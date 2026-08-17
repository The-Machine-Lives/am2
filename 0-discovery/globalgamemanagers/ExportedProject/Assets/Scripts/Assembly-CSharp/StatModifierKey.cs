using System;
using System.Runtime.CompilerServices;
using AM2.ReferenceData;
using Il2CppDummyDll;

[Token(Token = "0x20001BC")]
[IsReadOnly]
public struct StatModifierKey
{
	[Token(Token = "0x4000A65")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825CFC", Offset = "0x825CFC")]
	private readonly FightActorController.Stat _003Cstat_003Ek__BackingField;

	[Token(Token = "0x4000A66")]
	[FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825D0C", Offset = "0x825D0C")]
	private readonly Tag _003Ctype_003Ek__BackingField;

	[Token(Token = "0x1700016E")]
	public FightActorController.Stat stat
	{
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x89BB34", Offset = "0x89BB34", VA = "0x89BB34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83495C", Offset = "0x83495C")]
		get
		{
			return default(FightActorController.Stat);
		}
	}

	[Token(Token = "0x1700016F")]
	public Tag type
	{
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x89BB3C", Offset = "0x89BB3C", VA = "0x89BB3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83496C", Offset = "0x83496C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0x89BB44", Offset = "0x89BB44", VA = "0x89BB44")]
	public StatModifierKey(FightActorController.Stat statIn, Tag typeIn)
	{
	}

	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0xA08A5C", Offset = "0xA08A5C", VA = "0xA08A5C")]
	public static implicit operator StatModifierKey(ValueTuple<FightActorController.Stat, Tag> tupleKey)
	{
		return default(StatModifierKey);
	}
}
