using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004CD")]
	public class CLogStringData : CasualAnalogData
	{
		[Token(Token = "0x600244F")]
		[Address(RVA = "0xA26630", Offset = "0xA26630", VA = "0xA26630")]
		public CLogStringData(string key, string value)
		{
		}

		[Token(Token = "0x6002450")]
		[Address(RVA = "0xA266B0", Offset = "0xA266B0", VA = "0xA266B0")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x83971C", Offset = "0x83971C")]
		public CLogStringData(Dictionary<string, string> data)
		{
		}
	}
}
