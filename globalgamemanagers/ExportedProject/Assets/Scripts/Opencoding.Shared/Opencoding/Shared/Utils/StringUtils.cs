using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Opencoding.Shared.Utils
{
	[Token(Token = "0x2000006")]
	public static class StringUtils
	{
		[Token(Token = "0x2000007")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x808118", Offset = "0x808118")]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			[Token(Token = "0x400000C")]
			[FieldOffset(Offset = "0x10")]
			public bool inQuotes;

			[Token(Token = "0x600001A")]
			[Address(RVA = "0x18129EC", Offset = "0x18129EC", VA = "0x18129EC")]
			public _003C_003Ec__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600001B")]
			[Address(RVA = "0x1812CBC", Offset = "0x1812CBC", VA = "0x1812CBC")]
			internal bool _003CSplitCommandLine_003Eb__0(char c)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000008")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x808128", Offset = "0x808128")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x8")]
			public static Func<string, string> _003C_003E9__0_1;

			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x10")]
			public static Func<string, bool> _003C_003E9__0_2;

			[Token(Token = "0x600001D")]
			[Address(RVA = "0x1812C58", Offset = "0x1812C58", VA = "0x1812C58")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600001E")]
			[Address(RVA = "0x1812C60", Offset = "0x1812C60", VA = "0x1812C60")]
			internal string _003CSplitCommandLine_003Eb__0_1(string arg)
			{
				return null;
			}

			[Token(Token = "0x600001F")]
			[Address(RVA = "0x1812C98", Offset = "0x1812C98", VA = "0x1812C98")]
			internal bool _003CSplitCommandLine_003Eb__0_2(string arg)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x808138", Offset = "0x808138")]
		private sealed class _003CSplit_003Ed__1 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x18")]
			private string _003C_003E2__current;

			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x28")]
			private string str;

			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x30")]
			public string _003C_003E3__str;

			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x38")]
			private Func<char, bool> controller;

			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x40")]
			public Func<char, bool> _003C_003E3__controller;

			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x48")]
			private int _003CnextPiece_003E5__1;

			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x4C")]
			private int _003Cc_003E5__2;

			[Token(Token = "0x1700000B")]
			private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
			{
				[Token(Token = "0x6000023")]
				[Address(RVA = "0x1812E88", Offset = "0x1812E88", VA = "0x1812E88", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000025")]
				[Address(RVA = "0x1812EF8", Offset = "0x1812EF8", VA = "0x1812EF8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000020")]
			[Address(RVA = "0x1812A88", Offset = "0x1812A88", VA = "0x1812A88")]
			[DebuggerHidden]
			public _003CSplit_003Ed__1(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000021")]
			[Address(RVA = "0x1812CEC", Offset = "0x1812CEC", VA = "0x1812CEC", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000022")]
			[Address(RVA = "0x1812CF0", Offset = "0x1812CF0", VA = "0x1812CF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000024")]
			[Address(RVA = "0x1812E90", Offset = "0x1812E90", VA = "0x1812E90", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x1812F00", Offset = "0x1812F00", VA = "0x1812F00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EString_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1812FDC", Offset = "0x1812FDC", VA = "0x1812FDC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x18127DC", Offset = "0x18127DC", VA = "0x18127DC")]
		public static IEnumerable<string> SplitCommandLine(string commandLine)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x18129F4", Offset = "0x18129F4", VA = "0x18129F4")]
		public static IEnumerable<string> Split(this string str, Func<char, bool> controller)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1812AD8", Offset = "0x1812AD8", VA = "0x1812AD8")]
		public static string TrimMatchingQuotes(this string input, char quote)
		{
			return null;
		}
	}
}
