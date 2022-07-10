namespace Com.Surbon.GDSignals.Reference.PacketPeer.WebSocketMultiplayerPeer
{
	/// <summary>
	/// Contains constants for WebSocketClient signals.
	/// </summary>
	public static class WSCSignals
	{
		/// <summary>
		/// Emitted when the connection to the server is closed.
		/// <list type="table">
		///     <listheader>Parameters:</listheader>
		///     <item>
		///         <term>bool was_clean_close</term>
		///         <description>will be true if the connection was shutdown cleanly</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string CONNECTION_CLOSED = "connection_closed";

		/// <summary>
		/// Emitted when the connection to the server fails.
		/// </summary>
		public const string CONNECTION_ERROR = "connection_error";

		/// <summary>
		/// Emitted when a connection with the server is established.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string protocol</term>
		///			<description>will contain the sub-protocol agreed with the server</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string CONNECTION_ESTABLISHED = "connection_established";

		/// <summary>
		/// Emitted when a WebSocket message is received.
		/// <para>
		/// Note: This signal is not emitted when used as high-level multiplayer peer.
		/// </para>
		/// </summary>
		public const string DATA_RECEIVED = "data_received";

		/// <summary>
		/// Emitted when the server requests a clean close.
		/// You should keep polling until you get a connection_closed signal to achieve the clean close.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int code</term>
		///			<description></description>
		///		</item>
		///		<item>
		///			<term>string reason</term>
		///			<description>the reason of the request</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SERVER_CLOSE_REQUEST = "server_close_request";
	}
}