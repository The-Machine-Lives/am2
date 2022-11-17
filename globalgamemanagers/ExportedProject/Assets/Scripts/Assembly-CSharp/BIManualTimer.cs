using System;
using Il2CppDummyDll;

[Token(Token = "0x2000148")]
public class BIManualTimer
{
	[Token(Token = "0x400081C")]
	[FieldOffset(Offset = "0x10")]
	private float m_fTimeUntilFire;

	[Token(Token = "0x400081D")]
	[FieldOffset(Offset = "0x18")]
	private Action m_onTimeComplete;

	[Token(Token = "0x6000928")]
	[Address(RVA = "0xA40FEC", Offset = "0xA40FEC", VA = "0xA40FEC")]
	public BIManualTimer(float delay, Action onTimeComplete)
	{
	}

	[Token(Token = "0x6000929")]
	[Address(RVA = "0xA41030", Offset = "0xA41030", VA = "0xA41030")]
	public void Fire()
	{
	}

	[Token(Token = "0x600092A")]
	[Address(RVA = "0xA41050", Offset = "0xA41050", VA = "0xA41050")]
	public bool Update(float dt)
	{
		return default(bool);
	}
}
