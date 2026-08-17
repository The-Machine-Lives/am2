using System;
using Il2CppDummyDll;

namespace Firebase.Crashlytics
{
	[Token(Token = "0x2000010")]
	internal class Impl
	{
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string LogString;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string SetKeyValueString;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string SetUserIdentifierString;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string LogExceptionString;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string IsCrashlyticsCollectionEnabledString;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x28")]
		private static readonly string SetCrashlyticsCollectionEnabledString;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x17A1070", Offset = "0x17A1070", VA = "0x17A1070")]
		public Impl()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x17A31D0", Offset = "0x17A31D0", VA = "0x17A31D0")]
		public static Impl Make()
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x17A8D38", Offset = "0x17A8D38", VA = "0x17A8D38", Slot = "4")]
		public virtual bool IsSDKInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x17A8D40", Offset = "0x17A8D40", VA = "0x17A8D40", Slot = "5")]
		public virtual void Log(string message)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x17A8DEC", Offset = "0x17A8DEC", VA = "0x17A8DEC", Slot = "6")]
		public virtual void SetCustomKey(string key, string value)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x17A8EA8", Offset = "0x17A8EA8", VA = "0x17A8EA8", Slot = "7")]
		public virtual void SetUserId(string identifier)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x17A8F54", Offset = "0x17A8F54", VA = "0x17A8F54", Slot = "8")]
		public virtual void LogException(Exception exception)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x17A9000", Offset = "0x17A9000", VA = "0x17A9000", Slot = "9")]
		public virtual bool IsCrashlyticsCollectionEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x17A90C8", Offset = "0x17A90C8", VA = "0x17A90C8", Slot = "10")]
		public virtual void SetCrashlyticsCollectionEnabled(bool enabled)
		{
		}
	}
}
