using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004B2")]
	public class ResearchUIMessage
	{
		[Token(Token = "0x40015E4")]
		[FieldOffset(Offset = "0x10")]
		public HashSet<string> untouchedResearch;

		[Token(Token = "0x40015E5")]
		[FieldOffset(Offset = "0x18")]
		public bool newResearchAvailable;

		[Token(Token = "0x40015E6")]
		[FieldOffset(Offset = "0x19")]
		public bool newNPCPurchaseAvailable;

		[Token(Token = "0x40015E7")]
		[FieldOffset(Offset = "0x1A")]
		public bool researchComplete;

		[Token(Token = "0x6002338")]
		[Address(RVA = "0xA894D0", Offset = "0xA894D0", VA = "0xA894D0")]
		public ResearchUIMessage()
		{
		}
	}
}
