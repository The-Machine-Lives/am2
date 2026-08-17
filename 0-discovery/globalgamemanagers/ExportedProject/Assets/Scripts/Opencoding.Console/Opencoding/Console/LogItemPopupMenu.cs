using Il2CppDummyDll;
using Opencoding.LogHistory;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x2000011")]
	internal class LogItemPopupMenu
	{
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81CFD4", Offset = "0x81CFD4")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81CFD4", Offset = "0x81CFD4")]
		private bool _003CIsVisible_003Ek__BackingField;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D010", Offset = "0x81D010")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81D010", Offset = "0x81D010")]
		private Rect _003CRect_003Ek__BackingField;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D04C", Offset = "0x81D04C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81D04C", Offset = "0x81D04C")]
		private LogHistoryItem _003CTargetLogHistoryItem_003Ek__BackingField;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 _position;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x38")]
		private readonly DebugConsole _debugConsole;

		[Token(Token = "0x1700002A")]
		public bool IsVisible
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xE7937C", Offset = "0xE7937C", VA = "0xE7937C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DD08", Offset = "0x81DD08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xE7BA88", Offset = "0xE7BA88", VA = "0xE7BA88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DD18", Offset = "0x81DD18")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Rect Rect
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xE7D200", Offset = "0xE7D200", VA = "0xE7D200")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DD28", Offset = "0x81DD28")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xE8EAA8", Offset = "0xE8EAA8", VA = "0xE8EAA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DD38", Offset = "0x81DD38")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public LogHistoryItem TargetLogHistoryItem
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xE8E280", Offset = "0xE8E280", VA = "0xE8E280")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DD48", Offset = "0x81DD48")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0xE8EAB4", Offset = "0xE8EAB4", VA = "0xE8EAB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DD58", Offset = "0x81DD58")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		private static bool IsHorizontal
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0xE8EABC", Offset = "0xE8EABC", VA = "0xE8EABC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xE7A454", Offset = "0xE7A454", VA = "0xE7A454")]
		public LogItemPopupMenu(DebugConsole debugConsole)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xE8E9F4", Offset = "0xE8E9F4", VA = "0xE8E9F4")]
		public void Show(Vector2 position, LogHistoryItem logHistoryItem)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xE7CE78", Offset = "0xE7CE78", VA = "0xE7CE78")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xE8EB2C", Offset = "0xE8EB2C", VA = "0xE8EB2C")]
		private void WindowFunc(int id)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xE8F5F0", Offset = "0xE8F5F0", VA = "0xE8F5F0")]
		private void Separator()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xE8F17C", Offset = "0xE8F17C", VA = "0xE8F17C")]
		private bool Button(string text)
		{
			return default(bool);
		}
	}
}
