using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AM2;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x2000097")]
public class AdsItemView : MonoBehaviour, ISubTabItemView
{
	[Token(Token = "0x400028B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Button m_playAdsButton;

	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected ProgressBar m_quantityBar;

	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected AM2Text m_activeSpeedBoostText;

	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected AM2Text m_activespeedBoostText2;

	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected AM2Text m_buttonText;

	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected AM2Text m_nameText;

	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected AM2Text m_quantityText;

	[Token(Token = "0x4000292")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected AM2Text m_rewardTitleText;

	[Token(Token = "0x4000293")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected AM2Text m_rewardText;

	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject m_redDotNotification;

	[Token(Token = "0x4000295")]
	[FieldOffset(Offset = "0x68")]
	private float m_fRefreshTime;

	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x70")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x78")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x80")]
	private AdsController m_adsController;

	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x88")]
	private UIAlertController m_uiAlertController;

	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x90")]
	private SpeedBoosterController m_speedBoosterController;

	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x98")]
	private AdConfigs m_adConfigs;

	[Token(Token = "0x400029C")]
	[FieldOffset(Offset = "0xA0")]
	private AdConfig m_currentConfig;

	[Token(Token = "0x400029D")]
	[FieldOffset(Offset = "0xA8")]
	private VIPStatusController m_vipStatusController;

	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0xB0")]
	private CasualViewController m_parentController;

	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0xB8")]
	private string m_readyButtonText;

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xACF658", Offset = "0xACF658", VA = "0xACF658")]
	public void Initialize(CasualViewController parentController, AdConfig adConfig)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xACFB6C", Offset = "0xACFB6C", VA = "0xACFB6C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xACFC1C", Offset = "0xACFC1C", VA = "0xACFC1C")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xACFC30", Offset = "0xACFC30", VA = "0xACFC30")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xACFD28", Offset = "0xACFD28", VA = "0xACFD28", Slot = "4")]
	public bool RefreshRedDotNotification(HashSet<string> untouchedUnlockers, HashSet<string> untouchedItemRefs)
	{
		return default(bool);
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xACFE7C", Offset = "0xACFE7C", VA = "0xACFE7C")]
	public void ShowRedDotNotification(bool show)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xACFEB4", Offset = "0xACFEB4", VA = "0xACFEB4", Slot = "7")]
	public void OnHidePage()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xACFE28", Offset = "0xACFE28", VA = "0xACFE28")]
	private bool HasRemainingAdViews()
	{
		return default(bool);
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xACFEB8", Offset = "0xACFEB8", VA = "0xACFEB8")]
	private void MarkViewed()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xAD0384", Offset = "0xAD0384", VA = "0xAD0384", Slot = "8")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xAD0388", Offset = "0xAD0388", VA = "0xAD0388")]
	private void OnAdButtonClicked()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xAD0430", Offset = "0xAD0430", VA = "0xAD0430")]
	private void ShowAdResult(AdsController.AdShowState result)
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xAD0490", Offset = "0xAD0490", VA = "0xAD0490")]
	private void DisplayRewardPopup(bool adWatched = true)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xAD0690", Offset = "0xAD0690", VA = "0xAD0690")]
	private void Update()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xAD06E4", Offset = "0xAD06E4", VA = "0xAD06E4")]
	private void RefreshAdState()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xAD10CC", Offset = "0xAD10CC", VA = "0xAD10CC")]
	private void RefreshRewardText()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xAD0C4C", Offset = "0xAD0C4C", VA = "0xAD0C4C")]
	private void RefreshButtonText(DateTime currentTime, TimeSpan remainingTimeBetweenEachAd, TimeSpan remainingTimeBetweenReset, bool isActive, long viewCount, AdsController.CanWatchResult canWatchResult)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xAD12E0", Offset = "0xAD12E0", VA = "0xAD12E0")]
	private void RefreshGlobalSpeedBoostState(bool isActive)
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0xAD0C14", Offset = "0xAD0C14", VA = "0xAD0C14")]
	private void SetRewardedAdAvailable(bool isAvailable = true)
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0xAD1394", Offset = "0xAD1394", VA = "0xAD1394")]
	private static string FormatTime(TimeSpan remaining)
	{
		return null;
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xAD17C4", Offset = "0xAD17C4", VA = "0xAD17C4")]
	public AdsItemView()
	{
	}

	[SpecialName]
	[Token(Token = "0x6000328")]
	[Address(RVA = "0xAD181C", Offset = "0xAD181C", VA = "0xAD181C", Slot = "5")]
	private GameObject ISubTabItemView_002Eget_gameObject()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000329")]
	[Address(RVA = "0xAD1824", Offset = "0xAD1824", VA = "0xAD1824", Slot = "6")]
	private Transform ISubTabItemView_002Eget_transform()
	{
		return null;
	}
}
