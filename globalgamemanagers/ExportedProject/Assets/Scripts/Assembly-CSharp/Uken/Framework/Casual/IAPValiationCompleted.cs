using System;
using Com.Uken.Analog;
using Il2CppDummyDll;
using Uken.Library.IAP;

namespace Uken.Framework.Casual
{
	[Serializable]
	[Token(Token = "0x20004C4")]
	public class IAPValiationCompleted : GenericEvent
	{
		[Token(Token = "0x600240C")]
		[Address(RVA = "0xA6A3FC", Offset = "0xA6A3FC", VA = "0xA6A3FC")]
		public IAPValiationCompleted(UkenPaymentValidationResult validation_result, string event_name, string vendor_id, string product_name, string product_data, string transaction_id, string receipt, string is_retry)
		{
		}
	}
}
