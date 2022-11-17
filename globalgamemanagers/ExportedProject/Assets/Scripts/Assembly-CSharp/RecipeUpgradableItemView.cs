using System;
using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using UnityEngine;
using Utilities;

[Token(Token = "0x2000104")]
public class RecipeUpgradableItemView : UnlockableRecipeComponentView, IResearchableItemView
{
	[Token(Token = "0x4000600")]
	private const float c_delayToShowAutoBuy = 0.2f;

	[Token(Token = "0x4000601")]
	private const float c_delayToAutoBuy = 0.7f;

	[Token(Token = "0x4000602")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x823BF4", Offset = "0x823BF4")]
	private IResearchable _003Cresearchable_003Ek__BackingField;

	[Token(Token = "0x4000603")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected AM2Text m_titleText;

	[Token(Token = "0x4000604")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected AM2Text m_increaseAmountText;

	[Token(Token = "0x4000605")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected AM2Text m_levelText;

	[Token(Token = "0x4000606")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected GameObject m_costViewTemplate;

	[Token(Token = "0x4000607")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected Transform m_costViewsContainer;

	[Token(Token = "0x4000608")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<CostItemView> m_costViews;

	[Token(Token = "0x4000609")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	protected AM2Button m_upgradeButton;

	[Token(Token = "0x400060A")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	protected ProgressBar bonusProgressBar;

	[Token(Token = "0x400060B")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform m_progressContainer;

	[Token(Token = "0x400060C")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject m_progressViewTemplate;

	[Token(Token = "0x400060D")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	protected GameObject m_autoBuyContainer;

	[Token(Token = "0x400060E")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	protected ProgressBar autoBuyProgressBar;

	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0xA8")]
	protected float m_timeRemainingToShowAutoBuy;

	[Token(Token = "0x4000610")]
	[FieldOffset(Offset = "0xAC")]
	protected float m_timeRemainingToAutoBuy;

	[Token(Token = "0x4000611")]
	[FieldOffset(Offset = "0xB0")]
	protected bool m_buttonPressed;

	[Token(Token = "0x4000612")]
	[FieldOffset(Offset = "0xB1")]
	protected bool m_performedAutoBuy;

	[Token(Token = "0x4000613")]
	[FieldOffset(Offset = "0xB2")]
	protected bool m_didShowAutoBuyContainer;

	[Token(Token = "0x4000614")]
	[FieldOffset(Offset = "0xB8")]
	protected BuyDisplayInfo m_displayInfo;

	[Token(Token = "0x4000615")]
	[FieldOffset(Offset = "0xE8")]
	protected IResearchableView m_parentResearchView;

	[Token(Token = "0x4000616")]
	[FieldOffset(Offset = "0xF0")]
	protected Upgradable m_upgradable;

	[Token(Token = "0x4000617")]
	[FieldOffset(Offset = "0xF8")]
	protected QuantityTrackingProgressView m_quantityTrackingView;

	[Token(Token = "0x4000618")]
	[FieldOffset(Offset = "0x100")]
	protected ConstructionController m_constructionController;

	[Token(Token = "0x4000619")]
	[FieldOffset(Offset = "0x108")]
	protected ResearchController m_researchController;

	[Token(Token = "0x400061A")]
	[FieldOffset(Offset = "0x110")]
	protected Localizations m_localizationController;

	[Token(Token = "0x400061B")]
	[FieldOffset(Offset = "0x118")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x400061C")]
	[FieldOffset(Offset = "0x120")]
	private ObjectPoolController m_objectPoolController;

	[Token(Token = "0x170000E3")]
	public IResearchable researchable
	{
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x9ED5D0", Offset = "0x9ED5D0", VA = "0x9ED5D0", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834070", Offset = "0x834070")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x9EFE04", Offset = "0x9EFE04", VA = "0x9EFE04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834080", Offset = "0x834080")]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<float, bool> OnUpgrade
	{
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x9DB644", Offset = "0x9DB644", VA = "0x9DB644")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834090", Offset = "0x834090")]
		add
		{
		}
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x9EFE0C", Offset = "0x9EFE0C", VA = "0x9EFE0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8340A0", Offset = "0x8340A0")]
		remove
		{
		}
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x9EFEFC", Offset = "0x9EFEFC", VA = "0x9EFEFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x9F0074", Offset = "0x9F0074", VA = "0x9F0074")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x9ECD74", Offset = "0x9ECD74", VA = "0x9ECD74", Slot = "9")]
	public virtual void Initialize(IResearchableView parentResearchView, Upgradable upgradeable)
	{
	}

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x9F0358", Offset = "0x9F0358", VA = "0x9F0358")]
	public long GetLevel()
	{
		return default(long);
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x9DCC6C", Offset = "0x9DCC6C", VA = "0x9DCC6C")]
	public long? GetCostItemThreshold(string costItemRef)
	{
		return null;
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x9F0388", Offset = "0x9F0388", VA = "0x9F0388")]
	private void DespawnCostViews()
	{
	}

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x9F01EC", Offset = "0x9F01EC", VA = "0x9F01EC")]
	private void SpawnCostViews()
	{
	}

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x9F0498", Offset = "0x9F0498", VA = "0x9F0498")]
	private void AddRequirementsFromDict(Dictionary<string, long> dict, string format, bool isShowLevel)
	{
	}

	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x9F077C", Offset = "0x9F077C", VA = "0x9F077C", Slot = "5")]
	public override void SetViewActive(bool active)
	{
	}

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x9F07F8", Offset = "0x9F07F8", VA = "0x9F07F8")]
	private void SetQuantityTrackingViewActive(bool active)
	{
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x9F0958", Offset = "0x9F0958", VA = "0x9F0958", Slot = "6")]
	public override bool RefreshRedDotNotification(HashSet<string> untouchedUnlockers)
	{
		return default(bool);
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x9F09E4", Offset = "0x9F09E4", VA = "0x9F09E4", Slot = "10")]
	public virtual void RefreshView()
	{
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x9F0ED4", Offset = "0x9F0ED4", VA = "0x9F0ED4")]
	protected void OnButtonClicked()
	{
	}

	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x9F130C", Offset = "0x9F130C", VA = "0x9F130C")]
	protected void OnButtonPressed()
	{
	}

	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x9F1350", Offset = "0x9F1350", VA = "0x9F1350")]
	protected void OnButtonReleased()
	{
	}

	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x9F0FEC", Offset = "0x9F0FEC", VA = "0x9F0FEC")]
	protected void OnResearchPurchased(long levelBeforeUpgrade)
	{
	}

	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x9F1398", Offset = "0x9F1398", VA = "0x9F1398")]
	private void Update()
	{
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x9ED5D8", Offset = "0x9ED5D8", VA = "0x9ED5D8")]
	protected void UpdateInteractability()
	{
	}

	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x9F13BC", Offset = "0x9F13BC", VA = "0x9F13BC")]
	protected void UpdateAutoBuy()
	{
	}

	[Token(Token = "0x6000700")]
	[Address(RVA = "0x9ED6F0", Offset = "0x9ED6F0", VA = "0x9ED6F0")]
	public RecipeUpgradableItemView()
	{
	}
}
