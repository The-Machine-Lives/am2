using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000037")]
	public class CurrencyTransaction : BaseEvent
	{
		[Token(Token = "0x40000E5")]
		private const string TYPE = "currency_transaction";

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x70")]
		private CurrencyTransactionEventData eventData;

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x16D6740", Offset = "0x16D6740", VA = "0x16D6740")]
		public CurrencyTransaction(string eventName, long quantity, Currency currency, string source_sink)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x16D68D0", Offset = "0x16D68D0", VA = "0x16D68D0")]
		public CurrencyTransaction(string eventName, TransactionType transactionType, long quantity, Currency currency, string source_sink)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x16D692C", Offset = "0x16D692C", VA = "0x16D692C")]
		public CurrencyTransaction SetSource(string source)
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x16D6974", Offset = "0x16D6974", VA = "0x16D6974", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x16D6A10", Offset = "0x16D6A10", VA = "0x16D6A10")]
		public long GetQuantity()
		{
			return default(long);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x16D6A44", Offset = "0x16D6A44", VA = "0x16D6A44")]
		public Currency GetCurrency()
		{
			return default(Currency);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x16D67A0", Offset = "0x16D67A0", VA = "0x16D67A0")]
		private void Construct(string eventName, TransactionType transactionType, long quantity, Currency currency, string source_sink)
		{
		}
	}
}
