using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200003B")]
	public class EventLoadStart : BaseEvent
	{
		[Token(Token = "0x40000EE")]
		private const string TYPE = "event_load";

		[Token(Token = "0x40000EF")]
		private const string NAME = "start";

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x16D7518", Offset = "0x16D7518", VA = "0x16D7518")]
		public EventLoadStart(string name)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x16D7618", Offset = "0x16D7618", VA = "0x16D7618", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}
	}
}
