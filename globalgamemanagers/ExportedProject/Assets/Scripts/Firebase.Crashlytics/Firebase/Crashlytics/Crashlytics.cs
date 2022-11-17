using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace Firebase.Crashlytics
{
	[Token(Token = "0x2000012")]
	[Preserve]
	public static class Crashlytics
	{
		[Token(Token = "0x2000013")]
		[Preserve]
		internal static class PlatformAccessor
		{
			[Token(Token = "0x400002D")]
			[FieldOffset(Offset = "0x0")]
			private static ExceptionHandler _exceptionHandler;

			[Token(Token = "0x400002E")]
			[FieldOffset(Offset = "0x8")]
			private static Impl _impl;

			[Token(Token = "0x400002F")]
			[FieldOffset(Offset = "0x10")]
			private static FirebaseApp _app;

			[Token(Token = "0x17000013")]
			[Preserve]
			internal static ExceptionHandler ExceptionHandler
			{
				[Token(Token = "0x60000C0")]
				[Address(RVA = "0x17A33E0", Offset = "0x17A33E0", VA = "0x17A33E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000014")]
			internal static Impl Impl
			{
				[Token(Token = "0x60000C1")]
				[Address(RVA = "0x17A2D20", Offset = "0x17A2D20", VA = "0x17A2D20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000015")]
			[Preserve]
			internal static FirebaseApp App
			{
				[Token(Token = "0x60000C2")]
				[Address(RVA = "0x17A3448", Offset = "0x17A3448", VA = "0x17A3448")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x17A3074", Offset = "0x17A3074", VA = "0x17A3074")]
			static PlatformAccessor()
			{
			}
		}

		[Token(Token = "0x17000012")]
		public static bool IsCrashlyticsCollectionEnabled
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x17A2CA8", Offset = "0x17A2CA8", VA = "0x17A2CA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x17A2D88", Offset = "0x17A2D88", VA = "0x17A2D88")]
			set
			{
			}
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x17A2E08", Offset = "0x17A2E08", VA = "0x17A2E08")]
		[Preserve]
		private static void Initialize()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x17A2E64", Offset = "0x17A2E64", VA = "0x17A2E64")]
		public static void Log(string message)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x17A2EE4", Offset = "0x17A2EE4", VA = "0x17A2EE4")]
		public static void SetCustomKey(string key, string value)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x17A2F74", Offset = "0x17A2F74", VA = "0x17A2F74")]
		public static void SetUserId(string identifier)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x17A2FF4", Offset = "0x17A2FF4", VA = "0x17A2FF4")]
		public static void LogException(Exception exception)
		{
		}
	}
}
