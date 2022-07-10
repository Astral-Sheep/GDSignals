namespace Com.Surbon.GDSignals.Node.Spatial
{
	/// <summary>
	/// Contains constants for Spatial signals.
	/// </summary>
	public static class SpatialSignals
	{
		/// <summary>
		/// Emitted by portal system gameplay monitor when a node enters the gameplay area.
		/// </summary>
		public const string GAMEPLAY_ENTERED = "gameplay_entered";

		/// <summary>
		/// Emitted by portal system gameplay monitor when a node exits the gameplay area.
		/// </summary>
		public const string GAMEPLAY_EXITED = "gameplay_exited";

		/// <summary>
		/// Emitted when node visibility changes.
		/// </summary>
		public const string VISIBILITY_CHANGED = "visibility_changed";
	}
}
