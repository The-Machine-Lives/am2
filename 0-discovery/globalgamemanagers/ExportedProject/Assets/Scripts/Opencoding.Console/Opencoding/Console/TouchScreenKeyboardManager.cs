using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x2000018")]
	internal static class TouchScreenKeyboardManager
	{
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x0")]
		private static TouchScreenKeyboardProxy _touchScreenKeyboard;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x8")]
		private static TouchScreenKeyboardInput _currentInput;

		[Token(Token = "0x17000069")]
		public static bool IsAnyInputActive
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x17DE03C", Offset = "0x17DE03C", VA = "0x17DE03C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		public static Rect? KeyboardArea
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x17DE094", Offset = "0x17DE094", VA = "0x17DE094")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x17DCC28", Offset = "0x17DCC28", VA = "0x17DCC28")]
		public static void Update()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x17DD138", Offset = "0x17DD138", VA = "0x17DD138")]
		public static void OnGUI()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x17DD274", Offset = "0x17DD274", VA = "0x17DD274")]
		public static Rect GetTouchScreenKeyboardCloseButtonRect()
		{
			return default(Rect);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x17DCA80", Offset = "0x17DCA80", VA = "0x17DCA80")]
		public static void InputChanged(TouchScreenKeyboardInput input)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x17DD92C", Offset = "0x17DD92C", VA = "0x17DD92C")]
		public static void Activate(TouchScreenKeyboardInput input)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x17DDFE0", Offset = "0x17DDFE0", VA = "0x17DDFE0")]
		public static bool IsActive(TouchScreenKeyboardInput input)
		{
			return default(bool);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x17DE208", Offset = "0x17DE208", VA = "0x17DE208")]
		private static int GetAndroidKeyboardSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x17DE618", Offset = "0x17DE618", VA = "0x17DE618")]
		public static void Deactivate(TouchScreenKeyboardInput input)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x17DD6FC", Offset = "0x17DD6FC", VA = "0x17DD6FC")]
		public static void Deactivate()
		{
		}
	}
}
