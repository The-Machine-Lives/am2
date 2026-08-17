using AM2.ReferenceData;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000D6")]
public class MiniEventItemView : MonoBehaviour
{
	[Token(Token = "0x40003D7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected AM2Text m_titleText;

	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected AM2Text m_description;

	[Token(Token = "0x40003D9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected AM2Text m_durationText;

	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected UntouchedAlertView m_untouchedAlertView;

	[Token(Token = "0x40003DB")]
	[FieldOffset(Offset = "0x38")]
	private MiniEventItem m_miniEventItem;

	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0x40")]
	private MiniEvent m_miniEvent;

	[Token(Token = "0x170000D3")]
	private string durationText
	{
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x99C3B4", Offset = "0x99C3B4", VA = "0x99C3B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D4")]
	public string MiniEventItemRef
	{
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x99C478", Offset = "0x99C478", VA = "0x99C478")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x99C4A8", Offset = "0x99C4A8", VA = "0x99C4A8", Slot = "4")]
	public virtual void Initialize(MiniEventItem miniEventItem)
	{
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x99C6A4", Offset = "0x99C6A4", VA = "0x99C6A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x99C3BC", Offset = "0x99C3BC", VA = "0x99C3BC")]
	private static string GenerateDurationText(MiniEventItem miniEventItem)
	{
		return null;
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x99C73C", Offset = "0x99C73C", VA = "0x99C73C")]
	public void MarkAsSeen()
	{
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x99C76C", Offset = "0x99C76C", VA = "0x99C76C")]
	public MiniEventItemView()
	{
	}
}
