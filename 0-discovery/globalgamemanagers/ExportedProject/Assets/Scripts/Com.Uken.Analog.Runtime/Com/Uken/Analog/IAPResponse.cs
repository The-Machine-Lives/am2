using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000042")]
	public class IAPResponse : BaseEvent
	{
		[Token(Token = "0x2000043")]
		public enum Status
		{
			[Token(Token = "0x400010A")]
			success = 0,
			[Token(Token = "0x400010B")]
			cancel = 1,
			[Token(Token = "0x400010C")]
			server_fail = 2,
			[Token(Token = "0x400010D")]
			client_fail = 3
		}

		[Token(Token = "0x4000106")]
		private const string TYPE = "iap";

		[Token(Token = "0x4000107")]
		private const string NAME = "response";

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x70")]
		private IAPResponseEventData eventData;

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x16D8FB4", Offset = "0x16D8FB4", VA = "0x16D8FB4")]
		public IAPResponse(string ukenTransactionId, string productName, string productId, double usdPrice, Status status)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x16D9118", Offset = "0x16D9118", VA = "0x16D9118")]
		public IAPResponse SetLocalCurrency(string localCurrency)
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x16D9160", Offset = "0x16D9160", VA = "0x16D9160")]
		public IAPResponse SetLocalPrice(double localPrice)
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x16D91F4", Offset = "0x16D91F4", VA = "0x16D91F4")]
		public IAPResponse SetTransactionId(string transactionId)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x16D923C", Offset = "0x16D923C", VA = "0x16D923C", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x16D7EDC", Offset = "0x16D7EDC", VA = "0x16D7EDC")]
		public string GetUkenTransactionId()
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x16D7F08", Offset = "0x16D7F08", VA = "0x16D7F08")]
		public string GetProductName()
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x16D7F34", Offset = "0x16D7F34", VA = "0x16D7F34")]
		public string GetProductId()
		{
			return null;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x16D7F60", Offset = "0x16D7F60", VA = "0x16D7F60")]
		public double GetUsdPrice()
		{
			return default(double);
		}
	}
}
