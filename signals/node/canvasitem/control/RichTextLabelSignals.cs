namespace Com.Surbon.GDSignals.Node.CanvasItem.Control
{
	/// <summary>
	/// Contains constants for RichTextLabel signals.
	/// </summary>
	public static class RichTextLabelSignals
	{
		/// <summary>
		/// Triggered when the user clicks on content between meta tags. If the meta is defined in text, e.g. <c>[url={"data"="hi"}]hi[/url]</c>,
		/// then the parameter for this signal will be a String type.
		/// If a particular type or an object is desired, the push_meta method must be used to manually insert the data into the tag stack.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Variant meta</term>
		///			<description>the clicked meta</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string META_CLICKED = "meta_clicked";

		/// <summary>
		/// Triggers when the mouse exits a meta tag.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Variant meta</term>
		///			<description>the meta tag exited</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string META_HOVER_ENDED = "meta_hover_ended";

		/// <summary>
		/// Triggers when the mouse enters a meta tag.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Variant meta</term>
		///			<description>the meta tag entered</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string META_HOVER_STARTED = "meta_hover_started";
	}
}
