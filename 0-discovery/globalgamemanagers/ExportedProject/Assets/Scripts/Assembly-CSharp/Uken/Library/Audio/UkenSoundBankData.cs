using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Audio
{
	[Serializable]
	[Token(Token = "0x2000442")]
	public class UkenSoundBankData
	{
		[Token(Token = "0x6001FA9")]
		[Address(RVA = "0xAF7038", Offset = "0xAF7038", VA = "0xAF7038", Slot = "4")]
		public virtual Dictionary<string, List<string>> GetSoundBankInfo()
		{
			return null;
		}

		[Token(Token = "0x6001FAA")]
		[Address(RVA = "0xAF709C", Offset = "0xAF709C", VA = "0xAF709C")]
		public bool AddSoundBankInfo(Dictionary<string, List<string>> dict, Type enumType)
		{
			return default(bool);
		}

		[Token(Token = "0x6001FAB")]
		[Address(RVA = "0xAF7454", Offset = "0xAF7454", VA = "0xAF7454")]
		public UkenSoundBankData()
		{
		}
	}
}
