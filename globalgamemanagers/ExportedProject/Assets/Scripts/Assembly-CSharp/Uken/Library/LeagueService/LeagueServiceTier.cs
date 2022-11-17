using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.LeagueService
{
	[Token(Token = "0x200041B")]
	public class LeagueServiceTier
	{
		[Token(Token = "0x20007D6")]
		public enum RuntimeStrategy
		{
			[Token(Token = "0x40022D6")]
			UNKNOWN = 0,
			[Token(Token = "0x40022D7")]
			POINT_STRATEGY = 1
		}

		[Token(Token = "0x20007D7")]
		public enum SeasonEndStrategy
		{
			[Token(Token = "0x40022D9")]
			UNKNOWN = 0,
			[Token(Token = "0x40022DA")]
			POINT_STRATEGY = 1,
			[Token(Token = "0x40022DB")]
			RANK_STRATEGY = 2,
			[Token(Token = "0x40022DC")]
			RANK_PERCENTAGE_STRATEGY = 3
		}

		[Token(Token = "0x20007D8")]
		public enum StrategyOption
		{
			[Token(Token = "0x40022DE")]
			UNKNOWN = 0,
			[Token(Token = "0x40022DF")]
			RANK_STRATEGY_TOP = 1,
			[Token(Token = "0x40022E0")]
			RANK_STRATEGY_BOTTOM = 2
		}

		[Token(Token = "0x4001317")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x4001318")]
		[FieldOffset(Offset = "0x18")]
		public long bucketCapacity;

		[Token(Token = "0x4001319")]
		[FieldOffset(Offset = "0x20")]
		public long lowerBound;

		[Token(Token = "0x400131A")]
		[FieldOffset(Offset = "0x28")]
		public long upperBound;

		[Token(Token = "0x400131B")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		[Token(Token = "0x400131C")]
		[FieldOffset(Offset = "0x38")]
		public string runtimeDemote;

		[Token(Token = "0x400131D")]
		[FieldOffset(Offset = "0x40")]
		public string runtimePromote;

		[Token(Token = "0x400131E")]
		[FieldOffset(Offset = "0x48")]
		public string seasonEndDemote;

		[Token(Token = "0x400131F")]
		[FieldOffset(Offset = "0x50")]
		public string seasonEndPromote;

		[Token(Token = "0x4001320")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, string> strategyOptions;

		[Token(Token = "0x6001F10")]
		[Address(RVA = "0xBAB688", Offset = "0xBAB688", VA = "0xBAB688")]
		public LeagueServiceTier()
		{
		}
	}
}
