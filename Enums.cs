namespace LibInput 
{
	public enum EV 
	{
		SYN = 0x00,
		KEY = 0x01,
		REL = 0x02,
		ABS = 0x03,
		MSC = 0x04,
		SW = 0x05,
		LED = 0x11,
		SND = 0x12,
		REP = 0x14,
		FF = 0x15,
		PWR = 0x16,
		FFSTATUS = 0x17,
		MAX = 0x1f,
		CNT = 0x1f + 1,
	}

	public enum SYN 
	{
		REPORT = 0,
		CONFIG = 1,
		MTREPORT = 2,
		DROPPED = 3,
		MAX = 0xf,
		CNT = 0xf + 1,
	}

	public enum EventType 
	{
		None = 0,
		DeviceAdded,
		DeviceRemoved,

		KeyboardKey = 300,

		PointerMotion = 400,
		PointerMotionAbsolute,
		PointerButton,
		PointerAxis,
		PointerScrollWheel,
		PointerScrollFinger,
		PointerScrollContinuous,

		TouchDown = 500,
		TouchUp,
		TouchMotion,
		TouchCancel,
		TouchFrame,
		TabletToolAxis = 600,
		TabletToolProximity,
		TabletToolTip,
		TabletToolButton,
		TabletPadButton = 700,
		TabletPadRing,
		TabletPadStrip,
		TabletPadKey,

		GestureSwipeBegin = 800,
		GestureSwipeUpdate,
		GestureSwipeEnd,
		GesturePinchBegin,
		GesturePinchUpdate,
		GesturePinchEnd,
		GestureHoldBegin,
		GestureHoldEnd,
		SwitchToggle = 900,
	}

	public enum KeyState 
	{
		Released = 0,
		Pressed = 1,
	}

	public enum ButtonState 
	{
		Released = 0,
		Pressed = 1,
	}

	public enum MouseAxis 
	{
		Vertical = 0,
		Horizontal = 1,
	}

	public enum MouseAxisSource 
	{
		Wheel = 1,
		Finger,
		Continuous,
		WheelTilt,
	}

	public enum PointerAxis 
	{
		Vertical = 0,
		Horizontal = 1,
	}

	public enum PointerAxisSource 
	{
		Wheel = 1,
		Finger,
		Continuous,
		WheelTilt,
	}

	public enum TabletToolProximityState 
	{
		Out = 0,
		In = 1,
	}

	public enum TabletToolTipState 
	{
		Up = 0,
		Down = 1,
	}

	public enum TabletToolType 
	{
		Pen = 1,
		Eraser,
		Brush,
		Pencil,
		AirBrush,
		Mouse,
		Lens,
		Totem,
	}

	public enum TabletPadRingAxisSource 
	{
		Unknown = 1,
		Finger,
	}

	public enum TabletPadStripAxisSource 
	{
		Unknown = 1,
		Finger,
	}

	public enum Switch 
	{
		Lid = 1,
		TabletMode,
	}

	public enum SwitchState 
	{
		Off = 0,
		On = 1,
	}

	// file:///usr/include/linux/input-event-codes.h
	public enum KeyCode 
	{
		Reserved = 0,
		Escape = 1,
		Alpha1 = 2,
		Alpha2 = 3,
		Alpha3 = 4,
		Alpha4 = 5,
		Alpha5 = 6,
		Alpha6 = 7,
		Alpha7 = 8,
		Alpha8 = 9,
		Alpha9 = 10,
		Alpha0 = 11,
		Minus = 12,
		Equal = 13,
		Backspace = 14,
		Tab = 15,
		Q = 16,
		W = 17,
		E = 18,
		R = 19,
		T = 20,
		Y = 21,
		U = 22,
		I = 23,
		O = 24,
		P = 25,
		LeftBrace = 26,
		RightBrace = 27,
		Enter = 28,
		LeftControl = 29,
		A = 30,
		S = 31,
		D = 32,
		F = 33,
		G = 34,
		H = 35,
		J = 36,
		K = 37,
		L = 38,
		Semicolon = 39,
		Apostrophe = 40,
		Grave = 41,
		LeftShift = 42,
		Backslash = 43,
		Z = 44,
		X = 45,
		C = 46,
		V = 47,
		B = 48,
		N = 49,
		M = 50,
		Comma = 51,
		Dot = 52,
		Slash = 53,
		RightShift = 54,
		KeypadAsterisk = 55,
		LeftAlt = 56,
		Space = 57,
		CapsLock = 58,
		F1 = 59,
		F2 = 60,
		F3 = 61,
		F4 = 62,
		F5 = 63,
		F6 = 64,
		F7 = 65,
		F8 = 66,
		F9 = 67,
		F10 = 68,
		NumLock = 69,
		ScrollLock = 70,
		Keypad7 = 71,
		Keypad8 = 72,
		Keypad9 = 73,
		KeypadMinus = 74,
		Keypad4 = 75,
		Keypad5 = 76,
		Keypad6 = 77,
		KeypadPlus = 78,
		Keypad1 = 79,
		Keypad2 = 80,
		Keypad3 = 81,
		Keypad0 = 82,
		KeypadDot = 83,

		Zenkakuhankaku = 85,
		// 102nd = 86,
		F11 = 87,
		F12 = 88,
		Ro = 89,
		Katakana = 90,
		Hiragana = 91,
		Henkan = 92,
		Katakanahiragana = 93,
		Muhenkan = 94,
		KeypadJpComma = 95,
		KeypadEnter = 96,
		RightControl = 97,
		KeypadSlash = 98,
		SysRq = 99,
		PrintScreen = 99,
		RightAlt = 100,
		LineFeed = 101,
		Home = 102,
		Up = 103,
		PageUp = 104,
		Left = 105,
		Right = 106,
		End = 107,
		Down = 108,
		PageDown = 109,
		Insert = 110,
		Delete = 111,
		Macro = 112,
		Mute = 113,
		VolumeDown = 114,
		VolumeUp = 115,
		Power = 116,
		KeypadEqual = 117,
		KeypadPlusminus = 118,
		Pause = 119,
		Scale = 120,

		KeypadComma = 121,
		Hangeul = 122,
		Hanguel = 122,
		Hanja = 123,
		Yen = 124,
		LeftMeta = 125,
		RightMeta = 126,
		Compose = 127,

		Stop = 128,
		Again = 129,
		Props = 130,
		Undo = 131,
		Front = 132,
		Copy = 133,
		Open = 134,
		Paste = 135,
		Find = 136,
		Cut = 137,
		Help = 138,
		Menu = 139,
		Calc = 140,
		Setup = 141,
		Sleep = 142,
		Wakeup = 143,
		File = 144,
		SendFile = 145,
		DeleteFile = 146,
		Xfer = 147,
		Prog1 = 148,
		Prog2 = 149,
		WWW = 150,
		MsDos = 151,
		Coffee = 152,
		ScreenLock = 152,
		RotateDisplay = 153,
		Direction = 153,
		Cyclewindows = 154,
		Mail = 155,
		Bookmarks = 156,
		Computer = 157,
		Back = 158,
		Forward = 159,
		CloseCD = 160,
		EjectCD = 161,
		EjectcloseCD = 162,
		NextSong = 163,
		PlayPause = 164,
		PreviousSong = 165,
		StopCD = 166,
		Record = 167,
		Rewind = 168,
		Phone = 169,
		Iso = 170,
		Config = 171,
		HomePage = 172,
		Refresh = 173,
		Exit = 174,
		Move = 175,
		Edit = 176,
		ScrollUp = 177,
		ScrollDown = 178,
		KeypadLeftParen = 179,
		KeypadRightParen = 180,
		New = 181,
		Redo = 182,

		F13 = 183,
		F14 = 184,
		F15 = 185,
		F16 = 186,
		F17 = 187,
		F18 = 188,
		F19 = 189,
		F20 = 190,
		F21 = 191,
		F22 = 192,
		F23 = 193,
		F24 = 194,

		PlayCD = 200,
		PauseCD = 201,
		Prog3 = 202,
		Prog4 = 203,
		AllApplications = 204,
		Dashboard = 204,
		Suspend = 205,
		Close = 206,
		Play = 207,
		FastForward = 208,
		BassBoost = 209,
		Print = 210,
		Hp = 211,
		Camera = 212,
		Sound = 213,
		Question = 214,
		Email = 215,
		Chat = 216,
		Search = 217,
		Connect = 218,
		Finance = 219,
		Sport = 220,
		Shop = 221,
		Alterase = 222,
		Cancel = 223,
		BrightnessDown = 224,
		BrightnessUp = 225,
		Media = 226,

		SwitchVideoMode = 227,
		Kbdillumtoggle = 228,
		Kbdillumdown = 229,
		Kbdillumup = 230,

		Send = 231,
		Reply = 232,
		ForwardMail = 233,
		Save = 234,
		Documents = 235,

		Battery = 236,

		Bluetooth = 237,
		WLAN = 238,
		UWB = 239,

		Unknown = 240,

		VideoNext = 241,
		VideoPrev = 242,
		BrightnessCycle = 243,
		BrightnessAuto = 244,
		BrightnessZero = 244,
		DisplayOff = 245,

		WWAN = 246,
		WiMax = 246,
		RfKill = 247,

		MicMute = 248,







		OK = 0x160,
		Select = 0x161,
		Goto = 0x162,
		Clear = 0x163,
		Power2 = 0x164,
		Option = 0x165,
		Info = 0x166,
		Time = 0x167,
		Vendor = 0x168,
		Archive = 0x169,
		Program = 0x16a,
		Channel = 0x16b,
		Favorites = 0x16c,
		EPG = 0x16d,
		PVR = 0x16e,
		Mhp = 0x16f,
		Language = 0x170,
		Title = 0x171,
		Subtitle = 0x172,
		Angle = 0x173,
		FullScreen = 0x174,
		Zoom = 0x174,
		Mode = 0x175,
		Keyboard = 0x176,
		AspectRatio = 0x177,
		Screen = 0x177,
		PC = 0x178,
		TV = 0x179,
		TV2 = 0x17a,
		VCR = 0x17b,
		VCR2 = 0x17c,
		Sat = 0x17d,
		Sat2 = 0x17e,
		CD = 0x17f,
		Tape = 0x180,
		Radio = 0x181,
		Tuner = 0x182,
		Player = 0x183,
		Text = 0x184,
		Dvd = 0x185,
		Aux = 0x186,
		MP3 = 0x187,
		Audio = 0x188,
		Video = 0x189,
		Directory = 0x18a,
		List = 0x18b,
		Memo = 0x18c,
		Calendar = 0x18d,
		Red = 0x18e,
		Green = 0x18f,
		Yellow = 0x190,
		Blue = 0x191,
		Channelup = 0x192,
		Channeldown = 0x193,
		First = 0x194,
		Last = 0x195,
		Ab = 0x196,
		Next = 0x197,
		Restart = 0x198,
		Slow = 0x199,
		Shuffle = 0x19a,
		Break = 0x19b,
		Previous = 0x19c,
		Digits = 0x19d,
		Teen = 0x19e,
		Twen = 0x19f,
		VideoPhone = 0x1a0,
		Games = 0x1a1,
		ZoomIn = 0x1a2,
		ZoomOut = 0x1a3,
		ZoomReset = 0x1a4,
		WordProcessor = 0x1a5,
		Editor = 0x1a6,
		Spreadsheet = 0x1a7,
		GraphicsEditor = 0x1a8,
		Presentation = 0x1a9,
		Database = 0x1aa,
		News = 0x1ab,
		VoiceMail = 0x1ac,
		AddressBook = 0x1ad,
		Messenger = 0x1ae,
		DisplayToggle = 0x1af,
		BrightnessToggle = 0x1af,
		Spellcheck = 0x1b0,  
		Logoff = 0x1b1,  

		Dollar = 0x1b2,
		Euro = 0x1b3,

		FrameBack = 0x1b4,
		FrameForward = 0x1b5,
		ContextMenu = 0x1b6,
		MediaRepeat = 0x1b7,
		Channels10Up = 0x1b8,
		Channels10Down = 0x1b9,
		Images = 0x1ba,
		NotificationCenter = 0x1bc,
		PickupPhone = 0x1bd,
		HangupPhone = 0x1be,

		DelEol = 0x1c0,
		DelEos = 0x1c1,
		InsLine = 0x1c2,
		DelLine = 0x1c3,

		Fn = 0x1d0,
		FnEsc = 0x1d1,
		FnF1 = 0x1d2,
		FnF2 = 0x1d3,
		FnF3 = 0x1d4,
		FnF4 = 0x1d5,
		FnF5 = 0x1d6,
		FnF6 = 0x1d7,
		FnF7 = 0x1d8,
		FnF8 = 0x1d9,
		FnF9 = 0x1da,
		FnF10 = 0x1db,
		FnF11 = 0x1dc,
		FnF12 = 0x1dd,
		Fn1 = 0x1de,
		Fn2 = 0x1df,
		FnD = 0x1e0,
		FnE = 0x1e1,
		FnF = 0x1e2,
		FnS = 0x1e3,
		FnB = 0x1e4,
		FnRightShift = 0x1e5,

		BrlDot1 = 0x1f1,
		BrlDot2 = 0x1f2,
		BrlDot3 = 0x1f3,
		BrlDot4 = 0x1f4,
		BrlDot5 = 0x1f5,
		BrlDot6 = 0x1f6,
		BrlDot7 = 0x1f7,
		BrlDot8 = 0x1f8,
		BrlDot9 = 0x1f9,
		BrlDot10 = 0x1fa,

		Numeric0 = 0x200,
		Numeric1 = 0x201,
		Numeric2 = 0x202,
		Numeric3 = 0x203,
		Numeric4 = 0x204,
		Numeric5 = 0x205,
		Numeric6 = 0x206,
		Numeric7 = 0x207,
		Numeric8 = 0x208,
		Numeric9 = 0x209,
		NumericStar = 0x20a,
		NumericPound = 0x20b,
		NumericA = 0x20c,
		NumericB = 0x20d,
		NumericC = 0x20e,
		NumericD = 0x20f,

		CameraFocus = 0x210,
		WpsButton = 0x211,

		TouchpadToggle = 0x212,
		TouchpadOn = 0x213,
		TouchpadOff = 0x214,

		CameraZoomin = 0x215,
		CameraZoomout = 0x216,
		CameraUp = 0x217,
		CameraDown = 0x218,
		CameraLeft = 0x219,
		CameraRight = 0x21a,

		AttendantOn = 0x21b,
		AttendantOff = 0x21c,
		AttendantToggle = 0x21d,
		LightsToggle = 0x21e,

		AlsToggle = 0x230,
		RotateLockToggle = 0x231,

		ButtonConfig = 0x240,
		TaskManager = 0x241,
		Journal = 0x242,
		Controlpanel = 0x243,
		Appselect = 0x244,
		Screensaver = 0x245,
		VoiceCommand = 0x246,
		Assistant = 0x247,
		KbdLayoutNext = 0x248,
		EmojiPicker = 0x249,
		Dictate = 0x24a,
		CameraAccessEnable = 0x24b,
		CameraAccessDisable = 0x24c,
		CameraAccessToggle = 0x24d,

		BrightnessMin = 0x250,
		BrightnessMax = 0x251,

		KbdInputAssistPrev = 0x260,
		KbdInputAssistNext = 0x261,
		KbdInputAssistPrevgroup = 0x262,
		KbdInputAssistNextgroup = 0x263,
		KbdInputAssistAccept = 0x264,
		KbdInputAssistCancel = 0x265,
		RightUp = 0x266,
		RightDown = 0x267,
		LeftUp = 0x268,
		LeftDown = 0x269,

		RootMenu = 0x26a,
		MediaTopMenu = 0x26b,
		Numeric11 = 0x26c,
		Numeric12 = 0x26d,

		AudioDesc = 0x26e,
		Mode3D = 0x26f,
		NextFavorite = 0x270,
		StopRecord = 0x271,
		PauseRecord = 0x272,
		VOD = 0x273,
		Unmute = 0x274,
		FastReverse = 0x275,
		SlowReverse = 0x276,

		Data = 0x277,
		OnScreenKeyboard = 0x278,
		PrivacyScreenToggle = 0x279,
		SelectiveScreenshot = 0x27a,
		NextElement = 0x27b,
		PreviousElement = 0x27c,
		AutopilotEngageToggle = 0x27d,
		MarkWaypoint = 0x27e,
		SOS = 0x27f,
		NavChart = 0x280,
		FishingChart = 0x281,
		SingleRangeRadar = 0x282,
		DualRangeRadar = 0x283,
		RadarOverlay = 0x284,
		TraditionalSonar = 0x285,
		ClearvuSonar = 0x286,
		SidevuSonar = 0x287,
		NavInfo = 0x288,
		BrightnessMenu = 0x289,

		Macro1 = 0x290,
		Macro2 = 0x291,
		Macro3 = 0x292,
		Macro4 = 0x293,
		Macro5 = 0x294,
		Macro6 = 0x295,
		Macro7 = 0x296,
		Macro8 = 0x297,
		Macro9 = 0x298,
		Macro10 = 0x299,
		Macro11 = 0x29a,
		Macro12 = 0x29b,
		Macro13 = 0x29c,
		Macro14 = 0x29d,
		Macro15 = 0x29e,
		Macro16 = 0x29f,
		Macro17 = 0x2a0,
		Macro18 = 0x2a1,
		Macro19 = 0x2a2,
		Macro20 = 0x2a3,
		Macro21 = 0x2a4,
		Macro22 = 0x2a5,
		Macro23 = 0x2a6,
		Macro24 = 0x2a7,
		Macro25 = 0x2a8,
		Macro26 = 0x2a9,
		Macro27 = 0x2aa,
		Macro28 = 0x2ab,
		Macro29 = 0x2ac,
		Macro30 = 0x2ad,

		MacroRecordStart = 0x2b0,
		MacroRecordStop = 0x2b1,
		MacroPresetCycle = 0x2b2,
		MacroPreset1 = 0x2b3,
		MacroPreset2 = 0x2b4,
		MacroPreset3 = 0x2b5,

		KbdLcdMenu1 = 0x2b8,
		KbdLcdMenu2 = 0x2b9,
		KbdLcdMenu3 = 0x2ba,
		KbdLcdMenu4 = 0x2bb,
		KbdLcdMenu5 = 0x2bc,
	}
}