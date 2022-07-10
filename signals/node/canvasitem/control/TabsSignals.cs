namespace Com.Surbon.GDSignals.Node.CanvasItem.Control
{
	/// <summary>
	/// Contains constants for Tabs signals.
	/// </summary>
	public static class TabsSignals
	{
		/// <summary>
		/// Emitted when the active tab is rearranged via mouse drag.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int idx_to</term>
		///			<description>the tab's targeted index</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string REPOSITION_ACTIVE_TAB_REQUEST = "reposition_active_tab_request";

		/// <summary>
		/// Emitted when a tab is right-clicked.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int tab</term>
		///			<description>the clicked tab</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string RIGHT_BUTTON_PRESSED = "right_button_pressed";

		/// <summary>
		/// Emitted when switching to another tab.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int tab</term>
		///			<description>the current tab</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string CHANGED = "tab_changed";

		/// <summary>
		/// Emitted when a tab is clicked, even if it is the current tab.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int tab</term>
		///			<description>the clicked tab</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string CLICKED = "tab_clicked";

		/// <summary>
		/// Emitted when a tab is closed.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int tab</term>
		///			<description>the closed tab</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string CLOSE = "tab_close";

		/// <summary>
		/// Emitted when a tab is hovered by the mouse.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int tab</term>
		///			<description>the hovered tab</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string HOVER = "tab_hover";
	}
}
