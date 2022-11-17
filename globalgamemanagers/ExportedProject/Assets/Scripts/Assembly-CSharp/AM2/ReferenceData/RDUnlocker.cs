using System.Collections.Generic;
using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003B2")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F8A8", Offset = "0x81F8A8")]
	public class RDUnlocker : RDResearchable
	{
		[Token(Token = "0x40011BE")]
		public const string c_profileUnlockerRef = "profile_unlocker";

		[Token(Token = "0x40011BF")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DD1C", Offset = "0x82DD1C")]
		public EUnlockType unlockType;

		[Token(Token = "0x40011C0")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "EntityReference", RVA = "0x82DD54", Offset = "0x82DD54")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DD54", Offset = "0x82DD54")]
		public List<string> conditions;

		[Token(Token = "0x40011C1")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "EntityReference", RVA = "0x82DDB4", Offset = "0x82DDB4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DDB4", Offset = "0x82DDB4")]
		public string recipeRef;

		[Token(Token = "0x40011C2")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "EntityReference", RVA = "0x82DE14", Offset = "0x82DE14")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DE14", Offset = "0x82DE14")]
		public string itemConverterRef;

		[Token(Token = "0x40011C3")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DE74", Offset = "0x82DE74")]
		public string category;

		[Token(Token = "0x40011C4")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "EntityReference", RVA = "0x82DEAC", Offset = "0x82DEAC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DEAC", Offset = "0x82DEAC")]
		public string rewardGroup;

		[Token(Token = "0x6001C86")]
		[Address(RVA = "0x9BAB3C", Offset = "0x9BAB3C", VA = "0x9BAB3C")]
		public RDUnlocker(string _ref)
		{
		}
	}
}
