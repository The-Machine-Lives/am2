using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Token(Token = "0x20000E9")]
	[Preserve]
	internal class FieldMultipleFilter : PathFilter
	{
		[Serializable]
		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F318", Offset = "0x80F318")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000388")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000389")]
			[FieldOffset(Offset = "0x8")]
			public static Func<string, string> _003C_003E9__4_0;

			[Token(Token = "0x6000793")]
			[Address(RVA = "0xD05D60", Offset = "0xD05D60", VA = "0xD05D60")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0xD05D68", Offset = "0xD05D68", VA = "0xD05D68")]
			internal string _003CExecuteFilter_003Eb__4_0(string n)
			{
				return null;
			}
		}

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F328", Offset = "0x80F328")]
		private sealed class _003CExecuteFilter_003Ed__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400038A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400038B")]
			[FieldOffset(Offset = "0x18")]
			private JToken _003C_003E2__current;

			[Token(Token = "0x400038C")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x400038D")]
			[FieldOffset(Offset = "0x28")]
			private IEnumerable<JToken> current;

			[Token(Token = "0x400038E")]
			[FieldOffset(Offset = "0x30")]
			public IEnumerable<JToken> _003C_003E3__current;

			[Token(Token = "0x400038F")]
			[FieldOffset(Offset = "0x38")]
			public FieldMultipleFilter _003C_003E4__this;

			[Token(Token = "0x4000390")]
			[FieldOffset(Offset = "0x40")]
			private JObject _003Co_003E5__1;

			[Token(Token = "0x4000391")]
			[FieldOffset(Offset = "0x48")]
			private bool errorWhenNoMatch;

			[Token(Token = "0x4000392")]
			[FieldOffset(Offset = "0x49")]
			public bool _003C_003E3__errorWhenNoMatch;

			[Token(Token = "0x4000393")]
			[FieldOffset(Offset = "0x50")]
			private string _003Cname_003E5__2;

			[Token(Token = "0x4000394")]
			[FieldOffset(Offset = "0x58")]
			private JToken _003Ct_003E5__3;

			[Token(Token = "0x4000395")]
			[FieldOffset(Offset = "0x60")]
			private IEnumerator<JToken> _003C_003E7__wrap1;

			[Token(Token = "0x4000396")]
			[FieldOffset(Offset = "0x68")]
			private List<string>.Enumerator _003C_003E7__wrap2;

			[Token(Token = "0x17000160")]
			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[Token(Token = "0x600079A")]
				[Address(RVA = "0xD06598", Offset = "0xD06598", VA = "0xD06598", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000161")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600079C")]
				[Address(RVA = "0xD06608", Offset = "0xD06608", VA = "0xD06608", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0xD05CA4", Offset = "0xD05CA4", VA = "0xD05CA4")]
			[DebuggerHidden]
			public _003CExecuteFilter_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0xD05DC0", Offset = "0xD05DC0", VA = "0xD05DC0", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0xD05F48", Offset = "0xD05F48", VA = "0xD05F48", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0xD05E88", Offset = "0xD05E88", VA = "0xD05E88")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0xD05E30", Offset = "0xD05E30", VA = "0xD05E30")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0xD065A0", Offset = "0xD065A0", VA = "0xD065A0", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0xD06610", Offset = "0xD06610", VA = "0xD06610", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0xD066E0", Offset = "0xD066E0", VA = "0xD066E0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FC58", Offset = "0x80FC58")]
		private List<string> _003CNames_003Ek__BackingField;

		[Token(Token = "0x1700015F")]
		public List<string> Names
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0xD05BF0", Offset = "0xD05BF0", VA = "0xD05BF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8114D4", Offset = "0x8114D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xD05BF8", Offset = "0xD05BF8", VA = "0xD05BF8", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xD05CF4", Offset = "0xD05CF4", VA = "0xD05CF4")]
		public FieldMultipleFilter()
		{
		}
	}
}
