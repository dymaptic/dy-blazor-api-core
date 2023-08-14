using dymaptic.GeoBlazor.Core.Sample.Shared.Pages;
using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;
using System.Diagnostics;

namespace dymaptic.GeoBlazor.Core.Test;

[TestClass]
public class ServerTests
{
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public async Task RunThroughAllTests()
    {
        try
        {
            StartServer();
            string? apiKey = new ConfigurationBuilder().AddUserSecrets<ServerTests>().Build()["ArcGISApiKey"];

            IPlaywright playwright = await Playwright.CreateAsync()!;
            IBrowser browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
            IPage page = await browser.NewPageAsync();
            page.Console += (_, e) =>
            {
#if DEBUG
                Console.WriteLine($"{DateTime.Now} {e.Type}: {e.Text}");
#endif
            };

            var renderMessage = new PageWaitForConsoleMessageOptions
            {
                Predicate = m => m.Text.Contains("View Render Complete"),
                Timeout = 60000
            };
            await Task.Delay(1000);
            Task waitForRenderTask = page.WaitForConsoleMessageAsync(renderMessage);

            // Go to http://localhost:5199/

            await page.GotoAsync("http://localhost:5199/");
            await Task.Delay(1000);

            await waitForRenderTask;

            // Click text=Draw a Point >> span
            await page.GetByText("Run All Tests").ClickAsync();

            //2 min delay to run tests
            await Task.Delay(120000);

            //ran the tests get back results
            if (await page.GetByText("Complete").CountAsync() > 0)
            {
                var tests = await page.GetByText("Failed: ").AllInnerTextsAsync();

                var errorList = tests.Where(x => !x.Equals("Failed: 0")).ToList();
                IReadOnlyList<string> errorMessages = new List<string>();

                if (errorList.Count > 0)
                {
                    errorMessages = await page.GetByText("Assert").AllTextContentsAsync();
                }

                var stacktrace = errorMessages.Aggregate("", (current, errorMessage) => current + ("\r\n" + errorMessage));

                Assert.IsTrue(tests.All(x => x.Equals("Failed: 0")), "Some of the test have failed:" + stacktrace);
            }
            else
            {
                Assert.IsTrue(false, "Test failed to complete in time");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            throw;
        }
        finally
        {
            StopServer();
        }
    }

    private void Page_Console(object? sender, IConsoleMessage e)
    {
        throw new NotImplementedException();
    }

    private static void StartServer()
    {
        var processStartInfo = new ProcessStartInfo("dotnet",
            "run --project ../../../../../test/dymaptic.GeoBlazor.Core.Test.Blazor.Server/dymaptic.GeoBlazor.Core.Test.Blazor.Server.csproj --no-build")
        {
            UseShellExecute = true
        };

        _serverProcess = Process.Start(processStartInfo);
        Assert.IsNotNull(_serverProcess);
    }

    private static void StopServer()
    {
        if (_serverProcess is not null && !_serverProcess.HasExited)
        {
            _serverProcess.CloseMainWindow();
            _serverProcess.Kill();
        }

        _serverProcess = null;
    }

    private static Process? _serverProcess;
    private readonly string _screenShotsFolder = "../../../ScreenShots";
}
