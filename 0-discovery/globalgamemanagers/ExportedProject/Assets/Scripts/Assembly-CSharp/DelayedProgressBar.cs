using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D4")]
public class DelayedProgressBar : ProgressBar
{
	[Token(Token = "0x4000AB2")]
	[FieldOffset(Offset = "0x40")]
	private bool m_isFollowing;

	[Token(Token = "0x4000AB3")]
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	private bool m_followUp;

	[Token(Token = "0x4000AB4")]
	[FieldOffset(Offset = "0x42")]
	[SerializeField]
	private bool m_followDown;

	[Token(Token = "0x4000AB5")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float m_followTimeInSeconds;

	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float m_followDelay;

	[Token(Token = "0x4000AB7")]
	[FieldOffset(Offset = "0x50")]
	private double m_followStartTime;

	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x58")]
	private float m_desiredFillAmount;

	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0x9C1580", Offset = "0x9C1580", VA = "0x9C1580", Slot = "4")]
	public override void Initialize(float fillAmount)
	{
	}

	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0x9C15B4", Offset = "0x9C15B4", VA = "0x9C15B4")]
	public void SetFillAmountDelayed(float fillAmount)
	{
	}

	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0x9C1608", Offset = "0x9C1608", VA = "0x9C1608")]
	private void Update()
	{
	}

	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x9C17A4", Offset = "0x9C17A4", VA = "0x9C17A4")]
	public DelayedProgressBar()
	{
	}
}
