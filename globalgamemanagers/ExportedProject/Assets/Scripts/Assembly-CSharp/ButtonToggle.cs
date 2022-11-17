using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200014D")]
public class ButtonToggle : MonoBehaviour
{
	[Token(Token = "0x4000839")]
	[FieldOffset(Offset = "0x18")]
	public BIColorPalletteDatabase.BIColorPallettes m_enabledColor;

	[Token(Token = "0x400083A")]
	[FieldOffset(Offset = "0x1C")]
	public BIColorPalletteDatabase.BIColorPallettes m_disabledColor;

	[Token(Token = "0x400083B")]
	[FieldOffset(Offset = "0x20")]
	public BIButton m_button;

	[Token(Token = "0x400083C")]
	[FieldOffset(Offset = "0x28")]
	private bool m_enabled;

	[Token(Token = "0x400083D")]
	[FieldOffset(Offset = "0x30")]
	private Action<bool> m_callback;

	[Token(Token = "0x6000949")]
	[Address(RVA = "0xA47A5C", Offset = "0xA47A5C", VA = "0xA47A5C")]
	public void SetCallback(Action<bool> toggleCallback)
	{
	}

	[Token(Token = "0x600094A")]
	[Address(RVA = "0xA47A64", Offset = "0xA47A64", VA = "0xA47A64")]
	public void SetEnabled(bool enabled)
	{
	}

	[Token(Token = "0x600094B")]
	[Address(RVA = "0xA47B9C", Offset = "0xA47B9C", VA = "0xA47B9C")]
	public void Toggle()
	{
	}

	[Token(Token = "0x600094C")]
	[Address(RVA = "0xA47AE8", Offset = "0xA47AE8", VA = "0xA47AE8")]
	private void Refresh()
	{
	}

	[Token(Token = "0x600094D")]
	[Address(RVA = "0xA47BAC", Offset = "0xA47BAC", VA = "0xA47BAC")]
	public ButtonToggle()
	{
	}
}
