using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000468")]
	public class VersionRecord
	{
		[Token(Token = "0x400146C")]
		[FieldOffset(Offset = "0x10")]
		public string Version;

		[Token(Token = "0x400146D")]
		[FieldOffset(Offset = "0x18")]
		public VersionPlatform Platform;

		[Token(Token = "0x60020C7")]
		[Address(RVA = "0xB38630", Offset = "0xB38630", VA = "0xB38630")]
		public VersionRecord()
		{
		}
	}
}
