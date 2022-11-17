using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.IAP
{
	[Token(Token = "0x200043E")]
	public class UkenPurchasePayload
	{
		[Token(Token = "0x40013A8")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, long> items;

		[Token(Token = "0x40013A9")]
		[FieldOffset(Offset = "0x18")]
		public string reference;

		[Token(Token = "0x40013AA")]
		[FieldOffset(Offset = "0x20")]
		public int type;

		[Token(Token = "0x6001F8B")]
		[Address(RVA = "0xB96410", Offset = "0xB96410", VA = "0xB96410")]
		public static UkenPurchasePayload Create(string json)
		{
			return null;
		}

		[Token(Token = "0x6001F8C")]
		[Address(RVA = "0xB964D8", Offset = "0xB964D8", VA = "0xB964D8")]
		public UkenPurchasePayload(Dictionary<string, long> newItems, string newReference, int newPurchaseType)
		{
		}

		[Token(Token = "0x6001F8D")]
		[Address(RVA = "0xB96518", Offset = "0xB96518", VA = "0xB96518")]
		public string ToJSON()
		{
			return null;
		}
	}
}
