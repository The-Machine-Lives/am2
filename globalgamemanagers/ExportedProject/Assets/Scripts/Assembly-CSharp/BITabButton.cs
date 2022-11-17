using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200014B")]
public class BITabButton : BIBaseButton
{
	[Token(Token = "0x4000836")]
	[FieldOffset(Offset = "0xF0")]
	public CanvasGroup m_UnFocusedTab;

	[Token(Token = "0x4000837")]
	[FieldOffset(Offset = "0xF8")]
	public CanvasGroup m_FocusedTab;

	[Token(Token = "0x6000942")]
	[Address(RVA = "0xA439CC", Offset = "0xA439CC", VA = "0xA439CC")]
	public void SetFocus(bool inFocus)
	{
	}

	[Token(Token = "0x6000943")]
	[Address(RVA = "0xA43AFC", Offset = "0xA43AFC", VA = "0xA43AFC")]
	public bool HasFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x6000944")]
	[Address(RVA = "0xA43B38", Offset = "0xA43B38", VA = "0xA43B38")]
	public BITabButton()
	{
	}
}
