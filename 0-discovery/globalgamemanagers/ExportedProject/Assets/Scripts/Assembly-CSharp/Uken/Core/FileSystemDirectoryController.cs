using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003C1")]
	public class FileSystemDirectoryController : BaseDirectoryController
	{
		[Token(Token = "0x6001CF3")]
		[Address(RVA = "0xA17F94", Offset = "0xA17F94", VA = "0xA17F94", Slot = "4")]
		public override void CreateDirectory(string directory)
		{
		}

		[Token(Token = "0x6001CF4")]
		[Address(RVA = "0xA17FA0", Offset = "0xA17FA0", VA = "0xA17FA0", Slot = "6")]
		public override string[] GetFiles(string path)
		{
			return null;
		}

		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0xA18014", Offset = "0xA18014", VA = "0xA18014", Slot = "7")]
		public override string[] GetDirectories(string path)
		{
			return null;
		}

		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0xA18020", Offset = "0xA18020", VA = "0xA18020", Slot = "8")]
		public override string GetParent(string path)
		{
			return null;
		}

		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0xA1805C", Offset = "0xA1805C", VA = "0xA1805C", Slot = "5")]
		public override bool Exists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0xA18068", Offset = "0xA18068", VA = "0xA18068", Slot = "9")]
		public override void DeleteDirectory(string path)
		{
		}

		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0xA1807C", Offset = "0xA1807C", VA = "0xA1807C")]
		public FileSystemDirectoryController()
		{
		}
	}
}
