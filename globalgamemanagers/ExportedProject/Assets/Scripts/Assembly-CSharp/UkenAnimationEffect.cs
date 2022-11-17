using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000B3")]
public class UkenAnimationEffect
{
	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82240C", Offset = "0x82240C")]
	private bool _003CisPlaying_003Ek__BackingField;

	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x18")]
	private AnimData animDataX;

	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x20")]
	private AnimData animDataY;

	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x28")]
	private float m_duration;

	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x2C")]
	private float m_startTime;

	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_initPosition;

	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x40")]
	private RectTransform m_rectTransform;

	[Token(Token = "0x170000CC")]
	public bool isPlaying
	{
		[Token(Token = "0x600045D")]
		[Address(RVA = "0xB48648", Offset = "0xB48648", VA = "0xB48648")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833E2C", Offset = "0x833E2C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600045E")]
		[Address(RVA = "0xB48650", Offset = "0xB48650", VA = "0xB48650")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833E3C", Offset = "0x833E3C")]
		private set
		{
		}
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0xB4865C", Offset = "0xB4865C", VA = "0xB4865C")]
	public UkenAnimationEffect(RectTransform rectTransform, Vector3 initPosition, AnimData inAnimDataX, AnimData inAnimDataY, float inDuration = 0.5f)
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0xB486D8", Offset = "0xB486D8", VA = "0xB486D8")]
	public void CalculateAnimation(out float deltaX, out float deltaY)
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0xB48760", Offset = "0xB48760", VA = "0xB48760")]
	public void TryFinishAnimation()
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0xB48834", Offset = "0xB48834", VA = "0xB48834")]
	public void InterruptAnimation()
	{
	}
}
