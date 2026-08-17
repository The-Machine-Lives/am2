using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003A0")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F720", Offset = "0x81F720")]
	public class RDQuestSystem : BaseEntityDocument
	{
		[Token(Token = "0x4001188")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x82D7E4", Offset = "0x82D7E4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D7E4", Offset = "0x82D7E4")]
		public string questTabUnlocker;

		[Token(Token = "0x6001C52")]
		[Address(RVA = "0x9BA968", Offset = "0x9BA968", VA = "0x9BA968")]
		public RDQuestSystem(string _ref)
		{
		}
	}
}
