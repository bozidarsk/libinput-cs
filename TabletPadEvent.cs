using System;
using System.Runtime.InteropServices;

namespace LibInput 
{
	public sealed class TabletPadEvent : Event
	{
		[DllImport("input")] private static extern double libinput_event_tablet_pad_get_ring_position(IntPtr handle);
		public double RingPosition { get => libinput_event_tablet_pad_get_ring_position(this.Handle); }

		[DllImport("input")] private static extern uint libinput_event_tablet_pad_get_ring_number(IntPtr handle);
		public uint RingNumber { get => libinput_event_tablet_pad_get_ring_number(this.Handle); }

		[DllImport("input")] private static extern TabletPadRingAxisSource libinput_event_tablet_pad_get_ring_source(IntPtr handle);
		public TabletPadRingAxisSource RingSource { get => libinput_event_tablet_pad_get_ring_source(this.Handle); }

		[DllImport("input")] private static extern double libinput_event_tablet_pad_get_strip_position(IntPtr handle);
		public double StripPosition { get => libinput_event_tablet_pad_get_strip_position(this.Handle); }

		[DllImport("input")] private static extern uint libinput_event_tablet_pad_get_strip_number(IntPtr handle);
		public uint StripNumber { get => libinput_event_tablet_pad_get_strip_number(this.Handle); }

		[DllImport("input")] private static extern TabletPadStripAxisSource libinput_event_tablet_pad_get_strip_source(IntPtr handle);
		public TabletPadStripAxisSource StripSource { get => libinput_event_tablet_pad_get_strip_source(this.Handle); }

		[DllImport("input")] private static extern uint libinput_event_tablet_pad_get_button_number(IntPtr handle);
		public uint ButtonNumber { get => libinput_event_tablet_pad_get_button_number(this.Handle); }

		[DllImport("input")] private static extern ButtonState libinput_event_tablet_pad_get_button_state(IntPtr handle);
		public ButtonState ButtonState { get => libinput_event_tablet_pad_get_button_state(this.Handle); }

		[DllImport("input")] private static extern uint libinput_event_tablet_pad_get_key(IntPtr handle);
		public uint Key { get => libinput_event_tablet_pad_get_key(this.Handle); }

		[DllImport("input")] private static extern KeyState libinput_event_tablet_pad_get_key_state(IntPtr handle);
		public KeyState KeyState { get => libinput_event_tablet_pad_get_key_state(this.Handle); }

		[DllImport("input")] private static extern uint libinput_event_tablet_pad_get_mode(IntPtr handle);
		public uint Mode { get => libinput_event_tablet_pad_get_mode(this.Handle); }

		[DllImport("input")] private static extern IntPtr libinput_event_tablet_pad_get_mode_group(IntPtr handle);
		public TabletPadModeGroup ModeGroup { get => new TabletPadModeGroup() { Handle = libinput_event_tablet_pad_get_mode_group(this.Handle) }; }
	}

	public sealed class TabletPadModeGroup 
	{
		public IntPtr Handle;

		[DllImport("input")] private static extern uint libinput_tablet_pad_mode_group_get_index(IntPtr handle);
		public uint Index { get => libinput_tablet_pad_mode_group_get_index(this.Handle); }

		[DllImport("input")] private static extern uint libinput_tablet_pad_mode_group_get_num_modes(IntPtr handle);
		public uint NumModes { get => libinput_tablet_pad_mode_group_get_num_modes(this.Handle); }

		[DllImport("input")] private static extern uint libinput_tablet_pad_mode_group_get_mode(IntPtr handle);
		public uint Mode { get => libinput_tablet_pad_mode_group_get_mode(this.Handle); }

		[DllImport("input")] private static extern bool libinput_tablet_pad_mode_group_has_button(IntPtr handle, uint button);
		public bool HasButton(uint button) => libinput_tablet_pad_mode_group_has_button(this.Handle, button);

		[DllImport("input")] private static extern bool libinput_tablet_pad_mode_group_has_ring(IntPtr handle, uint ring);
		public bool HasRing(uint ring) => libinput_tablet_pad_mode_group_has_ring(this.Handle, ring);

		[DllImport("input")] private static extern bool libinput_tablet_pad_mode_group_has_strip(IntPtr handle, uint strip);
		public bool HasStrip(uint strip) => libinput_tablet_pad_mode_group_has_strip(this.Handle, strip);

		[DllImport("input")] private static extern bool libinput_tablet_pad_mode_group_button_is_toggle(IntPtr handle, uint button);
		public bool IsButtonToggle(uint button) => libinput_tablet_pad_mode_group_button_is_toggle(this.Handle, button);

		[DllImport("input")] private static extern IntPtr libinput_tablet_pad_mode_group_ref(IntPtr handle);
		public IntPtr Ref() => libinput_tablet_pad_mode_group_ref(this.Handle);

		[DllImport("input")] private static extern IntPtr libinput_tablet_pad_mode_group_unref(IntPtr handle);
		public IntPtr Unref() => libinput_tablet_pad_mode_group_unref(this.Handle);

		[DllImport("input")] private static extern void libinput_tablet_pad_mode_group_set_user_data(IntPtr handle, IntPtr data);
		[DllImport("input")] private static extern IntPtr libinput_tablet_pad_mode_group_get_user_data(IntPtr handle);
		public IntPtr UserData 
		{
			set => libinput_tablet_pad_mode_group_set_user_data(this.Handle, value);
			get => libinput_tablet_pad_mode_group_get_user_data(this.Handle);
		}
	}
}