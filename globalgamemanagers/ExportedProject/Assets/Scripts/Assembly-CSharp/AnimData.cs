using Il2CppDummyDll;

[Token(Token = "0x20000AF")]
public class AnimData
{
	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82237C", Offset = "0x82237C")]
	private float _003Cspeed_003Ek__BackingField;

	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82238C", Offset = "0x82238C")]
	private float _003CinitDistane_003Ek__BackingField;

	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82239C", Offset = "0x82239C")]
	private float _003Cdistane_003Ek__BackingField;

	[Token(Token = "0x170000C7")]
	public float speed
	{
		[Token(Token = "0x6000449")]
		[Address(RVA = "0xC1CFB8", Offset = "0xC1CFB8", VA = "0xC1CFB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833D8C", Offset = "0x833D8C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600044A")]
		[Address(RVA = "0xC1CFC0", Offset = "0xC1CFC0", VA = "0xC1CFC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833D9C", Offset = "0x833D9C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000C8")]
	public float initDistane
	{
		[Token(Token = "0x600044B")]
		[Address(RVA = "0xC1CFC8", Offset = "0xC1CFC8", VA = "0xC1CFC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833DAC", Offset = "0x833DAC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600044C")]
		[Address(RVA = "0xC1CFD0", Offset = "0xC1CFD0", VA = "0xC1CFD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833DBC", Offset = "0x833DBC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000C9")]
	public float distane
	{
		[Token(Token = "0x600044D")]
		[Address(RVA = "0xC1CFD8", Offset = "0xC1CFD8", VA = "0xC1CFD8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833DCC", Offset = "0x833DCC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600044E")]
		[Address(RVA = "0xC1CFE0", Offset = "0xC1CFE0", VA = "0xC1CFE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833DDC", Offset = "0x833DDC")]
		protected set
		{
		}
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0xC1CFE8", Offset = "0xC1CFE8", VA = "0xC1CFE8")]
	public AnimData(float inSpeed = 1500f, float inInitDistance = 100f, float inDistance = 100f)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0xC1D048", Offset = "0xC1D048", VA = "0xC1D048", Slot = "4")]
	public virtual float CalculateData(AnimData animData)
	{
		return default(float);
	}
}
