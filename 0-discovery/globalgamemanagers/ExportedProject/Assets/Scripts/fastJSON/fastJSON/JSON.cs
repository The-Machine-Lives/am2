using Il2CppDummyDll;

namespace fastJSON
{
	[Token(Token = "0x2000003")]
	public static class JSON
	{
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x0")]
		public static JSONParameters Parameters;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1813494", Offset = "0x1813494", VA = "0x1813494")]
		public static object Parse(string json)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1813588", Offset = "0x1813588", VA = "0x1813588")]
		internal static long CreateLong(out long num, string s, int index, int count)
		{
			return default(long);
		}
	}
}
