using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.LeagueService
{
	[Token(Token = "0x2000416")]
	public class LeagueServiceController : UkenController
	{
		[Token(Token = "0x20007D0")]
		public delegate void WebHandler(WebRequest request);

		[Token(Token = "0x20007D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821098", Offset = "0x821098")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x40022CE")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, LeagueServiceGetTierResponse> onComplete;

			[Token(Token = "0x600322D")]
			[Address(RVA = "0xBA9778", Offset = "0xBA9778", VA = "0xBA9778")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600322E")]
			[Address(RVA = "0xBAB508", Offset = "0xBAB508", VA = "0xBAB508")]
			internal void _003CQueryTier_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x20007D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8210A8", Offset = "0x8210A8")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x40022CF")]
			[FieldOffset(Offset = "0x10")]
			public LeagueServiceController _003C_003E4__this;

			[Token(Token = "0x40022D0")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool, LeagueServiceGetSeasonResponse> onComplete;

			[Token(Token = "0x600322F")]
			[Address(RVA = "0xBAA424", Offset = "0xBAA424", VA = "0xBAA424")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6003230")]
			[Address(RVA = "0xBAB0C0", Offset = "0xBAB0C0", VA = "0xBAB0C0")]
			internal void _003CQueryResults_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x20007D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8210B8", Offset = "0x8210B8")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x40022D1")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, LeagueServiceGetSeasonResponse> onComplete;

			[Token(Token = "0x6003231")]
			[Address(RVA = "0xBAA750", Offset = "0xBAA750", VA = "0xBAA750")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6003232")]
			[Address(RVA = "0xBAB220", Offset = "0xBAB220", VA = "0xBAB220")]
			internal void _003CQuerySeason_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x20007D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8210C8", Offset = "0x8210C8")]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			[Token(Token = "0x40022D2")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, LeagueServiceGetLeagueResponse> onComplete;

			[Token(Token = "0x6003233")]
			[Address(RVA = "0xBAA8E8", Offset = "0xBAA8E8", VA = "0xBAA8E8")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6003234")]
			[Address(RVA = "0xBAB328", Offset = "0xBAB328", VA = "0xBAB328")]
			internal void _003CQueryLeague_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x20007D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8210D8", Offset = "0x8210D8")]
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			[Token(Token = "0x40022D3")]
			[FieldOffset(Offset = "0x10")]
			public LeagueServiceController _003C_003E4__this;

			[Token(Token = "0x40022D4")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> onComplete;

			[Token(Token = "0x6003235")]
			[Address(RVA = "0xBAADAC", Offset = "0xBAADAC", VA = "0xBAADAC")]
			public _003C_003Ec__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6003236")]
			[Address(RVA = "0xBAB430", Offset = "0xBAB430", VA = "0xBAB430")]
			internal void _003CPostScore_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x40012FB")]
		[FieldOffset(Offset = "0x18")]
		private WebHandler m_webHandler;

		[Token(Token = "0x40012FC")]
		[FieldOffset(Offset = "0x20")]
		private Queue<LeagueServicePostScoreRequest> m_postQueue;

		[Token(Token = "0x40012FD")]
		private const int MAX_ACTIVE_POSTS = 3;

		[Token(Token = "0x40012FE")]
		[FieldOffset(Offset = "0x28")]
		private int m_activePosts;

		[Token(Token = "0x40012FF")]
		[FieldOffset(Offset = "0x30")]
		private string m_baseURL;

		[Token(Token = "0x4001300")]
		[FieldOffset(Offset = "0x38")]
		private LeagueServiceGetSeasonRequest m_resultRequest;

		[Token(Token = "0x6001F02")]
		[Address(RVA = "0xBA946C", Offset = "0xBA946C", VA = "0xBA946C")]
		public LeagueServiceController(WebHandler webHandler, string baseURL)
		{
		}

		[Token(Token = "0x6001F03")]
		[Address(RVA = "0xBA94F8", Offset = "0xBA94F8", VA = "0xBA94F8", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6001F04")]
		[Address(RVA = "0xBA95E4", Offset = "0xBA95E4", VA = "0xBA95E4")]
		public void QueryTier(string entityId, string leagueId, int tierIndex, int above, int below, int top, bool previous, bool queryOverallRank, bool topQueryForSelfTierOnly, bool withEntityData, Action<bool, LeagueServiceGetTierResponse> onComplete)
		{
		}

		[Token(Token = "0x6001F05")]
		[Address(RVA = "0xBAA274", Offset = "0xBAA274", VA = "0xBAA274")]
		public void QueryResults(string entityId, string leagueId, Action<bool, LeagueServiceGetSeasonResponse> onComplete)
		{
		}

		[Token(Token = "0x6001F06")]
		[Address(RVA = "0xBAA61C", Offset = "0xBAA61C", VA = "0xBAA61C")]
		public void QuerySeason(string entityId, string leagueId, Action<bool, LeagueServiceGetSeasonResponse> onComplete)
		{
		}

		[Token(Token = "0x6001F07")]
		[Address(RVA = "0xBAA758", Offset = "0xBAA758", VA = "0xBAA758")]
		public void QueryLeague(string entityId, string leagueId, int above, int below, int top, bool previous, bool queryOverallRank, bool querySelfTierOnly, bool withEntityData, Action<bool, LeagueServiceGetLeagueResponse> onComplete)
		{
		}

		[Token(Token = "0x6001F08")]
		[Address(RVA = "0xBAAC94", Offset = "0xBAAC94", VA = "0xBAAC94")]
		public void PostScore(string entityId, string entityData, int value, Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6001F09")]
		[Address(RVA = "0xBAAFA0", Offset = "0xBAAFA0", VA = "0xBAAFA0")]
		private void QueuePost(LeagueServicePostScoreRequest postRequest)
		{
		}

		[Token(Token = "0x6001F0A")]
		[Address(RVA = "0xBAB010", Offset = "0xBAB010", VA = "0xBAB010")]
		private LeagueServicePostScoreRequest DequeuePost()
		{
			return null;
		}

		[Token(Token = "0x6001F0B")]
		[Address(RVA = "0xBA94FC", Offset = "0xBA94FC", VA = "0xBA94FC")]
		private void ProcessPostQueue()
		{
		}
	}
}
