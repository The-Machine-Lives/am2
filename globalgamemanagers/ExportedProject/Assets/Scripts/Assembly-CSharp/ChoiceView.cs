using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x2000073")]
public class ChoiceView : MonoBehaviour
{
	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Text m_choiceText;

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Button m_choiceButton;

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AM2Text m_choiceCostTitleText;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AM2Text m_choiceCostText;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x38")]
	private Item m_requiredItem;

	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x40")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x48")]
	private Localizations m_localizationController;

	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x50")]
	private ChoiceSceneController m_sceneController;

	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x58")]
	private ChoiceSceneView m_choiceSceneView;

	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x60")]
	private int m_choiceIndex;

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xA4A24C", Offset = "0xA4A24C", VA = "0xA4A24C")]
	public void Initialize(ChoiceSceneController sceneController, ChoiceSceneView choiceSceneView, int choiceIndex)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xA4AE50", Offset = "0xA4AE50", VA = "0xA4AE50")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xA4AF00", Offset = "0xA4AF00", VA = "0xA4AF00")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xA4A688", Offset = "0xA4A688", VA = "0xA4A688")]
	public void SetupChoice()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xA4AFB0", Offset = "0xA4AFB0", VA = "0xA4AFB0")]
	private void OnClickChoice()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xA4B154", Offset = "0xA4B154", VA = "0xA4B154")]
	private void PlayChoiceSelectedSound()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xA4B170", Offset = "0xA4B170", VA = "0xA4B170")]
	public ChoiceView()
	{
	}
}
