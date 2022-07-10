namespace Com.Surbon.GDSignals.Node.CanvasItem.Control
{
	/// <summary>
	/// Contains constants for GraphEdit signals.
	/// </summary>
	public static class GraphEditSignals
	{
		/// <summary>
		/// Emitted at the beginning of a GraphNode movement.
		/// </summary>
		public const string BEGIN_NODE_MOVE = "_begin_node_move";

		/// <summary>
		/// Emitted at the end of a GraphNode movement.
		/// </summary>
		public const string END_NODE_MOVE = "_end_node_move";

		/// <summary>
		/// Emitted when user dragging connection from input port into empty space of the graph.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string to</term>
		///			<description>the name of the input port</description>
		///		</item>
		///		<item>
		///			<term>int to_slot</term>
		///			<description>the slot of the input port</description>
		///		</item>
		///		<item>
		///			<term>Vector2 release_position</term>
		///			<description>the release position</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string CONNECTION_FROM_EMPTY = "connection_from_empty";

		/// <summary>
		/// Emitted to the GraphEdit when the connection between the from_slot slot of the from GraphNode and
		/// the to_slot slot of the to GraphNode is attempted to be created.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string from</term>
		///			<description>the name of the from_slot</description>
		///		</item>
		///		<item>
		///			<term>int from_slot</term>
		///			<description>the index of the from_slot</description>
		///		</item>
		///		<item>
		///			<term>string to</term>
		///			<description>the name of the to_slot</description>
		///		</item>
		///		<item>
		///			<term>int to_slot</term>
		///			<description>the index of the to_slot</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string CONNECTION_REQUEST = "connection_request";

		/// <summary>
		/// Emitted when user dragging connection from output port into empty space of the graph.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string from</term>
		///			<description>the name of the output port</description>
		///		</item>
		///		<item>
		///			<term>int from_slot</term>
		///			<description>the index of the output port</description>
		///		</item>
		///		<item>
		///			<term>Vector2 release_position</term>
		///			<description>the release position</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string CONNECTION_TO_EMPTY = "connection_to_empty";

		/// <summary>
		/// Emitted when the user presses Ctrl + C.
		/// </summary>
		public const string COPY_NODES_REQUEST = "copy_nodes_request";

		/// <summary>
		/// Emitted when a GraphNode is attempted to be removed from the GraphEdit.
		/// </summary>
		public const string DELETE_NODES_REQUEST = "delete_nodes_request";

		/// <summary>
		/// Emitted to the GraphEdit when the connection between from_slot slot of from GraphNode and
		/// to_slot slot of to GraphNode is attempted to be removed.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string from</term>
		///			<description>the name of the from_slot</description>
		///		</item>
		///		<item>
		///			<term>int from_slot</term>
		///			<description>the index of the from_slot</description>
		///		</item>
		///		<item>
		///			<term>string to</term>
		///			<description>the name of the to_slot</description>
		///		</item>
		///		<item>
		///			<term>int to_slot</term>
		///			<description>the index of the to_slot</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string DISCONNECTION_REQUEST = "disconnection_request";

		/// <summary>
		/// Emitted when a GraphNode is attempted to be duplicated in the GraphEdit.
		/// </summary>
		public const string DUPLICATE_NODES_REQUEST = "duplicate_nodes_request";

		/// <summary>
		/// Emitted when a GraphNode is selected.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Node node</term>
		///			<description>the selected node</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string NODE_SELECTED = "node_selected";

		/// <summary>
		/// Emitted when a GraphNode is unselected.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Node node</term>
		///			<description>the unselected node</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string NODE_UNSELECTED = "node_unselected";

		/// <summary>
		/// Emitted when the user presses Ctrl + V.
		/// </summary>
		public const string PASTE_NODES_REQUEST = "paste_nodes_request";

		/// <summary>
		/// Emitted when a popup is requested. Happens on right-clicking in the GraphEdit.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Vector2 position</term>
		///			<description>position of the mouse pointer when the signal is sent</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string POPUP_REQUEST = "popup_request";

		/// <summary>
		/// Emitted when the scroll offset is changed by the user. It will not be emitted when changed in code.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Vector2 ofs</term>
		///			<description>the new scroll offset</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SCROLL_OFFSET_CHANGED = "scroll_offset_changed";
	}
}
