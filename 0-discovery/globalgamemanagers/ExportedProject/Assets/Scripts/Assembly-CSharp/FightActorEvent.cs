using Il2CppDummyDll;

[Token(Token = "0x2000080")]
public class FightActorEvent
{
	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821C08", Offset = "0x821C08")]
	private EFightActorEvent _003CeventType_003Ek__BackingField;

	[Token(Token = "0x17000040")]
	public EFightActorEvent eventType
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x9CEE74", Offset = "0x9CEE74", VA = "0x9CEE74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833A2C", Offset = "0x833A2C")]
		get
		{
			return default(EFightActorEvent);
		}
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x9CEE7C", Offset = "0x9CEE7C", VA = "0x9CEE7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833A3C", Offset = "0x833A3C")]
		protected set
		{
		}
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x9CEE84", Offset = "0x9CEE84", VA = "0x9CEE84")]
	public FightActorEvent()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x9C1524", Offset = "0x9C1524", VA = "0x9C1524")]
	public FightActorEvent(EFightActorEvent inEventType)
	{
	}
}
