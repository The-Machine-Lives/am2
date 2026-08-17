using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200001E")]
	public class AppCrashRecoveryEventData : EventData
	{
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814278", Offset = "0x814278")]
		private DateTime crashDateTime;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8142B0", Offset = "0x8142B0")]
		private string lastSceneView;

		[Token(Token = "0x17000024")]
		public DateTime CrashDateTime
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x16D4928", Offset = "0x16D4928", VA = "0x16D4928")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x16D4930", Offset = "0x16D4930", VA = "0x16D4930")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public string LastSceneView
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x16D4938", Offset = "0x16D4938", VA = "0x16D4938")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x16D4940", Offset = "0x16D4940", VA = "0x16D4940")]
			set
			{
			}
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x16D48E8", Offset = "0x16D48E8", VA = "0x16D48E8")]
		public AppCrashRecoveryEventData(DateTime crashDateTime, string lastSceneView)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x16D4948", Offset = "0x16D4948", VA = "0x16D4948", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
