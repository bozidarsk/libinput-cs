using System;
using System.Runtime.InteropServices;

namespace LibInput 
{
	public class Event 
	{
		public EventType Type;
		public IntPtr Handle;

		[DllImport("input")] private static extern uint libinput_event_keyboard_get_time(IntPtr handle);
		[DllImport("input")] private static extern uint libinput_event_pointer_get_time(IntPtr handle);
		[DllImport("input")] private static extern uint libinput_event_touch_get_time(IntPtr handle);
		[DllImport("input")] private static extern uint libinput_event_gesture_get_time(IntPtr handle);
		[DllImport("input")] private static extern uint libinput_event_tablet_tool_get_time(IntPtr handle);
		[DllImport("input")] private static extern uint libinput_event_tablet_pad_get_time(IntPtr handle);
		[DllImport("input")] private static extern uint libinput_event_switch_get_time(IntPtr handle);
		public uint Time 
		{
			get 
			{
				string name = this.Type.ToString();
				if (name.StartsWith("Keyboard")) { return libinput_event_keyboard_get_time(this.Handle); }
				else if (name.StartsWith("Pointer")) { return libinput_event_pointer_get_time(this.Handle); }
				else if (name.StartsWith("Touch")) { return libinput_event_touch_get_time(this.Handle); }
				else if (name.StartsWith("Gesture")) { return libinput_event_gesture_get_time(this.Handle); }
				else if (name.StartsWith("TabletTool")) { return libinput_event_tablet_tool_get_time(this.Handle); }
				else if (name.StartsWith("TabletPad")) { return libinput_event_tablet_pad_get_time(this.Handle); }
				else if (name.StartsWith("Switch")) { return libinput_event_switch_get_time(this.Handle); }
				else { throw new ArgumentException($"'{this.Type}' is not implemented."); }
			}
		}

		[DllImport("input")] private static extern ulong libinput_event_keyboard_get_time_usec(IntPtr handle);
		[DllImport("input")] private static extern ulong libinput_event_pointer_get_time_usec(IntPtr handle);
		[DllImport("input")] private static extern ulong libinput_event_touch_get_time_usec(IntPtr handle);
		[DllImport("input")] private static extern ulong libinput_event_gesture_get_time_usec(IntPtr handle);
		[DllImport("input")] private static extern ulong libinput_event_tablet_tool_get_time_usec(IntPtr handle);
		[DllImport("input")] private static extern ulong libinput_event_tablet_pad_get_time_usec(IntPtr handle);
		[DllImport("input")] private static extern ulong libinput_event_switch_get_time_usec(IntPtr handle);
		public ulong TimeUSec 
		{
			get 
			{
				string name = this.Type.ToString();
				if (name.StartsWith("Keyboard")) { return libinput_event_keyboard_get_time_usec(this.Handle); }
				else if (name.StartsWith("Pointer")) { return libinput_event_pointer_get_time_usec(this.Handle); }
				else if (name.StartsWith("Touch")) { return libinput_event_touch_get_time_usec(this.Handle); }
				else if (name.StartsWith("Gesture")) { return libinput_event_gesture_get_time_usec(this.Handle); }
				else if (name.StartsWith("TabletTool")) { return libinput_event_tablet_tool_get_time_usec(this.Handle); }
				else if (name.StartsWith("TabletPad")) { return libinput_event_tablet_pad_get_time_usec(this.Handle); }
				else if (name.StartsWith("Switch")) { return libinput_event_switch_get_time_usec(this.Handle); }
				else { throw new ArgumentException($"'{this.Type}' is not implemented."); }
			}
		}

