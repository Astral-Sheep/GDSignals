namespace Com.Surbon.GDSignals.Node
{
	/// <summary>
	/// Contains constants for EditorFileSystem signals.
	/// </summary>
	public static class EditorFileSystemSignals
	{
		/// <summary>
		/// Emitted if the filesystem changed.
		/// </summary>
		public const string FILE_SYSTEM_CHANGED = "filesystem_changed";

		/// <summary>
		/// Emitted if a resource is reimported.
		/// <list type="table">
		///     <listheader>Parameters:</listheader>
		///     <item>
		///         <term>PoolStringArray resources</term>
		///         <description>the reimported resources</description>
		///     </item>
		/// </list>
		/// </summary>
		public const string RESOURCES_REIMPORTED = "resources_reimported";

		/// <summary>
		/// Emitted if at least one resource is reloaded when the filesystem is scanned.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>PoolStringArray resources</term>
		///			<description>the reloaded resources</description>
		///		</item>
		///		</list>
		/// </summary>
		public const string RESOURCES_RELOAD = "resources_reload";

		/// <summary>
		/// Emitted if the source of any imported file changed.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>bool exist</term>
		///			<description>says if the source exists</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SOURCES_CHANGED = "sources_changed";
	}
}