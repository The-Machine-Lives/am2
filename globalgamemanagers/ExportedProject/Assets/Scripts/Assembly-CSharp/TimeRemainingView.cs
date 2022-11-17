using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D8")]
public class TimeRemainingView : MonoBehaviour
{
	[Token(Token = "0x4000AC7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Text m_timeRemainingText;

	[Token(Token = "0x4000AC8")]
	[FieldOffset(Offset = "0x20")]
	private int m_timeRemainingInSeconds;

	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0xA137DC", Offset = "0xA137DC", VA = "0xA137DC")]
	public void UpdateTimeRemaining(int currentTimeRemaining)
	{
	}

	[Token(Token = "0x6000C90")]
	[Address(RVA = "0xA13844", Offset = "0xA13844", VA = "0xA13844")]
	public TimeRemainingView()
	{
	}
}
