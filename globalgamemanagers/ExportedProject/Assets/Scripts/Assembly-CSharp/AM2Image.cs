using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000136")]
[Attribute(Name = "AddComponentMenu", RVA = "0x81E720", Offset = "0x81E720")]
public class AM2Image : Image
{
	[Token(Token = "0x40007D2")]
	[FieldOffset(Offset = "0xDE")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x824BBC", Offset = "0x824BBC")]
	[SerializeField]
	protected bool m_useColorPalette;

	[Token(Token = "0x40007D3")]
	[FieldOffset(Offset = "0xDF")]
	[SerializeField]
	protected bool m_useImagePalette;

	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0xE0")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x824C18", Offset = "0x824C18")]
	[SerializeField]
	protected AM2PaletteDatabase.AM2ColorPalettes m_colorPalette;

	[Token(Token = "0x40007D5")]
	[FieldOffset(Offset = "0xE4")]
	[SerializeField]
	protected AM2PaletteDatabase.AM2ImagePalettes m_imagePalette;

	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x981A48", Offset = "0x981A48", VA = "0x981A48", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x981A70", Offset = "0x981A70", VA = "0x981A70")]
	public void ApplyPalette()
	{
	}

	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x981B3C", Offset = "0x981B3C", VA = "0x981B3C")]
	public void ApplyNewPallet(AM2PaletteDatabase.AM2ColorPalettes newColorPalette, bool forced)
	{
	}

	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x981B58", Offset = "0x981B58", VA = "0x981B58")]
	public AM2Image()
	{
	}
}
