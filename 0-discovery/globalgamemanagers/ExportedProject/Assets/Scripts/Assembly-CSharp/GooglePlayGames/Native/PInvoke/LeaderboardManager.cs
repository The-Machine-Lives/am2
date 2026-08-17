using System;
using GooglePlayGames.BasicApi;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200026B")]
	internal class LeaderboardManager
	{
		[Token(Token = "0x200070B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E08", Offset = "0x820E08")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x40020F5")]
			[FieldOffset(Offset = "0x10")]
			public LeaderboardManager _003C_003E4__this;

			[Token(Token = "0x40020F6")]
			[FieldOffset(Offset = "0x18")]
			public ScorePageToken token;

			[Token(Token = "0x40020F7")]
			[FieldOffset(Offset = "0x20")]
			public string playerId;

			[Token(Token = "0x40020F8")]
			[FieldOffset(Offset = "0x28")]
			public int rowCount;

			[Token(Token = "0x40020F9")]
			[FieldOffset(Offset = "0x30")]
			public Action<LeaderboardScoreData> callback;

			[Token(Token = "0x6002FCB")]
			[Address(RVA = "0xC76AF4", Offset = "0xC76AF4", VA = "0xC76AF4")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6002FCC")]
			[Address(RVA = "0xC77B24", Offset = "0xC77B24", VA = "0xC77B24")]
			internal void _003CLoadLeaderboardData_003Eb__0(FetchResponse rsp)
			{
			}
		}

		[Token(Token = "0x200070C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E18", Offset = "0x820E18")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x40020FA")]
			[FieldOffset(Offset = "0x10")]
			public LeaderboardManager _003C_003E4__this;

			[Token(Token = "0x40020FB")]
			[FieldOffset(Offset = "0x18")]
			public LeaderboardScoreData data;

			[Token(Token = "0x40020FC")]
			[FieldOffset(Offset = "0x20")]
			public string selfPlayerId;

			[Token(Token = "0x40020FD")]
			[FieldOffset(Offset = "0x28")]
			public int maxResults;

			[Token(Token = "0x40020FE")]
			[FieldOffset(Offset = "0x30")]
			public ScorePageToken token;

			[Token(Token = "0x40020FF")]
			[FieldOffset(Offset = "0x38")]
			public Action<LeaderboardScoreData> callback;

			[Token(Token = "0x6002FCD")]
			[Address(RVA = "0xC76F8C", Offset = "0xC76F8C", VA = "0xC76F8C")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6002FCE")]
			[Address(RVA = "0xC77B84", Offset = "0xC77B84", VA = "0xC77B84")]
			internal void _003CHandleFetch_003Eb__0(FetchScoreSummaryResponse rsp)
			{
			}
		}

		[Token(Token = "0x200070D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E28", Offset = "0x820E28")]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			[Token(Token = "0x4002100")]
			[FieldOffset(Offset = "0x10")]
			public LeaderboardManager _003C_003E4__this;

			[Token(Token = "0x4002101")]
			[FieldOffset(Offset = "0x18")]
			public LeaderboardScoreData data;

			[Token(Token = "0x4002102")]
			[FieldOffset(Offset = "0x20")]
			public ScorePageToken token;

			[Token(Token = "0x4002103")]
			[FieldOffset(Offset = "0x28")]
			public Action<LeaderboardScoreData> callback;

			[Token(Token = "0x6002FCF")]
			[Address(RVA = "0xC77538", Offset = "0xC77538", VA = "0xC77538")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6002FD0")]
			[Address(RVA = "0xC77ADC", Offset = "0xC77ADC", VA = "0xC77ADC")]
			internal void _003CLoadScorePage_003Eb__0(FetchScorePageResponse rsp)
			{
			}
		}

		[Token(Token = "0x4000D1D")]
		[FieldOffset(Offset = "0x10")]
		private readonly GameServices mServices;

		[Token(Token = "0x1700029E")]
		internal int LeaderboardMaxResults
		{
			[Token(Token = "0x600124A")]
			[Address(RVA = "0xC76380", Offset = "0xC76380", VA = "0xC76380")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6001249")]
		[Address(RVA = "0xC7451C", Offset = "0xC7451C", VA = "0xC7451C")]
		internal LeaderboardManager(GameServices services)
		{
		}

		[Token(Token = "0x600124B")]
		[Address(RVA = "0xC76388", Offset = "0xC76388", VA = "0xC76388")]
		internal void SubmitScore(string leaderboardId, long score, string metadata)
		{
		}

		[Token(Token = "0x600124C")]
		[Address(RVA = "0xC76694", Offset = "0xC76694", VA = "0xC76694")]
		internal void ShowAllUI(Action<CommonErrorStatus.UIStatus> callback)
		{
		}

		[Token(Token = "0x600124D")]
		[Address(RVA = "0xC7677C", Offset = "0xC7677C", VA = "0xC7677C")]
		internal void ShowUI(string leaderboardId, LeaderboardTimeSpan span, Action<CommonErrorStatus.UIStatus> callback)
		{
		}

		[Token(Token = "0x600124E")]
		[Address(RVA = "0xC7687C", Offset = "0xC7687C", VA = "0xC7687C")]
		public void LoadLeaderboardData(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, string playerId, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x600124F")]
		[Address(RVA = "0xC761F4", Offset = "0xC761F4", VA = "0xC761F4")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8360E8", Offset = "0x8360E8")]
		private static void InternalFetchCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x6001250")]
		[Address(RVA = "0xC76AFC", Offset = "0xC76AFC", VA = "0xC76AFC")]
		internal void HandleFetch(ScorePageToken token, FetchResponse response, string selfPlayerId, int maxResults, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6001251")]
		[Address(RVA = "0xC76278", Offset = "0xC76278", VA = "0xC76278")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x83614C", Offset = "0x83614C")]
		private static void InternalFetchSummaryCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x6001252")]
		[Address(RVA = "0xC76F94", Offset = "0xC76F94", VA = "0xC76F94")]
		internal void HandleFetchScoreSummary(LeaderboardScoreData data, FetchScoreSummaryResponse response, string selfPlayerId, int maxResults, ScorePageToken token, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6001253")]
		[Address(RVA = "0xC771EC", Offset = "0xC771EC", VA = "0xC771EC")]
		public void LoadScorePage(LeaderboardScoreData data, int maxResults, ScorePageToken token, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6001254")]
		[Address(RVA = "0xC762FC", Offset = "0xC762FC", VA = "0xC762FC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8361B0", Offset = "0x8361B0")]
		private static void InternalFetchScorePage(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x6001255")]
		[Address(RVA = "0xC77540", Offset = "0xC77540", VA = "0xC77540")]
		internal void HandleFetchScorePage(LeaderboardScoreData data, ScorePageToken token, FetchScorePageResponse rsp, Action<LeaderboardScoreData> callback)
		{
		}
	}
}
