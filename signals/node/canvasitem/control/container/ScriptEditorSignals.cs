namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.Container
{
	/// <summary>
	/// Contains constants for ScriptEditor signals.
	/// </summary>
	public static class ScriptEditorSignals
	{
		/// <summary>
		/// Emitted when user changed active script.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Script script</term>
		///			<description>a freshly activated Script</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string EDITOR_SCRIPT_CHANGED = "editor_script_changed";

		/// <summary>
		/// Emitted when editor is about to close the active script.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Script script</term>
		///			<description>a Script that is going to be closed</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SCRIPT_CLOSE = "script_close";
	}
}