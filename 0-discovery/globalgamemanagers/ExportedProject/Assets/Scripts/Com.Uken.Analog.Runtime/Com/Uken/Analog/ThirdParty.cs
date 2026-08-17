using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000034")]
	public class ThirdParty
	{
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814CD0", Offset = "0x814CD0")]
		[SerializeField]
		private string adjust_id;

		[Token(Token = "0x17000057")]
		[JsonIgnore]
		public string AdjustId
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x16D3BA4", Offset = "0x16D3BA4", VA = "0x16D3BA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x16D1970", Offset = "0x16D1970", VA = "0x16D1970")]
			set
			{
			}
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x16D1944", Offset = "0x16D1944", VA = "0x16D1944")]
		public ThirdParty(string adjustId)
		{
		}
	}
}
