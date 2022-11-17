using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Token(Token = "0x20000E7")]
	[Preserve]
	internal class FieldFilter : PathFilter
	{
		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F2F8", Offset = "0x80F2F8")]
		private sealed class _003CExecuteFilter_003Ed__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400037B")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400037C")]
			[FieldOffset(Offset = "0x18")]
			private JToken _003C_003E2__current;

			[Token(Token = "0x400037D")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x400037E")]
			[FieldOffset(Offset = "0x28")]
			private IEnumerable<JToken> current;

			[Token(Token = "0x400037F")]
			[FieldOffset(Offset = "0x30")]
			public IEnumerable<JToken> _003C_003E3__current;

			[Token(Token = "0x4000380")]
			[FieldOffset(Offset = "0x38")]
			public FieldFilter _003C_003E4__this;

			[Token(Token = "0x4000381")]
			[FieldOffset(Offset = "0x40")]
			private bool errorWhenNoMatch;

			[Token(Token = "0x4000382")]
			[FieldOffset(Offset = "0x41")]
			public bool _003C_003E3__errorWhenNoMatch;

			[Token(Token = "0x4000383")]
			[FieldOffset(Offset = "0x48")]
			private JObject _003Co_003E5__1;

			[Token(Token = "0x4000384")]
			[FieldOffset(Offset = "0x50")]
			private JToken _003Ct_003E5__2;

			[Token(Token = "0x4000385")]
			[FieldOffset(Offset = "0x58")]
			private IEnumerator<JToken> _003C_003E7__wrap1;

			[Token(Token = "0x4000386")]
			[FieldOffset(Offset = "0x60")]
			private IEnumerator<KeyValuePair<string, JToken>> _003C_003E7__wrap2;

			[Token(Token = "0x1700015D")]
			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[Token(Token = "0x600078A")]
				[Address(RVA = "0xD05AA4", Offset = "0xD05AA4", VA = "0xD05AA4", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015E")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600078C")]
				[Address(RVA = "0xD05B14", Offset = "0xD05B14", VA = "0xD05B14", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0xD051F4", Offset = "0xD051F4", VA = "0xD051F4")]
			[DebuggerHidden]
			public _003CExecuteFilter_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0xD0524C", Offset = "0xD0524C", VA = "0xD0524C", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000787")]
			[Address(RVA = "0xD0543C", Offset = "0xD0543C", VA = "0xD0543C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0xD0537C", Offset = "0xD0537C", VA = "0xD0537C")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6000789")]
			[Address(RVA = "0xD052BC", Offset = "0xD052BC", VA = "0xD052BC")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0xD05AAC", Offset = "0xD05AAC", VA = "0xD05AAC", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0xD05B1C", Offset = "0xD05B1C", VA = "0xD05B1C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0xD05BEC", Offset = "0xD05BEC", VA = "0xD05BEC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FC48", Offset = "0x80FC48")]
		private string _003CName_003Ek__BackingField;

		[Token(Token = "0x1700015C")]
		public string Name
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0xD05140", Offset = "0xD05140", VA = "0xD05140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811454", Offset = "0x811454")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xD05148", Offset = "0xD05148", VA = "0xD05148", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xD05244", Offset = "0xD05244", VA = "0xD05244")]
		public FieldFilter()
		{
		}
	}
}
