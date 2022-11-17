using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Notifications;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004DA")]
	public abstract class CasualNotification : NotificationManager
	{
		[Serializable]
		[Token(Token = "0x2000842")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821488", Offset = "0x821488")]
		private sealed class _003C_003Ec__5<T> where T : IEvent, ILocalNotification
		{
			[Token(Token = "0x40023A8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec__5<T> _003C_003E9;

			[Token(Token = "0x40023A9")]
			[FieldOffset(Offset = "0x0")]
			public static Comparison<T> _003C_003E9__5_0;

			[Token(Token = "0x6003355")]
			public _003C_003Ec__5()
			{
			}

			[Token(Token = "0x6003356")]
			internal int _003CConfigureEventNotifications_003Eb__5_0(T x, T y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40016F4")]
		[FieldOffset(Offset = "0x38")]
		protected UkenTimeController m_time;

		[Token(Token = "0x40016F5")]
		[FieldOffset(Offset = "0x40")]
		protected LocalNotificationEvents m_localNotificationEvents;

		[Token(Token = "0x40016F6")]
		[FieldOffset(Offset = "0x48")]
		protected LocalNotifications m_localNotifications;

		[Token(Token = "0x6002548")]
		[Address(RVA = "0xA54310", Offset = "0xA54310", VA = "0xA54310")]
		public void Initialize(UkenTimeController time, LocalNotificationEvents notificationEvents, LocalNotifications notifications)
		{
		}

		[Token(Token = "0x6002549")]
		[Address(RVA = "0xA5431C", Offset = "0xA5431C", VA = "0xA5431C", Slot = "7")]
		protected override void ConfigureLocalNotifications(bool paused)
		{
		}

		[Token(Token = "0x600254A")]
		protected void ConfigureEventNotifications<T>(List<T> events, bool paused, DateTime currentTime) where T : IEvent, ILocalNotification
		{
		}

		[Token(Token = "0x600254B")]
		[Address(RVA = "0xA545FC", Offset = "0xA545FC", VA = "0xA545FC", Slot = "5")]
		protected override void SetupNotifications()
		{
		}

		[Token(Token = "0x600254C")]
		[Address(RVA = "0xA54474", Offset = "0xA54474", VA = "0xA54474")]
		private void ScheduleNotification(bool paused, DateTime currentTime, DateTime scheduledTime, string notificationReference)
		{
		}

		[Token(Token = "0x600254D")]
		[Address(RVA = "0xA547C4", Offset = "0xA547C4", VA = "0xA547C4")]
		protected CasualNotification()
		{
		}
	}
}
