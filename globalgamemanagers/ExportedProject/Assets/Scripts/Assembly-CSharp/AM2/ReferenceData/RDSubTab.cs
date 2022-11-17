using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003AA")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F800", Offset = "0x81F800")]
	public class RDSubTab : BaseEntityDocument
	{
		[Token(Token = "0x4001196")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82DA8C", Offset = "0x82DA8C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DA8C", Offset = "0x82DA8C")]
		public string readableName;

		[Token(Token = "0x4001197")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82DADC", Offset = "0x82DADC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DADC", Offset = "0x82DADC")]
		public string shortName;

		[Token(Token = "0x4001198")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DB2C", Offset = "0x82DB2C")]
		public int priority;

		[Token(Token = "0x4001199")]
		public const string c_substanceRef = "Inventory";

		[Token(Token = "0x400119A")]
		public const string c_itemConvertRef = "Exchange";

		[Token(Token = "0x400119B")]
		public const string c_researchableRef = "Researchables";

		[Token(Token = "0x400119C")]
		public const string c_adsRef = "Ads";

		[Token(Token = "0x400119D")]
		public const string c_iapRef = "IAP";

		[Token(Token = "0x400119E")]
		[FieldOffset(Offset = "0x48")]
		public string tag;

		[Token(Token = "0x400119F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DB64", Offset = "0x82DB64")]
		public string loggingEventName;

		[Token(Token = "0x6001C6E")]
		[Address(RVA = "0x9BAAFC", Offset = "0x9BAAFC", VA = "0x9BAAFC")]
		public RDSubTab(string _ref)
		{
		}
	}
}
