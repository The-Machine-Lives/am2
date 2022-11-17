using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;

[Token(Token = "0x2000192")]
public class AutoBanController : DepotController, IInventoryProgressTracker
{
	[Token(Token = "0x400096C")]
	public const string c_banItemRef = "social_bammed";

	[Token(Token = "0x400096D")]
	private const string c_wasBannedPlayerPrefsKey = "bammed";

	[Token(Token = "0x400096E")]
	private const string c_autoBanFeatureKey = "auto_bam_users";

	[Token(Token = "0x400096F")]
	[FieldOffset(Offset = "0x20")]
	private List<BanCondition> m_maxQuantityConditions;

	[Token(Token = "0x4000970")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, BanCondition> m_maxTransactionByItemRef;

	[Token(Token = "0x4000971")]
	[FieldOffset(Offset = "0x30")]
	private bool m_banImmune;

	[Token(Token = "0x4000972")]
	[FieldOffset(Offset = "0x31")]
	private bool m_autoBanFeatureEnabled;

	[Token(Token = "0x4000973")]
	[FieldOffset(Offset = "0x38")]
	private AM2InventoryController m_inventoryController;

	[Token(Token = "0x4000974")]
	[FieldOffset(Offset = "0x40")]
	private Features m_features;

	[Token(Token = "0x6000AE4")]
	[Address(RVA = "0xA3A8CC", Offset = "0xA3A8CC", VA = "0xA3A8CC")]
	public AutoBanController(DataStoreController dataStoreController, AM2InventoryController inventoryController, Features features, bool debugBanImmune)
	{
	}

	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0xA3A994", Offset = "0xA3A994", VA = "0xA3A994", Slot = "9")]
	public override void OnDataUpdated()
	{
	}

	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0xA3AD44", Offset = "0xA3AD44", VA = "0xA3AD44", Slot = "6")]
	public override bool PostLoadContent()
	{
		return default(bool);
	}

	[Token(Token = "0x6000AE7")]
	[Address(RVA = "0xA3B060", Offset = "0xA3B060", VA = "0xA3B060")]
	public void OnInventoryRevision(List<InventoryRevision> revisions)
	{
	}

	[Token(Token = "0x6000AE8")]
	[Address(RVA = "0xA3B154", Offset = "0xA3B154", VA = "0xA3B154")]
	public bool IsBanned()
	{
		return default(bool);
	}

	[Token(Token = "0x6000AE9")]
	[Address(RVA = "0xA3B1D8", Offset = "0xA3B1D8", VA = "0xA3B1D8", Slot = "10")]
	public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
	{
	}

	[Token(Token = "0x6000AEA")]
	[Address(RVA = "0xA3AFA4", Offset = "0xA3AFA4", VA = "0xA3AFA4")]
	private void ValidateAllItemQuantities()
	{
	}

	[Token(Token = "0x6000AEB")]
	[Address(RVA = "0xA3B29C", Offset = "0xA3B29C", VA = "0xA3B29C")]
	private void ValidateItemQuantity(BanCondition quantityCondition)
	{
	}

	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0xA3AE38", Offset = "0xA3AE38", VA = "0xA3AE38")]
	private void BanUserFromSocialFeatures(BanCondition banCondition)
	{
	}
}
