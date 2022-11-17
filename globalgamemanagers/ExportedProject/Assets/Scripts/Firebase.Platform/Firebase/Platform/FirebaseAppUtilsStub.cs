using System;
using Il2CppDummyDll;

namespace Firebase.Platform
{
	[Token(Token = "0x2000024")]
	internal class FirebaseAppUtilsStub : IFirebaseAppUtils
	{
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x0")]
		private static FirebaseAppUtilsStub _instance;

		[Token(Token = "0x17000023")]
		public static FirebaseAppUtilsStub Instance
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x17CFDFC", Offset = "0x17CFDFC", VA = "0x17CFDFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x17CFDF4", Offset = "0x17CFDF4", VA = "0x17CFDF4")]
		public FirebaseAppUtilsStub()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x17CFE64", Offset = "0x17CFE64", VA = "0x17CFE64", Slot = "4")]
		public void TranslateDllNotFoundException(Action action)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x17CFE94", Offset = "0x17CFE94", VA = "0x17CFE94", Slot = "5")]
		public void PollCallbacks()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x17CFE98", Offset = "0x17CFE98", VA = "0x17CFE98", Slot = "6")]
		public PlatformLogLevel GetLogLevel()
		{
			return default(PlatformLogLevel);
		}
	}
}
