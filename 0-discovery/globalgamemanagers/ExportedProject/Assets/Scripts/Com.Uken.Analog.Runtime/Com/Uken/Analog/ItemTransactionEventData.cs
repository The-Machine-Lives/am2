using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000046")]
	public class ItemTransactionEventData : EventData
	{
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815398", Offset = "0x815398")]
		private string item;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8153D0", Offset = "0x8153D0")]
		[SerializeField]
		private long quantity;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815408", Offset = "0x815408")]
		[SerializeField]
		private long amountBeforeEvent;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815440", Offset = "0x815440")]
		[SerializeField]
		private TransactionType transactionType;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815478", Offset = "0x815478")]
		[SerializeField]
		private string source;

		[Token(Token = "0x17000076")]
		public string Item
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x16D9850", Offset = "0x16D9850", VA = "0x16D9850")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x16D98C0", Offset = "0x16D98C0", VA = "0x16D98C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public long Quantity
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x16D9858", Offset = "0x16D9858", VA = "0x16D9858")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x16D98C8", Offset = "0x16D98C8", VA = "0x16D98C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public long AmountBeforeEvent
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x16D9860", Offset = "0x16D9860", VA = "0x16D9860")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x16D98D0", Offset = "0x16D98D0", VA = "0x16D98D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public TransactionType TransactionType
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x16D98D8", Offset = "0x16D98D8", VA = "0x16D98D8")]
			get
			{
				return default(TransactionType);
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x16D98E0", Offset = "0x16D98E0", VA = "0x16D98E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public string Source
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x16D98E8", Offset = "0x16D98E8", VA = "0x16D98E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x16D98F0", Offset = "0x16D98F0", VA = "0x16D98F0")]
			set
			{
			}
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x16D9868", Offset = "0x16D9868", VA = "0x16D9868")]
		public ItemTransactionEventData(string item, TransactionType transactionType, long quantity, long amountBeforeEvent, string source_sink)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x16D98F8", Offset = "0x16D98F8", VA = "0x16D98F8", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
