using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x200008F")]
public class GameSummaryView : CasualView
{
	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private float m_delayPerReportIndex;

	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private GameObject m_rewardItemViewTemplate;

	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private GameObject m_substancesSummaryListView;

	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private BIScrollPanel m_reportScrollPanel;

	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private GameObject m_reportListView;

	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private AM2Button m_skipButton;

	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private float m_additionalShowDelayOnDeath;

	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private AM2Text m_gameSummaryText;

	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0x100")]
	private ZoneView m_zoneView;

	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0x108")]
	private ZoneController m_zoneController;

	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0x110")]
	private Localizations m_localizationController;

	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0x118")]
	private ZoneState m_zoneState;

	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0x120")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0x128")]
	private int m_previouslySkippedIndex;

	[Token(Token = "0x400023F")]
	[FieldOffset(Offset = "0x12C")]
	private int m_currentReportIndex;

	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x130")]
	private float m_startTime;

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x9D386C", Offset = "0x9D386C", VA = "0x9D386C")]
	public void Initialize(BICasualViewController parentController, ZoneView zoneView, Localizations localizationController, ZoneState zoneState, InventoryController inventoryController, ZoneController zoneController)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x9D39A0", Offset = "0x9D39A0", VA = "0x9D39A0", Slot = "12")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x9D3A98", Offset = "0x9D3A98", VA = "0x9D3A98", Slot = "13")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x9D3B90", Offset = "0x9D3B90", VA = "0x9D3B90")]
	public void AddDeathShowDelay()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x9D3BA4", Offset = "0x9D3BA4", VA = "0x9D3BA4")]
	public void OnSkipClicked()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x9D3BAC", Offset = "0x9D3BAC", VA = "0x9D3BAC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x9D3E24", Offset = "0x9D3E24", VA = "0x9D3E24")]
	public void OnCloseButtonPressed()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x9D3E74", Offset = "0x9D3E74", VA = "0x9D3E74")]
	private void BuildRewardList()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x9D3CC0", Offset = "0x9D3CC0", VA = "0x9D3CC0")]
	private void BuildReportListSoFar()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x9D40CC", Offset = "0x9D40CC", VA = "0x9D40CC")]
	private void InstantiateRewardItemView(RectTransform parent, string name, long amount)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x9D4280", Offset = "0x9D4280", VA = "0x9D4280")]
	private void InstantiateTextItemView(RectTransform parent, ZoneState.ReportInfo reportInfo)
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x9D423C", Offset = "0x9D423C", VA = "0x9D423C")]
	protected void ScrollToBottom()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x9D4394", Offset = "0x9D4394", VA = "0x9D4394")]
	public GameSummaryView()
	{
	}
}
