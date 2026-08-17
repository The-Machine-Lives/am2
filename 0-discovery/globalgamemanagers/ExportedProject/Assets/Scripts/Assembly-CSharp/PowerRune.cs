using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000E5")]
public class PowerRune : MonoBehaviour
{
	[Token(Token = "0x4000510")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<RuneAnimation> m_runeAnimations;

	[Token(Token = "0x4000511")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform m_runeAnimationParent;

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x9DCF6C", Offset = "0x9DCF6C", VA = "0x9DCF6C")]
	public void UpdateRunes(float deltaTime, bool isPressed, float currentPowerPerSecond)
	{
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x9DD17C", Offset = "0x9DD17C", VA = "0x9DD17C")]
	public PowerRune()
	{
	}
}
