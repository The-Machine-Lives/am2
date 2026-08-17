using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.UserAnalytics
{
	[Token(Token = "0x20003E3")]
	public class UserProfileData
	{
		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, string> userProfileData;

		[Token(Token = "0x6001E29")]
		[Address(RVA = "0xB40F2C", Offset = "0xB40F2C", VA = "0xB40F2C")]
		public string GetValue(string key, string fallback)
		{
			return null;
		}

		[Token(Token = "0x6001E2A")]
		[Address(RVA = "0xB40C18", Offset = "0xB40C18", VA = "0xB40C18")]
		public UserProfileData()
		{
		}
	}
}
