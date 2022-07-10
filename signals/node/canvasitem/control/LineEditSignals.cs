namespace Com.Surbon.GDSignals.Node.CanvasItem.Control
{
	/// <summary>
	/// Contains constants for LineEdit signals.
	/// </summary>
	public static class LineEditSignals
	{
		/// <summary>
		/// Emitted when appending text that overflows the max_length.
		/// The appended text is truncated to fit max_length, and the part that couldn't fit is passed as the rejected_substring argument.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string rejected_substring</term>
		///			<description>the rejected part of the string</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string TEXT_CHANGE_REJECTED = "text_change_rejected";

		/// <summary>
		/// Emitted when the text changes.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string new_text</term>
		///			<description>the new text</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string TEXT_CHANGED = "text_changed";

		/// <summary>
		/// Emitted when the user presses @GlobalScope.KEY_ENTER on the LineEdit.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string new_text</term>
		///			<description>the entered text</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string TEXT_ENTERED = "text_entered";
	}
}
