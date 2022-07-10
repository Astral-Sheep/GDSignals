namespace Com.Surbon.GDSignals.Node.CanvasItem.Node2D.CollisionObject2D
{
	/// <summary>
	/// Contains constants for CollisionObject2D signals.
	/// </summary>
	public static class CollisionObject2DSignals
	{
		/// <summary>
		/// Emitted when an input event occurs. Requires input_pickable to be true and at least one collision_layer bit to be set.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Node viewport</term>
		///			<description>the node's viewport</description>
		///		</item>
		///		<item>
		///			<term>InputEvent event</term>
		///			<description>the occuring event</description>
		///		</item>
		///		<item>
		///			<term>int shape_idx</term>
		///			<description>the shape's index</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string INPUT_EVENT = "input_event";

		/// <summary>
		/// Emitted when the mouse pointer enters any of this object's shapes.
		/// Requires input_pickable to be true and at least one collision_layer bit to be set.
		/// </summary>
		public const string MOUSE_ENTERED = "mouse_entered";

		/// <summary>
		/// Emitted when the mouse pointer exits all this object's shapes.
		/// Requires input_pickable to be true and at least one collision_layer bit to be set.
		/// </summary>
		public const string MOUSE_EXITED = "mouse_exited";
	}
}
