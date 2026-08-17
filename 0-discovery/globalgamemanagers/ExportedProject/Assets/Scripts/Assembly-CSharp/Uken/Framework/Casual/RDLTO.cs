using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200053C")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FFF0", Offset = "0x81FFF0")]
	public class RDLTO : BaseEntityDocument
	{
		[Token(Token = "0x40018D4")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DropdownNameAttribute", RVA = "0x8314C0", Offset = "0x8314C0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8314C0", Offset = "0x8314C0")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x8314C0", Offset = "0x8314C0")]
		public List<int> surfacePoints;

		[Token(Token = "0x40018D5")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x831534", Offset = "0x831534")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831534", Offset = "0x831534")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831534", Offset = "0x831534")]
		public string schedule;

		[Token(Token = "0x40018D6")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "EntityReference", RVA = "0x8315A8", Offset = "0x8315A8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8315A8", Offset = "0x8315A8")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x8315A8", Offset = "0x8315A8")]
		public string offerSet;

		[Token(Token = "0x600280C")]
		[Address(RVA = "0xA813F4", Offset = "0xA813F4", VA = "0xA813F4")]
		public RDLTO()
		{
		}
	}
}
