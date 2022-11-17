using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000066")]
public class AltUnityInputsVisualiser : MonoBehaviour
{
	[Token(Token = "0x2000606")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820338", Offset = "0x820338")]
	private sealed class _003CVisualizerPulse_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001D4D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001D4E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001D4F")]
		[FieldOffset(Offset = "0x20")]
		public AltUnityInputsVisualiser _003C_003E4__this;

		[Token(Token = "0x4001D50")]
		[FieldOffset(Offset = "0x28")]
		public AltUnityInputMark mark;

		[Token(Token = "0x170007B0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002C6F")]
			[Address(RVA = "0xAE20FC", Offset = "0xAE20FC", VA = "0xAE20FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007B1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002C71")]
			[Address(RVA = "0xAE216C", Offset = "0xAE216C", VA = "0xAE216C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002C6C")]
		[Address(RVA = "0xAE1948", Offset = "0xAE1948", VA = "0xAE1948")]
		[DebuggerHidden]
		public _003CVisualizerPulse_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002C6D")]
		[Address(RVA = "0xAE1E40", Offset = "0xAE1E40", VA = "0xAE1E40", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002C6E")]
		[Address(RVA = "0xAE1E44", Offset = "0xAE1E44", VA = "0xAE1E44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002C70")]
		[Address(RVA = "0xAE2104", Offset = "0xAE2104", VA = "0xAE2104", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x18")]
	public float VisibleTime;

	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x821870", Offset = "0x821870")]
	[SerializeField]
	private AltUnityInputMark Template;

	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x28")]
	private readonly List<AltUnityInputMark> _pool;

	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x30")]
	private readonly Dictionary<int, AltUnityInputMark> _continuously;

	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x38")]
	private Transform _transform;

	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x40")]
	private float currentRatio;

	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x44")]
	private float initialRatio;

	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x48")]
	public float growthBound;

	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x4C")]
	public float approachSpeed;

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xAE1858", Offset = "0xAE1858", VA = "0xAE1858")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xAE18B0", Offset = "0xAE18B0", VA = "0xAE18B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x833708", Offset = "0x833708")]
	private IEnumerator VisualizerPulse(AltUnityInputMark mark)
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xAE1974", Offset = "0xAE1974", VA = "0xAE1974")]
	public void ShowClick(Vector2 pos)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xAE1B70", Offset = "0xAE1B70", VA = "0xAE1B70")]
	public int ShowContinuousInput(Vector2 pos, int id)
	{
		return default(int);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xAE19DC", Offset = "0xAE19DC", VA = "0xAE19DC")]
	private AltUnityInputMark GetMark()
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xAE1C88", Offset = "0xAE1C88", VA = "0xAE1C88")]
	private void PutMark(AltUnityInputMark mark)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xAE1D88", Offset = "0xAE1D88", VA = "0xAE1D88")]
	public AltUnityInputsVisualiser()
	{
	}
}
