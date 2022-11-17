using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.LeagueService
{
	[Token(Token = "0x2000418")]
	public class LeagueServiceLeague
	{
		[Token(Token = "0x4001305")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x82E438", Offset = "0x82E438")]
		public int curEndTime;

		[Token(Token = "0x4001306")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x82E470", Offset = "0x82E470")]
		public int curStartTime;

		[Token(Token = "0x4001307")]
		[FieldOffset(Offset = "0x18")]
		public string postRolloverStrategy;

		[Token(Token = "0x4001308")]
		[FieldOffset(Offset = "0x20")]
		public string preRolloverStrategy;

		[Token(Token = "0x4001309")]
		[FieldOffset(Offset = "0x28")]
		public string id;

		[Token(Token = "0x400130A")]
		[FieldOffset(Offset = "0x30")]
		public string leagueType;

		[Token(Token = "0x400130B")]
		[FieldOffset(Offset = "0x38")]
		public string name;

		[Token(Token = "0x400130C")]
		[FieldOffset(Offset = "0x40")]
		public LeagueServiceSeason season;

		[Token(Token = "0x400130D")]
		[FieldOffset(Offset = "0x48")]
		public List<LeagueServiceTier> tiers;

		[Token(Token = "0x6001F0D")]
		[Address(RVA = "0xBAB670", Offset = "0xBAB670", VA = "0xBAB670")]
		public LeagueServiceLeague()
		{
		}
	}
}
