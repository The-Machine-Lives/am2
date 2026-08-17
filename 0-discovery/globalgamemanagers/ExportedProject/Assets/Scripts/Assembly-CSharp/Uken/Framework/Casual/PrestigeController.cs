using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004B7")]
	public class PrestigeController : DepotController
	{
		[Token(Token = "0x4001601")]
		private const string c_prestigeEventName = "player_prestige";

		[Token(Token = "0x4001602")]
		private const string c_prestigeSyncName = "player_level";

		[Token(Token = "0x4001603")]
		private const string c_prestigeSystemDepotName = "prestige_system";

		[Token(Token = "0x4001604")]
		private const string c_prestigeLevelDepotName = "prestige_level";

		[Token(Token = "0x4001605")]
		private const string c_prestigeCreditEventName = "prestige_reward";

		[Token(Token = "0x4001606")]
		private const string c_prestigeCreditSyncName = "prestige";

		[Token(Token = "0x4001607")]
		private const long c_increasePrestigeLevelOnLevelUpAmount = 1L;

		[Token(Token = "0x4001608")]
		[FieldOffset(Offset = "0x20")]
		private RuntimeDataCache<PrestigeSystem, RDPrestigeSystem> m_prestigeSystemCache;

		[Token(Token = "0x4001609")]
		[FieldOffset(Offset = "0x28")]
		private RuntimeDataCache<PrestigeLevel, RDPrestigeLevel> m_prestigeLevelCache;

		[Token(Token = "0x400160A")]
		[FieldOffset(Offset = "0x30")]
		private PrestigeSystem m_prestigeSystem;

		[Token(Token = "0x400160B")]
		[FieldOffset(Offset = "0x38")]
		private List<PrestigeLevelUpRewards> m_prestigeLevelUpReward;

		[Token(Token = "0x400160C")]
		[FieldOffset(Offset = "0x40")]
		private List<PrestigePermanentItems> m_pretigePermanentItems;

		[Token(Token = "0x400160D")]
		[FieldOffset(Offset = "0x48")]
		private PrestigeLevel m_prestigeLevel;

		[Token(Token = "0x400160E")]
		[FieldOffset(Offset = "0x50")]
		private List<Prestiges> m_prestiges;

		[Token(Token = "0x400160F")]
		[FieldOffset(Offset = "0x58")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x4001610")]
		[FieldOffset(Offset = "0x60")]
		private SharedDataCacheController m_sharedDataCacheController;

		[Token(Token = "0x4001611")]
		[FieldOffset(Offset = "0x68")]
		private CasualAnalog m_casualAnalogController;

		[Token(Token = "0x170005FC")]
		public string prestigeTokenReferenceID
		{
			[Token(Token = "0x600237F")]
			[Address(RVA = "0xA78720", Offset = "0xA78720", VA = "0xA78720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600237B")]
		[Address(RVA = "0xA77B10", Offset = "0xA77B10", VA = "0xA77B10")]
		public PrestigeController(DataStoreController dataStoreController, AM2InventoryController inventoryController, SharedDataCacheController sharedDataCacheController, CasualAnalog casualAnalogController)
		{
		}

		[Token(Token = "0x600237C")]
		[Address(RVA = "0xA77B60", Offset = "0xA77B60", VA = "0xA77B60", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x600237D")]
		[Address(RVA = "0xA77F78", Offset = "0xA77F78", VA = "0xA77F78")]
		public void Prestige()
		{
		}

		[Token(Token = "0x600237E")]
		[Address(RVA = "0xA78130", Offset = "0xA78130", VA = "0xA78130")]
		private void LogPlayerPrestige()
		{
		}

		[Token(Token = "0x6002380")]
		[Address(RVA = "0xA7863C", Offset = "0xA7863C", VA = "0xA7863C")]
		public int GetNumberOfPrestigeTokenToBeAwarded()
		{
			return default(int);
		}

		[Token(Token = "0x6002381")]
		[Address(RVA = "0xA78750", Offset = "0xA78750", VA = "0xA78750")]
		private long GetQuantityOfAllSpeedBoostersSlotItems()
		{
			return default(long);
		}

		[Token(Token = "0x6002382")]
		[Address(RVA = "0xA7807C", Offset = "0xA7807C", VA = "0xA7807C")]
		private bool GivePrestigeTokens()
		{
			return default(bool);
		}

		[Token(Token = "0x6002383")]
		[Address(RVA = "0xA78574", Offset = "0xA78574", VA = "0xA78574")]
		private void IncreasePrestigeLevel()
		{
		}

		[Token(Token = "0x6002384")]
		[Address(RVA = "0xA78218", Offset = "0xA78218", VA = "0xA78218")]
		private void ResetInventory()
		{
		}

		[Token(Token = "0x6002385")]
		[Address(RVA = "0xA783C0", Offset = "0xA783C0", VA = "0xA783C0")]
		private void GivePrestigeRewards()
		{
		}

		[Token(Token = "0x6002386")]
		[Address(RVA = "0xA78904", Offset = "0xA78904", VA = "0xA78904")]
		public bool IsPrestigeTabUnlocked()
		{
			return default(bool);
		}

		[Token(Token = "0x6002387")]
		[Address(RVA = "0xA7894C", Offset = "0xA7894C", VA = "0xA7894C")]
		public string PrestigeTabUnlockerName()
		{
			return null;
		}

		[Token(Token = "0x6002388")]
		[Address(RVA = "0xA7897C", Offset = "0xA7897C", VA = "0xA7897C")]
		public string PrestigeButtonUnlockerName()
		{
			return null;
		}

		[Token(Token = "0x6002389")]
		[Address(RVA = "0xA789AC", Offset = "0xA789AC", VA = "0xA789AC")]
		public bool IsPrestigeButtonUnlocked()
		{
			return default(bool);
		}

		[Token(Token = "0x600238A")]
		[Address(RVA = "0xA789F4", Offset = "0xA789F4", VA = "0xA789F4")]
		public string PrestigeSystemDescriptionText()
		{
			return null;
		}

		[Token(Token = "0x600238B")]
		[Address(RVA = "0xA78A24", Offset = "0xA78A24", VA = "0xA78A24")]
		public List<Reward> GetAllPossiblePrestigeRewardsThatCanBeShown()
		{
			return null;
		}

		[Token(Token = "0x600238C")]
		[Address(RVA = "0xA788AC", Offset = "0xA788AC", VA = "0xA788AC")]
		public long CurrentPrestigeLevel()
		{
			return default(long);
		}

		[Token(Token = "0x600238D")]
		[Address(RVA = "0xA78BD8", Offset = "0xA78BD8", VA = "0xA78BD8")]
		public List<Prestiges> GetAllPrestigeItems()
		{
			return null;
		}

		[Token(Token = "0x600238E")]
		[Address(RVA = "0xA78BE0", Offset = "0xA78BE0", VA = "0xA78BE0")]
		public bool LevelUpPrestigeItem(Prestiges prestige)
		{
			return default(bool);
		}

		[Token(Token = "0x600238F")]
		[Address(RVA = "0xA78DAC", Offset = "0xA78DAC", VA = "0xA78DAC")]
		private void IncreaseLevel(Prestiges prestige)
		{
		}

		[Token(Token = "0x6002390")]
		[Address(RVA = "0xA78CD8", Offset = "0xA78CD8", VA = "0xA78CD8")]
		public bool CanAffordToLevelUp(Prestiges prestige)
		{
			return default(bool);
		}

		[Token(Token = "0x6002391")]
		[Address(RVA = "0xA78D64", Offset = "0xA78D64", VA = "0xA78D64")]
		public long CostToLevelUp(Prestiges prestige)
		{
			return default(long);
		}

		[Token(Token = "0x6002392")]
		[Address(RVA = "0xA78E60", Offset = "0xA78E60", VA = "0xA78E60")]
		public long GetLevelOfPrestige(Prestiges prestige)
		{
			return default(long);
		}

		[Token(Token = "0x6002393")]
		[Address(RVA = "0xA78EA8", Offset = "0xA78EA8", VA = "0xA78EA8")]
		public bool IsMaxLevel(Prestiges prestige)
		{
			return default(bool);
		}
	}
}
