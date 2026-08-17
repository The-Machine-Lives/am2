using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000137")]
public class AM2ScrollBar : MonoBehaviour
{
	[Token(Token = "0x40007D6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Image m_scrollBarHandleAM2Image;

	[Token(Token = "0x40007D7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected AM2PaletteDatabase.AM2ColorPalettes m_colorPaletteOff;

	[Token(Token = "0x40007D8")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	protected AM2PaletteDatabase.AM2ColorPalettes m_colorPaletteOn;

	[Token(Token = "0x40007D9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Scrollbar m_scrollBar;

	[Token(Token = "0x40007DA")]
	[FieldOffset(Offset = "0x30")]
	private double m_scrollHandleColorTime;

	[Token(Token = "0x40007DB")]
	private const double c_eventScrollHandleFadeDelay = 0.2;

	[Token(Token = "0x60008D8")]
	[Address(RVA = "0xAC41C4", Offset = "0xAC41C4", VA = "0xAC41C4")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60008D9")]
	[Address(RVA = "0xAC4294", Offset = "0xAC4294", VA = "0xAC4294")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60008DA")]
	[Address(RVA = "0xAC4354", Offset = "0xAC4354", VA = "0xAC4354")]
	private void OnScroll(float scrollValue)
	{
	}

	[Token(Token = "0x60008DB")]
	[Address(RVA = "0xAC43BC", Offset = "0xAC43BC", VA = "0xAC43BC")]
	protected void Update()
	{
	}

	[Token(Token = "0x60008DC")]
	[Address(RVA = "0xAC4434", Offset = "0xAC4434", VA = "0xAC4434")]
	public AM2ScrollBar()
	{
	}
}
