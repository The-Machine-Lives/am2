using System;
using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Observe;
using UnityEngine;
using Utilities;

[Token(Token = "0x200010A")]
public class ResearchablesStoreView : ResearchablesView, IUkenObserver<List<StoreInventoryItem>>
{
	[Token(Token = "0x2000629")]
	private class ItemConverterViewInstantiator : ItemModelViewInstantiator
	{
		[Token(Token = "0x4001E55")]
		[FieldOffset(Offset = "0x38")]
		private VolumeMultiplierView m_volumeMultiplierView;

		[Token(Token = "0x4001E56")]
		[FieldOffset(Offset = "0x40")]
		private CasualViewController m_viewController;

		[Token(Token = "0x6002D12")]
		[Address(RVA = "0x9FA834", Offset = "0x9FA834", VA = "0x9FA834")]
		public ItemConverterViewInstantiator(GameObject template, GetItemModelsDelegate getItemModelsDelegate, SubTab inDefaultSubTab, CasualViewController viewController, VolumeMultiplierView volumeMultiplierView)
		{
		}

		[Token(Token = "0x6002D13")]
		[Address(RVA = "0x9FA870", Offset = "0x9FA870", VA = "0x9FA870", Slot = "5")]
		protected override void Setup(GameObject newGameObject, ISubTabItemModel itemModel)
		{
		}
	}

	[Token(Token = "0x200062A")]
	protected class AdItemViewInstantiator : ItemModelViewInstantiator
	{
		[Token(Token = "0x4001E57")]
		[FieldOffset(Offset = "0x38")]
		private VIPStatusView m_vipStatusView;

		[Token(Token = "0x4001E58")]
		[FieldOffset(Offset = "0x40")]
		private bool m_updateButtonStateBasedOnCost;

		[Token(Token = "0x4001E59")]
		[FieldOffset(Offset = "0x48")]
		private CasualViewController m_viewController;

		[Token(Token = "0x6002D14")]
		[Address(RVA = "0x9FA4DC", Offset = "0x9FA4DC", VA = "0x9FA4DC")]
		public AdItemViewInstantiator(GameObject template, GetItemModelsDelegate getItemModelsDelegate, SubTab inDefaultSubTab, CasualViewController viewController, bool updateButtonStateBasedOnCost, VIPStatusView vipStatusView)
		{
		}

		[Token(Token = "0x6002D15")]
		[Address(RVA = "0x9FA544", Offset = "0x9FA544", VA = "0x9FA544", Slot = "5")]
		protected override void Setup(GameObject newGameObject, ISubTabItemModel itemModel)
		{
		}
	}

	[Token(Token = "0x200062B")]
	protected class IAPItemViewInstantiator : ItemModelViewInstantiator
	{
		[Token(Token = "0x4001E5A")]
		[FieldOffset(Offset = "0x38")]
		private CasualViewController m_viewController;

		[Token(Token = "0x4001E5B")]
		[FieldOffset(Offset = "0x40")]
		private VIPStatusView m_vipStatusView;

		[Token(Token = "0x6002D16")]
		[Address(RVA = "0x9FA690", Offset = "0x9FA690", VA = "0x9FA690")]
		public IAPItemViewInstantiator(GameObject template, GetItemModelsDelegate getItemModelsDelegate, SubTab inDefaultSubTab, CasualViewController viewController, VIPStatusView vipStatusView)
		{
		}

		[Token(Token = "0x6002D17")]
		[Address(RVA = "0x9FA6E4", Offset = "0x9FA6E4", VA = "0x9FA6E4", Slot = "5")]
		protected override void Setup(GameObject newGameObject, ISubTabItemModel itemModel)
		{
		}
	}

	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	protected GameObject m_itemConverterViewTemplate;

	[Token(Token = "0x4000683")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	protected VolumeMultiplierView m_volumeMultiplierView;

	[Token(Token = "0x4000684")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private VIPStatusView m_vipSatusView;

	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0x128")]
	private ResearchController m_researchController;

	[Token(Token = "0x4000686")]
	[FieldOffset(Offset = "0x130")]
	private ObjectPoolController m_objectPoolController;

	[Token(Token = "0x4000687")]
	[FieldOffset(Offset = "0x138")]
	private FTUEController m_ftueController;

	[Token(Token = "0x4000688")]
	[FieldOffset(Offset = "0x140")]
	private AdConfigs m_adConfigs;

	[Token(Token = "0x4000689")]
	[FieldOffset(Offset = "0x148")]
	private Features m_features;

	[Token(Token = "0x400068A")]
	[FieldOffset(Offset = "0x150")]
	private Stores m_allStores;

	[Token(Token = "0x400068B")]
	[FieldOffset(Offset = "0x158")]
	private UkenUnsubscriber<List<StoreInventoryItem>> m_storeUnsubscriber;

	[Token(Token = "0x6000746")]
	[Address(RVA = "0x9F8958", Offset = "0x9F8958", VA = "0x9F8958", Slot = "18")]
	public override void Initialize(CasualViewController parentController, int slotIndex, EBuyType buyType)
	{
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0x9F8CE4", Offset = "0x9F8CE4", VA = "0x9F8CE4", Slot = "19")]
	protected override void RegisterInstantiators()
	{
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0x9F8FBC", Offset = "0x9F8FBC", VA = "0x9F8FBC", Slot = "13")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0x9F901C", Offset = "0x9F901C", VA = "0x9F901C")]
	private List<AdConfig> GetAllAds()
	{
		return null;
	}

	[Token(Token = "0x600074A")]
	[Address(RVA = "0x9F904C", Offset = "0x9F904C", VA = "0x9F904C")]
	private List<StoreItem> GetAllIAP()
	{
		return null;
	}

	[Token(Token = "0x600074B")]
	[Address(RVA = "0x9F90FC", Offset = "0x9F90FC", VA = "0x9F90FC", Slot = "21")]
	public override void RebuildItemViews()
	{
	}

	[Token(Token = "0x600074C")]
	[Address(RVA = "0x9F9158", Offset = "0x9F9158", VA = "0x9F9158", Slot = "22")]
	public override void OnSelectResearch(IResearchableItemView researchableItem)
	{
	}

	[Token(Token = "0x600074D")]
	[Address(RVA = "0x9F928C", Offset = "0x9F928C", VA = "0x9F928C", Slot = "11")]
	protected override void OnHideFinished(Action onHideComplete)
	{
	}

	[Token(Token = "0x600074E")]
	[Address(RVA = "0x9F9310", Offset = "0x9F9310", VA = "0x9F9310")]
	private void Update()
	{
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0x9F9448", Offset = "0x9F9448", VA = "0x9F9448", Slot = "23")]
	public void OnEmit(List<StoreInventoryItem> value)
	{
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0x9F94D4", Offset = "0x9F94D4", VA = "0x9F94D4")]
	public ResearchablesStoreView()
	{
	}
}
