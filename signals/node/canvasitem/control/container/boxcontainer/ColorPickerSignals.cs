namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.Container.BoxContainer
{
	/// <summary>
	/// Contains constants for ColorPicker signals.
	/// </summary>
	public static class ColorPickerSignals
	{
		/// <summary>
		/// Emitted when the color is changed.
		/// <list type="table">
		///     <listheader>Parameters:</listheader>
		///     <item>
		///         <term>Color color</term>
		///         <description>the color after the change</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string COLOR_CHANGED = "color_changed";

		/// <summary>
		/// Emitted when a preset is added.
		/// <list type="table">
		///     <listheader>Parameters:</listheader>
		///     <item>
		///         <term>Color color</term>
		///         <description>the preset color</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string PRESET_ADDED = "preset_added";

		/// <summary>
		/// Emitted when a preset is removed.
		/// <list type="table">
		///     <listheader>Parameters:</listheader>
		///     <item>
		///         <term>Color color</term>
		///         <description>the preset color</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string PRESET_REMOVED = "preset_removed";
	}
}
