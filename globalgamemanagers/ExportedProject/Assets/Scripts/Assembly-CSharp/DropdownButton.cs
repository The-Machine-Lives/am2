using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D5")]
public class DropdownButton : AM2Button
{
	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private bool m_isOpen;

	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x14C")]
	public BISoundEvents.EventKey onOpenSoundEvent;

	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x150")]
	public BISoundEvents.EventKey onCloseSoundEvent;

	[Token(Token = "0x4000ABC")]
	[FieldOffset(Offset = "0x154")]
	public bool playOpenSound;

	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x155")]
	public bool playCloseSound;

	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private float rotationWhenOpen;

	[Token(Token = "0x4000ABF")]
	[FieldOffset(Offset = "0x15C")]
	[SerializeField]
	private float rotationWhenClosed;

	[Token(Token = "0x6000C7F")]
	[Address(RVA = "0x9C1ED0", Offset = "0x9C1ED0", VA = "0x9C1ED0")]
	public void OnToggle(bool open)
	{
	}

	[Token(Token = "0x6000C80")]
	[Address(RVA = "0x9C1EE0", Offset = "0x9C1EE0", VA = "0x9C1EE0")]
	public void RotateBasedOnToggle(bool open, bool animate = true)
	{
	}

	[Token(Token = "0x6000C81")]
	[Address(RVA = "0x9C20A0", Offset = "0x9C20A0", VA = "0x9C20A0", Slot = "45")]
	protected override void PlayButtonClickedSound()
	{
	}

	[Token(Token = "0x6000C82")]
	[Address(RVA = "0x9C2168", Offset = "0x9C2168", VA = "0x9C2168")]
	public DropdownButton()
	{
	}
}
