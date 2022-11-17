using System;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004F3")]
	[AttributeAttribute(Name = "GroupAttribute", RVA = "0x81FD24", Offset = "0x81FD24")]
	public class RDRepeatingEventSchedule : BaseEntityDocument
	{
		[Token(Token = "0x4001776")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x82FAA0", Offset = "0x82FAA0")]
		public RepeatingEventScheduleIterationType iterationType;

		[Token(Token = "0x4001777")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x82FAD8", Offset = "0x82FAD8")]
		public DayOfWeek weeklyIterationStartDay;

		[Token(Token = "0x4001778")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x82FB10", Offset = "0x82FB10")]
		public int startHour;

		[Token(Token = "0x4001779")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x82FB48", Offset = "0x82FB48")]
		public int startMinute;

		[Token(Token = "0x400177A")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x82FB80", Offset = "0x82FB80")]
		public int customTimeSpanDays;

		[Token(Token = "0x400177B")]
		[FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x82FBB8", Offset = "0x82FBB8")]
		public int cooldown;

		[Token(Token = "0x6002628")]
		[Address(RVA = "0xA81854", Offset = "0xA81854", VA = "0xA81854")]
		public RDRepeatingEventSchedule()
		{
		}
	}
}
