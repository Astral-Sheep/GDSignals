namespace Com.Surbon.GDSignals.Node.CanvasItem.Node2D.CollisionObject2D
{
	/// <summary>
	/// Contains constants for Area2D signals.
	/// </summary>
	public static class Area2DSignals
	{
		/// <summary>
		/// Emitted when another Area2D enters this Area2D. Requires monitoring to be set to true.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Area2D area</term>
		///			<description>the other Area2D</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ENTERED = "area_entered";

		/// <summary>
		/// Emitted when another Area2D exits this Area2D. Requires monitoring to be set to true.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Area2D area</term>
		///			<description>the other Area2D</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string EXITED = "area_exited";

		/// <summary>
		/// Emitted when one of another Area2D's Shape2Ds enters one of this Area2D's Shape2Ds. Requires monitoring to be set to true.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>RID area_rid</term>
		///			<description>the RID of the other Area2D's CollisionObject2D used by the Physics2DServer.</description>
		///		</item>
		///		<item>
		///			<term>Area2D area</term>
		///			<description>the other Area2D</description>
		///		</item>
		///		<item>
		///			<term>int area_shape_index</term>
		///			<description>
		///				the index of the Shape2D of the other Area2D used by the Physics2DServer.
		///				Get the CollisionShape2D node with <c>area.shape_owner_get_owner(area_shape_index)</c>.
		///			</description>
		///		</item>
		///		<item>
		///			<term>int local_shape_index</term>
		///			<description>
		///				the index of the Shape2D of this Area2D used by the Physics2DServer.
		///				Get the CollisionShape2D node with <c>self.shape_owner_get_owner(local_shape_index)</c>.
		///			</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SHAPE_ENTERED = "area_shape_entered";

		/// <summary>
		/// Emitted when one of another Area2D's Shape2Ds exits one of this Area2D's Shape2Ds. Requires monitoring to be set to true.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>RID area_rid</term>
		///			<description>the RID of the other Area2D's CollisionObject2D used by the Physics2DServer.</description>
		///		</item>
		///		<item>
		///			<term>Area2D area</term>
		///			<description>the other Area2D</description>
		///		</item>
		///		<item>
		///			<term>int area_shape_index</term>
		///			<description>
		///				the index of the Shape2D of the other Area2D used by the Physics2DServer.
		///				Get the CollisionShape2D node with <c>area.shape_owner_get_owner(area_shape_index)</c>.
		///			</description>
		///		</item>
		///		<item>
		///			<term>int local_shape_index</term>
		///			<description>
		///				the index of the Shape2D of this Area2D used by the Physics2DServer.
		///				Get the CollisionShape2D node with <c>self.shape_owner_get_owner(local_shape_index)</c>.
		///			</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SHAPE_EXITED = "area_shape_exited";

		/// <summary>
		/// Emitted when a PhysicsBody2D or TileMap enters this Area2D. Requires monitoring to be set to true.
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
		/// Emitted when a PhysicsBody2D or TileMap exits this Area2D. Requires monitoring to be set to true.
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
		/// Emitted when one of a PhysicsBody2D or TileMap's Shape2Ds enters one of this Area2D's Shape2Ds.
		/// Requires monitoring to be set to true. TileMaps are detected if the TileSet has Collision Shape2Ds.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>RID body_rid</term>
		///			<description>the RID of the PhysicsBody2D or TileSet's CollisionObject2D used by the Physics2DServer.</description>
		///		</item>
		///		<item>
		///			<term>Node body</term>
		///			<description>the Node, if it exists in the tree, of the PhysicsBody2D or TileMap.</description>
		///		</item>
		///		<item>
		///			<term>int body_shape_index</term>
		///			<description>
		///				the index of the Shape2D of the PhysicsBody2D or TileMap used by the Physics2DServer.
		///				Get the CollisionShape2D node with <c>body.shape_owner_get_owner(body_shape_index)</c>.
		///			</description>
		///		</item>
		///		<item>
		///			<term>int local_shape_index</term>
		///			<description>
		///				the index of the Shape2D of this Area2D used by the Physics2DServer.
		///				Get the CollisionShape2D node with <c>self.shape_owner_get_owner(local_shape_index)</c>.
		///			</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BODY_SHAPE_ENTERED = "body_shape_entered";

		/// <summary>
		/// Emitted when one of a PhysicsBody2D or TileMap's Shape2Ds exits one of this Area2D's Shape2Ds.
		/// Requires monitoring to be set to true. TileMaps are detected if the TileSet has Collision Shape2Ds.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>RID body_rid</term>
		///			<description>the RID of the PhysicsBody2D or TileSet's CollisionObject2D used by the Physics2DServer.</description>
		///		</item>
		///		<item>
		///			<term>Node body</term>
		///			<description>the Node, if it exists in the tree, of the PhysicsBody2D or TileMap.</description>
		///		</item>
		///		<item>
		///			<term>int body_shape_index</term>
		///			<description>
		///				the index of the Shape2D of the PhysicsBody2D or TileMap used by the Physics2DServer.
		///				Get the CollisionShape2D node with <c>body.shape_owner_get_owner(body_shape_index)</c>.
		///			</description>
		///		</item>
		///		<item>
		///			<term>int local_shape_index</term>
		///			<description>
		///				the index of the Shape2D of this Area2D used by the Physics2DServer.
		///				Get the CollisionShape2D node with <c>self.shape_owner_get_owner(local_shape_index)</c>.
		///			</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BODY_SHAPE_EXITED = "body_shape_exited";
	}
}
