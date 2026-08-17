using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000045")]
	public class ItemTransaction : BaseEvent
	{
		[Token(Token = "0x4000116")]
		private const string TYPE = "item_transaction";

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x70")]
		private ItemTransactionEventData eventData;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x16D9604", Offset = "0x16D9604", VA = "0x16D9604")]
		public ItemTransaction(string eventName, string item, long quantity, long amountBeforeEvent, string source_sink)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x16D9768", Offset = "0x16D9768", VA = "0x16D9768")]
		public ItemTransaction(string eventName, string item, TransactionType transactionType, long quantity, long amountBeforeEvent, string source_sink)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x16D97D4", Offset = "0x16D97D4", VA = "0x16D97D4")]
		public ItemTransaction SetSource(string source)
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x16D984C", Offset = "0x16D984C", VA = "0x16D984C", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x16D8094", Offset = "0x16D8094", VA = "0x16D8094")]
		public string GetItem()
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x16D8068", Offset = "0x16D8068", VA = "0x16D8068")]
		public long GetQuantity()
		{
			return default(long);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x16D80C0", Offset = "0x16D80C0", VA = "0x16D80C0")]
		public long GetAmountBeforeEvent()
		{
			return default(long);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x16D9674", Offset = "0x16D9674", VA = "0x16D9674")]
		private void Construct(string eventName, string item, TransactionType transactionType, long quantity, long amountBeforeEvent, string source_sink)
		{
		}
	}
}
