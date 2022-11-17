using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x2000125")]
public class VIPStatusPopUpView : CasualView
{
	[Token(Token = "0x2000635")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8204A8", Offset = "0x8204A8")]
	private sealed class _003CCountdownTimer_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E70")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E71")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E72")]
		[FieldOffset(Offset = "0x20")]
		public VIPStatusPopUpView _003C_003E4__this;

		[Token(Token = "0x170007E1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D37")]
			[Address(RVA = "0xAB814C", Offset = "0xAB814C", VA = "0xAB814C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D39")]
			[Address(RVA = "0xAB81BC", Offset = "0xAB81BC", VA = "0xAB81BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D34")]
		[Address(RVA = "0xAB7CB0", Offset = "0xAB7CB0", VA = "0xAB7CB0")]
		[DebuggerHidden]
		public _003CCountdownTimer_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D35")]
		[Address(RVA = "0xAB7CE4", Offset = "0xAB7CE4", VA = "0xAB7CE4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D36")]
		[Address(RVA = "0xAB7CE8", Offset = "0xAB7CE8", VA = "0xAB7CE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D38")]
		[Address(RVA = "0xAB8154", Offset = "0xAB8154", VA = "0xAB8154", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x824750", Offset = "0x824750")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x824750", Offset = "0x824750")]
	[SerializeField]
	private AM2Text m_countdownTimerText;

	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private AM2Button m_closeButton;

	[Token(Token = "0x400077E")]
	[FieldOffset(Offset = "0xD0")]
	private CasualViewController m_casualViewController;

	[Token(Token = "0x400077F")]
	[FieldOffset(Offset = "0xD8")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0xE0")]
	private DateTime m_timeRemaining;

	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0xE8")]
	private Color m_originalCountdownTextColor;

	[Token(Token = "0x6000877")]
	[Address(RVA = "0xAB7954", Offset = "0xAB7954", VA = "0xAB7954")]
	public void Initialize(CasualViewController viewController, DateTime timeRemaining)
	{
	}

	[Token(Token = "0x6000878")]
	[Address(RVA = "0xAB7AB4", Offset = "0xAB7AB4", VA = "0xAB7AB4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000879")]
	[Address(RVA = "0xAB7BEC", Offset = "0xAB7BEC", VA = "0xAB7BEC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600087A")]
	[Address(RVA = "0xAB7B78", Offset = "0xAB7B78", VA = "0xAB7B78")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x834364", Offset = "0x834364")]
	private IEnumerator CountdownTimer()
	{
		return null;
	}

	[Token(Token = "0x600087B")]
	[Address(RVA = "0xAB7CDC", Offset = "0xAB7CDC", VA = "0xAB7CDC")]
	public VIPStatusPopUpView()
	{
	}
}
