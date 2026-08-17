using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000017")]
	public class ABJoin : BaseEvent
	{
		[Token(Token = "0x4000056")]
		private const string TYPE = "ab_test";

		[Token(Token = "0x4000057")]
		private const string NAME = "join_experiment";

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x70")]
		private ABJoinEventData eventData;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x16CDF04", Offset = "0x16CDF04", VA = "0x16CDF04")]
		public ABJoin(string experimentName, string experimentGroup)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x16CE018", Offset = "0x16CE018", VA = "0x16CE018", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x16CE0D8", Offset = "0x16CE0D8", VA = "0x16CE0D8")]
		public string GetExperimentName()
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x16CE10C", Offset = "0x16CE10C", VA = "0x16CE10C")]
		public string GetExperimentGroup()
		{
			return null;
		}
	}
}
