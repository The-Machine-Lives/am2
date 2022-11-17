using System;
using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using UnityEngine;
using Utilities;

[Token(Token = "0x2000117")]
public class SpeedBoosterPopupView : CasualView
{
	[Serializable]
	[Token(Token = "0x200062E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820468", Offset = "0x820468")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001E61")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001E62")]
		[FieldOffset(Offset = "0x8")]
		public static Func<SpeedBooster, SpeedBooster> _003C_003E9__22_0;

		[Token(Token = "0x4001E63")]
		[FieldOffset(Offset = "0x10")]
		public static Func<SpeedBooster, bool> _003C_003E9__23_1;

		[Token(Token = "0x6002D1D")]
		[Address(RVA = "0xA06AEC", Offset = "0xA06AEC", VA = "0xA06AEC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002D1E")]
		[Address(RVA = "0xA06AF4", Offset = "0xA06AF4", VA = "0xA06AF4")]
		internal SpeedBooster _003CGetOwnedActiveSpeedBoosts_003Eb__22_0(SpeedBooster x)
		{
			return null;
		}

		[Token(Token = "0x6002D1F")]
		[Address(RVA = "0xA06AFC", Offset = "0xA06AFC", VA = "0xA06AFC")]
		internal bool _003CGetActiveSpeedBoosts_003Eb__23_1(SpeedBooster boost)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40006F9")]
	private const int c_maxBoostersOfEachTypeToShow = 50;

	[Token(Token = "0x40006FA")]
	private const string c_costItemToDisplay = "loot_2";

	[Token(Token = "0x40006FB")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private GameObject m_boosterItemViewTemplate;

	[Token(Token = "0x40006FC")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Transform m_boosterItemViewParent;

	[Token(Token = "0x40006FD")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private GameObject m_textEffectTemplate;

	[Token(Token = "0x40006FE")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	protected VolumeMultiplierView m_volumeMultiplierView;

	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	protected AM2Text m_costItemAmountText;

	[Token(Token = "0x4000700")]
	[FieldOffset(Offset = "0xE8")]
	private RewardVisualizer m_rewardVisualizer;

	[Token(Token = "0x4000701")]
	[FieldOffset(Offset = "0xF0")]
	private ObjectPoolController m_objectPoolController;

	[Token(Token = "0x4000702")]
	[FieldOffset(Offset = "0xF8")]
	private SpeedBoosterController m_speedBoosterController;

	[Token(Token = "0x4000703")]
	[FieldOffset(Offset = "0x100")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x4000704")]
	[FieldOffset(Offset = "0x108")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000705")]
	[FieldOffset(Offset = "0x110")]
	private CasualAnalog m_analogController;

	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x118")]
	private Recipe m_recipe;

	[Token(Token = "0x4000707")]
	[FieldOffset(Offset = "0x120")]
	private RecipeBoosterView m_parentView;

	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x128")]
	private List<GameObject> m_boosterItemViews;

	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x130")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8243B0", Offset = "0x8243B0")]
	private bool _003CallowBackButtonDismiss_003Ek__BackingField;

	[Token(Token = "0x170000F0")]
	public bool allowBackButtonDismiss
	{
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xA058E4", Offset = "0xA058E4", VA = "0xA058E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8341C0", Offset = "0x8341C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xA058EC", Offset = "0xA058EC", VA = "0xA058EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8341D0", Offset = "0x8341D0")]
		set
		{
		}
	}

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0xA058F8", Offset = "0xA058F8", VA = "0xA058F8")]
	public void Initialize(CasualViewController parentController, Recipe recipe, RecipeBoosterView parentView)
	{
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0xA05FB8", Offset = "0xA05FB8", VA = "0xA05FB8")]
	private void InitializeSpeedBoostItemViews()
	{
	}

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0xA06444", Offset = "0xA06444", VA = "0xA06444")]
	private IEnumerable<SpeedBooster> GetOwnedActiveSpeedBoosts()
	{
		return null;
	}

	[Token(Token = "0x60007CC")]
	[Address(RVA = "0xA0659C", Offset = "0xA0659C", VA = "0xA0659C")]
	private IEnumerable<SpeedBooster> GetActiveSpeedBoosts()
	{
		return null;
	}

	[Token(Token = "0x60007CD")]
	[Address(RVA = "0xA06728", Offset = "0xA06728", VA = "0xA06728")]
	private void Update()
	{
	}

	[Token(Token = "0x60007CE")]
	[Address(RVA = "0xA0672C", Offset = "0xA0672C", VA = "0xA0672C")]
	private void UpdateCostItemAmountText()
	{
	}

	[Token(Token = "0x60007CF")]
	[Address(RVA = "0xA06770", Offset = "0xA06770", VA = "0xA06770")]
	private string GenerateCostItemDisplayText()
	{
		return null;
	}

	[Token(Token = "0x60007D0")]
	[Address(RVA = "0xA06898", Offset = "0xA06898", VA = "0xA06898", Slot = "11")]
	protected override void OnHideFinished(Action onHideComplete)
	{
	}

	[Token(Token = "0x60007D1")]
	[Address(RVA = "0xA055E8", Offset = "0xA055E8", VA = "0xA055E8")]
	public SpeedBoosterSlotItem OnClickedRecipeBooster(SpeedBooster boost, SpeedBoosterItemView boosterItemView, long count)
	{
		return null;
	}

	[Token(Token = "0x60007D2")]
	[Address(RVA = "0xA069E0", Offset = "0xA069E0", VA = "0xA069E0")]
	public SpeedBoosterPopupView()
	{
	}

	[Token(Token = "0x60007D3")]
	[Address(RVA = "0xA06A50", Offset = "0xA06A50", VA = "0xA06A50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8341E0", Offset = "0x8341E0")]
	private SpeedBooster _003CGetActiveSpeedBoosts_003Eb__23_0(SpeedBoosterSlotItem slot)
	{
		return null;
	}
}
