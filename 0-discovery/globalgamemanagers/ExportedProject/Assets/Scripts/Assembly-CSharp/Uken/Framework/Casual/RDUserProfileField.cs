using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000553")]
	public class RDUserProfileField : BaseEntityDocument
	{
		[Token(Token = "0x4001966")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x832540", Offset = "0x832540")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832540", Offset = "0x832540")]
		public string viewData;

		[Token(Token = "0x4001967")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8325A0", Offset = "0x8325A0")]
		public string fieldName;

		[Token(Token = "0x4001968")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8325D8", Offset = "0x8325D8")]
		public bool IsVisible;

		[Token(Token = "0x4001969")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832610", Offset = "0x832610")]
		public string FallbackText;

		[Token(Token = "0x400196A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "EntityReference", RVA = "0x832648", Offset = "0x832648")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832648", Offset = "0x832648")]
		public string localization;

		[Token(Token = "0x400196B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8326A8", Offset = "0x8326A8")]
		public int displayOrder;

		[Token(Token = "0x60028D4")]
		[Address(RVA = "0xA81C30", Offset = "0xA81C30", VA = "0xA81C30")]
		public RDUserProfileField()
		{
		}
	}
}
