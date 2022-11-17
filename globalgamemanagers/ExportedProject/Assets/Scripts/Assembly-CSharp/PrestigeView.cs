using AM2;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Observe;
using UnityEngine;

[Token(Token = "0x20000EF")]
public class PrestigeView : MonoBehaviour, IUkenObserver<UntouchedUIMessage>
{
	[Token(Token = "0x4000587")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x82368C", Offset = "0x82368C")]
	private AM2Text m_currentLevelText;

	[Token(Token = "0x4000588")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x8236D8", Offset = "0x8236D8")]
	private AM2Button m_prestigePopupViewButton;

	[Token(Token = "0x4000589")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x823724", Offset = "0x823724")]
	private PrestigePopupView m_prestigePopupViewTemplate;

	[Token(Token = "0x400058A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x823770", Offset = "0x823770")]
	private PrestigeItemView m_prestigeItemViewTemplate;

	[Token(Token = "0x400058B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x8237BC", Offset = "0x8237BC")]
	private Transform m_scrollViewContentHolder;

	[Token(Token = "0x400058C")]
	[FieldOffset(Offset = "0x40")]
	private PrestigePopupView m_currentPrestigePopupView;

	[Token(Token = "0x400058D")]
	[FieldOffset(Offset = "0x48")]
	private CasualViewController m_casualViewController;

	[Token(Token = "0x400058E")]
	[FieldOffset(Offset = "0x50")]
	private PrestigeController m_prestigeController;

	[Token(Token = "0x400058F")]
	[FieldOffset(Offset = "0x58")]
	private UIAlertController m_uiAlertController;

	[Token(Token = "0x4000590")]
	[FieldOffset(Offset = "0x60")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000591")]
	[FieldOffset(Offset = "0x68")]
	private UkenUnsubscriber<UntouchedUIMessage> m_prestigeButtonUnlockHandle;

	[Token(Token = "0x4000592")]
	[FieldOffset(Offset = "0x70")]
	private CasualViewMutex m_casualViewMutex;

	[Token(Token = "0x4000593")]
	[FieldOffset(Offset = "0x78")]
	private string m_originalTitleText;

	[Token(Token = "0x6000662")]
	[Address(RVA = "0x9E0008", Offset = "0x9E0008", VA = "0x9E0008")]
	public void Initialize(CasualViewController viewController)
	{
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x9E03F0", Offset = "0x9E03F0", VA = "0x9E03F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x9E0434", Offset = "0x9E0434", VA = "0x9E0434")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x9E05D8", Offset = "0x9E05D8", VA = "0x9E05D8")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x9E0244", Offset = "0x9E0244", VA = "0x9E0244")]
	private void AddAllPrestigeItemsToView()
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x9E06A0", Offset = "0x9E06A0", VA = "0x9E06A0")]
	private void OnClickedOpenPrestigePopupViewButton()
	{
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0x9E0834", Offset = "0x9E0834", VA = "0x9E0834")]
	private void FinishedShowingPrestigePopupView()
	{
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x9E01F0", Offset = "0x9E01F0", VA = "0x9E01F0")]
	private void TryToEnablePrestigeButton()
	{
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x9E0868", Offset = "0x9E0868", VA = "0x9E0868", Slot = "4")]
	public void OnEmit(UntouchedUIMessage message)
	{
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x9E0910", Offset = "0x9E0910", VA = "0x9E0910")]
	public PrestigeView()
	{
	}
}
