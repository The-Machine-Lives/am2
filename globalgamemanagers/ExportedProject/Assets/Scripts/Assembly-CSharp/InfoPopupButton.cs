using System;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x2000161")]
public class InfoPopupButton : MonoBehaviour
{
	[Token(Token = "0x4000890")]
	[FieldOffset(Offset = "0x0")]
	private static InfoPopupView m_activeInfoPopupView;

	[Token(Token = "0x4000891")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Button m_button;

	[Token(Token = "0x4000892")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_infoPopupViewTemplate;

	[Token(Token = "0x4000893")]
	[FieldOffset(Offset = "0x28")]
	private CasualViewController m_parentController;

	[Token(Token = "0x4000894")]
	[FieldOffset(Offset = "0x30")]
	private IInfoText m_infoText;

	[Token(Token = "0x4000895")]
	[FieldOffset(Offset = "0x38")]
	private bool m_isResearch;

	[Token(Token = "0x4000896")]
	[FieldOffset(Offset = "0x40")]
	private string m_name;

	[Token(Token = "0x4000897")]
	[FieldOffset(Offset = "0x48")]
	private string m_description;

	[Token(Token = "0x4000898")]
	[FieldOffset(Offset = "0x50")]
	private Func<ValueTuple<string, string>> m_generatePopupContents;

	[Token(Token = "0x60009B2")]
	[Address(RVA = "0x98AD58", Offset = "0x98AD58", VA = "0x98AD58")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60009B3")]
	[Address(RVA = "0x98AE08", Offset = "0x98AE08", VA = "0x98AE08")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x60009B4")]
	[Address(RVA = "0x98AEB8", Offset = "0x98AEB8", VA = "0x98AEB8")]
	public void Initialize(CasualViewController parentController, Func<ValueTuple<string, string>> generatePopupContents, string defaultName = "", string defaultDescription = "")
	{
	}

	[Token(Token = "0x60009B5")]
	[Address(RVA = "0x98AF20", Offset = "0x98AF20", VA = "0x98AF20")]
	public void Initialize(CasualViewController parentController, string name, string description)
	{
	}

	[Token(Token = "0x60009B6")]
	[Address(RVA = "0x98AF7C", Offset = "0x98AF7C", VA = "0x98AF7C")]
	public void Initialize(CasualViewController parentController, ItemMinimalDetails itemMinimalDetails)
	{
	}

	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x98AFFC", Offset = "0x98AFFC", VA = "0x98AFFC")]
	public void Initialize(CasualViewController parentController, IInfoText infoText, bool isResearch = false)
	{
	}

	[Token(Token = "0x60009B8")]
	[Address(RVA = "0x98B108", Offset = "0x98B108", VA = "0x98B108")]
	public void OnButtonPress()
	{
	}

	[Token(Token = "0x60009B9")]
	[Address(RVA = "0x98B354", Offset = "0x98B354", VA = "0x98B354")]
	private void GeneratePopupContents()
	{
	}

	[Token(Token = "0x60009BA")]
	[Address(RVA = "0x98B930", Offset = "0x98B930", VA = "0x98B930")]
	public InfoPopupButton()
	{
	}
}
