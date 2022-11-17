using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x200004A")]
	internal abstract class ResultBase : IInternalResult, IResult
	{
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816440", Offset = "0x816440")]
		private string _003CError_003Ek__BackingField;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816450", Offset = "0x816450")]
		private IDictionary<string, object> _003CResultDictionary_003Ek__BackingField;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816460", Offset = "0x816460")]
		private string _003CRawResult_003Ek__BackingField;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816470", Offset = "0x816470")]
		private bool _003CCancelled_003Ek__BackingField;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816480", Offset = "0x816480")]
		private string _003CCallbackId_003Ek__BackingField;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816490", Offset = "0x816490")]
		private long? _003CCanvasErrorCode_003Ek__BackingField;

		[Token(Token = "0x17000058")]
		public virtual string Error
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x17C2DD0", Offset = "0x17C2DD0", VA = "0x17C2DD0", Slot = "9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816C20", Offset = "0x816C20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x17C2DD8", Offset = "0x17C2DD8", VA = "0x17C2DD8", Slot = "10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816C30", Offset = "0x816C30")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public virtual IDictionary<string, object> ResultDictionary
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x17C2DE0", Offset = "0x17C2DE0", VA = "0x17C2DE0", Slot = "11")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816C40", Offset = "0x816C40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x17C2DE8", Offset = "0x17C2DE8", VA = "0x17C2DE8", Slot = "12")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816C50", Offset = "0x816C50")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public virtual string RawResult
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x17C2DF0", Offset = "0x17C2DF0", VA = "0x17C2DF0", Slot = "13")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816C60", Offset = "0x816C60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x17C2DF8", Offset = "0x17C2DF8", VA = "0x17C2DF8", Slot = "14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816C70", Offset = "0x816C70")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public virtual bool Cancelled
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x17C2E00", Offset = "0x17C2E00", VA = "0x17C2E00", Slot = "15")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816C80", Offset = "0x816C80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x17C2E08", Offset = "0x17C2E08", VA = "0x17C2E08", Slot = "16")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816C90", Offset = "0x816C90")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public virtual string CallbackId
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x17C2E14", Offset = "0x17C2E14", VA = "0x17C2E14", Slot = "17")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816CA0", Offset = "0x816CA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x17C2E1C", Offset = "0x17C2E1C", VA = "0x17C2E1C", Slot = "18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816CB0", Offset = "0x816CB0")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		protected long? CanvasErrorCode
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x17BFBD0", Offset = "0x17BFBD0", VA = "0x17BFBD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816CC0", Offset = "0x816CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x17C2E24", Offset = "0x17C2E24", VA = "0x17C2E24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816CD0", Offset = "0x816CD0")]
			private set
			{
			}
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x17BFB20", Offset = "0x17BFB20", VA = "0x17BFB20")]
		internal ResultBase(ResultContainer result)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x17C2D84", Offset = "0x17C2D84", VA = "0x17C2D84")]
		internal ResultBase(ResultContainer result, string error, bool cancelled)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x17BFD50", Offset = "0x17BFD50", VA = "0x17BFD50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x17C2BB4", Offset = "0x17C2BB4", VA = "0x17C2BB4")]
		protected void Init(ResultContainer result, string error, bool cancelled, string callbackId)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x17C27CC", Offset = "0x17C27CC", VA = "0x17C27CC")]
		private static string GetErrorValue(IDictionary<string, object> result)
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x17C2854", Offset = "0x17C2854", VA = "0x17C2854")]
		private static bool GetCancelledValue(IDictionary<string, object> result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x17C2B2C", Offset = "0x17C2B2C", VA = "0x17C2B2C")]
		private static string GetCallbackId(IDictionary<string, object> result)
		{
			return null;
		}
	}
}
