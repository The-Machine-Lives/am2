using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x2000204")]
public class CollectionItem : Item
{
	[Token(Token = "0x4000B71")]
	public const string InventoryItemType = "CollectionItem";

	[Token(Token = "0x4000B72")]
	public const string CollectionIterationKey = "collection_iteration";

	[Token(Token = "0x4000B73")]
	public const string CurrentSegmentedScalarKey = "current_segment_index";

	[Token(Token = "0x170001AE")]
	public string collection_iteration
	{
		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0xA4BE6C", Offset = "0xA4BE6C", VA = "0xA4BE6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AF")]
	public long currentSegmentedScalar
	{
		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0xA4BEC4", Offset = "0xA4BEC4", VA = "0xA4BEC4")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x6000DA0")]
	[Address(RVA = "0xA4BF1C", Offset = "0xA4BF1C", VA = "0xA4BF1C")]
	public void SetIteration(string iterationValue)
	{
	}

	[Token(Token = "0x6000DA1")]
	[Address(RVA = "0xA4BF80", Offset = "0xA4BF80", VA = "0xA4BF80")]
	public void SetCurrentSegmentedScalar(long segmentIndex)
	{
	}

	[Token(Token = "0x6000DA2")]
	[Address(RVA = "0xA4C004", Offset = "0xA4C004", VA = "0xA4C004")]
	public long GetLastConfirmedRewardAmount()
	{
		return default(long);
	}

	[Token(Token = "0x6000DA3")]
	[Address(RVA = "0xA4C05C", Offset = "0xA4C05C", VA = "0xA4C05C")]
	public void SetLastConfirmedRewardAmount(long newAmount, bool allowReduction)
	{
	}

	[Token(Token = "0x6000DA4")]
	[Address(RVA = "0xA4C0F4", Offset = "0xA4C0F4", VA = "0xA4C0F4")]
	public CollectionItem()
	{
	}
}
