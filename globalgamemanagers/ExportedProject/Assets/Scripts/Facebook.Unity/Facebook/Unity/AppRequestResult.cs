using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000025")]
	internal class AppRequestResult : ResultBase, IAppRequestResult, IResult
	{
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8163A0", Offset = "0x8163A0")]
		private string _003CRequestID_003Ek__BackingField;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8163B0", Offset = "0x8163B0")]
		private IEnumerable<string> _003CTo_003Ek__BackingField;

		[Token(Token = "0x17000045")]
		public string RequestID
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0xCC87CC", Offset = "0xCC87CC", VA = "0xCC87CC", Slot = "20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816AF0", Offset = "0x816AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0xCC87BC", Offset = "0xCC87BC", VA = "0xCC87BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816B00", Offset = "0x816B00")]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public IEnumerable<string> To
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0xCC87D4", Offset = "0xCC87D4", VA = "0xCC87D4", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816B10", Offset = "0x816B10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0xCC87C4", Offset = "0xCC87C4", VA = "0xCC87C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816B20", Offset = "0x816B20")]
			private set
			{
			}
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xCC839C", Offset = "0xCC839C", VA = "0xCC839C")]
		public AppRequestResult(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xCC87DC", Offset = "0xCC87DC", VA = "0xCC87DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
