using System;
using Il2CppDummyDll;

namespace Firebase.Platform
{
	[Token(Token = "0x2000018")]
	internal class FirebaseAppUtils : IFirebaseAppUtils
	{
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x0")]
		private static FirebaseAppUtils instance;

		[Token(Token = "0x1700000A")]
		public static FirebaseAppUtils Instance
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x179D27C", Offset = "0x179D27C", VA = "0x179D27C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x17A0D38", Offset = "0x17A0D38", VA = "0x17A0D38")]
		public FirebaseAppUtils()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x17A0D40", Offset = "0x17A0D40", VA = "0x17A0D40", Slot = "4")]
		public void TranslateDllNotFoundException(Action action)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x17A0DA4", Offset = "0x17A0DA4", VA = "0x17A0DA4", Slot = "5")]
		public void PollCallbacks()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x17A0DA8", Offset = "0x17A0DA8", VA = "0x17A0DA8", Slot = "6")]
		public PlatformLogLevel GetLogLevel()
		{
			return default(PlatformLogLevel);
		}
	}
}
