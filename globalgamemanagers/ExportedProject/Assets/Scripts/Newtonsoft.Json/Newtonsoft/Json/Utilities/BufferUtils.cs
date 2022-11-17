using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000069")]
	[Preserve]
	internal static class BufferUtils
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xF097AC", Offset = "0xF097AC", VA = "0xF097AC")]
		public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize)
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xF09884", Offset = "0xF09884", VA = "0xF09884")]
		public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xF09950", Offset = "0xF09950", VA = "0xF09950")]
		public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer)
		{
			return null;
		}
	}
}
