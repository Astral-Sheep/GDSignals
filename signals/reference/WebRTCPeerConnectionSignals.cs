namespace Com.Surbon.GDSignals.Reference
{
	/// <summary>
	/// Contains constants for WebRTCPeerConnection signals.
	/// </summary>
	public static class WebRTCPeerConnectionSignals
	{
		/// <summary>
		/// Emitted when a new in-band channel is received, i.e. when the channel was created with negotiated: false (default).
		/// <para>
		/// The object will be an instance of WebRTCDataChannel.
		/// You must keep a reference of it or it will be closed automatically.
		/// </para>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Object channel</term>
		///			<description>the received channel</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string DATA_CHANNEL_RECEIVED = "data_channel_received";
	}
}