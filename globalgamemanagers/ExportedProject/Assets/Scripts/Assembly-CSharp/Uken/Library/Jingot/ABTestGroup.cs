using Il2CppDummyDll;

namespace Uken.Library.Jingot
{
	[Token(Token = "0x2000425")]
	public struct ABTestGroup
	{
		[Token(Token = "0x400133A")]
		[FieldOffset(Offset = "0x0")]
		public string testName;

		[Token(Token = "0x400133B")]
		[FieldOffset(Offset = "0x8")]
		public string groupName;

		[Token(Token = "0x400133C")]
		[FieldOffset(Offset = "0x10")]
		public string state;

		[Token(Token = "0x400133D")]
		[FieldOffset(Offset = "0x18")]
		public string assignedGroup;
	}
}
