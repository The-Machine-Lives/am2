using Il2CppDummyDll;

[Token(Token = "0x2000085")]
public class CureActorEvent : FightActorEvent
{
	[Token(Token = "0x40001F8")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821C68", Offset = "0x821C68")]
	private IBuffState _003CbuffState_003Ek__BackingField;

	[Token(Token = "0x17000046")]
	public IBuffState buffState
	{
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x9C14E0", Offset = "0x9C14E0", VA = "0x9C14E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833ADC", Offset = "0x833ADC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x9C14E8", Offset = "0x9C14E8", VA = "0x9C14E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833AEC", Offset = "0x833AEC")]
		set
		{
		}
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x9C14F0", Offset = "0x9C14F0", VA = "0x9C14F0")]
	public CureActorEvent(IBuffState inBuffState)
	{
	}
}
