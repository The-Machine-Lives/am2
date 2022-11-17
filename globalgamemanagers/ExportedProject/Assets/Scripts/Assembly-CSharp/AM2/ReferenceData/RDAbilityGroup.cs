using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000322")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81ECA0", Offset = "0x81ECA0")]
	public class RDAbilityGroup : BaseEntityDocument
	{
		[Token(Token = "0x4000F9A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x827E54", Offset = "0x827E54")]
		[Attribute(Name = "EntityReference", RVA = "0x827E54", Offset = "0x827E54")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827E54", Offset = "0x827E54")]
		public List<string> abilities;

		[Token(Token = "0x4000F9B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827EC8", Offset = "0x827EC8")]
		public EAbilityBehavior abilityBehavior;

		[Token(Token = "0x4000F9C")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827F00", Offset = "0x827F00")]
		public int weight;

		[Token(Token = "0x6001977")]
		[Address(RVA = "0x9BA184", Offset = "0x9BA184", VA = "0x9BA184")]
		public RDAbilityGroup(string inReference)
		{
		}
	}
}
