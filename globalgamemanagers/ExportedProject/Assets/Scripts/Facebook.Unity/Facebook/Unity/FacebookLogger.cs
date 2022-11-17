using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000051")]
	internal static class FacebookLogger
	{
		[Token(Token = "0x2000052")]
		private class DebugLogger : IFacebookLogger
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xCDE300", Offset = "0xCDE300", VA = "0xCDE300")]
			public DebugLogger()
			{
			}

			[Token(Token = "0x6000188")]
			[Address(RVA = "0xCDE464", Offset = "0xCDE464", VA = "0xCDE464", Slot = "4")]
			public void Log(string msg)
			{
			}

			[Token(Token = "0x6000189")]
			[Address(RVA = "0xCDE4FC", Offset = "0xCDE4FC", VA = "0xCDE4FC", Slot = "5")]
			public void Info(string msg)
			{
			}

			[Token(Token = "0x600018A")]
			[Address(RVA = "0xCDE564", Offset = "0xCDE564", VA = "0xCDE564", Slot = "6")]
			public void Warn(string msg)
			{
			}
		}

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8164D0", Offset = "0x8164D0")]
		private static IFacebookLogger _003CInstance_003Ek__BackingField;

		[Token(Token = "0x17000064")]
		internal static IFacebookLogger Instance
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0xCDE374", Offset = "0xCDE374", VA = "0xCDE374")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D90", Offset = "0x816D90")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xCDE308", Offset = "0xCDE308", VA = "0xCDE308")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816DA0", Offset = "0x816DA0")]
			set
			{
			}
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xCDE2A4", Offset = "0xCDE2A4", VA = "0xCDE2A4")]
		static FacebookLogger()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xCD132C", Offset = "0xCD132C", VA = "0xCD132C")]
		public static void Log(string msg)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xCD9950", Offset = "0xCD9950", VA = "0xCD9950")]
		public static void Info(string msg)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xCCA624", Offset = "0xCCA624", VA = "0xCCA624")]
		public static void Warn(string msg)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xCDE3DC", Offset = "0xCDE3DC", VA = "0xCDE3DC")]
		public static void Warn(string format, params string[] args)
		{
		}
	}
}
