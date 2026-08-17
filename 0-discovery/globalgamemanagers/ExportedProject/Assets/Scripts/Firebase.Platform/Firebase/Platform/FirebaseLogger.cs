using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Firebase.Platform
{
	[Token(Token = "0x2000006")]
	internal class FirebaseLogger
	{
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x0")]
		private static MainThreadProperty<bool> incompatibleStackUnwindingEnabled;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80792C", Offset = "0x80792C")]
		private static Func<bool> _003C_003Ef__mg_0024cache0;

		[Token(Token = "0x1700000A")]
		internal static bool CanRedirectNativeLogs
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x17D1B74", Offset = "0x17D1B74", VA = "0x17D1B74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x17D1944", Offset = "0x17D1944", VA = "0x17D1944")]
		private static bool IsStackTraceLogTypeIncompatibleWithNativeLogs(StackTraceLogType logType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x17D1950", Offset = "0x17D1950", VA = "0x17D1950")]
		private static bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs()
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x17CF78C", Offset = "0x17CF78C", VA = "0x17CF78C")]
		internal static void LogMessage(PlatformLogLevel logLevel, string message)
		{
		}
	}
}
