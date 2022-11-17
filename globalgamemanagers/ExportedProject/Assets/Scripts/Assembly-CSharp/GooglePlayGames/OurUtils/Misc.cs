using Il2CppDummyDll;

namespace GooglePlayGames.OurUtils
{
	[Token(Token = "0x20002CE")]
	public static class Misc
	{
		[Token(Token = "0x600162B")]
		[Address(RVA = "0xE6C43C", Offset = "0xE6C43C", VA = "0xE6C43C")]
		public static bool BuffersAreIdentical(byte[] a, byte[] b)
		{
			return default(bool);
		}

		[Token(Token = "0x600162C")]
		[Address(RVA = "0xE6C500", Offset = "0xE6C500", VA = "0xE6C500")]
		public static byte[] GetSubsetBytes(byte[] array, int offset, int length)
		{
			return null;
		}

		[Token(Token = "0x600162D")]
		public static T CheckNotNull<T>(T value)
		{
			return (T)null;
		}

		[Token(Token = "0x600162E")]
		public static T CheckNotNull<T>(T value, string paramName)
		{
			return (T)null;
		}
	}
}
