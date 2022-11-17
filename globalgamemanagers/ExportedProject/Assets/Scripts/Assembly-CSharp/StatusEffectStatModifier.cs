using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x20001BD")]
public class StatusEffectStatModifier : RuntimeData<RDStatusEffectStatModifier>, IStatusEffect, IReferenceable
{
	[Token(Token = "0x4000A67")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x825D1C", Offset = "0x825D1C")]
	private Tag _003Cm_type_003Ek__BackingField;

	[Token(Token = "0x4000A68")]
	[FieldOffset(Offset = "0x20")]
	private Formula m_levellableModifier;

	[Token(Token = "0x17000170")]
	public FightActorController.Stat stat
	{
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0xA0937C", Offset = "0xA0937C", VA = "0xA0937C")]
		get
		{
			return default(FightActorController.Stat);
		}
	}

	[Token(Token = "0x17000171")]
	public Tag m_type
	{
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0xA093A8", Offset = "0xA093A8", VA = "0xA093A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83497C", Offset = "0x83497C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0xA093B0", Offset = "0xA093B0", VA = "0xA093B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83498C", Offset = "0x83498C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000C00")]
	[Address(RVA = "0xA093B8", Offset = "0xA093B8", VA = "0xA093B8")]
	public StatusEffectStatModifier()
	{
	}

	[Token(Token = "0x6000C01")]
	[Address(RVA = "0xA09408", Offset = "0xA09408", VA = "0xA09408", Slot = "4")]
	public override void Initialize(RDStatusEffectStatModifier referenceData)
	{
	}

	[Token(Token = "0x6000C02")]
	[Address(RVA = "0xA0962C", Offset = "0xA0962C", VA = "0xA0962C")]
	public double Modifier(long level)
	{
		return default(double);
	}

	[Token(Token = "0x6000C03")]
	[Address(RVA = "0xA0966C", Offset = "0xA0966C", VA = "0xA0966C", Slot = "6")]
	private List<AbilityTraitDisplay> AM2_002EReferenceData_002EIStatusEffect_002EGetDetailedDisplayText(string buffName, long level, bool isSelf, bool isPassive)
	{
		return null;
	}

	[Token(Token = "0x6000C04")]
	[Address(RVA = "0xA09A64", Offset = "0xA09A64", VA = "0xA09A64", Slot = "7")]
	private BISoundEvents.EventKey AM2_002EReferenceData_002EIStatusEffect_002EGetSoundEventKey(BuffActorEvent buffEvent)
	{
		return default(BISoundEvents.EventKey);
	}

	[Token(Token = "0x6000C05")]
	[Address(RVA = "0xA09720", Offset = "0xA09720", VA = "0xA09720")]
	private AbilityTraitDisplay GetStatModifierDisplayText(string parentBuffName, long level)
	{
		return null;
	}
}
