using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004CB")]
	public class CasualAnalogData
	{
		[Token(Token = "0x4001665")]
		[FieldOffset(Offset = "0x10")]
		protected Dictionary<string, object> m_extraData;

		[Token(Token = "0x600244B")]
		[Address(RVA = "0xA27620", Offset = "0xA27620", VA = "0xA27620")]
		public List<string> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x600244C")]
		[Address(RVA = "0xA276B8", Offset = "0xA276B8", VA = "0xA276B8")]
		public object GetData(string key)
		{
			return null;
		}

		[Token(Token = "0x600244D")]
		[Address(RVA = "0xA26384", Offset = "0xA26384", VA = "0xA26384")]
		public CasualAnalogData()
		{
		}
	}
}
