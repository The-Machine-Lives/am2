using Il2CppDummyDll;

[Token(Token = "0x2000084")]
public class BuffActorEvent : FightActorEvent
{
	[Token(Token = "0x40001F6")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821C58", Offset = "0x821C58")]
	private IBuffState _003CbuffState_003Ek__BackingField;

	[Token(Token = "0x40001F7")]
	[FieldOffset(Offset = "0x20")]
	public BISoundEvents.EventKey buffAppliedSoundEventOverride;

	[Token(Token = "0x17000045")]
	public IBuffState buffState
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0xA467C8", Offset = "0xA467C8", VA = "0xA467C8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833ABC", Offset = "0x833ABC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xA467D0", Offset = "0xA467D0", VA = "0xA467D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833ACC", Offset = "0x833ACC")]
		set
		{
		}
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xA467D8", Offset = "0xA467D8", VA = "0xA467D8")]
	public BuffActorEvent(IBuffState inBuffState, BISoundEvents.EventKey inBuffAppliedSoundEventOverride)
	{
	}
}
