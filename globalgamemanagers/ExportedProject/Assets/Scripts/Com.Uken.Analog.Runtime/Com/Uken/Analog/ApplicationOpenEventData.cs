using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000021")]
	public class ApplicationOpenEventData : EventData
	{
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814358", Offset = "0x814358")]
		[SerializeField]
		private string language;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814390", Offset = "0x814390")]
		[SerializeField]
		private string facebookId;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8143C8", Offset = "0x8143C8")]
		[SerializeField]
		private string googlePlayServicesId;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814400", Offset = "0x814400")]
		private string gameCenterId;

		[Token(Token = "0x17000028")]
		public string Language
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x16D512C", Offset = "0x16D512C", VA = "0x16D512C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x16D4F84", Offset = "0x16D4F84", VA = "0x16D4F84")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public string FacebookId
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x16D5134", Offset = "0x16D5134", VA = "0x16D5134")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x16D4FCC", Offset = "0x16D4FCC", VA = "0x16D4FCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public string GooglePlayServicesId
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x16D513C", Offset = "0x16D513C", VA = "0x16D513C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x16D5014", Offset = "0x16D5014", VA = "0x16D5014")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public string GameCenterId
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x16D5144", Offset = "0x16D5144", VA = "0x16D5144")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x16D505C", Offset = "0x16D505C", VA = "0x16D505C")]
			set
			{
			}
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x16D514C", Offset = "0x16D514C", VA = "0x16D514C", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x16D4F3C", Offset = "0x16D4F3C", VA = "0x16D4F3C")]
		public ApplicationOpenEventData()
		{
		}
	}
}
