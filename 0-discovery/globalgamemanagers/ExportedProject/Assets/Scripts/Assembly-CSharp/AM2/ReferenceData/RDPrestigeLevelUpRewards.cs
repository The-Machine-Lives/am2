using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000383")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F480", Offset = "0x81F480")]
	public class RDPrestigeLevelUpRewards : BaseEntityDocument
	{
		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82C2AC", Offset = "0x82C2AC")]
		[Attribute(Name = "EntityReference", RVA = "0x82C2AC", Offset = "0x82C2AC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C2AC", Offset = "0x82C2AC")]
		public string prestigeRewardGroup;

		[Token(Token = "0x6001BB4")]
		[Address(RVA = "0x9BA6AC", Offset = "0x9BA6AC", VA = "0x9BA6AC")]
		public RDPrestigeLevelUpRewards(string inReference)
		{
		}
	}
}
