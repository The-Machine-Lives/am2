using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200034D")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EFE8", Offset = "0x81EFE8")]
	public class RDCodeButtonCombo : BaseEntityDocument
	{
		[Token(Token = "0x400100C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82912C", Offset = "0x82912C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82912C", Offset = "0x82912C")]
		public List<ECodeButtonIndex> buttonSequence;

		[Token(Token = "0x400100D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82917C", Offset = "0x82917C")]
		[Attribute(Name = "EntityReference", RVA = "0x82917C", Offset = "0x82917C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82917C", Offset = "0x82917C")]
		public string rewardGroup;

		[Token(Token = "0x400100E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8291F0", Offset = "0x8291F0")]
		public string acquireText;

		[Token(Token = "0x6001A28")]
		[Address(RVA = "0x9BA294", Offset = "0x9BA294", VA = "0x9BA294")]
		public RDCodeButtonCombo(string _ref)
		{
		}
	}
}
