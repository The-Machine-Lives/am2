using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.Inventory.InventoryInternal;
using Uken.Library.Network;

[Token(Token = "0x200016B")]
public class AM2InventoryController : InventoryController
{
	[Serializable]
	[Token(Token = "0x2000648")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820518", Offset = "0x820518")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001F41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001F42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<bool> _003C_003E9__16_0;

		[Token(Token = "0x6002D58")]
		[Address(RVA = "0xAC3BD8", Offset = "0xAC3BD8", VA = "0xAC3BD8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002D59")]
		[Address(RVA = "0xAC3BE0", Offset = "0xAC3BE0", VA = "0xAC3BE0")]
		internal bool _003CDeleteUnusedInventoryItems_003Eb__16_0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40008CA")]
	private const string c_untrackedGenerationLogEventName = "gen";

	[Token(Token = "0x40008CB")]
	private const string c_ammoUseLogEventName = "amm";

	[Token(Token = "0x40008CC")]
	private const string c_prestigeResetInventoryBlacklistLogEventName = "prestige_reset_dont_track";

	[Token(Token = "0x40008CD")]
	private const string c_prestigeTrackedItemInventoryReset = "prestige_reset";

	[Token(Token = "0x40008CE")]
	private const string c_prestigeSpendLogEventName = "prestige_spend";

	[Token(Token = "0x40008CF")]
	private const string c_prestigeUpgradableLogEventName = "prestige_upgradable";

	[Token(Token = "0x40008D0")]
	private const string c_ltoPurchaseEventName = "lto_purchase";

	[Token(Token = "0x40008D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly List<string> c_itemsRemovedFromRefData;

	[Token(Token = "0x40008D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private CasualAnalog m_analytics;

	[Token(Token = "0x40008D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private InventoryDefaults m_defaults;

	[Token(Token = "0x40008D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private QuestController m_questController;

	[Token(Token = "0x40008D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private StoryLogController m_storyLogController;

	[Token(Token = "0x40008D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	protected int m_maxSyncDelayOnApplicationPauseInSeconds;

	[Token(Token = "0x60009EC")]
	[Address(RVA = "0x97BE24", Offset = "0x97BE24", VA = "0x97BE24")]
	public AM2InventoryController(string softCurrencyName, string hardCurrencyName, GetUserIDFunc userIDFunc, CasualAnalog analytics, Action<WebRequest> webInterface, UkenAuth authenticator, INetworkStatus networkStatus, bool enableCrashOnMinimalDetailsNotReady)
	{
	}

	[Token(Token = "0x60009ED")]
	[Address(RVA = "0x981CCC", Offset = "0x981CCC", VA = "0x981CCC", Slot = "5")]
	public override bool LoadContent()
	{
		return default(bool);
	}

	[Token(Token = "0x60009EE")]
	[Address(RVA = "0x981D80", Offset = "0x981D80", VA = "0x981D80", Slot = "6")]
	public override bool PostLoadContent()
	{
		return default(bool);
	}

	[Token(Token = "0x60009EF")]
	[Address(RVA = "0x981DB4", Offset = "0x981DB4", VA = "0x981DB4")]
	private void DeleteUnusedInventoryItems()
	{
	}

	[Token(Token = "0x60009F0")]
	[Address(RVA = "0x980E08", Offset = "0x980E08", VA = "0x980E08")]
	public void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x60009F1")]
	[Address(RVA = "0x9805B0", Offset = "0x9805B0", VA = "0x9805B0")]
	public void SaveImmediately()
	{
	}

	[Token(Token = "0x60009F2")]
	[Address(RVA = "0x981FA8", Offset = "0x981FA8", VA = "0x981FA8")]
	public bool TransactUntrackedGeneration(string reference, long delta)
	{
		return default(bool);
	}

	[Token(Token = "0x60009F3")]
	[Address(RVA = "0x982020", Offset = "0x982020", VA = "0x982020")]
	public void TransactUntrackedGeneration(Dictionary<string, long> deltas)
	{
	}

	[Token(Token = "0x60009F4")]
	[Address(RVA = "0x982090", Offset = "0x982090", VA = "0x982090")]
	public bool TransactSpendAmmo(string reference, long delta)
	{
		return default(bool);
	}

	[Token(Token = "0x60009F5")]
	[Address(RVA = "0x982108", Offset = "0x982108", VA = "0x982108")]
	public bool TransactPrestigeInventoryResetNoLog(string reference)
	{
		return default(bool);
	}

	[Token(Token = "0x60009F6")]
	[Address(RVA = "0x98218C", Offset = "0x98218C", VA = "0x98218C")]
	public bool TransactPrestigeInventoryReset(string reference)
	{
		return default(bool);
	}

	[Token(Token = "0x60009F7")]
	[Address(RVA = "0x982210", Offset = "0x982210", VA = "0x982210")]
	public bool TransactionSpendPrestigeToken(string reference, long delta, string purchasedItemReference)
	{
		return default(bool);
	}

	[Token(Token = "0x60009F8")]
	[Address(RVA = "0x982294", Offset = "0x982294", VA = "0x982294")]
	public bool TransactionPrestigeUpgradableItem(string upgradableReference, long delta, string prestigeTokenReference)
	{
		return default(bool);
	}

	[Token(Token = "0x60009F9")]
	[Address(RVA = "0x982318", Offset = "0x982318", VA = "0x982318")]
	public bool LTOTransaction(string reference, long delta, string ltoReferenceName)
	{
		return default(bool);
	}

	[Token(Token = "0x60009FA")]
	[Address(RVA = "0x98239C", Offset = "0x98239C", VA = "0x98239C", Slot = "26")]
	public override bool Transaction(string reference, long delta, string event_name, string source_sink)
	{
		return default(bool);
	}

	[Token(Token = "0x60009FB")]
	[Address(RVA = "0x97E894", Offset = "0x97E894", VA = "0x97E894")]
	public void SetDefaults(InventoryDefaults defaults)
	{
	}

	[Token(Token = "0x60009FC")]
	[Address(RVA = "0x9824AC", Offset = "0x9824AC", VA = "0x9824AC", Slot = "21")]
	public override string GetDefaultInventory()
	{
		return null;
	}

	[Token(Token = "0x60009FD")]
	[Address(RVA = "0x982A6C", Offset = "0x982A6C", VA = "0x982A6C", Slot = "33")]
	protected override void OnSendComplete(bool bSuccess, string sRawData)
	{
	}

	[Token(Token = "0x60009FE")]
	[Address(RVA = "0x982C5C", Offset = "0x982C5C", VA = "0x982C5C")]
	public void LogTransactionForBlacklistedItem(string itemRef, long delta, string eventName, string sourceSink, bool shouldOverrideQuantity = false, long overrideQuantity = 0L)
	{
	}

	[Token(Token = "0x60009FF")]
	[Address(RVA = "0x982E44", Offset = "0x982E44", VA = "0x982E44", Slot = "40")]
	protected override void LogTransaction(BaseInventoryItem item, long delta, string eventName, string sourceSink)
	{
	}

	[Token(Token = "0x6000A00")]
	[Address(RVA = "0x982D90", Offset = "0x982D90", VA = "0x982D90")]
	protected bool ShouldLogTransaction(BaseInventoryItem item, string eventName, string sourceSink)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x982F34", Offset = "0x982F34", VA = "0x982F34")]
	public void ResetItemToDefault(string referenceName, [Optional] HashSet<string> itemsToNotReset, [Optional] HashSet<string> itemTypesToNotReset, [Optional] HashSet<string> transactionLogWhiteList)
	{
	}

	[Token(Token = "0x6000A02")]
	[Address(RVA = "0x9837A0", Offset = "0x9837A0", VA = "0x9837A0")]
	public void ResetAllItemsToDefault(HashSet<string> itemsToNotReset, HashSet<string> itemTypesToNotReset, HashSet<string> transactionLogWhiteList)
	{
	}

	[Token(Token = "0x6000A03")]
	[Address(RVA = "0x983944", Offset = "0x983944", VA = "0x983944")]
	private void ApplyDefaultInventoryAfterPrestige(HashSet<string> itemsToNotReset, HashSet<string> itemTypesToNotReset)
	{
	}
}
