using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inventory;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004AC")]
	public class LoadoutController : UkenController, IInventoryProgressTracker, ISlotController<Ability>
	{
		[Token(Token = "0x2000821")]
		public delegate void OnItemUnequiped();

		[Token(Token = "0x40015AE")]
		[FieldOffset(Offset = "0x0")]
		public static int s_maxLoadoutSlotsHardLimit;

		[Token(Token = "0x40015AF")]
		public const string c_loadoutItemRef = "loadout";

		[Token(Token = "0x40015B0")]
		public const string c_loadoutUpgradableItemRef = "loadout_slots";

		[Token(Token = "0x40015B2")]
		[FieldOffset(Offset = "0x20")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x40015B3")]
		[FieldOffset(Offset = "0x28")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x40015B4")]
		[FieldOffset(Offset = "0x30")]
		private AbilitiesController m_abilitiesController;

		[Token(Token = "0x40015B5")]
		[FieldOffset(Offset = "0x38")]
		private UIAlertController m_uiAlertController;

		[Token(Token = "0x40015B6")]
		[FieldOffset(Offset = "0x40")]
		private LoadoutItem m_loadoutItem;

		[Token(Token = "0x1400000E")]
		public event OnItemUnequiped itemUnequiped
		{
			[Token(Token = "0x60022C5")]
			[Address(RVA = "0xA716B0", Offset = "0xA716B0", VA = "0xA716B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839604", Offset = "0x839604")]
			add
			{
			}
			[Token(Token = "0x60022C6")]
			[Address(RVA = "0xA7179C", Offset = "0xA7179C", VA = "0xA7179C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839614", Offset = "0x839614")]
			remove
			{
			}
		}

		[Token(Token = "0x60022C7")]
		[Address(RVA = "0xA71888", Offset = "0xA71888", VA = "0xA71888")]
		public LoadoutController(SharedDataCacheController dataCacheController, InventoryController inventoryController, AbilitiesController abilitiesController, UIAlertController uiAlertController)
		{
		}

		[Token(Token = "0x60022C8")]
		[Address(RVA = "0xA718D4", Offset = "0xA718D4", VA = "0xA718D4", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x60022C9")]
		[Address(RVA = "0xA7198C", Offset = "0xA7198C", VA = "0xA7198C", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x60022CA")]
		[Address(RVA = "0xA71A08", Offset = "0xA71A08", VA = "0xA71A08", Slot = "10")]
		public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x60022CB")]
		[Address(RVA = "0xA71AA8", Offset = "0xA71AA8", VA = "0xA71AA8", Slot = "15")]
		public int GetSlotCount()
		{
			return default(int);
		}

		[Token(Token = "0x60022CC")]
		[Address(RVA = "0xA71B68", Offset = "0xA71B68", VA = "0xA71B68")]
		public long GetLevelOfAbility(Ability ability)
		{
			return default(long);
		}

		[Token(Token = "0x60022CD")]
		[Address(RVA = "0xA71C10", Offset = "0xA71C10", VA = "0xA71C10")]
		public bool IsMaxLevel(Ability ability)
		{
			return default(bool);
		}

		[Token(Token = "0x60022CE")]
		[Address(RVA = "0xA71C68", Offset = "0xA71C68", VA = "0xA71C68")]
		public Dictionary<string, long> CostToLevelUp(Ability ability)
		{
			return null;
		}

		[Token(Token = "0x60022CF")]
		[Address(RVA = "0xA71CB0", Offset = "0xA71CB0", VA = "0xA71CB0")]
		public bool CanAffordToLevelUp(Ability ability)
		{
			return default(bool);
		}

		[Token(Token = "0x60022D0")]
		[Address(RVA = "0xA71E5C", Offset = "0xA71E5C", VA = "0xA71E5C")]
		public bool LevelUpAbility(Ability ability)
		{
			return default(bool);
		}

		[Token(Token = "0x60022D1")]
		[Address(RVA = "0xA720B0", Offset = "0xA720B0", VA = "0xA720B0", Slot = "11")]
		public void SetSlotItem(int index, Ability ability)
		{
		}

		[Token(Token = "0x60022D2")]
		[Address(RVA = "0xA72214", Offset = "0xA72214", VA = "0xA72214")]
		public void UnequipSlotItem(string referenceId)
		{
		}

		[Token(Token = "0x60022D3")]
		[Address(RVA = "0xA72700", Offset = "0xA72700", VA = "0xA72700")]
		public void UnequipSlotItem(Ability ability)
		{
		}

		[Token(Token = "0x60022D4")]
		[Address(RVA = "0xA72744", Offset = "0xA72744", VA = "0xA72744")]
		public List<Ability> GetEqippedAbilities()
		{
			return null;
		}

		[Token(Token = "0x60022D5")]
		[Address(RVA = "0xA72914", Offset = "0xA72914", VA = "0xA72914", Slot = "14")]
		public Ability GetSlottedItemAtSlot(int index)
		{
			return null;
		}

		[Token(Token = "0x60022D6")]
		[Address(RVA = "0xA7281C", Offset = "0xA7281C", VA = "0xA7281C")]
		public Ability GetAbilityAtSlot(int index)
		{
			return null;
		}

		[Token(Token = "0x60022D7")]
		[Address(RVA = "0xA72918", Offset = "0xA72918", VA = "0xA72918", Slot = "12")]
		public List<Ability> GetAllOwnedSlottedItems()
		{
			return null;
		}

		[Token(Token = "0x60022D8")]
		[Address(RVA = "0xA729C8", Offset = "0xA729C8", VA = "0xA729C8", Slot = "13")]
		public List<Ability> GetEquippedSlottedItems()
		{
			return null;
		}

		[Token(Token = "0x60022D9")]
		[Address(RVA = "0xA729CC", Offset = "0xA729CC", VA = "0xA729CC")]
		public void TEMP_SETUP_LOADOUT_SINCE_THERES_NO_LOADOUT_SCREEN_YET()
		{
		}
	}
}
