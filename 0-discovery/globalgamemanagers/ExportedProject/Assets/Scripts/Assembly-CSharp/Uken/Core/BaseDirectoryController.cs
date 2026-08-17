using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003BF")]
	public class BaseDirectoryController
	{
		[Token(Token = "0x6001CDD")]
		[Address(RVA = "0xA14FA0", Offset = "0xA14FA0", VA = "0xA14FA0", Slot = "4")]
		public virtual void CreateDirectory(string directory)
		{
		}

		[Token(Token = "0x6001CDE")]
		[Address(RVA = "0xA14FA4", Offset = "0xA14FA4", VA = "0xA14FA4", Slot = "5")]
		public virtual bool Exists(string directory)
		{
			return default(bool);
		}

		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0xA14FAC", Offset = "0xA14FAC", VA = "0xA14FAC", Slot = "6")]
		public virtual string[] GetFiles(string path)
		{
			return null;
		}

		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0xA14FB4", Offset = "0xA14FB4", VA = "0xA14FB4", Slot = "7")]
		public virtual string[] GetDirectories(string path)
		{
			return null;
		}

		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0xA14FBC", Offset = "0xA14FBC", VA = "0xA14FBC", Slot = "8")]
		public virtual string GetParent(string path)
		{
			return null;
		}

		[Token(Token = "0x6001CE2")]
		[Address(RVA = "0xA15004", Offset = "0xA15004", VA = "0xA15004", Slot = "9")]
		public virtual void DeleteDirectory(string path)
		{
		}

		[Token(Token = "0x6001CE3")]
		[Address(RVA = "0xA15008", Offset = "0xA15008", VA = "0xA15008")]
		public BaseDirectoryController()
		{
		}
	}
}
