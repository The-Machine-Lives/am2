using System.Collections.Generic;
using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000340")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EED0", Offset = "0x81EED0")]
	public class RDFightScene : RDActionScene
	{
		[Token(Token = "0x4000FF0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x828C50", Offset = "0x828C50")]
		[Attribute(Name = "EntityReference", RVA = "0x828C50", Offset = "0x828C50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828C50", Offset = "0x828C50")]
		public List<string> monsters;

		[Token(Token = "0x4000FF1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x828CC4", Offset = "0x828CC4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828CC4", Offset = "0x828CC4")]
		public List<string> enemyStartEffects;

		[Token(Token = "0x6001A00")]
		[Address(RVA = "0x9BA498", Offset = "0x9BA498", VA = "0x9BA498")]
		public RDFightScene(string _ref)
		{
		}
	}
}
