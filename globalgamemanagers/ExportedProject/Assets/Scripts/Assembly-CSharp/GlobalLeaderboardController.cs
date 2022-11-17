using System;
using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Framework.Casual;
using Uken.Framework.Casual.Leaderboards;
using Uken.Library.Inventory;
using Uken.Library.Scoreboards;
using Uken.Library.UkenTime;

[Token(Token = "0x20001C7")]
public class GlobalLeaderboardController : UkenController, ILeaderboardResultsListener, IInventoryProgressTracker
{
	[Token(Token = "0x4000A7F")]
	public const string GLOBAL_LEADERBOARDS_FEATURE = "global_leaderboards";

	[Token(Token = "0x4000A80")]
	public const string GLOBAL_LEADERBOARDS_SOURCE = "global";

	[Token(Token = "0x4000A81")]
	public const string COLLECTION_EVENT_USER_LEADERBOARD_SOURCE = "collection_user";

	[Token(Token = "0x4000A82")]
	[FieldOffset(Offset = "0x18")]
	private EventQueueable<LeaderboardResultsMessage> m_resultMessages;

	[Token(Token = "0x4000A83")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, List<LeaderboardDefinition>> m_leaderboardsByTrackedItem;

	[Token(Token = "0x4000A84")]
	[FieldOffset(Offset = "0x28")]
	private List<LeaderboardDefinition> m_allLeaderboards;

	[Token(Token = "0x4000A85")]
	[FieldOffset(Offset = "0x30")]
	private SharedDataCacheController m_dataCacheController;

	[Token(Token = "0x4000A86")]
	[FieldOffset(Offset = "0x38")]
	private LeaderboardController m_leaderboardController;

	[Token(Token = "0x4000A87")]
	[FieldOffset(Offset = "0x40")]
	private UkenTimeController m_timeController;

	[Token(Token = "0x4000A88")]
	[FieldOffset(Offset = "0x48")]
	private AM2MessageController m_am2MessageController;

	[Token(Token = "0x4000A89")]
	[FieldOffset(Offset = "0x50")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000A8A")]
	[FieldOffset(Offset = "0x58")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x4000A8B")]
	[FieldOffset(Offset = "0x60")]
	private CasualAnalog m_analogController;

	[Token(Token = "0x4000A8C")]
	[FieldOffset(Offset = "0x68")]
	private AutoBanController m_autoBanController;

	[Token(Token = "0x4000A8D")]
	[FieldOffset(Offset = "0x70")]
	private bool m_leaderboardAllowedToTrack;

	[Token(Token = "0x6000C36")]
	[Address(RVA = "0x9D4870", Offset = "0x9D4870", VA = "0x9D4870")]
	public GlobalLeaderboardController(SharedDataCacheController dataCacheController, LeaderboardController leaderboardController, UkenTimeController timeController, AM2MessageController am2MessageController, Localizations localizationController, InventoryController inventoryController, CasualAnalog analogController, AutoBanController autoBanController)
	{
	}

	[Token(Token = "0x6000C37")]
	[Address(RVA = "0x9D4984", Offset = "0x9D4984", VA = "0x9D4984", Slot = "6")]
	public override bool PostLoadContent()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C38")]
	[Address(RVA = "0x9D4BD4", Offset = "0x9D4BD4", VA = "0x9D4BD4")]
	public void SetAllowedToTrack()
	{
	}

	[Token(Token = "0x6000C39")]
	[Address(RVA = "0x9D4BE0", Offset = "0x9D4BE0", VA = "0x9D4BE0")]
	public GlobalLeaderboard Get(string reference)
	{
		return null;
	}

	[Token(Token = "0x6000C3A")]
	[Address(RVA = "0x9D4C18", Offset = "0x9D4C18", VA = "0x9D4C18", Slot = "11")]
	public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
	{
	}

	[Token(Token = "0x6000C3B")]
	[Address(RVA = "0x9D4DA0", Offset = "0x9D4DA0", VA = "0x9D4DA0")]
	public void PostProgressForLeaderboard(LeaderboardDefinition leaderboard, long progress)
	{
	}

	[Token(Token = "0x6000C3C")]
	[Address(RVA = "0x9D4E54", Offset = "0x9D4E54", VA = "0x9D4E54")]
	public Leaderboard GetLeaderboardEntries(GlobalLeaderboard globalLeaderboard)
	{
		return null;
	}

	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0x9D4EE8", Offset = "0x9D4EE8", VA = "0x9D4EE8")]
	public void QueryActiveGLobalLeaderboard(GlobalLeaderboard globalLeaderboard, Action<LeaderboardEntries> onComplete)
	{
	}

	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0x9D50C4", Offset = "0x9D50C4", VA = "0x9D50C4")]
	public void QueryAllActiveGlobalLeaderboards()
	{
	}

	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x9D5278", Offset = "0x9D5278", VA = "0x9D5278")]
	private List<LeaderboardDefinition> GetActiveLeaderboards()
	{
		return null;
	}

	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x9D53D4", Offset = "0x9D53D4", VA = "0x9D53D4")]
	private void OnQueryLeaderboardsComplete(LeaderboardEntries result)
	{
	}

	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x9D5608", Offset = "0x9D5608", VA = "0x9D5608", Slot = "10")]
	public void LeaderboardResultsReceived(LeaderboardDefinition leaderboard, ScoreboardEntity entity)
	{
	}

	[Token(Token = "0x6000C42")]
	[Address(RVA = "0x9BFE90", Offset = "0x9BFE90", VA = "0x9BFE90")]
	public Queue<LeaderboardResultsMessage> ConsumeLeaderboardResults()
	{
		return null;
	}
}
