namespace Com.Surbon.GDSignals.Reference.Resource
{
	/// <summary>
	/// Contains constants for Resource signals.
	/// </summary>
	public static class ResourceSignals
	{
		/// <summary>
		/// Emitted whenever the resource changes.
		/// <para>
		/// Note: This signal is not emitted automatically for custom resources,
		/// which means that you need to create a setter and emit the signal yourself.
		/// </para>
		/// </summary>
		public const string CHANGED = "changed";
	}
}