namespace dymaptic.GeoBlazor.Core.Extensions;

internal static class StringExtensions
{
    public static string ToLowerFirstChar(this string val)
    {
        return string.Create(val.Length, val, (span, txt) =>
        {
            span[0] = char.ToLower(txt[0]);

            for (var i = 1; i < txt.Length; i++)
            {
                span[i] = txt[i];
            }
        });
    }

    public static string ToKebabCase(this string val)
    {
        bool usesUnderscores = val.Contains('_');
        int length = usesUnderscores ? val.Length : val.Length + (val.Count(char.IsUpper) - 1);
        return string.Create(length, val, (span, txt) =>
        {
            var offset = 0;
            
            for (var i = 0; i < txt.Length; i++)
            {
                char c = txt[i];

                if (c == '_')
                {
                    usesUnderscores = true;
                    span[i + offset] = '-';
                }
                else if (char.IsUpper(c))
                {
                    if (!usesUnderscores && i > 0)
                    {
                        span[i + offset] = '-';
                        offset++;
                    }

                    span[i + offset] = char.ToLower(c);
                }
                else
                {
                    span[i + offset] = c;
                }
            }
        });
    }
}