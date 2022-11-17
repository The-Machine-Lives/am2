using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Animation;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x2000118")]
public class StoryLogsView : MonoBehaviour
{
	[Token(Token = "0x200062F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820478", Offset = "0x820478")]
	private sealed class _003CSetActiveStateForAllNonVisibleStoryLogViews_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StoryLogsView _003C_003E4__this;

		[Token(Token = "0x4001E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool active;

		[Token(Token = "0x170007DF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D23")]
			[Address(RVA = "0xA0CD54", Offset = "0xA0CD54", VA = "0xA0CD54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D25")]
			[Address(RVA = "0xA0CDC4", Offset = "0xA0CDC4", VA = "0xA0CDC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D20")]
		[Address(RVA = "0xA0C6F8", Offset = "0xA0C6F8", VA = "0xA0C6F8")]
		[DebuggerHidden]
		public _003CSetActiveStateForAllNonVisibleStoryLogViews_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D21")]
		[Address(RVA = "0xA0CBF8", Offset = "0xA0CBF8", VA = "0xA0CBF8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D22")]
		[Address(RVA = "0xA0CBFC", Offset = "0xA0CBFC", VA = "0xA0CBFC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D24")]
		[Address(RVA = "0xA0CD5C", Offset = "0xA0CD5C", VA = "0xA0CD5C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400070A")]
	private const float c_numberOfOldLogsToShow = 2f;

	[Token(Token = "0x400070B")]
	private const float c_maxCanvasGroupAlpha = 1f;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GradientImage panelImage;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image panelBorderImage;

	[Token(Token = "0x400070E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_storyLogItemViewTemplate;

	[Token(Token = "0x400070F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform m_storyLogListParent;

	[Token(Token = "0x4000710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private BIScrollPanel m_storyLogsScrollPanel;

	[Token(Token = "0x4000711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private EventTrigger m_logEventTrigger;

	[Token(Token = "0x4000712")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private CanvasGroup m_logCanvasGroup;

	[Token(Token = "0x4000713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<HighlightableItemView> m_storyLogViews;

	[Token(Token = "0x4000714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<HighlightableItemView> m_storyLogItemViewsToHightlight;

	[Token(Token = "0x4000715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float m_storyLogFadeInDuration;

	[Token(Token = "0x4000716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float m_storyLogFadeOutDuration;

	[Token(Token = "0x4000717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float m_delayBeforeFadeLog;

	[Token(Token = "0x4000718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float m_storyLogFadedOutAlpha;

	[Token(Token = "0x4000719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int m_originalSiblingIndex;

	[Token(Token = "0x400071A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool m_allowOnFadeCallback;

	[Token(Token = "0x400071B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	private bool m_isFadingOut;

	[Token(Token = "0x400071C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private UkenAnimFloat m_fadeOutAnim;

	[Token(Token = "0x400071D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private UkenAnimFloat m_fadeInAnim;

	[Token(Token = "0x400071E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private StoryLogController m_storyLogController;

	[Token(Token = "0x170000F1")]
	private UkenAnim ukenAnim
	{
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xA0B894", Offset = "0xA0B894", VA = "0xA0B894")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007D5")]
	[Address(RVA = "0xA0B89C", Offset = "0xA0B89C", VA = "0xA0B89C")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60007D6")]
	[Address(RVA = "0xA0BBE0", Offset = "0xA0BBE0", VA = "0xA0BBE0")]
	protected void Start()
	{
	}

	[Token(Token = "0x60007D7")]
	[Address(RVA = "0xA0BC20", Offset = "0xA0BC20", VA = "0xA0BC20")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x60007D8")]
	[Address(RVA = "0xA0BC98", Offset = "0xA0BC98", VA = "0xA0BC98")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60007D9")]
	[Address(RVA = "0xA0BC9C", Offset = "0xA0BC9C", VA = "0xA0BC9C")]
	private void InstantFadOut()
	{
	}

	[Token(Token = "0x60007DA")]
	[Address(RVA = "0xA0BCF0", Offset = "0xA0BCF0", VA = "0xA0BCF0")]
	private void UpdateLogAlpha(float a)
	{
	}

	[Token(Token = "0x60007DB")]
	[Address(RVA = "0xA0BDFC", Offset = "0xA0BDFC", VA = "0xA0BDFC")]
	private void FadeOutLog()
	{
	}

	[Token(Token = "0x60007DC")]
	[Address(RVA = "0xA0BF70", Offset = "0xA0BF70", VA = "0xA0BF70")]
	private void OnStartFadeIn()
	{
	}

	[Token(Token = "0x60007DD")]
	[Address(RVA = "0xA0BF84", Offset = "0xA0BF84", VA = "0xA0BF84")]
	private void OnEndFadeOut()
	{
	}

	[Token(Token = "0x60007DE")]
	[Address(RVA = "0xA0BFB4", Offset = "0xA0BFB4", VA = "0xA0BFB4")]
	public void OnPressedDown([Optional] BaseEventData data)
	{
	}

	[Token(Token = "0x60007DF")]
	[Address(RVA = "0xA0BFB8", Offset = "0xA0BFB8", VA = "0xA0BFB8")]
	private void FadeInLog()
	{
	}

	[Token(Token = "0x60007E0")]
	[Address(RVA = "0xA0C208", Offset = "0xA0C208", VA = "0xA0C208")]
	public bool Maximized()
	{
		return default(bool);
	}

	[Token(Token = "0x60007E1")]
	[Address(RVA = "0xA0C16C", Offset = "0xA0C16C", VA = "0xA0C16C")]
	public void MaximizeView()
	{
	}

	[Token(Token = "0x60007E2")]
	[Address(RVA = "0xA0BB20", Offset = "0xA0BB20", VA = "0xA0BB20")]
	public void MinimizeView()
	{
	}

	[Token(Token = "0x60007E3")]
	[Address(RVA = "0xA0C258", Offset = "0xA0C258", VA = "0xA0C258")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8341F0", Offset = "0x8341F0")]
	private IEnumerator SetActiveStateForAllNonVisibleStoryLogViews(bool active)
	{
		return null;
	}

	[Token(Token = "0x60007E4")]
	[Address(RVA = "0xA0C2F4", Offset = "0xA0C2F4", VA = "0xA0C2F4")]
	private void SetPanelColor(float alpha)
	{
	}

	[Token(Token = "0x60007E5")]
	[Address(RVA = "0xA0C724", Offset = "0xA0C724", VA = "0xA0C724")]
	public void OnHighlightLog()
	{
	}

	[Token(Token = "0x60007E6")]
	[Address(RVA = "0xA0C774", Offset = "0xA0C774", VA = "0xA0C774")]
	public void OnSubTabToggledOn()
	{
	}

	[Token(Token = "0x60007E7")]
	[Address(RVA = "0xA0C684", Offset = "0xA0C684", VA = "0xA0C684")]
	public void TryScrollToBottom()
	{
	}

	[Token(Token = "0x60007E8")]
	[Address(RVA = "0xA0C898", Offset = "0xA0C898", VA = "0xA0C898")]
	public void OnEmit(StoryLogUIMessage storyLogUIMessage, bool isPowerSubTabActive)
	{
	}

	[Token(Token = "0x60007E9")]
	[Address(RVA = "0xA0CA1C", Offset = "0xA0CA1C", VA = "0xA0CA1C", Slot = "4")]
	protected virtual HighlightableItemView InstantiateStoryLogItemView(StoryLog storyLog, bool scrollToBottomAndRefresh = true)
	{
		return null;
	}

	[Token(Token = "0x60007EA")]
	[Address(RVA = "0xA0C440", Offset = "0xA0C440", VA = "0xA0C440")]
	protected void RefreshLogColors(bool isClosed = true)
	{
	}

	[Token(Token = "0x60007EB")]
	[Address(RVA = "0xA0BD9C", Offset = "0xA0BD9C", VA = "0xA0BD9C")]
	private void SkipAnim(ref UkenAnimFloat animationToSkip)
	{
	}

	[Token(Token = "0x60007EC")]
	[Address(RVA = "0xA0CB54", Offset = "0xA0CB54", VA = "0xA0CB54")]
	public StoryLogsView()
	{
	}
}
