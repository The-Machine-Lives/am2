using Il2CppDummyDll;

namespace Firebase.Analytics
{
	[Token(Token = "0x2000002")]
	public sealed class FirebaseAnalytics
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static FirebaseApp app;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x17FC3AC", Offset = "0x17FC3AC", VA = "0x17FC3AC")]
		static FirebaseAnalytics()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x17FC424", Offset = "0x17FC424", VA = "0x17FC424")]
		public static void LogEvent(string name, params Parameter[] parameters)
		{
		}
	}
}
