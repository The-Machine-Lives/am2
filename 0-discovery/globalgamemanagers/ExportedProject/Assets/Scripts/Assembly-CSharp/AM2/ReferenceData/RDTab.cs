using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003AD")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F838", Offset = "0x81F838")]
	public class RDTab : BaseEntityDocument
	{
		[Token(Token = "0x40011A0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82DB9C", Offset = "0x82DB9C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DB9C", Offset = "0x82DB9C")]
		public string readableName;

		[Token(Token = "0x40011A1")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82DBEC", Offset = "0x82DBEC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DBEC", Offset = "0x82DBEC")]
		public string shortName;

		[Token(Token = "0x40011A2")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DC3C", Offset = "0x82DC3C")]
		public BISoundEvents.EventKey ambientSoundOverride;

		[Token(Token = "0x40011A3")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DC74", Offset = "0x82DC74")]
		public BISoundEvents.EventKey onClickSoundOverride;

		[Token(Token = "0x6001C7B")]
		[Address(RVA = "0x9BAB0C", Offset = "0x9BAB0C", VA = "0x9BAB0C")]
		public RDTab()
		{
		}
	}
}
