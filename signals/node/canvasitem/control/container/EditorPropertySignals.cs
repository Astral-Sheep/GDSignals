namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.Container
{
	/// <summary>
	/// Contains constants for EditorProperty signals.
	/// </summary>
	public static class EditorPropertySignals
	{
		/// <summary>
		/// Emit it if you want multiple properties modified at the same time.
		/// Do not use if added via EditorInspectorPlugin.parse_property.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>PoolStringArray properties</term>
		///			<description></description>
		///		</item>
		///		<item>
		///			<term>Array value</term>
		///			<description></description>
		///		</item>
		/// </list>
		/// </summary>
		public const string MULTIPLE_PROPERTIES_CHANGED = "multiple_properties_changed";

		/// <summary>
		/// Used by sub-inspectors. Emit it if what was selected was an Object ID.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string property</term>
		///			<description></description>
		///		</item>
		///		<item>
		///			<term>int id</term>
		///			<description>the id of the object</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string OBJECT_ID_SELECTED = "object_id_selected";

		/// <summary>
		/// Do not emit this manually, use the emit_changed method instead.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string property</term>
		///			<description>the changed property</description>
		///		</item>
		///		<item>
		///			<term>Variant value</term>
		///			<description>the new value of the property</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string PROPERTY_CHANGED = "property_changed";

		/// <summary>
		/// Emitted when a property was checked. Used internally.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string property</term>
		///			<description>the checked property</description>
		///		</item>
		///		<item>
		///			<term>string bool</term>
		///			<description>says if the property was checked</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string PROPERTY_CHECKED = "property_checked";

		/// <summary>
		/// Emit it if you want to add this value as an animation key (check for keying being enabled first).
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string property</term>
		///			<description>the keyed property</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string PROPERTY_KEYED = "property_keyed";

		/// <summary>
		/// Emit it if you want to key a property with a single value.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string property</term>
		///			<description>the keyed property</description>
		///		</item>
		///		<item>
		///			<term>Variant value</term>
		///			<description>the value keyed to the property</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string PROPERTY_KEYED_WITH_VALUE = "property_keyed_with_value";

		/// <summary>
		/// If you want a sub-resource to be edited, emit this signal with the resource.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string path</term>
		///			<description>the path to the resource</description>
		///		</item>
		///		<item>
		///			<term>Resource resource</term>
		///			<description>the selected resource</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string RESOURCE_SELECTED = "resource_selected";

		/// <summary>
		/// Emitted when selected. Used internally.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string path</term>
		///			<description></description>
		///		</item>
		///		<item>
		///			<term>int focusable_idx</term>
		///			<description></description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SELECTED = "selected";
	}
}