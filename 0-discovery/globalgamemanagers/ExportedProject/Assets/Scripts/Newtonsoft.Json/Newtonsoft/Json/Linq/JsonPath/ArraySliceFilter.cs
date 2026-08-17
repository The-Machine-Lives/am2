using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Token(Token = "0x20000E5")]
	[Preserve]
	internal class ArraySliceFilter : PathFilter
	{
		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F2D8", Offset = "0x80F2D8")]
		private sealed class _003CExecuteFilter_003Ed__12 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400036B")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400036C")]
			[FieldOffset(Offset = "0x18")]
			private JToken _003C_003E2__current;

			[Token(Token = "0x400036D")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x400036E")]
			[FieldOffset(Offset = "0x28")]
			public ArraySliceFilter _003C_003E4__this;

			[Token(Token = "0x400036F")]
			[FieldOffset(Offset = "0x30")]
			private IEnumerable<JToken> current;

			[Token(Token = "0x4000370")]
			[FieldOffset(Offset = "0x38")]
			public IEnumerable<JToken> _003C_003E3__current;

			[Token(Token = "0x4000371")]
			[FieldOffset(Offset = "0x40")]
			private JArray _003Ca_003E5__1;

			[Token(Token = "0x4000372")]
			[FieldOffset(Offset = "0x48")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x4000373")]
			[FieldOffset(Offset = "0x4C")]
			private int _003CstepCount_003E5__3;

			[Token(Token = "0x4000374")]
			[FieldOffset(Offset = "0x50")]
			private int _003CstopIndex_003E5__4;

			[Token(Token = "0x4000375")]
			[FieldOffset(Offset = "0x54")]
			private bool _003CpositiveStep_003E5__5;

			[Token(Token = "0x4000376")]
			[FieldOffset(Offset = "0x55")]
			private bool errorWhenNoMatch;

			[Token(Token = "0x4000377")]
			[FieldOffset(Offset = "0x56")]
			public bool _003C_003E3__errorWhenNoMatch;

			[Token(Token = "0x4000378")]
			[FieldOffset(Offset = "0x58")]
			private JToken _003Ct_003E5__6;

			[Token(Token = "0x4000379")]
			[FieldOffset(Offset = "0x60")]
			private IEnumerator<JToken> _003C_003E7__wrap1;

			[Token(Token = "0x1700015A")]
			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[Token(Token = "0x600077D")]
				[Address(RVA = "0xD04190", Offset = "0xD04190", VA = "0xD04190", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600077F")]
				[Address(RVA = "0xD04200", Offset = "0xD04200", VA = "0xD04200", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0xD03570", Offset = "0xD03570", VA = "0xD03570")]
			[DebuggerHidden]
			public _003CExecuteFilter_003Ed__12(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0xD035E0", Offset = "0xD035E0", VA = "0xD035E0", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0xD036BC", Offset = "0xD036BC", VA = "0xD036BC", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0xD035FC", Offset = "0xD035FC", VA = "0xD035FC")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x600077E")]
			[Address(RVA = "0xD04198", Offset = "0xD04198", VA = "0xD04198", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000780")]
			[Address(RVA = "0xD04208", Offset = "0xD04208", VA = "0xD04208", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000781")]
			[Address(RVA = "0xD042D8", Offset = "0xD042D8", VA = "0xD042D8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FC18", Offset = "0x80FC18")]
		private int? _003CStart_003Ek__BackingField;

		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FC28", Offset = "0x80FC28")]
		private int? _003CEnd_003Ek__BackingField;

		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FC38", Offset = "0x80FC38")]
		private int? _003CStep_003Ek__BackingField;

		[Token(Token = "0x17000157")]
		public int? Start
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0xD034A8", Offset = "0xD034A8", VA = "0xD034A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8113B4", Offset = "0x8113B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		public int? End
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0xD034B0", Offset = "0xD034B0", VA = "0xD034B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8113C4", Offset = "0x8113C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000159")]
		public int? Step
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0xD034B8", Offset = "0xD034B8", VA = "0xD034B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8113D4", Offset = "0x8113D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xD034C0", Offset = "0xD034C0", VA = "0xD034C0", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xD035C0", Offset = "0xD035C0", VA = "0xD035C0")]
		private bool IsValid(int index, int stopIndex, bool positiveStep)
		{
			return default(bool);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xD035D8", Offset = "0xD035D8", VA = "0xD035D8")]
		public ArraySliceFilter()
		{
		}
	}
}
