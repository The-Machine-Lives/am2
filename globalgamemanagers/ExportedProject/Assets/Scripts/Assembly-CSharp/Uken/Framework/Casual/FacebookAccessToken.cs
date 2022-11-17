using Facebook.Unity;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004D5")]
	public class FacebookAccessToken
	{
		[Token(Token = "0x40016A4")]
		[FieldOffset(Offset = "0x10")]
		private AccessToken m_accessToken;

		[Token(Token = "0x17000604")]
		public string TokenString
		{
			[Token(Token = "0x6002465")]
			[Address(RVA = "0xA67C5C", Offset = "0xA67C5C", VA = "0xA67C5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000605")]
		public string FacebookId
		{
			[Token(Token = "0x6002466")]
			[Address(RVA = "0xA67C8C", Offset = "0xA67C8C", VA = "0xA67C8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002467")]
		[Address(RVA = "0xA67CBC", Offset = "0xA67CBC", VA = "0xA67CBC")]
		public FacebookAccessToken(AccessToken accessToken)
		{
		}
	}
}
