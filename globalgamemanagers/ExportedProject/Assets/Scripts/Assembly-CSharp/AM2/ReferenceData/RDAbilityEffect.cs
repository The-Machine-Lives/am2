using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000313")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EBC0", Offset = "0x81EBC0")]
	public class RDAbilityEffect : BaseEntityDocument
	{
		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826A64", Offset = "0x826A64")]
		public bool isChanneled;

		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826A9C", Offset = "0x826A9C")]
		public float channelTickIntervalInSeconds;

		[Token(Token = "0x4000F34")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826AD4", Offset = "0x826AD4")]
		public ETargetType targetType;

		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "EntityReference", RVA = "0x826B0C", Offset = "0x826B0C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x826B0C", Offset = "0x826B0C")]
		public List<string> healthTypes;

		[Token(Token = "0x60018EC")]
		[Address(RVA = "0x9BA110", Offset = "0x9BA110", VA = "0x9BA110")]
		public RDAbilityEffect(string inReference)
		{
		}
	}
}
