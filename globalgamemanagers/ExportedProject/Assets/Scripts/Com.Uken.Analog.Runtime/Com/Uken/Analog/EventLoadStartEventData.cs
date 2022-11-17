using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200003C")]
	public class EventLoadStartEventData : EventData
	{
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815018", Offset = "0x815018")]
		private string name;

		[Token(Token = "0x17000066")]
		public string Name
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x16D7620", Offset = "0x16D7620", VA = "0x16D7620")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x16D7628", Offset = "0x16D7628", VA = "0x16D7628")]
			set
			{
			}
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x16D75EC", Offset = "0x16D75EC", VA = "0x16D75EC")]
		public EventLoadStartEventData(string name)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x16D7630", Offset = "0x16D7630", VA = "0x16D7630", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
