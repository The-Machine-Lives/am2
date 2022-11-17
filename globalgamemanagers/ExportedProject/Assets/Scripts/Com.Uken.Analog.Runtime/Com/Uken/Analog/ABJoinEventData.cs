using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000018")]
	public class ABJoinEventData : EventData
	{
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x813E50", Offset = "0x813E50")]
		[SerializeField]
		private string experimentName;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x813E88", Offset = "0x813E88")]
		[SerializeField]
		private string experimentGroup;

		[Token(Token = "0x17000011")]
		public string ExperimentName
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x16CE104", Offset = "0x16CE104", VA = "0x16CE104")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public string ExperimentGroup
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x16CE138", Offset = "0x16CE138", VA = "0x16CE138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x16CDFE0", Offset = "0x16CDFE0", VA = "0x16CDFE0")]
		public ABJoinEventData(string experimentName, string experimentGroup)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x16CE140", Offset = "0x16CE140", VA = "0x16CE140", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
