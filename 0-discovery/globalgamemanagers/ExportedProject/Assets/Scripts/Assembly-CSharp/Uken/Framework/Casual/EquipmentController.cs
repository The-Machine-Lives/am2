using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004A9")]
	public class EquipmentController : DepotController, ITraitAppender, IInventoryProgressTracker, ISlotController<EquipmentItem>
	{
		[Token(Token = "0x4001592")]
		public const int c_maxEquipmentSlotsHardLimit = 8;

		[Token(Token = "0x4001593")]
		public const string c_equipmentItemRef = "equip";

		[Token(Token = "0x4001594")]
		public const string c_equipmentUpgradableItemRef = "equip_slots";

		[Token(Token = "0x4001595")]
		[FieldOffset(Offset = "0x20")]
		private bool m_equippedTraitsDirty;

		[Token(Token = "0x4001596")]
		[FieldOffset(Offset = "0x28")]
		private List<EquipmentTrait> m_equippedTraits;

		[Token(Token = "0x4001597")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, double> m_equippedEffects;

		[Token(Token = "0x4001598")]
		[FieldOffset(Offset = "0x38")]
		private RuntimeItemModelDataCache<Equipment, RDEquipment> m_equipmentCache;

		[Token(Token = "0x4001599")]
		[FieldOffset(Offset = "0x40")]
		private EquipmentSlotItem m_slotItem;

		[Token(Token = "0x400159A")]
		[FieldOffset(Offset = "0x48")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x400159B")]
		[FieldOffset(Offset = "0x50")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x400159C")]
		[FieldOffset(Offset = "0x58")]
		private UIAlertController m_uiAlertController;

		[Token(Token = "0x6002295")]
		[Address(RVA = "0xA63C4C", Offset = "0xA63C4C", VA = "0xA63C4C")]
		public EquipmentController(DataStoreController dataStoreController, SharedDataCacheController dataCacheController, InventoryController inventoryController, UIAlertController uiAlertController)
		{
		}

		[Token(Token = "0x6002296")]
		[Address(RVA = "0xA63D1C", Offset = "0xA63D1C", VA = "0xA63D1C", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x6002297")]
		[Address(RVA = "0xA63F3C", Offset = "0xA63F3C", VA = "0xA63F3C", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6002298")]
		[Address(RVA = "0xA63FB8", Offset = "0xA63FB8", VA = "0xA63FB8", Slot = "11")]
		public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x6002299")]
		[Address(RVA = "0xA64058", Offset = "0xA64058", VA = "0xA64058", Slot = "10")]
		public void AppendTraitsToItem(string itemModelReference, string reference, ItemMinimalDetails details)
		{
		}

		[Token(Token = "0x600229A")]
		[Address(RVA = "0xA641C0", Offset = "0xA641C0", VA = "0xA641C0")]
		public Equipment GetEquipment(string reference)
		{
			return null;
		}

		[Token(Token = "0x600229B")]
		[Address(RVA = "0xA64230", Offset = "0xA64230", VA = "0xA64230", Slot = "12")]
		public void SetSlotItem(int index, EquipmentItem equipmentItem)
		{
		}

		[Token(Token = "0x600229C")]
		[Address(RVA = "0xA644E0", Offset = "0xA644E0", VA = "0xA644E0")]
		public void UnequipSlotItem(EquipmentItem equipmentItem)
		{
		}

		[Token(Token = "0x600229D")]
		[Address(RVA = "0xA645E8", Offset = "0xA645E8", VA = "0xA645E8", Slot = "15")]
		public EquipmentItem GetSlottedItemAtSlot(int index)
		{
			return null;
		}

		[Token(Token = "0x600229E")]
		[Address(RVA = "0xA645EC", Offset = "0xA645EC", VA = "0xA645EC")]
		public EquipmentItem GetEquipmentAtSlot(int index)
		{
			return null;
		}

		[Token(Token = "0x600229F")]
		[Address(RVA = "0xA6474C", Offset = "0xA6474C", VA = "0xA6474C")]
		public List<EquipmentItem> GetAllOwnedEquipment()
		{
			return null;
		}

		[Token(Token = "0x60022A0")]
		[Address(RVA = "0xA64920", Offset = "0xA64920", VA = "0xA64920")]
		public List<EquipmentItem> GetEquippedEquipmentItems()
		{
			return null;
		}

		[Token(Token = "0x60022A1")]
		[Address(RVA = "0xA649F4", Offset = "0xA649F4", VA = "0xA649F4", Slot = "13")]
		public List<EquipmentItem> GetAllOwnedSlottedItems()
		{
			return null;
		}

		[Token(Token = "0x60022A2")]
		[Address(RVA = "0xA649F8", Offset = "0xA649F8", VA = "0xA649F8", Slot = "14")]
		public List<EquipmentItem> GetEquippedSlottedItems()
		{
			return null;
		}

		[Token(Token = "0x60022A3")]
		[Address(RVA = "0xA64398", Offset = "0xA64398", VA = "0xA64398", Slot = "16")]
		public int GetSlotCount()
		{
			return default(int);
		}

		[Token(Token = "0x60022A4")]
		[Address(RVA = "0xA649FC", Offset = "0xA649FC", VA = "0xA649FC")]
		public long GetMaxCapUpAmountUpForRecipe(Recipe recipe)
		{
			return default(long);
		}

		[Token(Token = "0x60022A5")]
		[Address(RVA = "0xA64DBC", Offset = "0xA64DBC", VA = "0xA64DBC")]
		public double GetSpeedUpPercentForRecipe(Recipe recipe)
		{
			return default(double);
		}

		[Token(Token = "0x60022A6")]
		[Address(RVA = "0xA64E00", Offset = "0xA64E00", VA = "0xA64E00")]
		public long GetVolumeAmountUpForRecipe(Recipe recipe)
		{
			return default(long);
		}

		[Token(Token = "0x60022A7")]
		[Address(RVA = "0xA64A90", Offset = "0xA64A90", VA = "0xA64A90")]
		private double GetAmountForEquipmentType(EEquipmentEffect effect, string reference)
		{
			return default(double);
		}

		[Token(Token = "0x60022A8")]
		[Address(RVA = "0xA646F0", Offset = "0xA646F0", VA = "0xA646F0")]
		private bool IsEquipmentSafe(EquipmentItem item)
		{
			return default(bool);
		}

		[Token(Token = "0x60022A9")]
		[Address(RVA = "0xA6442C", Offset = "0xA6442C", VA = "0xA6442C")]
		private void SetEquipmentDirty(bool dirty)
		{
		}
	}
}
