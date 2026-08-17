using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x20001BA")]
public class StatusEffectReflectDamage : RuntimeData<RDStatusEffectReflectDamage>, IStatusEffect, IReferenceable
{
	[Token(Token = "0x4000A5F")]
	[FieldOffset(Offset = "0x18")]
	private Formula m_levellableReflectChance;

	[Token(Token = "0x4000A60")]
	[FieldOffset(Offset = "0x20")]
	private Formula m_levellableDamageMultiplier;

	[Token(Token = "0x6000BF2")]
	[Address(RVA = "0xA08F34", Offset = "0xA08F34", VA = "0xA08F34")]
	public StatusEffectReflectDamage()
	{
	}

	[Token(Token = "0x6000BF3")]
	[Address(RVA = "0xA08F84", Offset = "0xA08F84", VA = "0xA08F84", Slot = "4")]
	public override void Initialize(RDStatusEffectReflectDamage referenceData)
	{
	}

	[Token(Token = "0x6000BF4")]
	[Address(RVA = "0xA09110", Offset = "0xA09110", VA = "0xA09110")]
	public float ReflectChance(long level)
	{
		return default(float);
	}

	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0xA09158", Offset = "0xA09158", VA = "0xA09158")]
	public double DamageMultiplier(long level)
	{
		return default(double);
	}

	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0xA09198", Offset = "0xA09198", VA = "0xA09198", Slot = "6")]
	private List<AbilityTraitDisplay> AM2_002EReferenceData_002EIStatusEffect_002EGetDetailedDisplayText(string buffName, long level, bool isSelf, bool isPassive)
	{
		return null;
	}

	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0xA09374", Offset = "0xA09374", VA = "0xA09374", Slot = "7")]
	private BISoundEvents.EventKey AM2_002EReferenceData_002EIStatusEffect_002EGetSoundEventKey(BuffActorEvent buffEvent)
	{
		return default(BISoundEvents.EventKey);
	}
}
