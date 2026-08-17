using System;
using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x2000175")]
public class DynamicAdItem : Item
{
	[Token(Token = "0x40008F7")]
	public new const string mc_sItemType = "DynamicAdItem";

	[Token(Token = "0x40008F8")]
	private const string c_firstSeenEpoch = "first_seen_epoch";

	[Token(Token = "0x40008F9")]
	private const string c_hasBeenSeen = "has_been_seen";

	[Token(Token = "0x40008FA")]
	private const string c_timeOfferWasUnlocked = "time_offer_was_unlocked";

	[Token(Token = "0x17000125")]
	public DateTime dateOfferFirstSeenByUser
	{
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x9C3570", Offset = "0x9C3570", VA = "0x9C3570")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x9C3314", Offset = "0x9C3314", VA = "0x9C3314")]
		set
		{
		}
	}

	[Token(Token = "0x17000126")]
	public DateTime dateOfferWasUnlockedByUser
	{
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x9C362C", Offset = "0x9C362C", VA = "0x9C362C")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x9C3410", Offset = "0x9C3410", VA = "0x9C3410")]
		set
		{
		}
	}

	[Token(Token = "0x17000127")]
	public bool hasBeenSeenByUser
	{
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x9C36E8", Offset = "0x9C36E8", VA = "0x9C36E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x9C350C", Offset = "0x9C350C", VA = "0x9C350C")]
		set
		{
		}
	}

	[Token(Token = "0x6000A29")]
	[Address(RVA = "0x9C3268", Offset = "0x9C3268", VA = "0x9C3268", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000A30")]
	[Address(RVA = "0x9C3740", Offset = "0x9C3740", VA = "0x9C3740")]
	public DynamicAdItem()
	{
	}
}
