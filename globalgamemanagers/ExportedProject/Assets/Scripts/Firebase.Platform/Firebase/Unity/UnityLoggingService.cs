using Firebase.Platform;
using Il2CppDummyDll;

namespace Firebase.Unity
{
	[Token(Token = "0x200000A")]
	internal class UnityLoggingService : ILoggingService
	{
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x0")]
		private static UnityLoggingService _instance;

		[Token(Token = "0x17000013")]
		public static UnityLoggingService Instance
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x17D24C0", Offset = "0x17D24C0", VA = "0x17D24C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x17D24B8", Offset = "0x17D24B8", VA = "0x17D24B8")]
		public UnityLoggingService()
		{
		}
	}
}
