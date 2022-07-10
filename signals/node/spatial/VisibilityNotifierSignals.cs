namespace Com.Surbon.GDSignals.Node.Spatial
{
	/// <summary>
	/// Contains constants for VisibilityNotifier signals.
	/// </summary>
	public static class VisibilityNotifierSignals
	{
		/// <summary>
		/// Emitted when the VisibilityNotifier enters a Camera's view.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Camera camera</term>
		///			<description>the entered camera</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string CAMERA_ENTERED = "camera_entered";

		/// <summary>
		/// Emitted when the VisibilityNotifier exits a Camera's view.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Camera camera</term>
		///			<description>the entered camera</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string CAMERA_EXITED = "camera_exited";

		/// <summary>
		/// Emitted when the VisibilityNotifier enters the screen.
		/// </summary>
		public const string SCREEN_ENTERED = "screen_entered";

		/// <summary>
		/// Emitted when the VisibilityNotifier exits the screen.
		/// </summary>
		public const string SCREEN_EXITED = "screen_exited";
	}
}
