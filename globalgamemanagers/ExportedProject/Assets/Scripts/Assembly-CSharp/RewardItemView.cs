using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000090")]
public class RewardItemView : BasicItemView
{
	[Token(Token = "0x4000241")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image m_background;

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x9FBD88", Offset = "0x9FBD88", VA = "0x9FBD88")]
	public void ShowBackground(bool show)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x9FBE38", Offset = "0x9FBE38", VA = "0x9FBE38")]
	public void Initialize(bool localized, string title, long amountMin, long amountMax, bool showAmount)
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x9FBF58", Offset = "0x9FBF58", VA = "0x9FBF58")]
	public void Initialize(bool localized, string title, long amount, bool showAmount)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x9FBE8C", Offset = "0x9FBE8C", VA = "0x9FBE8C")]
	protected void InitializeRangedText(bool showAmount, long amountMin, long amountMax)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x9FBFA8", Offset = "0x9FBFA8", VA = "0x9FBFA8")]
	public RewardItemView()
	{
	}
}
