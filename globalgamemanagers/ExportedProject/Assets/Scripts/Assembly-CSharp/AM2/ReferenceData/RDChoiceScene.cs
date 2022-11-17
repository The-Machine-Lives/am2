using System.Collections.Generic;
using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200033D")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EE98", Offset = "0x81EE98")]
	public class RDChoiceScene : RDActionScene
	{
		[Token(Token = "0x4000FEA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x828AA0", Offset = "0x828AA0")]
		[Attribute(Name = "EntityReference", RVA = "0x828AA0", Offset = "0x828AA0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828AA0", Offset = "0x828AA0")]
		public List<string> choices;

		[Token(Token = "0x4000FEB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x828B14", Offset = "0x828B14")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828B14", Offset = "0x828B14")]
		public string expirationEffect;

		[Token(Token = "0x4000FEC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828BC0", Offset = "0x828BC0")]
		public string text;

		[Token(Token = "0x4000FED")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828BF8", Offset = "0x828BF8")]
		public double durationInSeconds;

		[Token(Token = "0x60019F4")]
		[Address(RVA = "0x9BA224", Offset = "0x9BA224", VA = "0x9BA224")]
		public RDChoiceScene(string _ref)
		{
		}
	}
}
