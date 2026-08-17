using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004AA")]
	public class FTUEController : DepotController, IInventoryProgressTracker
	{
		[Token(Token = "0x400159D")]
		public const string c_powerResourceName = "power";

		[Token(Token = "0x400159E")]
		[FieldOffset(Offset = "0x20")]
		private RuntimeDataCache<Condition, RDCondition> m_conditionsCache;

		[Token(Token = "0x400159F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EACC", Offset = "0x82EACC")]
		private RuntimeUnlockersCache _003CunlockersCache_003Ek__BackingField;

		[Token(Token = "0x40015A0")]
		[FieldOffset(Offset = "0x30")]
		protected UkenObservable<List<Unlocker>> m_unlockSignal;

		[Token(Token = "0x40015A1")]
		[FieldOffset(Offset = "0x38")]
		private List<Unlocker> m_pendingUnlockedUnlockers;

		[Token(Token = "0x40015A2")]
		[FieldOffset(Offset = "0x40")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x40015A3")]
		[FieldOffset(Offset = "0x48")]
		private RewardGroupsController m_rewardGroupsController;

		[Token(Token = "0x40015A4")]
		[FieldOffset(Offset = "0x50")]
		private UIAlertController m_uiAlertController;

		[Token(Token = "0x40015A5")]
		[FieldOffset(Offset = "0x58")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x170005F5")]
		public RuntimeUnlockersCache unlockersCache
		{
			[Token(Token = "0x60022AA")]
			[Address(RVA = "0xA5AC58", Offset = "0xA5AC58", VA = "0xA5AC58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8395E4", Offset = "0x8395E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60022AB")]
			[Address(RVA = "0xA66CB0", Offset = "0xA66CB0", VA = "0xA66CB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8395F4", Offset = "0x8395F4")]
			private set
			{
			}
		}

		[Token(Token = "0x60022AC")]
		[Address(RVA = "0xA66CB8", Offset = "0xA66CB8", VA = "0xA66CB8")]
		public FTUEController(CasualDataStoreController dataController, InventoryController inventoryController, RewardGroupsController rewardGroupsController, UIAlertController uiAlertController, SharedDataCacheController dataCacheController)
		{
		}

		[Token(Token = "0x60022AD")]
		[Address(RVA = "0xA66D90", Offset = "0xA66D90", VA = "0xA66D90", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x60022AE")]
		[Address(RVA = "0xA67068", Offset = "0xA67068", VA = "0xA67068")]
		private void RemoveUnnecessaryUnlockerNotifications()
		{
		}

		[Token(Token = "0x60022AF")]
		[Address(RVA = "0xA67340", Offset = "0xA67340", VA = "0xA67340", Slot = "10")]
		public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x60022B0")]
		[Address(RVA = "0xA59E34", Offset = "0xA59E34", VA = "0xA59E34")]
		public Dictionary<string, Unlocker> GetResearchableUnlockers()
		{
			return null;
		}

		[Token(Token = "0x60022B1")]
		[Address(RVA = "0xA675D0", Offset = "0xA675D0", VA = "0xA675D0")]
		public bool IsProfileHeaderLocked()
		{
			return default(bool);
		}

		[Token(Token = "0x60022B2")]
		[Address(RVA = "0xA5B6E0", Offset = "0xA5B6E0", VA = "0xA5B6E0")]
		public UkenUnsubscriber<List<Unlocker>> SubscribeToUnlockUpdates(IUkenObserver<List<Unlocker>> observer, bool signalOnSubscribe)
		{
			return null;
		}

		[Token(Token = "0x60022B3")]
		[Address(RVA = "0xA67634", Offset = "0xA67634", VA = "0xA67634")]
		public bool IsRecipeLocked(Recipe recipe)
		{
			return default(bool);
		}

		[Token(Token = "0x60022B4")]
		[Address(RVA = "0xA6766C", Offset = "0xA6766C", VA = "0xA6766C")]
		public bool IsItemConverterLocked(ItemConverter itemConverter)
		{
			return default(bool);
		}

		[Token(Token = "0x60022B5")]
		[Address(RVA = "0xA59C7C", Offset = "0xA59C7C", VA = "0xA59C7C")]
		public bool IsUpgradeLocked(string category, EUnlockType unlockType)
		{
			return default(bool);
		}

		[Token(Token = "0x60022B6")]
		[Address(RVA = "0xA676A4", Offset = "0xA676A4", VA = "0xA676A4")]
		public bool IsUpgradeLocked(string category, EUnlockType unlockType, out string unlockerRef)
		{
			return default(bool);
		}

		[Token(Token = "0x60022B7")]
		[Address(RVA = "0xA5B7A8", Offset = "0xA5B7A8", VA = "0xA5B7A8")]
		public bool IsUnlockerLocked(EUnlockType unlockType)
		{
			return default(bool);
		}

		[Token(Token = "0x60022B8")]
		[Address(RVA = "0xA676F4", Offset = "0xA676F4", VA = "0xA676F4", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x60022B9")]
		[Address(RVA = "0xA5A034", Offset = "0xA5A034", VA = "0xA5A034")]
		public void SetUnlockerResearchLocked(string zoneRef)
		{
		}

		[Token(Token = "0x60022BA")]
		[Address(RVA = "0xA677F0", Offset = "0xA677F0", VA = "0xA677F0")]
		private void UpdateUnlockers()
		{
		}
	}
}
