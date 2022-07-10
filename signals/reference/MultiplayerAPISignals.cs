namespace Com.Surbon.GDSignals.Reference
{
	/// <summary>
	/// Contains constants for MultiplayerAPI signals.
	/// </summary>
	public static class MultiplayerAPISignals
	{
		/// <summary>
		/// Emitted when this MultiplayerAPI's network_peer successfully connected to a server. Only emitted on clients.
		/// </summary>
		public const string CONNECTED_TO_SERVER = "connected_to_server";

		/// <summary>
		/// Emitted when this MultiplayerAPI's network_peer fails to establish a connection to a server. Only emitted on clients.
		/// </summary>
		public const string CONNECTION_FAILED = "connection_failed";

		/// <summary>
		/// Emitted when this MultiplayerAPI's network_peer connects with a new peer.
		/// Clients get notified when other clients connect to the same server.
		/// Upon connecting to a server, a client also receives this signal for the server (with ID being 1).
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>the peer ID of the new peer</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string NETWORK_PEER_CONNECTED = "network_peer_connected";

		/// <summary>
		/// Emitted when this MultiplayerAPI's network_peer disconnects from a peer.
		/// Clients get notified when other clients disconnect from the same server.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>the peer ID of the disconnected peer</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string NETWORK_PEER_DISCONNECTED = "network_peer_disconnected";

		/// <summary>
		/// Emitted when this MultiplayerAPI's network_peer receive a packet with custom data.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>the peer ID of the peer that sent the packet</description>
		///		</item>
		///		<item>
		///			<term>PoolByteArray packet</term>
		///			<description>the sent packet</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string NETWORK_PEER_PACKET = "newtork_peer_packet";

		/// <summary>
		/// Emitted when this MultiplayerAPI's network_peer disconnects from server. Only emitted on clients.
		/// </summary>
		public const string SERVER_DISCONNECTED = "server_disconnected";
	}
}