using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x200010B")]
public class ResearchablesView : CasualView, IResearchableView
{
	[Token(Token = "0x200062C")]
	protected class ResearchableItemViewInstantiator : ItemModelViewInstantiator
	{
		[Token(Token = "0x4001E5C")]
		[FieldOffset(Offset = "0x38")]
		private ResearchablesView m_researchablesView;

		[Token(Token = "0x4001E5D")]
		[FieldOffset(Offset = "0x40")]
		private bool m_updateButtonStateBasedOnCost;

		[Token(Token = "0x4001E5E")]
		[FieldOffset(Offset = "0x48")]
		private CasualViewController m_viewController;

		[Token(Token = "0x6002D18")]
		[Address(RVA = "0x9FADDC", Offset = "0x9FADDC", VA = "0x9FADDC")]
		public ResearchableItemViewInstantiator(GameObject template, GetItemModelsDelegate getItemModelsDelegate, SubTab inDefaultSubTab, CasualViewController viewController, ResearchablesView researchablesView, bool updateButtonStateBasedOnCost)
		{
		}

		[Token(Token = "0x6002D19")]
		[Address(RVA = "0x9FBCAC", Offset = "0x9FBCAC", VA = "0x9FBCAC", Slot = "5")]
		protected override void Setup(GameObject newGameObject, ISubTabItemModel itemModel)
		{
		}
	}

	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	protected SubTabsView m_subTabsView;

	[Token(Token = "0x400068D")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	protected GameObject m_researchableItemViewTemplate;

	[Token(Token = "0x400068E")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	protected GameObject m_adsItemViewTemplate;

	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	protected GameObject m_iapItemViewTemplate;

	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0xE0")]
	protected IResearchableItemView m_currentResearchableItemView;

	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0xE8")]
	protected bool m_updateButtonStateBasedOnCost;

	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0xF0")]
	protected ConstructionController m_constructionController;

	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0xF8")]
	protected UIAlertController m_uiAlertController;

	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x100")]
	protected int m_slotIndex;

	[Token(Token = "0x4000695")]
	[FieldOffset(Offset = "0x104")]
	protected bool m_hideOnSelect;

	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x108")]
	protected EBuyType m_buyType;

	[Token(Token = "0x6000751")]
	[Address(RVA = "0x9FA9A4", Offset = "0x9FA9A4", VA = "0x9FA9A4", Slot = "18")]
	public virtual void Initialize(CasualViewController parentController, int slotIndex, EBuyType buyType)
	{
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0x9FACB4", Offset = "0x9FACB4", VA = "0x9FACB4", Slot = "19")]
	protected virtual void RegisterInstantiators()
	{
	}

	[Token(Token = "0x6000753")]
	[Address(RVA = "0x9FAEDC", Offset = "0x9FAEDC", VA = "0x9FAEDC", Slot = "20")]
	public virtual void OnHidePage()
	{
	}

	[Token(Token = "0x6000754")]
	[Address(RVA = "0x9FB058", Offset = "0x9FB058", VA = "0x9FB058")]
	private List<IResearchable> GetAllResearchables()
	{
		return null;
	}

	[Token(Token = "0x6000755")]
	[Address(RVA = "0x9FB090", Offset = "0x9FB090", VA = "0x9FB090", Slot = "21")]
	public virtual void RebuildItemViews()
	{
	}

	[Token(Token = "0x6000756")]
	[Address(RVA = "0x9FBAEC", Offset = "0x9FBAEC", VA = "0x9FBAEC", Slot = "22")]
	public virtual void OnSelectResearch(IResearchableItemView researchableItem)
	{
	}

	[Token(Token = "0x6000757")]
	[Address(RVA = "0x9FBAF4", Offset = "0x9FBAF4", VA = "0x9FBAF4")]
	public bool RefreshRedDotNotification(HashSet<string> untouchedUnlockers, HashSet<string> untouchedItemRefs)
	{
		return default(bool);
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0x9FBCA0", Offset = "0x9FBCA0", VA = "0x9FBCA0", Slot = "17")]
	public void OnSelectResearchBulk(IResearchableItemView selectedItem)
	{
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0x9FBCA4", Offset = "0x9FBCA4", VA = "0x9FBCA4")]
	public ResearchablesView()
	{
	}
}
