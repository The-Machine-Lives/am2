using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000038")]
	public class CurrencyTransactionEventData : EventData
	{
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814F00", Offset = "0x814F00")]
		[SerializeField]
		private TransactionType type;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814F38", Offset = "0x814F38")]
		[SerializeField]
		private long quantity;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814F70", Offset = "0x814F70")]
		[SerializeField]
		private Currency currency;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814FA8", Offset = "0x814FA8")]
		[SerializeField]
		private string source;

		[Token(Token = "0x17000061")]
		public TransactionType Type
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x16D6A98", Offset = "0x16D6A98", VA = "0x16D6A98")]
			get
			{
				return default(TransactionType);
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x16D6A80", Offset = "0x16D6A80", VA = "0x16D6A80")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public long Quantity
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x16D6A3C", Offset = "0x16D6A3C", VA = "0x16D6A3C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x16D6A88", Offset = "0x16D6A88", VA = "0x16D6A88")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public Currency Currency
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x16D6A70", Offset = "0x16D6A70", VA = "0x16D6A70")]
			get
			{
				return default(Currency);
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x16D6A90", Offset = "0x16D6A90", VA = "0x16D6A90")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public string Source
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x16D6AA0", Offset = "0x16D6AA0", VA = "0x16D6AA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x16D696C", Offset = "0x16D696C", VA = "0x16D696C")]
			set
			{
			}
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x16D6AA8", Offset = "0x16D6AA8", VA = "0x16D6AA8", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x16D6A78", Offset = "0x16D6A78", VA = "0x16D6A78")]
		public CurrencyTransactionEventData()
		{
		}
	}
}
