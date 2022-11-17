using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000E3")]
public class PowerRadial : MonoBehaviour
{
	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<PowerRadialAnimation> m_radialAnimations;

	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform m_runeAnimationParent;

	[Token(Token = "0x600061E")]
	[Address(RVA = "0x9DACD4", Offset = "0x9DACD4", VA = "0x9DACD4")]
	public void UpdateRadials(float deltaTime, bool isPressed, double currentPowerPerSecond, double maxPowerPerSecond)
	{
	}

	[Token(Token = "0x600061F")]
	[Address(RVA = "0x9DAF7C", Offset = "0x9DAF7C", VA = "0x9DAF7C")]
	public PowerRadial()
	{
	}
}
