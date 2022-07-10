namespace Com.Surbon.GDSignals.Node
{
    /// <summary>
    /// Contains constants for EditorResourcePreview signals.
    /// </summary>
	public static class ERPreviewSignals
    {
        /// <summary>
        /// Emitted if a preview was invalidated (changed)
        /// <list type="table">
        ///     <listheader>Parameters:</listheader>
        ///     <item>
        ///         <term>string path</term>
        ///         <description>the path of the preview</description>
        ///     </item>
        /// </list>
        /// </summary>
        public const string PREVIEW_INVALIDATED = "preview_invalidated";
    }
}