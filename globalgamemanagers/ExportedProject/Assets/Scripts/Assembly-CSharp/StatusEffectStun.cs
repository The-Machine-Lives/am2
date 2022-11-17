using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x20001BF")]
public class StatusEffectStun : RuntimeData<RDStatusEffectStun>, IStatusEffect, IReferenceable
{
	[Token(Token = "0x6000C07")]
	[Address(RVA = "0xA09BB8", Offset = "0xA09BB8", VA = "0xA09BB8")]
	public StatusEffectStun()
	{
	}

	[Token(Token = "0x6000C08")]
	[Address(RVA = "0xA09C08", Offset = "0xA09C08", VA = "0xA09C08", Slot = "6")]
	private List<AbilityTraitDisplay> AM2_002EReferenceData_002EIStatusEffect_002EGetDetailedDisplayText(string buffName, long level, bool isSelf, bool isPassive)
	{
		return null;
	}

	[Token(Token = "0x6000C09")]
	[Address(RVA = "0xA09C6C", Offset = "0xA09C6C", VA = "0xA09C6C", Slot = "7")]
	private BISoundEvents.EventKey AM2_002EReferenceData_002EIStatusEffect_002EGetSoundEventKey(BuffActorEvent buffEvent)
	{
		return default(BISoundEvents.EventKey);
	}
}
