using Il2CppDummyDll;
using Uken.Library.Animation;
using UnityEngine;

[Token(Token = "0x20000B2")]
public class PulsingAnimation : MonoBehaviour
{
	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform m_targetTransform;

	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_duration;

	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float m_scaleMax;

	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float m_scaleMin;

	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x30")]
	private UkenAnimChain m_chainAnim;

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x9E65DC", Offset = "0x9E65DC", VA = "0x9E65DC")]
	private void Start()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x9E67E8", Offset = "0x9E67E8", VA = "0x9E67E8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x9E67FC", Offset = "0x9E67FC", VA = "0x9E67FC")]
	private void OnUpdateSize(float size)
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x9E68E8", Offset = "0x9E68E8", VA = "0x9E68E8")]
	public PulsingAnimation()
	{
	}
}
