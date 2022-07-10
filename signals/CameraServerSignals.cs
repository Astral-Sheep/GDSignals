namespace Com.Surbon.GDSignals
{
	/// <summary>
	/// Contains constants for CameraServer signals.
	/// </summary>
	public static class CameraServerSignals
	{
		/// <summary>
		/// Emitted when a CameraFeed is added (e.g. a webcam is plugged in).
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>the camera's id</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string FEED_ADDED = "camera_feed_added";

		/// <summary>
		/// Emitted when a CameraFeed is removed (e.g. a webcam is unplugged).
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>the camera's id</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string FEED_REMOVED = "camera_feed_removed";
	}
}