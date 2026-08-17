using System;
using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000120")]
public class SubTabView : ConstructionPageView
{
	[Serializable]
	[Token(Token = "0x2000633")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820498", Offset = "0x820498")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001E6E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001E6F")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Transform, int> _003C_003E9__36_1;

		[Token(Token = "0x6002D2E")]
		[Address(RVA = "0xA0EBFC", Offset = "0xA0EBFC", VA = "0xA0EBFC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002D2F")]
		[Address(RVA = "0xA0EC04", Offset = "0xA0EC04", VA = "0xA0EC04")]
		internal int _003CSortSubTabItemViews_003Eb__36_1(Transform child)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400074C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private VerticalLayoutGroup m_subTabListLayoutGroup;

	[Token(Token = "0x400074D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform m_childrenContainer;

	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0x48")]
	protected List<ISubTabItemView> m_itemViews;

	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AM2Text titleText;

	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AM2Text tagText;

	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected RectTransform m_scrollRect;

	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0x68")]
	protected WeakReference<ISubTabToggledHandler> m_callbackHandler;

	[Token(Token = "0x4000753")]
	[FieldOffset(Offset = "0x70")]
	private bool m_clearSubTabNotificationsOnHide;

	[Token(Token = "0x4000754")]
	[FieldOffset(Offset = "0x78")]
	private Tag m_tag;

	[Token(Token = "0x4000755")]
	[FieldOffset(Offset = "0x80")]
	private ZoneController m_zoneController;

	[Token(Token = "0x4000756")]
	[FieldOffset(Offset = "0x88")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x4000757")]
	[FieldOffset(Offset = "0x90")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000758")]
	[FieldOffset(Offset = "0x98")]
	private long m_previousTagQuantity;

	[Token(Token = "0x4000759")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_initialized;

	[Token(Token = "0x400075A")]
	[FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8245D0", Offset = "0x8245D0")]
	private List<SectionView> _003Cm_sectionViews_003Ek__BackingField;

	[Token(Token = "0x170000F9")]
	public Transform childContainer
	{
		[Token(Token = "0x600082E")]
		[Address(RVA = "0xA0D8C0", Offset = "0xA0D8C0", VA = "0xA0D8C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000FA")]
	public List<SectionView> m_sectionViews
	{
		[Token(Token = "0x600082F")]
		[Address(RVA = "0xA0D8C8", Offset = "0xA0D8C8", VA = "0xA0D8C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8342D4", Offset = "0x8342D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000830")]
		[Address(RVA = "0xA0D8D0", Offset = "0xA0D8D0", VA = "0xA0D8D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8342E4", Offset = "0x8342E4")]
		private set
		{
		}
	}

	[Token(Token = "0x6000831")]
	[Address(RVA = "0xA0D8D8", Offset = "0xA0D8D8", VA = "0xA0D8D8")]
	public void Initialize(TabButton inTabButton, string pageName, bool clearSubTabNotificationsOnHide, string tagKey, long spacing)
	{
	}

	[Token(Token = "0x6000832")]
	[Address(RVA = "0xA0DF40", Offset = "0xA0DF40", VA = "0xA0DF40")]
	public void SetTogglePageCallback(ISubTabToggledHandler handler)
	{
	}

	[Token(Token = "0x6000833")]
	[Address(RVA = "0xA0DFB8", Offset = "0xA0DFB8", VA = "0xA0DFB8")]
	public Vector3[] GetContentCorners()
	{
		return null;
	}

	[Token(Token = "0x6000834")]
	[Address(RVA = "0xA0E034", Offset = "0xA0E034", VA = "0xA0E034", Slot = "6")]
	public override void OnTogglePageOff()
	{
	}

	[Token(Token = "0x6000835")]
	[Address(RVA = "0xA0E080", Offset = "0xA0E080", VA = "0xA0E080")]
	public void HideItemViews()
	{
	}

	[Token(Token = "0x6000836")]
	[Address(RVA = "0xA0E25C", Offset = "0xA0E25C", VA = "0xA0E25C")]
	public void AddItemView(ISubTabItemView itemView)
	{
	}

	[Token(Token = "0x6000837")]
	[Address(RVA = "0xA0E2CC", Offset = "0xA0E2CC", VA = "0xA0E2CC")]
	public void ClearItemViews()
	{
	}

	[Token(Token = "0x6000838")]
	[Address(RVA = "0xA0E4D4", Offset = "0xA0E4D4", VA = "0xA0E4D4")]
	public void SetSubTabActive(bool active)
	{
	}

	[Token(Token = "0x6000839")]
	[Address(RVA = "0xA0E524", Offset = "0xA0E524", VA = "0xA0E524")]
	public bool IsSubTabSelected()
	{
		return default(bool);
	}

	[Token(Token = "0x600083A")]
	[Address(RVA = "0xA0E580", Offset = "0xA0E580", VA = "0xA0E580", Slot = "5")]
	public override void OnTogglePageOn()
	{
	}

	[Token(Token = "0x600083B")]
	[Address(RVA = "0xA0E5B8", Offset = "0xA0E5B8", VA = "0xA0E5B8")]
	private void CallToggleOnCallback()
	{
	}

	[Token(Token = "0x600083C")]
	[Address(RVA = "0xA0E67C", Offset = "0xA0E67C", VA = "0xA0E67C")]
	private ISubTabToggledHandler GetCallBackHandler()
	{
		return null;
	}

	[Token(Token = "0x600083D")]
	[Address(RVA = "0xA0DBD8", Offset = "0xA0DBD8", VA = "0xA0DBD8")]
	private void UpdateSubTabView()
	{
	}

	[Token(Token = "0x600083E")]
	[Address(RVA = "0xA0E700", Offset = "0xA0E700", VA = "0xA0E700")]
	public bool RefreshRedDotNotification(HashSet<string> untouchedUnlockers, HashSet<string> untouchedItemRefs)
	{
		return default(bool);
	}

	[Token(Token = "0x600083F")]
	[Address(RVA = "0xA0E864", Offset = "0xA0E864", VA = "0xA0E864")]
	private void Update()
	{
	}

	[Token(Token = "0x6000840")]
	[Address(RVA = "0xA0E8EC", Offset = "0xA0E8EC", VA = "0xA0E8EC")]
	public void ClearSections()
	{
	}

	[Token(Token = "0x6000841")]
	[Address(RVA = "0xA0DD2C", Offset = "0xA0DD2C", VA = "0xA0DD2C")]
	public void SortSubTabItemViews()
	{
	}

	[Token(Token = "0x6000842")]
	[Address(RVA = "0xA0EA74", Offset = "0xA0EA74", VA = "0xA0EA74")]
	public SubTabView()
	{
	}

	[Token(Token = "0x6000843")]
	[Address(RVA = "0xA0EB0C", Offset = "0xA0EB0C", VA = "0xA0EB0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8342F4", Offset = "0x8342F4")]
	private bool _003CSortSubTabItemViews_003Eb__36_0(Transform child)
	{
		return default(bool);
	}
}
