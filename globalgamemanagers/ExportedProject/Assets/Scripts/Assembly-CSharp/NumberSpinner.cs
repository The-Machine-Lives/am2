using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000153")]
public class NumberSpinner : MonoBehaviour
{
	[Token(Token = "0x400085B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AM2Text m_text;

	[Token(Token = "0x400085C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public long m_value;

	[Token(Token = "0x400085D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float m_animDurationMax;

	[Token(Token = "0x400085E")]
	private const float m_animSpeed = 0.01f;

	[Token(Token = "0x400085F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private long m_displayedValue;

	[Token(Token = "0x4000860")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private long m_valueAtAnimStart;

	[Token(Token = "0x4000861")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float m_animRemainingTime;

	[Token(Token = "0x4000862")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float m_animDuration;

	[Token(Token = "0x4000863")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float m_animDelay;

	[Token(Token = "0x4000864")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Action m_onSpinStart;

	[Token(Token = "0x4000865")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Action m_onSpinStop;

	[Token(Token = "0x600096C")]
	[Address(RVA = "0x99DF3C", Offset = "0x99DF3C", VA = "0x99DF3C")]
	public void SpinToValue(long newValue, bool animate = true, float delay = 0f, [Optional] Action spinStart, [Optional] Action spinStop)
	{
	}

	[Token(Token = "0x600096D")]
	[Address(RVA = "0x99E0C0", Offset = "0x99E0C0", VA = "0x99E0C0")]
	private void OnSpinStart()
	{
	}

	[Token(Token = "0x600096E")]
	[Address(RVA = "0x99E0D4", Offset = "0x99E0D4", VA = "0x99E0D4")]
	private void OnSpinStop()
	{
	}

	[Token(Token = "0x600096F")]
	[Address(RVA = "0x99E104", Offset = "0x99E104", VA = "0x99E104")]
	private void Update()
	{
	}

	[Token(Token = "0x6000970")]
	[Address(RVA = "0x99E2AC", Offset = "0x99E2AC", VA = "0x99E2AC")]
	public NumberSpinner()
	{
	}
}
