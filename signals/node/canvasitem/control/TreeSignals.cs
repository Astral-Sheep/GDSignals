namespace Com.Surbon.GDSignals.Node.CanvasItem.Control
{
	/// <summary>
	/// Contains constants for Tree signals.
	/// </summary>
	public static class TreeSignals
	{
		/// <summary>
		/// Emitted when a button on the tree was pressed
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>TreeItem item</term>
		///			<description>the pressed button</description>
		///		</item>
		///		<item>
		///			<term>int column</term>
		///			<description>the button's column</description>
		///		</item>
		///		<item>
		///			<term>int id</term>
		///			<description>the button's id</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BUTTON_PRESSED = "button_pressed";

		/// <summary>
		/// Emitted when a cell is selected.
		/// </summary>
		public const string CELL_SELECTED = "cell_selected";

		/// <summary>
		/// Emitted when a column's title is pressed.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int column</term>
		///			<description>the column</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string COLUMN_TITLE_PRESSED = "column_title_pressed";

		/// <summary>
		/// Emitted when a cell with the TreeItem.CELL_MODE_CUSTOM is clicked to be edited.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>bool array_clicked</term>
		///			<description></description>
		///		</item>
		/// </list>
		/// </summary>
		public const string CUSTOM_POPUP_EDITED = "custom_popup_edited";

		/// <summary>
		/// Emitted when the right mouse button is pressed in the empty space of the tree.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Vector2 position</term>
		///			<description>the mouse's position</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string EMPTY_RMB = "empty_rmb";

		/// <summary>
		/// Emitted when the right mouse button is pressed if right mouse button selection is active and the tree is empty.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Vector2 position</term>
		///			<description>the mouse's position</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string EMPTY_RMB_SELECTED = "empty_tree_rmb_selected";

		/// <summary>
		/// Emitted when an item's label is double-clicked.
		/// </summary>
		public const string ITEM_ACTIVATED = "item_activated";

		/// <summary>
		/// Emitted when an item is collapsed by a click on the folding arrow.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>TreeItem item</term>
		///			<description>the collapsed item</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ITEM_COLLAPSED = "item_collapsed";

		/// <summary>
		/// Emitted when a custom button is pressed (i.e. in a TreeItem.CELL_MODE_CUSTOM mode cell).
		/// 
		/// </summary>
		public const string ITEM_CUSTOM_BUTTON_PRESSED = "item_custom_button_pressed";

		/// <summary>
		/// Emitted when an item's icon is double-clicked.
		/// </summary>
		public const string ITEM_DOUBLE_CLICKED = "item_double_clicked";

		/// <summary>
		/// Emitted when an item is edited.
		/// </summary>
		public const string ITEM_EDITED = "item_edited";

		/// <summary>
		/// Emitted when an item is edited using the right mouse button.
		/// </summary>
		public const string ITEM_RMB_EDITED = "item_rmb_edited";

		/// <summary>
		/// Emitted when an item is selected with the right mouse button.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Vector2 position</term>
		///			<description>the mouse's position</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ITEM_RMB_SELECTED = "item_rmb_selected";

		/// <summary>
		/// Emitted when an item is selected.
		/// </summary>
		public const string ITEM_SELECTED = "item_selected";

		/// <summary>
		/// Emitted instead of item_selected if select_mode is SELECT_MULTI
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>TreeItem item</term>
		///			<description>the selected item</description>
		///		</item>
		///		<item>
		///			<term>int column</term>
		///			<description>the item's column</description>
		///		</item>
		///		<item>
		///			<term>bool selected</term>
		///			<description>the selected state of the item</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string MULTI_SELECTED = "multi_selected";

		/// <summary>
		/// Emitted when a left mouse button click does not select any item.
		/// </summary>
		public const string NOTHING_SELECTED = "nothing_selected";
	}
}
