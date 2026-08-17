using Il2CppDummyDll;
using Uken.Library.IAP;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004CE")]
	public class CLogSaleItemPurchaseState : CasualAnalogData
	{
		[Token(Token = "0x6002451")]
		[Address(RVA = "0xA263F4", Offset = "0xA263F4", VA = "0xA263F4")]
		public CLogSaleItemPurchaseState(string saleReference, double price, string customPayload, UkenPurchaseResult purchase_result, string virtualCurrency, int virtualCost)
		{
		}
	}
}
