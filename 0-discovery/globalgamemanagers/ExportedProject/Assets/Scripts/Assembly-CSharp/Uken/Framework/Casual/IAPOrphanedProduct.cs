using System;
using Com.Uken.Analog;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Serializable]
	[Token(Token = "0x20004C8")]
	public class IAPOrphanedProduct : GenericEvent
	{
		[Token(Token = "0x6002410")]
		[Address(RVA = "0xA68C1C", Offset = "0xA68C1C", VA = "0xA68C1C")]
		public IAPOrphanedProduct(string provider_transaction_id, string receipt, string vendor_id)
		{
		}
	}
}
