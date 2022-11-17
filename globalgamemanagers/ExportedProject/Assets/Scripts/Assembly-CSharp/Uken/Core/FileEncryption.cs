using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003D7")]
	public static class FileEncryption
	{
		[Token(Token = "0x20007AF")]
		public static class AES
		{
			[Token(Token = "0x400226B")]
			[FieldOffset(Offset = "0x0")]
			private static int _iterations;

			[Token(Token = "0x400226C")]
			[FieldOffset(Offset = "0x4")]
			private static int _keySize;

			[Token(Token = "0x400226D")]
			[FieldOffset(Offset = "0x8")]
			private static string _hash;

			[Token(Token = "0x400226E")]
			[FieldOffset(Offset = "0x10")]
			private static string _salt;

			[Token(Token = "0x400226F")]
			[FieldOffset(Offset = "0x18")]
			private static string _vector;

			[Token(Token = "0x4002270")]
			[FieldOffset(Offset = "0x20")]
			private static string _key;

			[Token(Token = "0x17000814")]
			private static string _Key
			{
				[Token(Token = "0x60031C9")]
				[Address(RVA = "0xA17CE0", Offset = "0xA17CE0", VA = "0xA17CE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60031CA")]
			[Address(RVA = "0xA17D3C", Offset = "0xA17D3C", VA = "0xA17D3C")]
			private static string GetKey()
			{
				return null;
			}

			[Token(Token = "0x60031CB")]
			[Address(RVA = "0xA16694", Offset = "0xA16694", VA = "0xA16694")]
			public static string Encrypt(string value)
			{
				return null;
			}

			[Token(Token = "0x60031CC")]
			[Address(RVA = "0xA16E4C", Offset = "0xA16E4C", VA = "0xA16E4C")]
			public static string Decrypt(string value)
			{
				return null;
			}
		}

		[Token(Token = "0x400120D")]
		[FieldOffset(Offset = "0x0")]
		private static string androidPath;

		[Token(Token = "0x400120E")]
		[FieldOffset(Offset = "0x8")]
		public static string FILE_EXTENSION;

		[Token(Token = "0x6001DA6")]
		[Address(RVA = "0xA165EC", Offset = "0xA165EC", VA = "0xA165EC")]
		public static void SaveEncrypted(string filePath, string data)
		{
		}

		[Token(Token = "0x6001DA7")]
		[Address(RVA = "0xA16DA8", Offset = "0xA16DA8", VA = "0xA16DA8")]
		public static string LoadEncrypted(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001DA8")]
		[Address(RVA = "0xA1770C", Offset = "0xA1770C", VA = "0xA1770C")]
		public static string PrivatePersistentPath()
		{
			return null;
		}

		[Token(Token = "0x6001DA9")]
		[Address(RVA = "0xA17768", Offset = "0xA17768", VA = "0xA17768")]
		private static string AndroidPersistentPath()
		{
			return null;
		}
	}
}
