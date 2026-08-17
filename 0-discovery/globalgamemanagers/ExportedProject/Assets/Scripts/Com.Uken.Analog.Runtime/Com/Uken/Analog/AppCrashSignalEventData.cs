using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000020")]
	public class AppCrashSignalEventData : EventData
	{
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8142E8", Offset = "0x8142E8")]
		[SerializeField]
		private DateTime crashDateTime;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814320", Offset = "0x814320")]
		[SerializeField]
		private string stackTrace;

		[Token(Token = "0x17000026")]
		public DateTime CrashDateTime
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x16D4B6C", Offset = "0x16D4B6C", VA = "0x16D4B6C")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x16D4B74", Offset = "0x16D4B74", VA = "0x16D4B74")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public string StackTrace
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x16D4B7C", Offset = "0x16D4B7C", VA = "0x16D4B7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x16D4B84", Offset = "0x16D4B84", VA = "0x16D4B84")]
			set
			{
			}
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x16D4B2C", Offset = "0x16D4B2C", VA = "0x16D4B2C")]
		public AppCrashSignalEventData(DateTime crashDateTime, string stackTrace)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x16D4B8C", Offset = "0x16D4B8C", VA = "0x16D4B8C", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
