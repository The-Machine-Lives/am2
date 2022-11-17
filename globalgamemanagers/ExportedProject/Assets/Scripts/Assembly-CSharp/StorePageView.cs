using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Observe;
using Uken.Library.UkenTime;
using UnityEngine;

[Token(Token = "0x20000DF")]
public class StorePageView : ConstructionPageView, IUkenObserver<UntouchedUIMessage>, IUkenObserver<ResearchUIMessage>
{
	[Token(Token = "0x400049A")]
	public const string c_storeIapFeatureReference = "store_iaps_android";

	[Token(Token = "0x400049B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_researchablesViewTemplate;

	[Token(Token = "0x400049C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject m_researchablesViewParent;

	[Token(Token = "0x400049D")]
	[FieldOffset(Offset = "0x48")]
	private ResearchablesStoreView m_researchablesView;

	[Token(Token = "0x400049E")]
	[FieldOffset(Offset = "0x50")]
	private UkenUnsubscriber<UntouchedUIMessage> m_itemConverterSignalHandle;

	[Token(Token = "0x400049F")]
	[FieldOffset(Offset = "0x58")]
	private UkenUnsubscriber<UntouchedUIMessage> m_unlockerSignalHandle;

	[Token(Token = "0x40004A0")]
	[FieldOffset(Offset = "0x60")]
	private UkenUnsubscriber<ResearchUIMessage> m_researchSignalHandle;

	[Token(Token = "0x40004A1")]
	[FieldOffset(Offset = "0x68")]
	private UkenUnsubscriber<UntouchedUIMessage> m_adsSignalHandle;

	[Token(Token = "0x40004A2")]
	[FieldOffset(Offset = "0x70")]
	private UkenUnsubscriber<UntouchedUIMessage> m_storeItemsSignalHandle;

	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x78")]
	private UntouchedUIMessage m_latestItemConverterUIMessage;

	[Token(Token = "0x40004A4")]
	[FieldOffset(Offset = "0x80")]
	private UntouchedUIMessage m_latestUnlockerUIMessage;

	[Token(Token = "0x40004A5")]
	[FieldOffset(Offset = "0x88")]
	private UntouchedUIMessage m_latestAdConfigsUIMessage;

	[Token(Token = "0x40004A6")]
	[FieldOffset(Offset = "0x90")]
	private UntouchedUIMessage m_latestStoreItemsUIMessage;

	[Token(Token = "0x40004A7")]
	[FieldOffset(Offset = "0x98")]
	private ResearchUIMessage m_latestResearchUIMessage;

	[Token(Token = "0x40004A8")]
	[FieldOffset(Offset = "0xA0")]
	private ConstructionController m_constructionController;

	[Token(Token = "0x40004A9")]
	[FieldOffset(Offset = "0xA8")]
	private Localizations m_localizationController;

	[Token(Token = "0x40004AA")]
	[FieldOffset(Offset = "0xB0")]
	private ResearchController m_researchController;

	[Token(Token = "0x40004AB")]
	[FieldOffset(Offset = "0xB8")]
	private UkenTimeController m_time;

	[Token(Token = "0x40004AC")]
	[FieldOffset(Offset = "0xC0")]
	private AM2InventoryController m_inventory;

	[Token(Token = "0x40004AD")]
	[FieldOffset(Offset = "0xC8")]
	private FTUEController m_ftueController;

	[Token(Token = "0x40004AE")]
	[FieldOffset(Offset = "0xD0")]
	private Features m_features;

	[Token(Token = "0x60005EA")]
	[Address(RVA = "0xA0A664", Offset = "0xA0A664", VA = "0xA0A664")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005EB")]
	[Address(RVA = "0xA0AE04", Offset = "0xA0AE04", VA = "0xA0AE04")]
	private void Start()
	{
	}

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0xA0AEB0", Offset = "0xA0AEB0", VA = "0xA0AEB0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0xA0AF7C", Offset = "0xA0AF7C", VA = "0xA0AF7C", Slot = "6")]
	public override void OnTogglePageOff()
	{
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0xA0B028", Offset = "0xA0B028", VA = "0xA0B028", Slot = "4")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0xA0ACB4", Offset = "0xA0ACB4", VA = "0xA0ACB4")]
	private void BuildResearchablesView()
	{
	}

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0xA0B0C8", Offset = "0xA0B0C8", VA = "0xA0B0C8", Slot = "7")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CUntouchedUIMessage_003E_002EOnEmit(UntouchedUIMessage message)
	{
	}

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0xA0B1D4", Offset = "0xA0B1D4", VA = "0xA0B1D4", Slot = "8")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CUken_002EFramework_002ECasual_002EResearchUIMessage_003E_002EOnEmit(ResearchUIMessage researchUIMessage)
	{
	}

	[Token(Token = "0x60005F2")]
	[Address(RVA = "0xA0AF38", Offset = "0xA0AF38", VA = "0xA0AF38")]
	private void RefreshItemViewsAndRedDotNotification()
	{
	}

	[Token(Token = "0x60005F3")]
	[Address(RVA = "0xA0B1DC", Offset = "0xA0B1DC", VA = "0xA0B1DC")]
	private void RefreshRedDotNotifications()
	{
	}

	[Token(Token = "0x60005F4")]
	[Address(RVA = "0xA0B354", Offset = "0xA0B354", VA = "0xA0B354")]
	public StorePageView()
	{
	}
}
