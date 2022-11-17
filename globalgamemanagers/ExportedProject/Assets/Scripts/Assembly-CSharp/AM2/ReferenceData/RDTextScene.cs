using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000345")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EF40", Offset = "0x81EF40")]
	public class RDTextScene : RDActionScene
	{
		[Token(Token = "0x4000FF8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828E28", Offset = "0x828E28")]
		public string text;

		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x9BAB24", Offset = "0x9BAB24", VA = "0x9BAB24")]
		public RDTextScene(string _ref)
		{
		}
	}
}
