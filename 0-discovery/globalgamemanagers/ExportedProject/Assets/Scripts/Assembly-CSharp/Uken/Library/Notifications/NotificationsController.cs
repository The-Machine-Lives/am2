using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Notifications
{
	[Token(Token = "0x200040F")]
	public class NotificationsController : UkenController
	{
		[Token(Token = "0x40012ED")]
		[FieldOffset(Offset = "0x18")]
		protected NotificationManager m_NotificationManager;

		[Token(Token = "0x1700059D")]
		public bool LocalNotificationEnabled
		{
			[Token(Token = "0x6001EE0")]
			[Address(RVA = "0xBAD6C0", Offset = "0xBAD6C0", VA = "0xBAD6C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001EE1")]
		[Address(RVA = "0xBAD6EC", Offset = "0xBAD6EC", VA = "0xBAD6EC")]
		public NotificationsController(NotificationManager notificationManager)
		{
		}

		[Token(Token = "0x6001EE2")]
		[Address(RVA = "0xBAD718", Offset = "0xBAD718", VA = "0xBAD718")]
		public void EnableLocalNotifications(bool enable)
		{
		}

		[Token(Token = "0x6001EE3")]
		[Address(RVA = "0xBAD74C", Offset = "0xBAD74C", VA = "0xBAD74C", Slot = "9")]
		public override void OnDataUpdated()
		{
		}
	}
}
