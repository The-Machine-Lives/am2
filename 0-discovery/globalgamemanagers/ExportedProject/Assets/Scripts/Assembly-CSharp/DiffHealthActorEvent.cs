using Il2CppDummyDll;

[Token(Token = "0x2000083")]
public class DiffHealthActorEvent : FightActorEvent
{
	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821C28", Offset = "0x821C28")]
	private long _003ChealthDiff_003Ek__BackingField;

	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821C38", Offset = "0x821C38")]
	private float _003Cmultiplier_003Ek__BackingField;

	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821C48", Offset = "0x821C48")]
	private long _003CnewHealthQuantity_003Ek__BackingField;

	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x30")]
	public BISoundEvents.EventKey dealDamageSoundEventOverride;

	[Token(Token = "0x17000042")]
	public long healthDiff
	{
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x9C1C0C", Offset = "0x9C1C0C", VA = "0x9C1C0C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833A5C", Offset = "0x833A5C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x9C1C14", Offset = "0x9C1C14", VA = "0x9C1C14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833A6C", Offset = "0x833A6C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public float multiplier
	{
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x9C1C1C", Offset = "0x9C1C1C", VA = "0x9C1C1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833A7C", Offset = "0x833A7C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x9C1C24", Offset = "0x9C1C24", VA = "0x9C1C24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833A8C", Offset = "0x833A8C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000044")]
	public long newHealthQuantity
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x9C1C2C", Offset = "0x9C1C2C", VA = "0x9C1C2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833A9C", Offset = "0x833A9C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x9C1C34", Offset = "0x9C1C34", VA = "0x9C1C34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833AAC", Offset = "0x833AAC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x9C1C3C", Offset = "0x9C1C3C", VA = "0x9C1C3C")]
	public DiffHealthActorEvent(long inHealthDiff, float inMultiplier, long inNewHealthQuantity, BISoundEvents.EventKey inDealDamageSoundEventOverride)
	{
	}
}
