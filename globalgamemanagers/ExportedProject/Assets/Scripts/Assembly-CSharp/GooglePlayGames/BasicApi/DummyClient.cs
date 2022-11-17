using System;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20002DF")]
	public class DummyClient : IPlayGamesClient
	{
		[Token(Token = "0x600165E")]
		[Address(RVA = "0x1460424", Offset = "0x1460424", VA = "0x1460424", Slot = "4")]
		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		[Token(Token = "0x600165F")]
		[Address(RVA = "0x1460504", Offset = "0x1460504", VA = "0x1460504", Slot = "5")]
		public bool IsAuthenticated()
		{
			return default(bool);
		}

		[Token(Token = "0x6001660")]
		[Address(RVA = "0x146051C", Offset = "0x146051C", VA = "0x146051C", Slot = "6")]
		public void SignOut()
		{
		}

		[Token(Token = "0x6001661")]
		[Address(RVA = "0x1460520", Offset = "0x1460520", VA = "0x1460520", Slot = "10")]
		public string GetIdToken()
		{
			return null;
		}

		[Token(Token = "0x6001662")]
		[Address(RVA = "0x1460538", Offset = "0x1460538", VA = "0x1460538", Slot = "7")]
		public string GetUserId()
		{
			return null;
		}

		[Token(Token = "0x6001663")]
		[Address(RVA = "0x1460584", Offset = "0x1460584", VA = "0x1460584", Slot = "11")]
		public string GetServerAuthCode()
		{
			return null;
		}

		[Token(Token = "0x6001664")]
		[Address(RVA = "0x146059C", Offset = "0x146059C", VA = "0x146059C", Slot = "12")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Token(Token = "0x6001665")]
		[Address(RVA = "0x1460600", Offset = "0x1460600", VA = "0x1460600", Slot = "13")]
		public string GetUserEmail()
		{
			return null;
		}

		[Token(Token = "0x6001666")]
		[Address(RVA = "0x1460650", Offset = "0x1460650", VA = "0x1460650", Slot = "15")]
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		[Token(Token = "0x6001667")]
		[Address(RVA = "0x1460700", Offset = "0x1460700", VA = "0x1460700", Slot = "9")]
		public string GetUserDisplayName()
		{
			return null;
		}

		[Token(Token = "0x6001668")]
		[Address(RVA = "0x146074C", Offset = "0x146074C", VA = "0x146074C", Slot = "14")]
		public string GetUserImageUrl()
		{
			return null;
		}

		[Token(Token = "0x6001669")]
		[Address(RVA = "0x1460764", Offset = "0x1460764", VA = "0x1460764", Slot = "16")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		[Token(Token = "0x600166A")]
		[Address(RVA = "0x14607CC", Offset = "0x14607CC", VA = "0x14607CC", Slot = "17")]
		public void LoadAchievements(Action<Achievement[]> callback)
		{
		}

		[Token(Token = "0x600166B")]
		[Address(RVA = "0x1460834", Offset = "0x1460834", VA = "0x1460834", Slot = "18")]
		public void UnlockAchievement(string achId, Action<bool> callback)
		{
		}

		[Token(Token = "0x600166C")]
		[Address(RVA = "0x146089C", Offset = "0x146089C", VA = "0x146089C", Slot = "19")]
		public void RevealAchievement(string achId, Action<bool> callback)
		{
		}

		[Token(Token = "0x600166D")]
		[Address(RVA = "0x1460904", Offset = "0x1460904", VA = "0x1460904", Slot = "20")]
		public void IncrementAchievement(string achId, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x600166E")]
		[Address(RVA = "0x146096C", Offset = "0x146096C", VA = "0x146096C", Slot = "21")]
		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x600166F")]
		[Address(RVA = "0x14609D4", Offset = "0x14609D4", VA = "0x14609D4", Slot = "22")]
		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6001670")]
		[Address(RVA = "0x1460A3C", Offset = "0x1460A3C", VA = "0x1460A3C", Slot = "23")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6001671")]
		[Address(RVA = "0x1460AA4", Offset = "0x1460AA4", VA = "0x1460AA4", Slot = "26")]
		public int LeaderboardMaxResults()
		{
			return default(int);
		}

		[Token(Token = "0x6001672")]
		[Address(RVA = "0x1460AAC", Offset = "0x1460AAC", VA = "0x1460AAC", Slot = "24")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6001673")]
		[Address(RVA = "0x1460BD0", Offset = "0x1460BD0", VA = "0x1460BD0", Slot = "25")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6001674")]
		[Address(RVA = "0x1460C80", Offset = "0x1460C80", VA = "0x1460C80", Slot = "27")]
		public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
		{
		}

		[Token(Token = "0x6001675")]
		[Address(RVA = "0x1460CE8", Offset = "0x1460CE8", VA = "0x1460CE8", Slot = "28")]
		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback)
		{
		}

		[Token(Token = "0x6001676")]
		[Address(RVA = "0x1460D50", Offset = "0x1460D50", VA = "0x1460D50", Slot = "29")]
		public IRealTimeMultiplayerClient GetRtmpClient()
		{
			return null;
		}

		[Token(Token = "0x6001677")]
		[Address(RVA = "0x1460D68", Offset = "0x1460D68", VA = "0x1460D68", Slot = "30")]
		public ITurnBasedMultiplayerClient GetTbmpClient()
		{
			return null;
		}

		[Token(Token = "0x6001678")]
		[Address(RVA = "0x1460D80", Offset = "0x1460D80", VA = "0x1460D80", Slot = "31")]
		public ISavedGameClient GetSavedGameClient()
		{
			return null;
		}

		[Token(Token = "0x6001679")]
		[Address(RVA = "0x1460D98", Offset = "0x1460D98", VA = "0x1460D98", Slot = "32")]
		public IEventsClient GetEventsClient()
		{
			return null;
		}

		[Token(Token = "0x600167A")]
		[Address(RVA = "0x1460DB0", Offset = "0x1460DB0", VA = "0x1460DB0", Slot = "33")]
		public IVideoClient GetVideoClient()
		{
			return null;
		}

		[Token(Token = "0x600167B")]
		[Address(RVA = "0x1460DC8", Offset = "0x1460DC8", VA = "0x1460DC8", Slot = "34")]
		public void RegisterInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
		{
		}

		[Token(Token = "0x600167C")]
		[Address(RVA = "0x1460DCC", Offset = "0x1460DCC", VA = "0x1460DCC")]
		public Invitation GetInvitationFromNotification()
		{
			return null;
		}

		[Token(Token = "0x600167D")]
		[Address(RVA = "0x1460DE4", Offset = "0x1460DE4", VA = "0x1460DE4")]
		public bool HasInvitationFromNotification()
		{
			return default(bool);
		}

		[Token(Token = "0x600167E")]
		[Address(RVA = "0x1460DFC", Offset = "0x1460DFC", VA = "0x1460DFC", Slot = "8")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		[Token(Token = "0x600167F")]
		[Address(RVA = "0x1460E60", Offset = "0x1460E60", VA = "0x1460E60", Slot = "35")]
		public IUserProfile[] GetFriends()
		{
			return null;
		}

		[Token(Token = "0x6001680")]
		[Address(RVA = "0x1460EB0", Offset = "0x1460EB0", VA = "0x1460EB0", Slot = "36")]
		public IntPtr GetApiClient()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6001681")]
		[Address(RVA = "0x1460EF4", Offset = "0x1460EF4", VA = "0x1460EF4", Slot = "37")]
		public void SetGravityForPopups(Gravity gravity)
		{
		}

		[Token(Token = "0x6001682")]
		[Address(RVA = "0x1460498", Offset = "0x1460498", VA = "0x1460498")]
		private static void LogUsage()
		{
		}

		[Token(Token = "0x6001683")]
		[Address(RVA = "0x1460EF8", Offset = "0x1460EF8", VA = "0x1460EF8")]
		public DummyClient()
		{
		}
	}
}
