using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200004B")]
	public class MatchStart : BaseEvent
	{
		[Token(Token = "0x4000124")]
		private const string TYPE = "match";

		[Token(Token = "0x4000125")]
		private const string NAME = "start";

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x16DA0D0", Offset = "0x16DA0D0", VA = "0x16DA0D0")]
		public MatchStart(Guid matchId)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x16DA1E0", Offset = "0x16DA1E0", VA = "0x16DA1E0", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}
	}
}
