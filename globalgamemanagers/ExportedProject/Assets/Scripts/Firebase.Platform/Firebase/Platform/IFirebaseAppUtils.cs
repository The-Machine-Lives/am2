using System;
using Il2CppDummyDll;

namespace Firebase.Platform
{
	[Token(Token = "0x2000023")]
	internal interface IFirebaseAppUtils
	{
		[Token(Token = "0x600007F")]
		void TranslateDllNotFoundException(Action action);

		[Token(Token = "0x6000080")]
		void PollCallbacks();

		[Token(Token = "0x6000081")]
		PlatformLogLevel GetLogLevel();
	}
}
