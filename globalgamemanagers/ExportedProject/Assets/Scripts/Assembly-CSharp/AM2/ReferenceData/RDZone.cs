using System.Collections.Generic;
using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000333")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EE28", Offset = "0x81EE28")]
	public class RDZone : RDResearchable
	{
		[Token(Token = "0x4000FC8")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82863C", Offset = "0x82863C")]
		public string readableName;

		[Token(Token = "0x4000FC9")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x828674", Offset = "0x828674")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828674", Offset = "0x828674")]
		public string playCostItemRef;

		[Token(Token = "0x4000FCA")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8286C4", Offset = "0x8286C4")]
		public long playCostQuantity;

		[Token(Token = "0x4000FCB")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "EntityReference", RVA = "0x8286FC", Offset = "0x8286FC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8286FC", Offset = "0x8286FC")]
		public string onEnterRewardGroup;

		[Token(Token = "0x4000FCC")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "EntityReference", RVA = "0x82875C", Offset = "0x82875C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82875C", Offset = "0x82875C")]
		public List<string> encounters;

		[Token(Token = "0x4000FCD")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8287BC", Offset = "0x8287BC")]
		public BISoundEvents.EventKey ambientSoundEventOverride;

		[Token(Token = "0x60019BE")]
		[Address(RVA = "0x9BAC30", Offset = "0x9BAC30", VA = "0x9BAC30")]
		public RDZone(string _ref)
		{
		}
	}
}
