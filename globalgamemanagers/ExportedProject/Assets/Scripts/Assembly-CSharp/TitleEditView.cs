using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x20000FD")]
public class TitleEditView : MonoBehaviour
{
	[Token(Token = "0x40005D8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform scaleTarget;

	[Token(Token = "0x40005D9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_openSize;

	[Token(Token = "0x40005DA")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float m_closedSize;

	[Token(Token = "0x40005DB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ProfilePageView m_profilePageView;

	[Token(Token = "0x40005DC")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TitleScrollableSelector m_leftTitleSelector;

	[Token(Token = "0x40005DD")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TitleScrollableSelector m_rightTitleSelector;

	[Token(Token = "0x40005DE")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TitleScrollableSelector m_middleTitleSelector;

	[Token(Token = "0x40005DF")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AutoScrollableView m_leftAutoScrollableView;

	[Token(Token = "0x40005E0")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AutoScrollableView m_rightAutoScrollableView;

	[Token(Token = "0x40005E1")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AutoScrollableView m_middleAutoScrollableView;

	[Token(Token = "0x40005E2")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject m_titleItemViewTemplate;

	[Token(Token = "0x40005E3")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject m_titleConnectorItemViewTemplate;

	[Token(Token = "0x40005E4")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AM2Button m_confirmButton;

	[Token(Token = "0x40005E5")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private AM2Button m_cancelButton;

	[Token(Token = "0x40005E6")]
	[FieldOffset(Offset = "0x80")]
	private ProfilePageController m_profilePageController;

	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0x88")]
	private bool m_initialized;

	[Token(Token = "0x40005E8")]
	[FieldOffset(Offset = "0x89")]
	private bool m_isOpen;

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0xA138CC", Offset = "0xA138CC", VA = "0xA138CC")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0xA139E0", Offset = "0xA139E0", VA = "0xA139E0")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0xA13AF4", Offset = "0xA13AF4", VA = "0xA13AF4")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0xA13E80", Offset = "0xA13E80", VA = "0xA13E80")]
	private void InstantiateTitleItemView(IReadable title, Transform parentTransform, AutoScrollableView autoScrollableView)
	{
	}

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0xA14050", Offset = "0xA14050", VA = "0xA14050")]
	public void ToggleViewOpen()
	{
	}

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0xA140F4", Offset = "0xA140F4", VA = "0xA140F4")]
	public void OpenView()
	{
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0xA14060", Offset = "0xA14060", VA = "0xA14060")]
	public void CloseView()
	{
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0xA141FC", Offset = "0xA141FC", VA = "0xA141FC")]
	public void OnClickConfirmTitle()
	{
	}

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0xA144DC", Offset = "0xA144DC", VA = "0xA144DC")]
	public void OnClickCancelTitle()
	{
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0xA14194", Offset = "0xA14194", VA = "0xA14194")]
	private void SetContainerSize(float size)
	{
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0xA144E0", Offset = "0xA144E0", VA = "0xA144E0")]
	public TitleEditView()
	{
	}
}
