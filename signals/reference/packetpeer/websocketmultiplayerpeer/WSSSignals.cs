namespace Com.Surbon.GDSignals.Reference.PacketPeer.WebSocketMultiplayerPeer
{
	/// <summary>
	/// Contains constants for WebSocketServer signals.
	/// </summary>
	public static class WSSSignals
	{
		/// <summary>
		/// Emitted when a client requests a clean close.
		/// You should keep polling until you get a client_disconnected signal with the same id to achieve the clean close.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>client id</description>
		///		</item>
		///		<item>
		///			<term>int code</term>
		///			<description></description>
		///		</item>
		///		<item>
		///		    <term>string reason</term>
		///		    <description>the reason of the request</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string CLOSE_REQUEST = "client_close_request";

		/// <summary>
		/// Emitted when a new client connects.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>client id</description>
		///		</item>
		///		<item>
		///			<term>string protocol</term>
		///			<description>will be the sub-protocol agreed with the client</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string CONNECTED = "client_connected";

		/// <summary>
		/// Emitted when a client disconnects.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>client id</description>
		///		</item>
		///		<item>
		///			<term>bool was_clean_close</term>
		///			<description>will be true if the connection was shutdown cleanly</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string DISCONNECTED = "client_disconnected";

		/// <summary>
		/// Emitted when a new message is received.
		/// <para>
		/// Note: This signal is not emitted when used as high-level multiplayer peer.
		/// </para>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>client id</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string DATA_RECEIVED = "data_received";
	}
}