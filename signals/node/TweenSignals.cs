namespace Com.Surbon.GDSignals.Node
{
	/// <summary>
    /// Contains constants for Tween signals.
    /// </summary>
	public static class TweenSignals
	{
		/// <summary>
		/// Emitted when all processes in a tween end.
		/// </summary>
		public const string ALL_COMPLETED = "tween_all_completed";

		/// <summary>
		/// Emitted when a tween ends.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Object object</term>
		///			<description></description>
		///		</item>
		///		<item>
		///			<term>NodePath key</term>
		///			<description></description>
		///		</item>
		/// </list>
		/// </summary>
		public const string COMPLETED = "tween_completed";

		/// <summary>
		/// Emitted when a tween starts.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Object object</term>
		///			<description></description>
		///		</item>
		///		<item>
		///			<term>NodePath key</term>
		///			<description></description>
		///		</item>
		/// </list>
		/// </summary>
		public const string STARTED = "tween_started";

		/// <summary>
		/// Emitted at each step of the animation.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>Object object</term>
		///			<description></description>
		///		</item>
		///		<item>
		///			<term>NodePath key</term>
		///			<description></description>
		///		</item>
		///		<item>
		///			<term>float elapsed</term>
		///			<description></description>
		///		</item>
		///		<item>
		///			<term>Object value</term>
		///			<description></description>
		///		</item>
		/// </list>
		/// </summary>
		public const string STEP = "tween_step";
	}
}
