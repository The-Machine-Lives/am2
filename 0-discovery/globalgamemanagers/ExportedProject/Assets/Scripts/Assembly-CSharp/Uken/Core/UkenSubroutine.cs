using System.Collections;
using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003D0")]
	public class UkenSubroutine
	{
		[Token(Token = "0x40011F9")]
		[FieldOffset(Offset = "0x10")]
		public IEnumerator m_subroutine;

		[Token(Token = "0x6001D88")]
		[Address(RVA = "0xA1B360", Offset = "0xA1B360", VA = "0xA1B360")]
		public UkenSubroutine(IEnumerator subroutine)
		{
		}

		[Token(Token = "0x6001D89")]
		[Address(RVA = "0xA1B434", Offset = "0xA1B434", VA = "0xA1B434")]
		public bool Run()
		{
			return default(bool);
		}
	}
}
