using Il2CppDummyDll;

[Token(Token = "0x2000127")]
public class ProductionVolumeMode
{
	[Token(Token = "0x400078D")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8248EC", Offset = "0x8248EC")]
	private string _003CdisplayText_003Ek__BackingField;

	[Token(Token = "0x400078E")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8248FC", Offset = "0x8248FC")]
	private long _003CvolumeMultiplier_003Ek__BackingField;

	[Token(Token = "0x400078F")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82490C", Offset = "0x82490C")]
	private bool _003CisMax_003Ek__BackingField;

	[Token(Token = "0x170000FF")]
	public string displayText
	{
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x9E2458", Offset = "0x9E2458", VA = "0x9E2458")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8343C8", Offset = "0x8343C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x9E2460", Offset = "0x9E2460", VA = "0x9E2460")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8343D8", Offset = "0x8343D8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000100")]
	public long volumeMultiplier
	{
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x9E2468", Offset = "0x9E2468", VA = "0x9E2468")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8343E8", Offset = "0x8343E8")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x9E2470", Offset = "0x9E2470", VA = "0x9E2470")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8343F8", Offset = "0x8343F8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000101")]
	public bool isMax
	{
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x9E2478", Offset = "0x9E2478", VA = "0x9E2478")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834408", Offset = "0x834408")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x9E2480", Offset = "0x9E2480", VA = "0x9E2480")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834418", Offset = "0x834418")]
		private set
		{
		}
	}

	[Token(Token = "0x600088D")]
	[Address(RVA = "0x9E248C", Offset = "0x9E248C", VA = "0x9E248C")]
	public ProductionVolumeMode()
	{
	}

	[Token(Token = "0x600088E")]
	[Address(RVA = "0x9E24E4", Offset = "0x9E24E4", VA = "0x9E24E4")]
	public ProductionVolumeMode(string inDisplayText, long inVolumeMultiplier, bool inIsMax)
	{
	}
}
