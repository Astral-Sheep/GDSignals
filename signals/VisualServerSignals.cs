namespace Com.Surbon.GDSignals
{
	public static class VisualServerSignals
	{
		/// <summary>
		/// Emitted at the end of the frame, after the VisualServer has finished updating all the Viewports.
		/// </summary>
		public const string FRAME_POST_DRAW = "frame_post_draw";

		/// <summary>
		/// Emitted at the beginning of the frame, before the VisualServer updates all the Viewports.
		/// </summary>
		public const string FRAME_PRE_DRAW = "frame_pre_draw";
	}
}