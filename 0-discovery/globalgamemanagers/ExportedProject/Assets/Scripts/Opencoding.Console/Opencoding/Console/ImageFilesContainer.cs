using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x2000004")]
	public class ImageFilesContainer : ScriptableObject
	{
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D _ActiveGradient;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D _BackgroundGradient;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D _CheckboxChecked;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D _CheckboxUnchecked;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D _ClearIcon;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D _CloseButton;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x48")]
		public Texture2D _ConsoleInputIcon;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x50")]
		public Texture2D _SettingsPopupBackground;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x58")]
		public Texture2D _HighlightGradient;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x60")]
		public Texture2D _MaximizeIcon;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x68")]
		public Texture2D _MinimizeTopIcon;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x70")]
		public Texture2D _RedBackgroundGradient;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x78")]
		public Texture2D _FilterActiveIcon;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x80")]
		public Texture2D _SearchIcon;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x88")]
		public Texture2D _SettingsIcon;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x90")]
		public Texture2D _PreviousHistoryItemIcon;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x98")]
		public Texture2D _NextHistoryItemIcon;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0xA0")]
		public Texture2D _CloseKeyboardIcon;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0xA8")]
		public Texture2D _SuggestionButtonBackground;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0xB0")]
		public Texture2D _ScrollbarThumb;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0xB8")]
		public Texture2D _HelpIcon;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0xC0")]
		public Texture2D _RunIcon;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0xC8")]
		public Texture2D _InfoIcon;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0xD0")]
		public Texture2D _ErrorIcon;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0xD8")]
		public Texture2D _WarningIcon;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0xE0")]
		public Texture2D _ExceptionIcon;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0xE8")]
		public Texture2D _AssertIcon;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xE89160", Offset = "0xE89160", VA = "0xE89160")]
		public ImageFilesContainer()
		{
		}
	}
}
