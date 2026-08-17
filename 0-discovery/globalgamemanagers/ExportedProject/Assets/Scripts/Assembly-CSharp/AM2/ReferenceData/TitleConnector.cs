using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000395")]
	public class TitleConnector : RuntimeData<RDTitleConnector>, IReadable
	{
		[Token(Token = "0x17000514")]
		public string readableName
		{
			[Token(Token = "0x6001C0A")]
			[Address(RVA = "0x971834", Offset = "0x971834", VA = "0x971834", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001C0B")]
		[Address(RVA = "0x971860", Offset = "0x971860", VA = "0x971860")]
		public TitleConnector()
		{
		}
	}
}
