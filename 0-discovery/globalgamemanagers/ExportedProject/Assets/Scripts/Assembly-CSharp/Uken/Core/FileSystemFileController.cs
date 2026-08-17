using System;
using System.IO;
using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003C2")]
	public class FileSystemFileController : BaseFileController
	{
		[Token(Token = "0x6001CFA")]
		[Address(RVA = "0xA18084", Offset = "0xA18084", VA = "0xA18084", Slot = "4")]
		public override bool Exists(string filepath)
		{
			return default(bool);
		}

		[Token(Token = "0x6001CFB")]
		[Address(RVA = "0xA18090", Offset = "0xA18090", VA = "0xA18090", Slot = "5")]
		public override DateTime GetCreationTime(string filename)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6001CFC")]
		[Address(RVA = "0xA18104", Offset = "0xA18104", VA = "0xA18104", Slot = "6")]
		public override long GetFileLength(string fileName)
		{
			return default(long);
		}

		[Token(Token = "0x6001CFD")]
		[Address(RVA = "0xA18178", Offset = "0xA18178", VA = "0xA18178", Slot = "7")]
		public override string GetFileName(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001CFE")]
		[Address(RVA = "0xA181E0", Offset = "0xA181E0", VA = "0xA181E0", Slot = "8")]
		public override Stream OpenRead(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001CFF")]
		[Address(RVA = "0xA181EC", Offset = "0xA181EC", VA = "0xA181EC", Slot = "9")]
		public override Stream OpenWrite(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001D00")]
		[Address(RVA = "0xA181F8", Offset = "0xA181F8", VA = "0xA181F8", Slot = "11")]
		public override Stream Create(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001D01")]
		[Address(RVA = "0xA18204", Offset = "0xA18204", VA = "0xA18204", Slot = "12")]
		public override void Delete(string path)
		{
		}

		[Token(Token = "0x6001D02")]
		[Address(RVA = "0xA18210", Offset = "0xA18210", VA = "0xA18210", Slot = "13")]
		public override string GetParent(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001D03")]
		[Address(RVA = "0xA1824C", Offset = "0xA1824C", VA = "0xA1824C", Slot = "14")]
		public override void Move(string source, string destination)
		{
		}

		[Token(Token = "0x6001D04")]
		[Address(RVA = "0xA1825C", Offset = "0xA1825C", VA = "0xA1825C", Slot = "15")]
		public override void Copy(string source, string destination)
		{
		}

		[Token(Token = "0x6001D05")]
		[Address(RVA = "0xA1826C", Offset = "0xA1826C", VA = "0xA1826C", Slot = "16")]
		public override void WriteAllBytes(string filePath, byte[] bytes)
		{
		}

		[Token(Token = "0x6001D06")]
		[Address(RVA = "0xA1827C", Offset = "0xA1827C", VA = "0xA1827C", Slot = "17")]
		public override void WriteAllText(string filePath, string text)
		{
		}

		[Token(Token = "0x6001D07")]
		[Address(RVA = "0xA18304", Offset = "0xA18304", VA = "0xA18304")]
		public FileSystemFileController()
		{
		}
	}
}
