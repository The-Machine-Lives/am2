using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x2000072")]
public class ChoiceSceneView : ActionSceneView
{
	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private float choiceAnimateTime;

	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private AM2Text m_text;

	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private ProgressBar m_timerBar;

	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private GameObject m_choiceViewTemplate;

	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private GameObject m_choiceViewParent;

	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0xD8")]
	private List<ChoiceView> m_choiceViews;

	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0xE0")]
	private ActionController m_actionController;

	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0xE8")]
	private ChoiceSceneController m_sceneController;

	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0xF0")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0xF8")]
	private Localizations m_localizationController;

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xA49D9C", Offset = "0xA49D9C", VA = "0xA49D9C")]
	public void Initialize(ChoiceSceneController sceneController, ZoneView zoneView)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xA4A4DC", Offset = "0xA4A4DC", VA = "0xA4A4DC", Slot = "14")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xA4A610", Offset = "0xA4A610", VA = "0xA4A610")]
	public ChoiceSceneView()
	{
	}
}
