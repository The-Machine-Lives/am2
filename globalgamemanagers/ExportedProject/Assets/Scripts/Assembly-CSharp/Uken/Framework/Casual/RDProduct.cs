using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200052B")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FF10", Offset = "0x81FF10")]
	public class RDProduct : BaseEntityDocument
	{
		[Token(Token = "0x4001860")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DropdownNameAttribute", RVA = "0x830BEC", Offset = "0x830BEC")]
		public int bingoPrefabType;

		[Token(Token = "0x4001861")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830C24", Offset = "0x830C24")]
		public string itemName;

		[Token(Token = "0x4001862")]
		[FieldOffset(Offset = "0x40")]
		public int quantity;

		[Token(Token = "0x4001863")]
		[FieldOffset(Offset = "0x44")]
		public bool isScalable;

		[Token(Token = "0x4001864")]
		[FieldOffset(Offset = "0x45")]
		public bool showsBadge;

		[Token(Token = "0x4001865")]
		[FieldOffset(Offset = "0x48")]
		public string badgeTextTopFormatString;

		[Token(Token = "0x4001866")]
		[FieldOffset(Offset = "0x50")]
		public string badgeTextBottomFormatString;

		[Token(Token = "0x4001867")]
		[FieldOffset(Offset = "0x58")]
		public float percentBonus;

		[Token(Token = "0x4001868")]
		[FieldOffset(Offset = "0x5C")]
		public float bonusMultiplier;

		[Token(Token = "0x4001869")]
		[FieldOffset(Offset = "0x60")]
		public ImageSourceType backgroundImageSourceType;

		[Token(Token = "0x400186A")]
		[FieldOffset(Offset = "0x68")]
		public string backgroundImageSourcePath;

		[Token(Token = "0x400186B")]
		[FieldOffset(Offset = "0x70")]
		public ImageSourceType itemImageSourceType;

		[Token(Token = "0x400186C")]
		[FieldOffset(Offset = "0x78")]
		public string itemImageSourcePath;

		[Token(Token = "0x600279A")]
		[Address(RVA = "0xA81764", Offset = "0xA81764", VA = "0xA81764")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600279B")]
		[Address(RVA = "0xA817E8", Offset = "0xA817E8", VA = "0xA817E8")]
		public RDProduct()
		{
		}
	}
}
