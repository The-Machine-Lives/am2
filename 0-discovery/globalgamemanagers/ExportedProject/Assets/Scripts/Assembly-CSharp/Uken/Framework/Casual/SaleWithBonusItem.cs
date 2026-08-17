using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.IAP;
using Uken.Library.Inventory;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000544")]
	public class SaleWithBonusItem : Sale
	{
		[Token(Token = "0x400190B")]
		[FieldOffset(Offset = "0x40")]
		private PurchaseItem m_bonusItem;

		[Token(Token = "0x600283D")]
		[Address(RVA = "0xA8DC88", Offset = "0xA8DC88", VA = "0xA8DC88")]
		public SaleWithBonusItem(RDSale saleData, List<PurchaseItem> purchaseItems, CasualGame game, UkenPaymentProvider paymentProvider, InventoryController inventory, ItemController items, PurchaseItem bonusItem)
		{
		}

		[Token(Token = "0x600283E")]
		[Address(RVA = "0xA8E79C", Offset = "0xA8E79C", VA = "0xA8E79C", Slot = "4")]
		public override PurchaseItem GetBonusItem()
		{
			return null;
		}

		[Token(Token = "0x600283F")]
		[Address(RVA = "0xA8E7A4", Offset = "0xA8E7A4", VA = "0xA8E7A4", Slot = "5")]
		public override List<PurchaseItem> GetPurchaseItems()
		{
			return null;
		}
	}
}
