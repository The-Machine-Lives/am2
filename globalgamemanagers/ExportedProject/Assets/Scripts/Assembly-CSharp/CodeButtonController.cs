using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

[Token(Token = "0x20000C1")]
public class CodeButtonController : DepotController
{
	[Token(Token = "0x400031D")]
	[FieldOffset(Offset = "0x20")]
	private int m_longestComboLength;

	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x28")]
	private List<CodeButtonCombo> m_allCodes;

	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x30")]
	private List<ECodeButtonIndex> m_currentCommandsQueue;

	[Token(Token = "0x4000320")]
	[FieldOffset(Offset = "0x38")]
	private AM2InventoryController m_inventoryController;

	[Token(Token = "0x4000321")]
	[FieldOffset(Offset = "0x40")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x48")]
	private UIAlertController m_uiAlertController;

	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0x50")]
	private SharedDataCacheController m_dataCacheController;

	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x58")]
	private AM2MessageController m_am2MessageController;

	[Token(Token = "0x4000325")]
	[FieldOffset(Offset = "0x60")]
	private Features m_features;

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0xA4B178", Offset = "0xA4B178", VA = "0xA4B178")]
	public CodeButtonController(CasualDataStoreController dataController, AM2InventoryController inventoryController, Localizations localizationController, UIAlertController uiAlertController, SharedDataCacheController dataCacheController, AM2MessageController am2MessageController, Features features)
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0xA4B240", Offset = "0xA4B240", VA = "0xA4B240", Slot = "9")]
	public override void OnDataUpdated()
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0xA4B518", Offset = "0xA4B518", VA = "0xA4B518")]
	public bool AreButtonsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0xA4B580", Offset = "0xA4B580", VA = "0xA4B580")]
	public void OnPressedCodeButton(ECodeButtonIndex buttonIndex)
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0xA4B5F0", Offset = "0xA4B5F0", VA = "0xA4B5F0")]
	private void AddButtonPressToCommandQueue(ECodeButtonIndex buttonIndex)
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0xA4B6C8", Offset = "0xA4B6C8", VA = "0xA4B6C8")]
	private bool CheckCurrentCommandsForValidCombo(ECodeButtonIndex inputtedButtonIndex, out CodeButtonCombo codeButtonCombo)
	{
		return default(bool);
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0xA4B950", Offset = "0xA4B950", VA = "0xA4B950")]
	private void AwardCombo(CodeButtonCombo codeButtonCombo)
	{
	}
}
