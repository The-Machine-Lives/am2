using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x20000ED")]
public class PrestigeItemView : MonoBehaviour
{
	[Token(Token = "0x400057A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x82351C", Offset = "0x82351C")]
	private AM2Text m_prestigeNameText;

	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x823568", Offset = "0x823568")]
	private AM2Button m_prestigeButton;

	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x8235B4", Offset = "0x8235B4")]
	private PrestigeItemPopupInfoView m_prestigeItemPopupInfoViewTemplate;

	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x30")]
	private Localizations m_localizationController;

	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0x38")]
	private CasualViewController m_casualViewController;

	[Token(Token = "0x400057F")]
	[FieldOffset(Offset = "0x40")]
	private Prestiges m_prestigeItem;

	[Token(Token = "0x4000580")]
	[FieldOffset(Offset = "0x48")]
	private CasualViewMutex m_casualViewMutex;

	[Token(Token = "0x6000657")]
	[Address(RVA = "0x9DF690", Offset = "0x9DF690", VA = "0x9DF690")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x9DF740", Offset = "0x9DF740", VA = "0x9DF740")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x9DF7F0", Offset = "0x9DF7F0", VA = "0x9DF7F0")]
	public void Initialize(CasualViewController casualViewController, Prestiges prestigeItem, CasualViewMutex casualViewMutext)
	{
	}

	[Token(Token = "0x600065A")]
	[Address(RVA = "0x9DF96C", Offset = "0x9DF96C", VA = "0x9DF96C")]
	private void OnPrestigeButtonClicked()
	{
	}

	[Token(Token = "0x600065B")]
	[Address(RVA = "0x9DFAAC", Offset = "0x9DFAAC", VA = "0x9DFAAC")]
	private void OnFinishedShowingPrestigeItemPopupInfoView()
	{
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x9DFAE0", Offset = "0x9DFAE0", VA = "0x9DFAE0")]
	public PrestigeItemView()
	{
	}
}
