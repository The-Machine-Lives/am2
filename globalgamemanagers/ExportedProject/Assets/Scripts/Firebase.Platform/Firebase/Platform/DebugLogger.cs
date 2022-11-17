using Il2CppDummyDll;

namespace Firebase.Platform
{
	[Token(Token = "0x200001C")]
	internal class DebugLogger : ILoggingService
	{
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x0")]
		private static DebugLogger _instance;

		[Token(Token = "0x1700001C")]
		public static DebugLogger Instance
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x17CF944", Offset = "0x17CF944", VA = "0x17CF944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x17CF93C", Offset = "0x17CF93C", VA = "0x17CF93C")]
		public DebugLogger()
		{
		}
	}
}
