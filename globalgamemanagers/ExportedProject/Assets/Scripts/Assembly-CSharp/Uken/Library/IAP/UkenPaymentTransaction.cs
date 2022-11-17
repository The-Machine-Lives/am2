using Il2CppDummyDll;

namespace Uken.Library.IAP
{
	[Token(Token = "0x200043B")]
	public class UkenPaymentTransaction
	{
		[Token(Token = "0x4001397")]
		[FieldOffset(Offset = "0x10")]
		public UkenPurchasePayload m_customPayload;

		[Token(Token = "0x4001398")]
		[FieldOffset(Offset = "0x18")]
		public string m_eventName;

		[Token(Token = "0x4001399")]
		[FieldOffset(Offset = "0x20")]
		public string m_sourceSink;

		[Token(Token = "0x400139A")]
		[FieldOffset(Offset = "0x28")]
		public string m_transactionID;

		[Token(Token = "0x400139B")]
		[FieldOffset(Offset = "0x30")]
		public double m_price;

		[Token(Token = "0x400139C")]
		[FieldOffset(Offset = "0x38")]
		public string m_currency;

		[Token(Token = "0x400139D")]
		[FieldOffset(Offset = "0x40")]
		public bool m_bIsRetry;

		[Token(Token = "0x6001F82")]
		[Address(RVA = "0xB94FD0", Offset = "0xB94FD0", VA = "0xB94FD0")]
		public UkenPaymentTransaction(UkenPurchasePayload customPayload, string eventName, string sourceSink, string transactionID, double price, string currency, bool bIsRetry)
		{
		}
	}
}
