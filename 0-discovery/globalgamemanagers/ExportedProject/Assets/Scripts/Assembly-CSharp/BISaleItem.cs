using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.IAP;

[Token(Token = "0x20001CA")]
public class BISaleItem : SaleItem
{
	[Token(Token = "0x6000C48")]
	[Address(RVA = "0xA41A3C", Offset = "0xA41A3C", VA = "0xA41A3C")]
	public BISaleItem(RDSaleItem saleData, ProductController productController, List<UserSegment> userSegments, UkenPaymentProvider paymentProvider, PurchaseProfiler purchaseProfiler, Func<bool> isOnlineCallback)
	{
	}

	[Token(Token = "0x6000C49")]
	[Address(RVA = "0xA41A44", Offset = "0xA41A44", VA = "0xA41A44", Slot = "13")]
	protected override void LogPurchaseState(UkenPurchaseResult result, string customPayload)
	{
	}
}
