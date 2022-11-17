using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Token(Token = "0x20000E1")]
	[Preserve]
	internal class ArrayIndexFilter : PathFilter
	{
		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F298", Offset = "0x80F298")]
		private sealed class _003CExecuteFilter_003Ed__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000351")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000352")]
			[FieldOffset(Offset = "0x18")]
			private JToken _003C_003E2__current;

			[Token(Token = "0x4000353")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4000354")]
			[FieldOffset(Offset = "0x28")]
			private IEnumerable<JToken> current;

			[Token(Token = "0x4000355")]
			[FieldOffset(Offset = "0x30")]
			public IEnumerable<JToken> _003C_003E3__current;

			[Token(Token = "0x4000356")]
			[FieldOffset(Offset = "0x38")]
			public ArrayIndexFilter _003C_003E4__this;

			[Token(Token = "0x4000357")]
			[FieldOffset(Offset = "0x40")]
			private bool errorWhenNoMatch;

			[Token(Token = "0x4000358")]
			[FieldOffset(Offset = "0x41")]
			public bool _003C_003E3__errorWhenNoMatch;

			[Token(Token = "0x4000359")]
			[FieldOffset(Offset = "0x48")]
			private JToken _003Ct_003E5__1;

			[Token(Token = "0x400035A")]
			[FieldOffset(Offset = "0x50")]
			private IEnumerator<JToken> _003C_003E7__wrap1;

			[Token(Token = "0x400035B")]
			[FieldOffset(Offset = "0x58")]
			private IEnumerator<JToken> _003C_003E7__wrap2;

			[Token(Token = "0x17000152")]
			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[Token(Token = "0x6000761")]
				[Address(RVA = "0xD02C4C", Offset = "0xD02C4C", VA = "0xD02C4C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000153")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000763")]
				[Address(RVA = "0xD02CBC", Offset = "0xD02CBC", VA = "0xD02CBC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0xD02100", Offset = "0xD02100", VA = "0xD02100")]
			[DebuggerHidden]
			public _003CExecuteFilter_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0xD02160", Offset = "0xD02160", VA = "0xD02160", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0xD02350", Offset = "0xD02350", VA = "0xD02350", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0xD02290", Offset = "0xD02290", VA = "0xD02290")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0xD021D0", Offset = "0xD021D0", VA = "0xD021D0")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0xD02C54", Offset = "0xD02C54", VA = "0xD02C54", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0xD02CC4", Offset = "0xD02CC4", VA = "0xD02CC4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0xD02D94", Offset = "0xD02D94", VA = "0xD02D94", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FBF8", Offset = "0x80FBF8")]
		private int? _003CIndex_003Ek__BackingField;

		[Token(Token = "0x17000151")]
		public int? Index
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0xD0204C", Offset = "0xD0204C", VA = "0xD0204C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8112B4", Offset = "0x8112B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xD02054", Offset = "0xD02054", VA = "0xD02054", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xD02150", Offset = "0xD02150", VA = "0xD02150")]
		public ArrayIndexFilter()
		{
		}
	}
}
