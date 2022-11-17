using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x2000138")]
public class AM2Slider : Slider, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	[Token(Token = "0x40007DC")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private BIScrollPanel m_BIScrollPanel;

	[Token(Token = "0x40007DD")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private AM2Text m_textDisplay;

	[Token(Token = "0x40007DE")]
	[FieldOffset(Offset = "0x150")]
	private bool m_isCheckTarget;

	[Token(Token = "0x40007DF")]
	[FieldOffset(Offset = "0x151")]
	private bool m_isVertical;

	[Token(Token = "0x40007E0")]
	[FieldOffset(Offset = "0x154")]
	private Vector2 m_dragSoFar;

	[Token(Token = "0x40007E1")]
	[FieldOffset(Offset = "0x15C")]
	private float dragThreshold;

	[Token(Token = "0x60008DD")]
	[Address(RVA = "0xAC443C", Offset = "0xAC443C", VA = "0xAC443C", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60008DE")]
	[Address(RVA = "0xAC46F4", Offset = "0xAC46F4", VA = "0xAC46F4", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60008DF")]
	[Address(RVA = "0xAC45F4", Offset = "0xAC45F4", VA = "0xAC45F4")]
	private void UpdateTextToSlider(float sliderValue)
	{
	}

	[Token(Token = "0x60008E0")]
	[Address(RVA = "0xAC47B0", Offset = "0xAC47B0", VA = "0xAC47B0", Slot = "32")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60008E1")]
	[Address(RVA = "0xAC4828", Offset = "0xAC4828", VA = "0xAC4828", Slot = "33")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60008E2")]
	[Address(RVA = "0xAC4874", Offset = "0xAC4874", VA = "0xAC4874", Slot = "52")]
	public override void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60008E3")]
	[Address(RVA = "0xAC4AA8", Offset = "0xAC4AA8", VA = "0xAC4AA8", Slot = "54")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60008E4")]
	[Address(RVA = "0xAC4AAC", Offset = "0xAC4AAC", VA = "0xAC4AAC", Slot = "55")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60008E5")]
	[Address(RVA = "0xAC47B4", Offset = "0xAC47B4", VA = "0xAC47B4")]
	private void ResetTouch()
	{
	}

	[Token(Token = "0x60008E6")]
	[Address(RVA = "0xAC4B64", Offset = "0xAC4B64", VA = "0xAC4B64")]
	public AM2Slider()
	{
	}
}
