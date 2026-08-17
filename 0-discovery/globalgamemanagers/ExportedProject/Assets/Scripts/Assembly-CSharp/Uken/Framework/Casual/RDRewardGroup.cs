using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000517")]
	public class RDRewardGroup : BaseEntityDocument
	{
		[Token(Token = "0x40017D9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830310", Offset = "0x830310")]
		[Attribute(Name = "EntityReference", RVA = "0x830310", Offset = "0x830310")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830310", Offset = "0x830310")]
		public List<string> rewards;

		[Token(Token = "0x40017DA")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830384", Offset = "0x830384")]
		[Attribute(Name = "EntityReference", RVA = "0x830384", Offset = "0x830384")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830384", Offset = "0x830384")]
		public List<string> randomRewards;

		[Token(Token = "0x40017DB")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "EntityReference", RVA = "0x8303F8", Offset = "0x8303F8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8303F8", Offset = "0x8303F8")]
		public string tierDropSet;

		[Token(Token = "0x40017DC")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "EntityReference", RVA = "0x830458", Offset = "0x830458")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830458", Offset = "0x830458")]
		public string tierDropRate;

		[Token(Token = "0x60026C0")]
		[Address(RVA = "0xA818E4", Offset = "0xA818E4", VA = "0xA818E4")]
		public RDRewardGroup(string _refName)
		{
		}
	}
}
