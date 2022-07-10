namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.Popup.AcceptDialog.ConfirmationDialog
{
	/// <summary>
	/// Contains constants for EditorFileDialog signals
	/// </summary>
	public static class EditorFileDialogSignals
	{
		/// <summary>
		/// Emitted when a directory is selected.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string dir</term>
		///			<description>the name of the directory</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string DIR_SELECTED = "dir_selected";

		/// <summary>
		/// Emitted when a file is selected.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string path</term>
		///			<description>the path to the file</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string FILE_SELECTED = "file_selected";

		/// <summary>
		/// Emitted when multiple files are selected.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>PoolStringArray paths</term>
		///			<description>the paths to the files</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string FILES_SELECTED = "files_selected";
	}
}