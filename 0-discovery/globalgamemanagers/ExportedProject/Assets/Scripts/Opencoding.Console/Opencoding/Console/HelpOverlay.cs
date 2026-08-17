using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Opencoding.CommandHandlerSystem;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x200000D")]
	internal class HelpOverlay : IDisposable
	{
		[Serializable]
		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C92C", Offset = "0x81C92C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000138")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000139")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<CommandHandler> _003C_003E9__10_0;

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xE890B8", Offset = "0xE890B8", VA = "0xE890B8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xE890C0", Offset = "0xE890C0", VA = "0xE890C0")]
			internal int _003CResortRecentCommandList_003Eb__10_0(CommandHandler a, CommandHandler b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81CF20", Offset = "0x81CF20")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81CF20", Offset = "0x81CF20")]
		private bool _003CIsVisible_003Ek__BackingField;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x14")]
		private Vector2 _scrollPosition;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x20")]
		private List<CommandHandler> _sortedCommandList;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x28")]
		private DebugConsole _debugConsole;

		[Token(Token = "0x1700001D")]
		public bool IsVisible
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xE7C4C8", Offset = "0xE7C4C8", VA = "0xE7C4C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DCA8", Offset = "0x81DCA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xE7BA7C", Offset = "0xE7BA7C", VA = "0xE7BA7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DCB8", Offset = "0x81DCB8")]
			set
			{
			}
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xE7A644", Offset = "0xE7A644", VA = "0xE7A644")]
		public HelpOverlay(DebugConsole debugConsole)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE7C4DC", Offset = "0xE7C4DC", VA = "0xE7C4DC")]
		public void OnGUI(Rect rect)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xE88D04", Offset = "0xE88D04", VA = "0xE88D04")]
		private void HandleButtonPress(CommandHandler commandHandler)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xE88E60", Offset = "0xE88E60", VA = "0xE88E60")]
		private void ResortRecentCommandList()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xE88F64", Offset = "0xE88F64", VA = "0xE88F64")]
		private void OnCommandHandlerAdded(CommandHandler commandHandler)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xE88FDC", Offset = "0xE88FDC", VA = "0xE88FDC")]
		private void OnCommandHandlerRemoved(CommandHandler commandHandler)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xE7AE38", Offset = "0xE7AE38", VA = "0xE7AE38", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
