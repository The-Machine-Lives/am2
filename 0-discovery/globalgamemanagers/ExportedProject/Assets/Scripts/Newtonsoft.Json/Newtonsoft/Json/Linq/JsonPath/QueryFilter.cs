using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Token(Token = "0x20000F2")]
	[Preserve]
	internal class QueryFilter : PathFilter
	{
		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F3A8", Offset = "0x80F3A8")]
		private sealed class _003CExecuteFilter_003Ed__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[Token(Token = "0x40003A7")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003A8")]
			[FieldOffset(Offset = "0x18")]
			private JToken _003C_003E2__current;

			[Token(Token = "0x40003A9")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x40003AA")]
			[FieldOffset(Offset = "0x28")]
			private IEnumerable<JToken> current;

			[Token(Token = "0x40003AB")]
			[FieldOffset(Offset = "0x30")]
			public IEnumerable<JToken> _003C_003E3__current;

			[Token(Token = "0x40003AC")]
			[FieldOffset(Offset = "0x38")]
			public QueryFilter _003C_003E4__this;

			[Token(Token = "0x40003AD")]
			[FieldOffset(Offset = "0x40")]
			private IEnumerator<JToken> _003C_003E7__wrap1;

			[Token(Token = "0x40003AE")]
			[FieldOffset(Offset = "0x48")]
			private IEnumerator<JToken> _003C_003E7__wrap2;

			[Token(Token = "0x17000167")]
			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[Token(Token = "0x60007B7")]
				[Address(RVA = "0xD06E04", Offset = "0xD06E04", VA = "0xD06E04", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000168")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60007B9")]
				[Address(RVA = "0xD06E74", Offset = "0xD06E74", VA = "0xD06E74", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xD06780", Offset = "0xD06780", VA = "0xD06780")]
			[DebuggerHidden]
			public _003CExecuteFilter_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xD067D8", Offset = "0xD067D8", VA = "0xD067D8", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0xD069C8", Offset = "0xD069C8", VA = "0xD069C8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0xD06908", Offset = "0xD06908", VA = "0xD06908")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0xD06848", Offset = "0xD06848", VA = "0xD06848")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0xD06E0C", Offset = "0xD06E0C", VA = "0xD06E0C", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xD06E7C", Offset = "0xD06E7C", VA = "0xD06E7C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0xD06F44", Offset = "0xD06F44", VA = "0xD06F44", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FCA8", Offset = "0x80FCA8")]
		private QueryExpression _003CExpression_003Ek__BackingField;

		[Token(Token = "0x17000166")]
		public QueryExpression Expression
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0xD066E4", Offset = "0xD066E4", VA = "0xD066E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8115A4", Offset = "0x8115A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xD066EC", Offset = "0xD066EC", VA = "0xD066EC", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xD067D0", Offset = "0xD067D0", VA = "0xD067D0")]
		public QueryFilter()
		{
		}
	}
}
