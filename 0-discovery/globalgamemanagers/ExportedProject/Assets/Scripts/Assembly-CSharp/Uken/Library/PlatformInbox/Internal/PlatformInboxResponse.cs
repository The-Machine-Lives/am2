using Il2CppDummyDll;

namespace Uken.Library.PlatformInbox.Internal
{
	[Token(Token = "0x2000405")]
	public class PlatformInboxResponse
	{
		[Token(Token = "0x40012C9")]
		[FieldOffset(Offset = "0x10")]
		public int errorCode;

		[Token(Token = "0x40012CA")]
		[FieldOffset(Offset = "0x18")]
		public string errorMessage;

		[Token(Token = "0x6001E98")]
		[Address(RVA = "0xB2FF9C", Offset = "0xB2FF9C", VA = "0xB2FF9C")]
		public bool HasErrorCode()
		{
			return default(bool);
		}

		[Token(Token = "0x6001E99")]
		[Address(RVA = "0xB2FFAC", Offset = "0xB2FFAC", VA = "0xB2FFAC")]
		public PlatformInboxResponseCode GetResponseCode()
		{
			return default(PlatformInboxResponseCode);
		}

		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0xB30094", Offset = "0xB30094", VA = "0xB30094")]
		public PlatformInboxResponse()
		{
		}
	}
}
