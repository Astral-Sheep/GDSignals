namespace Com.Surbon.GDSignals.Node.CanvasItem.Control
{
	/// <summary>
    /// Contains constants for Control signals.
    /// </summary>
	public static class ControlSignals
	{
		/// <summary>
		/// Emitted when the node gains keyboard focus.
		/// </summary>
		public const string FOCUS_ENTERED = "focus_entered";

		/// <summary>
		/// Emitted when the node loses keyboard focus.
		/// </summary>
		public const string FOCUS_EXITED = "focus_exited";

		/// <summary>
		/// Emitted when the node receives an InputEvent.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>InputEvent event</term>
		///			<description>the received input</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string GUI_INPUT = "gui_input";

		/// <summary>
		/// Emitted when the node's minimum size changes.
		/// </summary>
		public const string MINIMUM_SIZE_CHANGED = "minimum_size_changed";

		/// <summary>
		/// Emitted when a modal Control is closed.
		/// </summary>
		public const string MODAL_CLOSED = "modal_closed";

		/// <summary>
		/// Emitted when the mouse enters the control's Rect area, provided its mouse_filter lets the event reach it.
		/// <para>
		/// Note: mouse_entered will not be emitted if the mouse enters a child Control node before entering the parent's Rect area, at least until the mouse is moved to reach the parent's Rect area.
		/// </para>
		/// </summary>
		public const string MOUSE_ENTERED = "mouse_entered";

		/// <summary>
		/// Emitted when the mouse leaves the control's Rect area, provided its mouse_filter lets the event reach it.
		///		<para>
		///			Note: mouse_exited will be emitted if the mouse enters a child Control node, even if the mouse cursor is still inside the parent's Rect area.
		///		</para>
		///		<para>
		///			If you want to check whether the mouse truly left the area, ignoring any top nodes, you can use code like this:
		///			<code>
		///				(new Rect2(new Vector2(), rect_size)).HasPoint(GetLocalMousePosition())
		///			</code>
		///			If true, the mouse is hovering over the area
		///		</para>
		/// </summary>
		public const string MOUSE_EXITED = "mouse_exited";

		/// <summary>
		/// Emitted when the control changes size.
		/// </summary>
		public const string RESIZED = "resize";

		/// <summary>
		/// Emitted when one of the size flags changes.
		/// </summary>
		public const string SIZE_FLAGS_CHANGED = "size_flags_changed";
	}
}
