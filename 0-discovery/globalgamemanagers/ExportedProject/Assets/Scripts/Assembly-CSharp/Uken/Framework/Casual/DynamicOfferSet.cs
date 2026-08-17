using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Library.IAP;
using Uken.Library.Inventory;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000534")]
	public class DynamicOfferSet : IEvent
	{
		[Token(Token = "0x40018A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected RDDynamicOfferSet m_setData;

		[Token(Token = "0x40018A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected SalesRecordController m_salesRecords;

		[Token(Token = "0x40018A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected DynamicOffers m_dynamicOffers;

		[Token(Token = "0x40018A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected UkenTimeController m_time;

		[Token(Token = "0x40018A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected CasualGame m_game;

		[Token(Token = "0x40018A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected InventoryController m_inventory;

		[Token(Token = "0x40018A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected List<DynamicOffer> m_cachedOffers;

		[Token(Token = "0x170006E6")]
		public string Reference
		{
			[Token(Token = "0x60027CB")]
			[Address(RVA = "0xA5D494", Offset = "0xA5D494", VA = "0xA5D494")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E7")]
		public bool IsUnlimited
		{
			[Token(Token = "0x60027CC")]
			[Address(RVA = "0xA5D4C0", Offset = "0xA5D4C0", VA = "0xA5D4C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170006E8")]
		public string AssetBundle
		{
			[Token(Token = "0x60027CD")]
			[Address(RVA = "0xA5D4EC", Offset = "0xA5D4EC", VA = "0xA5D4EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E9")]
		public string PrefabPath
		{
			[Token(Token = "0x60027CE")]
			[Address(RVA = "0xA5D518", Offset = "0xA5D518", VA = "0xA5D518")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006EA")]
		public string HudIconReference
		{
			[Token(Token = "0x60027CF")]
			[Address(RVA = "0xA5D544", Offset = "0xA5D544", VA = "0xA5D544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006EB")]
		public string LobbyBannerReference
		{
			[Token(Token = "0x60027D0")]
			[Address(RVA = "0xA5D570", Offset = "0xA5D570", VA = "0xA5D570")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006EC")]
		public string Title
		{
			[Token(Token = "0x60027D1")]
			[Address(RVA = "0xA5D59C", Offset = "0xA5D59C", VA = "0xA5D59C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006ED")]
		public string Subtitle
		{
			[Token(Token = "0x60027D2")]
			[Address(RVA = "0xA5D5C8", Offset = "0xA5D5C8", VA = "0xA5D5C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006EE")]
		public string Description
		{
			[Token(Token = "0x60027D3")]
			[Address(RVA = "0xA5D5F4", Offset = "0xA5D5F4", VA = "0xA5D5F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006EF")]
		public string TimerDescription
		{
			[Token(Token = "0x60027D4")]
			[Address(RVA = "0xA5D620", Offset = "0xA5D620", VA = "0xA5D620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F0")]
		public ImageSourceType BackgroundType
		{
			[Token(Token = "0x60027D5")]
			[Address(RVA = "0xA5D64C", Offset = "0xA5D64C", VA = "0xA5D64C")]
			get
			{
				return default(ImageSourceType);
			}
		}

		[Token(Token = "0x170006F1")]
		public string BackgroundPath
		{
			[Token(Token = "0x60027D6")]
			[Address(RVA = "0xA5D678", Offset = "0xA5D678", VA = "0xA5D678")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F2")]
		public bool UseGlobalScarcity
		{
			[Token(Token = "0x60027D7")]
			[Address(RVA = "0xA5D6A4", Offset = "0xA5D6A4", VA = "0xA5D6A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60027CA")]
		[Address(RVA = "0xA5D434", Offset = "0xA5D434", VA = "0xA5D434")]
		public DynamicOfferSet(RDDynamicOfferSet setData, DynamicOffers dynamicOffers, SalesRecordController salesRecords, UkenTimeController time, CasualGame game, InventoryController inventory)
		{
		}

		[Token(Token = "0x60027D8")]
		[Address(RVA = "0xA5D6D0", Offset = "0xA5D6D0", VA = "0xA5D6D0", Slot = "9")]
		public bool InsertTemporarySchedule(DateTime startTime, DateTime endTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60027D9")]
		[Address(RVA = "0xA5D744", Offset = "0xA5D744", VA = "0xA5D744")]
		public bool ShowOffer(bool enforceViewLimits, int recordExpiry, string source, Action<bool> onPurchaseComplete)
		{
			return default(bool);
		}

		[Token(Token = "0x60027DA")]
		[Address(RVA = "0xA5E4C0", Offset = "0xA5E4C0", VA = "0xA5E4C0")]
		public bool ShowExistingOffer(bool enforceViewLimits, Action<bool> onPurchaseComplete)
		{
			return default(bool);
		}

		[Token(Token = "0x60027DB")]
		[Address(RVA = "0xA5DB90", Offset = "0xA5DB90", VA = "0xA5DB90")]
		public bool UserHasAssets()
		{
			return default(bool);
		}

		[Token(Token = "0x60027DC")]
		[Address(RVA = "0xA5E5FC", Offset = "0xA5E5FC", VA = "0xA5E5FC")]
		public DynamicOffer GetCurrentOffer()
		{
			return null;
		}

		[Token(Token = "0x60027DD")]
		[Address(RVA = "0xA5E744", Offset = "0xA5E744", VA = "0xA5E744")]
		public List<DynamicOffer> GetAllOffers()
		{
			return null;
		}

		[Token(Token = "0x60027DE")]
		[Address(RVA = "0xA5E470", Offset = "0xA5E470", VA = "0xA5E470")]
		protected bool InstantiateView(Action<bool> onPurchaseComplete)
		{
			return default(bool);
		}

		[Token(Token = "0x60027DF")]
		[Address(RVA = "0xA5E8A0", Offset = "0xA5E8A0", VA = "0xA5E8A0")]
		public Sale GetCurrentSale()
		{
			return null;
		}

		[Token(Token = "0x60027E0")]
		[Address(RVA = "0xA5E918", Offset = "0xA5E918", VA = "0xA5E918")]
		protected void OnPurchaseComplete(UkenPurchaseResult result)
		{
		}

		[Token(Token = "0x60027E1")]
		[Address(RVA = "0xA5E9A8", Offset = "0xA5E9A8", VA = "0xA5E9A8")]
		public string GetTriggerSource()
		{
			return null;
		}

		[Token(Token = "0x60027E2")]
		[Address(RVA = "0xA5DB98", Offset = "0xA5DB98", VA = "0xA5DB98")]
		public void RefreshCurrentOffer()
		{
		}

		[Token(Token = "0x60027E3")]
		[Address(RVA = "0xA5DFAC", Offset = "0xA5DFAC", VA = "0xA5DFAC")]
		public bool IsVisible(double currentTime, [Optional] SalesRecordV2 record)
		{
			return default(bool);
		}

		[Token(Token = "0x60027E4")]
		[Address(RVA = "0xA5EA28", Offset = "0xA5EA28", VA = "0xA5EA28")]
		public void OnSaleHudIconClicked(IEvent resource)
		{
		}

		[Token(Token = "0x60027E5")]
		[Address(RVA = "0xA5EA34", Offset = "0xA5EA34", VA = "0xA5EA34")]
		public string GetTimeRemainingString()
		{
			return null;
		}

		[Token(Token = "0x60027E6")]
		[Address(RVA = "0xA5EC2C", Offset = "0xA5EC2C", VA = "0xA5EC2C")]
		public string GetQuantityRemainingString()
		{
			return null;
		}

		[Token(Token = "0x60027E7")]
		[Address(RVA = "0xA5ED7C", Offset = "0xA5ED7C", VA = "0xA5ED7C")]
		public List<string> GetImageURLs()
		{
			return null;
		}

		[Token(Token = "0x60027E8")]
		[Address(RVA = "0xA5EE60", Offset = "0xA5EE60", VA = "0xA5EE60")]
		public List<string> GetCustomImagePaths()
		{
			return null;
		}

		[Token(Token = "0x60027E9")]
		[Address(RVA = "0xA5EEE0", Offset = "0xA5EEE0", VA = "0xA5EEE0")]
		public List<string> GetCustomTexts()
		{
			return null;
		}

		[Token(Token = "0x60027EA")]
		[Address(RVA = "0xA5EF60", Offset = "0xA5EF60", VA = "0xA5EF60")]
		public int GetCurrentOfferIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60027EB")]
		[Address(RVA = "0xA5EFB4", Offset = "0xA5EFB4", VA = "0xA5EFB4")]
		public void RecordView()
		{
		}

		[Token(Token = "0x60027EC")]
		[Address(RVA = "0xA5F018", Offset = "0xA5F018", VA = "0xA5F018")]
		public bool IsExpired()
		{
			return default(bool);
		}

		[Token(Token = "0x60027ED")]
		[Address(RVA = "0xA5F098", Offset = "0xA5F098", VA = "0xA5F098", Slot = "4")]
		public bool IsResourceActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60027EE")]
		[Address(RVA = "0xA5F0D8", Offset = "0xA5F0D8", VA = "0xA5F0D8", Slot = "5")]
		public DateTime ResourceStartTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60027EF")]
		[Address(RVA = "0xA5F140", Offset = "0xA5F140", VA = "0xA5F140", Slot = "6")]
		public DateTime ResourceEndTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60027F0")]
		[Address(RVA = "0xA5F204", Offset = "0xA5F204", VA = "0xA5F204", Slot = "7")]
		public int GetNotificationCount()
		{
			return default(int);
		}

		[Token(Token = "0x60027F1")]
		[Address(RVA = "0xA5F20C", Offset = "0xA5F20C", VA = "0xA5F20C", Slot = "8")]
		public string GetSpecialText()
		{
			return null;
		}
	}
}
