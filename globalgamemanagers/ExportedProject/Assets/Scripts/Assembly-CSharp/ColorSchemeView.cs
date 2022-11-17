using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x20000C3")]
public class ColorSchemeView : MonoBehaviour
{
	[Token(Token = "0x400032B")]
	[FieldOffset(Offset = "0x18")]
	private ConstructionViewController m_viewController;

	[Token(Token = "0x400032C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Button m_color1Button;

	[Token(Token = "0x400032D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AM2Button m_color2Button;

	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AM2Button m_color3Button;

	[Token(Token = "0x400032F")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, AM2Button> m_allColorButtons;

	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x40")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x48")]
	private int m_colorIndex;

	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x50")]
	private AM2InventoryController m_inventoryController;

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0xA4C0FC", Offset = "0xA4C0FC", VA = "0xA4C0FC")]
	public void Initailize(ConstructionViewController viewController)
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0xA4C60C", Offset = "0xA4C60C", VA = "0xA4C60C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0xA4C83C", Offset = "0xA4C83C", VA = "0xA4C83C")]
	private void OnColor1Changed()
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0xA4C97C", Offset = "0xA4C97C", VA = "0xA4C97C")]
	private void OnColor2Changed()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0xA4C984", Offset = "0xA4C984", VA = "0xA4C984")]
	private void OnColor3Changed()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0xA4C844", Offset = "0xA4C844", VA = "0xA4C844")]
	private void OnColorChanged(int colorIndex)
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0xA4C98C", Offset = "0xA4C98C", VA = "0xA4C98C")]
	private void ConfirmChangeColor()
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0xA4C444", Offset = "0xA4C444", VA = "0xA4C444")]
	private void RefreshColorButtons(int colorIndex)
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0xA4CA74", Offset = "0xA4CA74", VA = "0xA4CA74")]
	public ColorSchemeView()
	{
	}
}
