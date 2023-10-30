using System;
using System.Runtime.InteropServices;

namespace LibInput 
{
	public sealed class TabletToolEvent : Event
	{
		[DllImport("input")] private static extern bool libinput_event_tablet_tool_x_has_changed(IntPtr handle);
		public bool HasXChanged { get => libinput_event_tablet_tool_x_has_changed(this.Handle); }

		[DllImport("input")] private static extern bool libinput_event_tablet_tool_y_has_changed(IntPtr handle);
		public bool HasYChanged { get => libinput_event_tablet_tool_y_has_changed(this.Handle); }

		[DllImport("input")] private static extern bool libinput_event_tablet_tool_pressure_has_changed(IntPtr handle);
		public bool HasPressureChanged { get => libinput_event_tablet_tool_pressure_has_changed(this.Handle); }

		[DllImport("input")] private static extern bool libinput_event_tablet_tool_distance_has_changed(IntPtr handle);
		public bool HasDistanceChanged { get => libinput_event_tablet_tool_distance_has_changed(this.Handle); }

		[DllImport("input")] private static extern bool libinput_event_tablet_tool_tilt_x_has_changed(IntPtr handle);
		public bool HasTiltXChanged { get => libinput_event_tablet_tool_tilt_x_has_changed(this.Handle); }

		[DllImport("input")] private static extern bool libinput_event_tablet_tool_tilt_y_has_changed(IntPtr handle);
		public bool HasTiltYChanged { get => libinput_event_tablet_tool_tilt_y_has_changed(this.Handle); }

		[DllImport("input")] private static extern bool libinput_event_tablet_tool_rotation_has_changed(IntPtr handle);
		public bool HasRotationChanged { get => libinput_event_tablet_tool_rotation_has_changed(this.Handle); }

		[DllImport("input")] private static extern bool libinput_event_tablet_tool_slider_has_changed(IntPtr handle);
		public bool HasSliderChanged { get => libinput_event_tablet_tool_slider_has_changed(this.Handle); }

		[DllImport("input")] private static extern bool libinput_event_tablet_tool_size_major_has_changed(IntPtr handle);
		public bool HasSizeMajorChanged { get => libinput_event_tablet_tool_size_major_has_changed(this.Handle); }

		[DllImport("input")] private static extern bool libinput_event_tablet_tool_size_minor_has_changed(IntPtr handle);
		public bool HasSizeMinorChanged { get => libinput_event_tablet_tool_size_minor_has_changed(this.Handle); }

