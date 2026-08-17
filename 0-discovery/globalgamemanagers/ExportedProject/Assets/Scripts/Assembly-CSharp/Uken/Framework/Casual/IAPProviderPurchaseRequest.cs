using System;
using Com.Uken.Analog;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Serializable]
	[Token(Token = "0x20004C6")]
	public class IAPProviderPurchaseRequest : GenericEvent
	{
		[Token(Token = "0x600240E")]
		[Address(RVA = "0xA6905C", Offset = "0xA6905C", VA = "0xA6905C")]
		public IAPProviderPurchaseRequest(string uken_transaction_id, string product_name, string product_data, string vendor_id, string currency_code, double usd_price)
		{
		}
	}
}
