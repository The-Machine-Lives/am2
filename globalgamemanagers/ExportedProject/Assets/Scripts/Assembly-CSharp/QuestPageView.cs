using System;
using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using Uken.Library.UkenTime;
using UnityEngine;

[Token(Token = "0x20000DC")]
public class QuestPageView : ConstructionPageView, IUkenObserver<QuestUIMessage>
{
	[Serializable]
	[Token(Token = "0x2000627")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820438", Offset = "0x820438")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001E50")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001E51")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<Quest> _003C_003E9__17_0;

		[Token(Token = "0x6002D0A")]
		[Address(RVA = "0x9E9148", Offset = "0x9E9148", VA = "0x9E9148")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002D0B")]
		[Address(RVA = "0x9E9150", Offset = "0x9E9150", VA = "0x9E9150")]
		internal int _003CBuildQuestViewList_003Eb__17_0(Quest q1, Quest q2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_eventQuestViewTemplate;

	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject m_questViewTemplate;

	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject m_questViewParent;

	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject m_emptyText;

	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x58")]
	private List<QuestViewBase> m_questViews;

	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x60")]
	private UkenUnsubscriber<QuestUIMessage> m_signalHandle;

	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x68")]
	private Vector3[] m_scrollViewCorners;

	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x70")]
	private QuestController m_questController;

	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0x78")]
	private InventoryController m_inventory;

	[Token(Token = "0x4000459")]
	[FieldOffset(Offset = "0x80")]
	private Localizations m_localizationController;

	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0x88")]
	private UkenTimeController m_timeController;

	[Token(Token = "0x400045B")]
	[FieldOffset(Offset = "0x90")]
	private GlobalLeaderboardController m_leaderboardController;

	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	protected RectTransform m_scrollRect;

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x9E82B0", Offset = "0x9E82B0", VA = "0x9E82B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x9E8B50", Offset = "0x9E8B50", VA = "0x9E8B50", Slot = "5")]
	public override void OnTogglePageOn()
	{
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x9E8C40", Offset = "0x9E8C40", VA = "0x9E8C40", Slot = "6")]
	public override void OnTogglePageOff()
	{
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x9E8C88", Offset = "0x9E8C88", VA = "0x9E8C88")]
	private void ClearAllQuestViews()
	{
	}

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x9E8598", Offset = "0x9E8598", VA = "0x9E8598")]
	private void BuildQuestViewList()
	{
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x9E8E00", Offset = "0x9E8E00", VA = "0x9E8E00", Slot = "4")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x9E8E68", Offset = "0x9E8E68", VA = "0x9E8E68", Slot = "7")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CUken_002EFramework_002ECasual_002EQuestUIMessage_003E_002EOnEmit(QuestUIMessage questUIMessage)
	{
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x9E8F68", Offset = "0x9E8F68", VA = "0x9E8F68")]
	public float GetScrollViewBottom()
	{
		return default(float);
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x9E8FAC", Offset = "0x9E8FAC", VA = "0x9E8FAC")]
	public float GetScrollViewTop()
	{
		return default(float);
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x9E8DDC", Offset = "0x9E8DDC", VA = "0x9E8DDC")]
	private void SetupScrollViewCorners()
	{
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x9E8FF8", Offset = "0x9E8FF8", VA = "0x9E8FF8")]
	public Vector3[] GetContentCorners()
	{
		return null;
	}

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x9E9074", Offset = "0x9E9074", VA = "0x9E9074")]
	public QuestPageView()
	{
	}
}
