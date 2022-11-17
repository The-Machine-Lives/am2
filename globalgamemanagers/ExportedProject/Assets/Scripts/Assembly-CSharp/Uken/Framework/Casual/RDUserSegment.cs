using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000569")]
	[Attribute(Name = "GroupAttribute", RVA = "0x8201F8", Offset = "0x8201F8")]
	public class RDUserSegment : BaseEntityDocument
	{
		[Token(Token = "0x40019A1")]
		[FieldOffset(Offset = "0x30")]
		public List<UserQualifier> qualifiers;

		[Token(Token = "0x600294B")]
		[Address(RVA = "0xA81C38", Offset = "0xA81C38", VA = "0xA81C38")]
		public RDUserSegment(string reference)
		{
		}
	}
}
