using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using dymaptic.GeoBlazor.Core.Components.Widgets.LayerList;
using Microsoft.AspNetCore.Components;

namespace dymaptic.GeoBlazor.Core.Components.Widgets
{
    /// <summary>
    ///     The TableList widget provides a way to display a list of tables associated with a Map. It is meant to be used with feature layer tables. The ListItem API provides access to each table, allows the developer to configure actions related to the table, and allows the developer to add content to the item related to the table.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-TableList.html">ArcGIS JS API</a>
    /// </summary>
    public class TableListWidget : Widget
    {
        /// <inheritdoc />
        [JsonPropertyName("type")]
        public override string WidgetType => "tableList";

        /// <summary>
        ///     The widget's default CSS icon class.
        /// </summary>
        [Parameter]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? IconClass { get; set; }

        /// <summary>
        ///     The widget's default label.
        /// </summary>
        [Parameter]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Label { get; set; }

		/// <summary>
		///     A reference to a map containing the tables.
		/// </summary>
		[Parameter]
		[JsonIgnore]
		public Map? Map { get; set; }

        /// <summary>
        ///     The collection of table ListItems displayed within the widget..
        /// </summary>
 
        [Parameter]
		[JsonIgnore]
		public List<ListItem>? TableItems { get; set; }

		/// <summary>
		///     A delegate to implement a custom handler for setting up each <see cref="ListItem"/>.
		///     Function must take in a ListItem and return a Task with the same (updated) item.
		/// </summary>
		[Parameter]
        [JsonIgnore]
        public Func<ListItem, Task<ListItem>>? OnListItemCreatedHandler { get; set; }

		/// <summary>
		///     A convenience property that signifies whether a custom <see cref="OnListItemCreatedHandler"/> was registered.
		/// </summary>
		public bool HasCustomHandler => OnListItemCreatedHandler is not null;




	}
}
