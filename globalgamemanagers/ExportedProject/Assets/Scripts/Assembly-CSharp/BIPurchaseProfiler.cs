using System;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;

[Token(Token = "0x20001C9")]
public class BIPurchaseProfiler : PurchaseProfiler
{
	[Token(Token = "0x4000A8E")]
	[FieldOffset(Offset = "0x40")]
	private Features m_features;

	[Token(Token = "0x6000C46")]
	[Address(RVA = "0xA41798", Offset = "0xA41798", VA = "0xA41798")]
	public BIPurchaseProfiler(Features features, Func<DateTime> currentTimeCallback, InventoryController inventory)
	{
	}

	[Token(Token = "0x6000C47")]
	[Address(RVA = "0xA417CC", Offset = "0xA417CC", VA = "0xA417CC", Slot = "10")]
	public override bool IsInitialized()
	{
		return default(bool);
	}
}
