using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Token(Token = "0x200000D")]
	public class AnalogTime
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x16D45D0", Offset = "0x16D45D0", VA = "0x16D45D0", Slot = "4")]
		public virtual DateTime GetDateTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x16CFA68", Offset = "0x16CFA68", VA = "0x16CFA68")]
		public AnalogTime()
		{
		}
	}
}
