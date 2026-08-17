using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200051A")]
	public class RDTierDropRate : BaseEntityDocument
	{
		[Token(Token = "0x40017E7")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8304B8", Offset = "0x8304B8")]
		public List<EDropTier> requiredRewards;

		[Token(Token = "0x40017E8")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8304F0", Offset = "0x8304F0")]
		public int randomToDropMin;

		[Token(Token = "0x40017E9")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830528", Offset = "0x830528")]
		public int randomToDropMax;

		[Token(Token = "0x40017EA")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830560", Offset = "0x830560")]
		public int commonWeight;

		[Token(Token = "0x40017EB")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830598", Offset = "0x830598")]
		public int rareWeight;

		[Token(Token = "0x40017EC")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8305D0", Offset = "0x8305D0")]
		public int epicWeight;

		[Token(Token = "0x40017ED")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830608", Offset = "0x830608")]
		public int legendaryWeight;

		[Token(Token = "0x60026CF")]
		[Address(RVA = "0xA81AE4", Offset = "0xA81AE4", VA = "0xA81AE4")]
		public RDTierDropRate(string _ref)
		{
		}
	}
}
