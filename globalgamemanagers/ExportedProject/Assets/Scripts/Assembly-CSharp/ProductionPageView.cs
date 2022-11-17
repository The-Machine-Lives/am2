using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Observe;
using UnityEngine;

[Token(Token = "0x20000DB")]
public class ProductionPageView : ConstructionPageView, IUkenObserver<UntouchedUIMessage>
{
	[Token(Token = "0x2000625")]
	private class RecipeViewInstantiator : ItemModelViewInstantiator
	{
		[Token(Token = "0x4001E4C")]
		[FieldOffset(Offset = "0x38")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x4001E4D")]
		[FieldOffset(Offset = "0x40")]
		private CasualViewController m_viewController;

		[Token(Token = "0x4001E4E")]
		[FieldOffset(Offset = "0x48")]
		private ProductionPageView m_productionPageView;

		[Token(Token = "0x6002D04")]
		[Address(RVA = "0x9E142C", Offset = "0x9E142C", VA = "0x9E142C")]
		public RecipeViewInstantiator(GameObject template, GetItemModelsDelegate getItemModelsDelegate, SubTab inDefaultSubTab, CasualViewController viewController, ProductionPageView productionPageView)
		{
		}

		[Token(Token = "0x6002D05")]
		[Address(RVA = "0x9E1FF0", Offset = "0x9E1FF0", VA = "0x9E1FF0", Slot = "4")]
		public override bool ShouldInstantiate(ISubTabItemModel itemModel)
		{
			return default(bool);
		}

		[Token(Token = "0x6002D06")]
		[Address(RVA = "0x9E20C8", Offset = "0x9E20C8", VA = "0x9E20C8", Slot = "5")]
		protected override void Setup(GameObject newGameObject, ISubTabItemModel itemModel)
		{
		}
	}

	[Token(Token = "0x2000626")]
	private class SubstanceViewInstantiator : ItemModelViewInstantiator
	{
		[Token(Token = "0x4001E4F")]
		[FieldOffset(Offset = "0x38")]
		private CasualViewController m_viewController;

		[Token(Token = "0x6002D07")]
		[Address(RVA = "0x9E155C", Offset = "0x9E155C", VA = "0x9E155C")]
		public SubstanceViewInstantiator(GameObject template, GetItemModelsDelegate getItemModelsDelegate, SubTab inDefaultSubTab, CasualViewController viewController)
		{
		}

		[Token(Token = "0x6002D08")]
		[Address(RVA = "0x9E227C", Offset = "0x9E227C", VA = "0x9E227C", Slot = "5")]
		protected override void Setup(GameObject newGameObject, ISubTabItemModel itemModel)
		{
		}
	}

	[Token(Token = "0x400043C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_recipeViewTemplate;

	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject m_substanceViewTemplate;

	[Token(Token = "0x400043E")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x822C00", Offset = "0x822C00")]
	private SubTabsView m_subTabsView;

	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0x50")]
	private Vector3[] m_scrollViewCorners;

	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0x58")]
	private List<RecipeView> m_recipeViews;

	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0x60")]
	private UkenUnsubscriber<UntouchedUIMessage> m_recipeSignalHandle;

	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x68")]
	private UkenUnsubscriber<UntouchedUIMessage> m_inventoryRecipeSignalHandle;

	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0x70")]
	private UkenUnsubscriber<UntouchedUIMessage> m_inventoryTagSignalHandle;

	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x78")]
	private UkenUnsubscriber<UntouchedUIMessage> m_unlockerSignalHandle;

	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0x80")]
	private UkenUnsubscriber<UntouchedUIMessage> m_dyesSignalHandle;

	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0x88")]
	private UntouchedUIMessage m_latestRecipeUIMessage;

	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0x90")]
	private UntouchedUIMessage m_latestUnlockerUIMessage;

	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0x98")]
	private bool m_rebuildSubstanceSubTab;

	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0xA0")]
	private SubTab m_substanceSubTab;

	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0xA8")]
	private RecipeController m_recipeController;

	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0xB0")]
	private FTUEController m_ftueController;

	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0xB8")]
	private ConstructionController m_constructionController;

	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0xC0")]
	private AM2InventoryController m_inventoryController;

	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0xC8")]
	private UIAlertController m_uiAlertController;

	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0xD0")]
	private ProfilePageController m_profilePageController;

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x9E0D7C", Offset = "0x9E0D7C", VA = "0x9E0D7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x9E1610", Offset = "0x9E1610", VA = "0x9E1610", Slot = "4")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x9E1708", Offset = "0x9E1708", VA = "0x9E1708")]
	public float GetScrollViewBottom()
	{
		return default(float);
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x9E174C", Offset = "0x9E174C", VA = "0x9E174C")]
	public float GetScrollViewTop()
	{
		return default(float);
	}

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x9E1798", Offset = "0x9E1798", VA = "0x9E1798")]
	public void SetupScrollViewCorners()
	{
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x9E17D4", Offset = "0x9E17D4", VA = "0x9E17D4", Slot = "6")]
	public override void OnTogglePageOff()
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x9E158C", Offset = "0x9E158C", VA = "0x9E158C")]
	private void BuildItemViews()
	{
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x9E181C", Offset = "0x9E181C", VA = "0x9E181C")]
	private void AddRecipeViewToList(RecipeView recipeView)
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x9E18D0", Offset = "0x9E18D0", VA = "0x9E18D0")]
	public void OnOpenTray(RecipeView recipeView)
	{
	}

	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x9E1D34", Offset = "0x9E1D34", VA = "0x9E1D34", Slot = "7")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CUntouchedUIMessage_003E_002EOnEmit(UntouchedUIMessage message)
	{
	}

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x9E1F2C", Offset = "0x9E1F2C", VA = "0x9E1F2C")]
	protected void Update()
	{
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x9E1EB0", Offset = "0x9E1EB0", VA = "0x9E1EB0")]
	private void RefreshRedDotNotifications()
	{
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x9E1F80", Offset = "0x9E1F80", VA = "0x9E1F80")]
	public ProductionPageView()
	{
	}
}
