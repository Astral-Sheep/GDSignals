namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.Popup
{
	/// <summary>
	/// Contains constants for PopupMenu signals.
	/// </summary>
	public static class PopupMenuSignals
	{
		/// <summary>
		/// Emitted when user navigated to an item of some id using ui_up or ui_down action.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>the item's id</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ID_FOCUSED = "id_focused";

		/// <summary>
		/// Emitted when an item of some id is pressed or its accelerator is activated.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>the item's id</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ID_PRESSED = "id_pressed";

		/// <summary>
		/// Emitted when an item of some index is pressed or its accelerator is activated.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int index</term>
		///			<description>the item's index</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string INDEX_PRESSED = "index_pressed";
	}
}
