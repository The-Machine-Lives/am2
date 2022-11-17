using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using UnityEngine;
using Utilities;

[Token(Token = "0x20000D2")]
public class LoadoutPopupView : SlottablePopupView<Ability>
{
	[Token(Token = "0x40003B1")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private AM2Text m_titleText;

	[Token(Token = "0x40003B2")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private AM2Text m_descriptionText;

	[Token(Token = "0x40003B3")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private GameObject m_costPanel;

	[Token(Token = "0x40003B4")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private List<CostItemView> m_costItemViews;

	[Token(Token = "0x40003B5")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	private AM2Button m_upgradeButton;

	[Token(Token = "0x40003B6")]
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	private AM2Text m_upgradeButtonText;

	[Token(Token = "0x40003B7")]
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	private AM2Button m_dustingButton;

	[Token(Token = "0x40003B8")]
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	private GameObject m_infoPopupViewTemplate;

	[Token(Token = "0x40003B9")]
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	private AM2Button m_settingButton;

	[Token(Token = "0x40003BA")]
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	private GameObject m_settingPopupViewTemplate;

	[Token(Token = "0x40003BB")]
	[FieldOffset(Offset = "0x190")]
	private bool m_needsRebuild;

	[Token(Token = "0x40003BC")]
	[FieldOffset(Offset = "0x191")]
	private bool m_previouslyMaxLevel;

	[Token(Token = "0x40003BD")]
	[FieldOffset(Offset = "0x198")]
	private List<AbilityTraitView> m_abilityTraitViews;

	[Token(Token = "0x40003BE")]
	[FieldOffset(Offset = "0x1A0")]
	private AmmoTextUpdater m_ammoTextUpdater;

	[Token(Token = "0x40003BF")]
	[FieldOffset(Offset = "0x1A8")]
	private LoadoutController m_loadoutController;

	[Token(Token = "0x40003C0")]
	[FieldOffset(Offset = "0x1B0")]
	private ObjectPoolController m_objectPoolController;

	[Token(Token = "0x40003C1")]
	[FieldOffset(Offset = "0x1B8")]
	private ZoneController m_zoneController;

	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0x1C0")]
	private InfoPopupView m_activeInfoPopupView;

	[Token(Token = "0x40003C3")]
	[FieldOffset(Offset = "0x1C8")]
	private LoadoutSettingPopupView m_activeSettingPopupView;

	[Token(Token = "0x40003C4")]
	[FieldOffset(Offset = "0x1D0")]
	private IInfoText infoText;

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x996328", Offset = "0x996328", VA = "0x996328", Slot = "12")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x9964FC", Offset = "0x9964FC", VA = "0x9964FC", Slot = "13")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x99676C", Offset = "0x99676C", VA = "0x99676C", Slot = "17")]
	public override void Initialize(CasualViewController parentController, int sourceIndex, IRefreshableSlottableView<Ability> sourceSlottableView, Ability ability)
	{
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x996A74", Offset = "0x996A74", VA = "0x996A74", Slot = "19")]
	protected override void RefreshView()
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x997758", Offset = "0x997758", VA = "0x997758")]
	private void RefreshCostItemViews()
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x9966D8", Offset = "0x9966D8", VA = "0x9966D8")]
	private void ClearTraitViews()
	{
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x996F64", Offset = "0x996F64", VA = "0x996F64")]
	private void CreateAmmoTraitView()
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x997664", Offset = "0x997664", VA = "0x997664")]
	private void CreateTraitViewsBasedOnEffects(long currentLevel)
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x997DDC", Offset = "0x997DDC", VA = "0x997DDC")]
	private void CreateTraitViewsFromList(List<IAbilityEffect> effectsList, long currentLevel, bool isSelf, bool isPassive)
	{
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x9971F8", Offset = "0x9971F8", VA = "0x9971F8")]
	private void CreateCooldownTraitView(long currentLevel)
	{
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0x9972BC", Offset = "0x9972BC", VA = "0x9972BC")]
	private void CreateCastTimeTraitView(long currentLevel)
	{
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0x9973F0", Offset = "0x9973F0", VA = "0x9973F0")]
	private void CreateChannelTimeTraitView()
	{
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x9974E8", Offset = "0x9974E8", VA = "0x9974E8")]
	private void CreateAccuracyTraitView(long currentLevel)
	{
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x998078", Offset = "0x998078", VA = "0x998078")]
	private AbilityTraitView CreateAbilityTraitView(string traitTitle, double currentAmount, double nextAmountDiff, bool localizedTitle, int decimalPlaces = 0, bool asTime = false)
	{
		return null;
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x997C5C", Offset = "0x997C5C", VA = "0x997C5C")]
	private AbilityTraitView CreateAbilityTraitView(string traitTitle, string currentAmountString, string nextAmountString, bool localizedTitle)
	{
		return null;
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x997ADC", Offset = "0x997ADC", VA = "0x997ADC")]
	private void UpdateView(bool force = false)
	{
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0x9981C8", Offset = "0x9981C8", VA = "0x9981C8")]
	private void SetUpgradeButtonActive(bool active)
	{
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0x996EC4", Offset = "0x996EC4", VA = "0x996EC4")]
	private long GetSelectedAbilityLevel()
	{
		return default(long);
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x9981CC", Offset = "0x9981CC", VA = "0x9981CC")]
	public void OnClickUpgrade()
	{
	}

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x998254", Offset = "0x998254", VA = "0x998254")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x998310", Offset = "0x998310", VA = "0x998310")]
	private void OnClickSetting()
	{
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x99856C", Offset = "0x99856C", VA = "0x99856C")]
	private void OnClickDust()
	{
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x996A1C", Offset = "0x996A1C", VA = "0x996A1C")]
	private void ApplySetting()
	{
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x998744", Offset = "0x998744", VA = "0x998744")]
	private void UpdateShowAbilityNoAmmo()
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x998990", Offset = "0x998990", VA = "0x998990")]
	public LoadoutPopupView()
	{
	}
}
