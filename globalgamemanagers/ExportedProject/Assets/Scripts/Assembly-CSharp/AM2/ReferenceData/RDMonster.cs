using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200032C")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81ED80", Offset = "0x81ED80")]
	public class RDMonster : BaseEntityDocument
	{
		[Token(Token = "0x4000FAF")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828268", Offset = "0x828268")]
		public string readableName;

		[Token(Token = "0x4000FB0")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x8282A0", Offset = "0x8282A0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8282A0", Offset = "0x8282A0")]
		public string rewardGroup;

		[Token(Token = "0x4000FB1")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "EntityReference", RVA = "0x828300", Offset = "0x828300")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828300", Offset = "0x828300")]
		public List<string> startingBuffs;

		[Token(Token = "0x4000FB2")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "EntityReference", RVA = "0x828360", Offset = "0x828360")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828360", Offset = "0x828360")]
		public List<string> abilityGroups;

		[Token(Token = "0x4000FB3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8283C0", Offset = "0x8283C0")]
		public long health;

		[Token(Token = "0x4000FB4")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x8283F8", Offset = "0x8283F8")]
		[Attribute(Name = "EntityReference", RVA = "0x8283F8", Offset = "0x8283F8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8283F8", Offset = "0x8283F8")]
		public string healthType;

		[Token(Token = "0x4000FB5")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82846C", Offset = "0x82846C")]
		public bool isThreat;

		[Token(Token = "0x4000FB6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8284A4", Offset = "0x8284A4")]
		public long level;

		[Token(Token = "0x4000FB7")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8284DC", Offset = "0x8284DC")]
		public BISoundEvents.EventKey deathSoundEventOverride;

		[Token(Token = "0x6001998")]
		[Address(RVA = "0x9BA664", Offset = "0x9BA664", VA = "0x9BA664")]
		public RDMonster(string inReference)
		{
		}
	}
}
