namespace Com.Surbon.GDSignals.Reference
{
	/// <summary>
	/// Contains constants for WebXRInterface signals.
	/// </summary>
	public static class WebXRInterfaceSignals
	{
		/// <summary>
		/// Emitted to indicate that the reference space has been reset or reconfigured.
		/// <para>
		/// When(or whether) this is emitted depends on the user's browser or device,
		/// but may include when the user has changed the dimensions of their play space (which you may be able to access via bounds_geometry)
		/// or pressed/held a button to recenter their position.
		/// </para>
		/// </summary>
		public const string REFERENCE_SPACE_RESET = "reference_space_reset";

		/// <summary>
		/// Emitted after one of the "controllers" has finished its "primary action".
		/// <para>
		/// Use get_controller to get more information about the controller.
		/// </para>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int controller_id</term>
		///			<description>the affected controller</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SELECT = "select";

		/// <summary>
		/// Emitted when one of the "controllers" has finished its "primary action".
		/// <para>
		/// Use get_controller to get more information about the controller.
		/// </para>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int controller_id</term>
		///			<description>the affected controller</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SELECT_END = "selectend";

		/// <summary>
		/// Emitted when one of the "controllers" has started its "primary action".
		/// <para>
		/// Use get_controller to get more information about the controller.
		/// </para>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int controller_id</term>
		///			<description>the affected controller</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SELECT_START = "selectstart";

		/// <summary>
		/// Emitted when the user ends the WebXR session (which can be done using UI from the browser or device).
		/// <para>
		/// At this point, you should do <c>get_viewport().arvr = false</c> to instruct Godot to resume rendering to the screen.
		/// </para>
		/// </summary>
		public const string SESSION_ENDED = "session_ended";

		/// <summary>
		/// Emitted by ARVRInterface.initialize if the session fails to start.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string message</term>
		///			<description>may optionally contain an error message from WebXR, or an empty string if no message is available</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SESSION_FAILED = "session_failed";

		/// <summary>
		/// Emitted by ARVRInterface.initialize if the session is successfully started.
		/// <para>
		/// At this point, it's safe to do <c>get_viewport().arvr = true</c> to instruct Godot to start rendering to the AR/VR device.
		/// </para>
		/// </summary>
		public const string SESSION_STARTED = "session_started";

		/// <summary>
		/// Emitted by is_session_supported to indicate if the given session_mode is supported or not.
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>string session_mode</term>
		///			<description>the given session_mode</description>
		///		</item>
		///		<item>
		///			<term>bool supported</term>
		///			<description>says if the session is supported</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SESSION_SUPPORTED = "session_supported";

		/// <summary>
		/// Emitted after one of the "controllers" has finished its "primary squeeze action".
		/// <para>
		/// Use get_controller to get more information about the controller.
		/// </para>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int controller_id</term>
		///			<description>the affected controller</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SQUEEZE = "squeeze";

		/// <summary>
		/// Emitted when one of the "controllers" has finished its "primary squeeze action".
		/// <para>
		/// Use get_controller to get more information about the controller.
		/// </para>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int controller_id</term>
		///			<description>the affected controller</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SQUEEZE_END = "squeezeend";

		/// <summary>
		/// Emitted when one of the "controllers" has started its "primary squeeze action".
		/// <para>
		/// Use get_controller to get more information about the controller.
		/// </para>
		/// <list type="table">
		///		<listheader>Parameters:</listheader>
		///		<item>
		///			<term>int controller_id</term>
		///			<description>the affected controller</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string SQUEEZE_START = "squeezestart";

		/// <summary>
		/// Emitted when visibility_state has changed.
		/// </summary>
		public const string VISIBILITY_STATE_CHANGED = "visibility_state_changed";
	}
}