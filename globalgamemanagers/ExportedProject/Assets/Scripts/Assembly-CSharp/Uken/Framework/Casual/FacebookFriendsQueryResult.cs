using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004D1")]
	public class FacebookFriendsQueryResult
	{
		[Token(Token = "0x4001697")]
		[FieldOffset(Offset = "0x10")]
		public List<FacebookUserData> data;

		[Token(Token = "0x6002460")]
		[Address(RVA = "0xA67CE8", Offset = "0xA67CE8", VA = "0xA67CE8")]
		public FacebookFriendsQueryResult()
		{
		}
	}
}
