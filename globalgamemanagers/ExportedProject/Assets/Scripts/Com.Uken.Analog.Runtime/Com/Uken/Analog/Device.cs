using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200002F")]
	public class Device
	{
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x10")]
		private PlatformName platformName;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814A90", Offset = "0x814A90")]
		[SerializeField]
		private string adid;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814AC8", Offset = "0x814AC8")]
		[SerializeField]
		private string idfa;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814B00", Offset = "0x814B00")]
		[SerializeField]
		private string ifv;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814B38", Offset = "0x814B38")]
		[SerializeField]
		private string android_id;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814B70", Offset = "0x814B70")]
		private string user_agent;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814BA8", Offset = "0x814BA8")]
		[SerializeField]
		private string device_id;

		[Token(Token = "0x1700004B")]
		[JsonIgnore]
		public string Adid
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x16D6C80", Offset = "0x16D6C80", VA = "0x16D6C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x16D6C88", Offset = "0x16D6C88", VA = "0x16D6C88")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		[JsonIgnore]
		public string Idfa
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x16D6C90", Offset = "0x16D6C90", VA = "0x16D6C90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x16D6C98", Offset = "0x16D6C98", VA = "0x16D6C98")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		[JsonIgnore]
		public string Ifv
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x16D6CA0", Offset = "0x16D6CA0", VA = "0x16D6CA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x16D6CA8", Offset = "0x16D6CA8", VA = "0x16D6CA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		[JsonIgnore]
		public string AndroidId
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x16D6CB0", Offset = "0x16D6CB0", VA = "0x16D6CB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x16D6CB8", Offset = "0x16D6CB8", VA = "0x16D6CB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		[JsonIgnore]
		public string UserAgent
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x16D6CC0", Offset = "0x16D6CC0", VA = "0x16D6CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x16D6CC8", Offset = "0x16D6CC8", VA = "0x16D6CC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		[JsonIgnore]
		public string DeviceId
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x16D6CD0", Offset = "0x16D6CD0", VA = "0x16D6CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x16D6CD8", Offset = "0x16D6CD8", VA = "0x16D6CD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x815CB4", Offset = "0x815CB4")]
		public string Platform
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x16D6CE0", Offset = "0x16D6CE0", VA = "0x16D6CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x16D61F4", Offset = "0x16D61F4", VA = "0x16D61F4")]
		public Device(PlatformName platformName, string user_agent, string device_id, string adid, string idfa, string ifv, string android_id)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x16D6D80", Offset = "0x16D6D80", VA = "0x16D6D80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
