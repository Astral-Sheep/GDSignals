namespace Com.Surbon.GDSignals.Node.Spatial.CollisionObject
{
	/// <summary>
	/// Contains constants for CollisionObject signals.
	/// </summary>
	public static class CollisionObjectSignals
	{
		/// <summary>
		/// Emitted when the object receives an unhandled InputEvent.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Node camera</term>
		///			<description>the active camera</description>
		///		</item>
		///		<item>
		///			<term>InputEvent event</term>
		///			<description>the unhandled input</description>
		///		</item>
		///		<item>
		///			<term>Vector3 position</term>
		///			<description>the location in world space of the mouse pointer on the surface of the shape</description>
		///		</item>
		///		<item>
		///			<term>Vector3 normal</term>
		///			<description>the normal vector of the surface at that point</description>
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
		/// </summary>
		public const string MOUSE_ENTERED = "mouse_entered";

		/// <summary>
		/// Emitted when the mouse pointer exits all this object's shapes.
		/// </summary>
		public const string MOUSE_EXITED = "mouse_exited";
	}
}
