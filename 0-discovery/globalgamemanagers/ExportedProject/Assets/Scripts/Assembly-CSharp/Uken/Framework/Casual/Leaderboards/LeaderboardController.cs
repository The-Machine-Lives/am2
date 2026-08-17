using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Scoreboards;

namespace Uken.Framework.Casual.Leaderboards
{
	[Token(Token = "0x2000592")]
	public class LeaderboardController : UkenController
	{
		[Token(Token = "0x2000866")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8215E8", Offset = "0x8215E8")]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			[Token(Token = "0x4002413")]
			[FieldOffset(Offset = "0x10")]
			public Action<LeaderboardEntries> onComplete;

			[Token(Token = "0x4002414")]
			[FieldOffset(Offset = "0x18")]
			public LeaderboardController _003C_003E4__this;

			[Token(Token = "0x60033A2")]
			[Address(RVA = "0xA6FD7C", Offset = "0xA6FD7C", VA = "0xA6FD7C")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}
		}

		[Token(Token = "0x2000867")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8215F8", Offset = "0x8215F8")]
		private sealed class _003C_003Ec__DisplayClass12_1
		{
			[Token(Token = "0x4002415")]
			[FieldOffset(Offset = "0x10")]
			public List<ScoreboardDefinition> scoreboardDefinitions;

			[Token(Token = "0x4002416")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x60033A3")]
			[Address(RVA = "0xA6FD84", Offset = "0xA6FD84", VA = "0xA6FD84")]
			public _003C_003Ec__DisplayClass12_1()
			{
			}

			[Token(Token = "0x60033A4")]
			[Address(RVA = "0xA707D8", Offset = "0xA707D8", VA = "0xA707D8")]
			internal void _003CQueryEntriesForLeaderboards_003Eb__0(bool result, ScoreboardScoreQueryResponse response)
			{
			}
		}

		[Token(Token = "0x2000868")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821608", Offset = "0x821608")]
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			[Token(Token = "0x4002417")]
			[FieldOffset(Offset = "0x10")]
			public Action<Dictionary<string, int>> onComplete;

			[Token(Token = "0x60033A5")]
			[Address(RVA = "0xA7004C", Offset = "0xA7004C", VA = "0xA7004C")]
			public _003C_003Ec__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60033A6")]
			[Address(RVA = "0xA70C7C", Offset = "0xA70C7C", VA = "0xA70C7C")]
			internal void _003CQueryTotalEntitiesForLeaderboards_003Eb__0(bool result, ScoreboardTotalEntitiesQueryResponse response)
			{
			}
		}

		[Token(Token = "0x4001A64")]
		private const int DEFAULT_TOP_USERS_TO_GET = 20;

		[Token(Token = "0x4001A65")]
		private const int DEFAULT_ABOVE_USERS_TO_GET = 0;

		[Token(Token = "0x4001A66")]
		private const int DEFAULT_BELOW_USERS_TO_GET = 0;

		[Token(Token = "0x4001A67")]
		[FieldOffset(Offset = "0x18")]
		private List<ILeaderboardResultsListener> m_listeners;

		[Token(Token = "0x4001A68")]
		[FieldOffset(Offset = "0x20")]
		private ScoreboardController m_scoreboardController;

		[Token(Token = "0x4001A69")]
		[FieldOffset(Offset = "0x28")]
		private LeaderboardEntries m_latestBoardEntries;

		[Token(Token = "0x6002A94")]
		[Address(RVA = "0xA6F694", Offset = "0xA6F694", VA = "0xA6F694")]
		public LeaderboardController(ScoreboardController scoreboardController)
		{
		}

		[Token(Token = "0x6002A95")]
		[Address(RVA = "0xA6F7A4", Offset = "0xA6F7A4", VA = "0xA6F7A4")]
		public void RegisterListener(ILeaderboardResultsListener listener)
		{
		}

		[Token(Token = "0x6002A96")]
		[Address(RVA = "0xA6F854", Offset = "0xA6F854", VA = "0xA6F854")]
		public void UnregisterListener(ILeaderboardResultsListener listener)
		{
		}

		[Token(Token = "0x6002A97")]
		[Address(RVA = "0xA6F904", Offset = "0xA6F904", VA = "0xA6F904")]
		public bool CanPostToLeaderboards()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A98")]
		[Address(RVA = "0xA6F984", Offset = "0xA6F984", VA = "0xA6F984")]
		public void CheckForLeaderboardResults(string userID)
		{
		}

		[Token(Token = "0x6002A99")]
		[Address(RVA = "0xA6FA84", Offset = "0xA6FA84", VA = "0xA6FA84")]
		public Leaderboard GetLatestLeaderboardEntries(string entityID, string leaderboardName)
		{
			return null;
		}

		[Token(Token = "0x6002A9A")]
		[Address(RVA = "0xA6FB60", Offset = "0xA6FB60", VA = "0xA6FB60")]
		public void QueryEntriesForLeaderboards(List<LeaderboardDefinition> leaderboards, List<string> entityIDs, Action<LeaderboardEntries> onComplete, int top = 20, int above = 0, int below = 0)
		{
		}

		[Token(Token = "0x6002A9B")]
		[Address(RVA = "0xA6FF00", Offset = "0xA6FF00", VA = "0xA6FF00")]
		public void QueryTotalEntitiesForLeaderboards(List<LeaderboardDefinition> leaderboards, Action<Dictionary<string, int>> onComplete)
		{
		}

		[Token(Token = "0x6002A9C")]
		[Address(RVA = "0xA70054", Offset = "0xA70054", VA = "0xA70054")]
		public void PostEvent(LeaderboardDefinition definition, string entityID, string entityData, long value)
		{
		}

		[Token(Token = "0x6002A9D")]
		[Address(RVA = "0xA6FD8C", Offset = "0xA6FD8C", VA = "0xA6FD8C")]
		private List<ScoreboardDefinition> CreateScoreboardDefinitions(List<LeaderboardDefinition> leaderboardDefinitions)
		{
			return null;
		}

		[Token(Token = "0x6002A9E")]
		[Address(RVA = "0xA700C4", Offset = "0xA700C4", VA = "0xA700C4")]
		private ScoreboardDefinition CreateScoreboardDefinition(LeaderboardDefinition leaderboard)
		{
			return null;
		}

		[Token(Token = "0x6002A9F")]
		[Address(RVA = "0xA70220", Offset = "0xA70220", VA = "0xA70220")]
		private DateTime GetLeaderboardExpiry(EventSchedule schedule)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6002AA0")]
		[Address(RVA = "0xA703B0", Offset = "0xA703B0", VA = "0xA703B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A98C", Offset = "0x83A98C")]
		private void _003CCheckForLeaderboardResults_003Eb__10_0(bool success, ScoreboardResultResponse results)
		{
		}
	}
}
