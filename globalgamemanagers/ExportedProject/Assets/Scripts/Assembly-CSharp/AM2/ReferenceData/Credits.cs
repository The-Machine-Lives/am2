using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000376")]
	public class Credits : RuntimeData<RDCredits>
	{
		[Token(Token = "0x170004CA")]
		public string credits
		{
			[Token(Token = "0x6001B83")]
			[Address(RVA = "0x9AF0A8", Offset = "0x9AF0A8", VA = "0x9AF0A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x9AF0D4", Offset = "0x9AF0D4", VA = "0x9AF0D4")]
		public Credits()
		{
		}
	}
}
