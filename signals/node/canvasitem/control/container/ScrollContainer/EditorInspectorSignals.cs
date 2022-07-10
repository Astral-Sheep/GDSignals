namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.Container.ScrollContainer
{
	/// <summary>
	/// Contains constants for EditorInspector signals.
	/// </summary>
	public static class EditorInspectorSignals
	{
		/// <summary>
		/// Emitted when the Edit button of an Object has been pressed in the inspector. This is mainly used in the remote scene tree inspector.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>the id of the selected object</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string OBJECT_ID_SELECTED = "object_id_selected";

		/// <summary>
		/// Emitted when a property is edited in the inspector.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string property</term>
		///			<description>the edited property</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string PROPERTY_EDITED = "property_edited";

		/// <summary>
		/// Emitted when a property is keyed in the inspector.
		/// Properties can be keyed by clicking the "key" icon next to a property when the Animation panel is toggled.
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
		/// Emitted when a property is selected in the inspector.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string property</term>
		///			<description>the selected property</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string PROPERTY_SELECTED = "property_selected";

		/// <summary>
		/// Emitted when a boolean property is toggled in the inspector.
		/// <para>
		/// Note: This signal is never emitted if the internal autoclear property enabled. 
		/// Since this property is always enabled in the editor inspector, this signal is never emitted by the editor itself.
		/// </para>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string property</term>
		///			<description>the toggled property</description>
		///		</item>
		///		<item>
		///			<term>bool checked</term>
		///			<description>the toggle state</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string PROPERTY_TOGGLED = "property_toggled";

		/// <summary>
		/// Emitted when a resource is selected in the inspector.
		/// <list type="table">
		///		<listheader>Paramaters:</listheader>
		///		<item>
		///			<term>Object res</term>
		///			<description>the selected resource</description>
		///		</item>
		///		<item>
		///			<term>string prop</term>
		///			<description></description>
		///		</item>
		/// </list>
		/// </summary>
		public const string RESOURCE_SELECTED = "resource_selected";

		/// <summary>
		/// Emitted when a property that requires a restart to be applied is edited in the inspector.
		/// This is only used in the Project Settings and Editor Settings.
		/// </summary>
		public const string RESTART_REQUESTED = "restart_requested";
	}
}