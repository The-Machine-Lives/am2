using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000386")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F4B8", Offset = "0x81F4B8")]
	public class RDPrestigePermanentItems : BaseEntityDocument
	{
		[Token(Token = "0x4001130")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x82C330", Offset = "0x82C330")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C330", Offset = "0x82C330")]
		public List<string> itemResetTransactionsToLogWhiteList;

		[Token(Token = "0x4001131")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C390", Offset = "0x82C390")]
		public bool keepAllBadges;

		[Token(Token = "0x4001132")]
		[FieldOffset(Offset = "0x39")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C3C8", Offset = "0x82C3C8")]
		public bool keepAllDyes;

		[Token(Token = "0x4001133")]
		[FieldOffset(Offset = "0x3A")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C400", Offset = "0x82C400")]
		public bool keepAllTitles;

		[Token(Token = "0x4001134")]
		[FieldOffset(Offset = "0x3B")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C438", Offset = "0x82C438")]
		public bool keepAllBooster;

		[Token(Token = "0x4001135")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C470", Offset = "0x82C470")]
		public bool keepAllEquipmentItems;

		[Token(Token = "0x4001136")]
		[FieldOffset(Offset = "0x3D")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C4A8", Offset = "0x82C4A8")]
		public bool keepAllMessages;

		[Token(Token = "0x4001137")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "EntityReference", RVA = "0x82C4E0", Offset = "0x82C4E0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C4E0", Offset = "0x82C4E0")]
		public List<string> equipmentToKeep;

		[Token(Token = "0x4001138")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "EntityReference", RVA = "0x82C540", Offset = "0x82C540")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C540", Offset = "0x82C540")]
		public List<string> recipesToKeep;

		[Token(Token = "0x4001139")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "EntityReference", RVA = "0x82C5A0", Offset = "0x82C5A0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C5A0", Offset = "0x82C5A0")]
		public List<string> badgesToKeep;

		[Token(Token = "0x400113A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "EntityReference", RVA = "0x82C600", Offset = "0x82C600")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C600", Offset = "0x82C600")]
		public List<string> titlesToKeep;

		[Token(Token = "0x400113B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "EntityReference", RVA = "0x82C660", Offset = "0x82C660")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C660", Offset = "0x82C660")]
		public List<string> dyesToKeep;

		[Token(Token = "0x400113C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "EntityReference", RVA = "0x82C6C0", Offset = "0x82C6C0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C6C0", Offset = "0x82C6C0")]
		public List<string> unlockersToKeep;

		[Token(Token = "0x400113D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "EntityReference", RVA = "0x82C720", Offset = "0x82C720")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C720", Offset = "0x82C720")]
		public List<string> researchToKeep;

		[Token(Token = "0x400113E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "EntityReference", RVA = "0x82C780", Offset = "0x82C780")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C780", Offset = "0x82C780")]
		public List<string> upgradablesToKeep;

		[Token(Token = "0x400113F")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "EntityReference", RVA = "0x82C7E0", Offset = "0x82C7E0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C7E0", Offset = "0x82C7E0")]
		public List<string> questsToKeep;

		[Token(Token = "0x4001140")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "EntityReference", RVA = "0x82C840", Offset = "0x82C840")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C840", Offset = "0x82C840")]
		public List<string> itemConvertersToKeep;

		[Token(Token = "0x4001141")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x82C8A0", Offset = "0x82C8A0")]
		public List<string> scenesToKeep;

		[Token(Token = "0x6001BBB")]
		[Address(RVA = "0x9BA6B4", Offset = "0x9BA6B4", VA = "0x9BA6B4")]
		public RDPrestigePermanentItems(string inReference)
		{
		}
	}
}