		[DllImport("input")] private static extern IntPtr libinput_event_keyboard_get_base_event(IntPtr handle);
		[DllImport("input")] private static extern IntPtr libinput_event_pointer_get_base_event(IntPtr handle);
		[DllImport("input")] private static extern IntPtr libinput_event_touch_get_base_event(IntPtr handle);
		[DllImport("input")] private static extern IntPtr libinput_event_gesture_get_base_event(IntPtr handle);
		[DllImport("input")] private static extern IntPtr libinput_event_tablet_tool_get_base_event(IntPtr handle);
		[DllImport("input")] private static extern IntPtr libinput_event_tablet_pad_get_base_event(IntPtr handle);
		[DllImport("input")] private static extern IntPtr libinput_event_switch_get_base_event(IntPtr handle);
		public IntPtr BaseEvent 
		{
			get 
			{
				string name = this.Type.ToString();
				if (name.StartsWith("Keyboard")) { return libinput_event_keyboard_get_base_event(this.Handle); }
				else if (name.StartsWith("Pointer")) { return libinput_event_pointer_get_base_event(this.Handle); }
				else if (name.StartsWith("Touch")) { return libinput_event_touch_get_base_event(this.Handle); }
				else if (name.StartsWith("Gesture")) { return libinput_event_gesture_get_base_event(this.Handle); }
				else if (name.StartsWith("TabletTool")) { return libinput_event_tablet_tool_get_base_event(this.Handle); }
				else if (name.StartsWith("TabletPad")) { return libinput_event_tablet_pad_get_base_event(this.Handle); }
				else if (name.StartsWith("Switch")) { return libinput_event_switch_get_base_event(this.Handle); }
				else { throw new ArgumentException($"'{this.Type}' is not implemented."); }
			}
		}

		[DllImport("input")] private static extern IntPtr libinput_path_create_context(IntPtr libinputInterface, IntPtr userData);
		[DllImport("input")] private static extern IntPtr libinput_path_add_device(IntPtr libinput, IntPtr path);
		[DllImport("input")] private static extern int libinput_dispatch(IntPtr libinput);
		[DllImport("input")] private static extern EventType libinput_next_event_type(IntPtr libinput);
		[DllImport("input")] private static extern IntPtr libinput_get_event(IntPtr libinput);
		[DllImport("input")] private static extern int open(IntPtr file, int flags);
		[DllImport("input")] private static extern void close(int fd);

		private delegate int OpenDeviceDelegate(IntPtr path, int flags, IntPtr userData);
		private delegate void CloseDeviceDelegate(int fd, IntPtr userData);
		private static IntPtr input = Initialize();
		private static IntPtr Initialize() 
		{
			OpenDeviceDelegate openDevice = (IntPtr path, int flags, IntPtr userData) => open(path, flags);
			CloseDeviceDelegate closeDevice = (int fd, IntPtr userData) => close(fd);

			Interface libinputInterface;
			libinputInterface.OpenRestricted = Marshal.GetFunctionPointerForDelegate(openDevice);
			libinputInterface.CloseRestricted = Marshal.GetFunctionPointerForDelegate(closeDevice);

			IntPtr interfacePtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(Interface)));
			Marshal.StructureToPtr(libinputInterface, interfacePtr, false);

			input = libinput_path_create_context(interfacePtr, IntPtr.Zero);

			for (int i = 0; System.IO.File.Exists($"/dev/input/event{i}"); i++) 
			{ libinput_path_add_device(input, Marshal.StringToCoTaskMemUTF8($"/dev/input/event{i}")); }

			return input;
		}

		public static bool TryGetEvent(out Event e) 
		{
			libinput_dispatch(input);

			EventType type = libinput_next_event_type(input);
			IntPtr handle = libinput_get_event(input);

			string name = type.ToString();
			if (name.StartsWith("Keyboard")) { e = new KeyboardEvent(); }
			else if (name.StartsWith("Pointer")) { e = new PointerEvent(); }
			else if (name.StartsWith("Touch")) { e = new TouchEvent(); }
			else if (name.StartsWith("Gesture")) { e = new GestureEvent(); }
			else if (name.StartsWith("TabletTool")) { e = new TabletToolEvent(); }
			else if (name.StartsWith("TabletPad")) { e = new TabletPadEvent(); }
			else if (name.StartsWith("Switch")) { e = new SwitchEvent(); }
			else { e = new Event(); }

			e.Type = type;
			e.Handle = handle;
			return e.Handle != IntPtr.Zero;
		}

		private struct Interface 
		{
			public IntPtr OpenRestricted;
			public IntPtr CloseRestricted;
		}
	}
}