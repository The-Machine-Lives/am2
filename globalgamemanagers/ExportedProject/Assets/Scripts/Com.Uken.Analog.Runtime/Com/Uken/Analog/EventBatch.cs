using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000013")]
	public class EventBatch
	{
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x813E18", Offset = "0x813E18")]
		private List<BaseEvent> events;

		[Token(Token = "0x1700000F")]
		[JsonIgnore]
		public List<BaseEvent> Events
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x16D3B8C", Offset = "0x16D3B8C", VA = "0x16D3B8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public int Count
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x16D6E14", Offset = "0x16D6E14", VA = "0x16D6E14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x16D6DE8", Offset = "0x16D6DE8", VA = "0x16D6DE8")]
		public EventBatch(List<BaseEvent> events)
		{
		}
	}
}
