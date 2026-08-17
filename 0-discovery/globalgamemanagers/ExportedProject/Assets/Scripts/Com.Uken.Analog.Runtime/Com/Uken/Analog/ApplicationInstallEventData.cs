using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000023")]
	public class ApplicationInstallEventData : EventData
	{
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814438", Offset = "0x814438")]
		[SerializeField]
		private string language;

		[Token(Token = "0x1700002C")]
		public string Language
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x16D4DB8", Offset = "0x16D4DB8", VA = "0x16D4DB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x16D4CE8", Offset = "0x16D4CE8", VA = "0x16D4CE8")]
			set
			{
			}
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x16D4DC0", Offset = "0x16D4DC0", VA = "0x16D4DC0", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x16D4C98", Offset = "0x16D4C98", VA = "0x16D4C98")]
		public ApplicationInstallEventData()
		{
		}
	}
}
