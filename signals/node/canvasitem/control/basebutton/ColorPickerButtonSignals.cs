namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.BaseButton
{
	/// <summary>
	/// Contains constants for ColorPickerButton signals.
	/// </summary>
	public static class ColorPickerButtonSignals
	{
		/// <summary>
		/// Emitted when the color changes
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///		    <term>Color color</term>
		///		    <description>the color after the change</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string COLOR_CHANGED = "color_changed";

		/// <summary>
		/// Emitted when the ColorPicker is created (the button is pressed for the first time).
		/// </summary>
		public const string PICKER_CREATED = "picked_created";

		/// <summary>
		/// Emitted when the ColorPicker is closed.
		/// </summary>
		public const string POPUP_CLOSED = "popup_closed";
	}
}
