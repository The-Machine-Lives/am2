using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000049")]
	public class MatchEnd : BaseEvent
	{
		[Token(Token = "0x4000121")]
		private const string TYPE = "match";

		[Token(Token = "0x4000122")]
		private const string NAME = "end";

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x16D9F10", Offset = "0x16D9F10", VA = "0x16D9F10")]
		public MatchEnd(Guid matchId)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x16DA020", Offset = "0x16DA020", VA = "0x16DA020", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}
	}
}
