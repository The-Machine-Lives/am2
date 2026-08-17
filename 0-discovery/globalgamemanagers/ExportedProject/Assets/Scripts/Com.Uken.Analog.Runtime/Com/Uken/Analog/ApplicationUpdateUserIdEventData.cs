using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000028")]
	public class ApplicationUpdateUserIdEventData : EventData
	{
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8145F8", Offset = "0x8145F8")]
		[SerializeField]
		private bool newUser;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814630", Offset = "0x814630")]
		private string language;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814668", Offset = "0x814668")]
		[SerializeField]
		private string oldUserId;

		[Token(Token = "0x17000034")]
		public bool NewUser
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x16D5D2C", Offset = "0x16D5D2C", VA = "0x16D5D2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x16D5D34", Offset = "0x16D5D34", VA = "0x16D5D34")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public string Language
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x16D5CF8", Offset = "0x16D5CF8", VA = "0x16D5CF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x16D5BE0", Offset = "0x16D5BE0", VA = "0x16D5BE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public string OldUserId
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x16D5D40", Offset = "0x16D5D40", VA = "0x16D5D40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x16D5C28", Offset = "0x16D5C28", VA = "0x16D5C28")]
			set
			{
			}
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x16D5B70", Offset = "0x16D5B70", VA = "0x16D5B70")]
		public ApplicationUpdateUserIdEventData(bool newUser)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x16D5D48", Offset = "0x16D5D48", VA = "0x16D5D48", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
