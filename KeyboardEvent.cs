using System;
using System.Runtime.InteropServices;

namespace LibInput 
{
	public sealed class KeyboardEvent : Event
	{
		[DllImport("input")] private static extern KeyCode libinput_event_keyboard_get_key(IntPtr handle);
		public KeyCode Key { get => libinput_event_keyboard_get_key(this.Handle); }

		[DllImport("input")] private static extern KeyState libinput_event_keyboard_get_key_state(IntPtr handle);
		public KeyState State { get => libinput_event_keyboard_get_key_state(this.Handle); }

		[DllImport("input")] private static extern uint libinput_event_keyboard_get_seat_key_count(IntPtr handle);
		public uint SeatKeyCount { get => libinput_event_keyboard_get_seat_key_count(this.Handle); }
	}
}