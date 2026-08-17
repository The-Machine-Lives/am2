using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x200045E")]
	public class CasualDataCacheController : DepotController
	{
		[Token(Token = "0x4001450")]
		[FieldOffset(Offset = "0x20")]
		private RuntimeDataCache<RepeatingEventSchedule, RDRepeatingEventSchedule> m_repeatingEventScheduleCache;

		[Token(Token = "0x4001451")]
		[FieldOffset(Offset = "0x28")]
		private RuntimeDataCache<EventSchedule, RDEventSchedule> m_eventScheduleCache;

		[Token(Token = "0x4001452")]
		[FieldOffset(Offset = "0x30")]
		private RuntimeDataCache<TimeSlot, RDTimeSlot> m_timeSlotsCache;

		[Token(Token = "0x60020A7")]
		[Address(RVA = "0xB348EC", Offset = "0xB348EC", VA = "0xB348EC")]
		public CasualDataCacheController(DataStoreController dataStoreController)
		{
		}

		[Token(Token = "0x60020A8")]
		[Address(RVA = "0xB34918", Offset = "0xB34918", VA = "0xB34918", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x60020A9")]
		[Address(RVA = "0xB34B6C", Offset = "0xB34B6C", VA = "0xB34B6C")]
		public RepeatingEventSchedule GetRepeatingEventSchedule(string reference)
		{
			return null;
		}

		[Token(Token = "0x60020AA")]
		[Address(RVA = "0xB34BDC", Offset = "0xB34BDC", VA = "0xB34BDC")]
		public List<TimeSlot> GetTimeSlots(List<string> timeSlotReferences)
		{
			return null;
		}

		[Token(Token = "0x60020AB")]
		[Address(RVA = "0xB34C4C", Offset = "0xB34C4C", VA = "0xB34C4C")]
		public EventSchedule GetEventSchedule(string reference)
		{
			return null;
		}
	}
}
