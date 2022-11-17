using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AM2;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x200015E")]
public class IAPStoreItemView : MonoBehaviour, ISubTabItemView
{
	[Token(Token = "0x2000645")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8204F8", Offset = "0x8204F8")]
	private sealed class _003CLTOCountdownTimer_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001F36")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001F37")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001F38")]
		[FieldOffset(Offset = "0x20")]
		public IAPStoreItemView _003C_003E4__this;

		[Token(Token = "0x170007E5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D4E")]
			[Address(RVA = "0x987DB8", Offset = "0x987DB8", VA = "0x987DB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D50")]
			[Address(RVA = "0x987E28", Offset = "0x987E28", VA = "0x987E28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D4B")]
		[Address(RVA = "0x9877B0", Offset = "0x9877B0", VA = "0x9877B0")]
		[DebuggerHidden]
		public _003CLTOCountdownTimer_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D4C")]
		[Address(RVA = "0x987C20", Offset = "0x987C20", VA = "0x987C20", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D4D")]
		[Address(RVA = "0x987C24", Offset = "0x987C24", VA = "0x987C24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D4F")]
		[Address(RVA = "0x987DC0", Offset = "0x987DC0", VA = "0x987DC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400087C")]
	public const float c_priceRefreshDelay = 1f;

	[Token(Token = "0x400087D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Button m_storeItemButton;

	[Token(Token = "0x400087E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected AM2Text m_titleText;

	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AM2Text m_timerText;

	[Token(Token = "0x4000880")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected AM2Text m_rewardTitleText;

	[Token(Token = "0x4000881")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected AM2Text m_rewardText;

	[Token(Token = "0x4000882")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject m_redDotNotification;

	[Token(Token = "0x4000883")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private InfoSpecialOfferPopupButton m_specialOfferInfoButton;

	[Token(Token = "0x4000884")]
	[FieldOffset(Offset = "0x50")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000885")]
	[FieldOffset(Offset = "0x58")]
	private UIAlertController m_uiAlertController;

	[Token(Token = "0x4000886")]
	[FieldOffset(Offset = "0x60")]
	private CasualViewController m_parentController;

	[Token(Token = "0x4000887")]
	[FieldOffset(Offset = "0x68")]
	private StoreItem m_storeItem;

	[Token(Token = "0x4000888")]
	[FieldOffset(Offset = "0x70")]
	private bool m_isDoingPurchase;

	[Token(Token = "0x4000889")]
	[FieldOffset(Offset = "0x74")]
	private float m_refreshTime;

	[Token(Token = "0x400088A")]
	[FieldOffset(Offset = "0x78")]
	private Coroutine m_countDownCoroutine;

	[Token(Token = "0x6000995")]
	[Address(RVA = "0x986694", Offset = "0x986694", VA = "0x986694")]
	public void Initialize(CasualViewController parentController, StoreItem storeItem)
	{
	}

	[Token(Token = "0x6000996")]
	[Address(RVA = "0x9874C4", Offset = "0x9874C4", VA = "0x9874C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000997")]
	[Address(RVA = "0x987574", Offset = "0x987574", VA = "0x987574")]
	private void Start()
	{
	}

	[Token(Token = "0x6000998")]
	[Address(RVA = "0x987474", Offset = "0x987474", VA = "0x987474")]
	private void ConfigureCountdownTimer()
	{
	}

	[Token(Token = "0x6000999")]
	[Address(RVA = "0x9876A0", Offset = "0x9876A0", VA = "0x9876A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600099A")]
	[Address(RVA = "0x9876A4", Offset = "0x9876A4", VA = "0x9876A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600099B")]
	[Address(RVA = "0x9876B8", Offset = "0x9876B8", VA = "0x9876B8")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x600099C")]
	[Address(RVA = "0x98762C", Offset = "0x98762C", VA = "0x98762C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x83455C", Offset = "0x83455C")]
	private IEnumerator LTOCountdownTimer()
	{
		return null;
	}

	[Token(Token = "0x600099D")]
	[Address(RVA = "0x986F54", Offset = "0x986F54", VA = "0x986F54")]
	public string GetPossibleRewards(RewardGroup rewardGroup)
	{
		return null;
	}

	[Token(Token = "0x600099E")]
	[Address(RVA = "0x9877DC", Offset = "0x9877DC", VA = "0x9877DC", Slot = "4")]
	public bool RefreshRedDotNotification(HashSet<string> untouchedUnlockers, HashSet<string> untouchedItemRefs)
	{
		return default(bool);
	}

	[Token(Token = "0x600099F")]
	[Address(RVA = "0x987878", Offset = "0x987878", VA = "0x987878")]
	public void ShowRedDotNotification(bool show)
	{
	}

	[Token(Token = "0x60009A0")]
	[Address(RVA = "0x9878B0", Offset = "0x9878B0", VA = "0x9878B0", Slot = "7")]
	public void OnHidePage()
	{
	}

	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x9878B4", Offset = "0x9878B4", VA = "0x9878B4")]
	private void MarkViewed()
	{
	}

	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x98790C", Offset = "0x98790C", VA = "0x98790C", Slot = "8")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x987910", Offset = "0x987910", VA = "0x987910")]
	private void OnBuyItem()
	{
	}

	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x987AF8", Offset = "0x987AF8", VA = "0x987AF8")]
	private void OnComplete(bool b, Stores.PurchaseResult p)
	{
	}

	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x986C60", Offset = "0x986C60", VA = "0x986C60")]
	private void UdpatePrice(bool isOnlineAndTimeValid)
	{
	}

	[Token(Token = "0x60009A6")]
	[Address(RVA = "0x987B00", Offset = "0x987B00", VA = "0x987B00")]
	private void Update()
	{
	}

	[Token(Token = "0x60009A7")]
	[Address(RVA = "0x987C08", Offset = "0x987C08", VA = "0x987C08")]
	public IAPStoreItemView()
	{
	}

	[SpecialName]
	[Token(Token = "0x60009A8")]
	[Address(RVA = "0x987C10", Offset = "0x987C10", VA = "0x987C10", Slot = "5")]
	private GameObject ISubTabItemView_002Eget_gameObject()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x60009A9")]
	[Address(RVA = "0x987C18", Offset = "0x987C18", VA = "0x987C18", Slot = "6")]
	private Transform ISubTabItemView_002Eget_transform()
	{
		return null;
	}
}
