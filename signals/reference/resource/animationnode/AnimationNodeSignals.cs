namespace Com.Surbon.GDSignals.Reference.Resource.AnimationNode
{
	/// <summary>
	/// Contains constants for AnimationNode signals.
	/// </summary>
	public static class AnimationNodeSignals
	{
		/// <summary>
		/// Emitted when the node was removed from the graph.
		/// </summary>
		public const string REMOVED_FROM_GRAPH = "removed_from_graph";

		/// <summary>
		/// Emitted by nodes that inherit from this class and that have an internal tree when one of their nodes changes.
		/// The nodes that emit this signal are AnimationNodeBlendSpace1D, AnimationNodeBlendSpace2D, AnimationNodeStateMachine,
		/// and AnimationNodeBlendTree.
		/// </summary>
		public const string TREE_CHANGED = "tree_changed";
	}
}