namespace Com.Surbon.GDSignals.Node.CanvasItem.Control
{
	/// <summary>
	/// Contains constants for TextEdit signals.
	/// </summary>
	public static class TextEditSignals
	{
		/// <summary>
		/// Emitted when a breakpoint is placed via the breakpoint gutter.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int row</term>
		///			<description>the breakpoint's row</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BREAKPOINT_TOGGLED = "breakpoint_toggled";

		/// <summary>
		/// Emitted when the cursor changes.
		/// </summary>
		public const string CURSOR_CHANGED = "cursor_changed";

		/// <summary>
		/// Emitted when the info icon is clicked.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int row</term>
		///			<description>the info's row</description>
		///		</item>
		///		<item>
		///			<term>string info</term>
		///			<description>the info</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string INFO_CLICKED = "info_clicked";

		/// <summary>
		/// 
		/// </summary>
		public const string REQUEST_COMPLETION = "request_completion";

		/// <summary>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string symbol</term>
		///			<description></description>
		///		</item>
		///		<item>
		///			<term>int row</term>
		///			<description></description>
		///		</item>
		///		<item>
		///			<term>int column</term>
		///			<description></description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SYMBOL_LOOKUP = "symbol_lookup";

		/// <summary>
		/// Emitted when the text changes.
		/// </summary>
		public const string TEXT_CHANGED = "text_changed";
	}
}
