using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000396")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F640", Offset = "0x81F640")]
	public class RDLTOGroups : BaseEntityDocument
	{
		[Token(Token = "0x400115E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x82CDA4", Offset = "0x82CDA4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CDA4", Offset = "0x82CDA4")]
		public List<string> groupedStoreItems;

		[Token(Token = "0x400115F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x82CE04", Offset = "0x82CE04")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CE04", Offset = "0x82CE04")]
		public string userSegment;

		[Token(Token = "0x6001C0C")]
		[Address(RVA = "0x9BA620", Offset = "0x9BA620", VA = "0x9BA620")]
		public RDLTOGroups(string inReference)
		{
		}
	}
}
