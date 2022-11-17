using Il2CppDummyDll;
using Uken.Library.Scoreboards;

namespace Uken.Framework.Casual.Leaderboards
{
	[Token(Token = "0x2000590")]
	public interface ILeaderboardResultsListener
	{
		[Token(Token = "0x6002A90")]
		void LeaderboardResultsReceived(LeaderboardDefinition leaderboard, ScoreboardEntity entity);
	}
}
