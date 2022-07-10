namespace Com.Surbon.GDSignals.Node.CanvasItem
{
	/// <summary>
	/// Contains constants for CanvasItem signals.
	/// </summary>
	public static class CanvasItemSignals
	{
		/// <summary>
		/// Emitted when the CanvasItem must redraw. This can only be connected realtime, as deferred will not allow drawing.
		/// </summary>
		public const string DRAW = "draw";

		/// <summary>
		/// Emitted when becoming hidden.
		/// </summary>
		public const string HIDE = "hide";

		/// <summary>
		/// Emitted when the item's Rect2 boundaries (position or size) have changed,
		/// or when an action is taking place that may have impacted these boundaries (e.g. changing Sprite.texture).
		/// </summary>
		public const string ITEM_RECT_CHANGED = "item_rect_changed";

		/// <summary>
		/// Emitted when the visibility (hidden/visible) changes.
		/// </summary>
		public const string VISIBILITY_CHANGED = "visibility_changed";
	}
}
