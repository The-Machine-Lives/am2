using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000E4")]
public class PowerRadialAnimation : MonoBehaviour
{
	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_visibleThresholdPowerPerSecond;

	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_minPowerPerSecond;

	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_maxPowerPerSecond;

	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float m_scaleWhenVisible;

	[Token(Token = "0x400050F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image m_radialImage;

	[Token(Token = "0x170000D8")]
	public float scaleWhenVisible
	{
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x9DAF74", Offset = "0x9DAF74", VA = "0x9DAF74")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000621")]
	[Address(RVA = "0x9DAF84", Offset = "0x9DAF84", VA = "0x9DAF84")]
	private void Start()
	{
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x9DAEC0", Offset = "0x9DAEC0", VA = "0x9DAEC0")]
	public bool UpdateRadial(float deltaTime, bool isPressed, double currentPowerPerSecond, double maxPowerPerSecond)
	{
		return default(bool);
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x9DAFB8", Offset = "0x9DAFB8", VA = "0x9DAFB8")]
	public PowerRadialAnimation()
	{
	}
}
