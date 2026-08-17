using Il2CppDummyDll;

namespace Com.Uken.Adlib
{
	[Token(Token = "0x200000C")]
	public enum ConsentStatus
	{
		[Token(Token = "0x4000020")]
		NotRequired = 0,
		[Token(Token = "0x4000021")]
		Unknown = 1,
		[Token(Token = "0x4000022")]
		NotConsented = 2,
		[Token(Token = "0x4000023")]
		Consented = 3
	}
}
