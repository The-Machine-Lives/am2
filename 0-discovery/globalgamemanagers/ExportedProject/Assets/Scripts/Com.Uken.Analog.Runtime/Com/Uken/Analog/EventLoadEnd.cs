using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000039")]
	public class EventLoadEnd : BaseEvent
	{
		[Token(Token = "0x40000EB")]
		private const string TYPE = "event_load";

		[Token(Token = "0x40000EC")]
		private const string NAME = "end";

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x16D735C", Offset = "0x16D735C", VA = "0x16D735C")]
		public EventLoadEnd(string name)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x16D745C", Offset = "0x16D745C", VA = "0x16D745C", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}
	}
}
