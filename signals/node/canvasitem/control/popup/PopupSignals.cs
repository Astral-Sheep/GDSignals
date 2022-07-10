namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.Popup
{
	/// <summary>
	/// Contains constants for Popup signals.
	/// </summary>
	public static class PopupSignals
	{
		/// <summary>
		/// Emitted when a popup is about to be shown.
		/// This is often used in PopupMenu to clear the list of options then create a new one according to the current context.
		/// </summary>
		public const string ABOUT_TO_SHOW = "sort_children";

		/// <summary>
		/// Emitted when a popup is hidden.
		/// </summary>
		public const string HIDE = "popup_hide";
	}
}
