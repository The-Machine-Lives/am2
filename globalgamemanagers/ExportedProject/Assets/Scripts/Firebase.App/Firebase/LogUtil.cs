using System;
using Firebase.Platform;
using Il2CppDummyDll;

namespace Firebase
{
	[Token(Token = "0x200001B")]
	internal sealed class LogUtil : IDisposable
	{
		[Token(Token = "0x200001C")]
		internal delegate void LogMessageDelegate(LogLevel log_level, string message);

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x0")]
		private static LogUtil _instance;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x8")]
		private static object InitializeLoggingLock;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x10")]
		private bool _disposed;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D218", Offset = "0x80D218")]
		private static LogMessageDelegate _003C_003Ef__mg_0024cache0;

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x17A0550", Offset = "0x17A0550", VA = "0x17A0550")]
		static LogUtil()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x17A05E0", Offset = "0x17A05E0", VA = "0x17A05E0")]
		public LogUtil()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x179A9FC", Offset = "0x179A9FC", VA = "0x179A9FC")]
		public static void InitializeLogging()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x17A06DC", Offset = "0x17A06DC", VA = "0x17A06DC")]
		internal static Firebase.Platform.PlatformLogLevel ConvertLogLevel(LogLevel logLevel)
		{
			return default(Firebase.Platform.PlatformLogLevel);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x179CF14", Offset = "0x179CF14", VA = "0x179CF14")]
		internal static void LogMessage(LogLevel logLevel, string message)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x17A04A0", Offset = "0x17A04A0", VA = "0x17A04A0")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D990", Offset = "0x80D990")]
		internal static void LogMessageFromCallback(LogLevel logLevel, string message)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x17A06E8", Offset = "0x17A06E8", VA = "0x17A06E8", Slot = "1")]
		~LogUtil()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x17A07A4", Offset = "0x17A07A4", VA = "0x17A07A4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x17A0770", Offset = "0x17A0770", VA = "0x17A0770")]
		protected void Dispose(bool disposing)
		{
		}
	}
}
