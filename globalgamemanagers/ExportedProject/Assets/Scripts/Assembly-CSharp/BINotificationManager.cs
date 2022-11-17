using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Notifications;

[Token(Token = "0x200019D")]
public class BINotificationManager : CasualNotification
{
	[Token(Token = "0x200064D")]
	public enum ENotificationType
	{
		[Token(Token = "0x4001F4C")]
		Local = 0,
		[Token(Token = "0x4001F4D")]
		Push = 1
	}

	[Token(Token = "0x40009C0")]
	private const string mc_sPlayerPrefsPrefix = "bi_notifications_";

	[Token(Token = "0x6000B2F")]
	[Address(RVA = "0xA410AC", Offset = "0xA410AC", VA = "0xA410AC", Slot = "9")]
	protected override string GetNotificationGroup(int notificationType)
	{
		return null;
	}

	[Token(Token = "0x6000B30")]
	[Address(RVA = "0xA410F4", Offset = "0xA410F4", VA = "0xA410F4", Slot = "8")]
	protected override NotificationData GetNotificationData(Notification notification)
	{
		return null;
	}

	[Token(Token = "0x6000B31")]
	[Address(RVA = "0xA410FC", Offset = "0xA410FC", VA = "0xA410FC", Slot = "6")]
	protected override bool LocalPlayerPrefEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000B32")]
	[Address(RVA = "0xA411A4", Offset = "0xA411A4", VA = "0xA411A4")]
	public BINotificationManager()
	{
	}
}
