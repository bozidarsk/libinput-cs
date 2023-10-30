using System;
using System.Runtime.InteropServices;

namespace LibInput 
{
	public sealed class GestureEvent : Event
	{
		[DllImport("input")] private static extern int libinput_event_gesture_get_finger_count(IntPtr handle);
		public int FingerCount { get => libinput_event_gesture_get_finger_count(this.Handle); }

		[DllImport("input")] private static extern int libinput_event_gesture_get_cancelled(IntPtr handle);
		public int Cancelled { get => libinput_event_gesture_get_cancelled(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_gesture_get_dx(IntPtr handle);
		public double Dx { get => libinput_event_gesture_get_dx(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_gesture_get_dy(IntPtr handle);
		public double Dy { get => libinput_event_gesture_get_dy(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_gesture_get_dx_unaccelerated(IntPtr handle);
		public double DxUnaccelerated { get => libinput_event_gesture_get_dx_unaccelerated(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_gesture_get_dy_unaccelerated(IntPtr handle);
		public double DyUnaccelerated { get => libinput_event_gesture_get_dy_unaccelerated(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_gesture_get_scale(IntPtr handle);
		public double Scale { get => libinput_event_gesture_get_scale(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_gesture_get_angle_delta(IntPtr handle);
		public double AngleDelta { get => libinput_event_gesture_get_angle_delta(this.Handle); }
	}
}