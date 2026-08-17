using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200009B")]
public class DynamicAdTransitionColour : MonoBehaviour, IColorAnimator
{
	[Token(Token = "0x40002AE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x82225C", Offset = "0x82225C")]
	private float m_colourTransitionSpeed;

	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x8222A8", Offset = "0x8222A8")]
	private Color m_colourToTransitionTo;

	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AM2Button m_button;

	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0x38")]
	private ColorBlock m_activeTransitionColour;

	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0x80")]
	private ColorBlock m_originalButtonColourBlock;

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x9C39A0", Offset = "0x9C39A0", VA = "0x9C39A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x9C3A34", Offset = "0x9C3A34", VA = "0x9C3A34", Slot = "4")]
	public void AnimateColors()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x9C3CE0", Offset = "0x9C3CE0", VA = "0x9C3CE0")]
	public DynamicAdTransitionColour()
	{
	}
}
