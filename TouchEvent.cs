using System;
using System.Runtime.InteropServices;

namespace LibInput 
{
	public sealed class TouchEvent : Event
	{
		[DllImport("input")] private static extern int libinput_event_touch_get_slot(IntPtr handle);
		public int Slot { get => libinput_event_touch_get_slot(this.Handle); }

		[DllImport("input")] private static extern int libinput_event_touch_get_seat_slot(IntPtr handle);
		public int SeatSlot { get => libinput_event_touch_get_seat_slot(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_touch_get_x(IntPtr handle);
		public double X { get => libinput_event_touch_get_x(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_touch_get_y(IntPtr handle);
		public double Y { get => libinput_event_touch_get_y(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_touch_get_x_transformed(IntPtr handle, uint width);
		public double GetXTransformed(uint width) => libinput_event_touch_get_x_transformed(this.Handle, width);

		[DllImport("input")] private static extern double libinput_event_touch_get_y_transformed(IntPtr handle, uint height);
		public double GetYTransformed(uint height) => libinput_event_touch_get_y_transformed(this.Handle, height);
	}
}