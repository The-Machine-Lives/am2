using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	[Token(Token = "0x200024E")]
	public class PlayGamesPlatform : ISocialPlatform
	{
		[Token(Token = "0x2000682")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820728", Offset = "0x820728")]
		private sealed class _003C_003Ec__DisplayClass30_0
		{
			[Token(Token = "0x4001FE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<INearbyConnectionClient> callback;

			[Token(Token = "0x6002E29")]
			[Address(RVA = "0xE71764", Offset = "0xE71764", VA = "0xE71764")]
			public _003C_003Ec__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6002E2A")]
			[Address(RVA = "0xE74A88", Offset = "0xE74A88", VA = "0xE74A88")]
			internal void _003CInitializeNearby_003Eb__0(INearbyConnectionClient client)
			{
			}
		}

		[Token(Token = "0x2000683")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820738", Offset = "0x820738")]
		private sealed class _003C_003Ec__DisplayClass37_0
		{
			[Token(Token = "0x4001FE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool> callback;

			[Token(Token = "0x6002E2B")]
			[Address(RVA = "0xE71A24", Offset = "0xE71A24", VA = "0xE71A24")]
			public _003C_003Ec__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6002E2C")]
			[Address(RVA = "0xE74B88", Offset = "0xE74B88", VA = "0xE74B88")]
			internal void _003CAuthenticate_003Eb__0(bool success, string msg)
			{
			}
		}

		[Token(Token = "0x2000684")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820748", Offset = "0x820748")]
		private sealed class _003C_003Ec__DisplayClass47_0
		{
			[Token(Token = "0x4001FE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<string> callback;

			[Token(Token = "0x4001FE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PlayGamesPlatform _003C_003E4__this;

			[Token(Token = "0x6002E2D")]
			[Address(RVA = "0xE72078", Offset = "0xE72078", VA = "0xE72078")]
			public _003C_003Ec__DisplayClass47_0()
			{
			}

			[Token(Token = "0x6002E2E")]
			[Address(RVA = "0xE74BF8", Offset = "0xE74BF8", VA = "0xE74BF8")]
			internal void _003CGetAnotherServerAuthCode_003Eb__0(bool success, string msg)
			{
			}
		}

		[Token(Token = "0x2000685")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820758", Offset = "0x820758")]
		private sealed class _003C_003Ec__DisplayClass52_0
		{
			[Token(Token = "0x4001FE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool> callback;

			[Token(Token = "0x4001FE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string achievementID;

			[Token(Token = "0x4001FE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public double progress;

			[Token(Token = "0x4001FE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PlayGamesPlatform _003C_003E4__this;

			[Token(Token = "0x6002E2F")]
			[Address(RVA = "0xE72600", Offset = "0xE72600", VA = "0xE72600")]
			public _003C_003Ec__DisplayClass52_0()
			{
			}

			[Token(Token = "0x6002E30")]
			[Address(RVA = "0xE74D68", Offset = "0xE74D68", VA = "0xE74D68")]
			internal void _003CReportProgress_003Eb__0(Achievement[] ach)
			{
			}
		}

		[Token(Token = "0x2000686")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820768", Offset = "0x820768")]
		private sealed class _003C_003Ec__DisplayClass57_0
		{
			[Token(Token = "0x4001FE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<IAchievementDescription[]> callback;

			[Token(Token = "0x6002E31")]
			[Address(RVA = "0xE73210", Offset = "0xE73210", VA = "0xE73210")]
			public _003C_003Ec__DisplayClass57_0()
			{
			}

			[Token(Token = "0x6002E32")]
			[Address(RVA = "0xE75344", Offset = "0xE75344", VA = "0xE75344")]
			internal void _003CLoadAchievementDescriptions_003Eb__0(Achievement[] ach)
			{
			}
		}

		[Token(Token = "0x2000687")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820778", Offset = "0x820778")]
		private sealed class _003C_003Ec__DisplayClass58_0
		{
			[Token(Token = "0x4001FE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<IAchievement[]> callback;

			[Token(Token = "0x6002E33")]
			[Address(RVA = "0xE733B0", Offset = "0xE733B0", VA = "0xE733B0")]
			public _003C_003Ec__DisplayClass58_0()
			{
			}

			[Token(Token = "0x6002E34")]
			[Address(RVA = "0xE7549C", Offset = "0xE7549C", VA = "0xE7549C")]
			internal void _003CLoadAchievements_003Eb__0(Achievement[] ach)
			{
			}
		}

		[Token(Token = "0x2000688")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820788", Offset = "0x820788")]
		private sealed class _003C_003Ec__DisplayClass62_0
		{
			[Token(Token = "0x4001FEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<IScore[]> callback;

			[Token(Token = "0x6002E35")]
			[Address(RVA = "0xE73C34", Offset = "0xE73C34", VA = "0xE73C34")]
			public _003C_003Ec__DisplayClass62_0()
			{
			}

			[Token(Token = "0x6002E36")]
			[Address(RVA = "0xE755F4", Offset = "0xE755F4", VA = "0xE755F4")]
			internal void _003CLoadScores_003Eb__0(LeaderboardScoreData scoreData)
			{
			}
		}

		[Token(Token = "0x2000689")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820798", Offset = "0x820798")]
		private sealed class _003C_003Ec__DisplayClass74_0
		{
			[Token(Token = "0x4001FEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlayGamesPlatform _003C_003E4__this;

			[Token(Token = "0x4001FEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ILeaderboard board;

			[Token(Token = "0x4001FED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<bool> callback;

			[Token(Token = "0x6002E37")]
			[Address(RVA = "0xE74648", Offset = "0xE74648", VA = "0xE74648")]
			public _003C_003Ec__DisplayClass74_0()
			{
			}

			[Token(Token = "0x6002E38")]
			[Address(RVA = "0xE75680", Offset = "0xE75680", VA = "0xE75680")]
			internal void _003CLoadScores_003Eb__0(LeaderboardScoreData scoreData)
			{
			}
		}

		[Token(Token = "0x200068A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8207A8", Offset = "0x8207A8")]
		private sealed class _003C_003Ec__DisplayClass77_0
		{
			[Token(Token = "0x4001FEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlayGamesPlatform _003C_003E4__this;

			[Token(Token = "0x4001FEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PlayGamesLeaderboard board;

			[Token(Token = "0x4001FF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<bool> callback;

			[Token(Token = "0x6002E39")]
			[Address(RVA = "0xE74A7C", Offset = "0xE74A7C", VA = "0xE74A7C")]
			public _003C_003Ec__DisplayClass77_0()
			{
			}

			[Token(Token = "0x6002E3A")]
			[Address(RVA = "0xE75784", Offset = "0xE75784", VA = "0xE75784")]
			internal void _003CHandleLoadingScores_003Eb__0(LeaderboardScoreData nextScoreData)
			{
			}
		}

		[Token(Token = "0x200068B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8207B8", Offset = "0x8207B8")]
		private sealed class _003C_003Ec__DisplayClass80_0<T>
		{
			[Token(Token = "0x4001FF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> toConvert;

			[Token(Token = "0x6002E3B")]
			public _003C_003Ec__DisplayClass80_0()
			{
			}

			[Token(Token = "0x6002E3C")]
			internal void _003CToOnGameThread_003Eb__1(T val)
			{
			}
		}

		[Token(Token = "0x200068C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8207C8", Offset = "0x8207C8")]
		private sealed class _003C_003Ec__DisplayClass80_1<T>
		{
			[Token(Token = "0x4001FF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T val;

			[Token(Token = "0x4001FF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass80_0<T> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6002E3D")]
			public _003C_003Ec__DisplayClass80_1()
			{
			}

			[Token(Token = "0x6002E3E")]
			internal void _003CToOnGameThread_003Eb__2()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200068D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8207D8", Offset = "0x8207D8")]
		private sealed class _003C_003Ec__80<T>
		{
			[Token(Token = "0x4001FF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec__80<T> _003C_003E9;

			[Token(Token = "0x4001FF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Action<T> _003C_003E9__80_0;

			[Token(Token = "0x6002E40")]
			public _003C_003Ec__80()
			{
			}

			[Token(Token = "0x6002E41")]
			internal void _003CToOnGameThread_003Eb__80_0(T _003Cp0_003E)
			{
			}
		}

		[Token(Token = "0x4000CD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PlayGamesPlatform sInstance;

		[Token(Token = "0x4000CD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool sNearbyInitializePending;

		[Token(Token = "0x4000CD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static INearbyConnectionClient sNearbyConnectionClient;

		[Token(Token = "0x4000CD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly PlayGamesClientConfiguration mConfiguration;

		[Token(Token = "0x4000CD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PlayGamesLocalUser mLocalUser;

		[Token(Token = "0x4000CD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IPlayGamesClient mClient;

		[Token(Token = "0x4000CD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string mDefaultLbUi;

		[Token(Token = "0x4000CD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, string> mIdMap;

		[Token(Token = "0x17000288")]
		public static bool DebugLogEnabled
		{
			[Token(Token = "0x60010D3")]
			[Address(RVA = "0xE70F1C", Offset = "0xE70F1C", VA = "0xE70F1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010D4")]
			[Address(RVA = "0xE70F78", Offset = "0xE70F78", VA = "0xE70F78")]
			set
			{
			}
		}

		[Token(Token = "0x17000289")]
		public static PlayGamesPlatform Instance
		{
			[Token(Token = "0x60010D5")]
			[Address(RVA = "0xE6D9D8", Offset = "0xE6D9D8", VA = "0xE6D9D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700028A")]
		public static INearbyConnectionClient Nearby
		{
			[Token(Token = "0x60010D6")]
			[Address(RVA = "0xE710F4", Offset = "0xE710F4", VA = "0xE710F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700028B")]
		public IRealTimeMultiplayerClient RealTime
		{
			[Token(Token = "0x60010D7")]
			[Address(RVA = "0xE713C4", Offset = "0xE713C4", VA = "0xE713C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700028C")]
		public ITurnBasedMultiplayerClient TurnBased
		{
			[Token(Token = "0x60010D8")]
			[Address(RVA = "0xE7147C", Offset = "0xE7147C", VA = "0xE7147C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700028D")]
		public ISavedGameClient SavedGame
		{
			[Token(Token = "0x60010D9")]
			[Address(RVA = "0xE71534", Offset = "0xE71534", VA = "0xE71534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700028E")]
		public IEventsClient Events
		{
			[Token(Token = "0x60010DA")]
			[Address(RVA = "0xE715EC", Offset = "0xE715EC", VA = "0xE715EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700028F")]
		public IVideoClient Video
		{
			[Token(Token = "0x60010DB")]
			[Address(RVA = "0xE716A4", Offset = "0xE716A4", VA = "0xE716A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000290")]
		public ILocalUser localUser
		{
			[Token(Token = "0x60010DC")]
			[Address(RVA = "0xE7175C", Offset = "0xE7175C", VA = "0xE7175C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010D1")]
		[Address(RVA = "0xE70D4C", Offset = "0xE70D4C", VA = "0xE70D4C")]
		internal PlayGamesPlatform(IPlayGamesClient client)
		{
		}

		[Token(Token = "0x60010D2")]
		[Address(RVA = "0xE70E3C", Offset = "0xE70E3C", VA = "0xE70E3C")]
		private PlayGamesPlatform(PlayGamesClientConfiguration configuration)
		{
		}

		[Token(Token = "0x60010DD")]
		[Address(RVA = "0xE70FDC", Offset = "0xE70FDC", VA = "0xE70FDC")]
		public static void InitializeInstance(PlayGamesClientConfiguration configuration)
		{
		}

		[Token(Token = "0x60010DE")]
		[Address(RVA = "0xE711F0", Offset = "0xE711F0", VA = "0xE711F0")]
		public static void InitializeNearby(Action<INearbyConnectionClient> callback)
		{
		}

		[Token(Token = "0x60010DF")]
		[Address(RVA = "0xE7176C", Offset = "0xE7176C", VA = "0xE7176C")]
		public static PlayGamesPlatform Activate()
		{
			return null;
		}

		[Token(Token = "0x60010E0")]
		[Address(RVA = "0xE7182C", Offset = "0xE7182C", VA = "0xE7182C")]
		public IntPtr GetApiClient()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60010E1")]
		[Address(RVA = "0xE718E4", Offset = "0xE718E4", VA = "0xE718E4")]
		public void SetGravityForPopups(Gravity gravity)
		{
		}

		[Token(Token = "0x60010E2")]
		[Address(RVA = "0xE719AC", Offset = "0xE719AC", VA = "0xE719AC")]
		public void AddIdMapping(string fromId, string toId)
		{
		}

		[Token(Token = "0x60010E3")]
		[Address(RVA = "0xE6FA7C", Offset = "0xE6FA7C", VA = "0xE6FA7C")]
		public void Authenticate(Action<bool> callback)
		{
		}

		[Token(Token = "0x60010E4")]
		[Address(RVA = "0xE6FABC", Offset = "0xE6FABC", VA = "0xE6FABC")]
		public void Authenticate(Action<bool, string> callback)
		{
		}

		[Token(Token = "0x60010E5")]
		[Address(RVA = "0xE6FB08", Offset = "0xE6FB08", VA = "0xE6FB08")]
		public void Authenticate(Action<bool> callback, bool silent)
		{
		}

		[Token(Token = "0x60010E6")]
		[Address(RVA = "0xE6FC08", Offset = "0xE6FC08", VA = "0xE6FC08")]
		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		[Token(Token = "0x60010E7")]
		[Address(RVA = "0xE71A2C", Offset = "0xE71A2C", VA = "0xE71A2C", Slot = "5")]
		public void Authenticate(ILocalUser unused, Action<bool> callback)
		{
		}

		[Token(Token = "0x60010E8")]
		[Address(RVA = "0xE71A38", Offset = "0xE71A38", VA = "0xE71A38", Slot = "7")]
		public void Authenticate(ILocalUser unused, Action<bool, string> callback)
		{
		}

		[Token(Token = "0x60010E9")]
		[Address(RVA = "0xE70130", Offset = "0xE70130", VA = "0xE70130")]
		public bool IsAuthenticated()
		{
			return default(bool);
		}

		[Token(Token = "0x60010EA")]
		[Address(RVA = "0xE71A44", Offset = "0xE71A44", VA = "0xE71A44")]
		public void SignOut()
		{
		}

		[Token(Token = "0x60010EB")]
		[Address(RVA = "0xE71B18", Offset = "0xE71B18", VA = "0xE71B18", Slot = "8")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		[Token(Token = "0x60010EC")]
		[Address(RVA = "0xE70408", Offset = "0xE70408", VA = "0xE70408")]
		public string GetUserId()
		{
			return null;
		}

		[Token(Token = "0x60010ED")]
		[Address(RVA = "0xE70014", Offset = "0xE70014", VA = "0xE70014")]
		public string GetIdToken()
		{
			return null;
		}

		[Token(Token = "0x60010EE")]
		[Address(RVA = "0xE71C6C", Offset = "0xE71C6C", VA = "0xE71C6C")]
		public string GetServerAuthCode()
		{
			return null;
		}

		[Token(Token = "0x60010EF")]
		[Address(RVA = "0xE71DB0", Offset = "0xE71DB0", VA = "0xE71DB0")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Token(Token = "0x60010F0")]
		[Address(RVA = "0xE7091C", Offset = "0xE7091C", VA = "0xE7091C")]
		public string GetUserEmail()
		{
			return null;
		}

		[Token(Token = "0x60010F1")]
		[Address(RVA = "0xE70B08", Offset = "0xE70B08", VA = "0xE70B08")]
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		[Token(Token = "0x60010F2")]
		[Address(RVA = "0xE702EC", Offset = "0xE702EC", VA = "0xE702EC")]
		public string GetUserDisplayName()
		{
			return null;
		}

		[Token(Token = "0x60010F3")]
		[Address(RVA = "0xE70514", Offset = "0xE70514", VA = "0xE70514")]
		public string GetUserImageUrl()
		{
			return null;
		}

		[Token(Token = "0x60010F4")]
		[Address(RVA = "0xE72080", Offset = "0xE72080", VA = "0xE72080", Slot = "9")]
		public void ReportProgress(string achievementID, double progress, Action<bool> callback)
		{
		}

		[Token(Token = "0x60010F5")]
		[Address(RVA = "0xE72714", Offset = "0xE72714", VA = "0xE72714")]
		public void RevealAchievement(string achievementID, [Optional] Action<bool> callback)
		{
		}

		[Token(Token = "0x60010F6")]
		[Address(RVA = "0xE728B0", Offset = "0xE728B0", VA = "0xE728B0")]
		public void UnlockAchievement(string achievementID, [Optional] Action<bool> callback)
		{
		}

		[Token(Token = "0x60010F7")]
		[Address(RVA = "0xE72A4C", Offset = "0xE72A4C", VA = "0xE72A4C")]
		public void IncrementAchievement(string achievementID, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x60010F8")]
		[Address(RVA = "0xE72D60", Offset = "0xE72D60", VA = "0xE72D60")]
		public void SetStepsAtLeast(string achievementID, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x60010F9")]
		[Address(RVA = "0xE73074", Offset = "0xE73074", VA = "0xE73074", Slot = "10")]
		public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback)
		{
		}

		[Token(Token = "0x60010FA")]
		[Address(RVA = "0xE73218", Offset = "0xE73218", VA = "0xE73218", Slot = "11")]
		public void LoadAchievements(Action<IAchievement[]> callback)
		{
		}

		[Token(Token = "0x60010FB")]
		[Address(RVA = "0xE733B8", Offset = "0xE733B8", VA = "0xE733B8", Slot = "12")]
		public IAchievement CreateAchievement()
		{
			return null;
		}

		[Token(Token = "0x60010FC")]
		[Address(RVA = "0xE73410", Offset = "0xE73410", VA = "0xE73410", Slot = "13")]
		public void ReportScore(long score, string board, Action<bool> callback)
		{
		}

		[Token(Token = "0x60010FD")]
		[Address(RVA = "0xE73724", Offset = "0xE73724", VA = "0xE73724")]
		public void ReportScore(long score, string board, string metadata, Action<bool> callback)
		{
		}

		[Token(Token = "0x60010FE")]
		[Address(RVA = "0xE73ADC", Offset = "0xE73ADC", VA = "0xE73ADC", Slot = "14")]
		public void LoadScores(string leaderboardId, Action<IScore[]> callback)
		{
		}

		[Token(Token = "0x60010FF")]
		[Address(RVA = "0xE73C3C", Offset = "0xE73C3C", VA = "0xE73C3C")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6001100")]
		[Address(RVA = "0xE73DD4", Offset = "0xE73DD4", VA = "0xE73DD4")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6001101")]
		[Address(RVA = "0xE73F68", Offset = "0xE73F68", VA = "0xE73F68", Slot = "15")]
		public ILeaderboard CreateLeaderboard()
		{
			return null;
		}

		[Token(Token = "0x6001102")]
		[Address(RVA = "0xE73FCC", Offset = "0xE73FCC", VA = "0xE73FCC", Slot = "16")]
		public void ShowAchievementsUI()
		{
		}

		[Token(Token = "0x6001103")]
		[Address(RVA = "0xE73FD4", Offset = "0xE73FD4", VA = "0xE73FD4")]
		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6001104")]
		[Address(RVA = "0xE7412C", Offset = "0xE7412C", VA = "0xE7412C", Slot = "17")]
		public void ShowLeaderboardUI()
		{
		}

		[Token(Token = "0x6001105")]
		[Address(RVA = "0xE741C8", Offset = "0xE741C8", VA = "0xE741C8")]
		public void ShowLeaderboardUI(string leaderboardId)
		{
		}

		[Token(Token = "0x6001106")]
		[Address(RVA = "0xE741B8", Offset = "0xE741B8", VA = "0xE741B8")]
		public void ShowLeaderboardUI(string leaderboardId, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6001107")]
		[Address(RVA = "0xE742AC", Offset = "0xE742AC", VA = "0xE742AC")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6001108")]
		[Address(RVA = "0xE74598", Offset = "0xE74598", VA = "0xE74598")]
		public void SetDefaultLeaderboardForUI(string lbid)
		{
		}

		[Token(Token = "0x6001109")]
		[Address(RVA = "0xE6FD70", Offset = "0xE6FD70", VA = "0xE6FD70", Slot = "18")]
		public void LoadFriends(ILocalUser user, Action<bool> callback)
		{
		}

		[Token(Token = "0x600110A")]
		[Address(RVA = "0xE6EAF8", Offset = "0xE6EAF8", VA = "0xE6EAF8", Slot = "19")]
		public void LoadScores(ILeaderboard board, Action<bool> callback)
		{
		}

		[Token(Token = "0x600110B")]
		[Address(RVA = "0xE74650", Offset = "0xE74650", VA = "0xE74650", Slot = "6")]
		public bool GetLoading(ILeaderboard board)
		{
			return default(bool);
		}

		[Token(Token = "0x600110C")]
		[Address(RVA = "0xE74708", Offset = "0xE74708", VA = "0xE74708")]
		public void RegisterInvitationDelegate(InvitationReceivedDelegate deleg)
		{
		}

		[Token(Token = "0x600110D")]
		[Address(RVA = "0xE747D0", Offset = "0xE747D0", VA = "0xE747D0")]
		internal void HandleLoadingScores(PlayGamesLeaderboard board, LeaderboardScoreData scoreData, Action<bool> callback)
		{
		}

		[Token(Token = "0x600110E")]
		[Address(RVA = "0xE6FED8", Offset = "0xE6FED8", VA = "0xE6FED8")]
		internal IUserProfile[] GetFriends()
		{
			return null;
		}

		[Token(Token = "0x600110F")]
		[Address(RVA = "0xE72608", Offset = "0xE72608", VA = "0xE72608")]
		private string MapId(string id)
		{
			return null;
		}

		[Token(Token = "0x6001110")]
		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}
	}
}
