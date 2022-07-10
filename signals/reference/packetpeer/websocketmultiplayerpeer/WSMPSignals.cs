namespace Com.Surbon.GDSignals.Reference.PacketPeer.WebSocketMultiplayerPeer
{
	/// <summary>
    /// Contains constants for WebSocketMultiplayerPeer signals.
    /// </summary>
	public static class WSMPSignals
	{
		/// <summary>
		/// Emitted when a packet is received from a peer.
		/// <para>
		/// Note: This signal is only emitted when the client or server is configured to use Godot multiplayer API.
		/// </para>
        /// <list type="table">
        ///		<listheader>Parameters:</listheader>
        ///		<item>
        ///			<term>int peer_source</term>
        ///			<description>the peer's id</description>
        ///		</item>
        /// </list>
		/// </summary>
		public const string PEER_PACKET = "peer_packet";
	}
}