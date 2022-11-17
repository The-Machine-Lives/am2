using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200034A")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EFB0", Offset = "0x81EFB0")]
	public class RDSpeedBoosterReward : BaseEntityDocument
	{
		[Token(Token = "0x4001003")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829010", Offset = "0x829010")]
		public bool visible;

		[Token(Token = "0x4001004")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x829048", Offset = "0x829048")]
		[Attribute(Name = "EntityReference", RVA = "0x829048", Offset = "0x829048")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829048", Offset = "0x829048")]
		public string rewardGroup;

		[Token(Token = "0x4001005")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "EntityReference", RVA = "0x8290BC", Offset = "0x8290BC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8290BC", Offset = "0x8290BC")]
		public string recipe;

		[Token(Token = "0x6001A21")]
		[Address(RVA = "0x9BAAE4", Offset = "0x9BAAE4", VA = "0x9BAAE4")]
		public RDSpeedBoosterReward(string _ref)
		{
		}
	}
}
