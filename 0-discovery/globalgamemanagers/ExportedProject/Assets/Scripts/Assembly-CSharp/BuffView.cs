using Il2CppDummyDll;
using Uken.Library.UkenTime;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200007C")]
public class BuffView : MonoBehaviour
{
	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected TimeRemainingView m_timeRemainingView;

	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected AM2Text m_stacksText;

	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected Image m_icon;

	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x30")]
	private IBuffState m_buffState;

	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0x38")]
	private UkenTimeController m_timeController;

	[Token(Token = "0x40001E5")]
	[FieldOffset(Offset = "0x40")]
	private int m_timeRemainingInSeconds;

	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x44")]
	private bool m_showBuffDuration;

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xA46818", Offset = "0xA46818", VA = "0xA46818")]
	public void Initialize(IBuffState buffState)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xA46DA0", Offset = "0xA46DA0", VA = "0xA46DA0")]
	public int GetTimeRemaining()
	{
		return default(int);
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xA46FE4", Offset = "0xA46FE4", VA = "0xA46FE4")]
	public bool UpdateBuff()
	{
		return default(bool);
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xA46F9C", Offset = "0xA46F9C", VA = "0xA46F9C")]
	private void UpdateBuffDurationText()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xA470A4", Offset = "0xA470A4", VA = "0xA470A4")]
	public BuffView()
	{
	}
}
