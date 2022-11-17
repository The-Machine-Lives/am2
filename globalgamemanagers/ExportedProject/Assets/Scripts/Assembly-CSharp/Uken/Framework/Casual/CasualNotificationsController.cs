using Il2CppDummyDll;
using Uken.Library.Notifications;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004DB")]
	internal class CasualNotificationsController : NotificationsController
	{
		[Token(Token = "0x40016F7")]
		private const string c_unlockedNotifications = "unlock_notifications";

		[Token(Token = "0x40016F8")]
		[FieldOffset(Offset = "0x20")]
		protected CasualGame m_game;

		[Token(Token = "0x600254E")]
		[Address(RVA = "0xA547CC", Offset = "0xA547CC", VA = "0xA547CC")]
		public static bool UnlockedNotifications()
		{
			return default(bool);
		}

		[Token(Token = "0x600254F")]
		[Address(RVA = "0xA54828", Offset = "0xA54828", VA = "0xA54828")]
		public static void UnlockNotifications()
		{
		}

		[Token(Token = "0x6002550")]
		[Address(RVA = "0xA54878", Offset = "0xA54878", VA = "0xA54878")]
		public CasualNotificationsController(CasualGame game, NotificationManager notificationManager)
		{
		}

		[Token(Token = "0x6002551")]
		[Address(RVA = "0xA548A8", Offset = "0xA548A8", VA = "0xA548A8", Slot = "9")]
		public override void OnDataUpdated()
		{
		}
	}
}
