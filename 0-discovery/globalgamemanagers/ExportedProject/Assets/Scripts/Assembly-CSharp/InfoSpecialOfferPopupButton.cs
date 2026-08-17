using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x2000165")]
public class InfoSpecialOfferPopupButton : MonoBehaviour
{
	[Token(Token = "0x40008B4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Button m_button;

	[Token(Token = "0x40008B5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private InfoSpecialOfferPopupView m_infoSpecialOfferPopupViewTemplate;

	[Token(Token = "0x40008B6")]
	[FieldOffset(Offset = "0x28")]
	private CasualViewController m_parentController;

	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0x30")]
	private StoreItem m_storeItem;

	[Token(Token = "0x60009D2")]
	[Address(RVA = "0x986BFC", Offset = "0x986BFC", VA = "0x986BFC")]
	public void Initialize(CasualViewController parentController, StoreItem storeItem)
	{
	}

	[Token(Token = "0x60009D3")]
	[Address(RVA = "0x98D2D0", Offset = "0x98D2D0", VA = "0x98D2D0")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60009D4")]
	[Address(RVA = "0x98D380", Offset = "0x98D380", VA = "0x98D380")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x60009D5")]
	[Address(RVA = "0x98D430", Offset = "0x98D430", VA = "0x98D430")]
	public void OnButtonPress()
	{
	}

	[Token(Token = "0x60009D6")]
	[Address(RVA = "0x98D8AC", Offset = "0x98D8AC", VA = "0x98D8AC")]
	public InfoSpecialOfferPopupButton()
	{
	}
}
