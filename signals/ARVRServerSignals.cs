namespace Com.Surbon.GDSignals
{
	/// <summary>
	/// Contains constants for ARVRServer signals.
	/// </summary>
	public static class ARVRServerSignals
	{
		/// <summary>
		/// Emitted when a new interface has been added.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string interface_name</term>
		///			<description>the interface's name</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string INTERFACE_ADDED = "interface_added";

		/// <summary>
		/// Emitted when an interface is removed.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string interface_name</term>
		///			<description>the interface's name</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string INTERFACE_REMOVED = "interface_removed";

		/// <summary>
		/// Emitted when a new tracker has been added.
		/// If you don't use a fixed number of controllers or if you're using ARVRAnchors for an AR solution,
		/// it is important to react to this signal to add the appropriate ARVRController or ARVRAnchor nodes related to this new tracker.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string tracker_name</term>
		///			<description>the tracker's name</description>
		///		</item>
		///		<item>
		///			<term>int type</term>
		///			<description>the tracker's type</description>
		///		</item>
		///		<item>
		///			<term>int id</term>
		///			<description>the tracker's id</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string TRACKER_ADDED = "tracker_added";

		/// <summary>
		/// Emitted when a tracker is removed.
		/// You should remove any ARVRController or ARVRAnchor points if applicable.
		/// This is not mandatory, the nodes simply become inactive and will be made active again when a new tracker becomes available
		/// (i.e. a new controller is switched on that takes the place of the previous one).
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string tracker_name</term>
		///			<description>the tracker's name</description>
		///		</item>
		///		<item>
		///			<term>int type</term>
		///			<description>the tracker's type</description>
		///		</item>
		///		<item>
		///			<term>int id</term>
		///			<description>the tracker's id</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string TRACKER_REMOVED = "tracker_removed";
	}
}
