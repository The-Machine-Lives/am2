using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x2000088")]
public class PlayerActorController : FightActorController
{
	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x38")]
	private ZoneController m_zoneController;

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x99F5C0", Offset = "0x99F5C0", VA = "0x99F5C0")]
	public PlayerActorController(List<Ability> inAbilities, long health, long maxHealth)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x99F96C", Offset = "0x99F96C", VA = "0x99F96C", Slot = "6")]
	public override void DiffHealth(long diff, float multiplier, FightActorController sourceActorController, BISoundEvents.EventKey soundEventOverride, bool isReflectedDamage = false, bool interrupt = false)
	{
	}
}
