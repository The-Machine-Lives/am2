using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000149")]
public class BIScrollPanel : ScrollRect
{
	[Token(Token = "0x200063E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8204E8", Offset = "0x8204E8")]
	private sealed class _003CScrollToBottom_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001EDE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001EDF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001EE0")]
		[FieldOffset(Offset = "0x20")]
		public BIScrollPanel _003C_003E4__this;

		[Token(Token = "0x170007E3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D45")]
			[Address(RVA = "0xA427DC", Offset = "0xA427DC", VA = "0xA427DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D47")]
			[Address(RVA = "0xA4284C", Offset = "0xA4284C", VA = "0xA4284C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D42")]
		[Address(RVA = "0xA423E8", Offset = "0xA423E8", VA = "0xA423E8")]
		[DebuggerHidden]
		public _003CScrollToBottom_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D43")]
		[Address(RVA = "0xA42688", Offset = "0xA42688", VA = "0xA42688", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D44")]
		[Address(RVA = "0xA4268C", Offset = "0xA4268C", VA = "0xA4268C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D46")]
		[Address(RVA = "0xA427E4", Offset = "0xA427E4", VA = "0xA427E4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0x128")]
	public BIScrollSnap scrollSnap;

	[Token(Token = "0x400081F")]
	[FieldOffset(Offset = "0x130")]
	private Vector2 targetPosition;

	[Token(Token = "0x4000820")]
	[FieldOffset(Offset = "0x138")]
	private bool isAutoScrolling;

	[Token(Token = "0x4000821")]
	[FieldOffset(Offset = "0x139")]
	private bool shouldReenableSnap;

	[Token(Token = "0x4000822")]
	[FieldOffset(Offset = "0x13C")]
	private float autoScrollTime;

	[Token(Token = "0x4000823")]
	[FieldOffset(Offset = "0x140")]
	private float autoScrollArriveTime;

	[Token(Token = "0x4000824")]
	[FieldOffset(Offset = "0x148")]
	private RectTransform m_rectTransform;

	[Token(Token = "0x600092B")]
	[Address(RVA = "0xA41E90", Offset = "0xA41E90", VA = "0xA41E90", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600092C")]
	[Address(RVA = "0xA41F0C", Offset = "0xA41F0C", VA = "0xA41F0C")]
	public void SetAutoScrollTarget(Vector2 position, bool isInstant = false)
	{
	}

	[Token(Token = "0x600092D")]
	[Address(RVA = "0xA42090", Offset = "0xA42090", VA = "0xA42090")]
	public void SetAutoScrollTarget(float x, float y, bool isInstant = false)
	{
	}

	[Token(Token = "0x600092E")]
	[Address(RVA = "0xA420D8", Offset = "0xA420D8", VA = "0xA420D8")]
	public void SetAutoScrollTarget(RectTransform target, bool isInstant = false)
	{
	}

	[Token(Token = "0x600092F")]
	[Address(RVA = "0xA42274", Offset = "0xA42274", VA = "0xA42274")]
	public void SetVerticalAutoScrollTarget(float verticalPosition, bool isInstant = false)
	{
	}

	[Token(Token = "0x6000930")]
	[Address(RVA = "0xA422F4", Offset = "0xA422F4", VA = "0xA422F4")]
	public void SetHorizontalAutoScrollTarget(float horizontalPosition, bool isInstant = false)
	{
	}

	[Token(Token = "0x6000931")]
	[Address(RVA = "0xA42374", Offset = "0xA42374", VA = "0xA42374")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8344B8", Offset = "0x8344B8")]
	public IEnumerator ScrollToBottom()
	{
		return null;
	}

	[Token(Token = "0x6000932")]
	[Address(RVA = "0xA42414", Offset = "0xA42414", VA = "0xA42414")]
	private void Update()
	{
	}

	[Token(Token = "0x6000933")]
	[Address(RVA = "0xA42674", Offset = "0xA42674", VA = "0xA42674")]
	public BIScrollPanel()
	{
	}
}
