using System;
using Com.Uken.Analog;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Serializable]
	[Token(Token = "0x20004C5")]
	public class IAPValiationStart : GenericEvent
	{
		[Token(Token = "0x600240D")]
		[Address(RVA = "0xA6A5AC", Offset = "0xA6A5AC", VA = "0xA6A5AC")]
		public IAPValiationStart(string vendor_id, string product_name, string product_data, string transaction_id, string receipt, string is_retry)
		{
		}
	}
}
