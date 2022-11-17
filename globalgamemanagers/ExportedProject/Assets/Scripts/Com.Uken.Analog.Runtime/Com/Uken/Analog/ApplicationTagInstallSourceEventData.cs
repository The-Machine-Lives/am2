using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000026")]
	public class ApplicationTagInstallSourceEventData : EventData
	{
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814470", Offset = "0x814470")]
		[SerializeField]
		private string sourceType;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8144A8", Offset = "0x8144A8")]
		[SerializeField]
		private string trackerName;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8144E0", Offset = "0x8144E0")]
		[SerializeField]
		private string network;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814518", Offset = "0x814518")]
		[SerializeField]
		private string campaign;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814550", Offset = "0x814550")]
		[SerializeField]
		private string adGroup;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814588", Offset = "0x814588")]
		[SerializeField]
		private string creative;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8145C0", Offset = "0x8145C0")]
		[SerializeField]
		private string clickLabel;

		[Token(Token = "0x1700002D")]
		public string SourceType
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x16D5608", Offset = "0x16D5608", VA = "0x16D5608")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x16D5748", Offset = "0x16D5748", VA = "0x16D5748")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public string TrackerName
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x16D563C", Offset = "0x16D563C", VA = "0x16D563C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x16D5750", Offset = "0x16D5750", VA = "0x16D5750")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public string Network
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x16D5670", Offset = "0x16D5670", VA = "0x16D5670")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x16D5758", Offset = "0x16D5758", VA = "0x16D5758")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public string Campaign
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x16D56A4", Offset = "0x16D56A4", VA = "0x16D56A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x16D5760", Offset = "0x16D5760", VA = "0x16D5760")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public string AdGroup
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x16D56D8", Offset = "0x16D56D8", VA = "0x16D56D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x16D5768", Offset = "0x16D5768", VA = "0x16D5768")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public string Creative
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x16D570C", Offset = "0x16D570C", VA = "0x16D570C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x16D5770", Offset = "0x16D5770", VA = "0x16D5770")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public string ClickLabel
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x16D5740", Offset = "0x16D5740", VA = "0x16D5740")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x16D5778", Offset = "0x16D5778", VA = "0x16D5778")]
			set
			{
			}
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x16D5414", Offset = "0x16D5414", VA = "0x16D5414")]
		public ApplicationTagInstallSourceEventData(string sourceType, string trackerName, string network, string campaign, string adGroup, string creative, string clickLabel)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x16D5780", Offset = "0x16D5780", VA = "0x16D5780", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
