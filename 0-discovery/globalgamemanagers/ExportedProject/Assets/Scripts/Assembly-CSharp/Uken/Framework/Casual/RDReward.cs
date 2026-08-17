using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000514")]
	public class RDReward : BaseEntityDocument
	{
		[Token(Token = "0x40017C7")]
		public const int c_maxNestedAltRewardSize = 10;

		[Token(Token = "0x40017C8")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82FFAC", Offset = "0x82FFAC")]
		public string itemName;

		[Token(Token = "0x40017C9")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82FFC0", Offset = "0x82FFC0")]
		public long quantityMin;

		[Token(Token = "0x40017CA")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82FFF8", Offset = "0x82FFF8")]
		public long quantityMax;

		[Token(Token = "0x40017CB")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830030", Offset = "0x830030")]
		public int weight;

		[Token(Token = "0x40017CC")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830068", Offset = "0x830068")]
		public float percentChance;

		[Token(Token = "0x40017CD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "EntityReference", RVA = "0x8300A0", Offset = "0x8300A0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8300A0", Offset = "0x8300A0")]
		public string quantityFormula;

		[Token(Token = "0x40017CE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "EntityReference", RVA = "0x830100", Offset = "0x830100")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830100", Offset = "0x830100")]
		public string itemForMaxCap;

		[Token(Token = "0x40017CF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830160", Offset = "0x830160")]
		public float maxCapPercent;

		[Token(Token = "0x40017D0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "EntityReference", RVA = "0x830198", Offset = "0x830198")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830198", Offset = "0x830198")]
		public string altReward;

		[Token(Token = "0x40017D1")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8301F8", Offset = "0x8301F8")]
		public bool dontDisplayToUser;

		[Token(Token = "0x40017D2")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "EntityReference", RVA = "0x830230", Offset = "0x830230")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830230", Offset = "0x830230")]
		public string globalScaler;

		[Token(Token = "0x40017D3")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "EntityReference", RVA = "0x830290", Offset = "0x830290")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830290", Offset = "0x830290")]
		public List<string> miniEventScalers;

		[Token(Token = "0x60026A9")]
		[Address(RVA = "0xA8185C", Offset = "0xA8185C", VA = "0xA8185C")]
		public RDReward(string _ref)
		{
		}
	}
}
