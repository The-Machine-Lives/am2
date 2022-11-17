using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000343")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EF08", Offset = "0x81EF08")]
	public class RDQuestScene : RDActionScene
	{
		[Token(Token = "0x4000FF5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "EntityReference", RVA = "0x828D90", Offset = "0x828D90")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828D90", Offset = "0x828D90")]
		public string quest;

		[Token(Token = "0x4000FF6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828DF0", Offset = "0x828DF0")]
		public string text;

		[Token(Token = "0x6001A09")]
		[Address(RVA = "0x9BA960", Offset = "0x9BA960", VA = "0x9BA960")]
		public RDQuestScene(string _ref)
		{
		}
	}
}
