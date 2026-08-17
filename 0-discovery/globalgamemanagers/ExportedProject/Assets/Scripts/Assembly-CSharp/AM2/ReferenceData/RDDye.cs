using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000390")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F598", Offset = "0x81F598")]
	public class RDDye : BaseEntityDocument
	{
		[Token(Token = "0x4001153")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CBCC", Offset = "0x82CBCC")]
		public string readableColorName;

		[Token(Token = "0x4001154")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CC04", Offset = "0x82CC04")]
		[Attribute(Name = "ColorUsageAttribute", RVA = "0x82CC04", Offset = "0x82CC04")]
		public string color;

		[Token(Token = "0x4001155")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CC54", Offset = "0x82CC54")]
		public int dustOutputAmount;

		[Token(Token = "0x4001156")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CC8C", Offset = "0x82CC8C")]
		public EDropTier rarity;

		[Token(Token = "0x4001157")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CCC4", Offset = "0x82CCC4")]
		public string infoText;

		[Token(Token = "0x4001158")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CCFC", Offset = "0x82CCFC")]
		public string infoImageSource;

		[Token(Token = "0x6001BEF")]
		[Address(RVA = "0x9BA378", Offset = "0x9BA378", VA = "0x9BA378")]
		public RDDye(string _ref)
		{
		}
	}
}
