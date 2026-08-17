using System.Collections.Generic;
using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000361")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F1A8", Offset = "0x81F1A8")]
	public class RDRecipe : RDResearchable
	{
		[Token(Token = "0x400107A")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A3A8", Offset = "0x82A3A8")]
		public string readableName;

		[Token(Token = "0x400107B")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "EntityReference", RVA = "0x82A3E0", Offset = "0x82A3E0")]
		public List<string> regents;

		[Token(Token = "0x400107C")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A418", Offset = "0x82A418")]
		public sbyte displayPriority;

		[Token(Token = "0x400107D")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82A450", Offset = "0x82A450")]
		[Attribute(Name = "EntityReference", RVA = "0x82A450", Offset = "0x82A450")]
		public string subTab;

		[Token(Token = "0x400107E")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82A4A0", Offset = "0x82A4A0")]
		[Attribute(Name = "EntityReference", RVA = "0x82A4A0", Offset = "0x82A4A0")]
		public string maxCapacity;

		[Token(Token = "0x400107F")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82A4F0", Offset = "0x82A4F0")]
		[Attribute(Name = "EntityReference", RVA = "0x82A4F0", Offset = "0x82A4F0")]
		public string cyclesPerSecond;

		[Token(Token = "0x4001080")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82A540", Offset = "0x82A540")]
		[Attribute(Name = "EntityReference", RVA = "0x82A540", Offset = "0x82A540")]
		public string volume;

		[Token(Token = "0x4001081")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "EntityReference", RVA = "0x82A590", Offset = "0x82A590")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A590", Offset = "0x82A590")]
		public string sustainTime;

		[Token(Token = "0x4001082")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A5F0", Offset = "0x82A5F0")]
		public long fullAutoSustainTimeLevel;

		[Token(Token = "0x4001083")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "EntityReference", RVA = "0x82A628", Offset = "0x82A628")]
		public string bonusMaxCapacity;

		[Token(Token = "0x4001084")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "EntityReference", RVA = "0x82A660", Offset = "0x82A660")]
		public string bonusCyclesPerSecond;

		[Token(Token = "0x4001085")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "EntityReference", RVA = "0x82A698", Offset = "0x82A698")]
		public string bonusVolume;

		[Token(Token = "0x4001086")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A6D0", Offset = "0x82A6D0")]
		public string category;

		[Token(Token = "0x4001087")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A708", Offset = "0x82A708")]
		public string bonusCategory;

		[Token(Token = "0x4001088")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A740", Offset = "0x82A740")]
		public BISoundEvents.EventKey jobStartSoundEventOverride;

		[Token(Token = "0x4001089")]
		[FieldOffset(Offset = "0xFC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A778", Offset = "0x82A778")]
		public BISoundEvents.EventKey jobSustainSoundEventOverride;

		[Token(Token = "0x400108A")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A7B0", Offset = "0x82A7B0")]
		public int dustOutputAmount;

		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0x9BA970", Offset = "0x9BA970", VA = "0x9BA970")]
		public RDRecipe(string _ref)
		{
		}
	}
}
