using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004E6")]
	public class AlertEvent : IEvent
	{
		[Token(Token = "0x400173C")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F614", Offset = "0x82F614")]
		private Alert _003Cm_alert_003Ek__BackingField;

		[Token(Token = "0x400173D")]
		[FieldOffset(Offset = "0x18")]
		private RDAlertEvent m_alertEventData;

		[Token(Token = "0x400173E")]
		[FieldOffset(Offset = "0x20")]
		private EventSchedule m_schedule;

		[Token(Token = "0x400173F")]
		[FieldOffset(Offset = "0x28")]
		private UkenTimeController m_time;

		[Token(Token = "0x4001740")]
		[FieldOffset(Offset = "0x30")]
		private List<UserSegment> m_userSegments;

		[Token(Token = "0x4001741")]
		[FieldOffset(Offset = "0x38")]
		private UserProfiler m_userProfiler;

		[Token(Token = "0x4001742")]
		[FieldOffset(Offset = "0x40")]
		private CasualGame m_game;

		[Token(Token = "0x17000659")]
		public string reference
		{
			[Token(Token = "0x60025C0")]
			[Address(RVA = "0xA24448", Offset = "0xA24448", VA = "0xA24448")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065A")]
		public string hudIconReference
		{
			[Token(Token = "0x60025C1")]
			[Address(RVA = "0xA24474", Offset = "0xA24474", VA = "0xA24474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065B")]
		public string lobbyBannerReference
		{
			[Token(Token = "0x60025C2")]
			[Address(RVA = "0xA244A0", Offset = "0xA244A0", VA = "0xA244A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065C")]
		public Alert m_alert
		{
			[Token(Token = "0x60025C3")]
			[Address(RVA = "0xA244CC", Offset = "0xA244CC", VA = "0xA244CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839F1C", Offset = "0x839F1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60025C4")]
			[Address(RVA = "0xA244D4", Offset = "0xA244D4", VA = "0xA244D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839F2C", Offset = "0x839F2C")]
			private set
			{
			}
		}

		[Token(Token = "0x60025C5")]
		[Address(RVA = "0xA244DC", Offset = "0xA244DC", VA = "0xA244DC")]
		public AlertEvent(RDAlertEvent alertEventData, Alert alert, List<UserSegment> userSegments, UserProfiler userProfiler, EventSchedule schedule, UkenTimeController time, CasualGame game)
		{
		}

		[Token(Token = "0x60025C6")]
		[Address(RVA = "0xA24544", Offset = "0xA24544", VA = "0xA24544")]
		private bool PassesUserSegmentsCheck()
		{
			return default(bool);
		}

		[Token(Token = "0x60025C7")]
		[Address(RVA = "0xA24694", Offset = "0xA24694", VA = "0xA24694", Slot = "9")]
		public bool InsertTemporarySchedule(DateTime startTime, DateTime endTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60025C8")]
		[Address(RVA = "0xA246DC", Offset = "0xA246DC", VA = "0xA246DC", Slot = "4")]
		public bool IsResourceActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60025C9")]
		[Address(RVA = "0xA24748", Offset = "0xA24748", VA = "0xA24748", Slot = "5")]
		public DateTime ResourceStartTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60025CA")]
		[Address(RVA = "0xA247CC", Offset = "0xA247CC", VA = "0xA247CC", Slot = "6")]
		public DateTime ResourceEndTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60025CB")]
		[Address(RVA = "0xA24850", Offset = "0xA24850", VA = "0xA24850", Slot = "7")]
		public int GetNotificationCount()
		{
			return default(int);
		}

		[Token(Token = "0x60025CC")]
		[Address(RVA = "0xA24858", Offset = "0xA24858", VA = "0xA24858", Slot = "8")]
		public string GetSpecialText()
		{
			return null;
		}
	}
}
