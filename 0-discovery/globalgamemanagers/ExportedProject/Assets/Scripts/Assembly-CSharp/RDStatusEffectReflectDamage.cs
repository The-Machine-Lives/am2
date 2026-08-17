using Il2CppDummyDll;
using Uken.Library.ReferenceData;

[Token(Token = "0x20001B9")]
[Attribute(Name = "GroupAttribute", RVA = "0x81E8E0", Offset = "0x81E8E0")]
public class RDStatusEffectReflectDamage : BaseEntityDocument
{
	[Token(Token = "0x4000A5B")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x825A9C", Offset = "0x825A9C")]
	public float reflectChance;

	[Token(Token = "0x4000A5C")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x825AD4", Offset = "0x825AD4")]
	public double damageMultiplier;

	[Token(Token = "0x4000A5D")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "EntityReference", RVA = "0x825B0C", Offset = "0x825B0C")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x825B0C", Offset = "0x825B0C")]
	public string levellableReflectChance;

	[Token(Token = "0x4000A5E")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "EntityReference", RVA = "0x825B6C", Offset = "0x825B6C")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x825B6C", Offset = "0x825B6C")]
	public string levellableDamageMultiplier;

	[Token(Token = "0x6000BF1")]
	[Address(RVA = "0x9EC5A8", Offset = "0x9EC5A8", VA = "0x9EC5A8")]
	public RDStatusEffectReflectDamage(string inReference)
	{
	}
}
