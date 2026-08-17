using System;
using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x20001AC")]
public class QuestCompleteView : CasualView
{
	[Token(Token = "0x4000A04")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private GameObject m_rewardItemViewTemplate;

	[Token(Token = "0x4000A05")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private GameObject m_summaryListView;

	[Token(Token = "0x4000A06")]
	[FieldOffset(Offset = "0xD0")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000A07")]
	[FieldOffset(Offset = "0xD8")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x4000A08")]
	[FieldOffset(Offset = "0xE0")]
	private QuestController m_questController;

	[Token(Token = "0x6000BA5")]
	[Address(RVA = "0x9E7780", Offset = "0x9E7780", VA = "0x9E7780")]
	public void Initialize(CasualViewController parentController, Dictionary<string, long> rewards, Quest quest)
	{
	}

	[Token(Token = "0x6000BA6")]
	[Address(RVA = "0x9E7A18", Offset = "0x9E7A18", VA = "0x9E7A18")]
	private void BuildRewardList(Dictionary<string, long> rewards)
	{
	}

	[Token(Token = "0x6000BA7")]
	[Address(RVA = "0x9E7D64", Offset = "0x9E7D64", VA = "0x9E7D64")]
	private void InstantiateRewardItemView(RectTransform parent, string name, long amount, bool showAmount)
	{
	}

	[Token(Token = "0x6000BA8")]
	[Address(RVA = "0x9E7E44", Offset = "0x9E7E44", VA = "0x9E7E44", Slot = "7")]
	protected override void OnShow(Action onShowComplete)
	{
	}

	[Token(Token = "0x6000BA9")]
	[Address(RVA = "0x9E7EDC", Offset = "0x9E7EDC", VA = "0x9E7EDC")]
	public QuestCompleteView()
	{
	}
}
