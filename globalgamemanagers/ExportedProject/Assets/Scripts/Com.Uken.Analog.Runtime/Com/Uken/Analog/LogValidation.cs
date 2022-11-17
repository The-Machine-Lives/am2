using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000033")]
	public class LogValidation
	{
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814C60", Offset = "0x814C60")]
		private bool valid_on_client;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814C98", Offset = "0x814C98")]
		private string client_error_message;

		[Token(Token = "0x17000055")]
		[JsonIgnore]
		public bool ValidOnClient
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x16D9AE8", Offset = "0x16D9AE8", VA = "0x16D9AE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x16D6440", Offset = "0x16D6440", VA = "0x16D6440")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		[JsonIgnore]
		public string ClientErrorMessage
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x16D9AF0", Offset = "0x16D9AF0", VA = "0x16D9AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x16D9AF8", Offset = "0x16D9AF8", VA = "0x16D9AF8")]
			set
			{
			}
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x16D6650", Offset = "0x16D6650", VA = "0x16D6650")]
		public LogValidation(bool valid_on_client)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x16D7980", Offset = "0x16D7980", VA = "0x16D7980")]
		public LogValidation AddClientErrorMessage(string clientErrorMessage)
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x16D9B00", Offset = "0x16D9B00", VA = "0x16D9B00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
