namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.Popup.AcceptDialog
{
	/// <summary>
	/// Contains constants for AcceptDialog signals.
	/// </summary>
	public static class AcceptDialogSignals
	{
		/// <summary>
		/// Emitted when the dialog is accepted, i.e. the OK button is pressed.
		/// </summary>
		public const string CONFIRMED = "confirmed";

		/// <summary>
		/// Emitted when a custom button is pressed.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string action</term>
		///			<description>the name of the action</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string CUSTOM_ACTION = "custom_action";
	}
}
