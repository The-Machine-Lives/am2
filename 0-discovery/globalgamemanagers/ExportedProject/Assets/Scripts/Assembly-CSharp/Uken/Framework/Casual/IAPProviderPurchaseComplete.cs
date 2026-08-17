using System;
using Com.Uken.Analog;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Serializable]
	[Token(Token = "0x20004C7")]
	public class IAPProviderPurchaseComplete : GenericEvent
	{
		[Token(Token = "0x600240F")]
		[Address(RVA = "0xA68CEC", Offset = "0xA68CEC", VA = "0xA68CEC")]
		public IAPProviderPurchaseComplete(string uken_transaction_id, string provider_transaction_id, string product_name, string product_data, string vendor_id, string currency_code, double usd_price, string result, string is_retry)
		{
		}
	}
}
