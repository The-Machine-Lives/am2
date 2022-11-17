using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004E5")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FC44", Offset = "0x81FC44")]
	public class RDAdsConfigGroup : BaseEntityDocument
	{
		[Token(Token = "0x400173B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x82F5DC", Offset = "0x82F5DC")]
		public List<string> adsConfigs;

		[Token(Token = "0x60025BF")]
		[Address(RVA = "0xA80C7C", Offset = "0xA80C7C", VA = "0xA80C7C")]
		public RDAdsConfigGroup()
		{
		}
	}
}
