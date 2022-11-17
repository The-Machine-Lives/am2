using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000508")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FDCC", Offset = "0x81FDCC")]
	public class RDItem : BaseEntityDocument
	{
		[Token(Token = "0x40017AD")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DepotReference", RVA = "0x82FDC8", Offset = "0x82FDC8")]
		public string depot;

		[Token(Token = "0x40017AE")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DynamicEntityReference", RVA = "0x82FE4C", Offset = "0x82FE4C")]
		public string itemReference;

		[Token(Token = "0x40017AF")]
		[FieldOffset(Offset = "0x40")]
		public string smallImage;

		[Token(Token = "0x40017B0")]
		[FieldOffset(Offset = "0x48")]
		public string largeImage;

		[Token(Token = "0x40017B1")]
		[FieldOffset(Offset = "0x50")]
		public string name;

		[Token(Token = "0x40017B2")]
		[FieldOffset(Offset = "0x58")]
		public string namePlural;

		[Token(Token = "0x40017B3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DropdownNameAttribute", RVA = "0x82FE60", Offset = "0x82FE60")]
		public int frameStyle;

		[Token(Token = "0x600268C")]
		[Address(RVA = "0xA8122C", Offset = "0xA8122C", VA = "0xA8122C")]
		public RDItem()
		{
		}
	}
}
