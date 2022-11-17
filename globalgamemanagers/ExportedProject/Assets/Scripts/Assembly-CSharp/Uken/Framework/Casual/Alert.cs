using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004E8")]
	public class Alert
	{
		[Token(Token = "0x4001749")]
		private const string m_alertShownCountKey = "alert_shown_{0}";

		[Token(Token = "0x400174A")]
		private const string m_alertIterationKey = "alert_iteration_{0}";

		[Token(Token = "0x400174B")]
		[FieldOffset(Offset = "0x10")]
		private bool hasShownThisSession;

		[Token(Token = "0x400174C")]
		[FieldOffset(Offset = "0x18")]
		private RDAlert m_alertData;

		[Token(Token = "0x400174D")]
		[FieldOffset(Offset = "0x20")]
		private EventSchedule m_scheduleData;

		[Token(Token = "0x400174E")]
		[FieldOffset(Offset = "0x28")]
		private UkenTimeController m_time;

		[Token(Token = "0x400174F")]
		[FieldOffset(Offset = "0x30")]
		private List<UserSegment> m_userSegments;

		[Token(Token = "0x4001750")]
		[FieldOffset(Offset = "0x38")]
		private UserProfiler m_userProfiler;

		[Token(Token = "0x1700065E")]
		public string reference
		{
			[Token(Token = "0x60025D2")]
			[Address(RVA = "0xA23BD8", Offset = "0xA23BD8", VA = "0xA23BD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065F")]
		public int maxShowCount
		{
			[Token(Token = "0x60025D3")]
			[Address(RVA = "0xA23C04", Offset = "0xA23C04", VA = "0xA23C04")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000660")]
		public bool newUserOnly
		{
			[Token(Token = "0x60025D4")]
			[Address(RVA = "0xA23C30", Offset = "0xA23C30", VA = "0xA23C30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000661")]
		public string imageUrl
		{
			[Token(Token = "0x60025D5")]
			[Address(RVA = "0xA23C5C", Offset = "0xA23C5C", VA = "0xA23C5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000662")]
		public string iconPath
		{
			[Token(Token = "0x60025D6")]
			[Address(RVA = "0xA23C88", Offset = "0xA23C88", VA = "0xA23C88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000663")]
		public string titleText
		{
			[Token(Token = "0x60025D7")]
			[Address(RVA = "0xA23CB4", Offset = "0xA23CB4", VA = "0xA23CB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000664")]
		public string middleText
		{
			[Token(Token = "0x60025D8")]
			[Address(RVA = "0xA23CE0", Offset = "0xA23CE0", VA = "0xA23CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000665")]
		public string bottomText
		{
			[Token(Token = "0x60025D9")]
			[Address(RVA = "0xA23D0C", Offset = "0xA23D0C", VA = "0xA23D0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000666")]
		public int priority
		{
			[Token(Token = "0x60025DA")]
			[Address(RVA = "0xA23D38", Offset = "0xA23D38", VA = "0xA23D38")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000667")]
		private string FormattedCountKey
		{
			[Token(Token = "0x60025DB")]
			[Address(RVA = "0xA23D64", Offset = "0xA23D64", VA = "0xA23D64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000668")]
		private string FormattedIterationKey
		{
			[Token(Token = "0x60025DC")]
			[Address(RVA = "0xA23DC8", Offset = "0xA23DC8", VA = "0xA23DC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60025DD")]
		[Address(RVA = "0xA23E2C", Offset = "0xA23E2C", VA = "0xA23E2C")]
		public Alert(RDAlert alertData, List<UserSegment> userSegments, UserProfiler userProfiler, EventSchedule scheduleData, UkenTimeController time)
		{
		}

		[Token(Token = "0x60025DE")]
		[Address(RVA = "0xA23E80", Offset = "0xA23E80", VA = "0xA23E80")]
		public DateTime StartTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60025DF")]
		[Address(RVA = "0xA23F04", Offset = "0xA23F04", VA = "0xA23F04")]
		public DateTime EndTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60025E0")]
		[Address(RVA = "0xA23F88", Offset = "0xA23F88", VA = "0xA23F88")]
		public void MarkShown(bool value)
		{
		}

		[Token(Token = "0x60025E1")]
		[Address(RVA = "0xA23F94", Offset = "0xA23F94", VA = "0xA23F94")]
		public bool HasShownThisSession()
		{
			return default(bool);
		}

		[Token(Token = "0x60025E2")]
		[Address(RVA = "0xA23F9C", Offset = "0xA23F9C", VA = "0xA23F9C")]
		public bool IsViewed()
		{
			return default(bool);
		}

		[Token(Token = "0x60025E3")]
		[Address(RVA = "0xA2408C", Offset = "0xA2408C", VA = "0xA2408C")]
		public void UpdateViewed()
		{
		}

		[Token(Token = "0x60025E4")]
		[Address(RVA = "0xA2411C", Offset = "0xA2411C", VA = "0xA2411C")]
		public static int CompareAlertPriority(Alert x, Alert y)
		{
			return default(int);
		}

		[Token(Token = "0x60025E5")]
		[Address(RVA = "0xA241AC", Offset = "0xA241AC", VA = "0xA241AC")]
		private bool PassesUserSegmentsCheck()
		{
			return default(bool);
		}

		[Token(Token = "0x60025E6")]
		[Address(RVA = "0xA242FC", Offset = "0xA242FC", VA = "0xA242FC")]
		public bool CanShowUser()
		{
			return default(bool);
		}

		[Token(Token = "0x60025E7")]
		[Address(RVA = "0xA240B4", Offset = "0xA240B4", VA = "0xA240B4")]
		private void SetShowCount(int value)
		{
		}

		[Token(Token = "0x60025E8")]
		[Address(RVA = "0xA24004", Offset = "0xA24004", VA = "0xA24004")]
		private int GetShowCount()
		{
			return default(int);
		}
	}
}
