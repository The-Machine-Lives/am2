using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001D6")]
public class HighlightableItemView : BasicItemView
{
	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected Image m_backgroundImage;

	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected float highlightTime;

	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x4C")]
	protected Color m_flashColor;

	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x9862FC", Offset = "0x9862FC", VA = "0x9862FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000C84")]
	[Address(RVA = "0x98634C", Offset = "0x98634C", VA = "0x98634C")]
	public void SetForcedTextColor(Color color)
	{
	}

	[Token(Token = "0x6000C85")]
	[Address(RVA = "0x9863D4", Offset = "0x9863D4", VA = "0x9863D4")]
	public void EnableTextColorPalette()
	{
	}

	[Token(Token = "0x6000C86")]
	[Address(RVA = "0x986404", Offset = "0x986404", VA = "0x986404")]
	public void Highlight()
	{
	}

	[Token(Token = "0x6000C87")]
	[Address(RVA = "0x9864E4", Offset = "0x9864E4", VA = "0x9864E4")]
	public HighlightableItemView()
	{
	}
}
