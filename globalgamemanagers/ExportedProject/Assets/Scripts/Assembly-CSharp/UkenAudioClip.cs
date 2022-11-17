using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200020D")]
public class UkenAudioClip
{
	[Token(Token = "0x4000BA4")]
	[FieldOffset(Offset = "0x10")]
	public AudioSource source;

	[Token(Token = "0x4000BA5")]
	[FieldOffset(Offset = "0x18")]
	private float fadeInTime;

	[Token(Token = "0x4000BA6")]
	[FieldOffset(Offset = "0x1C")]
	private float fadeOutTime;

	[Token(Token = "0x4000BA7")]
	[FieldOffset(Offset = "0x20")]
	private float currentTime;

	[Token(Token = "0x4000BA8")]
	[FieldOffset(Offset = "0x24")]
	private bool bFadingOut;

	[Token(Token = "0x4000BA9")]
	[FieldOffset(Offset = "0x25")]
	private bool bFadingIn;

	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0xB492D0", Offset = "0xB492D0", VA = "0xB492D0")]
	public UkenAudioClip(AudioSource Source)
	{
	}

	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0xB492FC", Offset = "0xB492FC", VA = "0xB492FC")]
	public void FadeOut(float timeToFade)
	{
	}

	[Token(Token = "0x6000DED")]
	[Address(RVA = "0xB49310", Offset = "0xB49310", VA = "0xB49310")]
	public void FadeIn(float timeToFade)
	{
	}

	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0xB493D0", Offset = "0xB493D0", VA = "0xB493D0")]
	public bool IsComplete()
	{
		return default(bool);
	}

	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0xB4946C", Offset = "0xB4946C", VA = "0xB4946C")]
	public void Update()
	{
	}
}
