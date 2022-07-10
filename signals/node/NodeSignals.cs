namespace Com.Surbon.GDSignals.Node
{
    /// <summary>
    /// Contains constants for Node signals.
    /// </summary>
	public static class NodeSignals
    {
        /// <summary>
        /// Emitted when the node is ready
        /// </summary>
        public const string READY = "ready";

        /// <summary>
        /// Emitted when the node is renamed
        /// </summary>
        public const string RENAMED = "renamed";

        /// <summary>
        /// Emitted when the node enters the tree
        /// </summary>
        public const string TREE_ENTERED = "tree_entered";

        /// <summary>
        /// Emitted after the node exits the tree and is no longer active
        /// </summary>
        public const string TREE_EXITED = "tree_exited";

        /// <summary>
        /// Emitted when the node is still active but about to exit the tree.
        /// This is the right place for de-initialization (or a "destructor", if you will).
        /// </summary>
        public const string TREE_EXITING = "tree_exiting";
    }
}
