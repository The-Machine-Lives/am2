using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using UnityEngine;
using Utilities;

[Token(Token = "0x20000D0")]
public class ItemConverterView : MonoBehaviour, IUkenObserver<List<Unlocker>>, IVolumeModeItem, ISubTabItemView
{
	[Token(Token = "0x4000380")]
	public const long c_TEMP_DEFAULT_MAX_CAP = 999L;

	[Token(Token = "0x4000381")]
	private const int c_confirmationRequiredForVolumeMultiplierThreshold = 100;

	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Text m_titleText;

	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Text m_giveText;

	[Token(Token = "0x4000384")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AM2Text m_inputItemNameText;

	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AM2Text m_inputItemPercentChangeText;

	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AM2Text m_getText;

	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AM2Text m_outputItemNameText;

	[Token(Token = "0x4000388")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AM2Text m_outputItemPercentChangeText;

	[Token(Token = "0x4000389")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AM2Text m_buttonText;

	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AM2Text m_maxedOutText;

	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AM2Button m_convertButton;

	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject m_redDotNotification;

	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject m_tagTextEffectTemplate;

	[Token(Token = "0x400038E")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject m_textEffectTemplate;

	[Token(Token = "0x400038F")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private RectTransform m_textTagSpawnArea;

	[Token(Token = "0x4000390")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private RectTransform m_textIncreaseSpawnArea;

	[Token(Token = "0x4000391")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private InfoPopupButton m_infoPopupButton;

	[Token(Token = "0x4000392")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8227C8", Offset = "0x8227C8")]
	private ItemConverter _003CitemConverter_003Ek__BackingField;

	[Token(Token = "0x4000393")]
	[FieldOffset(Offset = "0xA0")]
	private Item m_inputItem;

	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0xA8")]
	private Item m_outputItem;

	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_initialized;

	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0xB1")]
	private bool m_previousMaxedOut;

	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0xB2")]
	private bool m_previousEnoughInput;

	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0xB8")]
	private long m_previousInputQuantity;

	[Token(Token = "0x4000399")]
	[FieldOffset(Offset = "0xC0")]
	private long m_previousOutputQuantity;

	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0xC8")]
	private long m_previousOutputMaxCap;

	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0xD0")]
	private string m_localizedInputItem;

	[Token(Token = "0x400039C")]
	[FieldOffset(Offset = "0xD8")]
	private string m_localizedOutputItem;

	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0xE0")]
	private Recipe m_outputRecipe;

	[Token(Token = "0x400039E")]
	[FieldOffset(Offset = "0xE8")]
	private ProductionVolumeMode m_volumeMode;

	[Token(Token = "0x400039F")]
	[FieldOffset(Offset = "0xF0")]
	private long m_volumeMultiplier;

	[Token(Token = "0x40003A0")]
	[FieldOffset(Offset = "0xF8")]
	private TagItem m_tagItem;

	[Token(Token = "0x40003A1")]
	[FieldOffset(Offset = "0x100")]
	private RewardVisualizer m_rewardVisualizer;

	[Token(Token = "0x40003A2")]
	[FieldOffset(Offset = "0x108")]
	private UkenUnsubscriber<List<Unlocker>> m_ftueSignalHandle;

	[Token(Token = "0x40003A3")]
	[FieldOffset(Offset = "0x110")]
	private CasualViewController m_parentController;

	[Token(Token = "0x40003A4")]
	[FieldOffset(Offset = "0x118")]
	private FTUEController m_ftueController;

	[Token(Token = "0x40003A5")]
	[FieldOffset(Offset = "0x120")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x40003A6")]
	[FieldOffset(Offset = "0x128")]
	private ItemConverterController m_itemConverterController;

	[Token(Token = "0x40003A7")]
	[FieldOffset(Offset = "0x130")]
	private UIAlertController m_uiAlertController;

	[Token(Token = "0x40003A8")]
	[FieldOffset(Offset = "0x138")]
	private ObjectPoolController m_objectPoolController;

	[Token(Token = "0x40003A9")]
	[FieldOffset(Offset = "0x140")]
	private Localizations m_localizationController;

	[Token(Token = "0x40003AA")]
	[FieldOffset(Offset = "0x148")]
	private RecipeController m_recipeController;

	[Token(Token = "0x170000CF")]
	public ItemConverter itemConverter
	{
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x98E52C", Offset = "0x98E52C", VA = "0x98E52C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833E6C", Offset = "0x833E6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x98E534", Offset = "0x98E534", VA = "0x98E534")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833E7C", Offset = "0x833E7C")]
		private set
		{
		}
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x98E53C", Offset = "0x98E53C", VA = "0x98E53C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x98E624", Offset = "0x98E624", VA = "0x98E624")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x98E6E4", Offset = "0x98E6E4", VA = "0x98E6E4", Slot = "10")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x98E6F0", Offset = "0x98E6F0", VA = "0x98E6F0", Slot = "11")]
	public virtual void Unsubscribe()
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x98E74C", Offset = "0x98E74C", VA = "0x98E74C", Slot = "12")]
	public virtual void Initialize(ItemConverter inItemConverter, ProductionVolumeMode volumeMode, CasualViewController parentController)
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x98FB18", Offset = "0x98FB18", VA = "0x98FB18", Slot = "13")]
	protected virtual bool InitializeFTUEVisibility()
	{
		return default(bool);
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x98FB98", Offset = "0x98FB98", VA = "0x98FB98", Slot = "9")]
	public void OnHidePage()
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x98FB9C", Offset = "0x98FB9C", VA = "0x98FB9C")]
	private void MarkViewed()
	{
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x98F084", Offset = "0x98F084", VA = "0x98F084", Slot = "5")]
	public void OnChangeVolumeMode(ProductionVolumeMode volumeMode)
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x98F950", Offset = "0x98F950", VA = "0x98F950")]
	private void UpdateButtonText()
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x98FBF8", Offset = "0x98FBF8", VA = "0x98FBF8")]
	public void ShowRedDotNotification(bool show)
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x98FC30", Offset = "0x98FC30", VA = "0x98FC30", Slot = "14")]
	public virtual void OnEmit(List<Unlocker> unlockers)
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x98FD98", Offset = "0x98FD98", VA = "0x98FD98")]
	private void Update()
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0x98FD9C", Offset = "0x98FD9C", VA = "0x98FD9C")]
	private void CheckIfConfirmationIsRequiredToConvert()
	{
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0x9904EC", Offset = "0x9904EC", VA = "0x9904EC")]
	private void TryToConvert()
	{
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0x990800", Offset = "0x990800", VA = "0x990800")]
	private void ShowRandomRewardPopup(Dictionary<string, long> rewardGroupTransaction)
	{
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x990780", Offset = "0x990780", VA = "0x990780")]
	private void TryDisplayTags(Dictionary<string, long> rewardGroupTransaction)
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x98F0FC", Offset = "0x98F0FC", VA = "0x98F0FC")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0x990ED4", Offset = "0x990ED4", VA = "0x990ED4", Slot = "6")]
	public bool RefreshRedDotNotification(HashSet<string> untouchedUnlockers, HashSet<string> untouchedItemRefs)
	{
		return default(bool);
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0x990FB0", Offset = "0x990FB0", VA = "0x990FB0")]
	public ItemConverterView()
	{
	}

	[SpecialName]
	[Token(Token = "0x600052F")]
	[Address(RVA = "0x991028", Offset = "0x991028", VA = "0x991028", Slot = "7")]
	private GameObject ISubTabItemView_002Eget_gameObject()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000530")]
	[Address(RVA = "0x991030", Offset = "0x991030", VA = "0x991030", Slot = "8")]
	private Transform ISubTabItemView_002Eget_transform()
	{
		return null;
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x991038", Offset = "0x991038", VA = "0x991038")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833E8C", Offset = "0x833E8C")]
	private void _003CCheckIfConfirmationIsRequiredToConvert_003Eb__59_0()
	{
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x991088", Offset = "0x991088", VA = "0x991088")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833E9C", Offset = "0x833E9C")]
	private void _003CCheckIfConfirmationIsRequiredToConvert_003Eb__59_1()
	{
	}
}
