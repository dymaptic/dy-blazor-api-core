---
layout: default
title: TableListWidget
parent: Classes
---
#### [dymaptic.GeoBlazor.Core](index.html 'index')
### [dymaptic.GeoBlazor.Core.Components.Widgets](index.html#dymaptic.GeoBlazor.Core.Components.Widgets 'dymaptic.GeoBlazor.Core.Components.Widgets')

## TableListWidget Class

The TableList widget provides a way to display a list of tables associated with a Map. It is meant to be used with feature layer tables. The ListItem API provides access to each table, allows the developer to configure actions related to the table, and allows the developer to add content to the item related to the table.  
<a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-TableList.html">ArcGIS JS API</a>

```csharp
public class TableListWidget : dymaptic.GeoBlazor.Core.Components.Widgets.Widget
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Microsoft.AspNetCore.Components.ComponentBase](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Components.ComponentBase 'Microsoft.AspNetCore.Components.ComponentBase') &#129106; [MapComponent](dymaptic.GeoBlazor.Core.Components.MapComponent.html 'dymaptic.GeoBlazor.Core.Components.MapComponent') &#129106; [Widget](dymaptic.GeoBlazor.Core.Components.Widgets.Widget.html 'dymaptic.GeoBlazor.Core.Components.Widgets.Widget') &#129106; TableListWidget
### Properties

<a name='dymaptic.GeoBlazor.Core.Components.Widgets.TableListWidget.HasCustomHandler'></a>

## TableListWidget.HasCustomHandler Property

A convenience property that signifies whether a custom [OnListItemCreatedHandler](dymaptic.GeoBlazor.Core.Components.Widgets.TableListWidget.html#dymaptic.GeoBlazor.Core.Components.Widgets.TableListWidget.OnListItemCreatedHandler 'dymaptic.GeoBlazor.Core.Components.Widgets.TableListWidget.OnListItemCreatedHandler') was registered.

```csharp
public bool HasCustomHandler { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='dymaptic.GeoBlazor.Core.Components.Widgets.TableListWidget.IconClass'></a>

## TableListWidget.IconClass Property

The widget's default CSS icon class.

```csharp
public string? IconClass { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='dymaptic.GeoBlazor.Core.Components.Widgets.TableListWidget.Label'></a>

## TableListWidget.Label Property

The widget's default label.

```csharp
public string? Label { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='dymaptic.GeoBlazor.Core.Components.Widgets.TableListWidget.Layer'></a>

## TableListWidget.Layer Property

If a map contains feature layer tables, they will display within the widget. Tables  
can also be added to the map's tables collection. Any tables referenced in the map  
property will display in the widget. If unsure of whether the layer is a table,   
check the feature layer's isTable property.

```csharp
public dymaptic.GeoBlazor.Core.Components.Layers.Layer? Layer { get; set; }
```

#### Property Value
[Layer](dymaptic.GeoBlazor.Core.Components.Layers.Layer.html 'dymaptic.GeoBlazor.Core.Components.Layers.Layer')

<a name='dymaptic.GeoBlazor.Core.Components.Widgets.TableListWidget.Map'></a>

## TableListWidget.Map Property

A reference to a map containing the tables.

```csharp
public dymaptic.GeoBlazor.Core.Components.Map? Map { get; set; }
```

#### Property Value
[Map](dymaptic.GeoBlazor.Core.Components.Map.html 'dymaptic.GeoBlazor.Core.Components.Map')

<a name='dymaptic.GeoBlazor.Core.Components.Widgets.TableListWidget.OnListItemCreatedHandler'></a>

## TableListWidget.OnListItemCreatedHandler Property

A delegate to implement a custom handler for setting up each [ListItem](dymaptic.GeoBlazor.Core.Components.Widgets.LayerList.ListItem.html 'dymaptic.GeoBlazor.Core.Components.Widgets.LayerList.ListItem').  
Function must take in a ListItem and return a Task with the same (updated) item.

```csharp
public System.Func<dymaptic.GeoBlazor.Core.Components.Widgets.LayerList.ListItem,System.Threading.Tasks.Task<dymaptic.GeoBlazor.Core.Components.Widgets.LayerList.ListItem>>? OnListItemCreatedHandler { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[ListItem](dymaptic.GeoBlazor.Core.Components.Widgets.LayerList.ListItem.html 'dymaptic.GeoBlazor.Core.Components.Widgets.LayerList.ListItem')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ListItem](dymaptic.GeoBlazor.Core.Components.Widgets.LayerList.ListItem.html 'dymaptic.GeoBlazor.Core.Components.Widgets.LayerList.ListItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='dymaptic.GeoBlazor.Core.Components.Widgets.TableListWidget.TableItems'></a>

## TableListWidget.TableItems Property

The collection of table ListItems displayed within the widget..

```csharp
public System.Collections.Generic.List<dymaptic.GeoBlazor.Core.Components.Widgets.LayerList.ListItem>? TableItems { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[ListItem](dymaptic.GeoBlazor.Core.Components.Widgets.LayerList.ListItem.html 'dymaptic.GeoBlazor.Core.Components.Widgets.LayerList.ListItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='dymaptic.GeoBlazor.Core.Components.Widgets.TableListWidget.WidgetType'></a>

## TableListWidget.WidgetType Property

The type of widget

```csharp
public override string WidgetType { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
