using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003C4")]
	public class UkenFile
	{
		[Token(Token = "0x40011E2")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<string, byte[]> memoryFileSystem;

		[Token(Token = "0x40011E3")]
		[FieldOffset(Offset = "0x8")]
		private static BaseFileController fileController;

		[Token(Token = "0x6001D10")]
		[Address(RVA = "0xA1BAE0", Offset = "0xA1BAE0", VA = "0xA1BAE0")]
		public static bool Exists(string filepath)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D11")]
		[Address(RVA = "0xA1BB68", Offset = "0xA1BB68", VA = "0xA1BB68")]
		public static DateTime GetCreationTime(string filename)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6001D12")]
		[Address(RVA = "0xA1BBF0", Offset = "0xA1BBF0", VA = "0xA1BBF0")]
		public static long GetFileLength(string fileName)
		{
			return default(long);
		}

		[Token(Token = "0x6001D13")]
		[Address(RVA = "0xA1BC78", Offset = "0xA1BC78", VA = "0xA1BC78")]
		public static Stream OpenRead(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001D14")]
		[Address(RVA = "0xA1BD00", Offset = "0xA1BD00", VA = "0xA1BD00")]
		public static string GetFileName(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001D15")]
		[Address(RVA = "0xA1BD88", Offset = "0xA1BD88", VA = "0xA1BD88")]
		public static Stream OpenWrite(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001D16")]
		[Address(RVA = "0xA1BE14", Offset = "0xA1BE14", VA = "0xA1BE14")]
		public static void SaveStream(Stream inputStream, string path)
		{
		}

		[Token(Token = "0x6001D17")]
		[Address(RVA = "0xA1BEAC", Offset = "0xA1BEAC", VA = "0xA1BEAC")]
		public static Stream Create(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001D18")]
		[Address(RVA = "0xA1BF34", Offset = "0xA1BF34", VA = "0xA1BF34")]
		public static void Delete(string path)
		{
		}

		[Token(Token = "0x6001D19")]
		[Address(RVA = "0xA1BFBC", Offset = "0xA1BFBC", VA = "0xA1BFBC")]
		public string GetParent(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0xA1C044", Offset = "0xA1C044", VA = "0xA1C044")]
		public static void Move(string source, string destination)
		{
		}

		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0xA1C0E0", Offset = "0xA1C0E0", VA = "0xA1C0E0")]
		public static void CopyAndOverwrite(string source, string destination)
		{
		}

		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0xA1C15C", Offset = "0xA1C15C", VA = "0xA1C15C")]
		public static void Copy(string source, string destination)
		{
		}

		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0xA1C1F8", Offset = "0xA1C1F8", VA = "0xA1C1F8")]
		public static string ReadAllText(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0xA1C574", Offset = "0xA1C574", VA = "0xA1C574")]
		public static void ThreadSafe_WriteAllBytes(string filePath, byte[] bytes)
		{
		}

		[Token(Token = "0x6001D1F")]
		[Address(RVA = "0xA1C610", Offset = "0xA1C610", VA = "0xA1C610")]
		public static void WriteAllBytes(string filePath, byte[] bytes)
		{
		}

		[Token(Token = "0x6001D20")]
		[Address(RVA = "0xA1C684", Offset = "0xA1C684", VA = "0xA1C684")]
		public static void WriteAllText(string filePath, string text)
		{
		}

		[Token(Token = "0x6001D21")]
		[Address(RVA = "0xA1BE10", Offset = "0xA1BE10", VA = "0xA1BE10")]
		public static void SetNoBackupFlag(string filePath)
		{
		}

		[Token(Token = "0x6001D22")]
		[Address(RVA = "0xA1C720", Offset = "0xA1C720", VA = "0xA1C720")]
		public UkenFile()
		{
		}
	}
}
