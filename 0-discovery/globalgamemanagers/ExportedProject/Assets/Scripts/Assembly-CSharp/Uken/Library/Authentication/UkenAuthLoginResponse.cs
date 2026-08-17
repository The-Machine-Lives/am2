using Il2CppDummyDll;

namespace Uken.Library.Authentication
{
	[Token(Token = "0x2000487")]
	public class UkenAuthLoginResponse : UkenAuthData
	{
		[Token(Token = "0x40014B4")]
		[FieldOffset(Offset = "0x20")]
		public string access_token;

		[Token(Token = "0x40014B5")]
		[FieldOffset(Offset = "0x28")]
		public string refresh_token;

		[Token(Token = "0x40014B6")]
		[FieldOffset(Offset = "0x30")]
		public string credential;

		[Token(Token = "0x40014B7")]
		[FieldOffset(Offset = "0x38")]
		public long userCreationDateTime;

		[Token(Token = "0x6002149")]
		[Address(RVA = "0xAFC430", Offset = "0xAFC430", VA = "0xAFC430", Slot = "4")]
		public override bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600214A")]
		[Address(RVA = "0xAFBE80", Offset = "0xAFBE80", VA = "0xAFBE80")]
		public void DecodeJOT()
		{
		}

		[Token(Token = "0x600214B")]
		[Address(RVA = "0xAFC464", Offset = "0xAFC464", VA = "0xAFC464")]
		public UkenAuthLoginResponse()
		{
		}
	}
}
