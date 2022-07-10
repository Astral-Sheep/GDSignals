namespace Com.Surbon.GDSignals.Node.CanvasItem.Node2D
{
	/// <summary>
	/// Contains constants for VisibilityNotifier2D signals.
	/// </summary>
	public static class VisibilityNotifier2DSignals
	{
		/// <summary>
		/// Emitted when the VisibilityNotifier2D enters the screen.
		/// </summary>
		public const string SCREEN_ENTERED = "screen_entered";

		/// <summary>
		/// Emitted when the VisibilityNotifier2D exits the screen.
		/// </summary>
		public const string SCREEN_EXITED = "screen_exited";

		/// <summary>
		/// Emitted when the VisibilityNotifier2D enters a Viewport's view.
		/// <list type="table">
		///     <listheader>Parameters:</listheader>
		///     <item>
		///         <term>Viewport viewport</term>
		///         <description>the entered viewport</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string VIEWPORT_ENTERED = "viewport_entered";

		/// <summary>
		/// Emitted when the VisibilityNotifier2D exits a Viewport's view.
		/// <list type="table">
		///     <listheader>Parameters:</listheader>
		///     <item>
		///         <term>Viewport viewport</term>
		///         <description>the exited viewport</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string VIEWPORT_EXITED = "viewport_exited";
	}
}
