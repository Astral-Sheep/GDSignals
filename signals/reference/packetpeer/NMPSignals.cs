namespace Com.Surbon.GDSignals.Reference.PacketPeer
{
	/// <summary>
	/// Contains constants for NetworkMultiplayerPeer signals.
	/// </summary>
	public static class NMPSignals
	{
		/// <summary>
		/// Emitted when a connection attempt fails.
		/// </summary>
		public const string CONNECTION_FAILED = "connection_failed";

		/// <summary>
		/// Emitted when a connection attempt succeeds.
		/// </summary>
		public const string CONNECTION_SUCCEEDED = "connection_succeeded";

		/// <summary>
		/// Emitted by the server when a client connects.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>the client's id</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string PEER_CONNECTED = "peer_connected";

		/// <summary>
		/// Emitted by the server when a client disconnects.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>the client's id</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string PEER_DISCONNECTED = "peer_disconnected";

		/// <summary>
		/// Emitted by clients when the server disconnects.
		/// </summary>
		public const string SERVER_DISCONNECTED = "server_disconnected";
	}
}