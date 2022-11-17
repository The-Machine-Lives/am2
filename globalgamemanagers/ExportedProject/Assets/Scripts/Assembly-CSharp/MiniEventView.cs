using System.Collections.Generic;
using AM2;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Observe;
using UnityEngine;
using Utilities;

[Token(Token = "0x20000D7")]
public class MiniEventView : MonoBehaviour, IUkenObserver<MiniEventItem>
{
	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject m_miniEventItemViewTemplate;

	[Token(Token = "0x40003DE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_miniEventItemViewParent;

	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected AM2Text m_titleText;

	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x30")]
	private List<MiniEventItemView> m_miniEventItemViews;

	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x38")]
	private MiniEventController m_miniEventController;

	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0x40")]
	private ObjectPoolController m_objectPoolController;

	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x48")]
	private UIAlertController m_uiAlertController;

	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0x50")]
	private UkenUnsubscriber<MiniEventItem> _miniEventUpdateHandle;

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x99C774", Offset = "0x99C774", VA = "0x99C774", Slot = "5")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x99C990", Offset = "0x99C990", VA = "0x99C990")]
	private void SyncMiniEventList()
	{
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x99CA1C", Offset = "0x99CA1C", VA = "0x99CA1C")]
	private void SetNumberOfMiniEventViews(int count)
	{
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x99CD70", Offset = "0x99CD70", VA = "0x99CD70")]
	private void RemoveRangeOfViews(int index, int count)
	{
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x99CC50", Offset = "0x99CC50", VA = "0x99CC50")]
	private void InitializeMiniEventItemViews()
	{
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x99CED8", Offset = "0x99CED8", VA = "0x99CED8", Slot = "4")]
	public void OnEmit(MiniEventItem miniEventItem)
	{
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x99CF04", Offset = "0x99CF04", VA = "0x99CF04")]
	private void ActivateRedDotNotificationOnItemView(MiniEventItem miniEventItem)
	{
	}

	[Token(Token = "0x600057C")]
	[Address(RVA = "0x99CFA8", Offset = "0x99CFA8", VA = "0x99CFA8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x99CFAC", Offset = "0x99CFAC", VA = "0x99CFAC")]
	public void MarkMiniEventItemsAsTouched()
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0x99D09C", Offset = "0x99D09C", VA = "0x99D09C")]
	public MiniEventView()
	{
	}
}
