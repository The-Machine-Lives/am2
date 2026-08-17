using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x2000012")]
	internal class SettingsOverlay
	{
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D088", Offset = "0x81D088")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81D088", Offset = "0x81D088")]
		private bool _003CIsVisible_003Ek__BackingField;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x14")]
		private Rect _settingsButtonRect;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x28")]
		private DebugConsole _debugConsole;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D0C4", Offset = "0x81D0C4")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81D0C4", Offset = "0x81D0C4")]
		private Rect _003CRect_003Ek__BackingField;

		[Token(Token = "0x1700002E")]
		public bool IsVisible
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xE7DECC", Offset = "0xE7DECC", VA = "0xE7DECC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DD68", Offset = "0x81DD68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xE7BA70", Offset = "0xE7BA70", VA = "0xE7BA70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DD78", Offset = "0x81DD78")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public Rect SettingsButtonRect
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xE7E4EC", Offset = "0xE7E4EC", VA = "0xE7E4EC")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xE88C44", Offset = "0xE88C44", VA = "0xE88C44")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public Rect Rect
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xE7DED4", Offset = "0xE7DED4", VA = "0xE7DED4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DD88", Offset = "0x81DD88")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xE90508", Offset = "0xE90508", VA = "0xE90508")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DD98", Offset = "0x81DD98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		private int Height
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xE9040C", Offset = "0xE9040C", VA = "0xE9040C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000032")]
		private int Width
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xE9039C", Offset = "0xE9039C", VA = "0xE9039C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xE7AC70", Offset = "0xE7AC70", VA = "0xE7AC70")]
		public SettingsOverlay(DebugConsole debugConsole)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xE7DEE0", Offset = "0xE7DEE0", VA = "0xE7DEE0")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xE90514", Offset = "0xE90514", VA = "0xE90514")]
		private void EmailLog()
		{
		}
	}
}
