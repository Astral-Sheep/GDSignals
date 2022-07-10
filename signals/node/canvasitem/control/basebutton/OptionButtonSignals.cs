namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.BaseButton
{
	/// <summary>
	/// Contains constants for OptionButton signals.
	/// </summary>
	public static class OptionButtonSignals
	{
		/// <summary>
		/// Emitted when the user navigates to an item using the ui_up or ui_down actions.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int index</term>
		///			<description>the index of the item selected</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ITEM_FOCUSED = "item_focused";

		/// <summary>
		/// Emitted when the current item has been changed by the user.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int index</term>
		///			<description>the index of the item selected</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ITEM_SELECTED = "item_selected";
	}
}
