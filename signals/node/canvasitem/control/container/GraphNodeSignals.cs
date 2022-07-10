namespace Com.Surbon.GDSignals.Node.CanvasItem.Control.Container
{
	/// <summary>
	/// Contains constants for GraphNode signals.
	/// </summary>
	public static class GraphNodeSignals
	{
		/// <summary>
		/// Emitted when the GraphNode is requested to be closed. Happens on clicking the close button (see show_close).
		/// </summary>
		public const string CLOSE_REQUEST = "close_request";

		/// <summary>
		/// Emitted when the GraphNode is dragged.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Vector2 from</term>
		///			<description>the initial position</description>
		///		</item>
		///		<item>
		///			<term>Vector2 to</term>
		///			<description>the final position</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string DRAGGED = "dragged";

		/// <summary>
		/// Emitted when the GraphNode is moved.
		/// </summary>
		public const string OFFSET_CHANGED = "offset_changed";

		/// <summary>
		/// Emitted when the GraphNode is requested to be displayed over other ones. Happens on focusing (clicking into) the GraphNode.
		/// </summary>
		public const string RAISE_REQUEST = "raise_request";

		/// <summary>
		/// Emitted when the GraphNode is requested to be resized. Happens on dragging the resizer handle.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Vector2 new_minsize</term>
		///			<description>the new minimum size</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string RESIZE_REQUEST = "resize_request";

		/// <summary>
		/// Emitted when any GraphNode's slot is updated.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int idx</term>
		///			<description>the index of the slot</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SLOT_UPDATED = "slot_update";
	}
}
