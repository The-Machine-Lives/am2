using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000065")]
public class AltUnityInputMark : MonoBehaviour
{
	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x18")]
	public CanvasGroup CanvasGroup;

	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve VisibilityCurve;

	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821860", Offset = "0x821860")]
	private int _003CId_003Ek__BackingField;

	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x30")]
	private Transform _transform;

	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x38")]
	private Action<AltUnityInputMark> _onFinished;

	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x40")]
	private float _time;

	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x44")]
	private float _currentTime;

	[Token(Token = "0x17000009")]
	public int Id
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0xAE1504", Offset = "0xAE1504", VA = "0xAE1504")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8336E8", Offset = "0x8336E8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000159")]
		[Address(RVA = "0xAE150C", Offset = "0xAE150C", VA = "0xAE150C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8336F8", Offset = "0x8336F8")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Transform Transform
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0xAE1514", Offset = "0xAE1514", VA = "0xAE1514")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xAE1574", Offset = "0xAE1574", VA = "0xAE1574")]
	private void Awake()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xAE1624", Offset = "0xAE1624", VA = "0xAE1624")]
	public void Init(float time, Action<AltUnityInputMark> onFinished)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xAE1630", Offset = "0xAE1630", VA = "0xAE1630")]
	public void Show(Vector2 pos)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xAE171C", Offset = "0xAE171C", VA = "0xAE171C")]
	private void Update()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xAE17C8", Offset = "0xAE17C8", VA = "0xAE17C8")]
	private void Finish()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xAE1850", Offset = "0xAE1850", VA = "0xAE1850")]
	public AltUnityInputMark()
	{
	}
}
