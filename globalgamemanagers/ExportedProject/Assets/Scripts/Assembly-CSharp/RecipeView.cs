using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Animation;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using Uken.Library.UkenTime;
using UnityEngine;
using Utilities;

[Token(Token = "0x2000105")]
public class RecipeView : MonoBehaviour, IUkenObserver<List<Unlocker>>, IResearchableView, ISubTabItemView
{
	[Token(Token = "0x400061E")]
	[FieldOffset(Offset = "0x18")]
	protected RecipeController m_recipeController;

	[Token(Token = "0x400061F")]
	[FieldOffset(Offset = "0x20")]
	protected ResearchController m_researchController;

	[Token(Token = "0x4000620")]
	[FieldOffset(Offset = "0x28")]
	protected FTUEController m_ftueController;

	[Token(Token = "0x4000621")]
	[FieldOffset(Offset = "0x30")]
	protected UkenTimeController m_time;

	[Token(Token = "0x4000622")]
	[FieldOffset(Offset = "0x38")]
	protected ConstructionItem m_constructionItem;

	[Token(Token = "0x4000623")]
	[FieldOffset(Offset = "0x40")]
	protected RecipeItem m_recipeItem;

	[Token(Token = "0x4000624")]
	[FieldOffset(Offset = "0x48")]
	protected InventoryController m_inventoryController;

	[Token(Token = "0x4000625")]
	[FieldOffset(Offset = "0x50")]
	protected ConstructionController m_constructionController;

	[Token(Token = "0x4000626")]
	[FieldOffset(Offset = "0x58")]
	protected Localizations m_localizationController;

	[Token(Token = "0x4000627")]
	[FieldOffset(Offset = "0x60")]
	protected CasualViewController m_parentController;

	[Token(Token = "0x4000628")]
	[FieldOffset(Offset = "0x68")]
	protected UIAlertController m_uiAlertController;

	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x823CD4", Offset = "0x823CD4")]
	private Recipe _003Crecipe_003Ek__BackingField;

	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x823CE4", Offset = "0x823CE4")]
	private bool _003CtrayOpen_003Ek__BackingField;

	[Token(Token = "0x400062B")]
	[FieldOffset(Offset = "0x80")]
	private UkenAnimFloat m_trayAnim;

	[Token(Token = "0x400062C")]
	[FieldOffset(Offset = "0x88")]
	protected float m_currentHeight;

