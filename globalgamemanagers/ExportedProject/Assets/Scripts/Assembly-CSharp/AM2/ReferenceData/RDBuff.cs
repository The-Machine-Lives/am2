using System.Collections.Generic;
using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000316")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EBF8", Offset = "0x81EBF8")]
	public class RDBuff : RDAbilityEffect
	{
		[Token(Token = "0x4000F3A")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x826B8C", Offset = "0x826B8C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826B8C", Offset = "0x826B8C")]
		public List<string> statusEffects;

		[Token(Token = "0x4000F3B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x826C58", Offset = "0x826C58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826C58", Offset = "0x826C58")]
		public string icon;

		[Token(Token = "0x4000F3C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826CA8", Offset = "0x826CA8")]
		public float iconColorR;

		[Token(Token = "0x4000F3D")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826CE0", Offset = "0x826CE0")]
		public float iconColorG;

		[Token(Token = "0x4000F3E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826D18", Offset = "0x826D18")]
		public float iconColorB;

		[Token(Token = "0x4000F3F")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826D50", Offset = "0x826D50")]
		public float durationInSeconds;

		[Token(Token = "0x4000F40")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826D88", Offset = "0x826D88")]
		public int durationInSceneCount;

		[Token(Token = "0x4000F41")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826DC0", Offset = "0x826DC0")]
		public int maxStacks;

		[Token(Token = "0x4000F42")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826DF8", Offset = "0x826DF8")]
		public int stacksToApply;

		[Token(Token = "0x4000F43")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "EntityReference", RVA = "0x826E30", Offset = "0x826E30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826E30", Offset = "0x826E30")]
		public string levellableDurationInSeconds;

		[Token(Token = "0x4000F44")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "EntityReference", RVA = "0x826E90", Offset = "0x826E90")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826E90", Offset = "0x826E90")]
		public string levellableMaxStacks;

		[Token(Token = "0x4000F45")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "EntityReference", RVA = "0x826EF0", Offset = "0x826EF0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826EF0", Offset = "0x826EF0")]
		public string levellableStacksToApply;

		[Token(Token = "0x4000F46")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826F50", Offset = "0x826F50")]
		public string readableName;

		[Token(Token = "0x4000F47")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "EntityReference", RVA = "0x826F88", Offset = "0x826F88")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826F88", Offset = "0x826F88")]
		public string overtimeAbility;

		[Token(Token = "0x4000F48")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826FE8", Offset = "0x826FE8")]
		public float overtimeAbilityTickInterval;

		[Token(Token = "0x4000F49")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "EntityReference", RVA = "0x827020", Offset = "0x827020")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827020", Offset = "0x827020")]
		public string buffEndAbility;

		[Token(Token = "0x4000F4A")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827080", Offset = "0x827080")]
		public bool shouldShowBuffIcon;

		[Token(Token = "0x4000F4B")]
		[FieldOffset(Offset = "0xB4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8270B8", Offset = "0x8270B8")]
		public BISoundEvents.EventKey buffAppliedSoundEventOverride;

		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x9BA1B4", Offset = "0x9BA1B4", VA = "0x9BA1B4")]
		public RDBuff(string inReference)
		{
		}
	}
}
