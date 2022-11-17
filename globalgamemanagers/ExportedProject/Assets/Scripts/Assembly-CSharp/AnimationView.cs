using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Animation;
using UnityEngine;

[Token(Token = "0x20000AE")]
[Attribute(Name = "RequireComponent", RVA = "0x81E5E4", Offset = "0x81E5E4")]
public class AnimationView : MonoBehaviour
{
	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x18")]
	private List<UkenAnimationEffect> m_animationList;

	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 m_initPosition;

	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_initialized;

	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform m_rectTransform;

	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x38")]
	private UkenAnimBase m_currentAnimation;

	[Token(Token = "0x600043F")]
	[Address(RVA = "0xC1D0F8", Offset = "0xC1D0F8", VA = "0xC1D0F8")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0xC1D1C0", Offset = "0xC1D1C0", VA = "0xC1D1C0")]
	private void SetupPlay(bool isInterrupt = true)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0xC1D1F8", Offset = "0xC1D1F8", VA = "0xC1D1F8")]
	private void InterruptAnimations()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0xC1D358", Offset = "0xC1D358", VA = "0xC1D358")]
	public void PlayMoveToAndBack(Vector2 offset, float toDuration, float fromDuration)
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0xC1D578", Offset = "0xC1D578", VA = "0xC1D578")]
	public void PlayXPingPong(bool isInterrupt = true)
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0xC1D688", Offset = "0xC1D688", VA = "0xC1D688")]
	public void PlayYPingPong(bool isInterrupt = true)
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0xC1D798", Offset = "0xC1D798", VA = "0xC1D798")]
	public void PlayXYShake(bool isInterrupt = true, float moveAmount = 100f, float speed = 1500f, float duration = 0.5f)
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0xC1D8D4", Offset = "0xC1D8D4", VA = "0xC1D8D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0xC1D8D8", Offset = "0xC1D8D8", VA = "0xC1D8D8")]
	private void UpdateAnimations()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0xC1DBE0", Offset = "0xC1DBE0", VA = "0xC1DBE0")]
	public AnimationView()
	{
	}
}
