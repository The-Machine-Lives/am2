using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200052C")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FF48", Offset = "0x81FF48")]
	public class RDSaleItem : BaseEntityDocument
	{
		[Token(Token = "0x400186D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DropdownNameAttribute", RVA = "0x830C38", Offset = "0x830C38")]
		public int bingoPrefabType;

		[Token(Token = "0x400186E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x830C70", Offset = "0x830C70")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830C70", Offset = "0x830C70")]
		public List<string> productReferences;

		[Token(Token = "0x400186F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "EntityReference", RVA = "0x830CC0", Offset = "0x830CC0")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830CC0", Offset = "0x830CC0")]
		public List<string> userSegmentReferences;

		[Token(Token = "0x4001870")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "EntityReference", RVA = "0x830D10", Offset = "0x830D10")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830D10", Offset = "0x830D10")]
		public string iapProduct;

		[Token(Token = "0x4001871")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DeprecatedAttribute", RVA = "0x830D60", Offset = "0x830D60")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x830D60", Offset = "0x830D60")]
		public float price;

		[Token(Token = "0x4001872")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DeprecatedAttribute", RVA = "0x830DC0", Offset = "0x830DC0")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x830DC0", Offset = "0x830DC0")]
		public string currency;

		[Token(Token = "0x4001873")]
		[FieldOffset(Offset = "0x60")]
		public ImageSourceType backgroundImageSourceType;

		[Token(Token = "0x4001874")]
		[FieldOffset(Offset = "0x68")]
		public string backgroundImageSourcePath;

		[Token(Token = "0x4001875")]
		[FieldOffset(Offset = "0x70")]
		public int displayPriority;

		[Token(Token = "0x4001876")]
		[FieldOffset(Offset = "0x78")]
		public string displayNameSingular;

		[Token(Token = "0x4001877")]
		[FieldOffset(Offset = "0x80")]
		public string descriptionLongFormatString;

		[Token(Token = "0x4001878")]
		[FieldOffset(Offset = "0x88")]
		public bool showsBadge;

		[Token(Token = "0x4001879")]
		[FieldOffset(Offset = "0x90")]
		public string badgeTextTopFormatString;

		[Token(Token = "0x400187A")]
		[FieldOffset(Offset = "0x98")]
		public string badgeTextBottomFormatString;

		[Token(Token = "0x600279C")]
		[Address(RVA = "0xA81944", Offset = "0xA81944", VA = "0xA81944")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600279D")]
		[Address(RVA = "0xA819E8", Offset = "0xA819E8", VA = "0xA819E8")]
		public RDSaleItem()
		{
		}
	}
}
