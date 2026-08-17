using Il2CppDummyDll;

namespace Uken.Library.Authentication
{
	[Token(Token = "0x2000489")]
	public class UkenAuthData
	{
		[Token(Token = "0x200081A")]
		protected class UkenDecodedJOT
		{
			[Token(Token = "0x4002351")]
			[FieldOffset(Offset = "0x10")]
			public string iss;

			[Token(Token = "0x4002352")]
			[FieldOffset(Offset = "0x18")]
			public string sub;

			[Token(Token = "0x4002353")]
			[FieldOffset(Offset = "0x20")]
			public string iat;

			[Token(Token = "0x4002354")]
			[FieldOffset(Offset = "0x28")]
			public string exp;

			[Token(Token = "0x60032E9")]
			[Address(RVA = "0xAFC428", Offset = "0xAFC428", VA = "0xAFC428")]
			public UkenDecodedJOT()
			{
			}
		}

		[Token(Token = "0x40014B9")]
		[FieldOffset(Offset = "0x10")]
		public string timestamp;

		[Token(Token = "0x40014BA")]
		[FieldOffset(Offset = "0x18")]
		private UkenDecodedJOT decodedJOT;

		[Token(Token = "0x600214F")]
		[Address(RVA = "0xAFC230", Offset = "0xAFC230", VA = "0xAFC230", Slot = "4")]
		public virtual bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6002150")]
		[Address(RVA = "0xAFBE88", Offset = "0xAFBE88", VA = "0xAFBE88")]
		public string GetUserID()
		{
			return null;
		}

		[Token(Token = "0x6002151")]
		[Address(RVA = "0xAFBFA0", Offset = "0xAFBFA0", VA = "0xAFBFA0")]
		public string GetExpirationTime()
		{
			return null;
		}

		[Token(Token = "0x6002152")]
		[Address(RVA = "0xAFBFFC", Offset = "0xAFBFFC", VA = "0xAFBFFC")]
		public string GetIssueTime()
		{
			return null;
		}

		[Token(Token = "0x6002153")]
		[Address(RVA = "0xAFBEE4", Offset = "0xAFBEE4", VA = "0xAFBEE4")]
		public long GetServerTime()
		{
			return default(long);
		}

		[Token(Token = "0x6002154")]
		[Address(RVA = "0xAFC240", Offset = "0xAFC240", VA = "0xAFC240")]
		protected void DecodeJOT(string access_token)
		{
		}

		[Token(Token = "0x6002155")]
		[Address(RVA = "0xAFC420", Offset = "0xAFC420", VA = "0xAFC420")]
		public UkenAuthData()
		{
		}
	}
}
