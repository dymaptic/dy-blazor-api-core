﻿using dymaptic.GeoBlazor.Core.Components.Geometries;
using dymaptic.GeoBlazor.Core.Exceptions;
using dymaptic.GeoBlazor.Core.Model;
using dymaptic.GeoBlazor.Core.Objects;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;


namespace dymaptic.GeoBlazor.Tests.Blazor.Components;

public class GeometryEngineTests: TestRunnerBase
{
    [Inject]
    public GeometryEngine GeometryEngine { get; set; } = default!;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }

    [TestMethod]
    public async Task TestBufferWithProjectedPoint()
    {
        Point point = new Point(0, 0, spatialReference: new SpatialReference(103002));
        Polygon buffer = await GeometryEngine.Buffer(point, 10.0, LinearUnit.Feet);
        Assert.IsNotNull(buffer);
    }

    [TestMethod]
    public async Task TestBufferWithWgs84PointThrowsJavaScriptError()
    {
        Point point = new Point(0, 0, spatialReference: new SpatialReference(4326));
        await Assert.ThrowsExceptionAsync<JSException>(() => GeometryEngine.Buffer(point, 10.0, LinearUnit.Feet));
    }
    
    [TestMethod]
    public async Task TestBufferWithMultipleProjectedPoints()
    {
        Point point1 = new Point(0, 0, spatialReference: new SpatialReference(103002));
        Point point2 = new Point(10, 10, spatialReference: new SpatialReference(103002));
        Polygon[] buffers = await GeometryEngine.Buffer(new[] {point1, point2}, new[] {10.0, 20.0}, LinearUnit.Feet);
        Assert.IsNotNull(buffers);
        Assert.AreEqual(2, buffers.Length);
    }
    
    [TestMethod]
    public async Task TestBufferWithMultipleProjectedPointsUnioned()
    {
        Point point1 = new Point(0, 0, spatialReference: new SpatialReference(103002));
        Point point2 = new Point(10, 10, spatialReference: new SpatialReference(103002));
        Polygon[] buffers = await GeometryEngine.Buffer(new[] {point1, point2}, new[] {10.0, 20.0}, LinearUnit.Feet, true);
        Assert.IsNotNull(buffers);
        Assert.AreEqual(1, buffers.Length);
    }

    [TestMethod]
    public async Task TestClip()
    {
        Polygon boundaryPolygon = new Polygon(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(0, 0),
                new MapPoint(0, 10),
                new MapPoint(10, 10),
                new MapPoint(10, 0),
                new MapPoint(0, 0)
            }
        }, spatialReference: new SpatialReference(103002));
        
        Extent envelope = new Extent(-5, 5, -15, 15, spatialReference: new SpatialReference(103002));
        
        Polygon clippedPolygon = (Polygon)(await GeometryEngine.Clip(boundaryPolygon, envelope))!;
        Assert.IsNotNull(clippedPolygon);
    }
    
    [TestMethod]
    public async Task TestClipNoOverlapReturnsNull()
    {
        Polygon boundaryPolygon = new Polygon(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(0, 0),
                new MapPoint(0, 10),
                new MapPoint(10, 10),
                new MapPoint(10, 0),
                new MapPoint(0, 0)
            }
        }, spatialReference: new SpatialReference(103002));
        
        Extent envelope = new Extent(5, 5, 15, 15, spatialReference: new SpatialReference(103002));
        
        Polygon? clippedPolygon = (await GeometryEngine.Clip(boundaryPolygon, envelope)) as Polygon;
        Assert.IsNull(clippedPolygon);
    }

    [TestMethod]
    public async Task TestContainsTrue()
    {
        Polygon boundaryPolygon = new Polygon(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(0, 0),
                new MapPoint(0, 10),
                new MapPoint(10, 10),
                new MapPoint(10, 0),
                new MapPoint(0, 0)
            }
        }, spatialReference: new SpatialReference(103002));
        Point point = new Point(5, 5, spatialReference: new SpatialReference(103002));
        
        bool contains = await GeometryEngine.Contains(boundaryPolygon, point);
        Assert.IsTrue(contains);
    }

    [TestMethod]
    public async Task TestContainsFalse()
    {
        Polygon boundaryPolygon = new Polygon(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(0, 0),
                new MapPoint(0, 10),
                new MapPoint(10, 10),
                new MapPoint(10, 0),
                new MapPoint(0, 0)
            }
        }, spatialReference: new SpatialReference(103002));
        Point point = new Point(15, 15, spatialReference: new SpatialReference(103002));
        
        bool contains = await GeometryEngine.Contains(boundaryPolygon, point);
        Assert.IsFalse(contains);
    }

    [TestMethod]
    public async Task TestConvexHull()
    {
        Point point = new Point(0, 0, spatialReference: new SpatialReference(103002));
        
        Geometry convexHull = await GeometryEngine.ConvexHull(point);
        Assert.IsInstanceOfType<Point>(convexHull);
    }
    
    [TestMethod]
    public async Task TestConvexHullMultiplePoints()
    {
        List<Point> points = new();
        for (int i = 0; i < 10; i++)
        {
            points.Add(new Point(i, i, spatialReference: new SpatialReference(103002)));
        }
        
        Geometry[] convexHull = await GeometryEngine.ConvexHull(points);
        Assert.IsInstanceOfType<Point>(convexHull[0]);
        Assert.AreEqual(10, convexHull.Length);
    }

    [TestMethod]
    public async Task TestConvexHullMerged()
    {
        List<Point> points = new();
        for (int i = 0; i < 10; i++)
        {
            points.Add(new Point(i, i, spatialReference: new SpatialReference(103002)));
        }
        
        Geometry[] convexHull = await GeometryEngine.ConvexHull(points, true);
        Assert.IsInstanceOfType<Polygon>(convexHull[0]);
        Assert.AreEqual(1, convexHull.Length);
    }

    [TestMethod]
    public async Task TestCrossesTrue()
    {
        PolyLine polyline1 = new PolyLine(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(0, 0),
                new MapPoint(10, 10)
            }
        }, spatialReference: new SpatialReference(103002));
        
        PolyLine polyline2 = new PolyLine(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(0, 10),
                new MapPoint(10, 0)
            }
        }, spatialReference: new SpatialReference(103002));
        
        bool crosses = await GeometryEngine.Crosses(polyline1, polyline2);
        
        Assert.IsTrue(crosses);
    }

    [TestMethod]
    public async Task TestCrossesFalse()
    {
        PolyLine polyline1 = new PolyLine(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(0, 0),
                new MapPoint(10, 10)
            }
        }, spatialReference: new SpatialReference(103002));
        
        PolyLine polyline2 = new PolyLine(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(10, 0),
                new MapPoint(20, 0)
            }
        }, spatialReference: new SpatialReference(103002));
        
        bool crosses = await GeometryEngine.Crosses(polyline1, polyline2);
        
        Assert.IsFalse(crosses);
    }

    [TestMethod]
    public async Task TestCut()
    {
        Polygon polygon = new Polygon(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(0, 0),
                new MapPoint(10, 0),
                new MapPoint(10, 10),
                new MapPoint(0, 10),
                new MapPoint(0, 0)
            }
        }, spatialReference: new SpatialReference(103002));
        
        PolyLine cutter = new PolyLine(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(5, -5),
                new MapPoint(5, 15)
            }
        }, spatialReference: new SpatialReference(103002));
        
        Geometry[] cut = await GeometryEngine.Cut(polygon, cutter);
        
        Assert.AreEqual(2, cut.Length);
    }

    [TestMethod]
    public async Task TestCutNotIntersectedReturnsEmpty()
    {
        Polygon polygon = new Polygon(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(0, 0),
                new MapPoint(10, 0),
                new MapPoint(10, 10),
                new MapPoint(0, 10),
                new MapPoint(0, 0)
            }
        }, spatialReference: new SpatialReference(103002));
        
        PolyLine cutter = new PolyLine(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(-5, -5),
                new MapPoint(-5, -15)
            }
        }, spatialReference: new SpatialReference(103002));
        
        Geometry[] cut = await GeometryEngine.Cut(polygon, cutter);
        
        Assert.AreEqual(0, cut.Length);
    }

    [TestMethod]
    public async Task TestDensify()
    {
        Polygon boundaryPolygon = new Polygon(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(0, 0),
                new MapPoint(0, 10),
                new MapPoint(10, 10),
                new MapPoint(10, 0),
                new MapPoint(0, 0)
            }
        }, spatialReference: new SpatialReference(103002));
        
        Geometry densifiedPolygon = await GeometryEngine.Densify(boundaryPolygon, 1, LinearUnit.Feet);
        
        Assert.AreNotEqual(boundaryPolygon, densifiedPolygon);
    }

    [TestMethod]
    public async Task TestDifference()
    {
        Polygon boundaryPolygon = new Polygon(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(0, 0),
                new MapPoint(0, 10),
                new MapPoint(10, 10),
                new MapPoint(10, 0),
                new MapPoint(0, 0)
            }
        }, spatialReference: new SpatialReference(103002));
        Polygon subtractor = new Polygon(new MapPath[]
        {
            new MapPath
            {
                new MapPoint(5, 5),
                new MapPoint(5, 15),
                new MapPoint(15, 15),
                new MapPoint(15, 5),
                new MapPoint(5, 5)
            }
        }, spatialReference: new SpatialReference(103002));
        
        Geometry difference = await GeometryEngine.Difference(boundaryPolygon, subtractor);
        Assert.AreNotEqual(boundaryPolygon, difference);
    }
}