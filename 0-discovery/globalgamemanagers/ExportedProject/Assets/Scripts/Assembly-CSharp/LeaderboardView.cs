using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.Leaderboards;
using Uken.Framework.Casual.View;
using Uken.Library.Animation;
using UnityEngine;

[Token(Token = "0x2000196")]
public class LeaderboardView : CasualView
{
	[Token(Token = "0x2000649")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820528", Offset = "0x820528")]
	private sealed class _003CCloseMenuWhenTimerExpires_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001F43")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001F44")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001F45")]
		[FieldOffset(Offset = "0x20")]
		public LeaderboardView _003C_003E4__this;

		[Token(Token = "0x170007E9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D5D")]
			[Address(RVA = "0x995774", Offset = "0x995774", VA = "0x995774", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007EA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D5F")]
			[Address(RVA = "0x9957E4", Offset = "0x9957E4", VA = "0x9957E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D5A")]
		[Address(RVA = "0x994498", Offset = "0x994498", VA = "0x994498")]
		[DebuggerHidden]
		public _003CCloseMenuWhenTimerExpires_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D5B")]
		[Address(RVA = "0x995650", Offset = "0x995650", VA = "0x995650", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D5C")]
		[Address(RVA = "0x995654", Offset = "0x995654", VA = "0x995654", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D5E")]
		[Address(RVA = "0x99577C", Offset = "0x99577C", VA = "0x99577C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000984")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private GameObject m_loadingObjects;

	[Token(Token = "0x4000985")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private List<GameObject> m_leaderboardObjects;

	[Token(Token = "0x4000986")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private GameObject m_winnersPanel;

	[Token(Token = "0x4000987")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private GameObject m_rewardsPanel;

	[Token(Token = "0x4000988")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private AM2Button m_showRewardsButton;

	[Token(Token = "0x4000989")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private AM2Button m_showLeaderboardButton;

	[Token(Token = "0x400098A")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private AM2Button m_toggleModeButton;

	[Token(Token = "0x400098B")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private AM2Text m_descriptionText;

	[Token(Token = "0x400098C")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private AM2Text m_howToPlaceText;

	[Token(Token = "0x400098D")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private LeaderboardTierView m_currentTierView;

	[Token(Token = "0x400098E")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private LeaderboardTierView m_nextTierView;

	[Token(Token = "0x400098F")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private Transform m_entryViewsParent;

	[Token(Token = "0x4000990")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private GameObject m_entryViewTemplate;

	[Token(Token = "0x4000991")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private Transform m_tierViewsParent;

	[Token(Token = "0x4000992")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private GameObject m_tierViewTemplate;

	[Token(Token = "0x4000993")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private RectTransform m_resizingPanel;

	[Token(Token = "0x4000994")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	protected RectTransform m_winnersScrollRect;

	[Token(Token = "0x4000995")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	protected RectTransform m_scrollContent;

	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private AM2Text m_loadingText;

	[Token(Token = "0x4000997")]
	[FieldOffset(Offset = "0x158")]
	private UkenAnimFloat m_selfCenterAnim;

	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0x160")]
	private DateTime m_endDate;

	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x168")]
	private string m_localizedTitle;

	[Token(Token = "0x400099A")]
	[FieldOffset(Offset = "0x170")]
	private bool m_showingRewardsPanel;

	[Token(Token = "0x400099B")]
	[FieldOffset(Offset = "0x178")]
	private string m_titleCountdownColor;

	[Token(Token = "0x400099C")]
	[FieldOffset(Offset = "0x180")]
	private bool m_queriedForLeaderboards;

	[Token(Token = "0x400099D")]
	[FieldOffset(Offset = "0x181")]
	private bool waitingOnLeaderboardData;

	[Token(Token = "0x400099E")]
	[FieldOffset(Offset = "0x184")]
	private float m_timeUntilTitleUpdate;

	[Token(Token = "0x400099F")]
	[FieldOffset(Offset = "0x188")]
	private int m_scrollToSelfDelay;

	[Token(Token = "0x40009A0")]
	[FieldOffset(Offset = "0x190")]
	private string m_originalLoadingText;

	[Token(Token = "0x40009A1")]
	[FieldOffset(Offset = "0x198")]
	private GlobalLeaderboard m_leaderboard;

	[Token(Token = "0x40009A2")]
	[FieldOffset(Offset = "0x1A0")]
	private GlobalLeaderboardController m_globalLeaderboardController;

	[Token(Token = "0x40009A3")]
	[FieldOffset(Offset = "0x1A8")]
	private NetworkStatusCentre m_networkStatusCentre;

	[Token(Token = "0x40009A4")]
	[FieldOffset(Offset = "0x1B0")]
	private LeaderboardEntryView m_selfEntryView;

	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0x99391C", Offset = "0x99391C", VA = "0x99391C", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0x993A98", Offset = "0x993A98", VA = "0x993A98", Slot = "13")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000AF7")]
	[Address(RVA = "0x993C14", Offset = "0x993C14", VA = "0x993C14")]
	public void Initialize(CasualViewController viewController, string title, GlobalLeaderboard leaderboard)
	{
	}

	[Token(Token = "0x6000AF8")]
	[Address(RVA = "0x994424", Offset = "0x994424", VA = "0x994424")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x834704", Offset = "0x834704")]
	private IEnumerator CloseMenuWhenTimerExpires()
	{
		return null;
	}

	[Token(Token = "0x6000AF9")]
	[Address(RVA = "0x994260", Offset = "0x994260", VA = "0x994260")]
	private void SetLoading(bool isLoading)
	{
	}

	[Token(Token = "0x6000AFA")]
	[Address(RVA = "0x9944C4", Offset = "0x9944C4", VA = "0x9944C4", Slot = "7")]
	protected override void OnShow(Action onShowComplete)
	{
	}

	[Token(Token = "0x6000AFB")]
	[Address(RVA = "0x9945A0", Offset = "0x9945A0", VA = "0x9945A0", Slot = "8")]
	protected override void OnShowFinished(Action onShowComplete)
	{
	}

	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x994618", Offset = "0x994618", VA = "0x994618", Slot = "11")]
	protected override void OnHideFinished(Action onHideComplete)
	{
	}

	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x994500", Offset = "0x994500", VA = "0x994500")]
	private void RefreshLeaderboards()
	{
	}

	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x994680", Offset = "0x994680", VA = "0x994680")]
	private void OnLeaderboardQueryComplete(LeaderboardEntries result)
	{
	}

	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x994F98", Offset = "0x994F98", VA = "0x994F98")]
	private void CenterOnSelf(LeaderboardEntryView selfEntryView)
	{
	}

	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x995258", Offset = "0x995258", VA = "0x995258")]
	private void OnUpdateWinnersScroll(float newYLocation)
	{
	}

	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x994998", Offset = "0x994998", VA = "0x994998")]
	private void RefreshTierViews(Leaderboard leaderboard)
	{
	}

	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x994C48", Offset = "0x994C48", VA = "0x994C48")]
	private LeaderboardEntryView RefreshEntryViews(Leaderboard leaderboard)
	{
		return null;
	}

	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x994DF0", Offset = "0x994DF0", VA = "0x994DF0")]
	private void RefreshTierViewList(Leaderboard leaderboard)
	{
	}

	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x995324", Offset = "0x995324", VA = "0x995324")]
	private LeaderboardEntryView CreateLeaderboardEntryView(LeaderboardEntity entity, bool isSelf)
	{
		return null;
	}

	[Token(Token = "0x6000B05")]
	[Address(RVA = "0x995474", Offset = "0x995474", VA = "0x995474")]
	private void OnToggleRewardsPanel()
	{
	}

	[Token(Token = "0x6000B06")]
	[Address(RVA = "0x995540", Offset = "0x995540", VA = "0x995540")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000B07")]
	[Address(RVA = "0x993F88", Offset = "0x993F88", VA = "0x993F88")]
	private void UpdateTitleText()
	{
	}

	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x995638", Offset = "0x995638", VA = "0x995638")]
	public LeaderboardView()
	{
	}
}
