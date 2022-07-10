namespace Com.Surbon.GDSignals.Node.CanvasItem.Node2D
{
	/// <summary>
	/// Contains constants for AnimatedSprite signals.
	/// </summary>
	public static class AnimatedSpriteSignals
	{
		/// <summary>
		/// Emitted when the animation is finished (when it plays the last frame).
		/// If the animation is looping, this signal is emitted every time the last frame is drawn.
		/// </summary>
		public const string ANIMATION_FINISHED = "animation_finished";

		/// <summary>
		/// Emitted when frame changed.
		/// </summary>
		public const string FRAME_CHANGED = "frame_changed";
	}
}
