using System;
using Com.Uken.Analog;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Serializable]
	[Token(Token = "0x20004C3")]
	public class IAPProviderPurchaseFailure : GenericEvent
	{
		[Token(Token = "0x600240B")]
		[Address(RVA = "0xA68EB0", Offset = "0xA68EB0", VA = "0xA68EB0")]
		public IAPProviderPurchaseFailure(string reason, string provider_transaction_id, string uken_transaction_id, string product_name, string product_data, string vendor_id, string currency_code, double usd_price)
		{
		}
	}
}
