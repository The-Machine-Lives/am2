using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200008C")]
public class ZoneIntroView : MonoBehaviour
{
	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float delayInSeconds;

	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Text m_zoneText;

	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x28")]
	private ZoneView m_zoneView;

	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x30")]
	private bool m_initialized;

	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x34")]
	private float m_remainingTimeInSeconds;

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xAB986C", Offset = "0xAB986C", VA = "0xAB986C")]
	public void Initialize(ZoneState zoneState, ZoneView zoneView)
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xAB990C", Offset = "0xAB990C", VA = "0xAB990C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xABA13C", Offset = "0xABA13C", VA = "0xABA13C")]
	public ZoneIntroView()
	{
	}
}
