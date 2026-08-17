using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Observe;
using UnityEngine;

[Token(Token = "0x20000DD")]
public class ResearchPageView : ConstructionPageView, IUkenObserver<List<ResearchSlotItem>>, IUkenObserver<ResearchUIMessage>
{
	[Token(Token = "0x400045D")]
	private const string c_costItemReference = "power";

	[Token(Token = "0x400045E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_researchViewTemplate;

	[Token(Token = "0x400045F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject m_researchListView;

	[Token(Token = "0x4000460")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AM2Text m_costItemOverdrawText;

	[Token(Token = "0x4000461")]
	[FieldOffset(Offset = "0x50")]
	private List<ResearchView> m_researchViews;

	[Token(Token = "0x4000462")]
	[FieldOffset(Offset = "0x58")]
	private ConstructionController m_constructionController;

	[Token(Token = "0x4000463")]
	[FieldOffset(Offset = "0x60")]
	private ResearchController m_researchController;

	[Token(Token = "0x4000464")]
	[FieldOffset(Offset = "0x68")]
	private RecipeDifferentialController m_recipeDifferentialController;

	[Token(Token = "0x4000465")]
	[FieldOffset(Offset = "0x70")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000466")]
	[FieldOffset(Offset = "0x78")]
	private ResearchUIMessage m_latestResearchUIMessage;

	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0x80")]
	private UkenUnsubscriber<List<ResearchSlotItem>> m_slotSignalHandle;

	[Token(Token = "0x4000468")]
	[FieldOffset(Offset = "0x88")]
	private UkenUnsubscriber<ResearchUIMessage> m_researchSignalhandle;

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x9F49F0", Offset = "0x9F49F0", VA = "0x9F49F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x9F4C84", Offset = "0x9F4C84", VA = "0x9F4C84", Slot = "4")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x9F4D08", Offset = "0x9F4D08", VA = "0x9F4D08")]
	private void Update()
	{
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x9F4D0C", Offset = "0x9F4D0C", VA = "0x9F4D0C")]
	private void SetCostItemOverdrawText()
	{
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x9F4D54", Offset = "0x9F4D54", VA = "0x9F4D54")]
	private string GenerateCostItemOverdrawText()
	{
		return null;
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x9F4E98", Offset = "0x9F4E98", VA = "0x9F4E98", Slot = "7")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CSystem_002ECollections_002EGeneric_002EList_003CResearchSlotItem_003E_003E_002EOnEmit(List<ResearchSlotItem> researchSlots)
	{
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x9F583C", Offset = "0x9F583C", VA = "0x9F583C", Slot = "8")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CUken_002EFramework_002ECasual_002EResearchUIMessage_003E_002EOnEmit(ResearchUIMessage researchUIMessage)
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x9F5A2C", Offset = "0x9F5A2C", VA = "0x9F5A2C")]
	private void RefreshRedDotNotifications()
	{
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x9F5A5C", Offset = "0x9F5A5C", VA = "0x9F5A5C")]
	public ResearchPageView()
	{
	}
}
