using System.Runtime.CompilerServices;
using Il2CppDummyDll;

[Token(Token = "0x200015F")]
[IsReadOnly]
public struct VIPStatusState
{
	[Token(Token = "0x400088B")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x824FD4", Offset = "0x824FD4")]
	private readonly bool _003CisActive_003Ek__BackingField;

	[Token(Token = "0x17000112")]
	public bool isActive
	{
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x89BF80", Offset = "0x89BF80", VA = "0x89BF80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8345C0", Offset = "0x8345C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60009AB")]
	[Address(RVA = "0x89BF88", Offset = "0x89BF88", VA = "0x89BF88")]
	public VIPStatusState(bool isActiveIn)
	{
	}

	[Token(Token = "0x60009AC")]
	[Address(RVA = "0xAB81D8", Offset = "0xAB81D8", VA = "0xAB81D8")]
	public static implicit operator VIPStatusState(bool isActive)
	{
		return default(VIPStatusState);
	}
}
