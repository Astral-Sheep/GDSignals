namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.BaseButton
{
	/// <summary>
	/// Contains constants for BaseButton signals.
	/// </summary>
	public static class BaseButtonSignals
	{
		/// <summary>
		/// Emitted when the button starts being held down.
		/// </summary>
		public const string DOWN = "button_down";

		/// <summary>
		/// Emitted when the button stops being held down.
		/// </summary>
		public const string UP = "button_up";

		/// <summary>
		/// Emitted when the button is toggled or pressed.
		/// This is on button_down if action_mode is ACTION_MODE_BUTTON_PRESS and on button_up otherwise.
		/// <para>
		///		If you need to know the button's pressed state (and toggle_mode is active), use toggled instead.
		/// </para>
		/// </summary>
		public const string PRESSED = "pressed";

		/// <summary>
		/// Emitted when the button was just toggled between pressed and normal states (only if toggle_mode is active).
		/// The new state is contained in the button_pressed argument.
		/// </summary>
		public const string TOGGLED = "toggled";
	}
}