namespace Com.Surbon.GDSignals.Node
{
	/// <summary>
	/// Contains constants for EditorPlugin signals.
	/// </summary>
	public static class EditorPluginSignals
	{
		/// <summary>
		/// Emitted when user changes the workspace (2D, 3D, Script, AssetLib). Also works with custom screens defined by plugins.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string screen_name</term>
		///			<description>the name of the screen</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string MAIN_SCREEN_CHANGED = "main_screen_changed";

		/// <summary>
		/// Emitted when a resource is saved.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Resource resource</term>
		///			<description>the saved resource</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string RESOURCE_SAVED = "resource_saved";
	}
}
