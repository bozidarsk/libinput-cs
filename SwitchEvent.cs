using System;
using System.Runtime.InteropServices;

namespace LibInput 
{
	public sealed class SwitchEvent : Event
	{
		[DllImport("input")] private static extern Switch libinput_event_switch_get_switch(IntPtr handle);
		public Switch Switch { get => libinput_event_switch_get_switch(this.Handle); }

		[DllImport("input")] private static extern SwitchState libinput_event_switch_get_switch_state(IntPtr handle);
		public SwitchState SwitchState { get => libinput_event_switch_get_switch_state(this.Handle); }
	}
}