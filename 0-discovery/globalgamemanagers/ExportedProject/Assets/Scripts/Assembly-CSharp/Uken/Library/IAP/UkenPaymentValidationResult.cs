using Il2CppDummyDll;

namespace Uken.Library.IAP
{
	[Token(Token = "0x200043C")]
	public enum UkenPaymentValidationResult
	{
		[Token(Token = "0x400139F")]
		Valid = 0,
		[Token(Token = "0x40013A0")]
		Invalid = 1,
		[Token(Token = "0x40013A1")]
		Unprocessed = 2,
		[Token(Token = "0x40013A2")]
		Pending = 3
	}
}
