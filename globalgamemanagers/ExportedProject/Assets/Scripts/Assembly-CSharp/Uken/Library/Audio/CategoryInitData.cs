using Il2CppDummyDll;

namespace Uken.Library.Audio
{
	[Token(Token = "0x2000443")]
	public class CategoryInitData
	{
		[Token(Token = "0x40013BC")]
		[FieldOffset(Offset = "0x10")]
		public int m_nPriority;

		[Token(Token = "0x40013BD")]
		[FieldOffset(Offset = "0x14")]
		public float m_fVolume;

		[Token(Token = "0x6001FAC")]
		[Address(RVA = "0xAF6E28", Offset = "0xAF6E28", VA = "0xAF6E28")]
		public CategoryInitData()
		{
		}

		[Token(Token = "0x6001FAD")]
		[Address(RVA = "0xAF6E58", Offset = "0xAF6E58", VA = "0xAF6E58")]
		public CategoryInitData(float volume)
		{
		}

		[Token(Token = "0x6001FAE")]
		[Address(RVA = "0xAF6E94", Offset = "0xAF6E94", VA = "0xAF6E94")]
		public CategoryInitData(float volume, int priority)
		{
		}
	}
}
