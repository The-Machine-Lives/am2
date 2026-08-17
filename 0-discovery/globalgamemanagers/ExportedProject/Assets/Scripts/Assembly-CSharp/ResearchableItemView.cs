using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AM2;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x2000108")]
public class ResearchableItemView : BasicItemView, IResearchableItemView, ISubTabItemView
{
	[Token(Token = "0x4000670")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x823FB4", Offset = "0x823FB4")]
	private IResearchable _003Cresearchable_003Ek__BackingField;

	[Token(Token = "0x4000671")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AM2Text m_buttonText;

	[Token(Token = "0x4000672")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AM2Button m_button;

	[Token(Token = "0x4000673")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject m_redDotNotification;

	[Token(Token = "0x4000674")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private InfoPopupButton m_infoPopupButton;

	[Token(Token = "0x4000675")]
	[FieldOffset(Offset = "0x68")]
	private bool m_updateButtonStateBasedOnCost;

	[Token(Token = "0x4000676")]
	[FieldOffset(Offset = "0x70")]
	private IResearchableView m_parentResearchView;

	[Token(Token = "0x4000677")]
	[FieldOffset(Offset = "0x78")]
	private long m_previousCostItemQuantity;

	[Token(Token = "0x4000678")]
	[FieldOffset(Offset = "0x80")]
	private Item m_costItem;

	[Token(Token = "0x4000679")]
	[FieldOffset(Offset = "0x88")]
	private ItemMinimalDetails m_costItemDetails;

	[Token(Token = "0x400067A")]
	[FieldOffset(Offset = "0x90")]
	private Localizations m_localizationController;

	[Token(Token = "0x400067B")]
	[FieldOffset(Offset = "0x98")]
	private AM2TextDisplayController m_textDisplayController;

	[Token(Token = "0x400067C")]
	[FieldOffset(Offset = "0xA0")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x400067D")]
	[FieldOffset(Offset = "0xA8")]
	private UIAlertController m_uiAlertController;

	[Token(Token = "0x400067E")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_initialized;

	[Token(Token = "0x170000E7")]
	public IResearchable researchable
	{
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x9F732C", Offset = "0x9F732C", VA = "0x9F732C", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8340F0", Offset = "0x8340F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x9F7334", Offset = "0x9F7334", VA = "0x9F7334")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834100", Offset = "0x834100")]
		private set
		{
		}
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0x9F733C", Offset = "0x9F733C", VA = "0x9F733C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000733")]
	[Address(RVA = "0x9F7424", Offset = "0x9F7424", VA = "0x9F7424")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000734")]
	[Address(RVA = "0x9F74D4", Offset = "0x9F74D4", VA = "0x9F74D4", Slot = "10")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0x9F74D8", Offset = "0x9F74D8", VA = "0x9F74D8")]
	public void Initialize(IResearchableView parentResearchView, IResearchable inResearchable, bool updateButtonStateBasedOnCost, CasualViewController viewController)
	{
	}

	[Token(Token = "0x6000736")]
	[Address(RVA = "0x9F8210", Offset = "0x9F8210", VA = "0x9F8210")]
	public void ShowRedDotNotification(bool show)
	{
	}

	[Token(Token = "0x6000737")]
	[Address(RVA = "0x9F7F5C", Offset = "0x9F7F5C", VA = "0x9F7F5C", Slot = "5")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x6000738")]
	[Address(RVA = "0x9F8380", Offset = "0x9F8380", VA = "0x9F8380")]
	public void OnButtonPressed()
	{
	}

	[Token(Token = "0x6000739")]
	[Address(RVA = "0x9F8438", Offset = "0x9F8438", VA = "0x9F8438")]
	private void Update()
	{
	}

	[Token(Token = "0x600073A")]
	[Address(RVA = "0x9F8248", Offset = "0x9F8248", VA = "0x9F8248")]
	private void RefreshButtonState(long costItemQuantity)
	{
	}

	[Token(Token = "0x600073B")]
	[Address(RVA = "0x9F84A4", Offset = "0x9F84A4", VA = "0x9F84A4", Slot = "9")]
	public void OnHidePage()
	{
	}

	[Token(Token = "0x600073C")]
	[Address(RVA = "0x9F858C", Offset = "0x9F858C", VA = "0x9F858C", Slot = "6")]
	public bool RefreshRedDotNotification(HashSet<string> untouchedUnlockers, HashSet<string> untouchedItemRefs)
	{
		return default(bool);
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0x9F85BC", Offset = "0x9F85BC", VA = "0x9F85BC")]
	public ResearchableItemView()
	{
	}

	[SpecialName]
	[Token(Token = "0x600073E")]
	[Address(RVA = "0x9F85CC", Offset = "0x9F85CC", VA = "0x9F85CC", Slot = "7")]
	private GameObject ISubTabItemView_002Eget_gameObject()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x600073F")]
	[Address(RVA = "0x9F85D4", Offset = "0x9F85D4", VA = "0x9F85D4", Slot = "8")]
	private Transform ISubTabItemView_002Eget_transform()
	{
		return null;
	}
}
