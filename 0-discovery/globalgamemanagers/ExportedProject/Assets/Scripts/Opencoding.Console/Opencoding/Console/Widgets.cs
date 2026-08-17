using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x200001A")]
	internal static class Widgets
	{
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x0")]
		private static float _timeOfMouseDown;

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x17DF46C", Offset = "0x17DF46C", VA = "0x17DF46C")]
		public static void VerticalSeparator()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x17DF648", Offset = "0x17DF648", VA = "0x17DF648")]
		public static void HorizontalSeparator()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x17DF824", Offset = "0x17DF824", VA = "0x17DF824")]
		public static bool Button(string text)
		{
			return default(bool);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x17DFB04", Offset = "0x17DFB04", VA = "0x17DFB04")]
		public static bool Button(Texture2D icon, Texture2D backgroundImage, string text, int iconSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x17DF860", Offset = "0x17DF860", VA = "0x17DF860")]
		public static bool Button(Texture2D icon, Texture2D backgroundImage, string text, int iconSize, out bool wasButtonHeldDown)
		{
			return default(bool);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x17E00C0", Offset = "0x17E00C0", VA = "0x17E00C0")]
		public static bool Button(Rect rect, Texture2D icon, Texture2D backgroundImage, string text, int iconSize, int padding)
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x17DFB2C", Offset = "0x17DFB2C", VA = "0x17DFB2C")]
		public static bool Button(Rect rect, Texture2D icon, Texture2D backgroundImage, string text, int iconSize, int padding, out bool wasButtonHeldDown)
		{
			return default(bool);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x17DD3BC", Offset = "0x17DD3BC", VA = "0x17DD3BC")]
		public static bool SimpleImageButton(Rect rect, Texture2D icon)
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x17E00E8", Offset = "0x17E00E8", VA = "0x17E00E8")]
		public static bool Checkbox(bool isChecked, string text)
		{
			return default(bool);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x17E0228", Offset = "0x17E0228", VA = "0x17E0228")]
		public static bool HighlightHeaderButton(Texture2D icon, string text, bool isHighlighted, bool isActive, out bool wasButtonHeldDown)
		{
			return default(bool);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x17E045C", Offset = "0x17E045C", VA = "0x17E045C")]
		public static bool ToggleHeaderButton(Texture2D icon, string text, bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x17E0494", Offset = "0x17E0494", VA = "0x17E0494")]
		public static bool ToggleHeaderButton(Texture2D icon, string text, bool value, out bool wasButtonHeldDown)
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x17E04CC", Offset = "0x17E04CC", VA = "0x17E04CC")]
		public static bool HeaderButton(Texture2D icon)
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x17E0584", Offset = "0x17E0584", VA = "0x17E0584")]
		public static bool OverlayHeaderButton(Texture2D icon, string text, bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x17E05BC", Offset = "0x17E05BC", VA = "0x17E05BC")]
		public static bool HeaderButton(Texture2D icon, Texture2D backgroundImage, string text)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x17E0380", Offset = "0x17E0380", VA = "0x17E0380")]
		public static bool HeaderButton(Texture2D icon, Texture2D backgroundImage, string text, out bool wasButtonHeldDown)
		{
			return default(bool);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x17E05E4", Offset = "0x17E05E4", VA = "0x17E05E4")]
		public static void TouchFriendlyTextField(TouchScreenKeyboardInput touchScreenKeyboardInput, GUIStyle style, params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x17E09D0", Offset = "0x17E09D0", VA = "0x17E09D0")]
		public static string FixedSizeTextField(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return null;
		}
	}
}
