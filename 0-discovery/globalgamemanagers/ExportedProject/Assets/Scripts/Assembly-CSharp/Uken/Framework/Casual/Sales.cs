using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.IAP;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000541")]
	public class Sales : DepotController
	{
		[Token(Token = "0x40018F1")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, Sale> m_cachedSales;

		[Token(Token = "0x40018F2")]
		[FieldOffset(Offset = "0x28")]
		private CasualGame m_game;

		[Token(Token = "0x40018F3")]
		[FieldOffset(Offset = "0x30")]
		private PurchaseItems m_purchaseItems;

		[Token(Token = "0x40018F4")]
		[FieldOffset(Offset = "0x38")]
		private UkenPaymentProvider m_paymentProvider;

		[Token(Token = "0x40018F5")]
		[FieldOffset(Offset = "0x40")]
		private InventoryController m_inventory;

		[Token(Token = "0x40018F6")]
		[FieldOffset(Offset = "0x48")]
		private ItemController m_items;

		[Token(Token = "0x17000700")]
		private DepotEntity<RDSale> m_sales
		{
			[Token(Token = "0x6002822")]
			[Address(RVA = "0xA8E968", Offset = "0xA8E968", VA = "0xA8E968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002823")]
		[Address(RVA = "0xA8EAD0", Offset = "0xA8EAD0", VA = "0xA8EAD0")]
		public Sales(CasualGame game, DataStoreController dataStoreController)
		{
		}

		[Token(Token = "0x6002824")]
		[Address(RVA = "0xA8EB5C", Offset = "0xA8EB5C", VA = "0xA8EB5C", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6002825")]
		[Address(RVA = "0xA8EC00", Offset = "0xA8EC00", VA = "0xA8EC00")]
		public Sale Get(string reference)
		{
			return null;
		}
	}
}
