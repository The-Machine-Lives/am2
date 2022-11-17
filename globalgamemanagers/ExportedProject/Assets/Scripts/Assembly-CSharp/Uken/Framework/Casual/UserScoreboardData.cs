using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000562")]
	public class UserScoreboardData
	{
		[Token(Token = "0x4001997")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x8328C8", Offset = "0x8328C8")]
		private string m_facebookID;

		[Token(Token = "0x4001998")]
		[FieldOffset(Offset = "0x18")]
		public string m_dauberName;

		[Token(Token = "0x600292B")]
		[Address(RVA = "0xAA01D0", Offset = "0xAA01D0", VA = "0xAA01D0")]
		public UserScoreboardData()
		{
		}

		[Token(Token = "0x600292C")]
		[Address(RVA = "0xAA0234", Offset = "0xAA0234", VA = "0xAA0234")]
		public UserScoreboardData(string facebookID, string dauberName)
		{
		}

		[Token(Token = "0x600292D")]
		[Address(RVA = "0xAA02A4", Offset = "0xAA02A4", VA = "0xAA02A4")]
		public string Serialize()
		{
			return null;
		}

		[Token(Token = "0x600292E")]
		[Address(RVA = "0xAA02F8", Offset = "0xAA02F8", VA = "0xAA02F8")]
		public void Deserialize(string csvText)
		{
		}
	}
}
