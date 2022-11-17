using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000571")]
	public class LeagueSavedData
	{
		[Token(Token = "0x40019EC")]
		public const string LEAGUE_METADATA_ITEM = "league_metadata";

		[Token(Token = "0x40019ED")]
		public const string PREV_END_TIME_TRAIT_KEY = "prev_season_end_time";

		[Token(Token = "0x40019EE")]
		public const string PREV_LEAGUE_ID_TRAIT_KEY = "prev_league_id";

		[Token(Token = "0x40019EF")]
		public const string CURR_END_TIME_TRAIT_KEY = "curr_season_end_time";

		[Token(Token = "0x40019F0")]
		public const string CURR_LEAGUE_ID_TRAIT_KEY = "curr_league_id";

		[Token(Token = "0x40019F1")]
		public const string LAST_RESULT_END_TIME_TRAIT_KEY = "last_result_end_time";

		[Token(Token = "0x40019F2")]
		[FieldOffset(Offset = "0x10")]
		private double m_prevSeasonEndTime;

		[Token(Token = "0x40019F3")]
		[FieldOffset(Offset = "0x18")]
		private string m_prevLeagueId;

		[Token(Token = "0x40019F4")]
		[FieldOffset(Offset = "0x20")]
		private double m_currSeasonEndTime;

		[Token(Token = "0x40019F5")]
		[FieldOffset(Offset = "0x28")]
		private string m_currLeagueId;

		[Token(Token = "0x40019F6")]
		[FieldOffset(Offset = "0x30")]
		private double m_lastResultEndTime;

		[Token(Token = "0x1700074D")]
		public double PrevSeasonEndTime
		{
			[Token(Token = "0x60029B5")]
			[Address(RVA = "0xA71454", Offset = "0xA71454", VA = "0xA71454")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700074E")]
		public string PrevLeagueId
		{
			[Token(Token = "0x60029B6")]
			[Address(RVA = "0xA7145C", Offset = "0xA7145C", VA = "0xA7145C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700074F")]
		public double CurrSeasonEndTime
		{
			[Token(Token = "0x60029B7")]
			[Address(RVA = "0xA71464", Offset = "0xA71464", VA = "0xA71464")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000750")]
		public string CurrLeagueId
		{
			[Token(Token = "0x60029B8")]
			[Address(RVA = "0xA7146C", Offset = "0xA7146C", VA = "0xA7146C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000751")]
		public double LastResultEndTime
		{
			[Token(Token = "0x60029B9")]
			[Address(RVA = "0xA71474", Offset = "0xA71474", VA = "0xA71474")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x60029BA")]
		[Address(RVA = "0xA7147C", Offset = "0xA7147C", VA = "0xA7147C")]
		public LeagueSavedData()
		{
		}

		[Token(Token = "0x60029BB")]
		[Address(RVA = "0xA71484", Offset = "0xA71484", VA = "0xA71484")]
		public LeagueSavedData(double prevSeasonEndTime, string prevLeagueId, double currSeasonEndTime, string currLeagueId, double lastResultEndTime)
		{
		}

		[Token(Token = "0x60029BC")]
		[Address(RVA = "0xA714E8", Offset = "0xA714E8", VA = "0xA714E8")]
		public void UpdateCurrentSeason(string newLeagueId, double newEndTime, double currTime)
		{
		}

		[Token(Token = "0x60029BD")]
		[Address(RVA = "0xA71520", Offset = "0xA71520", VA = "0xA71520")]
		public void UpdateLastResultEndTime(double newResultEndTime)
		{
		}

		[Token(Token = "0x60029BE")]
		[Address(RVA = "0xA71528", Offset = "0xA71528", VA = "0xA71528")]
		public bool ShouldQueryResults(string newLeagueId, double currTime)
		{
			return default(bool);
		}
	}
}
