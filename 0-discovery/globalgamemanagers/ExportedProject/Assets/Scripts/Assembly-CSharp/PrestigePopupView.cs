using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x20000EE")]
public class PrestigePopupView : CasualView
{
	[Token(Token = "0x4000581")]
	[FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x823600", Offset = "0x823600")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x823600", Offset = "0x823600")]
	[SerializeField]
	private AM2Button m_confirmationButton;

	[Token(Token = "0x4000582")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private AM2Text m_prestigeDescriptionText;

	[Token(Token = "0x4000583")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private TierRewardDescriptionView m_tierRewardEntryViewTemplate;

	[Token(Token = "0x4000584")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private Transform m_scrollViewContentHolder;

	[Token(Token = "0x4000585")]
	[FieldOffset(Offset = "0xE0")]
	private CasualViewController m_casualViewController;

	[Token(Token = "0x4000586")]
	[FieldOffset(Offset = "0xE8")]
	private PrestigeController m_prestigeController;

	[Token(Token = "0x600065D")]
	[Address(RVA = "0x9DFAF0", Offset = "0x9DFAF0", VA = "0x9DFAF0")]
	public void Initialize(CasualViewController viewController, PrestigeController prestigeController)
	{
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0x9DFBA8", Offset = "0x9DFBA8", VA = "0x9DFBA8")]
	private void CreatePrestigeRewardEntries()
	{
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0x9DFE84", Offset = "0x9DFE84", VA = "0x9DFE84", Slot = "12")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000660")]
	[Address(RVA = "0x9DFF38", Offset = "0x9DFF38", VA = "0x9DFF38", Slot = "13")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x9DFFF8", Offset = "0x9DFFF8", VA = "0x9DFFF8")]
	public PrestigePopupView()
	{
	}
}
