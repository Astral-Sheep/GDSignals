namespace Com.Surbon.GDSignals.Node.CanvasItem.Node2D.CollisionObject2D
{
	/// <summary>
	/// Contains constants for RigidBody2D signals.
	/// </summary>
	public static class RigidBody2DSignals
	{
		/// <summary>
		/// Emitted when a collision with another PhysicsBody2D or TileMap occurs.
		/// Requires contact_monitor to be set to true and contacts_reported to be set high enough to detect all the collisions.
		/// TileMaps are detected if the TileSet has Collision Shape2Ds.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Node body</term>
		///			<description>the Node, if it exists in the tree, of the other PhysicsBody2D or TileMap.</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BODY_ENTERED = "body_entered";

		/// <summary>
		/// Emitted when the collision with another PhysicsBody2D or TileMap ends.
		/// Requires contact_monitor to be set to true and contacts_reported to be set high enough to detect all the collisions.
		/// TileMaps are detected if the TileSet has Collision Shape2Ds.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Node body</term>
		///			<description>the Node, if it exists in the tree, of the other PhysicsBody2D or TileMap.</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BODY_EXITED = "body_exited";

		/// <summary>
		/// Emitted when one of this RigidBody2D's Shape2Ds collides with another PhysicsBody2D or TileMap's Shape2Ds.
		/// Requires contact_monitor to be set to true and contacts_reported to be set high enough to detect all the collisions.
		/// TileMaps are detected if the TileSet has Collision Shape2Ds.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>RID body_rid</term>
		///			<description>the RID of the other PhysicsBody2D or TileSet's CollisionObject2D used by the Physics2DServer.</description>
		///		</item>
		///		<item>
		///			<term>Node body</term>
		///			<description>the Node, if it exists in the tree, of the other PhysicsBody2D or TileMap.</description>
		///		</item>
		///		<item>
		///			<term>int body_shape_index</term>
		///			<description>
		///				the index of the Shape2D of the other PhysicsBody2D or TileMap used by the Physics2DServer.
		///				Get the CollisionShape2D node with <c>body.shape_owner_get_owner(body_shape_index)</c>.
		///			</description>
		///		</item>
		///		<item>
		///			<term>int local_shape_index</term>
		///			<description>
		///				the index of the Shape2D of this RigidBody2D used by the Physics2DServer.
		///				Get the CollisionShape2D node with <c>self.shape_owner_get_owner(local_shape_index)</c>.
		///			</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BODY_SHAPE_ENTERED = "body_shape_entered";

		/// <summary>
		/// Emitted when the collision between one of this RigidBody2D's Shape2Ds and another PhysicsBody2D or TileMap's Shape2Ds ends.
		/// Requires contact_monitor to be set to true and contacts_reported to be set high enough to detect all the collisions.
		/// TileMaps are detected if the TileSet has Collision Shape2Ds.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>RID body_rid</term>
		///			<description>the RID of the other PhysicsBody2D or TileSet's CollisionObject2D used by the Physics2DServer.</description>
		///		</item>
		///		<item>
		///			<term>Node body</term>
		///			<description>the Node, if it exists in the tree, of the other PhysicsBody2D or TileMap.</description>
		///		</item>
		///		<item>
		///			<term>int body_shape_index</term>
		///			<description>
		///				the index of the Shape2D of the other PhysicsBody2D or TileMap used by the Physics2DServer.
		///				Get the CollisionShape2D node with <c>body.shape_owner_get_owner(body_shape_index)</c>.
		///			</description>
		///		</item>
		///		<item>
		///			<term>int local_shape_index</term>
		///			<description>
		///				the index of the Shape2D of this RigidBody2D used by the Physics2DServer.
		///				Get the CollisionShape2D node with <c>self.shape_owner_get_owner(local_shape_index)</c>.
		///			</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BODY_SHAPE_EXITED = "body_shape_exited";

		/// <summary>
		/// Emitted when the physics engine changes the body's sleeping state.
		/// <para>
		///		Note: Changing the value sleeping will not trigger this signal.
		///		It is only emitted if the sleeping state is changed by the physics engine or emit_signal("sleeping_state_changed") is used.
		/// </para>
		/// </summary>
		public const string SLEEPING_STATE_CHANGED = "sleeping_state_changed";
	}
}
