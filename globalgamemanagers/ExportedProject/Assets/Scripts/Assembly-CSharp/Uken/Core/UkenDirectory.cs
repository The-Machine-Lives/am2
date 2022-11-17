using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003C3")]
	public class UkenDirectory
	{
		[Token(Token = "0x40011E1")]
		[FieldOffset(Offset = "0x0")]
		private static BaseDirectoryController directoryController;

		[Token(Token = "0x6001D08")]
		[Address(RVA = "0xA1B72C", Offset = "0xA1B72C", VA = "0xA1B72C")]
		public static void CreateDirectory(string directory)
		{
		}

		[Token(Token = "0x6001D09")]
		[Address(RVA = "0xA1B7B4", Offset = "0xA1B7B4", VA = "0xA1B7B4")]
		public static bool Exists(string directory)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0xA1B83C", Offset = "0xA1B83C", VA = "0xA1B83C")]
		public static string[] GetFiles(string path)
		{
			return null;
		}

		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0xA1B8C4", Offset = "0xA1B8C4", VA = "0xA1B8C4")]
		public static string[] GetDirectories(string path)
		{
			return null;
		}

		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0xA1B94C", Offset = "0xA1B94C", VA = "0xA1B94C")]
		public static string GetParent(string path)
		{
			return null;
		}

		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0xA1B9D4", Offset = "0xA1B9D4", VA = "0xA1B9D4")]
		public static void DeleteDirectory(string path)
		{
		}

		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0xA1BA5C", Offset = "0xA1BA5C", VA = "0xA1BA5C")]
		public UkenDirectory()
		{
		}
	}
}
