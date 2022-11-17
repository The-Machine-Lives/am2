using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200020E")]
public class UkenAudioLoop
{
	[Token(Token = "0x4000BAA")]
	[FieldOffset(Offset = "0x10")]
	private AudioSource m_source;

	[Token(Token = "0x4000BAB")]
	[FieldOffset(Offset = "0x18")]
	private float m_originalMaxVolume;

	[Token(Token = "0x4000BAC")]
	[FieldOffset(Offset = "0x1C")]
	private float m_fadeInTime;

	[Token(Token = "0x4000BAD")]
	[FieldOffset(Offset = "0x20")]
	private float m_fadeOutTime;

	[Token(Token = "0x4000BAE")]
	[FieldOffset(Offset = "0x24")]
	private bool m_fadingOut;

	[Token(Token = "0x4000BAF")]
	[FieldOffset(Offset = "0x25")]
	private bool m_fadingIn;

	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0xB4964C", Offset = "0xB4964C", VA = "0xB4964C")]
	public UkenAudioLoop(AudioSource source, float fadeInTime = 0.1f, float fadeOutTime = 0.1f)
	{
	}

	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0xB496C4", Offset = "0xB496C4", VA = "0xB496C4")]
	public void SetVolume(float volume)
	{
	}

	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0xB49768", Offset = "0xB49768", VA = "0xB49768")]
	public void FadeIn()
	{
	}

	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0xB49774", Offset = "0xB49774", VA = "0xB49774")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0xB49780", Offset = "0xB49780", VA = "0xB49780")]
	public void StopFading()
	{
	}

	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0xB49788", Offset = "0xB49788", VA = "0xB49788")]
	public void Update()
	{
	}
}