		[DllImport("input")] private static extern bool libinput_event_tablet_tool_wheel_has_changed(IntPtr handle);
		public bool HasWheelChanged { get => libinput_event_tablet_tool_wheel_has_changed(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_x(IntPtr handle);
		public double X { get => libinput_event_tablet_tool_get_x(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_y(IntPtr handle);
		public double Y { get => libinput_event_tablet_tool_get_y(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_dx(IntPtr handle);
		public double Dx { get => libinput_event_tablet_tool_get_dx(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_dy(IntPtr handle);
		public double Dy { get => libinput_event_tablet_tool_get_dy(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_pressure(IntPtr handle);
		public double Pressure { get => libinput_event_tablet_tool_get_pressure(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_distance(IntPtr handle);
		public double Distance { get => libinput_event_tablet_tool_get_distance(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_tilt_x(IntPtr handle);
		public double TiltX { get => libinput_event_tablet_tool_get_tilt_x(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_tilt_y(IntPtr handle);
		public double TiltY { get => libinput_event_tablet_tool_get_tilt_y(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_rotation(IntPtr handle);
		public double Rotation { get => libinput_event_tablet_tool_get_rotation(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_slider_position(IntPtr handle);
		public double SliderPosition { get => libinput_event_tablet_tool_get_slider_position(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_size_major(IntPtr handle);
		public double SizeMajor { get => libinput_event_tablet_tool_get_size_major(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_size_minor(IntPtr handle);
		public double SizeMinor { get => libinput_event_tablet_tool_get_size_minor(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_wheel_delta(IntPtr handle);
		public double WheelDelta { get => libinput_event_tablet_tool_get_wheel_delta(this.Handle); }

		[DllImport("input")] private static extern int libinput_event_tablet_tool_get_wheel_delta_discrete(IntPtr handle);
		public int WheelDeltaDiscrete { get => libinput_event_tablet_tool_get_wheel_delta_discrete(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_x_transformed(IntPtr handle, uint width);
		public double GetXTransformed(uint width) => libinput_event_tablet_tool_get_x_transformed(this.Handle, width);

		[DllImport("input")] private static extern double libinput_event_tablet_tool_get_y_transformed(IntPtr handle, uint height);
		public double GetYTransformed(uint height) =>libinput_event_tablet_tool_get_y_transformed(this.Handle, height); 

		[DllImport("input")] private static extern TabletToolProximityState libinput_event_tablet_tool_get_proximity_state(IntPtr handle);
		public TabletToolProximityState ProximityState { get => libinput_event_tablet_tool_get_proximity_state(this.Handle); }

		[DllImport("input")] private static extern TabletToolTipState libinput_event_tablet_tool_get_tip_state(IntPtr handle);
		public TabletToolTipState TipState { get => libinput_event_tablet_tool_get_tip_state(this.Handle); }

		[DllImport("input")] private static extern uint libinput_event_tablet_tool_get_button(IntPtr handle);
		public uint Button { get => libinput_event_tablet_tool_get_button(this.Handle); }

		[DllImport("input")] private static extern ButtonState libinput_event_tablet_tool_get_button_state(IntPtr handle);
		public ButtonState ButtonState { get => libinput_event_tablet_tool_get_button_state(this.Handle); }

		[DllImport("input")] private static extern uint libinput_event_tablet_tool_get_seat_button_count(IntPtr handle);
		public uint SeatButtonCount { get => libinput_event_tablet_tool_get_seat_button_count(this.Handle); }

		[DllImport("input")] private static extern IntPtr libinput_event_tablet_tool_get_tool(IntPtr handle);
		public TabletTool Tool { get => new TabletTool() { Handle = libinput_event_tablet_tool_get_tool(this.Handle) }; }
	}

	public sealed class TabletTool 
	{
		public IntPtr Handle;

		[DllImport("input")] private static extern TabletToolType libinput_tablet_tool_get_type(IntPtr handle);
		public TabletToolType Type { get => libinput_tablet_tool_get_type(this.Handle); }

		[DllImport("input")] private static extern ulong libinput_tablet_tool_get_tool_id(IntPtr handle);
		public ulong Id { get => libinput_tablet_tool_get_tool_id(this.Handle); }

		[DllImport("input")] private static extern IntPtr libinput_tablet_tool_ref(IntPtr handle);
		public IntPtr Ref() => libinput_tablet_tool_ref(this.Handle);

		[DllImport("input")] private static extern IntPtr libinput_tablet_tool_unref(IntPtr handle);
		public IntPtr Unref() => libinput_tablet_tool_unref(this.Handle);

		[DllImport("input")] private static extern bool libinput_tablet_tool_has_pressure(IntPtr handle);
		public bool HasPressure { get => libinput_tablet_tool_has_pressure(this.Handle); }

		[DllImport("input")] private static extern bool libinput_tablet_tool_has_distance(IntPtr handle);
		public bool HasDistance { get => libinput_tablet_tool_has_distance(this.Handle); }

		[DllImport("input")] private static extern bool libinput_tablet_tool_has_tilt(IntPtr handle);
		public bool HasTilt { get => libinput_tablet_tool_has_tilt(this.Handle); }

		[DllImport("input")] private static extern bool libinput_tablet_tool_has_rotation(IntPtr handle);
		public bool HasRotation { get => libinput_tablet_tool_has_rotation(this.Handle); }

		[DllImport("input")] private static extern bool libinput_tablet_tool_has_slider(IntPtr handle);
		public bool HasSlider { get => libinput_tablet_tool_has_slider(this.Handle); }

		[DllImport("input")] private static extern bool libinput_tablet_tool_has_size(IntPtr handle);
		public bool HasSize { get => libinput_tablet_tool_has_size(this.Handle); }

		[DllImport("input")] private static extern bool libinput_tablet_tool_has_wheel(IntPtr handle);
		public bool HasWheel { get => libinput_tablet_tool_has_wheel(this.Handle); }

		[DllImport("input")] private static extern bool libinput_tablet_tool_has_button(IntPtr handle, uint code);
		public bool HasButton(uint code) => libinput_tablet_tool_has_button(this.Handle, code);

		[DllImport("input")] private static extern bool libinput_tablet_tool_is_unique(IntPtr handle);
		public bool IsUnique { get => libinput_tablet_tool_is_unique(this.Handle); }

		[DllImport("input")] private static extern ulong libinput_tablet_tool_get_serial(IntPtr handle);
		public ulong Serial { get => libinput_tablet_tool_get_serial(this.Handle); }

		[DllImport("input")] private static extern void libinput_tablet_tool_set_user_data(IntPtr handle, IntPtr data);
		[DllImport("input")] private static extern IntPtr libinput_tablet_tool_get_user_data(IntPtr handle);
		public IntPtr UserData 
		{
			set => libinput_tablet_tool_set_user_data(this.Handle, value);
			get => libinput_tablet_tool_get_user_data(this.Handle);
		}
	}
}