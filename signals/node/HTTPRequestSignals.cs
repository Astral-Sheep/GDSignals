namespace Com.Surbon.GDSignals.Node
{
	/// <summary>
	/// Contains constants for HTTPRequest signals.
	/// </summary>
	public static class HTTPRequestSignals
	{
		/// <summary>
		/// Emitted when a request is completed.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int result</term>
		///			<description>the result of the request</description>
		///		</item>
		///		<item>
		///			<term>int response_code</term>
		///			<description>the response code</description>
		///		</item>
		///		<item>
		///		    <term>PoolStringArray headers</term>
		///		    <description>the headers of the response</description>
		///     </item>
		///     <item>
		///         <term>PoolByteArray body</term>
		///         <description>the body of the response</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string COMPLETED = "request_completed";
	}
}
