using Il2CppDummyDll;
using Uken.Library.ReferenceData;

[Token(Token = "0x20001B7")]
[Attribute(Name = "GroupAttribute", RVA = "0x81E8A8", Offset = "0x81E8A8")]
public class RDStatusEffectImmuneToBuff : BaseEntityDocument
{
	[Token(Token = "0x4000A56")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "EntityReference", RVA = "0x825A04", Offset = "0x825A04")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x825A04", Offset = "0x825A04")]
	public string buff;

	[Token(Token = "0x4000A57")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x825A64", Offset = "0x825A64")]
	public string cureMessage;

	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0x9EC5A0", Offset = "0x9EC5A0", VA = "0x9EC5A0")]
	public RDStatusEffectImmuneToBuff(string inReference)
	{
	}
}
