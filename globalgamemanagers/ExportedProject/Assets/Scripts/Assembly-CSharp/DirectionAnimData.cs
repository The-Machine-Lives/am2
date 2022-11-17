using Il2CppDummyDll;

[Token(Token = "0x20000B0")]
public class DirectionAnimData : AnimData
{
	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8223AC", Offset = "0x8223AC")]
	private bool _003CisCenter_003Ek__BackingField;

	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x1D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8223BC", Offset = "0x8223BC")]
	private bool _003CisReverse_003Ek__BackingField;

	[Token(Token = "0x170000CA")]
	public bool isCenter
	{
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x9C1C94", Offset = "0x9C1C94", VA = "0x9C1C94")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833DEC", Offset = "0x833DEC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x9C1C9C", Offset = "0x9C1C9C", VA = "0x9C1C9C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833DFC", Offset = "0x833DFC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000CB")]
	public bool isReverse
	{
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x9C1CA8", Offset = "0x9C1CA8", VA = "0x9C1CA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833E0C", Offset = "0x833E0C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x9C1CB0", Offset = "0x9C1CB0", VA = "0x9C1CB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833E1C", Offset = "0x833E1C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x9C1CBC", Offset = "0x9C1CBC", VA = "0x9C1CBC")]
	public DirectionAnimData(float inSpeed = 1500f, float inInitDistance = 100f, float inDistance = 100f, bool inIsCenter = true, bool inIsReverse = false)
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x9C1D08", Offset = "0x9C1D08", VA = "0x9C1D08", Slot = "4")]
	public override float CalculateData(AnimData animData)
	{
		return default(float);
	}
}