	[Token(Token = "0x400062D")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	protected string m_speedTextFormat;

	[Token(Token = "0x400062E")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	protected Color m_flashColor;

	[Token(Token = "0x400062F")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	protected float m_flashAnimDuration;

	[Token(Token = "0x4000630")]
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	protected float m_trayAnimDuration;

	[Token(Token = "0x4000631")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	protected float m_openTraySize;

	[Token(Token = "0x4000632")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	protected float m_closedTraySize;

	[Token(Token = "0x4000633")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	protected RectTransform m_contentTransform;

	[Token(Token = "0x4000634")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	protected DropdownButton m_trayButton;

	[Token(Token = "0x4000635")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	protected GameObject m_trayButtonNotification;

	[Token(Token = "0x4000636")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	protected RectTransform m_trayParent;

	[Token(Token = "0x4000637")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	protected AM2Text m_titleText;

	[Token(Token = "0x4000638")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	protected AM2Text m_quantityText;

	[Token(Token = "0x4000639")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	protected AM2Text m_cyclesPerSecondText;

	[Token(Token = "0x400063A")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	protected AM2Text m_volumeText;

	[Token(Token = "0x400063B")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	protected AM2Text m_maxCapText;

	[Token(Token = "0x400063C")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	protected AM2Text m_sustainText;

	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	protected AM2Text m_speedBoosterText;

	[Token(Token = "0x400063E")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	protected AM2Text m_volumeBoosterText;

	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	protected AM2Text m_maxCapBoosterText;

	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	protected ProgressBar m_quantityBar;

	[Token(Token = "0x4000641")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	protected ProgressBar m_unitProgressBar;

	[Token(Token = "0x4000642")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	protected ProgressBar m_sustainBar;

	[Token(Token = "0x4000643")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	protected GameObject m_rateSliderContainer;

	[Token(Token = "0x4000644")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	protected ProgressBar m_rateSliderBar;

	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	protected AM2Slider m_rateSlider;

	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	protected RecipeDifferentialView m_differentialView;

	[Token(Token = "0x4000647")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	protected AM2Button m_generateButton;

	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	protected RecipeUpgradableItemView m_upgradeMaxCapView;

	[Token(Token = "0x4000649")]
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	protected RecipeUpgradableItemView m_upgradeSpeedView;

	[Token(Token = "0x400064A")]
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	protected RecipeUpgradableItemView m_upgradeVolumeView;

	[Token(Token = "0x400064B")]
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	protected RecipeUpgradableItemView m_upgradeSustainTimeView;

	[Token(Token = "0x400064C")]
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	protected RecipeBoosterView m_boosterView;

	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	private GameObject m_redDotNotification;

	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x190")]
	[SerializeField]
	private Transform m_ingredientsList;

	[Token(Token = "0x400064F")]
	[FieldOffset(Offset = "0x198")]
	[SerializeField]
	private GameObject m_ingredientListItemTemplate;

	[Token(Token = "0x4000650")]
	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	private Transform m_ingredientsProgressContainer;

	[Token(Token = "0x4000651")]
	[FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	private GameObject m_ingredientProgressTemplate;

	[Token(Token = "0x4000652")]
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	private GameObject m_textEffectTemplate;

	[Token(Token = "0x4000653")]
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	private RectTransform m_textIncreaseSpawnArea;

	[Token(Token = "0x4000654")]
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	private GameObject m_upgradablesContainer;

	[Token(Token = "0x4000655")]
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	private InfoPopupButton m_infoPopupButton;

	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	private int m_poolSize;

	[Token(Token = "0x4000657")]
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	private List<MonoBehaviour> m_toggleableTrayComponents;

	[Token(Token = "0x4000658")]
	[FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	private List<GameObject> m_toggleableTrayObjects;

	[Token(Token = "0x4000659")]
	[FieldOffset(Offset = "0x1E8")]
	private List<IngredientView> m_ingredientViews;

	[Token(Token = "0x400065A")]
	[FieldOffset(Offset = "0x1F0")]
	private List<QuantityTrackingProgressView> m_quantityTrackingViews;

	[Token(Token = "0x400065B")]
	[FieldOffset(Offset = "0x1F8")]
	protected bool m_initialized;

	[Token(Token = "0x400065C")]
	[FieldOffset(Offset = "0x1F9")]
	protected bool m_displaySpeedAsSecondsOnly;

	[Token(Token = "0x400065D")]
	[FieldOffset(Offset = "0x200")]
	protected double m_previousCyclesPerSecond;

	[Token(Token = "0x400065E")]
	[FieldOffset(Offset = "0x208")]
	protected long m_previousQuantity;

	[Token(Token = "0x400065F")]
	[FieldOffset(Offset = "0x210")]
	protected long m_previousMaxCap;

	[Token(Token = "0x4000660")]
	[FieldOffset(Offset = "0x218")]
	protected long m_previousMaxCapBoost;

	[Token(Token = "0x4000661")]
	[FieldOffset(Offset = "0x220")]
	protected long m_previousVolume;

	[Token(Token = "0x4000662")]
	[FieldOffset(Offset = "0x228")]
	protected long m_previousVolumeBoost;

	[Token(Token = "0x4000663")]
	[FieldOffset(Offset = "0x230")]
	protected long m_previousSustainTimeInSeconds;

	[Token(Token = "0x4000664")]
	[FieldOffset(Offset = "0x238")]
	protected double m_previousSpeedPercentUp;

	[Token(Token = "0x4000665")]
	[FieldOffset(Offset = "0x240")]
	protected float m_previousContentTransformHeight;

	[Token(Token = "0x4000666")]
	[FieldOffset(Offset = "0x244")]
	private bool m_IsShowTextEffect;

	[Token(Token = "0x4000667")]
	[FieldOffset(Offset = "0x245")]
	private bool m_isResizeDeferred;

	[Token(Token = "0x4000668")]
	[FieldOffset(Offset = "0x248")]
	private ProductionPageView m_parentPageView;

	[Token(Token = "0x4000669")]
	[FieldOffset(Offset = "0x250")]
	private UkenUnsubscriber<List<Unlocker>> m_ftueSignalHandle;

	[Token(Token = "0x400066A")]
	[FieldOffset(Offset = "0x258")]
	private Color m_mainColor;

	[Token(Token = "0x400066B")]
	[FieldOffset(Offset = "0x268")]
	private Color m_secondaryColor;

	[Token(Token = "0x400066C")]
	[FieldOffset(Offset = "0x278")]
	protected List<RecipeUpgradableItemView> m_upgradableItemViews;

	[Token(Token = "0x400066D")]
	[FieldOffset(Offset = "0x280")]
	private ObjectPoolController m_objectPoolController;

	[Token(Token = "0x400066E")]
	[FieldOffset(Offset = "0x288")]
	private EquipmentController m_equipmentController;

	[Token(Token = "0x400066F")]
	[FieldOffset(Offset = "0x290")]
	private string m_uiPreferencesKey;

	[Token(Token = "0x170000E4")]
	public Recipe recipe
	{
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x9F15A8", Offset = "0x9F15A8", VA = "0x9F15A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8340B0", Offset = "0x8340B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x9F15B0", Offset = "0x9F15B0", VA = "0x9F15B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8340C0", Offset = "0x8340C0")]
		private set
		{
		}
	}

	[Token(Token = "0x170000E5")]
	public bool trayOpen
	{
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x9F15B8", Offset = "0x9F15B8", VA = "0x9F15B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8340D0", Offset = "0x8340D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x9F15C0", Offset = "0x9F15C0", VA = "0x9F15C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8340E0", Offset = "0x8340E0")]
		protected set
		{
		}
	}

	[Token(Token = "0x6000705")]
	[Address(RVA = "0x9F15CC", Offset = "0x9F15CC", VA = "0x9F15CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000706")]
	[Address(RVA = "0x9F1798", Offset = "0x9F1798", VA = "0x9F1798")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000707")]
	[Address(RVA = "0x9F1908", Offset = "0x9F1908", VA = "0x9F1908", Slot = "11")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x6000708")]
	[Address(RVA = "0x9DB734", Offset = "0x9DB734", VA = "0x9DB734", Slot = "12")]
	public virtual void Initialize(Recipe inRecipe, ConstructionItem constructionItem, RecipeItem recipeItem, ProductionPageView parentPageView, CasualViewController viewController)
	{
	}

	[Token(Token = "0x6000709")]
	[Address(RVA = "0x9F1938", Offset = "0x9F1938", VA = "0x9F1938")]
	private void InitializeRegents()
	{
	}

	[Token(Token = "0x600070A")]
	[Address(RVA = "0x9F1FBC", Offset = "0x9F1FBC", VA = "0x9F1FBC", Slot = "13")]
	protected virtual bool InitializeFTUEVisibility()
	{
		return default(bool);
	}

	[Token(Token = "0x600070B")]
	[Address(RVA = "0x9DC3B8", Offset = "0x9DC3B8", VA = "0x9DC3B8", Slot = "14")]
	protected virtual void ShowUpgradesContainer(bool show)
	{
	}

	[Token(Token = "0x600070C")]
	[Address(RVA = "0x9F214C", Offset = "0x9F214C", VA = "0x9F214C")]
	protected bool SetupUpgradabledLocked(RecipeUpgradableItemView view)
	{
		return default(bool);
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0x9F2218", Offset = "0x9F2218", VA = "0x9F2218", Slot = "15")]
	public virtual void OnHidePage()
	{
	}

	[Token(Token = "0x600070E")]
	[Address(RVA = "0x9F2338", Offset = "0x9F2338", VA = "0x9F2338")]
	public void ToggleTrayOpen()
	{
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0x9F234C", Offset = "0x9F234C", VA = "0x9F234C")]
	private void StopTrayAnimation()
	{
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0x9E1A04", Offset = "0x9E1A04", VA = "0x9E1A04")]
	public void OpenTray(bool open, bool animate = true)
	{
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0x9F237C", Offset = "0x9F237C", VA = "0x9F237C")]
	private void OnTrayOpenStart()
	{
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0x9F2810", Offset = "0x9F2810", VA = "0x9F2810")]
	private void OnTrayCloseComplete()
	{
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0x9F1E70", Offset = "0x9F1E70", VA = "0x9F1E70")]
	private void EnableTrayObjects(bool enableTrayObjects)
	{
	}

	[Token(Token = "0x6000714")]
	[Address(RVA = "0x9F23AC", Offset = "0x9F23AC", VA = "0x9F23AC")]
	private void OnUpdateViewHeight(float height)
	{
	}

	[Token(Token = "0x6000715")]
	[Address(RVA = "0x9F2840", Offset = "0x9F2840", VA = "0x9F2840")]
	private void ShowRedDotNotification(bool show)
	{
	}

	[Token(Token = "0x6000716")]
	[Address(RVA = "0x9F28F0", Offset = "0x9F28F0", VA = "0x9F28F0", Slot = "16")]
	public virtual void Unsubscribe()
	{
	}

	[Token(Token = "0x6000717")]
	[Address(RVA = "0x9F294C", Offset = "0x9F294C", VA = "0x9F294C", Slot = "17")]
	public virtual void OnEmit(List<Unlocker> unlockers)
	{
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0x9F2C9C", Offset = "0x9F2C9C", VA = "0x9F2C9C")]
	private void OnResizedContent()
	{
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0x9F2D44", Offset = "0x9F2D44", VA = "0x9F2D44")]
	protected void Update()
	{
	}

	[Token(Token = "0x600071A")]
	[Address(RVA = "0x9F2D74", Offset = "0x9F2D74", VA = "0x9F2D74")]
	private void UpdateContentSize()
	{
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0x9F2EC4", Offset = "0x9F2EC4", VA = "0x9F2EC4")]
	public void OnPressedGenerateButton()
	{
	}

	[Token(Token = "0x600071C")]
	[Address(RVA = "0x9DC734", Offset = "0x9DC734", VA = "0x9DC734", Slot = "18")]
	protected virtual void UpdateView()
	{
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0x9F3DC8", Offset = "0x9F3DC8", VA = "0x9F3DC8")]
	private void UpdateGenerateButton(long recipeMaxCap)
	{
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0x9F2FDC", Offset = "0x9F2FDC", VA = "0x9F2FDC")]
	private void UpdateSpeedTexts()
	{
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0x9F32E4", Offset = "0x9F32E4", VA = "0x9F32E4")]
	private void UpdateVolumeTexts()
	{
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0x9F3F30", Offset = "0x9F3F30", VA = "0x9F3F30")]
	private void UpdateRegents()
	{
	}

	[Token(Token = "0x6000721")]
	[Address(RVA = "0x9F3598", Offset = "0x9F3598", VA = "0x9F3598")]
	private void UpdateMaxCapTexts()
	{
	}

	[Token(Token = "0x6000722")]
	[Address(RVA = "0x9F3BD0", Offset = "0x9F3BD0", VA = "0x9F3BD0")]
	private void UpdateSustainTexts()
	{
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0x9F1CEC", Offset = "0x9F1CEC", VA = "0x9F1CEC")]
	private void OnAutoGenerationRefreshed()
	{
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0x9F4178", Offset = "0x9F4178", VA = "0x9F4178")]
	public void OnSliderUpdated()
	{
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0x9F4288", Offset = "0x9F4288", VA = "0x9F4288", Slot = "19")]
	public virtual void OnSelectResearch(IResearchableItemView researchableItem)
	{
	}

	[Token(Token = "0x6000726")]
	[Address(RVA = "0x9F45C0", Offset = "0x9F45C0", VA = "0x9F45C0", Slot = "20")]
	public virtual void OnSelectResearchBulk(IResearchableItemView researchableItem)
	{
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0x9F43A4", Offset = "0x9F43A4", VA = "0x9F43A4")]
	private void RefreshViewFromResearchSelect(IResearchableItemView researchableItem, double previousCyclesPerSecond)
	{
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0x9F47D8", Offset = "0x9F47D8", VA = "0x9F47D8", Slot = "21")]
	public virtual bool RefreshRedDotNotification(HashSet<string> untouchedUnlockers, HashSet<string> untouchedItemRefs)
	{
		return default(bool);
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0x9DCE08", Offset = "0x9DCE08", VA = "0x9DCE08")]
	public RecipeView()
	{
	}

	[SpecialName]
	[Token(Token = "0x600072A")]
	[Address(RVA = "0x9F49B4", Offset = "0x9F49B4", VA = "0x9F49B4", Slot = "8")]
	private GameObject ISubTabItemView_002Eget_gameObject()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x600072B")]
	[Address(RVA = "0x9F49BC", Offset = "0x9F49BC", VA = "0x9F49BC", Slot = "9")]
	private Transform ISubTabItemView_002Eget_transform()
	{
		return null;
	}
}
