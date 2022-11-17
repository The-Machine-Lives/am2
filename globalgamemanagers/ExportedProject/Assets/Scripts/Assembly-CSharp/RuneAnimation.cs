using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000EA")]
public class RuneAnimation : MonoBehaviour
{
	[Token(Token = "0x4000549")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ERuneSpinAnimationType m_spinAnimationType;

	[Token(Token = "0x400054A")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool m_spinLeft;

	[Token(Token = "0x400054B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_maxSpinSpeed;

	[Token(Token = "0x400054C")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float m_minSpinSpeed;

	[Token(Token = "0x400054D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float m_maxSpinPowerPerSecond;

	[Token(Token = "0x400054E")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float m_minSpinPowerPerSecond;

	[Token(Token = "0x400054F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool alwaysFullOpacity;

	[Token(Token = "0x4000550")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float m_visibleThresholdPowerPerSecond;

	[Token(Token = "0x4000551")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float m_currentOpacity;

	[Token(Token = "0x4000552")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float m_opacityDecreaseRate;

	[Token(Token = "0x4000553")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float m_opacityIncreaseRate;

	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float m_scaleWhenVisible;

	[Token(Token = "0x4000555")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image m_rune;

	[Token(Token = "0x4000556")]
	[FieldOffset(Offset = "0x50")]
	private float m_currentRotationLinear;

	[Token(Token = "0x4000557")]
	[FieldOffset(Offset = "0x54")]
	private float m_nextDistance;

	[Token(Token = "0x4000558")]
	[FieldOffset(Offset = "0x58")]
	private float m_duration;

	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x5C")]
	private float m_startingRandomRotation;

	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x60")]
	private float m_time;

	[Token(Token = "0x170000DA")]
	public float scaleWhenVisible
	{
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x9FE008", Offset = "0x9FE008", VA = "0x9FE008")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0x9FE010", Offset = "0x9FE010", VA = "0x9FE010")]
	private void Start()
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x9FE190", Offset = "0x9FE190", VA = "0x9FE190")]
	public bool UpdateRune(float deltaTime, bool isPressed, float currentPowerPerSecond)
	{
		return default(bool);
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x9FE3D0", Offset = "0x9FE3D0", VA = "0x9FE3D0")]
	private void SpinAnimationLinear(float deltaTime, float spinSpeed, bool isPressed, float currentPowerPerSecond)
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0x9FE478", Offset = "0x9FE478", VA = "0x9FE478")]
	private void SpinAnimationEaseInOut(float deltaTime, float spinSpeed, bool isPressed, float currentPowerPerSecond)
	{
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0x9FE0B8", Offset = "0x9FE0B8", VA = "0x9FE0B8")]
	private void ChooseNextRandomRotation()
	{
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0x9FE5F8", Offset = "0x9FE5F8", VA = "0x9FE5F8")]
	private void SpinAnimationRandomAround(float deltaTime, float spinSpeed, bool isPressed, float currentPowerPerSecond)
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x9FE72C", Offset = "0x9FE72C", VA = "0x9FE72C")]
	public RuneAnimation()
	{
	}
}
