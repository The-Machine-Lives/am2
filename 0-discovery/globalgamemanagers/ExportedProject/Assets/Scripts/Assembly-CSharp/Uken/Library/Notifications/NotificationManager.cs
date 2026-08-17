using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Library.Notifications
{
	[Token(Token = "0x200040E")]
	public abstract class NotificationManager : MonoBehaviour
	{
		[Token(Token = "0x40012E6")]
		private const string mc_sLocalNotificationsPlayerPrefsPrefix = "uken_local_notifications";

		[Token(Token = "0x40012E7")]
		public const string TargetGameObject = "Uken.Library.LocalNotificationManager";

		[Token(Token = "0x40012E8")]
		[FieldOffset(Offset = "0x18")]
		private AndroidJavaObject m_androidPlugin;

		[Token(Token = "0x40012E9")]
		[FieldOffset(Offset = "0x20")]
		private bool m_checkForNotifications;

		[Token(Token = "0x40012EA")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<int, Notification> registeredNotifications;

		[Token(Token = "0x40012EB")]
		[FieldOffset(Offset = "0x30")]
		private bool m_bInitialized;

		[Token(Token = "0x40012EC")]
		[FieldOffset(Offset = "0x31")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E3D8", Offset = "0x82E3D8")]
		private bool _003Cm_bEnableLocalNotifications_003Ek__BackingField;

		[Token(Token = "0x1700059C")]
		public bool m_bEnableLocalNotifications
		{
			[Token(Token = "0x6001EC5")]
			[Address(RVA = "0xBAC348", Offset = "0xBAC348", VA = "0xBAC348")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838EE0", Offset = "0x838EE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EC6")]
			[Address(RVA = "0xBAC350", Offset = "0xBAC350", VA = "0xBAC350")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838EF0", Offset = "0x838EF0")]
			protected set
			{
			}
		}

		[Token(Token = "0x6001EC7")]
		public static T Create<T>() where T : NotificationManager
		{
			return null;
		}

		[Token(Token = "0x6001EC8")]
		[Address(RVA = "0xBAC35C", Offset = "0xBAC35C", VA = "0xBAC35C")]
		public NotificationManager()
		{
		}

		[Token(Token = "0x6001EC9")]
		[Address(RVA = "0xBAC3CC", Offset = "0xBAC3CC", VA = "0xBAC3CC")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6001ECA")]
		[Address(RVA = "0xBAC4FC", Offset = "0xBAC4FC", VA = "0xBAC4FC")]
		public void SetLocalNotificationsEnabled(bool bEnable)
		{
		}

		[Token(Token = "0x6001ECB")]
		[Address(RVA = "0xBAC568", Offset = "0xBAC568", VA = "0xBAC568", Slot = "4")]
		protected virtual void OnReceiveNotification(int nType)
		{
		}

		[Token(Token = "0x6001ECC")]
		[Address(RVA = "0xBAC618", Offset = "0xBAC618", VA = "0xBAC618", Slot = "5")]
		protected virtual void SetupNotifications()
		{
		}

		[Token(Token = "0x6001ECD")]
		[Address(RVA = "0xBAC61C", Offset = "0xBAC61C", VA = "0xBAC61C", Slot = "6")]
		protected virtual bool LocalPlayerPrefEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6001ECE")]
		[Address(RVA = "0xBAC678", Offset = "0xBAC678", VA = "0xBAC678")]
		protected bool Cancel(int notificationId)
		{
			return default(bool);
		}

		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0xBAC798", Offset = "0xBAC798", VA = "0xBAC798")]
		protected void Schedule(int notificationId, string message, string groupId, long millisecondsSinceEpoch)
		{
		}

		[Token(Token = "0x6001ED0")]
		[Address(RVA = "0xBAC430", Offset = "0xBAC430", VA = "0xBAC430")]
		protected void CheckForNotifications()
		{
		}

		[Token(Token = "0x6001ED1")]
		[Address(RVA = "0xBAD020", Offset = "0xBAD020", VA = "0xBAD020")]
		protected void SetShouldCheckForNotifications(string booleanString)
		{
		}

		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0xBAD08C", Offset = "0xBAD08C", VA = "0xBAD08C")]
		public void ReceiveNotification(string notificationIdString)
		{
		}

		[Token(Token = "0x6001ED3")]
		[Address(RVA = "0xBAD13C", Offset = "0xBAD13C", VA = "0xBAD13C", Slot = "7")]
		protected virtual void ConfigureLocalNotifications(bool paused)
		{
		}

		[Token(Token = "0x6001ED4")]
		[Address(RVA = "0xBAD494", Offset = "0xBAD494", VA = "0xBAD494", Slot = "8")]
		protected virtual NotificationData GetNotificationData(Notification notification)
		{
			return null;
		}

		[Token(Token = "0x6001ED5")]
		[Address(RVA = "0xBAD274", Offset = "0xBAD274", VA = "0xBAD274")]
		private void ConfigureLocalNotification(int notificationId, bool paused)
		{
		}

		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0xBAD49C", Offset = "0xBAD49C", VA = "0xBAD49C")]
		protected void RegisterNotification(Notification notification)
		{
		}

		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0xBAD5A8", Offset = "0xBAD5A8", VA = "0xBAD5A8")]
		protected bool CanScheduleLocalNotifications()
		{
			return default(bool);
		}

		[Token(Token = "0x6001ED8")]
		protected abstract string GetNotificationGroup(int localNotificationId);

		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0xBAD5B0", Offset = "0xBAD5B0", VA = "0xBAD5B0")]
		public void OnApplicationPause(bool paused)
		{
		}

		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0xBAD634", Offset = "0xBAD634", VA = "0xBAD634")]
		public void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0xBAD680", Offset = "0xBAD680", VA = "0xBAD680")]
		private void Update()
		{
		}

		[Token(Token = "0x6001EDC")]
		[Address(RVA = "0xBAD604", Offset = "0xBAD604", VA = "0xBAD604")]
		public void CleanPlugin()
		{
		}

		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0xBAD690", Offset = "0xBAD690", VA = "0xBAD690")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6001EDE")]
		[Address(RVA = "0xBACBB8", Offset = "0xBACBB8", VA = "0xBACBB8")]
		private bool AndroidPluginExists()
		{
			return default(bool);
		}

		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0xBAC67C", Offset = "0xBAC67C", VA = "0xBAC67C")]
		private bool CancelNotification(int notificationId)
		{
			return default(bool);
		}
	}
}
