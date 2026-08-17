using System;
using Com.Uken.Analog;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004C9")]
	public class CasualTime : AnalogTime
	{
		[Token(Token = "0x400165A")]
		[FieldOffset(Offset = "0x10")]
		private CasualGame m_game;

		[Token(Token = "0x6002411")]
		[Address(RVA = "0xA56C94", Offset = "0xA56C94", VA = "0xA56C94")]
		public CasualTime(CasualGame game)
		{
		}

		[Token(Token = "0x6002412")]
		[Address(RVA = "0xA56CC0", Offset = "0xA56CC0", VA = "0xA56CC0", Slot = "4")]
		public override DateTime GetDateTime()
		{
			return default(DateTime);
		}
	}
}
