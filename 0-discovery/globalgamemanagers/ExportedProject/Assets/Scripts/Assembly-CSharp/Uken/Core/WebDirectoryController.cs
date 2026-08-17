using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003C5")]
	public class WebDirectoryController : BaseDirectoryController
	{
		[Token(Token = "0x6001D24")]
		[Address(RVA = "0xA1D23C", Offset = "0xA1D23C", VA = "0xA1D23C", Slot = "4")]
		public override void CreateDirectory(string directory)
		{
		}

		[Token(Token = "0x6001D25")]
		[Address(RVA = "0xA1D240", Offset = "0xA1D240", VA = "0xA1D240", Slot = "6")]
		public override string[] GetFiles(string path)
		{
			return null;
		}

		[Token(Token = "0x6001D26")]
		[Address(RVA = "0xA1D4E8", Offset = "0xA1D4E8", VA = "0xA1D4E8", Slot = "5")]
		public override bool Exists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D27")]
		[Address(RVA = "0xA1D55C", Offset = "0xA1D55C", VA = "0xA1D55C", Slot = "7")]
		public override string[] GetDirectories(string path)
		{
			return null;
		}

		[Token(Token = "0x6001D28")]
		[Address(RVA = "0xA1D5D0", Offset = "0xA1D5D0", VA = "0xA1D5D0", Slot = "8")]
		public override string GetParent(string path)
		{
			return null;
		}

		[Token(Token = "0x6001D29")]
		[Address(RVA = "0xA1D750", Offset = "0xA1D750", VA = "0xA1D750", Slot = "9")]
		public override void DeleteDirectory(string path)
		{
		}

		[Token(Token = "0x6001D2A")]
		[Address(RVA = "0xA1DA3C", Offset = "0xA1DA3C", VA = "0xA1DA3C")]
		public WebDirectoryController()
		{
		}
	}
}
