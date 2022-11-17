using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004E4")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FC0C", Offset = "0x81FC0C")]
	public class RDAdConfig : BaseEntityDocument
	{
		[Token(Token = "0x400172A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F15C", Offset = "0x82F15C")]
		public string readableName;

		[Token(Token = "0x400172B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F194", Offset = "0x82F194")]
		public long maxAdViews;

		[Token(Token = "0x400172C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82F1CC", Offset = "0x82F1CC")]
		[Attribute(Name = "EntityReference", RVA = "0x82F1CC", Offset = "0x82F1CC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F1CC", Offset = "0x82F1CC")]
		public string maxAdsFormula;

		[Token(Token = "0x400172D")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F240", Offset = "0x82F240")]
		public long timeAfterEachAd;

		[Token(Token = "0x400172E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F278", Offset = "0x82F278")]
		public long timeAfterEachGroupOfAds;

		[Token(Token = "0x400172F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F2B0", Offset = "0x82F2B0")]
		public bool showProgressBar;

		[Token(Token = "0x4001730")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F2E8", Offset = "0x82F2E8")]
		public double globalSpeedBoostDurationInSeconds;

		[Token(Token = "0x4001731")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F320", Offset = "0x82F320")]
		public double globalSpeedBoostPercent;

		[Token(Token = "0x4001732")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "EntityReference", RVA = "0x82F358", Offset = "0x82F358")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F358", Offset = "0x82F358")]
		public string rewardGroup;

		[Token(Token = "0x4001733")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F3B8", Offset = "0x82F3B8")]
		public bool isIntersitialConfig;

		[Token(Token = "0x4001734")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F3F0", Offset = "0x82F3F0")]
		public long roundsBetweenAds;

		[Token(Token = "0x4001735")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "EntityReference", RVA = "0x82F428", Offset = "0x82F428")]
		public List<string> userSegmentReferences;

		[Token(Token = "0x4001736")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82F460", Offset = "0x82F460")]
		[Attribute(Name = "EntityReference", RVA = "0x82F460", Offset = "0x82F460")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F460", Offset = "0x82F460")]
		public string subTab;

		[Token(Token = "0x4001737")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "EntityReference", RVA = "0x82F4D4", Offset = "0x82F4D4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F4D4", Offset = "0x82F4D4")]
		public string section;

		[Token(Token = "0x4001738")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F534", Offset = "0x82F534")]
		public sbyte displayPriority;

		[Token(Token = "0x4001739")]
		[FieldOffset(Offset = "0xA1")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F56C", Offset = "0x82F56C")]
		public bool skippable;

		[Token(Token = "0x400173A")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F5A4", Offset = "0x82F5A4")]
		public string buttonText;

		[Token(Token = "0x60025BE")]
		[Address(RVA = "0xA80C1C", Offset = "0xA80C1C", VA = "0xA80C1C")]
		public RDAdConfig()
		{
		}
	}
}
