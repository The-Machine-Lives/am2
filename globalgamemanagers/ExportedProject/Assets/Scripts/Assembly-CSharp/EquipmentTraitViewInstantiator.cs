using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using UnityEngine;
using Utilities;

[Token(Token = "0x20000CC")]
public class EquipmentTraitViewInstantiator
{
	[Token(Token = "0x200061D")]
	private class CombinedEquipmentTypes
	{
		[Token(Token = "0x4001E3C")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<EEquipmentEffect, Dictionary<string, EquipmentTrait>> m_traitsByType;

		[Token(Token = "0x6002CED")]
		[Address(RVA = "0x9C71E8", Offset = "0x9C71E8", VA = "0x9C71E8")]
		public void AddEquipment(List<EquipmentTrait> traits)
		{
		}

		[Token(Token = "0x6002CEE")]
		[Address(RVA = "0x9C7408", Offset = "0x9C7408", VA = "0x9C7408")]
		public List<EquipmentTrait> GetAllTraits()
		{
			return null;
		}

		[Token(Token = "0x6002CEF")]
		[Address(RVA = "0x9C7178", Offset = "0x9C7178", VA = "0x9C7178")]
		public CombinedEquipmentTypes()
		{
		}
	}

	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0x10")]
	private List<EquipmentItem> m_sourceEquipmentItems;

	[Token(Token = "0x400036C")]
	[FieldOffset(Offset = "0x18")]
	private List<AbilityTraitView> m_equipmentTraitViews;

	[Token(Token = "0x400036D")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_equipmentTraitTemplate;

	[Token(Token = "0x400036E")]
	[FieldOffset(Offset = "0x28")]
	private Transform m_equipmentTraitViewsParent;

	[Token(Token = "0x400036F")]
	[FieldOffset(Offset = "0x30")]
	private ObjectPoolController m_objectPoolController;

	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0x38")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0x40")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x48")]
	private bool m_needsRebuild;

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x9C5DF0", Offset = "0x9C5DF0", VA = "0x9C5DF0")]
	public EquipmentTraitViewInstantiator(GameObject equipmentTraitTemplate, Transform equipmentTraitViewsParent)
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x9C7104", Offset = "0x9C7104", VA = "0x9C7104", Slot = "1")]
	~EquipmentTraitViewInstantiator()
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x9C65DC", Offset = "0x9C65DC", VA = "0x9C65DC")]
	public void CreateTraitViews()
	{
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x9C653C", Offset = "0x9C653C", VA = "0x9C653C")]
	public void SetSourceEquipmentItem(EquipmentItem item)
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x9C7700", Offset = "0x9C7700", VA = "0x9C7700")]
	public void SetSourceEquipmentItems(List<EquipmentItem> items)
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x9C75C8", Offset = "0x9C75C8", VA = "0x9C75C8")]
	private void CreateRecipeMaxCapPercentTraitView(EquipmentTrait trait)
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x9C7630", Offset = "0x9C7630", VA = "0x9C7630")]
	private void CreateRecipeVolumeAmountTraitView(EquipmentTrait trait)
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x9C7698", Offset = "0x9C7698", VA = "0x9C7698")]
	private void CreateRecipeSpeedPercentTraitView(EquipmentTrait trait)
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x9C7780", Offset = "0x9C7780", VA = "0x9C7780")]
	private AbilityTraitView CreateEquipmentTraitView(EquipmentTrait trait, string titleSuffix, EStatusNumericDisplay numericDisplay, int decimals)
	{
		return null;
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x9C7978", Offset = "0x9C7978", VA = "0x9C7978")]
	private AbilityTraitView CreateEquipmentTraitView(string traitTitle, string nextAmountString, bool localizedTitle)
	{
		return null;
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x9C5988", Offset = "0x9C5988", VA = "0x9C5988")]
	public void ClearTraitViews()
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x9C67BC", Offset = "0x9C67BC", VA = "0x9C67BC")]
	public void Update()
	{
	}
}
