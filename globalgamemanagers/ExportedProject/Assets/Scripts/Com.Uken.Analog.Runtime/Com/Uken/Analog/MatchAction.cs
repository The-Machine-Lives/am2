using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000047")]
	public class MatchAction : BaseEvent
	{
		[Token(Token = "0x400011D")]
		private const string TYPE = "match";

		[Token(Token = "0x400011E")]
		private const string NAME = "action";

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x16D9CCC", Offset = "0x16D9CCC", VA = "0x16D9CCC")]
		public MatchAction(Guid matchId, string actionName)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x16D9DF4", Offset = "0x16D9DF4", VA = "0x16D9DF4", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}
	}
}
