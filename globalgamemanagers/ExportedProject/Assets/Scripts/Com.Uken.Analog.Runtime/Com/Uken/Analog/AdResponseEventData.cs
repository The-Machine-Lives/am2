using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200001C")]
	public class AdResponseEventData : EventData
	{
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814048", Offset = "0x814048")]
		private AdType adType;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814080", Offset = "0x814080")]
		private string provider;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8140B8", Offset = "0x8140B8")]
		[SerializeField]
		private AdStatus adStatus;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8140F0", Offset = "0x8140F0")]
		private string adId;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814128", Offset = "0x814128")]
		[SerializeField]
		private string message;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814160", Offset = "0x814160")]
		private string rewardType;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814198", Offset = "0x814198")]
		private string providerPlacementId;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8141D0", Offset = "0x8141D0")]
		[SerializeField]
		private string placement;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814208", Offset = "0x814208")]
		private int rewardQuantity;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814240", Offset = "0x814240")]
		private int? estUsdRevenue;

		[Token(Token = "0x1700001A")]
		public AdType AdType
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x16CED14", Offset = "0x16CED14", VA = "0x16CED14")]
			get
			{
				return default(AdType);
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x16CE9D8", Offset = "0x16CE9D8", VA = "0x16CE9D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public string Provider
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x16CED0C", Offset = "0x16CED0C", VA = "0x16CED0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x16CE9E0", Offset = "0x16CE9E0", VA = "0x16CE9E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public AdStatus AdStatus
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x16CED1C", Offset = "0x16CED1C", VA = "0x16CED1C")]
			get
			{
				return default(AdStatus);
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x16CE9E8", Offset = "0x16CE9E8", VA = "0x16CE9E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public string AdId
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x16CED24", Offset = "0x16CED24", VA = "0x16CED24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x16CE9F0", Offset = "0x16CE9F0", VA = "0x16CE9F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public string Message
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x16CED2C", Offset = "0x16CED2C", VA = "0x16CED2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x16CEA38", Offset = "0x16CEA38", VA = "0x16CEA38")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public string RewardType
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x16CED34", Offset = "0x16CED34", VA = "0x16CED34")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x16CEA80", Offset = "0x16CEA80", VA = "0x16CEA80")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public string ProviderPlacementId
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x16CED3C", Offset = "0x16CED3C", VA = "0x16CED3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x16CEB10", Offset = "0x16CEB10", VA = "0x16CEB10")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public string Placement
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x16CED44", Offset = "0x16CED44", VA = "0x16CED44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x16CEB58", Offset = "0x16CEB58", VA = "0x16CEB58")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public int RewardQuantity
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x16CED4C", Offset = "0x16CED4C", VA = "0x16CED4C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x16CEAC8", Offset = "0x16CEAC8", VA = "0x16CEAC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public int? EstUsdRevenue
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x16CED54", Offset = "0x16CED54", VA = "0x16CED54")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x16CEBE4", Offset = "0x16CEBE4", VA = "0x16CEBE4")]
			set
			{
			}
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x16CED5C", Offset = "0x16CED5C", VA = "0x16CED5C", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x16CE9D0", Offset = "0x16CE9D0", VA = "0x16CE9D0")]
		public AdResponseEventData()
		{
		}
	}
}
