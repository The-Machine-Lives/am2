using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002A8")]
	internal static class LeaderboardManager
	{
		[Token(Token = "0x2000746")]
		internal delegate void FetchCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000747")]
		internal delegate void FetchAllCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000748")]
		internal delegate void FetchScorePageCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000749")]
		internal delegate void FetchScoreSummaryCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x200074A")]
		internal delegate void FetchAllScoreSummariesCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x200074B")]
		internal delegate void ShowAllUICallback(CommonErrorStatus.UIStatus arg0, IntPtr arg1);

		[Token(Token = "0x200074C")]
		internal delegate void ShowUICallback(CommonErrorStatus.UIStatus arg0, IntPtr arg1);

		[PreserveSig]
		[Token(Token = "0x6001483")]
		[Address(RVA = "0x14725AC", Offset = "0x14725AC", VA = "0x14725AC")]
		internal static extern void LeaderboardManager_FetchAll(HandleRef self, Types.DataSource data_source, FetchAllCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001484")]
		[Address(RVA = "0x1472678", Offset = "0x1472678", VA = "0x1472678")]
		internal static extern void LeaderboardManager_FetchScoreSummary(HandleRef self, Types.DataSource data_source, string leaderboard_id, Types.LeaderboardTimeSpan time_span, Types.LeaderboardCollection collection, FetchScoreSummaryCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001485")]
		[Address(RVA = "0x1472778", Offset = "0x1472778", VA = "0x1472778")]
		internal static extern IntPtr LeaderboardManager_ScorePageToken(HandleRef self, string leaderboard_id, Types.LeaderboardStart start, Types.LeaderboardTimeSpan time_span, Types.LeaderboardCollection collection);

		[PreserveSig]
		[Token(Token = "0x6001486")]
		[Address(RVA = "0x1472860", Offset = "0x1472860", VA = "0x1472860")]
		internal static extern void LeaderboardManager_ShowAllUI(HandleRef self, ShowAllUICallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001487")]
		[Address(RVA = "0x147291C", Offset = "0x147291C", VA = "0x147291C")]
		internal static extern void LeaderboardManager_FetchScorePage(HandleRef self, Types.DataSource data_source, IntPtr token, uint max_results, FetchScorePageCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001488")]
		[Address(RVA = "0x1472A00", Offset = "0x1472A00", VA = "0x1472A00")]
		internal static extern void LeaderboardManager_FetchAllScoreSummaries(HandleRef self, Types.DataSource data_source, string leaderboard_id, FetchAllScoreSummariesCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001489")]
		[Address(RVA = "0x1472AE8", Offset = "0x1472AE8", VA = "0x1472AE8")]
		internal static extern void LeaderboardManager_ShowUI(HandleRef self, string leaderboard_id, Types.LeaderboardTimeSpan time_span, ShowUICallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600148A")]
		[Address(RVA = "0x1472BD0", Offset = "0x1472BD0", VA = "0x1472BD0")]
		internal static extern void LeaderboardManager_Fetch(HandleRef self, Types.DataSource data_source, string leaderboard_id, FetchCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600148B")]
		[Address(RVA = "0x1472CB8", Offset = "0x1472CB8", VA = "0x1472CB8")]
		internal static extern void LeaderboardManager_SubmitScore(HandleRef self, string leaderboard_id, ulong score, string metadata);

		[PreserveSig]
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x1472DA4", Offset = "0x1472DA4", VA = "0x1472DA4")]
		internal static extern void LeaderboardManager_FetchResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x1472E40", Offset = "0x1472E40", VA = "0x1472E40")]
		internal static extern CommonErrorStatus.ResponseStatus LeaderboardManager_FetchResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600148E")]
		[Address(RVA = "0x1472EDC", Offset = "0x1472EDC", VA = "0x1472EDC")]
		internal static extern IntPtr LeaderboardManager_FetchResponse_GetData(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x1472F78", Offset = "0x1472F78", VA = "0x1472F78")]
		internal static extern void LeaderboardManager_FetchAllResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x1473014", Offset = "0x1473014", VA = "0x1473014")]
		internal static extern CommonErrorStatus.ResponseStatus LeaderboardManager_FetchAllResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x14730B0", Offset = "0x14730B0", VA = "0x14730B0")]
		internal static extern UIntPtr LeaderboardManager_FetchAllResponse_GetData_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x147314C", Offset = "0x147314C", VA = "0x147314C")]
		internal static extern IntPtr LeaderboardManager_FetchAllResponse_GetData_GetElement(HandleRef self, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x14731F8", Offset = "0x14731F8", VA = "0x14731F8")]
		internal static extern void LeaderboardManager_FetchScorePageResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001494")]
		[Address(RVA = "0x1473294", Offset = "0x1473294", VA = "0x1473294")]
		internal static extern CommonErrorStatus.ResponseStatus LeaderboardManager_FetchScorePageResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001495")]
		[Address(RVA = "0x1473330", Offset = "0x1473330", VA = "0x1473330")]
		internal static extern IntPtr LeaderboardManager_FetchScorePageResponse_GetData(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001496")]
		[Address(RVA = "0x14733CC", Offset = "0x14733CC", VA = "0x14733CC")]
		internal static extern void LeaderboardManager_FetchScoreSummaryResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x1473468", Offset = "0x1473468", VA = "0x1473468")]
		internal static extern CommonErrorStatus.ResponseStatus LeaderboardManager_FetchScoreSummaryResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001498")]
		[Address(RVA = "0x1473504", Offset = "0x1473504", VA = "0x1473504")]
		internal static extern IntPtr LeaderboardManager_FetchScoreSummaryResponse_GetData(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001499")]
		[Address(RVA = "0x14735A0", Offset = "0x14735A0", VA = "0x14735A0")]
		internal static extern void LeaderboardManager_FetchAllScoreSummariesResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x147363C", Offset = "0x147363C", VA = "0x147363C")]
		internal static extern CommonErrorStatus.ResponseStatus LeaderboardManager_FetchAllScoreSummariesResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600149B")]
		[Address(RVA = "0x14736D8", Offset = "0x14736D8", VA = "0x14736D8")]
		internal static extern UIntPtr LeaderboardManager_FetchAllScoreSummariesResponse_GetData_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600149C")]
		[Address(RVA = "0x1473774", Offset = "0x1473774", VA = "0x1473774")]
		internal static extern IntPtr LeaderboardManager_FetchAllScoreSummariesResponse_GetData_GetElement(HandleRef self, UIntPtr index);
	}
}
