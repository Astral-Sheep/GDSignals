namespace Com.Surbon.GDSignals.MainLoop
{
	/// <summary>
	/// Contains constants for MainLoop signals.
	/// </summary>
	public static class MainLoopSignals
	{
		/// <summary>
		/// Emitted when a user responds to a permission request.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string permission</term>
		///			<description>the requested permission</description>
		///		</item>
		///		<item>
		///		    <term>bool granted</term>
		///		    <description>says if the permission has been granted</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string ON_REQUEST_PERMISSION_RESULT = "on_request_permission_result";
	}
}