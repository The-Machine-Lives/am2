using System.Collections.Generic;
using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200033B")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EE60", Offset = "0x81EE60")]
	public class RDBundleScene : RDActionScene
	{
		[Token(Token = "0x4000FE8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "EntityReference", RVA = "0x8289E0", Offset = "0x8289E0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8289E0", Offset = "0x8289E0")]
		public string choiceScene;

		[Token(Token = "0x4000FE9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "EntityReference", RVA = "0x828A40", Offset = "0x828A40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828A40", Offset = "0x828A40")]
		public List<string> encounters;

		[Token(Token = "0x60019F0")]
		[Address(RVA = "0x9BA1E0", Offset = "0x9BA1E0", VA = "0x9BA1E0")]
		public RDBundleScene(string _ref)
		{
		}
	}
}
