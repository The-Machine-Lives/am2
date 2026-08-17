using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Firebase.Crashlytics
{
	[Token(Token = "0x2000015")]
	internal class AndroidImpl : Impl
	{
		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817B24", Offset = "0x817B24")]
		private sealed class _003CLog_003Ec__AnonStorey0
		{
			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string message;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal AndroidImpl _0024this;

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x17A16C0", Offset = "0x17A16C0", VA = "0x17A16C0")]
			public _003CLog_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x17A263C", Offset = "0x17A263C", VA = "0x17A263C")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817B34", Offset = "0x817B34")]
		private sealed class _003CSetCustomKey_003Ec__AnonStorey1
		{
			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string key;

			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string value;

			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal AndroidImpl _0024this;

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x17A182C", Offset = "0x17A182C", VA = "0x17A182C")]
			public _003CSetCustomKey_003Ec__AnonStorey1()
			{
			}

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x17A2A38", Offset = "0x17A2A38", VA = "0x17A2A38")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817B44", Offset = "0x817B44")]
		private sealed class _003CSetUserId_003Ec__AnonStorey2
		{
			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string identifier;

			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal AndroidImpl _0024this;

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x17A195C", Offset = "0x17A195C", VA = "0x17A195C")]
			public _003CSetUserId_003Ec__AnonStorey2()
			{
			}

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x17A2B7C", Offset = "0x17A2B7C", VA = "0x17A2B7C")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817B54", Offset = "0x817B54")]
		private sealed class _003CLogException_003Ec__AnonStorey3
		{
			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal LoggedException loggedException;

			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal StackFrames frames;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal AndroidImpl _0024this;

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x17A1C54", Offset = "0x17A1C54", VA = "0x17A1C54")]
			public _003CLogException_003Ec__AnonStorey3()
			{
			}

			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x17A2768", Offset = "0x17A2768", VA = "0x17A2768")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817B64", Offset = "0x817B64")]
		private sealed class _003CSetCrashlyticsCollectionEnabled_003Ec__AnonStorey4
		{
			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool enabled;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal AndroidImpl _0024this;

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x17A2528", Offset = "0x17A2528", VA = "0x17A2528")]
			public _003CSetCrashlyticsCollectionEnabled_003Ec__AnonStorey4()
			{
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x17A2908", Offset = "0x17A2908", VA = "0x17A2908")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private FirebaseCrashlyticsInternal crashlyticsInternal;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly FirebaseApp firebaseApp;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x17A0F0C", Offset = "0x17A0F0C", VA = "0x17A0F0C")]
		internal AndroidImpl()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x17A1234", Offset = "0x17A1234", VA = "0x17A1234", Slot = "1")]
		~AndroidImpl()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x17A12A8", Offset = "0x17A12A8", VA = "0x17A12A8")]
		private void Dispose()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x17A1390", Offset = "0x17A1390", VA = "0x17A1390", Slot = "4")]
		public override bool IsSDKInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x17A13A0", Offset = "0x17A13A0", VA = "0x17A13A0")]
		private void LogOperationFailedWarningDueToShutdown(string operation)
		{
		}

		[Token(Token = "0x60000C9")]
		private T CallInternalMethod<T>(Func<T> methodCall, string operation, [Optional] T errorValue)
		{
			return (T)null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x17A142C", Offset = "0x17A142C", VA = "0x17A142C")]
		private void CallInternalMethod(Action methodCall, string operation)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x17A1598", Offset = "0x17A1598", VA = "0x17A1598", Slot = "5")]
		public override void Log(string message)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x17A16C8", Offset = "0x17A16C8", VA = "0x17A16C8", Slot = "6")]
		public override void SetCustomKey(string key, string value)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x17A1834", Offset = "0x17A1834", VA = "0x17A1834", Slot = "7")]
		public override void SetUserId(string identifier)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x17A1964", Offset = "0x17A1964", VA = "0x17A1964", Slot = "8")]
		public override void LogException(Exception exception)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x17A23B8", Offset = "0x17A23B8", VA = "0x17A23B8", Slot = "9")]
		public override bool IsCrashlyticsCollectionEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x17A2450", Offset = "0x17A2450", VA = "0x17A2450", Slot = "10")]
		public override void SetCrashlyticsCollectionEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x17A2530", Offset = "0x17A2530", VA = "0x17A2530")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818284", Offset = "0x818284")]
		private bool _003CIsCrashlyticsCollectionEnabled_003Em__0()
		{
			return default(bool);
		}
	}
}
