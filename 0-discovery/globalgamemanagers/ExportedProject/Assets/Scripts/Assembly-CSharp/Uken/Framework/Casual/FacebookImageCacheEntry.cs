using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004D4")]
	public class FacebookImageCacheEntry
	{
		[Token(Token = "0x40016A2")]
		[FieldOffset(Offset = "0x10")]
		public Sprite m_imageSprite;

		[Token(Token = "0x40016A3")]
		[FieldOffset(Offset = "0x18")]
		public int m_expiration;

		[Token(Token = "0x6002464")]
		[Address(RVA = "0xA67CF0", Offset = "0xA67CF0", VA = "0xA67CF0")]
		public FacebookImageCacheEntry(Sprite imageSprite, int expiration)
		{
		}
	}
}
