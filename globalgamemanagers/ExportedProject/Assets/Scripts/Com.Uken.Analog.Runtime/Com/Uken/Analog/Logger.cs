using Com.Uken.NativeHelpers;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Token(Token = "0x200004F")]
	public class Logger
	{
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x0")]
		private static UkenLogger.LogLevel minimumLevel;

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x16D012C", Offset = "0x16D012C", VA = "0x16D012C")]
		public static void SetLogLevel(UkenLogger.LogLevel logLevel)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x16D2D28", Offset = "0x16D2D28", VA = "0x16D2D28")]
		public static void Debug(string message)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x16D3588", Offset = "0x16D3588", VA = "0x16D3588")]
		public static void Warning(string message)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x16CFF0C", Offset = "0x16CFF0C", VA = "0x16CFF0C")]
		public static void Error(string message)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x16D9BA0", Offset = "0x16D9BA0", VA = "0x16D9BA0")]
		private static string PrefixMessage(string message)
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x16D9CC4", Offset = "0x16D9CC4", VA = "0x16D9CC4")]
		public Logger()
		{
		}
	}
}
