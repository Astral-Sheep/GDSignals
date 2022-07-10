namespace Com.Surbon.GDSignals.Node.Spatial.CollisionObject
{
	/// <summary>
	/// Contains constants for Area signals.
	/// </summary>
	public static class AreaSignals
	{
		/// <summary>
		/// Emitted when another Area enters this Area. Requires monitoring to be set to true.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Area area</term>
		///			<description>the other Area</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ENTERED = "area_entered";

		/// <summary>
		/// Emitted when another Area exits this Area. Requires monitoring to be set to true.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Area area</term>
		///			<description>the other Area</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string EXITED = "area_exited";

		/// <summary>
		/// Emitted when one of another Area's Shapes enters one of this Area's Shapes. Requires monitoring to be set to true.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>RID area_rid</term>
		///			<description>the RID of the other Area's CollisionObject used by the PhysicsServer.</description>
		///		</item>
		///		<item>
		///			<term>Area area</term>
		///			<description>the other Area</description>
		///		</item>
		///		<item>
		///			<term>int area_shape_index</term>
		///			<description>
		///				the index of the Shape of the other Area used by the PhysicsServer.
		///				Get the CollisionShape node with <c>area.shape_owner_get_owner(area_shape_index)</c>.
		///			</description>
		///		</item>
		///		<item>
		///			<term>int local_shape_index</term>
		///			<description>
		///				the index of the Shape of this Area used by the PhysicsServer.
		///				Get the CollisionShape node with <c>self.shape_owner_get_owner(local_shape_index)</c>.
		///			</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SHAPE_ENTERED = "area_shape_entered";

		/// <summary>
		/// Emitted when one of another Area's Shapes enters one of this Area's Shapes. Requires monitoring to be set to true.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>RID area_rid</term>
		///			<description>the RID of the other Area's CollisionObject used by the PhysicsServer.</description>
		///		</item>
		///		<item>
		///			<term>Area area</term>
		///			<description>the other Area</description>
		///		</item>
		///		<item>
		///			<term>int area_shape_index</term>
		///			<description>
		///				the index of the Shape of the other Area used by the PhysicsServer.
		///				Get the CollisionShape node with <c>area.shape_owner_get_owner(area_shape_index)</c>.
		///			</description>
		///		</item>
		///		<item>
		///			<term>int local_shape_index</term>
		///			<description>
		///				the index of the Shape of this Area used by the PhysicsServer.
		///				Get the CollisionShape node with <c>self.shape_owner_get_owner(local_shape_index)</c>.
		///			</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SHAPE_EXITED = "area_shape_exited";

		/// <summary>
		/// Emitted when a PhysicsBody or GridMap enters this Area.
		/// Requires monitoring to be set to true. GridMaps are detected if the MeshLibrary has Collision Shapes.
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
		/// Emitted when a PhysicsBody or GridMap exits this Area.
		/// Requires monitoring to be set to true. GridMaps are detected if the MeshLibrary has Collision Shapes.
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
		/// Emitted when one of a PhysicsBody or GridMap's Shapes enters one of this Area's Shapes.
		/// Requires monitoring to be set to true.
		/// GridMaps are detected if the MeshLibrary has Collision Shapes.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>RID body_rid</term>
		///			<description>the RID of the PhysicsBody or MeshLibrary's CollisionObject used by the PhysicsServer.</description>
		///		</item>
		///		<item>
		///			<term>Node body</term>
		///			<description>the Node, if it exists in the tree, of the PhysicsBody or GridMap.</description>
		///		</item>
		///		<item>
		///			<term>int body_shape_index</term>
		///			<description>
		///				the index of the Shape of the PhysicsBody or GridMap used by the PhysicsServer.
		///				Get the CollisionShape node with <c>body.shape_owner_get_owner(body_shape_index)</c>.
		///			</description>
		///		</item>
		///		<item>
		///			<term>int local_shape_index</term>
		///			<description>
		///				the index of the Shape of this Area used by the PhysicsServer.
		///				Get the CollisionShape node with <c>self.shape_owner_get_owner(local_shape_index)</c>.
		///			</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BODY_SHAPE_ENTERED = "body_shape_entered";

		/// <summary>
		/// Emitted when one of a PhysicsBody or GridMap's Shapes enters one of this Area's Shapes.
		/// Requires monitoring to be set to true.
		/// GridMaps are detected if the MeshLibrary has Collision Shapes.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>RID body_rid</term>
		///			<description>the RID of the PhysicsBody or MeshLibrary's CollisionObject used by the PhysicsServer.</description>
		///		</item>
		///		<item>
		///			<term>Node body</term>
		///			<description>the Node, if it exists in the tree, of the PhysicsBody or GridMap.</description>
		///		</item>
		///		<item>
		///			<term>int body_shape_index</term>
		///			<description>
		///				the index of the Shape of the PhysicsBody or GridMap used by the PhysicsServer.
		///				Get the CollisionShape node with <c>body.shape_owner_get_owner(body_shape_index)</c>.
		///			</description>
		///		</item>
		///		<item>
		///			<term>int local_shape_index</term>
		///			<description>
		///				the index of the Shape of this Area used by the PhysicsServer.
		///				Get the CollisionShape node with <c>self.shape_owner_get_owner(local_shape_index)</c>.
		///			</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string BODY_SHAPE_EXITED = "body_shape_exited";
	}
}
