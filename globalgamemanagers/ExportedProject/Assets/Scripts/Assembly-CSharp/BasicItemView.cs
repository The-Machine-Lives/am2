using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000C4")]
public class BasicItemView : MonoBehaviour
{
	[Token(Token = "0x4000333")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected AM2Text m_titleText;

	[Token(Token = "0x4000334")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected AM2Text m_nameTitleText;

	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected AM2Text m_text;

	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected AM2Text m_costTitleText;

	[Token(Token = "0x4000337")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected AM2Text m_amountText;

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0xA45DFC", Offset = "0xA45DFC", VA = "0xA45DFC")]
	public void InitializeText(string text, bool localized)
	{
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0xA45F94", Offset = "0xA45F94", VA = "0xA45F94")]
	public void SetTextAlpha(float alpha)
	{
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0xA46024", Offset = "0xA46024", VA = "0xA46024")]
	public void InitializeTitleText(string text)
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0xA460E4", Offset = "0xA460E4", VA = "0xA460E4")]
	public void InitializeAmountText(string text)
	{
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0xA461A4", Offset = "0xA461A4", VA = "0xA461A4")]
	public BasicItemView()
	{
	}
}
