using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003B0")]
	public class Condition : RuntimeData<RDCondition>
	{
		[Token(Token = "0x17000553")]
		public string itemRef
		{
			[Token(Token = "0x6001C83")]
			[Address(RVA = "0x9AED50", Offset = "0x9AED50", VA = "0x9AED50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000554")]
		public long itemQuantity
		{
			[Token(Token = "0x6001C84")]
			[Address(RVA = "0x9AED7C", Offset = "0x9AED7C", VA = "0x9AED7C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6001C85")]
		[Address(RVA = "0x9AEDA8", Offset = "0x9AEDA8", VA = "0x9AEDA8")]
		public Condition()
		{
		}
	}
}
