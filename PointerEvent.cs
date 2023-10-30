using System;
using System.Runtime.InteropServices;

namespace LibInput 
{
	public sealed class PointerEvent : Event
	{
		[DllImport("input")] private static extern double libinput_event_pointer_get_dx(IntPtr handle);
		public double Dx { get => libinput_event_pointer_get_dx(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_pointer_get_dy(IntPtr handle);
		public double Dy { get => libinput_event_pointer_get_dy(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_pointer_get_dx_unaccelerated(IntPtr handle);
		public double DxUnaccelerated { get => libinput_event_pointer_get_dx_unaccelerated(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_pointer_get_dy_unaccelerated(IntPtr handle);
		public double DyUnaccelerated { get => libinput_event_pointer_get_dy_unaccelerated(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_pointer_get_absolute_x(IntPtr handle);
		public double AbsoluteX { get => libinput_event_pointer_get_absolute_x(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_pointer_get_absolute_y(IntPtr handle);
		public double AbsoluteY { get => libinput_event_pointer_get_absolute_y(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_pointer_get_absolute_x_transformed(IntPtr handle, uint width);
		public double GetAbsoluteXTransformed(uint width) => libinput_event_pointer_get_absolute_x_transformed(this.Handle, width);

		[DllImport("input")] private static extern double libinput_event_pointer_get_absolute_y_transformed(IntPtr handle, uint height);
		public double GetAbsoluteYTransformed(uint height) => libinput_event_pointer_get_absolute_y_transformed(this.Handle, height);

		[DllImport("input")] private static extern uint libinput_event_pointer_get_button(IntPtr handle);
		public uint Button { get => libinput_event_pointer_get_button(this.Handle); }

		[DllImport("input")] private static extern ButtonState libinput_event_pointer_get_button_state(IntPtr handle);
		public ButtonState ButtonState { get => libinput_event_pointer_get_button_state(this.Handle); }

		[DllImport("input")] private static extern uint libinput_event_pointer_get_seat_button_count(IntPtr handle);
		public uint SeatButtonCount { get => libinput_event_pointer_get_seat_button_count(this.Handle); }

		[DllImport("input")] private static extern bool libinput_event_pointer_has_axis(IntPtr handle, PointerAxis axis);
		public bool HasAxis(PointerAxis axis) => libinput_event_pointer_has_axis(this.Handle, axis);

		[DllImport("input")] private static extern double libinput_event_pointer_get_axis_value(IntPtr handle, PointerAxis axis);
		public double GetAxisValue(PointerAxis axis) => libinput_event_pointer_get_axis_value(this.Handle, axis);

		[DllImport("input")] private static extern PointerAxisSource libinput_event_pointer_get_axis_source(IntPtr handle);
		public PointerAxisSource AxisSource { get => libinput_event_pointer_get_axis_source(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_pointer_get_axis_value_discrete(IntPtr handle, PointerAxis axis);
		public double GetAxisValueDiscrete(PointerAxis axis) => libinput_event_pointer_get_axis_value_discrete(this.Handle, axis);

		[DllImport("input")] private static extern double libinput_event_pointer_get_scroll_value(IntPtr handle, PointerAxis axis);
		public double GetScrollValue(PointerAxis axis) => libinput_event_pointer_get_scroll_value(this.Handle, axis);

		[DllImport("input")] private static extern double libinput_event_pointer_get_scroll_value_v120(IntPtr handle, PointerAxis axis);
		public double GetScrollValueV120(PointerAxis axis) => libinput_event_pointer_get_scroll_value_v120(this.Handle, axis);
	}
}