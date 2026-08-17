using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003A6")]
	public class Section : RuntimeData<RDSection>
	{
		[Token(Token = "0x17000540")]
		public string readableName
		{
			[Token(Token = "0x6001C61")]
			[Address(RVA = "0x96FC44", Offset = "0x96FC44", VA = "0x96FC44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000541")]
		public int priority
		{
			[Token(Token = "0x6001C62")]
			[Address(RVA = "0x96FC70", Offset = "0x96FC70", VA = "0x96FC70")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6001C63")]
		[Address(RVA = "0x96FC9C", Offset = "0x96FC9C", VA = "0x96FC9C")]
		public Section()
		{
		}

		[Token(Token = "0x6001C64")]
		[Address(RVA = "0x96FCEC", Offset = "0x96FCEC", VA = "0x96FCEC")]
		public Section(RDSection inRDSection, string inRedableName)
		{
		}
	}
}
