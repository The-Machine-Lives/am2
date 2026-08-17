using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000099")]
public class DynamicAdsHueShift : MonoBehaviour, IColorAnimator
{
	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_dynamicAdHueShiftSpeed;

	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Button m_button;

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x9C3D1C", Offset = "0x9C3D1C", VA = "0x9C3D1C", Slot = "4")]
	public void AnimateColors()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x9C3ED0", Offset = "0x9C3ED0", VA = "0x9C3ED0")]
	public DynamicAdsHueShift()
	{
	}
}
