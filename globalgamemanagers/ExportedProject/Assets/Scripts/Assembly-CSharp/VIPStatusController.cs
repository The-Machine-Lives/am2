using System;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

[Token(Token = "0x2000160")]
public class VIPStatusController : DepotController
{
	[Token(Token = "0x400088C")]
	public const string c_vipStatusItemReference = "vip_status_days";

	[Token(Token = "0x400088D")]
	[FieldOffset(Offset = "0x20")]
	private AM2InventoryController m_inventoryController;

	[Token(Token = "0x400088E")]
	[FieldOffset(Offset = "0x28")]
	private VIPStatusItem m_vipStatusItem;

	[Token(Token = "0x400088F")]
	[FieldOffset(Offset = "0x30")]
	private bool m_readyForUse;

	[Token(Token = "0x60009AD")]
	[Address(RVA = "0xAB768C", Offset = "0xAB768C", VA = "0xAB768C")]
	public VIPStatusController(DataStoreController dataStoreController, AM2InventoryController inventoryController)
	{
	}

	[Token(Token = "0x60009AE")]
	[Address(RVA = "0xAB76B8", Offset = "0xAB76B8", VA = "0xAB76B8", Slot = "9")]
	public override void OnDataUpdated()
	{
	}

	[Token(Token = "0x60009AF")]
	[Address(RVA = "0xAB60E0", Offset = "0xAB60E0", VA = "0xAB60E0")]
	public DateTime VIPStatusExpireDate()
	{
		return default(DateTime);
	}

	[Token(Token = "0x60009B0")]
	[Address(RVA = "0xAB5F10", Offset = "0xAB5F10", VA = "0xAB5F10")]
	public bool VIPStatusActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60009B1")]
	[Address(RVA = "0xAB5F08", Offset = "0xAB5F08", VA = "0xAB5F08")]
	internal bool IsReadyForUse()
	{
		return default(bool);
	}
}
