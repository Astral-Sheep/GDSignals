namespace Com.Surbon.GDSignals.Reference.Resource.VisualShaderNode
{
	/// <summary>
	/// Contains constants for VisualShaderNode signals.
	/// </summary>
	public static class VisualShaderNodeSignals
	{
		/// <summary>
		/// Emitted when the node requests an editor refresh.
		/// Currently called only in setter of VisualShaderNodeTexture.source, VisualShaderNodeTexture,
		/// and VisualShaderNodeCubeMap (and their derivatives).
		/// </summary>
		public const string EDITOR_REFRESH_REQUEST = "editor_refresh_request";
	}
}