using System;
using Il2CppDummyDll;

[Token(Token = "0x200020A")]
public class CasualViewMutex
{
	[Token(Token = "0x200066B")]
	[Flags]
	public enum Label : byte
	{
		[Token(Token = "0x4001FAA")]
		None = 0,
		[Token(Token = "0x4001FAB")]
		QuestTabPopups = 1,
		[Token(Token = "0x4001FAC")]
		CoreTabPopups = 2,
		[Token(Token = "0x4001FAD")]
		ConfirmConvertPopup = 4,
		[Token(Token = "0x4001FAE")]
		PrestigePopups = 8,
		[Token(Token = "0x4001FAF")]
		OKPromptPopups = 0x10
	}

	[Token(Token = "0x4000B86")]
	[FieldOffset(Offset = "0x10")]
	private Label mutexes;

	[Token(Token = "0x6000DB4")]
	[Address(RVA = "0xA47E28", Offset = "0xA47E28", VA = "0xA47E28")]
	public bool TryAcquireMutex(Label label)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DB5")]
	[Address(RVA = "0xA47E4C", Offset = "0xA47E4C", VA = "0xA47E4C")]
	public void ReleaseMutex(Label label)
	{
	}

	[Token(Token = "0x6000DB6")]
	[Address(RVA = "0xA47E5C", Offset = "0xA47E5C", VA = "0xA47E5C")]
	public CasualViewMutex()
	{
	}
}
