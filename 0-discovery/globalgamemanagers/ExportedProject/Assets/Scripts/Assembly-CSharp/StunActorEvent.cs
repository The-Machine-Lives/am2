using Il2CppDummyDll;

[Token(Token = "0x2000082")]
public class StunActorEvent : FightActorEvent
{
	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821C18", Offset = "0x821C18")]
	private readonly float _003Cduration_003Ek__BackingField;

	[Token(Token = "0x17000041")]
	public float duration
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xA0D854", Offset = "0xA0D854", VA = "0xA0D854")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833A4C", Offset = "0x833A4C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xA0D85C", Offset = "0xA0D85C", VA = "0xA0D85C")]
	public StunActorEvent()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xA0D888", Offset = "0xA0D888", VA = "0xA0D888")]
	public StunActorEvent(float inDuration)
	{
	}
}
