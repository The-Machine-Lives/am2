using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000135")]
public class AM2ButtonImage : MonoBehaviour
{
	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0x18")]
	public Image m_image;

	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected bool usePalette;

	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	protected AM2PaletteDatabase.AM2ColorPalettes disabledColorPalette;

	[Token(Token = "0x40007CF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected AM2PaletteDatabase.AM2ColorPalettes enabledColorPalette;

	[Token(Token = "0x40007D0")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public Color m_disabledTextColor;

	[Token(Token = "0x40007D1")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public Color m_enabledTextColor;

	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x979AC0", Offset = "0x979AC0", VA = "0x979AC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x979AC4", Offset = "0x979AC4", VA = "0x979AC4")]
	public void ApplyPalette()
	{
	}

	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x9799D4", Offset = "0x9799D4", VA = "0x9799D4")]
	public void SetInteractable(bool interactable)
	{
	}

	[Token(Token = "0x60008D3")]
	[Address(RVA = "0x979B30", Offset = "0x979B30", VA = "0x979B30")]
	public AM2ButtonImage()
	{
	}
}
