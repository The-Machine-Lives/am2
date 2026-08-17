using Il2CppDummyDll;

namespace Uken.Library.Authentication
{
	[Token(Token = "0x2000488")]
	public class UkenAuthRefreshResponse : UkenAuthData
	{
		[Token(Token = "0x40014B8")]
		[FieldOffset(Offset = "0x20")]
		public string access_token;

		[Token(Token = "0x600214C")]
		[Address(RVA = "0xAFC554", Offset = "0xAFC554", VA = "0xAFC554", Slot = "4")]
		public override bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600214D")]
		[Address(RVA = "0xAFC228", Offset = "0xAFC228", VA = "0xAFC228")]
		public void DecodeJOT()
		{
		}

		[Token(Token = "0x600214E")]
		[Address(RVA = "0xAFC588", Offset = "0xAFC588", VA = "0xAFC588")]
		public UkenAuthRefreshResponse()
		{
		}
	}
}
