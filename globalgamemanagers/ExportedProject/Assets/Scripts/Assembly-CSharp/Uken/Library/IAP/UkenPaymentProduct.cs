using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.IAP
{
	[Token(Token = "0x2000432")]
	public class UkenPaymentProduct
	{
		[Token(Token = "0x400135E")]
		[FieldOffset(Offset = "0x10")]
		public UkenPurchasePlatform m_platform;

		[Token(Token = "0x400135F")]
		[FieldOffset(Offset = "0x18")]
		public string m_vendorID;

		[Token(Token = "0x4001360")]
		[FieldOffset(Offset = "0x20")]
		public UkenPurchasePayload m_customPayload;

		[Token(Token = "0x4001361")]
		[FieldOffset(Offset = "0x28")]
		public UkenPurchaseType m_purchaseType;

		[Token(Token = "0x4001362")]
		[FieldOffset(Offset = "0x30")]
		public string m_currencyCode;

		[Token(Token = "0x4001363")]
		[FieldOffset(Offset = "0x38")]
		public double m_currencyCost;

		[Token(Token = "0x4001364")]
		[FieldOffset(Offset = "0x40")]
		public string m_transactionID;

		[Token(Token = "0x4001365")]
		[FieldOffset(Offset = "0x48")]
		public string m_receipt;

		[Token(Token = "0x4001366")]
		[FieldOffset(Offset = "0x50")]
		public string m_isoCurrencyCode;

		[Token(Token = "0x4001367")]
		[FieldOffset(Offset = "0x58")]
		public float m_isoCurrencyCost;

		[Token(Token = "0x4001368")]
		[FieldOffset(Offset = "0x5C")]
		public bool m_isRetry;

		[Token(Token = "0x4001369")]
		[FieldOffset(Offset = "0x60")]
		public string m_providerTransactionID;

		[Token(Token = "0x6001F4C")]
		[Address(RVA = "0xAFC94C", Offset = "0xAFC94C", VA = "0xAFC94C")]
		public UkenPaymentProduct(string vendorID, string currencyCode, double currencyCost, string sPurchaseType)
		{
		}

		[Token(Token = "0x6001F4D")]
		[Address(RVA = "0xAFCAC8", Offset = "0xAFCAC8", VA = "0xAFCAC8")]
		private UkenPaymentProduct()
		{
		}

		[Token(Token = "0x6001F4E")]
		[Address(RVA = "0xAFCB20", Offset = "0xAFCB20", VA = "0xAFCB20")]
		public static UkenPaymentProduct Clone(UkenPaymentProduct other)
		{
			return null;
		}

		[Token(Token = "0x6001F4F")]
		[Address(RVA = "0xAFCCF0", Offset = "0xAFCCF0", VA = "0xAFCCF0")]
		public string GetFormattedPrice()
		{
			return null;
		}

		[Token(Token = "0x6001F50")]
		[Address(RVA = "0xAFCD5C", Offset = "0xAFCD5C", VA = "0xAFCD5C")]
		public UkenPaymentProduct CloneForTransaction()
		{
			return null;
		}

		[Token(Token = "0x6001F51")]
		[Address(RVA = "0xAFC808", Offset = "0xAFC808", VA = "0xAFC808")]
		public Dictionary<string, object> GetParameters()
		{
			return null;
		}

		[Token(Token = "0x6001F52")]
		[Address(RVA = "0xAFCE24", Offset = "0xAFCE24", VA = "0xAFCE24")]
		public static UkenPaymentProduct CreateFromPurchaseData(Dictionary<string, object> purchaseData, Func<string, UkenPurchasePayload> payloadParser)
		{
			return null;
		}

		[Token(Token = "0x6001F53")]
		[Address(RVA = "0xAFD61C", Offset = "0xAFD61C", VA = "0xAFD61C")]
		public void LoadProviderTransaction(string providerTransactionID, string receipt, string isoCurrencyCode, float isoCurrencyCost)
		{
		}
	}
}
