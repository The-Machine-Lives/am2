using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004F1")]
	public class EventSchedule : RuntimeData<RDEventSchedule>
	{
		[Token(Token = "0x400176B")]
		[FieldOffset(Offset = "0x18")]
		private TimeSlot m_currentTimeSlot;

		[Token(Token = "0x400176C")]
		[FieldOffset(Offset = "0x20")]
		private List<TimeSlot> m_timeSlots;

		[Token(Token = "0x400176D")]
		[FieldOffset(Offset = "0x28")]
		private RepeatingEventSchedule m_repeatingSchedule;

		[Token(Token = "0x400176E")]
		[FieldOffset(Offset = "0x30")]
		private UkenTimeController m_timeController;

		[Token(Token = "0x6002618")]
		[Address(RVA = "0xA64E4C", Offset = "0xA64E4C", VA = "0xA64E4C")]
		public EventSchedule()
		{
		}

		[Token(Token = "0x6002619")]
		[Address(RVA = "0xA64EC4", Offset = "0xA64EC4", VA = "0xA64EC4", Slot = "4")]
		public override void Initialize(RDEventSchedule referenceData)
		{
		}

		[Token(Token = "0x600261A")]
		[Address(RVA = "0xA65124", Offset = "0xA65124", VA = "0xA65124")]
		public EventSchedule(List<TimeSlot> timeSlots, UkenTimeController time)
		{
		}

		[Token(Token = "0x600261B")]
		[Address(RVA = "0xA60278", Offset = "0xA60278", VA = "0xA60278")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x600261C")]
		[Address(RVA = "0xA602D4", Offset = "0xA602D4", VA = "0xA602D4")]
		public bool IsActiveAtTime(DateTime time)
		{
			return default(bool);
		}

		[Token(Token = "0x600261D")]
		[Address(RVA = "0xA5FF6C", Offset = "0xA5FF6C", VA = "0xA5FF6C")]
		public bool InsertTemporaryTimeSlot(DateTime startTime, DateTime endTime)
		{
			return default(bool);
		}

		[Token(Token = "0x600261E")]
		[Address(RVA = "0xA604B4", Offset = "0xA604B4", VA = "0xA604B4")]
		public DateTime StartTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x600261F")]
		[Address(RVA = "0xA6042C", Offset = "0xA6042C", VA = "0xA6042C")]
		public DateTime EndTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x6002620")]
		[Address(RVA = "0xA6077C", Offset = "0xA6077C", VA = "0xA6077C")]
		public void StartEndTimeForTimeSlotAt(DateTime time, out DateTime slotStartTime, out DateTime slotEndTime)
		{
		}

		[Token(Token = "0x6002621")]
		[Address(RVA = "0xA60704", Offset = "0xA60704", VA = "0xA60704")]
		public int GetCurrentIteration()
		{
			return default(int);
		}

		[Token(Token = "0x6002622")]
		[Address(RVA = "0xA65664", Offset = "0xA65664", VA = "0xA65664")]
		public string GetCurrentTimeSlotReference()
		{
			return null;
		}

		[Token(Token = "0x6002623")]
		[Address(RVA = "0xA654D8", Offset = "0xA654D8", VA = "0xA654D8")]
		private TimeSlot GetTimeSlotForDateTime(DateTime time)
		{
			return null;
		}

		[Token(Token = "0x6002624")]
		[Address(RVA = "0xA651DC", Offset = "0xA651DC", VA = "0xA651DC")]
		private TimeSlot GetCurrentTimeSlot()
		{
			return null;
		}

		[Token(Token = "0x6002625")]
		[Address(RVA = "0xA65700", Offset = "0xA65700", VA = "0xA65700")]
		private bool HasRepeatingSchedule()
		{
			return default(bool);
		}

		[Token(Token = "0x6002626")]
		[Address(RVA = "0xA65714", Offset = "0xA65714", VA = "0xA65714")]
		public int GetStartTimeInUnixSeconds()
		{
			return default(int);
		}

		[Token(Token = "0x6002627")]
		[Address(RVA = "0xA657E0", Offset = "0xA657E0", VA = "0xA657E0")]
		public RepeatingEventScheduleIterationType GetRepeatingType()
		{
			return default(RepeatingEventScheduleIterationType);
		}
	}
}
