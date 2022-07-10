namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.Range
{
	/// <summary>
	/// Contains constants for Range signals.
	/// </summary>
	public static class RangeSignals
	{
		/// <summary>
		/// Emitted when min_value, max_value, page, or step change.
		/// </summary>
		public const string CHANGED = "changed";

		/// <summary>
		/// Emitted when value changes. When used on a Slider, this is called continuously while dragging (potentially every frame).
		/// If you are performing an expensive operation in a function connected to value_changed,
		/// consider using a debouncing Timer to call the function less often.
		/// <para>
		/// Note: Unlike signals such as LineEdit.text_changed, value_changed is also emitted when value is set directly via code.
		/// </para>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>float value</term>
		///			<description>the new value</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string VALUE_CHANGED = "value_changed";
	}
}
