namespace Com.Surbon.GDSignals.Node
{
	/// <summary>
	/// Contains constants for AnimationPlayer signals.
	/// </summary>
	public static class AnimationPlayerSignals
	{
		/// <summary>
		/// Emitted when a queued animation plays after the previous animation was finished.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string old_name</term>
		///			<description>the previous animation's name</description>
		///		</item>
		///		<item>
		///			<term>string new_name</term>
		///			<description>the queued animation's name</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ANIMATION_CHANGED = "animation_changed";

		/// <summary>
		/// Notifies when an animation finished playing.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string anim_name</term>
		///			<description>the animation's name</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ANIMATION_FINISHED = "animation_finished";

		/// <summary>
		/// Notifies when an animation starts playing.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string anim_name</term>
		///			<description>the animation's name</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ANIMATION_STARTED = "animation_started";
		
		/// <summary>
		/// Notifies when the caches have been cleared, either automatically, or manually via clear_caches.
		/// </summary>
		public const string CACHES_CLEARED = "caches_cleared";
	}
}
