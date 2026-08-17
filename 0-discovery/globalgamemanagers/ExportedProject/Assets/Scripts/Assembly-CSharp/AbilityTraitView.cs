using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000198")]
public class AbilityTraitView : MonoBehaviour
{
	[Token(Token = "0x40009AB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Text m_nameText;

	[Token(Token = "0x40009AC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Text m_amountText;

	[Token(Token = "0x40009AD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AM2Text m_nextAmountText;

	[Token(Token = "0x1700015D")]
	public AM2Text amountText
	{
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0xACC588", Offset = "0xACC588", VA = "0xACC588")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000B0F")]
	[Address(RVA = "0xACC590", Offset = "0xACC590", VA = "0xACC590")]
	public void Initialize(string title, string amount, string nextAmount, bool localizedTitle)
	{
	}

	[Token(Token = "0x6000B10")]
	[Address(RVA = "0xACC658", Offset = "0xACC658", VA = "0xACC658")]
	public AbilityTraitView()
	{
	}
}
