using System;
using System.IO;
using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003C0")]
	public class BaseFileController
	{
		[Token(Token = "0x6001CE4")]
		[Address(RVA = "0xA15010", Offset = "0xA15010", VA = "0xA15010", Slot = "4")]
		public virtual bool Exists(string filepath)
		{
			return default(bool);
		}

		[Token(Token = "0x6001CE5")]
		[Address(RVA = "0xA15018", Offset = "0xA15018", VA = "0xA15018", Slot = "5")]
		public virtual DateTime GetCreationTime(string filename)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6001CE6")]
		[Address(RVA = "0xA15050", Offset = "0xA15050", VA = "0xA15050", Slot = "6")]
		public virtual long GetFileLength(string fileName)
		{
			return default(long);
		}

		[Token(Token = "0x6001CE7")]
		[Address(RVA = "0xA15058", Offset = "0xA15058", VA = "0xA15058", Slot = "7")]
		public virtual string GetFileName(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001CE8")]
		[Address(RVA = "0xA150A0", Offset = "0xA150A0", VA = "0xA150A0", Slot = "8")]
		public virtual Stream OpenRead(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001CE9")]
		[Address(RVA = "0xA150A8", Offset = "0xA150A8", VA = "0xA150A8", Slot = "9")]
		public virtual Stream OpenWrite(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001CEA")]
		[Address(RVA = "0xA150B0", Offset = "0xA150B0", VA = "0xA150B0", Slot = "10")]
		public virtual void SaveStream(Stream inputStream, string path)
		{
		}

		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0xA150B4", Offset = "0xA150B4", VA = "0xA150B4", Slot = "11")]
		public virtual Stream Create(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0xA150BC", Offset = "0xA150BC", VA = "0xA150BC", Slot = "12")]
		public virtual void Delete(string path)
		{
		}

		[Token(Token = "0x6001CED")]
		[Address(RVA = "0xA150C0", Offset = "0xA150C0", VA = "0xA150C0", Slot = "13")]
		public virtual string GetParent(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0xA15108", Offset = "0xA15108", VA = "0xA15108", Slot = "14")]
		public virtual void Move(string source, string destination)
		{
		}

		[Token(Token = "0x6001CEF")]
		[Address(RVA = "0xA1510C", Offset = "0xA1510C", VA = "0xA1510C", Slot = "15")]
		public virtual void Copy(string source, string destination)
		{
		}

		[Token(Token = "0x6001CF0")]
		[Address(RVA = "0xA15110", Offset = "0xA15110", VA = "0xA15110", Slot = "16")]
		public virtual void WriteAllBytes(string filePath, byte[] bytes)
		{
		}

		[Token(Token = "0x6001CF1")]
		[Address(RVA = "0xA15114", Offset = "0xA15114", VA = "0xA15114", Slot = "17")]
		public virtual void WriteAllText(string filePath, string text)
		{
		}

		[Token(Token = "0x6001CF2")]
		[Address(RVA = "0xA15118", Offset = "0xA15118", VA = "0xA15118")]
		public BaseFileController()
		{
		}
	}
}
