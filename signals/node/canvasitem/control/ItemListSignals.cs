namespace Com.Surbon.GDSignals.Node.CanvasItem.Control
{
	/// <summary>
	/// Contains constants for ItemList signals.
	/// </summary>
	public static class ItemListSignals
	{
		/// <summary>
		/// Triggered when specified list item is activated via double-clicking or by pressing Enter.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int index</term>
		///			<description>the index of the item</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ITEM_ACTIVATED = "item_activated";

		/// <summary>
		/// Triggered when specified list item has been selected via right mouse clicking.
		/// <para>
		/// The click position is also provided to allow appropriate popup of context menus at the correct location.
		/// </para>
		/// <para>
		/// allow_rmb_select must be enabled.
		/// </para>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int index</term>
		///			<description>the item index</description>
		///		</item>
		///		<item>
		///			<term>Vector2 at_position</term>
		///			<description>the click position</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ITEM_RMB_SELECTED = "item_rmb_selected";

		/// <summary>
		/// Triggered when specified item has been selected.
		/// <para>
		/// allow_reselect must be enabled to reselect an item.
		/// </para>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int index</term>
		///			<description>the index of the item</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ITEM_SELECTED = "item_selected";

		/// <summary>
		/// Triggered when a multiple selection is altered on a list allowing multiple selection.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int index</term>
		///			<description></description>
		///		</item>
		///		<item>
		///			<term>bool selected</term>
		///			<description></description>
		///		</item>
		/// </list>
		/// </summary>
		public const string MULTI_SELECTED = "multi_selected";

		/// <summary>
		/// Triggered when a left mouse click is issued within the rect of the list but on empty space.
		/// </summary>
		public const string NOTHING_SELECTED = "nothing_selected";

		/// <summary>
		/// Triggered when a right mouse click is issued within the rect of the list but on empty space.
		/// <para>
		/// allow_rmb_select must be enabled.
		/// </para>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Vector2 at_position</term>
		///			<description>the mouse position</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string RMB_CLICKED = "rmb_clicked";
	}
}
