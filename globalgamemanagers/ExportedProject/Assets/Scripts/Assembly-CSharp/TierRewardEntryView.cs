using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x20001B2")]
public class TierRewardEntryView : MonoBehaviour
{
	[Token(Token = "0x4000A49")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject m_tierRewardDescriptionViewTemplate;

	[Token(Token = "0x4000A4A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Text m_tierTitle;

	[Token(Token = "0x4000A4B")]
	[FieldOffset(Offset = "0x28")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x6000BD4")]
	[Address(RVA = "0x9FC858", Offset = "0x9FC858", VA = "0x9FC858")]
	public void Initialize(CasualViewController parentViewController, int tierNumber, List<Reward> rewards)
	{
	}

	[Token(Token = "0x6000BD5")]
	[Address(RVA = "0xA137D4", Offset = "0xA137D4", VA = "0xA137D4")]
	public TierRewardEntryView()
	{
	}
}
