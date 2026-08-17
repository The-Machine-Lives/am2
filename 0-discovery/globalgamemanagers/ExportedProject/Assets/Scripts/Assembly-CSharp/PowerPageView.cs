using System;
using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Animation;
using Uken.Library.Observe;
using UnityEngine;

[Token(Token = "0x20000DA")]
public class PowerPageView : ConstructionPageView, IUkenObserver<StoryLogUIMessage>, IUkenObserver<UntouchedUIMessage>, IUkenObserver<DynamicAdState>, ISubTabToggledHandler
{
	[Token(Token = "0x200061F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8203D8", Offset = "0x8203D8")]
	private sealed class _003C_003Ec__DisplayClass70_0
	{
		[Token(Token = "0x4001E40")]
		[FieldOffset(Offset = "0x10")]
		public DynamicAds dynamicAd;

		[Token(Token = "0x4001E41")]
		[FieldOffset(Offset = "0x18")]
		public PowerPageView _003C_003E4__this;

		[Token(Token = "0x6002CF4")]
		[Address(RVA = "0x9DA860", Offset = "0x9DA860", VA = "0x9DA860")]
		public _003C_003Ec__DisplayClass70_0()
		{
		}

		[Token(Token = "0x6002CF5")]
		[Address(RVA = "0x9DA868", Offset = "0x9DA868", VA = "0x9DA868")]
		internal void _003COnDynamicAdButtonPressed_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000620")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8203E8", Offset = "0x8203E8")]
	private sealed class _003C_003Ec__DisplayClass72_0
	{
		[Token(Token = "0x4001E42")]
		[FieldOffset(Offset = "0x10")]
		public PowerPageView _003C_003E4__this;

		[Token(Token = "0x4001E43")]
		[FieldOffset(Offset = "0x18")]
		public DynamicAds dynamicAd;

		[Token(Token = "0x6002CF6")]
		[Address(RVA = "0x9DA8F0", Offset = "0x9DA8F0", VA = "0x9DA8F0")]
		public _003C_003Ec__DisplayClass72_0()
		{
		}

		[Token(Token = "0x6002CF7")]
		[Address(RVA = "0x9DA8F8", Offset = "0x9DA8F8", VA = "0x9DA8F8")]
		internal void _003COnPlayDynamicAd_003Eb__0(AdsController.AdShowState result)
		{
		}
	}

	[Token(Token = "0x2000621")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8203F8", Offset = "0x8203F8")]
	private sealed class _003C_003Ec__DisplayClass73_0
	{
		[Token(Token = "0x4001E44")]
		[FieldOffset(Offset = "0x10")]
		public DynamicAds dynamicAd;

		[Token(Token = "0x4001E45")]
		[FieldOffset(Offset = "0x18")]
		public PowerPageView _003C_003E4__this;

		[Token(Token = "0x6002CF8")]
		[Address(RVA = "0x9DAA74", Offset = "0x9DAA74", VA = "0x9DAA74")]
		public _003C_003Ec__DisplayClass73_0()
		{
		}

		[Token(Token = "0x6002CF9")]
		[Address(RVA = "0x9DAA7C", Offset = "0x9DAA7C", VA = "0x9DAA7C")]
		internal bool _003CHideDynamicAd_003Eb__0(DynamicAdsView o)
		{
			return default(bool);
		}

		[Token(Token = "0x6002CFA")]
		[Address(RVA = "0x9DAAC0", Offset = "0x9DAAC0", VA = "0x9DAAC0")]
		internal void _003CHideDynamicAd_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000622")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820408", Offset = "0x820408")]
	private sealed class _003C_003Ec__DisplayClass77_0
	{
		[Token(Token = "0x4001E46")]
		[FieldOffset(Offset = "0x10")]
		public PowerPageView _003C_003E4__this;

		[Token(Token = "0x4001E47")]
		[FieldOffset(Offset = "0x18")]
		public IEnumerable<DynamicAds> alreadyActiveAds;

		[Token(Token = "0x6002CFB")]
		[Address(RVA = "0x9DAB0C", Offset = "0x9DAB0C", VA = "0x9DAB0C")]
		public _003C_003Ec__DisplayClass77_0()
		{
		}

		[Token(Token = "0x6002CFC")]
		[Address(RVA = "0x9DAB14", Offset = "0x9DAB14", VA = "0x9DAB14")]
		internal bool _003CShowActiveAds_003Eb__1(DynamicAds o)
		{
			return default(bool);
		}

		[Token(Token = "0x6002CFD")]
		[Address(RVA = "0x9DAC24", Offset = "0x9DAC24", VA = "0x9DAC24")]
		internal bool _003CShowActiveAds_003Eb__2(DynamicAds o)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000623")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820418", Offset = "0x820418")]
	private sealed class _003C_003Ec__DisplayClass77_1
	{
		[Token(Token = "0x4001E48")]
		[FieldOffset(Offset = "0x10")]
		public DynamicAds o;

		[Token(Token = "0x6002CFE")]
		[Address(RVA = "0x9DAC1C", Offset = "0x9DAC1C", VA = "0x9DAC1C")]
		public _003C_003Ec__DisplayClass77_1()
		{
		}

		[Token(Token = "0x6002CFF")]
		[Address(RVA = "0x9DAC90", Offset = "0x9DAC90", VA = "0x9DAC90")]
		internal bool _003CShowActiveAds_003Eb__4(DynamicAdsView i)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x2000624")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820428", Offset = "0x820428")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001E49")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001E4A")]
		[FieldOffset(Offset = "0x8")]
		public static Func<DynamicAdsView, bool> _003C_003E9__77_0;

		[Token(Token = "0x4001E4B")]
		[FieldOffset(Offset = "0x10")]
		public static Func<DynamicAdsView, int> _003C_003E9__77_3;

		[Token(Token = "0x6002D01")]
		[Address(RVA = "0x9DA7D4", Offset = "0x9DA7D4", VA = "0x9DA7D4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002D02")]
		[Address(RVA = "0x9DA7DC", Offset = "0x9DA7DC", VA = "0x9DA7DC")]
		internal bool _003CShowActiveAds_003Eb__77_0(DynamicAdsView o)
		{
			return default(bool);
		}

		[Token(Token = "0x6002D03")]
		[Address(RVA = "0x9DA818", Offset = "0x9DA818", VA = "0x9DA818")]
		internal int _003CShowActiveAds_003Eb__77_3(DynamicAdsView o)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000406")]
	private const float c_powerAnimMoveSpeed = 0.38f;

	[Token(Token = "0x4000407")]
	private const int c_dynamicButtonSibilingIndex = 6;

	[Token(Token = "0x4000408")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private StoryLogsView m_storyLogsView;

	[Token(Token = "0x4000409")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private PowerRecipeView m_powerRecipeView;

	[Token(Token = "0x400040A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform m_powerAnimRect;

	[Token(Token = "0x400040B")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8229E8", Offset = "0x8229E8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8229E8", Offset = "0x8229E8")]
	[SerializeField]
	private TabController m_subTabController;

	[Token(Token = "0x400040C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private SubTabView m_powerSubTabView;

	[Token(Token = "0x400040D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private SubTabView m_equipmentSubTabView;

	[Token(Token = "0x400040E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private SubTabView m_prestigeSubTabView;

	[Token(Token = "0x400040F")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private TabButton m_powerTabButton;

	[Token(Token = "0x4000410")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private TabButton m_equipmentTabButton;

	[Token(Token = "0x4000411")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private TabButton m_prestigeTabButton;

	[Token(Token = "0x4000412")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x822AA4", Offset = "0x822AA4")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x822AA4", Offset = "0x822AA4")]
	[SerializeField]
	private SubTabsView m_subTabsView;

	[Token(Token = "0x4000413")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private EquipmentView m_equipmentView;

	[Token(Token = "0x4000414")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private MiniEventView m_miniEventView;

	[Token(Token = "0x4000415")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private PrestigeView m_prestigeView;

	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x822B30", Offset = "0x822B30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x822B30", Offset = "0x822B30")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822B30", Offset = "0x822B30")]
	private int m_maximumNumberOfDynamicAds;

	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private DynamicAdsView m_dynamicAdsTemplate;

	[Token(Token = "0x4000418")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Transform m_dynamicAdRotationSource;

	[Token(Token = "0x4000419")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private ProfileHeaderView m_profileHeaderView;

	[Token(Token = "0x400041A")]
	[FieldOffset(Offset = "0xC8")]
	private UkenUnsubscriber<DynamicAdState> m_dynamicAdSignalHandle;

	[Token(Token = "0x400041B")]
	[FieldOffset(Offset = "0xD0")]
	private UkenUnsubscriber<UntouchedUIMessage> m_unlockerSignalHandle;

	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0xD8")]
	private UkenUnsubscriber<UntouchedUIMessage> m_equipmentSignalHandle;

	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0xE0")]
	private UkenUnsubscriber<UntouchedUIMessage> m_miniEventSignalHandle;

	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0xE8")]
	private UkenUnsubscriber<UntouchedUIMessage> m_prestigeSignalHandle;

	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0xF0")]
	private UkenUnsubscriber<UntouchedUIMessage> m_slotsSignalHandle;

	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0xF8")]
	private UkenUnsubscriber<UntouchedUIMessage> m_titlesNotificationSignalHandle;

	[Token(Token = "0x4000421")]
	[FieldOffset(Offset = "0x100")]
	private UkenUnsubscriber<UntouchedUIMessage> m_badgesNotificationSignalHandle;

	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x108")]
	private bool m_hasUntouchedEquipmentSlot;

	[Token(Token = "0x4000423")]
	[FieldOffset(Offset = "0x109")]
	private bool m_hasUntouchedEquipmentItems;

	[Token(Token = "0x4000424")]
	[FieldOffset(Offset = "0x10A")]
	private bool m_hasUntouchedMiniEventItems;

	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x10B")]
	private bool m_initializedElements;

	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x10C")]
	private bool m_anyUnseenStoryLogs;

	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x10D")]
	private bool m_hasUntouchedDynamicAd;

	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x110")]
	private UntouchedUIMessage m_latestUnlockerUIMessage;

	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x118")]
	private UntouchedUIMessage m_latestTitlesUIMessage;

	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x120")]
	private UntouchedUIMessage m_latestBadgesUIMessage;

	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x128")]
	private UkenUnsubscriber<StoryLogUIMessage> m_signalHandle;

	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0x130")]
	private bool equipmentSubTabInitialized;

	[Token(Token = "0x400042D")]
	[FieldOffset(Offset = "0x131")]
	private bool prestigeSubTabInitialized;

	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0x138")]
	private Power m_power;

	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0x140")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0x148")]
	private StoryLogController m_storyLogController;

	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x150")]
	private UIAlertController m_uiAlertController;

	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x158")]
	private EquipmentController m_equipmentController;

	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x160")]
	private DynamicAdsController m_dynamicAdsController;

	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x168")]
	private AdsController m_adsController;

	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x170")]
	private AdConfigs m_adConfigs;

	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x178")]
	private FTUEController m_ftueController;

	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x180")]
	private PrestigeController m_prestigeController;

	[Token(Token = "0x4000438")]
	[FieldOffset(Offset = "0x188")]
	private VIPStatusController m_vipStatusController;

	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0x190")]
	private MiniEventController m_miniEventController;

	[Token(Token = "0x400043A")]
	[FieldOffset(Offset = "0x198")]
	private bool m_previousActive;

	[Token(Token = "0x400043B")]
	[FieldOffset(Offset = "0x1A0")]
	private List<DynamicAdsView> m_dynamicAdViews;

	[Token(Token = "0x170000D6")]
	private UkenAnim ukenAnim
	{
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x9A2170", Offset = "0x9A2170", VA = "0x9A2170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x9A2178", Offset = "0x9A2178", VA = "0x9A2178")]
	private void Awake()
	{
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x9A2ED0", Offset = "0x9A2ED0", VA = "0x9A2ED0")]
	private void InitializeEquipmentSubTab()
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x9A3208", Offset = "0x9A3208", VA = "0x9A3208")]
	private void InitializePrestigeSubTab()
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x9A329C", Offset = "0x9A329C", VA = "0x9A329C", Slot = "4")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x9A33AC", Offset = "0x9A33AC", VA = "0x9A33AC", Slot = "5")]
	public override void OnTogglePageOn()
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x9A3434", Offset = "0x9A3434", VA = "0x9A3434", Slot = "10")]
	public void OnSubTabToggledOn(SubTabView source)
	{
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x9A33EC", Offset = "0x9A33EC", VA = "0x9A33EC")]
	private bool IsPowerSubTabActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x9A3710", Offset = "0x9A3710", VA = "0x9A3710", Slot = "6")]
	public override void OnTogglePageOff()
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x9A37BC", Offset = "0x9A37BC", VA = "0x9A37BC", Slot = "7")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CUken_002EFramework_002ECasual_002EStoryLogUIMessage_003E_002EOnEmit(StoryLogUIMessage storyLogUIMessage)
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x9A38AC", Offset = "0x9A38AC", VA = "0x9A38AC", Slot = "8")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CUntouchedUIMessage_003E_002EOnEmit(UntouchedUIMessage message)
	{
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x9A3470", Offset = "0x9A3470", VA = "0x9A3470")]
	private void RefreshRedDotNotifications()
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x9A3B1C", Offset = "0x9A3B1C", VA = "0x9A3B1C")]
	protected void TryScrollToBottom()
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x9A3B64", Offset = "0x9A3B64", VA = "0x9A3B64")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x9A3B68", Offset = "0x9A3B68", VA = "0x9A3B68")]
	protected void UpdatePowerAnimationPos()
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x9A3CE4", Offset = "0x9A3CE4", VA = "0x9A3CE4")]
	private void OnDynamicAdButtonPressed(DynamicAds dynamicAd)
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x9A4058", Offset = "0x9A4058", VA = "0x9A4058")]
	private void OnCollectReward(DynamicAds dynamicAd)
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x9A422C", Offset = "0x9A422C", VA = "0x9A422C")]
	private void OnPlayDynamicAd(DynamicAds dynamicAd)
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x9A40A8", Offset = "0x9A40A8", VA = "0x9A40A8")]
	private void HideDynamicAd(DynamicAds dynamicAd)
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x9A439C", Offset = "0x9A439C", VA = "0x9A439C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x9A2FF8", Offset = "0x9A2FF8", VA = "0x9A2FF8")]
	private void InstantiateDynamicAdButtons()
	{
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x9A4424", Offset = "0x9A4424", VA = "0x9A4424")]
	private void HideInactiveAds()
	{
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x9A4620", Offset = "0x9A4620", VA = "0x9A4620")]
	private void ShowActiveAds()
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x9A4B74", Offset = "0x9A4B74", VA = "0x9A4B74", Slot = "9")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CUken_002EFramework_002ECasual_002EDynamicAdState_003E_002EOnEmit(DynamicAdState dynamicAdState)
	{
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x9A4BC8", Offset = "0x9A4BC8", VA = "0x9A4BC8")]
	public PowerPageView()
	{
	}
}
