using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000041")]
	public class IAPRequestEventData : EventData
	{
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815050", Offset = "0x815050")]
		private string ukenTransactionId;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815088", Offset = "0x815088")]
		private string productName;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8150C0", Offset = "0x8150C0")]
		[SerializeField]
		private string productId;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8150F8", Offset = "0x8150F8")]
		private double usdPrice;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815130", Offset = "0x815130")]
		[SerializeField]
		private string localCurrency;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815168", Offset = "0x815168")]
		[SerializeField]
		private double? localPrice;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8151A0", Offset = "0x8151A0")]
		[SerializeField]
		private string transactionId;

		[Token(Token = "0x17000067")]
		public string UkenTransactionId
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x16D8CB0", Offset = "0x16D8CB0", VA = "0x16D8CB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x16D8CC8", Offset = "0x16D8CC8", VA = "0x16D8CC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public string ProductName
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x16D8CD0", Offset = "0x16D8CD0", VA = "0x16D8CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x16D8CD8", Offset = "0x16D8CD8", VA = "0x16D8CD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public string ProductId
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x16D8CB8", Offset = "0x16D8CB8", VA = "0x16D8CB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x16D8CE0", Offset = "0x16D8CE0", VA = "0x16D8CE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public double UsdPrice
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x16D8CC0", Offset = "0x16D8CC0", VA = "0x16D8CC0")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x16D8CE8", Offset = "0x16D8CE8", VA = "0x16D8CE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public string LocalCurrency
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x16D8CF0", Offset = "0x16D8CF0", VA = "0x16D8CF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x16D8BC8", Offset = "0x16D8BC8", VA = "0x16D8BC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public double? LocalPrice
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x16D8CF8", Offset = "0x16D8CF8", VA = "0x16D8CF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x16D8C5C", Offset = "0x16D8C5C", VA = "0x16D8C5C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public string TransactionId
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x16D8D04", Offset = "0x16D8D04", VA = "0x16D8D04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x16D8CA4", Offset = "0x16D8CA4", VA = "0x16D8CA4")]
			set
			{
			}
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x16D8B38", Offset = "0x16D8B38", VA = "0x16D8B38")]
		public IAPRequestEventData(string ukenTransactionId, string productName, string productId, double usdPrice)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x16D8D0C", Offset = "0x16D8D0C", VA = "0x16D8D0C", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
