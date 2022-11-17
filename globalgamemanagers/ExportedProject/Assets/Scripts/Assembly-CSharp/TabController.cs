using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x2000122")]
public class TabController : MonoBehaviour
{
	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Text m_titleText;

	[Token(Token = "0x400076D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_titleBackground;

	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected int startingTabIndex;

	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected List<TabButton> m_tabButtons;

	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool m_buttonsCanScroll;

	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private BIScrollPanel m_scrollView;

	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform m_scrollContent;

	[Token(Token = "0x4000773")]
	[FieldOffset(Offset = "0x50")]
	private AutoScroller m_autoScroller;

	[Token(Token = "0x4000774")]
	[FieldOffset(Offset = "0x58")]
	private bool m_initialized;

	[Token(Token = "0x4000775")]
	[FieldOffset(Offset = "0x60")]
	private Localizations m_localizationController;

	[Token(Token = "0x6000861")]
	[Address(RVA = "0xA120B8", Offset = "0xA120B8", VA = "0xA120B8", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000862")]
	[Address(RVA = "0xA122A0", Offset = "0xA122A0", VA = "0xA122A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000863")]
	[Address(RVA = "0xA12124", Offset = "0xA12124", VA = "0xA12124")]
	public void Initialize(List<TabButton> tabButtons)
	{
	}

	[Token(Token = "0x6000864")]
	[Address(RVA = "0xA10338", Offset = "0xA10338", VA = "0xA10338")]
	public void AddNewTabButton(TabButton tabButton)
	{
	}

	[Token(Token = "0x6000865")]
	[Address(RVA = "0xA0F8F8", Offset = "0xA0F8F8", VA = "0xA0F8F8")]
	public void SelectFirstVisibleTabButton()
	{
	}

	[Token(Token = "0x6000866")]
	[Address(RVA = "0xA117A4", Offset = "0xA117A4", VA = "0xA117A4")]
	public bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x6000867")]
	[Address(RVA = "0xA122A4", Offset = "0xA122A4", VA = "0xA122A4")]
	private void RefreshTitleVisibility()
	{
	}

	[Token(Token = "0x6000868")]
	[Address(RVA = "0xA12370", Offset = "0xA12370", VA = "0xA12370", Slot = "5")]
	public virtual void OnClickedButton(TabButton clickedButton)
	{
	}

	[Token(Token = "0x6000869")]
	[Address(RVA = "0xA11DF8", Offset = "0xA11DF8", VA = "0xA11DF8")]
	public void SetTitle(string text)
	{
	}

	[Token(Token = "0x600086A")]
	[Address(RVA = "0xA1253C", Offset = "0xA1253C", VA = "0xA1253C")]
	public TabController()
	{
	}
}
