using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000319")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EC30", Offset = "0x81EC30")]
	public class RDDiffHealth : RDAbilityEffect
	{
		[Token(Token = "0x4000F58")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827130", Offset = "0x827130")]
		public bool isDamage;

		[Token(Token = "0x4000F59")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827168", Offset = "0x827168")]
		public long minDiff;

		[Token(Token = "0x4000F5A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8271A0", Offset = "0x8271A0")]
		public long maxDiff;

		[Token(Token = "0x4000F5B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "EntityReference", RVA = "0x8271D8", Offset = "0x8271D8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8271D8", Offset = "0x8271D8")]
		public string levellableMinDiff;

		[Token(Token = "0x4000F5C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "EntityReference", RVA = "0x827238", Offset = "0x827238")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827238", Offset = "0x827238")]
		public string levellableMaxDiff;

		[Token(Token = "0x4000F5D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827298", Offset = "0x827298")]
		public bool isPercentage;

		[Token(Token = "0x4000F5E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "EntityReference", RVA = "0x8272D0", Offset = "0x8272D0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8272D0", Offset = "0x8272D0")]
		public string diffType;

		[Token(Token = "0x4000F5F")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827330", Offset = "0x827330")]
		public bool interrupts;

		[Token(Token = "0x4000F60")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827368", Offset = "0x827368")]
		public BISoundEvents.EventKey dealDamageSoundEventOverride;

		[Token(Token = "0x4000F61")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8273A0", Offset = "0x8273A0")]
		public bool canDoNegativeDiff;

		[Token(Token = "0x6001922")]
		[Address(RVA = "0x9BA36C", Offset = "0x9BA36C", VA = "0x9BA36C")]
		public RDDiffHealth(string inReference)
		{
		}
	}
}
