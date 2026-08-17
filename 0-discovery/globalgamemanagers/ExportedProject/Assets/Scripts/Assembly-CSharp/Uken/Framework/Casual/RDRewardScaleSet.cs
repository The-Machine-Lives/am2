using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000546")]
	[Attribute(Name = "GroupAttribute", RVA = "0x8200D0", Offset = "0x8200D0")]
	public class RDRewardScaleSet : BaseEntityDocument
	{
		[Token(Token = "0x4001918")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831BF8", Offset = "0x831BF8")]
		[Attribute(Name = "EntityReference", RVA = "0x831BF8", Offset = "0x831BF8")]
		public string rewardGroup;

		[Token(Token = "0x4001919")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831C48", Offset = "0x831C48")]
		[Attribute(Name = "EntityReference", RVA = "0x831C48", Offset = "0x831C48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831C48", Offset = "0x831C48")]
		public List<string> scaleSetEntries;

		[Token(Token = "0x6002848")]
		[Address(RVA = "0xA81910", Offset = "0xA81910", VA = "0xA81910")]
		public RDRewardScaleSet(string _refName)
		{
		}
	}
}
