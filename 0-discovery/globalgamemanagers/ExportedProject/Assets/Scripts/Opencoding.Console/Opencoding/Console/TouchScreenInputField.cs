using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x2000014")]
	internal class TouchScreenInputField : InputField
	{
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x30")]
		private TouchScreenKeyboardInput _touchScreenKeyboardInput;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x38")]
		private Rect _commandInputRect;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x48")]
		private readonly InputHistory _inputHistory;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x50")]
		private readonly LogHistoryView _logHistoryView;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x58")]
		private readonly HelpOverlay _helpOverlay;

		[Token(Token = "0x17000033")]
		public override string Input
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xE92088", Offset = "0xE92088", VA = "0xE92088", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xE920B8", Offset = "0xE920B8", VA = "0xE920B8", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public override bool HasFocus
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xE921A4", Offset = "0xE921A4", VA = "0xE921A4", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public override Rect TextFieldRect
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xE921B0", Offset = "0xE921B0", VA = "0xE921B0", Slot = "7")]
			get
			{
				return default(Rect);
			}
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xE7AA80", Offset = "0xE7AA80", VA = "0xE7AA80")]
		public TouchScreenInputField(InputHistory inputHistory, LogHistoryView logHistoryView, HelpOverlay helpOverlay)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xE921BC", Offset = "0xE921BC", VA = "0xE921BC", Slot = "8")]
		public override void OnGUI(Rect containingRect)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xE92954", Offset = "0xE92954", VA = "0xE92954")]
		private void ExecuteInput()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xE92A78", Offset = "0xE92A78", VA = "0xE92A78", Slot = "9")]
		public override void LoseFocus()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xE92A84", Offset = "0xE92A84", VA = "0xE92A84", Slot = "11")]
		public override void ClearInput()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xE92AE8", Offset = "0xE92AE8", VA = "0xE92AE8", Slot = "10")]
		public override void Focus()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xE92124", Offset = "0xE92124", VA = "0xE92124")]
		private void ShowInputForConsole()
		{
		}
	}
}
