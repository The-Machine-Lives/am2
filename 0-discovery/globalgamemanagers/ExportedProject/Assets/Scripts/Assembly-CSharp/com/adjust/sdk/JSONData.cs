using System.IO;
using Il2CppDummyDll;

namespace com.adjust.sdk
{
	[Token(Token = "0x2000221")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x4000C09")]
		[FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x170001EF")]
		public override string Value
		{
			[Token(Token = "0x6000EC4")]
			[Address(RVA = "0x177FD5C", Offset = "0x177FD5C", VA = "0x177FD5C", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EC5")]
			[Address(RVA = "0x177FD64", Offset = "0x177FD64", VA = "0x177FD64", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x177B76C", Offset = "0x177B76C", VA = "0x177B76C")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x177FD6C", Offset = "0x177FD6C", VA = "0x177FD6C")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x6000EC8")]
		[Address(RVA = "0x177FDB0", Offset = "0x177FDB0", VA = "0x177FDB0")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x6000EC9")]
		[Address(RVA = "0x177FDF4", Offset = "0x177FDF4", VA = "0x177FDF4")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x177FE30", Offset = "0x177FE30", VA = "0x177FE30")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x177FE6C", Offset = "0x177FE6C", VA = "0x177FE6C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x177FED0", Offset = "0x177FED0", VA = "0x177FED0", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x177FF34", Offset = "0x177FF34", VA = "0x177FF34", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
}
