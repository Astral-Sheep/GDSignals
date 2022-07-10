namespace Com.Surbon.GDSignals
{
	/// <summary>
	/// Contains constants for Input signals.
	/// </summary>
	public static class InputSignals
	{
		/// <summary>
		/// Emitted when a joypad device has been connected or disconnected.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///		    <term>int device</term>
		///		    <description>the device's index</description>
		///     </item>
		///     <item>
		///         <term>bool connected</term>
		///         <description>says if the device is connected</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string JOY_CONNECTION_CHANGED = "joy_connection_changed";
	}
}