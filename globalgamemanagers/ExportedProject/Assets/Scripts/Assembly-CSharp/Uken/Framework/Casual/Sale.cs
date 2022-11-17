using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.IAP;
using Uken.Library.Inventory;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000540")]
	public class Sale
	{
		[Token(Token = "0x40018EA")]
		public const int MAX_PURCHASE_ITEMS = 4;

		[Token(Token = "0x40018EB")]
		[FieldOffset(Offset = "0x10")]
		private RDSale m_saleData;

		[Token(Token = "0x40018EC")]
		[FieldOffset(Offset = "0x18")]
		private List<PurchaseItem> m_purchaseItems;

		[Token(Token = "0x40018ED")]
		[FieldOffset(Offset = "0x20")]
		private CasualGame m_game;

		[Token(Token = "0x40018EE")]
		[FieldOffset(Offset = "0x28")]
		private UkenPaymentProvider m_paymentProvider;

		[Token(Token = "0x40018EF")]
		[FieldOffset(Offset = "0x30")]
		private InventoryController m_inventory;

		[Token(Token = "0x40018F0")]
		[FieldOffset(Offset = "0x38")]
		private ItemController m_items;

		[Token(Token = "0x170006FA")]
		public string Reference
		{
			[Token(Token = "0x6002811")]
			[Address(RVA = "0xA8D088", Offset = "0xA8D088", VA = "0xA8D088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006FB")]
		public string VirtualCurrency
		{
			[Token(Token = "0x6002812")]
			[Address(RVA = "0xA8D0B4", Offset = "0xA8D0B4", VA = "0xA8D0B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006FC")]
		public int VirtualCost
		{
			[Token(Token = "0x6002813")]
			[Address(RVA = "0xA8D0E0", Offset = "0xA8D0E0", VA = "0xA8D0E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006FD")]
		public string BannerText
		{
			[Token(Token = "0x6002814")]
			[Address(RVA = "0xA8D10C", Offset = "0xA8D10C", VA = "0xA8D10C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006FE")]
		public string BadgeTextTop
		{
			[Token(Token = "0x6002815")]
			[Address(RVA = "0xA8D138", Offset = "0xA8D138", VA = "0xA8D138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006FF")]
		public string BadgeTextBottom
		{
			[Token(Token = "0x6002816")]
			[Address(RVA = "0xA8D164", Offset = "0xA8D164", VA = "0xA8D164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002810")]
		[Address(RVA = "0xA8D028", Offset = "0xA8D028", VA = "0xA8D028")]
		public Sale(RDSale saleData, List<PurchaseItem> purchaseItems, CasualGame game, UkenPaymentProvider paymentProvider, InventoryController inventory, ItemController items)
		{
		}

		[Token(Token = "0x6002817")]
		[Address(RVA = "0xA8D190", Offset = "0xA8D190", VA = "0xA8D190", Slot = "4")]
		public virtual PurchaseItem GetBonusItem()
		{
			return null;
		}

		[Token(Token = "0x6002818")]
		[Address(RVA = "0xA8D198", Offset = "0xA8D198", VA = "0xA8D198")]
		private void PurchaseWithVirtualCurrency(Action<UkenPurchaseResult, Dictionary<string, long>> onPurchaseComplete)
		{
		}

		[Token(Token = "0x6002819")]
		[Address(RVA = "0xA8D614", Offset = "0xA8D614", VA = "0xA8D614")]
		private void CollectRewards(Action<UkenPurchaseResult, Dictionary<string, long>> onPurchaseComplete)
		{
		}

		[Token(Token = "0x600281A")]
		[Address(RVA = "0xA8D6E4", Offset = "0xA8D6E4", VA = "0xA8D6E4")]
		protected UkenPurchasePayload GetCustomPayload()
		{
			return null;
		}

		[Token(Token = "0x600281B")]
		[Address(RVA = "0xA8D374", Offset = "0xA8D374", VA = "0xA8D374")]
		public Dictionary<string, long> GetItems()
		{
			return null;
		}

		[Token(Token = "0x600281C")]
		[Address(RVA = "0xA8D778", Offset = "0xA8D778", VA = "0xA8D778", Slot = "5")]
		public virtual List<PurchaseItem> GetPurchaseItems()
		{
			return null;
		}

		[Token(Token = "0x600281D")]
		[Address(RVA = "0xA8D908", Offset = "0xA8D908", VA = "0xA8D908")]
		public List<string> GetImageURLs()
		{
			return null;
		}

		[Token(Token = "0x600281E")]
		[Address(RVA = "0xA8DAC4", Offset = "0xA8DAC4", VA = "0xA8DAC4")]
		public bool IsVirtualPurchase()
		{
			return default(bool);
		}

		[Token(Token = "0x600281F")]
		[Address(RVA = "0xA8DB44", Offset = "0xA8DB44", VA = "0xA8DB44")]
		public bool IsIAPPurchase()
		{
			return default(bool);
		}

		[Token(Token = "0x6002820")]
		[Address(RVA = "0xA8DB80", Offset = "0xA8DB80", VA = "0xA8DB80")]
		public bool ShowsBadge()
		{
			return default(bool);
		}

		[Token(Token = "0x6002821")]
		[Address(RVA = "0xA8DBE8", Offset = "0xA8DBE8", VA = "0xA8DBE8")]
		public SaleWithBonusItem CreateSaleWithBonusItem(PurchaseItem bonusItem)
		{
			return null;
		}
	}
}
