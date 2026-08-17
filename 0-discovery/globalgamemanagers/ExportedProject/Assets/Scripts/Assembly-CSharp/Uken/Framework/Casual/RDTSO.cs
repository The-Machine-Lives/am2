using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200053F")]
	[Attribute(Name = "GroupAttribute", RVA = "0x820098", Offset = "0x820098")]
	public class RDTSO : BaseEntityDocument
	{
		[Token(Token = "0x40018E4")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8319A0", Offset = "0x8319A0")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x8319A0", Offset = "0x8319A0")]
		public int activationIntervalMinutes;

		[Token(Token = "0x40018E5")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DropdownNameAttribute", RVA = "0x8319F0", Offset = "0x8319F0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8319F0", Offset = "0x8319F0")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x8319F0", Offset = "0x8319F0")]
		public List<int> surfacePoints;

		[Token(Token = "0x40018E6")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "EntityReference", RVA = "0x831A64", Offset = "0x831A64")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831A64", Offset = "0x831A64")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831A64", Offset = "0x831A64")]
		public string schedule;

		[Token(Token = "0x40018E7")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "EntityReference", RVA = "0x831AD8", Offset = "0x831AD8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831AD8", Offset = "0x831AD8")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831AD8", Offset = "0x831AD8")]
		public string offerSet;

		[Token(Token = "0x40018E8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "EntityReference", RVA = "0x831B4C", Offset = "0x831B4C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831B4C", Offset = "0x831B4C")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831B4C", Offset = "0x831B4C")]
		public string gameTrigger;

		[Token(Token = "0x40018E9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831BC0", Offset = "0x831BC0")]
		public bool allowOverlap;

		[Token(Token = "0x600280F")]
		[Address(RVA = "0xA81ADC", Offset = "0xA81ADC", VA = "0xA81ADC")]
		public RDTSO()
		{
		}
	}
}
