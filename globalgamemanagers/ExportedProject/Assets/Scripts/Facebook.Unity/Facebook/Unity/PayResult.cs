using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000047")]
	internal class PayResult : ResultBase, IPayResult, IResult
	{
		[Token(Token = "0x17000055")]
		public long ErrorCode
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x17BFBDC", Offset = "0x17BFBDC", VA = "0x17BFBDC", Slot = "19")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x17BFA5C", Offset = "0x17BFA5C", VA = "0x17BFA5C")]
		internal PayResult(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x17BFC40", Offset = "0x17BFC40", VA = "0x17BFC40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
