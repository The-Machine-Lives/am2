using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x20001B8")]
public class StatusEffectImmuneToBuff : RuntimeData<RDStatusEffectImmuneToBuff>, IStatusEffect, IReferenceable
{
	[Token(Token = "0x4000A58")]
	[FieldOffset(Offset = "0x18")]
	private string buffName;

	[Token(Token = "0x4000A59")]
	[FieldOffset(Offset = "0x20")]
	private Localizations m_localizationsController;

	[Token(Token = "0x4000A5A")]
	[FieldOffset(Offset = "0x28")]
	private SharedDataCacheController m_sharedDataCacheController;

	[Token(Token = "0x1700016B")]
	public string buffReference
	{
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0xA08A64", Offset = "0xA08A64", VA = "0xA08A64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700016C")]
	public string cureMessage
	{
		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0xA08A90", Offset = "0xA08A90", VA = "0xA08A90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700016D")]
	public bool immuneToAll
	{
		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0xA08ABC", Offset = "0xA08ABC", VA = "0xA08ABC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000BED")]
	[Address(RVA = "0xA08AEC", Offset = "0xA08AEC", VA = "0xA08AEC")]
	public StatusEffectImmuneToBuff()
	{
	}

	[Token(Token = "0x6000BEE")]
	[Address(RVA = "0xA08B3C", Offset = "0xA08B3C", VA = "0xA08B3C", Slot = "4")]
	public override void Initialize(RDStatusEffectImmuneToBuff referenceData)
	{
	}

	[Token(Token = "0x6000BEF")]
	[Address(RVA = "0xA08CBC", Offset = "0xA08CBC", VA = "0xA08CBC", Slot = "6")]
	private List<AbilityTraitDisplay> AM2_002EReferenceData_002EIStatusEffect_002EGetDetailedDisplayText(string buffName, long level, bool isSelf, bool isPassive)
	{
		return null;
	}

	[Token(Token = "0x6000BF0")]
	[Address(RVA = "0xA08F2C", Offset = "0xA08F2C", VA = "0xA08F2C", Slot = "7")]
	private BISoundEvents.EventKey AM2_002EReferenceData_002EIStatusEffect_002EGetSoundEventKey(BuffActorEvent buffEvent)
	{
		return default(BISoundEvents.EventKey);
	}
}
