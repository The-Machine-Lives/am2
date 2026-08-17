using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200001A")]
	public class AdRequestEventData : EventData
	{
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x813EC0", Offset = "0x813EC0")]
		[SerializeField]
		private AdType type;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x813EF8", Offset = "0x813EF8")]
		private string provider;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x813F30", Offset = "0x813F30")]
		[SerializeField]
		private string adId;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x813F68", Offset = "0x813F68")]
		[SerializeField]
		private string rewardType;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x813FA0", Offset = "0x813FA0")]
		[SerializeField]
		private int? rewardQuantity;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x813FD8", Offset = "0x813FD8")]
		[SerializeField]
		private string placement;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814010", Offset = "0x814010")]
		[SerializeField]
		private string providerPlacementId;

		[Token(Token = "0x17000013")]
		public AdType Type
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x16CE618", Offset = "0x16CE618", VA = "0x16CE618")]
			get
			{
				return default(AdType);
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x16CE374", Offset = "0x16CE374", VA = "0x16CE374")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public string Provider
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x16CE610", Offset = "0x16CE610", VA = "0x16CE610")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x16CE37C", Offset = "0x16CE37C", VA = "0x16CE37C")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public string AdId
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x16CE620", Offset = "0x16CE620", VA = "0x16CE620")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x16CE384", Offset = "0x16CE384", VA = "0x16CE384")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public string RewardType
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x16CE628", Offset = "0x16CE628", VA = "0x16CE628")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x16CE3CC", Offset = "0x16CE3CC", VA = "0x16CE3CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public int? RewardQuantity
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x16CE630", Offset = "0x16CE630", VA = "0x16CE630")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x16CE458", Offset = "0x16CE458", VA = "0x16CE458")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public string Placement
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x16CE638", Offset = "0x16CE638", VA = "0x16CE638")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x16CE4A0", Offset = "0x16CE4A0", VA = "0x16CE4A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public string ProviderPlacementId
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x16CE640", Offset = "0x16CE640", VA = "0x16CE640")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x16CE4E8", Offset = "0x16CE4E8", VA = "0x16CE4E8")]
			set
			{
			}
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x16CE648", Offset = "0x16CE648", VA = "0x16CE648", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x16CE36C", Offset = "0x16CE36C", VA = "0x16CE36C")]
		public AdRequestEventData()
		{
		}
	}
}
