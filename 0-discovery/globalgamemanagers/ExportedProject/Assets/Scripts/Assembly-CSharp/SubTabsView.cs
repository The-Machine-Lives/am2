using System;
using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;
using UnityEngine.UI;
using Utilities;

[Token(Token = "0x200011D")]
public class SubTabsView : MonoBehaviour
{
	[Token(Token = "0x2000631")]
	public enum ESubTabsViewOrigin
	{
		[Token(Token = "0x4001E69")]
		Power = 0,
		[Token(Token = "0x4001E6A")]
		Research = 1,
		[Token(Token = "0x4001E6B")]
		Production = 2
	}

	[Serializable]
	[Token(Token = "0x2000632")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820488", Offset = "0x820488")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001E6C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001E6D")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<TabButton> _003C_003E9__30_0;

		[Token(Token = "0x6002D2B")]
		[Address(RVA = "0xA10A50", Offset = "0xA10A50", VA = "0xA10A50")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002D2C")]
		[Address(RVA = "0xA10A58", Offset = "0xA10A58", VA = "0xA10A58")]
		internal int _003CInitializeSubTabViewAndTabButton_003Eb__30_0(TabButton b1, TabButton b2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400073D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected int m_spacing;

	[Token(Token = "0x400073E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected CasualSceneController m_sceneController;

	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected GameObject m_tabButtonTemplate;

	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected Transform m_tabButtonParent;

	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected GameObject m_subTabTemplate;

	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected GameObject m_sectionTemplate;

	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool m_clearSubTabNotificationsOnHide;

	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private TabController m_tabController;

	[Token(Token = "0x4000745")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ToggleGroup m_toggleGroup;

	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0x60")]
	protected Dictionary<string, ItemModelViewInstantiator> m_instatiators;

	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x68")]
	protected Dictionary<string, SubTabView> m_constructionPageSubTabViews;

	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x70")]
	protected List<TabButton> m_tabButtons;

	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x78")]
	private int numSubTabs;

	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0x80")]
	private ObjectPoolController m_objectPoolController;

	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0x88")]
	private string m_origin;

	[Token(Token = "0x6000813")]
	[Address(RVA = "0x9FAB78", Offset = "0x9FAB78", VA = "0x9FAB78")]
	public void Initialize(ESubTabsViewOrigin origin)
	{
	}

	[Token(Token = "0x6000814")]
	[Address(RVA = "0xA0ECD4", Offset = "0xA0ECD4", VA = "0xA0ECD4")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000815")]
	[Address(RVA = "0x9FAE28", Offset = "0x9FAE28", VA = "0x9FAE28")]
	public void RegisterInstantiator(string itemType, ItemModelViewInstantiator instantiator)
	{
	}

	[Token(Token = "0x6000816")]
	[Address(RVA = "0xA0ED34", Offset = "0xA0ED34", VA = "0xA0ED34")]
	public Vector3[] GetContentCorners()
	{
		return null;
	}

	[Token(Token = "0x6000817")]
	[Address(RVA = "0x9FAF08", Offset = "0x9FAF08", VA = "0x9FAF08")]
	public void OnHideParentView()
	{
	}

	[Token(Token = "0x6000818")]
	[Address(RVA = "0xA0EF28", Offset = "0xA0EF28", VA = "0xA0EF28")]
	public void RebuildSubTab(SubTab subTabToRebuild)
	{
	}

	[Token(Token = "0x6000819")]
	[Address(RVA = "0x9FB0BC", Offset = "0x9FB0BC", VA = "0x9FB0BC")]
	public void BuildItemViews()
	{
	}

	[Token(Token = "0x600081A")]
	[Address(RVA = "0xA0F680", Offset = "0xA0F680", VA = "0xA0F680")]
	protected void ClearSubTab(string subTabName)
	{
	}

	[Token(Token = "0x600081B")]
	[Address(RVA = "0xA0F8B0", Offset = "0xA0F8B0", VA = "0xA0F8B0")]
	protected void ClearSubTab(SubTabView subTabView)
	{
	}

	[Token(Token = "0x600081C")]
	[Address(RVA = "0xA0F708", Offset = "0xA0F708", VA = "0xA0F708")]
	private ISubTabItemView InstantiateItemModelView(ItemModelViewInstantiator instantiator, ISubTabItemModel itemModel, SubTab subTab, Section section)
	{
		return null;
	}

	[Token(Token = "0x600081D")]
	[Address(RVA = "0xA0FC50", Offset = "0xA0FC50", VA = "0xA0FC50")]
	private SectionView FindOrCreateSectionView(SubTabView constructionPageSubTabView, ISubTabItemModel itemModel, SubTab subTab, Section section)
	{
		return null;
	}

	[Token(Token = "0x600081E")]
	[Address(RVA = "0xA0FE88", Offset = "0xA0FE88", VA = "0xA0FE88")]
	protected SubTabView CreateSubTab(string subTabName, string subTabShortName, int priority, string tagKey, string subTabReference, string eventName)
	{
		return null;
	}

	[Token(Token = "0x600081F")]
	[Address(RVA = "0xA10500", Offset = "0xA10500", VA = "0xA10500")]
	public void AddExistingSubTabViewAndTabButton(SubTab subTab, SubTabView subTabView, TabButton tabButton, string defaultSubTabName, string defaultSubTabShortName, string tagKey)
	{
	}

	[Token(Token = "0x6000820")]
	[Address(RVA = "0xA0FFFC", Offset = "0xA0FFFC", VA = "0xA0FFFC")]
	private void HandleVisibilityOnSubTabAdded()
	{
	}

	[Token(Token = "0x6000821")]
	[Address(RVA = "0xA10060", Offset = "0xA10060", VA = "0xA10060")]
	private void InitializeSubTabViewAndTabButton(SubTabView subTabView, TabButton tabButton, string subTabName, string subTabShortName, string tagKey, int priority, string subTabReference, string eventName)
	{
	}

	[Token(Token = "0x6000822")]
	[Address(RVA = "0xA107A4", Offset = "0xA107A4", VA = "0xA107A4")]
	public void ClearItems()
	{
	}

	[Token(Token = "0x6000823")]
	[Address(RVA = "0xA10648", Offset = "0xA10648", VA = "0xA10648")]
	private void GetSubTabDisplayDetails(SubTab subTab, string defaultSubTabName, string defaultSubTabShortName, out string subTabName, out string subTabShortName, out int subTabPriority)
	{
	}

	[Token(Token = "0x6000824")]
	[Address(RVA = "0xA0FA78", Offset = "0xA0FA78", VA = "0xA0FA78")]
	private SubTabView FindOrCreateSubTabView(SubTab subTab)
	{
		return null;
	}

	[Token(Token = "0x6000825")]
	[Address(RVA = "0xA108F4", Offset = "0xA108F4", VA = "0xA108F4")]
	private string TryGetTagKey(SubTab subTab)
	{
		return null;
	}

	[Token(Token = "0x6000826")]
	[Address(RVA = "0x9FBB38", Offset = "0x9FBB38", VA = "0x9FBB38")]
	public bool RefreshRedDotNotification(HashSet<string> untouchedUnlockers, HashSet<string> untouchedItemRefs)
	{
		return default(bool);
	}

	[Token(Token = "0x6000827")]
	[Address(RVA = "0xA1090C", Offset = "0xA1090C", VA = "0xA1090C")]
	public SubTabsView()
	{
	}
}
