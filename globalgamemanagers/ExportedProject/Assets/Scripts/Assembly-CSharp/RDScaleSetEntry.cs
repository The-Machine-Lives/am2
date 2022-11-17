using Il2CppDummyDll;
using Uken.Library.ReferenceData;

[Token(Token = "0x2000202")]
public class RDScaleSetEntry : BaseEntityDocument
{
	[Token(Token = "0x4000B69")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x82601C", Offset = "0x82601C")]
	public int lowerBound;

	[Token(Token = "0x4000B6A")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x826054", Offset = "0x826054")]
	public int upperBound;

	[Token(Token = "0x4000B6B")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "EntityReference", RVA = "0x82608C", Offset = "0x82608C")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x82608C", Offset = "0x82608C")]
	public string overrideRewardGroup;

	[Token(Token = "0x4000B6C")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x8260EC", Offset = "0x8260EC")]
	public long scalar;

	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x9EC590", Offset = "0x9EC590", VA = "0x9EC590")]
	public RDScaleSetEntry()
	{
	}
}
