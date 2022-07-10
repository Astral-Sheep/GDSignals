namespace Com.Surbon.GDSignals.Node.Spatial
{
	/// <summary>
	/// Contains constants for ARVRAnchor signals.
	/// </summary>
	public static class ARVRAnchorSignals
	{
		/// <summary>
		/// Emitted when the mesh associated with the anchor changes or when one becomes available.
		/// This is especially important for topology that is constantly being mesh_updated.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///		    <term>Mesh mesh</term>
		///		    <description>the updated mesh</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string MESH_UPDATED = "mesh_updated";
	}
}
