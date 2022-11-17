using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000044")]
	public class IAPResponseEventData : EventData
	{
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8151D8", Offset = "0x8151D8")]
		[SerializeField]
		private string ukenTransactionId;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815210", Offset = "0x815210")]
		[SerializeField]
		private string productName;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815248", Offset = "0x815248")]
		[SerializeField]
		private string productId;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815280", Offset = "0x815280")]
		[SerializeField]
		private double usdPrice;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8152B8", Offset = "0x8152B8")]
		[SerializeField]
		private IAPResponse.Status status;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8152F0", Offset = "0x8152F0")]
		[SerializeField]
		private string localCurrency;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815328", Offset = "0x815328")]
		[SerializeField]
		private double? localPrice;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815360", Offset = "0x815360")]
		private string transactionId;

		[Token(Token = "0x1700006E")]
		public string UkenTransactionId
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x16D9240", Offset = "0x16D9240", VA = "0x16D9240")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x16D9260", Offset = "0x16D9260", VA = "0x16D9260")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public string ProductName
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x16D9248", Offset = "0x16D9248", VA = "0x16D9248")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x16D9268", Offset = "0x16D9268", VA = "0x16D9268")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public string ProductId
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x16D9250", Offset = "0x16D9250", VA = "0x16D9250")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x16D9270", Offset = "0x16D9270", VA = "0x16D9270")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public double UsdPrice
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x16D9258", Offset = "0x16D9258", VA = "0x16D9258")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x16D9278", Offset = "0x16D9278", VA = "0x16D9278")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public IAPResponse.Status Status
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x16D9280", Offset = "0x16D9280", VA = "0x16D9280")]
			get
			{
				return default(IAPResponse.Status);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x16D9288", Offset = "0x16D9288", VA = "0x16D9288")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public string LocalCurrency
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x16D9290", Offset = "0x16D9290", VA = "0x16D9290")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x16D9158", Offset = "0x16D9158", VA = "0x16D9158")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public double? LocalPrice
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x16D9298", Offset = "0x16D9298", VA = "0x16D9298")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x16D91EC", Offset = "0x16D91EC", VA = "0x16D91EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public string TransactionId
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x16D92A4", Offset = "0x16D92A4", VA = "0x16D92A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x16D9234", Offset = "0x16D9234", VA = "0x16D9234")]
			set
			{
			}
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x16D90B8", Offset = "0x16D90B8", VA = "0x16D90B8")]
		public IAPResponseEventData(string ukenTransactionId, string productName, string productId, double usdPrice, IAPResponse.Status status)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x16D92AC", Offset = "0x16D92AC", VA = "0x16D92AC", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
