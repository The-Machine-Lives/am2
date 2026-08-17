using Il2CppDummyDll;

[Token(Token = "0x2000081")]
public class DeathActorEvent : FightActorEvent
{
	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x14")]
	public BISoundEvents.EventKey deathSoundEventOverride;

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x9C1550", Offset = "0x9C1550", VA = "0x9C1550")]
	public DeathActorEvent(BISoundEvents.EventKey inDeathSoundEventOverride)
	{
	}
}
