using Il2CppDummyDll;
using Uken.Library.ReferenceData;

[Token(Token = "0x20001BB")]
[Attribute(Name = "GroupAttribute", RVA = "0x81E918", Offset = "0x81E918")]
public class RDStatusEffectStatModifier : BaseEntityDocument
{
	[Token(Token = "0x4000A61")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x825BCC", Offset = "0x825BCC")]
	public FightActorController.Stat stat;

	[Token(Token = "0x4000A62")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "EntityReference", RVA = "0x825C04", Offset = "0x825C04")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x825C04", Offset = "0x825C04")]
	public string modifiedType;

	[Token(Token = "0x4000A63")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x825C64", Offset = "0x825C64")]
	public double modifier;

	[Token(Token = "0x4000A64")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "EntityReference", RVA = "0x825C9C", Offset = "0x825C9C")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x825C9C", Offset = "0x825C9C")]
	public string levellableModifier;

	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x9EC5B0", Offset = "0x9EC5B0", VA = "0x9EC5B0")]
	public RDStatusEffectStatModifier(string inReference)
	{
	}
}
