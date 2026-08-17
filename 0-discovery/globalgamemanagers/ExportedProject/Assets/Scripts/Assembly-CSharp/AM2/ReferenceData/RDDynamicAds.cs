using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000354")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F090", Offset = "0x81F090")]
	public class RDDynamicAds : BaseEntityDocument
	{
		[Token(Token = "0x4001019")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x829494", Offset = "0x829494")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829494", Offset = "0x829494")]
		public string adConfig;

		[Token(Token = "0x400101A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ColorUsageAttribute", RVA = "0x8294F4", Offset = "0x8294F4")]
		public string orbNormalColor;

		[Token(Token = "0x400101B")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ColorUsageAttribute", RVA = "0x829508", Offset = "0x829508")]
		public string orbHighlightColor;

		[Token(Token = "0x400101C")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ColorUsageAttribute", RVA = "0x82951C", Offset = "0x82951C")]
		public string orbPressedColor;

		[Token(Token = "0x400101D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ColorUsageAttribute", RVA = "0x829530", Offset = "0x829530")]
		public string orbBorderColor;

		[Token(Token = "0x400101E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829544", Offset = "0x829544")]
		public float minNewDynamicAdTimeInSeconds;

		[Token(Token = "0x400101F")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82957C", Offset = "0x82957C")]
		public float maxNewDynamicAdTimeInSeconds;

		[Token(Token = "0x4001020")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8295B4", Offset = "0x8295B4")]
		public float minDynamicAdDurationInSeconds;

		[Token(Token = "0x4001021")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8295EC", Offset = "0x8295EC")]
		public float maxDynamicAdDurationInSeconds;

		[Token(Token = "0x4001022")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "EntityReference", RVA = "0x829624", Offset = "0x829624")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829624", Offset = "0x829624")]
		public string userSegment;

		[Token(Token = "0x4001023")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "EntityReference", RVA = "0x829684", Offset = "0x829684")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829684", Offset = "0x829684")]
		public string rewardGroup;

		[Token(Token = "0x4001024")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8296E4", Offset = "0x8296E4")]
		public double globalSpeedBoostDurationInSeconds;

		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82971C", Offset = "0x82971C")]
		public double globalSpeedBoostPercent;

		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829754", Offset = "0x829754")]
		public int priority;

		[Token(Token = "0x6001A42")]
		[Address(RVA = "0x9BA380", Offset = "0x9BA380", VA = "0x9BA380")]
		public RDDynamicAds()
		{
		}
	}
}
