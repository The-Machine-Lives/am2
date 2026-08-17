using System;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20002E0")]
	public interface IPlayGamesClient
	{
		[Token(Token = "0x6001684")]
		void Authenticate(Action<bool, string> callback, bool silent);

		[Token(Token = "0x6001685")]
		bool IsAuthenticated();

		[Token(Token = "0x6001686")]
		void SignOut();

		[Token(Token = "0x6001687")]
		string GetUserId();

		[Token(Token = "0x6001688")]
		void LoadFriends(Action<bool> callback);

		[Token(Token = "0x6001689")]
		string GetUserDisplayName();

		[Token(Token = "0x600168A")]
		string GetIdToken();

		[Token(Token = "0x600168B")]
		string GetServerAuthCode();

		[Token(Token = "0x600168C")]
		void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);

		[Token(Token = "0x600168D")]
		string GetUserEmail();

		[Token(Token = "0x600168E")]
		string GetUserImageUrl();

		[Token(Token = "0x600168F")]
		void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback);

		[Token(Token = "0x6001690")]
		void LoadUsers(string[] userIds, Action<IUserProfile[]> callback);

		[Token(Token = "0x6001691")]
		void LoadAchievements(Action<Achievement[]> callback);

		[Token(Token = "0x6001692")]
		void UnlockAchievement(string achievementId, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x6001693")]
		void RevealAchievement(string achievementId, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x6001694")]
		void IncrementAchievement(string achievementId, int steps, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x6001695")]
		void SetStepsAtLeast(string achId, int steps, Action<bool> callback);

		[Token(Token = "0x6001696")]
		void ShowAchievementsUI(Action<UIStatus> callback);

		[Token(Token = "0x6001697")]
		void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback);

		[Token(Token = "0x6001698")]
		void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback);

		[Token(Token = "0x6001699")]
		void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback);

		[Token(Token = "0x600169A")]
		int LeaderboardMaxResults();

		[Token(Token = "0x600169B")]
		void SubmitScore(string leaderboardId, long score, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x600169C")]
		void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x600169D")]
		IRealTimeMultiplayerClient GetRtmpClient();

		[Token(Token = "0x600169E")]
		ITurnBasedMultiplayerClient GetTbmpClient();

		[Token(Token = "0x600169F")]
		ISavedGameClient GetSavedGameClient();

		[Token(Token = "0x60016A0")]
		IEventsClient GetEventsClient();

		[Token(Token = "0x60016A1")]
		IVideoClient GetVideoClient();

		[Token(Token = "0x60016A2")]
		void RegisterInvitationDelegate(InvitationReceivedDelegate invitationDelegate);

		[Token(Token = "0x60016A3")]
		IUserProfile[] GetFriends();

		[Token(Token = "0x60016A4")]
		IntPtr GetApiClient();

		[Token(Token = "0x60016A5")]
		void SetGravityForPopups(Gravity gravity);
	}
}
