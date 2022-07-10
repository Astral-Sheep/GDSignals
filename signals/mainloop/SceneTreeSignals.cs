namespace Com.Surbon.GDSignals.MainLoop
{
	/// <summary>
	/// Contains constants for SceneTree signals.
	/// </summary>
	public static class SceneTreeSignals
	{
		/// <summary>
		/// Emitted whenever this SceneTree's network_peer successfully connected to a server. Only emitted on clients.
		/// </summary>
		public const string CONNECTED_TO_SERVER = "connected_to_server";

		/// <summary>
		/// Emitted whenever this SceneTree's network_peer fails to establish a connection to a server. Only emitted on clients.
		/// </summary>
		public const string CONNECTION_FAILED = "connection_failed";

		/// <summary>
		/// Emitted when files are dragged from the OS file manager and dropped in the game window.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>PoolStringArray files</term>
		///			<description>a list of file paths</description>
		///		</item>
		///		<item>
		///			<term>int screen</term>
		///			<description>the identifier of the screen where the drag originated</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string FILES_DROPPED = "files_dropped";

		/// <summary>
		/// Emitted whenever global menu item is clicked.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Variant id</term>
		///			<description>the item's id (I guess)</description>
		///		</item>
		///		<item>
		///			<term>Variant meta</term>
		///			<description>the item's meta (I guess)</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string GLOBAL_MENU_ACTION = "global_menu_action";

		/// <summary>
		/// Emitted immediately before Node._process is called on every node in the SceneTree.
		/// </summary>
		public const string IDLE_FRAME = "idle_frame";

		/// <summary>
		/// Emitted whenever this SceneTree's network_peer disconnects from a peer.
		/// Clients get notified when other clients disconnect from the same server.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int id</term>
		///			<description>the peer's id</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string NETWORK_PEER_CONNECTED = "network_peer_connected";

		/// <summary>
		/// Emitted whenever a node is added to the SceneTree.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Node node</term>
		///			<description>the added node</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string NODE_ADDED = "node_added";

		/// <summary>
		/// Emitted when a node's configuration changed. Only emitted in tool mode.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Node node</term>
		///			<description>the changed node</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string NODE_CONFIGURATION_WARNING_CHANGED = "node_configuration_warning_changed";

		/// <summary>
		/// Emitted whenever a node is removed from the SceneTree.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Node node</term>
		///			<description>the removed node</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string NODE_REMOVED = "node_removed";

		/// <summary>
		/// Emitted whenever a node is renamed.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Node node</term>
		///			<description>the renamed node</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string NODE_RENAMED = "node_renamed";

		/// <summary>
		/// Emitted immediately before Node._physics_process is called on every node in the SceneTree.
		/// </summary>
		public const string PHYSICS_FRAME = "physics_frame";

		/// <summary>
		/// Emitted when the screen resolution (fullscreen) or window size (windowed) changes.
		/// </summary>
		public const string SCREEN_RESIZED = "screen_resized";

		/// <summary>
		/// Emitted whenever this SceneTree's network_peer disconnected from server. Only emitted on clients.
		/// </summary>
		public const string SERVER_DISCONNECTED = "server_disconnected";

		/// <summary>
		/// Emitted whenever the SceneTree hierarchy changed (children being moved or renamed, etc.).
		/// </summary>
		public const string TREE_CHANGED = "tree_changed";
	}
}