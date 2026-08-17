using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D9")]
public class FPSCounterView : MonoBehaviour
{
	[Token(Token = "0x4000AC9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected AM2Text m_text;

	[Token(Token = "0x4000ACA")]
	[FieldOffset(Offset = "0x20")]
	protected float m_timeToUpdate;

	[Token(Token = "0x4000ACB")]
	[FieldOffset(Offset = "0x24")]
	protected float m_updateInterval;

	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x9C89C4", Offset = "0x9C89C4", VA = "0x9C89C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000C92")]
	[Address(RVA = "0x9C8ABC", Offset = "0x9C8ABC", VA = "0x9C8ABC")]
	public FPSCounterView()
	{
	}
}
