using System.IO;
using Il2CppDummyDll;

namespace Com.Uken.Extensions
{
	[Token(Token = "0x2000004")]
	public static class FileExtensions
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x181BD3C", Offset = "0x181BD3C", VA = "0x181BD3C")]
		public static Stream SafeOpenWrite(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x181BD44", Offset = "0x181BD44", VA = "0x181BD44")]
		public static void SetNoBackupFlag(string filePath)
		{
		}
	}
}
