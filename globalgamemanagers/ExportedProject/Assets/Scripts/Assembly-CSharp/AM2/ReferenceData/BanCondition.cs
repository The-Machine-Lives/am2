using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200037E")]
	public class BanCondition : RuntimeData<RDBanCondition>
	{
		[Token(Token = "0x170004D7")]
		public EBanType banType
		{
			[Token(Token = "0x6001B9C")]
			[Address(RVA = "0x9AC808", Offset = "0x9AC808", VA = "0x9AC808")]
			get
			{
				return default(EBanType);
			}
		}

		[Token(Token = "0x170004D8")]
		public string itemReference
		{
			[Token(Token = "0x6001B9D")]
			[Address(RVA = "0x9AC834", Offset = "0x9AC834", VA = "0x9AC834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D9")]
		public long maxAmount
		{
			[Token(Token = "0x6001B9E")]
			[Address(RVA = "0x9AC860", Offset = "0x9AC860", VA = "0x9AC860")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0x9AC88C", Offset = "0x9AC88C", VA = "0x9AC88C")]
		public BanCondition()
		{
		}
	}
}
