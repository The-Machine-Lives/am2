using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x2000164")]
public class InfoSpecialOfferEntryView : MonoBehaviour
{
	[Token(Token = "0x40008B2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Text m_itemName;

	[Token(Token = "0x40008B3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Text m_itemDescription;

	[Token(Token = "0x60009D0")]
	[Address(RVA = "0x98CF74", Offset = "0x98CF74", VA = "0x98CF74")]
	public void Initialize(Reward reward)
	{
	}

	[Token(Token = "0x60009D1")]
	[Address(RVA = "0x98D2C8", Offset = "0x98D2C8", VA = "0x98D2C8")]
	public InfoSpecialOfferEntryView()
	{
	}
}
