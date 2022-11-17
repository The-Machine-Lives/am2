using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.IAP;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000521")]
	public abstract class DynamicSaleItem : IEvent
	{
		[Token(Token = "0x40017F9")]
		[FieldOffset(Offset = "0x10")]
		protected RDDynamicSaleItem m_dynamicSaleItemData;

		[Token(Token = "0x40017FA")]
		[FieldOffset(Offset = "0x18")]
		protected SaleItemController m_saleItemController;

		[Token(Token = "0x40017FB")]
		[FieldOffset(Offset = "0x20")]
		protected UserProfiler m_userProfiler;

		[Token(Token = "0x40017FC")]
		[FieldOffset(Offset = "0x28")]
		protected UkenTimeController m_timeController;

		[Token(Token = "0x40017FD")]
		[FieldOffset(Offset = "0x30")]
		protected PurchaseProfiler m_purchaseProfiler;

		[Token(Token = "0x40017FE")]
		[FieldOffset(Offset = "0x38")]
		protected UkenPaymentProvider m_paymentProvider;

		[Token(Token = "0x40017FF")]
		[FieldOffset(Offset = "0x40")]
		protected Func<bool> m_isOnlineCallback;

		[Token(Token = "0x4001800")]
		[FieldOffset(Offset = "0x48")]
		protected EventSchedule m_schedule;

		[Token(Token = "0x4001801")]
		[FieldOffset(Offset = "0x50")]
		protected LTOSet m_parentLTOset;

		[Token(Token = "0x4001802")]
		public const string EVENT_TYPE_LOGGING_KEY = "dynamic_sale_item";

		[Token(Token = "0x4001803")]
		[FieldOffset(Offset = "0x58")]
		protected int m_startingQuantity;

		[Token(Token = "0x4001804")]
		[FieldOffset(Offset = "0x5C")]
		protected bool m_useGlobalScarcity;

		[Token(Token = "0x4001805")]
		[FieldOffset(Offset = "0x60")]
		private SaleItem m_saleItem;

		[Token(Token = "0x170006AC")]
		public string Reference
		{
			[Token(Token = "0x60026E3")]
			[Address(RVA = "0xA5FC9C", Offset = "0xA5FC9C", VA = "0xA5FC9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006AD")]
		public int DisplayPriority
		{
			[Token(Token = "0x60026E4")]
			[Address(RVA = "0xA5FCC8", Offset = "0xA5FCC8", VA = "0xA5FCC8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006AE")]
		public bool IsUnlimited
		{
			[Token(Token = "0x60026E5")]
			[Address(RVA = "0xA5FCF4", Offset = "0xA5FCF4", VA = "0xA5FCF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170006AF")]
		public int PurchaseLimit
		{
			[Token(Token = "0x60026E6")]
			[Address(RVA = "0xA5FD20", Offset = "0xA5FD20", VA = "0xA5FD20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006B0")]
		public string HudIconReference
		{
			[Token(Token = "0x60026E7")]
			[Address(RVA = "0xA5FD4C", Offset = "0xA5FD4C", VA = "0xA5FD4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B1")]
		public LTOSet LTOSet
		{
			[Token(Token = "0x60026E8")]
			[Address(RVA = "0xA5FD78", Offset = "0xA5FD78", VA = "0xA5FD78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B2")]
		public string title
		{
			[Token(Token = "0x60026E9")]
			[Address(RVA = "0xA5FD80", Offset = "0xA5FD80", VA = "0xA5FD80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B3")]
		public string subtitle
		{
			[Token(Token = "0x60026EA")]
			[Address(RVA = "0xA5FDAC", Offset = "0xA5FDAC", VA = "0xA5FDAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B4")]
		public int StartingScarcityQuantity
		{
			[Token(Token = "0x60026EB")]
			[Address(RVA = "0xA5FDD8", Offset = "0xA5FDD8", VA = "0xA5FDD8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006B5")]
		public bool UseGlobalScarcity
		{
			[Token(Token = "0x60026EC")]
			[Address(RVA = "0xA5FDE0", Offset = "0xA5FDE0", VA = "0xA5FDE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170006B6")]
		public string lobbyBannerReference
		{
			[Token(Token = "0x60026ED")]
			[Address(RVA = "0xA5FDE8", Offset = "0xA5FDE8", VA = "0xA5FDE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B7")]
		public bool ExcludeIfNewSalesActive
		{
			[Token(Token = "0x60026EE")]
			[Address(RVA = "0xA5FE14", Offset = "0xA5FE14", VA = "0xA5FE14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60026EF")]
		[Address(RVA = "0xA5FE40", Offset = "0xA5FE40", VA = "0xA5FE40")]
		public DynamicSaleItem(RDSaleItem saleData, ProductController productController, RDDynamicSaleItem dynamicSaleData, EventSchedule schedule, SaleItemController saleItemController, UserProfiler userProfiler, PurchaseProfiler purchaseProfiler, UkenTimeController timeController, UkenPaymentProvider paymentProvider, Func<bool> isOnlineCallback)
		{
		}

		[Token(Token = "0x60026F0")]
		[Address(RVA = "0xA5FEE4", Offset = "0xA5FEE4", VA = "0xA5FEE4")]
		public bool RequiresHudIcon()
		{
			return default(bool);
		}

		[Token(Token = "0x60026F1")]
		[Address(RVA = "0xA5FF20", Offset = "0xA5FF20", VA = "0xA5FF20", Slot = "9")]
		public bool InsertTemporarySchedule(DateTime startTime, DateTime endTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60026F2")]
		[Address(RVA = "0xA601BC", Offset = "0xA601BC", VA = "0xA601BC")]
		public bool IsAvailable()
		{
			return default(bool);
		}

		[Token(Token = "0x60026F3")]
		[Address(RVA = "0xA602F0", Offset = "0xA602F0", VA = "0xA602F0")]
		public TimeSpan GetSaleDuration()
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x60026F4")]
		[Address(RVA = "0xA6053C", Offset = "0xA6053C", VA = "0xA6053C")]
		public bool ShowsTimer()
		{
			return default(bool);
		}

		[Token(Token = "0x60026F5")]
		[Address(RVA = "0xA60570", Offset = "0xA60570", VA = "0xA60570")]
		public int GetCurrentIteration()
		{
			return default(int);
		}

		[Token(Token = "0x60026F6")]
		[Address(RVA = "0xA6084C", Offset = "0xA6084C", VA = "0xA6084C")]
		public bool IsExpired()
		{
			return default(bool);
		}

		[Token(Token = "0x60026F7")]
		[Address(RVA = "0xA608F4", Offset = "0xA608F4", VA = "0xA608F4")]
		public DateTime GetFurthestPossibleEndTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60026F8")]
		[Address(RVA = "0xA60A70", Offset = "0xA60A70", VA = "0xA60A70")]
		public DateTime GetViewExpirationTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60026F9")]
		[Address(RVA = "0xA60BA0", Offset = "0xA60BA0", VA = "0xA60BA0")]
		public TimeSpan GetViewFrequencyLimit()
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x60026FA")]
		[Address(RVA = "0xA60BEC", Offset = "0xA60BEC", VA = "0xA60BEC")]
		private string GetTimeRemainingString()
		{
			return null;
		}

		[Token(Token = "0x60026FB")]
		[Address(RVA = "0xA60DEC", Offset = "0xA60DEC", VA = "0xA60DEC")]
		private string GetQuantityRemaining()
		{
			return null;
		}

		[Token(Token = "0x60026FC")]
		[Address(RVA = "0xA60F48", Offset = "0xA60F48", VA = "0xA60F48", Slot = "10")]
		public virtual Dictionary<string, int> GetItems()
		{
			return null;
		}

		[Token(Token = "0x60026FD")]
		[Address(RVA = "0xA6127C", Offset = "0xA6127C", VA = "0xA6127C", Slot = "11")]
		public virtual int GetPurchaseType()
		{
			return default(int);
		}

		[Token(Token = "0x60026FE")]
		[Address(RVA = "0xA61284", Offset = "0xA61284", VA = "0xA61284", Slot = "12")]
		protected virtual void LogPurchaseState(UkenPurchaseResult result, string customPayload)
		{
		}

		[Token(Token = "0x60026FF")]
		[Address(RVA = "0xA61288", Offset = "0xA61288", VA = "0xA61288")]
		public string SaleItemReference()
		{
			return null;
		}

		[Token(Token = "0x6002700")]
		[Address(RVA = "0xA612D4", Offset = "0xA612D4", VA = "0xA612D4")]
		public bool ShowsBadge()
		{
			return default(bool);
		}

		[Token(Token = "0x6002701")]
		[Address(RVA = "0xA61300", Offset = "0xA61300", VA = "0xA61300")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6002702")]
		[Address(RVA = "0xA61328", Offset = "0xA61328", VA = "0xA61328")]
		public List<string> GetImageURLs()
		{
			return null;
		}

		[Token(Token = "0x6002703")]
		[Address(RVA = "0xA613B4", Offset = "0xA613B4", VA = "0xA613B4")]
		public bool UpdateSaleItemOnRecord(SaleItem saleItem)
		{
			return default(bool);
		}

		[Token(Token = "0x6002704")]
		[Address(RVA = "0xA6140C", Offset = "0xA6140C", VA = "0xA6140C", Slot = "13")]
		protected virtual void OnPurchaseComplete(UkenPurchaseResult result)
		{
		}

		[Token(Token = "0x6002705")]
		[Address(RVA = "0xA61444", Offset = "0xA61444", VA = "0xA61444")]
		public ImageSourceType GetBackgroundImageSourceType()
		{
			return default(ImageSourceType);
		}

		[Token(Token = "0x6002706")]
		[Address(RVA = "0xA61474", Offset = "0xA61474", VA = "0xA61474")]
		public string GetBackgroundImageSourcePath()
		{
			return null;
		}

		[Token(Token = "0x6002707")]
		[Address(RVA = "0xA614E4", Offset = "0xA614E4", VA = "0xA614E4")]
		public List<Product> GetProducts()
		{
			return null;
		}

		[Token(Token = "0x6002708")]
		[Address(RVA = "0xA6121C", Offset = "0xA6121C", VA = "0xA6121C")]
		protected SaleItem GetSaleItem()
		{
			return null;
		}

		[Token(Token = "0x6002709")]
		[Address(RVA = "0xA61634", Offset = "0xA61634", VA = "0xA61634")]
		public string GetReference()
		{
			return null;
		}

		[Token(Token = "0x600270A")]
		[Address(RVA = "0xA61660", Offset = "0xA61660", VA = "0xA61660")]
		public bool IsVisible(DateTime currentTime)
		{
			return default(bool);
		}

		[Token(Token = "0x600270B")]
		[Address(RVA = "0xA618DC", Offset = "0xA618DC", VA = "0xA618DC")]
		public void RecordView()
		{
		}

		[Token(Token = "0x600270C")]
		[Address(RVA = "0xA61944", Offset = "0xA61944", VA = "0xA61944", Slot = "14")]
		protected virtual void UpdateSalesRecordOnPurchase()
		{
		}

		[Token(Token = "0x600270D")]
		[Address(RVA = "0xA619AC", Offset = "0xA619AC", VA = "0xA619AC", Slot = "15")]
		protected virtual void UpdateSalesRecordOnSuccess()
		{
		}

		[Token(Token = "0x600270E")]
		[Address(RVA = "0xA61A20", Offset = "0xA61A20", VA = "0xA61A20", Slot = "16")]
		protected virtual void UpdateSalesRecordOnFailure()
		{
		}

		[Token(Token = "0x600270F")]
		[Address(RVA = "0xA61A88", Offset = "0xA61A88", VA = "0xA61A88")]
		public bool ReserveSalesRecord(bool enforceViewLimits)
		{
			return default(bool);
		}

		[Token(Token = "0x6002710")]
		[Address(RVA = "0xA61570", Offset = "0xA61570", VA = "0xA61570")]
		public SaleItem GetSaleByReference(string saleReference)
		{
			return null;
		}

		[Token(Token = "0x6002711")]
		[Address(RVA = "0xA61D8C", Offset = "0xA61D8C", VA = "0xA61D8C")]
		public SaleItem GetSaleItemForUser()
		{
			return null;
		}

		[Token(Token = "0x6002712")]
		[Address(RVA = "0xA61F60", Offset = "0xA61F60", VA = "0xA61F60")]
		public List<SaleItem> GetSaleItemsForUser(int maxCount = 0)
		{
			return null;
		}

		[Token(Token = "0x6002713")]
		[Address(RVA = "0xA621CC", Offset = "0xA621CC", VA = "0xA621CC")]
		protected bool HasSurfacePointInteger(int surfacePointInteger)
		{
			return default(bool);
		}

		[Token(Token = "0x6002714")]
		[Address(RVA = "0xA62254", Offset = "0xA62254", VA = "0xA62254")]
		public DateTime GetStartTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x6002715")]
		[Address(RVA = "0xA62280", Offset = "0xA62280", VA = "0xA62280", Slot = "17")]
		public virtual DateTime GetEndTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x6002716")]
		[Address(RVA = "0xA62350", Offset = "0xA62350", VA = "0xA62350")]
		public void SetLTOSet(LTOSet parentLTOset)
		{
		}

		[Token(Token = "0x6002717")]
		[Address(RVA = "0xA62358", Offset = "0xA62358", VA = "0xA62358")]
		public bool PurchasedToLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x6002718")]
		[Address(RVA = "0xA623C0", Offset = "0xA623C0", VA = "0xA623C0", Slot = "4")]
		public bool IsResourceActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6002719")]
		[Address(RVA = "0xA62400", Offset = "0xA62400", VA = "0xA62400", Slot = "5")]
		public DateTime ResourceStartTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x600271A")]
		[Address(RVA = "0xA62404", Offset = "0xA62404", VA = "0xA62404", Slot = "6")]
		public DateTime ResourceEndTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x600271B")]
		[Address(RVA = "0xA62414", Offset = "0xA62414", VA = "0xA62414", Slot = "7")]
		public int GetNotificationCount()
		{
			return default(int);
		}

		[Token(Token = "0x600271C")]
		[Address(RVA = "0xA6241C", Offset = "0xA6241C", VA = "0xA6241C", Slot = "8")]
		public string GetSpecialText()
		{
			return null;
		}

		[Token(Token = "0x600271D")]
		public abstract ISaleView Show(bool enforceViewLimits, float showDelay, bool allowLTOSetOverride = true);

		[Token(Token = "0x600271E")]
		[Address(RVA = "0xA6246C", Offset = "0xA6246C", VA = "0xA6246C", Slot = "19")]
		public virtual void OnSaleHudIconClicked(IEvent resource)
		{
		}
	}
}
