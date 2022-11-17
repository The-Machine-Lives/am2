using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000549")]
	[Attribute(Name = "GroupAttribute", RVA = "0x820108", Offset = "0x820108")]
	public class RDStoreItem : BaseEntityDocument
	{
		[Token(Token = "0x400191F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831CDC", Offset = "0x831CDC")]
		public string name;

		[Token(Token = "0x4001920")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831D14", Offset = "0x831D14")]
		public string description;

		[Token(Token = "0x4001921")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831D4C", Offset = "0x831D4C")]
		public string bonusText;

		[Token(Token = "0x4001922")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ColorUsageAttribute", RVA = "0x831D84", Offset = "0x831D84")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831D84", Offset = "0x831D84")]
		public string bonusTextHexColourCode;

		[Token(Token = "0x4001923")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831DD4", Offset = "0x831DD4")]
		public string imagePath;

		[Token(Token = "0x4001924")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831E0C", Offset = "0x831E0C")]
		[Attribute(Name = "EntityReference", RVA = "0x831E0C", Offset = "0x831E0C")]
		public string rewardGroupName;

		[Token(Token = "0x4001925")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831E5C", Offset = "0x831E5C")]
		public bool showInfoPopup;

		[Token(Token = "0x4001926")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831E94", Offset = "0x831E94")]
		public string currencyCode;

		[Token(Token = "0x4001927")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831ECC", Offset = "0x831ECC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831ECC", Offset = "0x831ECC")]
		public double currencyCost;

		[Token(Token = "0x4001928")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831F1C", Offset = "0x831F1C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831F1C", Offset = "0x831F1C")]
		public string vendorID;

		[Token(Token = "0x4001929")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831F6C", Offset = "0x831F6C")]
		[Attribute(Name = "EntityReference", RVA = "0x831F6C", Offset = "0x831F6C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831F6C", Offset = "0x831F6C")]
		public string subTab;

		[Token(Token = "0x400192A")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831FE0", Offset = "0x831FE0")]
		[Attribute(Name = "EntityReference", RVA = "0x831FE0", Offset = "0x831FE0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831FE0", Offset = "0x831FE0")]
		public string sectionRef;

		[Token(Token = "0x400192B")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "EntityReference", RVA = "0x832054", Offset = "0x832054")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832054", Offset = "0x832054")]
		public string userSegment;

		[Token(Token = "0x400192C")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "EntityReference", RVA = "0x8320B4", Offset = "0x8320B4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8320B4", Offset = "0x8320B4")]
		public string ltoSchedule;

		[Token(Token = "0x400192D")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832114", Offset = "0x832114")]
		public long ltoStartTimeDelaySeconds;

		[Token(Token = "0x400192E")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x83214C", Offset = "0x83214C")]
		public long ltoDurationSeconds;

		[Token(Token = "0x400192F")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832184", Offset = "0x832184")]
		public int ltoPurchaseMinCooldownSeconds;

		[Token(Token = "0x4001930")]
		[FieldOffset(Offset = "0xB4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8321BC", Offset = "0x8321BC")]
		public int ltoPurchaseMaxCooldownSeconds;

		[Token(Token = "0x4001931")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8321F4", Offset = "0x8321F4")]
		public int maxActiviationsDuringScheduledDuration;

		[Token(Token = "0x6002860")]
		[Address(RVA = "0xA81A74", Offset = "0xA81A74", VA = "0xA81A74")]
		public RDStoreItem()
		{
		}
	}
}
