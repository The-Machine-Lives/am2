using System;
using System.Collections.Generic;
using AM2;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.IAP;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200054D")]
	public class Stores : DepotController
	{
		[Token(Token = "0x2000850")]
		public enum PurchaseResult
		{
			[Token(Token = "0x40023DC")]
			Success = 0,
			[Token(Token = "0x40023DD")]
			Failed = 1,
			[Token(Token = "0x40023DE")]
			InvalidItem = 2,
			[Token(Token = "0x40023DF")]
			NotEnoughCurrency = 3,
			[Token(Token = "0x40023E0")]
			ConnectionRequired = 4,
			[Token(Token = "0x40023E1")]
			Cancelled = 5,
			[Token(Token = "0x40023E2")]
			StoreNotAvailable = 6
		}

		[Token(Token = "0x2000851")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8214D8", Offset = "0x8214D8")]
		private sealed class _003C_003Ec__DisplayClass38_0
		{
			[Token(Token = "0x40023E3")]
			[FieldOffset(Offset = "0x10")]
			public Stores _003C_003E4__this;

			[Token(Token = "0x40023E4")]
			[FieldOffset(Offset = "0x18")]
			public StoreItem storeItem;

			[Token(Token = "0x40023E5")]
			[FieldOffset(Offset = "0x20")]
			public Action<bool, PurchaseResult> onComplete;

			[Token(Token = "0x6003373")]
			[Address(RVA = "0xA98498", Offset = "0xA98498", VA = "0xA98498")]
			public _003C_003Ec__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6003374")]
			[Address(RVA = "0xA986F0", Offset = "0xA986F0", VA = "0xA986F0")]
			internal void _003CPurchase_003Eb__0(UkenPurchaseResult result, UkenPaymentProduct product, Dictionary<string, long> finalizedRewards)
			{
			}
		}

		[Token(Token = "0x4001943")]
		[FieldOffset(Offset = "0x20")]
		private float c_storeItemUnlockedCheckDelaySeconds;

		[Token(Token = "0x4001944")]
		private const string c_persistentLTONotificationReference = "persistent_lto_notification";

		[Token(Token = "0x4001945")]
		[FieldOffset(Offset = "0x28")]
		private string m_finalizePurchaseURL;

		[Token(Token = "0x4001946")]
		[FieldOffset(Offset = "0x30")]
		private Action<WebRequest> m_webInterface;

		[Token(Token = "0x4001947")]
		[FieldOffset(Offset = "0x38")]
		private UserSegments m_userSegments;

		[Token(Token = "0x4001948")]
		[FieldOffset(Offset = "0x40")]
		private UserProfiler m_userProfiler;

		[Token(Token = "0x4001949")]
		[FieldOffset(Offset = "0x48")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x400194A")]
		[FieldOffset(Offset = "0x50")]
		private RewardGroupsController m_rewardGroups;

		[Token(Token = "0x400194B")]
		[FieldOffset(Offset = "0x58")]
		private Features m_features;

		[Token(Token = "0x400194C")]
		[FieldOffset(Offset = "0x60")]
		private UIAlertController m_uiAlertController;

		[Token(Token = "0x400194D")]
		[FieldOffset(Offset = "0x68")]
		private CasualAnalog m_casualAnalog;

		[Token(Token = "0x400194E")]
		[FieldOffset(Offset = "0x70")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x400194F")]
		[FieldOffset(Offset = "0x78")]
		private List<StoreItem> m_currentlyNotAvailableStoreItems;

		[Token(Token = "0x4001950")]
		[FieldOffset(Offset = "0x80")]
		private float m_timeUntilNextUnlockedStoreItemsCheck;

		[Token(Token = "0x4001951")]
		[FieldOffset(Offset = "0x88")]
		private double m_timeRemainingNextExpiringStoreItem;

		[Token(Token = "0x4001952")]
		[FieldOffset(Offset = "0x90")]
		private UkenObservable<List<StoreInventoryItem>> m_storeInventoryObservable;

		[Token(Token = "0x4001953")]
		[FieldOffset(Offset = "0x98")]
		private bool m_postLoadComplete;

		[Token(Token = "0x4001954")]
		[FieldOffset(Offset = "0x99")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83228C", Offset = "0x83228C")]
		private bool _003CpersistentLTONotification_003Ek__BackingField;

		[Token(Token = "0x17000725")]
		public bool persistentLTONotification
		{
			[Token(Token = "0x60028A0")]
			[Address(RVA = "0xA96F08", Offset = "0xA96F08", VA = "0xA96F08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A310", Offset = "0x83A310")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028A1")]
			[Address(RVA = "0xA96F10", Offset = "0xA96F10", VA = "0xA96F10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A320", Offset = "0x83A320")]
			private set
			{
			}
		}

		[Token(Token = "0x60028A2")]
		[Address(RVA = "0xA96F1C", Offset = "0xA96F1C", VA = "0xA96F1C")]
		public Stores(DataStoreController controller, UserSegments userSegments, UserProfiler userProfiler, RewardGroupsController rewardGroups, InventoryController inventoryController, SharedDataCacheController dataCacheController, string finalizePurchaseURL, Action<WebRequest> webInterface, Features features, UIAlertController uIAlertController, CasualAnalog casualAnalog)
		{
		}

		[Token(Token = "0x60028A3")]
		[Address(RVA = "0xA97084", Offset = "0xA97084", VA = "0xA97084", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x60028A4")]
		[Address(RVA = "0xA97154", Offset = "0xA97154", VA = "0xA97154", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x60028A5")]
		[Address(RVA = "0xA97118", Offset = "0xA97118", VA = "0xA97118")]
		private void ConfigureData()
		{
		}

		[Token(Token = "0x60028A6")]
		[Address(RVA = "0xA977BC", Offset = "0xA977BC", VA = "0xA977BC")]
		private void ApplyPersistentNotificationDotToLTOsOnAppLaunch()
		{
		}

		[Token(Token = "0x60028A7")]
		[Address(RVA = "0xA97BF4", Offset = "0xA97BF4", VA = "0xA97BF4")]
		public UkenUnsubscriber<List<StoreInventoryItem>> SubscribeToMessages(IUkenObserver<List<StoreInventoryItem>> observer, bool signalOnSubscribe)
		{
			return null;
		}

		[Token(Token = "0x60028A8")]
		[Address(RVA = "0xA97C6C", Offset = "0xA97C6C", VA = "0xA97C6C")]
		private List<StoreInventoryItem> GetAllStoreInventoryItems()
		{
			return null;
		}

		[Token(Token = "0x60028A9")]
		[Address(RVA = "0xA971EC", Offset = "0xA971EC", VA = "0xA971EC")]
		private List<StoreItem> GetAllUnavailableStoreItems()
		{
			return null;
		}

		[Token(Token = "0x60028AA")]
		[Address(RVA = "0xA97E40", Offset = "0xA97E40", VA = "0xA97E40")]
		private void SetFirstSeenTimeForVariableStartStoreItem(StoreItem storeItem)
		{
		}

		[Token(Token = "0x60028AB")]
		[Address(RVA = "0xA97F7C", Offset = "0xA97F7C", VA = "0xA97F7C")]
		private void SetUnlockTimeForVariableStartStoreItem(StoreItem storeItem)
		{
		}

		[Token(Token = "0x60028AC")]
		[Address(RVA = "0xA9738C", Offset = "0xA9738C", VA = "0xA9738C")]
		private void CheckIfLockedStoreItemsAreNowAvailable()
		{
		}

		[Token(Token = "0x60028AD")]
		[Address(RVA = "0xA9763C", Offset = "0xA9763C", VA = "0xA9763C")]
		private double GetNextExpiringOfferTimeRemaining()
		{
			return default(double);
		}

		[Token(Token = "0x60028AE")]
		[Address(RVA = "0xA98060", Offset = "0xA98060", VA = "0xA98060")]
		private void EmitStoreUpdated()
		{
		}

		[Token(Token = "0x60028AF")]
		[Address(RVA = "0xA97E2C", Offset = "0xA97E2C", VA = "0xA97E2C")]
		private List<StoreItem> GetAllStoreItems()
		{
			return null;
		}

		[Token(Token = "0x60028B0")]
		[Address(RVA = "0xA9794C", Offset = "0xA9794C", VA = "0xA9794C")]
		public List<StoreItem> GetOwnedStoreItems()
		{
			return null;
		}

		[Token(Token = "0x60028B1")]
		[Address(RVA = "0xA97F00", Offset = "0xA97F00", VA = "0xA97F00")]
		private void SendServedLTOLog(StoreItem storeItem)
		{
		}

		[Token(Token = "0x60028B2")]
		[Address(RVA = "0xA980D4", Offset = "0xA980D4", VA = "0xA980D4")]
		public void Purchase(StoreItem storeItem, Action<bool, PurchaseResult> onComplete, string eventName, string sourceSink)
		{
		}

		[Token(Token = "0x60028B3")]
		[Address(RVA = "0xA984A0", Offset = "0xA984A0", VA = "0xA984A0")]
		private void MarkPurchased(StoreItem storeItem)
		{
		}

		[Token(Token = "0x60028B4")]
		[Address(RVA = "0xA98580", Offset = "0xA98580", VA = "0xA98580")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x83A330", Offset = "0x83A330")]
		public Dictionary<string, long> IAPGrantTransaction(UkenPaymentTransaction transaction)
		{
			return null;
		}

		[Token(Token = "0x60028B5")]
		[Address(RVA = "0xA98670", Offset = "0xA98670", VA = "0xA98670", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}
	}
}
