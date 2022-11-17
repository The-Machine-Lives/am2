using System.Text.RegularExpressions;
using Il2CppDummyDll;

[Token(Token = "0x2000218")]
public struct ItemLimit
{
	[Token(Token = "0x4000BF3")]
	private const float c_itemWarningLimitMultiplier = 0.75f;

	[Token(Token = "0x4000BF4")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826454", Offset = "0x826454")]
	private readonly Regex _003Cregex_003Ek__BackingField;

	[Token(Token = "0x4000BF5")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826464", Offset = "0x826464")]
	private readonly string _003CreadableNamePrefix_003Ek__BackingField;

	[Token(Token = "0x4000BF6")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826474", Offset = "0x826474")]
	private readonly string _003CreadableNameSuffix_003Ek__BackingField;

	[Token(Token = "0x4000BF7")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826484", Offset = "0x826484")]
	private readonly int _003CitemLimit_003Ek__BackingField;

	[Token(Token = "0x4000BF8")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826494", Offset = "0x826494")]
	private int _003CitemCount_003Ek__BackingField;

	[Token(Token = "0x4000BF9")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8264A4", Offset = "0x8264A4")]
	private bool _003CprintOnAdd_003Ek__BackingField;

	[Token(Token = "0x4000BFA")]
	[FieldOffset(Offset = "0x24")]
	private float m_itemWarningLimitMultiplier;

	[Token(Token = "0x170001D5")]
	public Regex regex
	{
		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x89B9B4", Offset = "0x89B9B4", VA = "0x89B9B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835284", Offset = "0x835284")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001D6")]
	public string readableNamePrefix
	{
		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x89B9BC", Offset = "0x89B9BC", VA = "0x89B9BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835294", Offset = "0x835294")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001D7")]
	public string readableNameSuffix
	{
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x89B9C4", Offset = "0x89B9C4", VA = "0x89B9C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8352A4", Offset = "0x8352A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001D8")]
	public int itemLimit
	{
		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x89B9CC", Offset = "0x89B9CC", VA = "0x89B9CC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8352B4", Offset = "0x8352B4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170001D9")]
	public int itemCount
	{
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x89B9D4", Offset = "0x89B9D4", VA = "0x89B9D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8352C4", Offset = "0x8352C4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x89B9DC", Offset = "0x89B9DC", VA = "0x89B9DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8352D4", Offset = "0x8352D4")]
		set
		{
		}
	}

	[Token(Token = "0x170001DA")]
	public bool printOnAdd
	{
		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x89B9E4", Offset = "0x89B9E4", VA = "0x89B9E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8352E4", Offset = "0x8352E4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x89B9EC", Offset = "0x89B9EC", VA = "0x89B9EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8352F4", Offset = "0x8352F4")]
		set
		{
		}
	}

	[Token(Token = "0x6000E5B")]
	[Address(RVA = "0x89B9F8", Offset = "0x89B9F8", VA = "0x89B9F8")]
	public ItemLimit(string inRegex, string inReadableNamePrefix, string inReadableNameSuffix, int inItemLimit, bool inPrintOnAdd = false, float itemWarningLimitMultiplier = 0.75f)
	{
	}

	[Token(Token = "0x6000E5C")]
	[Address(RVA = "0x89BA04", Offset = "0x89BA04", VA = "0x89BA04")]
	public void IncrementItemCount()
	{
	}

	[Token(Token = "0x6000E5D")]
	[Address(RVA = "0x89BA14", Offset = "0x89BA14", VA = "0x89BA14")]
	public void ResetItemCount()
	{
	}

	[Token(Token = "0x6000E5E")]
	[Address(RVA = "0x89BA1C", Offset = "0x89BA1C", VA = "0x89BA1C")]
	public bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E5F")]
	[Address(RVA = "0x89BA3C", Offset = "0x89BA3C", VA = "0x89BA3C")]
	public string ReadableName()
	{
		return null;
	}
}
