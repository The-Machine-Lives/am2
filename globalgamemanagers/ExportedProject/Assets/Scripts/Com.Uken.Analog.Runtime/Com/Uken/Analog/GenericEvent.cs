using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200003F")]
	public class GenericEvent : BaseEvent
	{
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x16D8970", Offset = "0x16D8970", VA = "0x16D8970")]
		public GenericEvent(string type, string name)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x16D8A34", Offset = "0x16D8A34", VA = "0x16D8A34", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}
	}
}
