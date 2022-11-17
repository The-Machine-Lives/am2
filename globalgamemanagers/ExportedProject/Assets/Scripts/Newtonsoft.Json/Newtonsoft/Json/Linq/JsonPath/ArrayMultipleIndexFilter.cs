using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Token(Token = "0x20000E3")]
	[Preserve]
	internal class ArrayMultipleIndexFilter : PathFilter
	{
		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F2B8", Offset = "0x80F2B8")]
		private sealed class _003CExecuteFilter_003Ed__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400035D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400035E")]
			[FieldOffset(Offset = "0x18")]
			private JToken _003C_003E2__current;

			[Token(Token = "0x400035F")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4000360")]
			[FieldOffset(Offset = "0x28")]
			private IEnumerable<JToken> current;

			[Token(Token = "0x4000361")]
			[FieldOffset(Offset = "0x30")]
			public IEnumerable<JToken> _003C_003E3__current;

			[Token(Token = "0x4000362")]
			[FieldOffset(Offset = "0x38")]
			public ArrayMultipleIndexFilter _003C_003E4__this;

			[Token(Token = "0x4000363")]
			[FieldOffset(Offset = "0x40")]
			private JToken _003Ct_003E5__1;

			[Token(Token = "0x4000364")]
			[FieldOffset(Offset = "0x48")]
			private bool errorWhenNoMatch;

			[Token(Token = "0x4000365")]
			[FieldOffset(Offset = "0x49")]
			public bool _003C_003E3__errorWhenNoMatch;

			[Token(Token = "0x4000366")]
			[FieldOffset(Offset = "0x50")]
			private IEnumerator<JToken> _003C_003E7__wrap1;

			[Token(Token = "0x4000367")]
			[FieldOffset(Offset = "0x58")]
			private List<int>.Enumerator _003C_003E7__wrap2;

			[Token(Token = "0x17000155")]
			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[Token(Token = "0x600076E")]
				[Address(RVA = "0xD0335C", Offset = "0xD0335C", VA = "0xD0335C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000156")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000770")]
				[Address(RVA = "0xD033CC", Offset = "0xD033CC", VA = "0xD033CC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0xD02E4C", Offset = "0xD02E4C", VA = "0xD02E4C")]
			[DebuggerHidden]
			public _003CExecuteFilter_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0xD02EA4", Offset = "0xD02EA4", VA = "0xD02EA4", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0xD0302C", Offset = "0xD0302C", VA = "0xD0302C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0xD02F6C", Offset = "0xD02F6C", VA = "0xD02F6C")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0xD02F14", Offset = "0xD02F14", VA = "0xD02F14")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0xD03364", Offset = "0xD03364", VA = "0xD03364", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0xD033D4", Offset = "0xD033D4", VA = "0xD033D4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0xD034A4", Offset = "0xD034A4", VA = "0xD034A4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FC08", Offset = "0x80FC08")]
		private List<int> _003CIndexes_003Ek__BackingField;

		[Token(Token = "0x17000154")]
		public List<int> Indexes
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0xD02D98", Offset = "0xD02D98", VA = "0xD02D98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811334", Offset = "0x811334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xD02DA0", Offset = "0xD02DA0", VA = "0xD02DA0", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xD02E9C", Offset = "0xD02E9C", VA = "0xD02E9C")]
		public ArrayMultipleIndexFilter()
		{
		}
	}
}
