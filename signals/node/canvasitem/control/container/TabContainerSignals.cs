namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.Container
{
    /// <summary>
    /// Contains constants for TabContainer signals.
    /// </summary>
    public static class TabContainerSignals
    {
        /// <summary>
        /// Emitted when the TabContainer's Popup button is clicked.
        /// </summary>
        public const string PRE_POPUP_PRESSED = "pre_popup_pressed";

        /// <summary>
        /// Emitted when switching to another tab.
        /// <list type="table">
        ///     <listheader>Parameters:</listheader>
        ///     <item>
        ///         <term>int tab</term>
        ///         <description>the index of the table</description>
        ///     </item>
        /// </list>
        /// </summary>
        public const string TAB_CHANGED = "tab_changed";

        /// <summary>
        /// Emitted when a tab is selected, even if it is the current tab.
        /// <list type="table">
        ///     <listheader>Parameters:</listheader>
        ///     <item>
        ///         <term>int tab</term>
        ///         <description>the index of the table</description>
        ///     </item>
        /// </list>
        /// </summary>
        public const string TAB_SELECTED = "tab_selected";
    }
}
