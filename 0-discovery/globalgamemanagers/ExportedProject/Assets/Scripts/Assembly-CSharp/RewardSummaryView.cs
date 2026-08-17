using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x20001B0")]
public class RewardSummaryView : CasualView
{
	[Token(Token = "0x200064E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820548", Offset = "0x820548")]
	private sealed class _003CCloseMenuOnEventQuestTimeExpired_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001F4E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001F4F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001F50")]
		[FieldOffset(Offset = "0x20")]
		public float secondsUntilEventQuestEnds;

		[Token(Token = "0x4001F51")]
		[FieldOffset(Offset = "0x28")]
		public RewardSummaryView _003C_003E4__this;

		[Token(Token = "0x170007EB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D67")]
			[Address(RVA = "0x9FCC90", Offset = "0x9FCC90", VA = "0x9FCC90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007EC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D69")]
			[Address(RVA = "0x9FCD00", Offset = "0x9FCD00", VA = "0x9FCD00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D64")]
		[Address(RVA = "0x9FCB1C", Offset = "0x9FCB1C", VA = "0x9FCB1C")]
		[DebuggerHidden]
		public _003CCloseMenuOnEventQuestTimeExpired_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D65")]
		[Address(RVA = "0x9FCBC8", Offset = "0x9FCBC8", VA = "0x9FCBC8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D66")]
		[Address(RVA = "0x9FCBCC", Offset = "0x9FCBCC", VA = "0x9FCBCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D68")]
		[Address(RVA = "0x9FCC98", Offset = "0x9FCC98", VA = "0x9FCC98", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000A3C")]
	[FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8258E8", Offset = "0x8258E8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8258E8", Offset = "0x8258E8")]
	[SerializeField]
	private GameObject m_tierRewardEntryViewTemplate;

	[Token(Token = "0x4000A3D")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private AM2Text m_eventTitleText;

	[Token(Token = "0x4000A3E")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private AM2Text m_currentTierText;

	[Token(Token = "0x4000A3F")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private RectTransform m_scrollContent;

	[Token(Token = "0x4000A40")]
	[FieldOffset(Offset = "0xE0")]
	private CasualViewController m_viewController;

	[Token(Token = "0x4000A41")]
	[FieldOffset(Offset = "0xE8")]
	private Quest m_quest;

	[Token(Token = "0x4000A42")]
	[FieldOffset(Offset = "0xF0")]
	private QuestItem m_questItem;

	[Token(Token = "0x4000A43")]
	[FieldOffset(Offset = "0xF8")]
	private List<TierRewardEntryView> m_tierRewardEntryViews;

	[Token(Token = "0x4000A44")]
	[FieldOffset(Offset = "0x100")]
	private string m_rewardSummary;

	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0x108")]
	private string m_currentTierOriginalText;

	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0x9FBFB0", Offset = "0x9FBFB0", VA = "0x9FBFB0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0x9FC024", Offset = "0x9FC024", VA = "0x9FC024")]
	public void Initialize(CasualViewController viewController, Quest quest, QuestItem questItem)
	{
	}

	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x9FC678", Offset = "0x9FC678", VA = "0x9FC678")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0x9FC7F0", Offset = "0x9FC7F0", VA = "0x9FC7F0", Slot = "11")]
	protected override void OnHideFinished(Action onHideComplete)
	{
	}

	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0x9FC0A4", Offset = "0x9FC0A4", VA = "0x9FC0A4")]
	private void SetTextForView()
	{
	}

	[Token(Token = "0x6000BCF")]
	[Address(RVA = "0x9FC434", Offset = "0x9FC434", VA = "0x9FC434")]
	private void CreateTierRewardEntriesForScrollView()
	{
	}

	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0x9FC758", Offset = "0x9FC758", VA = "0x9FC758")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8348F8", Offset = "0x8348F8")]
	private IEnumerator CloseMenuOnEventQuestTimeExpired(float secondsUntilEventQuestEnds)
	{
		return null;
	}

	[Token(Token = "0x6000BD1")]
	[Address(RVA = "0x9FCB48", Offset = "0x9FCB48", VA = "0x9FCB48")]
	public RewardSummaryView()
	{
	}
}
