using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Token(Token = "0x20000F4")]
	[Preserve]
	internal class ScanFilter : PathFilter
	{
		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F3C8", Offset = "0x80F3C8")]
		private sealed class _003CExecuteFilter_003Ed__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[Token(Token = "0x40003B0")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003B1")]
			[FieldOffset(Offset = "0x18")]
			private JToken _003C_003E2__current;

			[Token(Token = "0x40003B2")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x40003B3")]
			[FieldOffset(Offset = "0x28")]
			private IEnumerable<JToken> current;

			[Token(Token = "0x40003B4")]
			[FieldOffset(Offset = "0x30")]
			public IEnumerable<JToken> _003C_003E3__current;

			[Token(Token = "0x40003B5")]
			[FieldOffset(Offset = "0x38")]
			public ScanFilter _003C_003E4__this;

			[Token(Token = "0x40003B6")]
			[FieldOffset(Offset = "0x40")]
			private JToken _003Croot_003E5__1;

			[Token(Token = "0x40003B7")]
			[FieldOffset(Offset = "0x48")]
			private JToken _003Cvalue_003E5__2;

			[Token(Token = "0x40003B8")]
			[FieldOffset(Offset = "0x50")]
			private IEnumerator<JToken> _003C_003E7__wrap1;

			[Token(Token = "0x1700016A")]
			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[Token(Token = "0x60007C3")]
				[Address(RVA = "0xD0762C", Offset = "0xD0762C", VA = "0xD0762C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60007C5")]
				[Address(RVA = "0xD0769C", Offset = "0xD0769C", VA = "0xD0769C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0xD06FE4", Offset = "0xD06FE4", VA = "0xD06FE4")]
			[DebuggerHidden]
			public _003CExecuteFilter_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xD0703C", Offset = "0xD0703C", VA = "0xD0703C", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0xD07128", Offset = "0xD07128", VA = "0xD07128", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xD07068", Offset = "0xD07068", VA = "0xD07068")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0xD07634", Offset = "0xD07634", VA = "0xD07634", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0xD076A4", Offset = "0xD076A4", VA = "0xD076A4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0xD0776C", Offset = "0xD0776C", VA = "0xD0776C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FCB8", Offset = "0x80FCB8")]
		private string _003CName_003Ek__BackingField;

		[Token(Token = "0x17000169")]
		public string Name
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0xD06F48", Offset = "0xD06F48", VA = "0xD06F48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811624", Offset = "0x811624")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xD06F50", Offset = "0xD06F50", VA = "0xD06F50", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xD07034", Offset = "0xD07034", VA = "0xD07034")]
		public ScanFilter()
		{
		}
	}
}
