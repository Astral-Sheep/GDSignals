namespace Com.Surbon.GDSignals.Node.Spatial
{
	/// <summary>
	/// Contains constants for ARVRController signals.
	/// </summary>
	public static class ARVRControllerSignals
	{
		/// <summary>
		/// Emitted when a button on this controller is pressed.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int button</term>
		///			<description>the index of the pressed button</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BUTTON_PRESSED = "button_pressed";

		/// <summary>
		/// Emitted when a button on this controller is released.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int button</term>
		///			<description>the index of the released button</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BUTTON_RELEASE = "button_release";

		/// <summary>
		/// Emitted when the mesh associated with the controller changes or when one becomes available.
		/// Generally speaking this will be a static mesh after becoming available.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Mesh mesh</term>
		///			<description>the updated mesh</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string MESH_UPDATED = "mesh_updated";
	}
}
