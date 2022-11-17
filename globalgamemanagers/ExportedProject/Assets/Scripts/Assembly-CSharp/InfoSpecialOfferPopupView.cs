using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x2000166")]
public class InfoSpecialOfferPopupView : CasualView
{
	[Token(Token = "0x2000646")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820508", Offset = "0x820508")]
	private sealed class _003CLTOCountdownTimer_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001F39")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001F3A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001F3B")]
		[FieldOffset(Offset = "0x20")]
		public InfoSpecialOfferPopupView _003C_003E4__this;

		[Token(Token = "0x170007E7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D54")]
			[Address(RVA = "0x98DD64", Offset = "0x98DD64", VA = "0x98DD64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D56")]
			[Address(RVA = "0x98DDD4", Offset = "0x98DDD4", VA = "0x98DDD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D51")]
		[Address(RVA = "0x98DB60", Offset = "0x98DB60", VA = "0x98DB60")]
		[DebuggerHidden]
		public _003CLTOCountdownTimer_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D52")]
		[Address(RVA = "0x98DB94", Offset = "0x98DB94", VA = "0x98DB94", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D53")]
		[Address(RVA = "0x98DB98", Offset = "0x98DB98", VA = "0x98DB98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D55")]
		[Address(RVA = "0x98DD6C", Offset = "0x98DD6C", VA = "0x98DD6C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40008B8")]
	private const string c_countdownTimerTextColour = "#FA6400FF";

	[Token(Token = "0x40008B9")]
	[FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x825110", Offset = "0x825110")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x825110", Offset = "0x825110")]
	[SerializeField]
	private AM2Text m_titleText;

	[Token(Token = "0x40008BA")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private AM2Text m_bannerText;

	[Token(Token = "0x40008BB")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private InfoSpecialOfferEntryView m_specialOfferEntryViewTemplate;

	[Token(Token = "0x40008BC")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private Transform m_contentHolder;

	[Token(Token = "0x40008BD")]
	[FieldOffset(Offset = "0xE0")]
	private StoreItem m_storeItem;

	[Token(Token = "0x60009D7")]
	[Address(RVA = "0x98D518", Offset = "0x98D518", VA = "0x98D518")]
	public void Initialize(CasualViewController parentController, StoreItem storeItem)
	{
	}

	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x98DA60", Offset = "0x98DA60", VA = "0x98DA60")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x98DB34", Offset = "0x98DB34", VA = "0x98DB34")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60009DA")]
	[Address(RVA = "0x98DAC0", Offset = "0x98DAC0", VA = "0x98DAC0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x834620", Offset = "0x834620")]
	private IEnumerator LTOCountdownTimer()
	{
		return null;
	}

	[Token(Token = "0x60009DB")]
	[Address(RVA = "0x98D8B4", Offset = "0x98D8B4", VA = "0x98D8B4")]
	private void AddAllRewardEntries()
	{
	}

	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x98DB8C", Offset = "0x98DB8C", VA = "0x98DB8C")]
	public InfoSpecialOfferPopupView()
	{
	}
}
