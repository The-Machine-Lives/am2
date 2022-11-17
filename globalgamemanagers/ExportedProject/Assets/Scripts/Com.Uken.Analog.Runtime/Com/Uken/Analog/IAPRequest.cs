using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000040")]
	public class IAPRequest : BaseEvent
	{
		[Token(Token = "0x40000FC")]
		private const string TYPE = "iap";

		[Token(Token = "0x40000FD")]
		private const string NAME = "request";

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x70")]
		private IAPRequestEventData eventData;

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x16D8A3C", Offset = "0x16D8A3C", VA = "0x16D8A3C")]
		public IAPRequest(string ukenTransactionId, string productName, string productId, double usdPrice)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x16D8B88", Offset = "0x16D8B88", VA = "0x16D8B88")]
		public IAPRequest SetLocalCurrency(string localCurrency)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x16D8BD0", Offset = "0x16D8BD0", VA = "0x16D8BD0")]
		public IAPRequest SetLocalPrice(double localPrice)
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x16D8C64", Offset = "0x16D8C64", VA = "0x16D8C64")]
		public IAPRequest SetTransactionId(string transactionId)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x16D8CAC", Offset = "0x16D8CAC", VA = "0x16D8CAC", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x16D7CE0", Offset = "0x16D7CE0", VA = "0x16D7CE0")]
		public string GetUkenTransactionId()
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x16D7D0C", Offset = "0x16D7D0C", VA = "0x16D7D0C")]
		public string GetProductId()
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x16D7D38", Offset = "0x16D7D38", VA = "0x16D7D38")]
		public double GetUsdPrice()
		{
			return default(double);
		}
	}
}
