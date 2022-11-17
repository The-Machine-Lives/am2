using System.IO;
using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003C6")]
	public class WebFileController : BaseFileController
	{
		[Token(Token = "0x6001D2B")]
		[Address(RVA = "0xA1DA44", Offset = "0xA1DA44", VA = "0xA1DA44", Slot = "4")]
		public override bool Exists(string filepath)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0xA1DAD0", Offset = "0xA1DAD0", VA = "0xA1DAD0", Slot = "6")]
		public override long GetFileLength(string fileName)
		{
			return default(long);
		}

		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0xA1DBCC", Offset = "0xA1DBCC", VA = "0xA1DBCC", Slot = "8")]
		public override Stream OpenRead(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0xA1DD3C", Offset = "0xA1DD3C", VA = "0xA1DD3C", Slot = "9")]
		public override Stream OpenWrite(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0xA1DD98", Offset = "0xA1DD98", VA = "0xA1DD98", Slot = "10")]
		public override void SaveStream(Stream inputStream, string path)
		{
		}

		[Token(Token = "0x6001D30")]
		[Address(RVA = "0xA1DEDC", Offset = "0xA1DEDC", VA = "0xA1DEDC", Slot = "11")]
		public override Stream Create(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001D31")]
		[Address(RVA = "0xA1E074", Offset = "0xA1E074", VA = "0xA1E074", Slot = "12")]
		public override void Delete(string path)
		{
		}

		[Token(Token = "0x6001D32")]
		[Address(RVA = "0xA1E164", Offset = "0xA1E164", VA = "0xA1E164", Slot = "13")]
		public override string GetParent(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001D33")]
		[Address(RVA = "0xA1E2E8", Offset = "0xA1E2E8", VA = "0xA1E2E8", Slot = "14")]
		public override void Move(string source, string destination)
		{
		}

		[Token(Token = "0x6001D34")]
		[Address(RVA = "0xA1E4B4", Offset = "0xA1E4B4", VA = "0xA1E4B4", Slot = "15")]
		public override void Copy(string source, string destination)
		{
		}

		[Token(Token = "0x6001D35")]
		[Address(RVA = "0xA1E5F0", Offset = "0xA1E5F0", VA = "0xA1E5F0", Slot = "16")]
		public override void WriteAllBytes(string filePath, byte[] bytes)
		{
		}

		[Token(Token = "0x6001D36")]
		[Address(RVA = "0xA1E68C", Offset = "0xA1E68C", VA = "0xA1E68C", Slot = "17")]
		public override void WriteAllText(string filePath, string text)
		{
		}

		[Token(Token = "0x6001D37")]
		[Address(RVA = "0xA1E890", Offset = "0xA1E890", VA = "0xA1E890")]
		public WebFileController()
		{
		}
	}
}
