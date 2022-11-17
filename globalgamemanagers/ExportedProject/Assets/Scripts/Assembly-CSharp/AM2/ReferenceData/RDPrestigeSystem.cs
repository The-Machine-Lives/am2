using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200038C")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F528", Offset = "0x81F528")]
	public class RDPrestigeSystem : BaseEntityDocument
	{
		[Token(Token = "0x400114D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CA54", Offset = "0x82CA54")]
		public List<string> prestigeSystemDescription;

		[Token(Token = "0x400114E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x82CA8C", Offset = "0x82CA8C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CA8C", Offset = "0x82CA8C")]
		public string prestigeTabUnlocker;

		[Token(Token = "0x400114F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "EntityReference", RVA = "0x82CAEC", Offset = "0x82CAEC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CAEC", Offset = "0x82CAEC")]
		public string prestigeButtonUnlocker;

		[Token(Token = "0x6001BDF")]
		[Address(RVA = "0x9BA844", Offset = "0x9BA844", VA = "0x9BA844")]
		public RDPrestigeSystem(string _ref)
		{
		}
	}
}
