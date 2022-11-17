using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000074")]
public class ContextualTextView : MonoBehaviour
{
	[Token(Token = "0x40001AA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Color m_interruptTextColor;

	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected Color m_ineffectiveTextColor;

	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected float m_interruptAnimationDuration;

	[Token(Token = "0x40001AD")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	protected float m_missAnimationDuration;

	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected float m_scaleInDuration;

	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	protected Vector3 m_peakScale;

	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected AM2Text m_contextualText;

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x9BFF60", Offset = "0x9BFF60", VA = "0x9BFF60", Slot = "4")]
	public virtual void AnimateInterrupt()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x9C0228", Offset = "0x9C0228", VA = "0x9C0228", Slot = "5")]
	public virtual void AnimateStunned(float duration)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x9C02E4", Offset = "0x9C02E4", VA = "0x9C02E4", Slot = "6")]
	public virtual void AnimateIneffective()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x9C0340", Offset = "0x9C0340", VA = "0x9C0340", Slot = "7")]
	public virtual void AnimateMiss()
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x9C039C", Offset = "0x9C039C", VA = "0x9C039C", Slot = "8")]
	public virtual void AnimateDodge()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x9C03F8", Offset = "0x9C03F8", VA = "0x9C03F8", Slot = "9")]
	public virtual void AnimateCured(string cureMessage)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x9BFFBC", Offset = "0x9BFFBC", VA = "0x9BFFBC")]
	public void AnimateContextualText(Color color, string message, float duration)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x9C0408", Offset = "0x9C0408", VA = "0x9C0408", Slot = "10")]
	protected virtual void OnContextualTextAnimationComplete()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x9C0454", Offset = "0x9C0454", VA = "0x9C0454")]
	public ContextualTextView()
	{
	}
}
