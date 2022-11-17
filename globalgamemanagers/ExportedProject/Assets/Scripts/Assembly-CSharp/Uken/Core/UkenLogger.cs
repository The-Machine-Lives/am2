using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003CD")]
	public static class UkenLogger
	{
		[Token(Token = "0x20007AA")]
		public enum LogLevel
		{
			[Token(Token = "0x4002255")]
			Info = 0,
			[Token(Token = "0x4002256")]
			Warning = 1,
			[Token(Token = "0x4002257")]
			Error = 2,
			[Token(Token = "0x4002258")]
			None = 3
		}

		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0xA1C7C4", Offset = "0xA1C7C4", VA = "0xA1C7C4")]
		public static void LogError(string message)
		{
		}

		[Token(Token = "0x6001D7C")]
		[Address(RVA = "0xA1C89C", Offset = "0xA1C89C", VA = "0xA1C89C")]
		public static void LogWarning(string message)
		{
		}

		[Token(Token = "0x6001D7D")]
		[Address(RVA = "0xA1C7CC", Offset = "0xA1C7CC", VA = "0xA1C7CC")]
		public static void Log(string message, LogLevel errorLevel = LogLevel.Info)
		{
		}
	}
}
