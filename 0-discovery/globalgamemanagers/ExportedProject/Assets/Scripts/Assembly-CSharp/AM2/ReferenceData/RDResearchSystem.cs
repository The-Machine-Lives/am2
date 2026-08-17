using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000366")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F218", Offset = "0x81F218")]
	public class RDResearchSystem : BaseEntityDocument
	{
		[Token(Token = "0x40010A3")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82A954", Offset = "0x82A954")]
		[Attribute(Name = "EntityReference", RVA = "0x82A954", Offset = "0x82A954")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A954", Offset = "0x82A954")]
		public string powerSustainTime;

		[Token(Token = "0x40010A4")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82A9C8", Offset = "0x82A9C8")]
		[Attribute(Name = "EntityReference", RVA = "0x82A9C8", Offset = "0x82A9C8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A9C8", Offset = "0x82A9C8")]
		public string maxRate;

		[Token(Token = "0x40010A5")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82AA3C", Offset = "0x82AA3C")]
		[Attribute(Name = "EntityReference", RVA = "0x82AA3C", Offset = "0x82AA3C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82AA3C", Offset = "0x82AA3C")]
		public string loadoutSlots;

		[Token(Token = "0x40010A6")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82AAB0", Offset = "0x82AAB0")]
		[Attribute(Name = "EntityReference", RVA = "0x82AAB0", Offset = "0x82AAB0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82AAB0", Offset = "0x82AAB0")]
		public string numSlots;

		[Token(Token = "0x40010A7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82AB24", Offset = "0x82AB24")]
		[Attribute(Name = "EntityReference", RVA = "0x82AB24", Offset = "0x82AB24")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82AB24", Offset = "0x82AB24")]
		public string equipmentSlots;

		[Token(Token = "0x40010A8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82AB98", Offset = "0x82AB98")]
		[Attribute(Name = "EntityReference", RVA = "0x82AB98", Offset = "0x82AB98")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82AB98", Offset = "0x82AB98")]
		public string powerGrowthRate;

		[Token(Token = "0x40010A9")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82AC0C", Offset = "0x82AC0C")]
		[Attribute(Name = "EntityReference", RVA = "0x82AC0C", Offset = "0x82AC0C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82AC0C", Offset = "0x82AC0C")]
		public string powerDecayTime;

		[Token(Token = "0x40010AA")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82AC80", Offset = "0x82AC80")]
		[Attribute(Name = "EntityReference", RVA = "0x82AC80", Offset = "0x82AC80")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82AC80", Offset = "0x82AC80")]
		public string globalSpeedBoost;

		[Token(Token = "0x40010AB")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82ACF4", Offset = "0x82ACF4")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x82ACF4", Offset = "0x82ACF4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82ACF4", Offset = "0x82ACF4")]
		public string dustOutputItem;

		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x9BAA74", Offset = "0x9BAA74", VA = "0x9BAA74")]
		public RDResearchSystem(string _ref)
		{
		}
	}
}
