namespace Com.Surbon.GDSignals.Node
{
	/// <summary>
	/// Contains constants for Viewport signals.
	/// </summary>
	public static class ViewportSignals
	{
		/// <summary>
		/// Emitted when a Control node grabs keyboard focus.
		/// <list type="table">
		///     <listheader>Parameters:</listheader>
		///     <item>
		///         <term>Control node</term>
		///         <description>the node which grabs the keyboard focus</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string FOCUS_CHANGED = "gui_focus_changed";

		/// <summary>
		/// Emitted when the size of the viewport is changed, whether by set_size_override, resize of window, or some other means.
		/// </summary>
		public const string SIZE_CHANGED = "size_changed";
	}
}
