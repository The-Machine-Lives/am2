using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x200012A")]
public class ZoneItemView : MonoBehaviour
{
	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Text m_text;

	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_redDotNotification;

	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CostItemView m_costView;

	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AM2Button m_button;

	[Token(Token = "0x400079B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AM2Text m_buttonText;

	[Token(Token = "0x400079C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private InfoPopupButton m_infoPopupButton;

	[Token(Token = "0x400079D")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82499C", Offset = "0x82499C")]
	private string _003CzoneReference_003Ek__BackingField;

	[Token(Token = "0x400079E")]
	[FieldOffset(Offset = "0x50")]
	private ZonePageView m_zonePageView;

	[Token(Token = "0x400079F")]
	[FieldOffset(Offset = "0x58")]
	private ConstructionViewController m_viewController;

	[Token(Token = "0x40007A0")]
	[FieldOffset(Offset = "0x60")]
	private Localizations m_localizationController;

	[Token(Token = "0x40007A1")]
	[FieldOffset(Offset = "0x68")]
	private AM2TextDisplayController m_textDisplayController;

	[Token(Token = "0x17000103")]
	public string zoneReference
	{
		[Token(Token = "0x600089D")]
		[Address(RVA = "0xABA154", Offset = "0xABA154", VA = "0xABA154")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834428", Offset = "0x834428")]
		get
		{
			return null;
		}
		[Token(Token = "0x600089E")]
		[Address(RVA = "0xABA15C", Offset = "0xABA15C", VA = "0xABA15C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834438", Offset = "0x834438")]
		private set
		{
		}
	}

	[Token(Token = "0x600089F")]
	[Address(RVA = "0xABA164", Offset = "0xABA164", VA = "0xABA164")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008A0")]
	[Address(RVA = "0xABA214", Offset = "0xABA214", VA = "0xABA214")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60008A1")]
	[Address(RVA = "0xABA2CC", Offset = "0xABA2CC", VA = "0xABA2CC")]
	public void Initialize(ZonePageView zonePageView, Zone zone)
	{
	}

	[Token(Token = "0x60008A2")]
	[Address(RVA = "0xABA784", Offset = "0xABA784", VA = "0xABA784")]
	public void ShowRedDotNotification(bool show)
	{
	}

	[Token(Token = "0x60008A3")]
	[Address(RVA = "0xABA7BC", Offset = "0xABA7BC", VA = "0xABA7BC")]
	public void OnButtonPressed()
	{
	}

	[Token(Token = "0x60008A4")]
	[Address(RVA = "0xABA8F4", Offset = "0xABA8F4", VA = "0xABA8F4")]
	public ZoneItemView()
	{
	}
}
