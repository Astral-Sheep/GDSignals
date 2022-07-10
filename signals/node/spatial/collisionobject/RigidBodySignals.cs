namespace Com.Surbon.GDSignals.Node.Spatial.CollisionObject
{
	/// <summary>
	/// Contains constants for RigidBody signals.
	/// </summary>
	public static class RigidBodySignals
	{
		/// <summary>
		/// Emitted when a collision with another PhysicsBody or GridMap occurs.
		/// Requires contact_monitor to be set to true and contacts_reported to be set high enough to detect all the collisions.
		/// GridMaps are detected if the MeshLibrary has Collision Shapes.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Node body</term>
		///			<description>the Node, if it exists in the tree, of the other PhysicsBody or GridMap.</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BODY_ENTERED = "body_entered";

		/// <summary>
		/// Emitted when the collision with another PhysicsBody or GridMap ends.
		/// Requires contact_monitor to be set to true and contacts_reported to be set high enough to detect all the collisions.
		/// GridMaps are detected if the MeshLibrary has Collision Shapes.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Node body</term>
		///			<description>the Node, if it exists in the tree, of the other PhysicsBody or GridMap.</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BODY_EXITED = "body_exited";

		/// <summary>
		/// Emitted when one of this RigidBody's Shapes collides with another PhysicsBody or GridMap's Shapes.
		/// Requires contact_monitor to be set to true and contacts_reported to be set high enough to detect all the collisions.
		/// GridMaps are detected if the MeshLibrary has Collision Shapes.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>RID body_rid</term>
		///			<description>the RID of the other PhysicsBody or MeshLibrary's CollisionObject used by the PhysicsServer.</description>
		///		</item>
		///		<item>
		///			<term>Node body</term>
		///			<description>the Node, if it exists in the tree, of the other PhysicsBody or GridMap.</description>
		///		</item>
		///		<item>
		///			<term>int body_shape_index</term>
		///			<description>
		///				the index of the Shape of the other PhysicsBody or GridMap used by the PhysicsServer.
		///				Get the CollisionShape node with <c>body.shape_owner_get_owner(body_shape_index)</c>.
		///			</description>
		///		</item>
		///		<item>
		///			<term>int local_shape_index</term>
		///			<description>
		///				the index of the Shape of this RigidBody used by the PhysicsServer.
		///				Get the CollisionShape node with <c>self.shape_owner_get_owner(local_shape_index)</c>.
		///			</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BODY_SHAPE_ENTERED = "body_shape_entered";

		/// <summary>
		/// Emitted when the collision between one of this RigidBody's Shapes and another PhysicsBody or GridMap's Shapes ends.
		/// Requires contact_monitor to be set to true and contacts_reported to be set high enough to detect all the collisions.
		/// GridMaps are detected if the MeshLibrary has Collision Shapes.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>RID body_rid</term>
		///			<description>the RID of the other PhysicsBody or MeshLibrary's CollisionObject used by the PhysicsServer.</description>
		///		</item>
		///		<item>
		///			<term>Node body</term>
		///			<description>the Node, if it exists in the tree, of the other PhysicsBody or GridMap.</description>
		///		</item>
		///		<item>
		///			<term>int body_shape_index</term>
		///			<description>
		///				the index of the Shape of the other PhysicsBody or GridMap used by the PhysicsServer.
		///				Get the CollisionShape node with <c>body.shape_owner_get_owner(body_shape_index)</c>.
		///			</description>
		///		</item>
		///		<item>
		///			<term>int local_shape_index</term>
		///			<description>
		///				the index of the Shape of this RigidBody used by the PhysicsServer.
		///				Get the CollisionShape node with <c>self.shape_owner_get_owner(local_shape_index)</c>.
		///			</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BODY_SHAPE_EXITED = "body_shape_exited";

		/// <summary>
		/// Emitted when the physics engine changes the body's sleeping state.
		/// <para>
		/// Note: Changing the value sleeping will not trigger this signal.
		/// It is only emitted if the sleeping state is changed by the physics engine or <c>emit_signal("sleeping_state_changed")</c> is used.
		/// </para>
		/// </summary>
		public const string SLEEPING_STATE_CHANGED = "sleeping_state_changed";
	}
}
