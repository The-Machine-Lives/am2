using Il2CppDummyDll;

namespace Uken.Library.Notifications
{
	[Token(Token = "0x200040D")]
	public sealed class NotificationData
	{
		[Token(Token = "0x40012E4")]
		[FieldOffset(Offset = "0x10")]
		public string m_message;

		[Token(Token = "0x40012E5")]
		[FieldOffset(Offset = "0x18")]
		public long m_millisecondsSinceEpoch;

		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0xBAC340", Offset = "0xBAC340", VA = "0xBAC340")]
		public NotificationData()
		{
		}
	}
}
