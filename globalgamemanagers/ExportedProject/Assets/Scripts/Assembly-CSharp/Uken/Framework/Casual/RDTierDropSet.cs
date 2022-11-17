using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200051C")]
	public class RDTierDropSet : BaseEntityDocument
	{
		[Token(Token = "0x40017F0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x830640", Offset = "0x830640")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830640", Offset = "0x830640")]
		public List<string> commonRewards;

		[Token(Token = "0x40017F1")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x8306A0", Offset = "0x8306A0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8306A0", Offset = "0x8306A0")]
		public List<string> rareRewards;

		[Token(Token = "0x40017F2")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "EntityReference", RVA = "0x830700", Offset = "0x830700")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830700", Offset = "0x830700")]
		public List<string> epicRewards;

		[Token(Token = "0x40017F3")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "EntityReference", RVA = "0x830760", Offset = "0x830760")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830760", Offset = "0x830760")]
		public List<string> legendaryRewards;

		[Token(Token = "0x60026D4")]
		[Address(RVA = "0xA81B68", Offset = "0xA81B68", VA = "0xA81B68")]
		public RDTierDropSet(string _ref)
		{
		}
	}
}
