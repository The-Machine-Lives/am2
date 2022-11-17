using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200003A")]
	public class EventLoadEndEventData : EventData
	{
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814FE0", Offset = "0x814FE0")]
		[SerializeField]
		private string name;

		[Token(Token = "0x17000065")]
		public string Name
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x16D7464", Offset = "0x16D7464", VA = "0x16D7464")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x16D746C", Offset = "0x16D746C", VA = "0x16D746C")]
			set
			{
			}
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x16D7430", Offset = "0x16D7430", VA = "0x16D7430")]
		public EventLoadEndEventData(string name)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x16D7474", Offset = "0x16D7474", VA = "0x16D7474", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
