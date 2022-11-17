using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x20001CC")]
public class BIScoreboardEventBusController : ScoreboardEventBusController
{
	[Token(Token = "0x200064F")]
	public enum EventType
	{
		[Token(Token = "0x4001F53")]
		CoinWinnings = 1,
		[Token(Token = "0x4001F54")]
		CollectionEventItems = 2,
		[Token(Token = "0x4001F55")]
		PlayBingoRounds = 3,
		[Token(Token = "0x4001F56")]
		SingleBingos = 4,
		[Token(Token = "0x4001F57")]
		DoubleBingos = 5,
		[Token(Token = "0x4001F58")]
		TripleBingos = 6,
		[Token(Token = "0x4001F59")]
		MegaBingos = 7,
		[Token(Token = "0x4001F5A")]
		EarnXp = 8,
		[Token(Token = "0x4001F5B")]
		DaubNumbers = 9,
		[Token(Token = "0x4001F5C")]
		PlayMaxBet = 10,
		[Token(Token = "0x4001F5D")]
		DoubleDaubPowerups = 20,
		[Token(Token = "0x4001F5E")]
		InstantBingoPowerups = 21,
		[Token(Token = "0x4001F5F")]
		CompleteStageMastery = 30,
		[Token(Token = "0x4001F60")]
		CommonMasteryPieces = 31,
		[Token(Token = "0x4001F61")]
		UncommonMasteryPieces = 32,
		[Token(Token = "0x4001F62")]
		RareMasteryPieces = 33,
		[Token(Token = "0x4001F63")]
		EpicMasteryPieces = 34,
		[Token(Token = "0x4001F64")]
		LegendaryMasteryPieces = 35,
		[Token(Token = "0x4001F65")]
		CommonDaubers = 40,
		[Token(Token = "0x4001F66")]
		UncommonDaubers = 41,
		[Token(Token = "0x4001F67")]
		RareDaubers = 42,
		[Token(Token = "0x4001F68")]
		EpicDaubers = 43,
		[Token(Token = "0x4001F69")]
		LegendaryDaubers = 44,
		[Token(Token = "0x4001F6A")]
		MasteryDaubers = 45,
		[Token(Token = "0x4001F6B")]
		DailyGoals = 100,
		[Token(Token = "0x4001F6C")]
		WeeklyGoals = 101,
		[Token(Token = "0x4001F6D")]
		AllTimeGoals = 102
	}

	[Token(Token = "0x6000C4C")]
	[Address(RVA = "0xA41B5C", Offset = "0xA41B5C", VA = "0xA41B5C")]
	public void DispatchEvents(IDictionary<EventType, int> scoreboardEventBusEvents)
	{
	}

	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0xA41E80", Offset = "0xA41E80", VA = "0xA41E80")]
	public void DispatchEvent(EventType evt, int scoreboardEventBusEventValue)
	{
	}

	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0xA41E88", Offset = "0xA41E88", VA = "0xA41E88")]
	public BIScoreboardEventBusController()
	{
	}
}
