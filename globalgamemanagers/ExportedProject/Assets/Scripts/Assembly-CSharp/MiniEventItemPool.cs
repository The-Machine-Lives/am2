using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20000D5")]
public class MiniEventItemPool
{
	[Serializable]
	[Token(Token = "0x200061E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8203C8", Offset = "0x8203C8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001E3D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001E3E")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MiniEventItem, bool> _003C_003E9__7_0;

		[Token(Token = "0x4001E3F")]
		[FieldOffset(Offset = "0x10")]
		public static Func<MiniEventItem, bool> _003C_003E9__7_1;

		[Token(Token = "0x6002CF1")]
		[Address(RVA = "0x99C374", Offset = "0x99C374", VA = "0x99C374")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002CF2")]
		[Address(RVA = "0x99C37C", Offset = "0x99C37C", VA = "0x99C37C")]
		internal bool _003CRegisterAndGroupMiniEventItems_003Eb__7_0(MiniEventItem item)
		{
			return default(bool);
		}

		[Token(Token = "0x6002CF3")]
		[Address(RVA = "0x99C388", Offset = "0x99C388", VA = "0x99C388")]
		internal bool _003CRegisterAndGroupMiniEventItems_003Eb__7_1(MiniEventItem item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40003D3")]
	private const int c_maxMiniEvent = 100;

	[Token(Token = "0x40003D4")]
	[FieldOffset(Offset = "0x10")]
	private List<MiniEventItem> m_activeMiniEventItems;

	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x18")]
	private List<MiniEventItem> m_inactiveMiniEventItems;

	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0x20")]
	private AM2InventoryController m_inventoryController;

	[Token(Token = "0x170000D1")]
	public List<MiniEventItem> ActiveMiniEvents
	{
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x99BB28", Offset = "0x99BB28", VA = "0x99BB28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D2")]
	private int miniEventItemPoolCount
	{
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x99C280", Offset = "0x99C280", VA = "0x99C280")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x99BB30", Offset = "0x99BB30", VA = "0x99BB30")]
	public MiniEventItemPool(AM2InventoryController inventoryController)
	{
	}

	[Token(Token = "0x6000569")]
	[Address(RVA = "0x99BC00", Offset = "0x99BC00", VA = "0x99BC00")]
	private void RegisterAndGroupMiniEventItems(int count)
	{
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0x99BF9C", Offset = "0x99BF9C", VA = "0x99BF9C")]
	private void RegisterMiniEventItem(int itemCount)
	{
	}

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x99C050", Offset = "0x99C050", VA = "0x99C050")]
	public void ExpireMiniEvent(int index)
	{
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x99C114", Offset = "0x99C114", VA = "0x99C114")]
	public bool TryCreateActiveMiniEvent(out MiniEventItem newMiniEvent)
	{
		return default(bool);
	}
}
