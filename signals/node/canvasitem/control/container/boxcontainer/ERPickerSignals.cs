namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.Container.BoxContainer
{
	/// <summary>
	/// Contains constants for EditorResourcePicker signals.
	/// </summary>
	public static class ERPickerSignals
	{
		/// <summary>
		/// Emitted when the value of the edited resource was changed.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Resource resource</term>
		///			<description>the changed resource</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string RESOURCE_CHANGED = "resource_changed";

		/// <summary>
		/// Emitted when the resource value was set and user clicked to edit it.
		/// When edit is true, the signal was caused by the context menu "Edit" option.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Resource resource</term>
		///			<description>the resource selected</description>
		///		</item>
		///		<item>
		///			<term>bool edit</term>
		///			<description>says if the signals was cause by the "Edit" option</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string RESOURCE_SELECTED = "resource_selected";
	}
}