using System;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004F4")]
	public class RepeatingEventSchedule : RuntimeData<RDRepeatingEventSchedule>
	{
		[Token(Token = "0x17000688")]
		public RepeatingEventScheduleIterationType m_iterationType
		{
			[Token(Token = "0x6002629")]
			[Address(RVA = "0xA85888", Offset = "0xA85888", VA = "0xA85888")]
			get
			{
				return default(RepeatingEventScheduleIterationType);
			}
		}

		[Token(Token = "0x17000689")]
		private DayOfWeek m_startDay
		{
			[Token(Token = "0x600262A")]
			[Address(RVA = "0xA858B4", Offset = "0xA858B4", VA = "0xA858B4")]
			get
			{
				return default(DayOfWeek);
			}
		}

		[Token(Token = "0x1700068A")]
		private int m_startHour
		{
			[Token(Token = "0x600262B")]
			[Address(RVA = "0xA858E0", Offset = "0xA858E0", VA = "0xA858E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700068B")]
		private int m_startMinute
		{
			[Token(Token = "0x600262C")]
			[Address(RVA = "0xA8590C", Offset = "0xA8590C", VA = "0xA8590C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700068C")]
		private int m_customTimeSpan
		{
			[Token(Token = "0x600262D")]
			[Address(RVA = "0xA85938", Offset = "0xA85938", VA = "0xA85938")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700068D")]
		private int m_cooldown
		{
			[Token(Token = "0x600262E")]
			[Address(RVA = "0xA85964", Offset = "0xA85964", VA = "0xA85964")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600262F")]
		[Address(RVA = "0xA85990", Offset = "0xA85990", VA = "0xA85990")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6002630")]
		[Address(RVA = "0xA859A0", Offset = "0xA859A0", VA = "0xA859A0")]
		public TimeSlot GetCurrentTimeSlot(TimeSlot timeSlot, DateTime currentTime)
		{
			return null;
		}

		[Token(Token = "0x6002631")]
		[Address(RVA = "0xA85A78", Offset = "0xA85A78", VA = "0xA85A78")]
		protected DateTime GetStartTime(TimeSlot timeSlot, DateTime currentTime)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6002632")]
		[Address(RVA = "0xA85BAC", Offset = "0xA85BAC", VA = "0xA85BAC")]
		protected DateTime GetEndTime(TimeSlot timeSlot, DateTime currentTime)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6002633")]
		[Address(RVA = "0xA85EB4", Offset = "0xA85EB4", VA = "0xA85EB4")]
		protected DateTime GetEarliestStartTime(TimeSlot timeSlot)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6002634")]
		[Address(RVA = "0xA85D74", Offset = "0xA85D74", VA = "0xA85D74")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x839F5C", Offset = "0x839F5C")]
		protected double GetIterationNumber(TimeSlot timeSlot, DateTime currentTime)
		{
			return default(double);
		}

		[Token(Token = "0x6002635")]
		[Address(RVA = "0xA860F0", Offset = "0xA860F0", VA = "0xA860F0")]
		public TimeSpan GetIterationDurationWithCooldown()
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x6002636")]
		[Address(RVA = "0xA8615C", Offset = "0xA8615C", VA = "0xA8615C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x839F94", Offset = "0x839F94")]
		public TimeSpan GetIterationDuration()
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x6002637")]
		[Address(RVA = "0xA86270", Offset = "0xA86270", VA = "0xA86270")]
		public RepeatingEventSchedule()
		{
		}
	}
}
