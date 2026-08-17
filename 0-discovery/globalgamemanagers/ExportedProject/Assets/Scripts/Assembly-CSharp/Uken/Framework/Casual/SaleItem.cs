using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.IAP;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200052F")]
	public abstract class SaleItem
	{
		[Token(Token = "0x4001883")]
		public const string EVENT_TYPE_LOGGING_KEY = "sale_item";

		[Token(Token = "0x4001884")]
		[FieldOffset(Offset = "0x10")]
		protected UkenPaymentProvider m_paymentProvider;

		[Token(Token = "0x4001885")]
		[FieldOffset(Offset = "0x18")]
		protected PurchaseProfiler m_purchaseProfiler;

		[Token(Token = "0x4001886")]
		[FieldOffset(Offset = "0x20")]
		protected Func<bool> m_isOnlineCallback;

		[Token(Token = "0x4001887")]
		[FieldOffset(Offset = "0x28")]
		protected RDSaleItem m_saleData;

		[Token(Token = "0x4001888")]
		[FieldOffset(Offset = "0x30")]
		protected List<UserSegment> m_userSegments;

		[Token(Token = "0x4001889")]
		[FieldOffset(Offset = "0x38")]
		protected ProductController m_productController;

		[Token(Token = "0x170006DA")]
		public virtual string Reference
		{
			[Token(Token = "0x60027A0")]
			[Address(RVA = "0xA8DCF0", Offset = "0xA8DCF0", VA = "0xA8DCF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60027A1")]
		[Address(RVA = "0xA8DD1C", Offset = "0xA8DD1C", VA = "0xA8DD1C")]
		public SaleItem(RDSaleItem saleData, ProductController productController, List<UserSegment> userSegments, UkenPaymentProvider paymentProvider, PurchaseProfiler purchaseProfiler, Func<bool> isOnlineCallback)
		{
		}

		[Token(Token = "0x60027A2")]
		[Address(RVA = "0xA8DD7C", Offset = "0xA8DD7C", VA = "0xA8DD7C", Slot = "5")]
		public virtual SaleItem GetSaleItem()
		{
			return null;
		}

		[Token(Token = "0x60027A3")]
		[Address(RVA = "0xA8DD80", Offset = "0xA8DD80", VA = "0xA8DD80", Slot = "6")]
		public virtual bool CanShowUser(UserProfiler user)
		{
			return default(bool);
		}

		[Token(Token = "0x60027A4")]
		[Address(RVA = "0xA8DEC8", Offset = "0xA8DEC8", VA = "0xA8DEC8", Slot = "7")]
		public virtual bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60027A5")]
		[Address(RVA = "0xA8DEF8", Offset = "0xA8DEF8", VA = "0xA8DEF8", Slot = "8")]
		public virtual bool IsVirtualPurchase()
		{
			return default(bool);
		}

		[Token(Token = "0x60027A6")]
		[Address(RVA = "0xA8DF00", Offset = "0xA8DF00", VA = "0xA8DF00", Slot = "9")]
		public virtual int GetPurchaseType()
		{
			return default(int);
		}

		[Token(Token = "0x60027A7")]
		[Address(RVA = "0xA8DF08", Offset = "0xA8DF08", VA = "0xA8DF08", Slot = "10")]
		public virtual Dictionary<string, long> GetItems()
		{
			return null;
		}

		[Token(Token = "0x60027A8")]
		[Address(RVA = "0xA8E1C8", Offset = "0xA8E1C8", VA = "0xA8E1C8", Slot = "11")]
		protected virtual UkenPurchasePayload GetCustomPayload()
		{
			return null;
		}

		[Token(Token = "0x60027A9")]
		[Address(RVA = "0xA8E27C", Offset = "0xA8E27C", VA = "0xA8E27C", Slot = "12")]
		protected virtual void PurchaseWithVirtualCurrency(Action<UkenPurchaseResult, Dictionary<string, long>> onPurchaseComplete)
		{
		}

		[Token(Token = "0x60027AA")]
		protected abstract void LogPurchaseState(UkenPurchaseResult result, string customPayload);

		[Token(Token = "0x60027AB")]
		[Address(RVA = "0xA8E308", Offset = "0xA8E308", VA = "0xA8E308", Slot = "14")]
		protected virtual void OnPurchaseComplete(UkenPurchaseResult result, UkenPaymentProduct paymentProduct, Dictionary<string, long> finalizedRewards, Action<UkenPurchaseResult, Dictionary<string, long>> onPurchaseComplete)
		{
		}

		[Token(Token = "0x60027AC")]
		[Address(RVA = "0xA8E3D8", Offset = "0xA8E3D8", VA = "0xA8E3D8")]
		public int GetPrefabType()
		{
			return default(int);
		}

		[Token(Token = "0x60027AD")]
		[Address(RVA = "0xA8E404", Offset = "0xA8E404", VA = "0xA8E404", Slot = "15")]
		public virtual string GetReference()
		{
			return null;
		}

		[Token(Token = "0x60027AE")]
		[Address(RVA = "0xA8E430", Offset = "0xA8E430", VA = "0xA8E430", Slot = "16")]
		public virtual List<Product> GetProducts()
		{
			return null;
		}

		[Token(Token = "0x60027AF")]
		[Address(RVA = "0xA8E500", Offset = "0xA8E500", VA = "0xA8E500", Slot = "17")]
		public virtual List<string> GetImageURLs()
		{
			return null;
		}

		[Token(Token = "0x60027B0")]
		[Address(RVA = "0xA8E708", Offset = "0xA8E708", VA = "0xA8E708", Slot = "18")]
		public virtual string GetBackgroundImageSourcePath()
		{
			return null;
		}

		[Token(Token = "0x60027B1")]
		[Address(RVA = "0xA8E734", Offset = "0xA8E734", VA = "0xA8E734", Slot = "19")]
		public virtual ImageSourceType GetBackgroundImageSourceType()
		{
			return default(ImageSourceType);
		}

		[Token(Token = "0x60027B2")]
		[Address(RVA = "0xA8E760", Offset = "0xA8E760", VA = "0xA8E760", Slot = "20")]
		public virtual bool ShowsTimer()
		{
			return default(bool);
		}

		[Token(Token = "0x60027B3")]
		[Address(RVA = "0xA8E768", Offset = "0xA8E768", VA = "0xA8E768", Slot = "21")]
		public virtual bool IsVisible(DateTime currentTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60027B4")]
		[Address(RVA = "0xA8E770", Offset = "0xA8E770", VA = "0xA8E770", Slot = "22")]
		public virtual bool ShowsBadge()
		{
			return default(bool);
		}
	}
}
