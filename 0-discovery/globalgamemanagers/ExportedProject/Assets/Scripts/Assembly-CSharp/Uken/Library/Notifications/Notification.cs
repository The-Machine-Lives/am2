using Il2CppDummyDll;

namespace Uken.Library.Notifications
{
	[Token(Token = "0x200040C")]
	public class Notification
	{
		[Token(Token = "0x40012E2")]
		[FieldOffset(Offset = "0x10")]
		public string reference;

		[Token(Token = "0x40012E3")]
		[FieldOffset(Offset = "0x18")]
		public int notificationID;

		[Token(Token = "0x6001EC3")]
		[Address(RVA = "0xBAC338", Offset = "0xBAC338", VA = "0xBAC338")]
		public Notification()
		{
		}
	}
}
