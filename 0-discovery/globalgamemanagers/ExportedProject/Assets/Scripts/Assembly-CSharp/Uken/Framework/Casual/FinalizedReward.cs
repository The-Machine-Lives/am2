using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000504")]
	public class FinalizedReward
	{
		[Token(Token = "0x40017A4")]
		[FieldOffset(Offset = "0x10")]
		public ItemView sourceItem;

		[Token(Token = "0x40017A5")]
		[FieldOffset(Offset = "0x18")]
		public long originalQuantity;

		[Token(Token = "0x40017A6")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, long> finalRewards;

		[Token(Token = "0x600266B")]
		[Address(RVA = "0xA6803C", Offset = "0xA6803C", VA = "0xA6803C")]
		public FinalizedReward()
		{
		}
	}
}
