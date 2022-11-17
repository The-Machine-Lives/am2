using Il2CppDummyDll;

namespace Com.Uken.NativeHelpers
{
	[Token(Token = "0x2000003")]
	public static class UkenLogger
	{
		[Token(Token = "0x2000004")]
		public enum LogLevel
		{
			[Token(Token = "0x4000003")]
			Info = 0,
			[Token(Token = "0x4000004")]
			Warning = 1,
			[Token(Token = "0x4000005")]
			Error = 2,
			[Token(Token = "0x4000006")]
			None = 3
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x16DA61C", Offset = "0x16DA61C", VA = "0x16DA61C")]
		public static void LogError(string message)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x16DA624", Offset = "0x16DA624", VA = "0x16DA624")]
		public static void LogWarning(string message)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x16D9BF4", Offset = "0x16D9BF4", VA = "0x16D9BF4")]
		public static void Log(string message, LogLevel errorLevel = LogLevel.Info)
		{
		}
	}
}
