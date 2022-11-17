using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using AM2;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000522")]
	public class DynamicSaleItemController : DepotController
	{
		[Token(Token = "0x200084A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8214C8", Offset = "0x8214C8")]
		private sealed class _003CShowSalesAtSurfacePoint_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40023C5")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40023C6")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40023C7")]
			[FieldOffset(Offset = "0x20")]
			public DynamicSaleItemController _003C_003E4__this;

			[Token(Token = "0x40023C8")]
			[FieldOffset(Offset = "0x28")]
			public int surfacePoint;

			[Token(Token = "0x40023C9")]
			[FieldOffset(Offset = "0x30")]
			private List<DynamicSaleItem> _003CdynamicSaleItems_003E5__2;

			[Token(Token = "0x40023CA")]
			[FieldOffset(Offset = "0x38")]
			private int _003CtotalSalesShown_003E5__3;

			[Token(Token = "0x40023CB")]
			[FieldOffset(Offset = "0x40")]
			private HashSet<string> _003CsalesAlreadyConsidered_003E5__4;

			[Token(Token = "0x40023CC")]
			[FieldOffset(Offset = "0x48")]
			private int _003Ci_003E5__5;

			[Token(Token = "0x40023CD")]
			[FieldOffset(Offset = "0x50")]
			private ISaleView _003CsaleView_003E5__6;

			[Token(Token = "0x40023CE")]
			[FieldOffset(Offset = "0x58")]
			private DateTime _003CdownloadStart_003E5__7;

			[Token(Token = "0x17000835")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600336C")]
				[Address(RVA = "0xA63BD4", Offset = "0xA63BD4", VA = "0xA63BD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000836")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600336E")]
				[Address(RVA = "0xA63C44", Offset = "0xA63C44", VA = "0xA63C44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6003369")]
			[Address(RVA = "0xA63530", Offset = "0xA63530", VA = "0xA63530")]
			[DebuggerHidden]
			public _003CShowSalesAtSurfacePoint_003Ed__33(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600336A")]
			[Address(RVA = "0xA6361C", Offset = "0xA6361C", VA = "0xA6361C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600336B")]
			[Address(RVA = "0xA63620", Offset = "0xA63620", VA = "0xA63620", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600336D")]
			[Address(RVA = "0xA63BDC", Offset = "0xA63BDC", VA = "0xA63BDC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4001806")]
		public const float SURFACE_POINT_DELAY_IN_SECONDS = 2.75f;

		[Token(Token = "0x4001807")]
		public const float SALE_VIEW_DOWNLOAD_TIMEOUT_IN_SECONDS = 10f;

		[Token(Token = "0x4001808")]
		[FieldOffset(Offset = "0x20")]
		protected PurchaseProfiler m_purchaseProfiler;

		[Token(Token = "0x4001809")]
		[FieldOffset(Offset = "0x28")]
		protected SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x400180A")]
		[FieldOffset(Offset = "0x30")]
		protected SaleItemController m_saleItemsController;

		[Token(Token = "0x400180B")]
		[FieldOffset(Offset = "0x38")]
		protected UkenTimeController m_timeController;

		[Token(Token = "0x400180C")]
		[FieldOffset(Offset = "0x40")]
		protected Features m_features;

		[Token(Token = "0x400180D")]
		[FieldOffset(Offset = "0x48")]
		protected Func<bool> m_isOnlineCallback;

		[Token(Token = "0x400180E")]
		[FieldOffset(Offset = "0x50")]
		protected LTOSets m_ltoSetController;

		[Token(Token = "0x400180F")]
		[FieldOffset(Offset = "0x58")]
		protected int m_maxSaleHudIcons;

		[Token(Token = "0x4001810")]
		[FieldOffset(Offset = "0x5C")]
		protected int m_maxSalePopupsPerSurfacePoint;

		[Token(Token = "0x4001811")]
		[FieldOffset(Offset = "0x60")]
		protected int m_maxGlobalSalePopupsPerTimeInterval;

		[Token(Token = "0x4001812")]
		[FieldOffset(Offset = "0x68")]
		protected double m_globalSalePopupIntervalInSeconds;

		[Token(Token = "0x4001813")]
		[FieldOffset(Offset = "0x70")]
		private List<DynamicSaleItem> m_activeItems;

		[Token(Token = "0x4001814")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<int, List<string>> m_queuedDynamicSaleItemRefs;

		[Token(Token = "0x4001815")]
		[FieldOffset(Offset = "0x80")]
		private int m_globalDynamicSaleItemViewCount;

		[Token(Token = "0x4001816")]
		[FieldOffset(Offset = "0x88")]
		private double m_globalDynamicSaleItemViewIntervalStart;

		[Token(Token = "0x170006B8")]
		protected virtual DepotEntity<RDDynamicSaleItem> m_DynamicSaleItems
		{
			[Token(Token = "0x600271F")]
			[Address(RVA = "0xA62488", Offset = "0xA62488", VA = "0xA62488", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002720")]
		[Address(RVA = "0xA62490", Offset = "0xA62490", VA = "0xA62490")]
		public DynamicSaleItemController(CasualDataStoreController controller)
		{
		}

		[Token(Token = "0x6002721")]
		[Address(RVA = "0xA6255C", Offset = "0xA6255C", VA = "0xA6255C", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x6002722")]
		[Address(RVA = "0xA625D0", Offset = "0xA625D0", VA = "0xA625D0", Slot = "11")]
		public virtual void Initialize(PurchaseProfiler purchaseProfiler, SharedDataCacheController dataCacheController, LTOSets ltoSetController, UkenTimeController timeController, SaleItemController saleItems, Features features, Func<bool> isOnlineCallback)
		{
		}

		[Token(Token = "0x6002723")]
		[Address(RVA = "0xA625E4", Offset = "0xA625E4", VA = "0xA625E4", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6002724")]
		[Address(RVA = "0xA625EC", Offset = "0xA625EC", VA = "0xA625EC", Slot = "12")]
		protected virtual DynamicSaleItem ConstructDynamicSaleItem(RDDynamicSaleItem dynamicSaleItemData, EventSchedule schedule)
		{
			return null;
		}

		[Token(Token = "0x6002725")]
		[Address(RVA = "0xA625F4", Offset = "0xA625F4", VA = "0xA625F4")]
		public DynamicSaleItem Get(string reference)
		{
			return null;
		}

		[Token(Token = "0x6002726")]
		[Address(RVA = "0xA62B24", Offset = "0xA62B24", VA = "0xA62B24")]
		private List<DynamicSaleItem> GetSalesForSurfacePoint(int surfacePoint)
		{
			return null;
		}

		[Token(Token = "0x6002727")]
		[Address(RVA = "0xA62D48", Offset = "0xA62D48", VA = "0xA62D48")]
		private void UpdateSaleQueueForSurfacePoint(int surfacePoint)
		{
		}

		[Token(Token = "0x6002728")]
		[Address(RVA = "0xA63030", Offset = "0xA63030", VA = "0xA63030")]
		private bool CanShowSalePopupsGlobally()
		{
			return default(bool);
		}

		[Token(Token = "0x6002729")]
		[Address(RVA = "0xA63094", Offset = "0xA63094", VA = "0xA63094")]
		private void TrackGlobalSalePopups()
		{
		}

		[Token(Token = "0x600272A")]
		[Address(RVA = "0xA63118", Offset = "0xA63118", VA = "0xA63118")]
		public DynamicSaleItem GetActiveDynamicSale(string dynamicSaleRef)
		{
			return null;
		}

		[Token(Token = "0x600272B")]
		[Address(RVA = "0xA632A4", Offset = "0xA632A4", VA = "0xA632A4")]
		public List<DynamicSaleItem> GetActiveDynamicSales()
		{
			return null;
		}

		[Token(Token = "0x600272C")]
		[Address(RVA = "0xA632AC", Offset = "0xA632AC", VA = "0xA632AC")]
		public void RefreshActiveSales()
		{
		}

		[Token(Token = "0x600272D")]
		[Address(RVA = "0xA63490", Offset = "0xA63490", VA = "0xA63490", Slot = "13")]
		protected virtual bool MeetsViewRequirements()
		{
			return default(bool);
		}

		[Token(Token = "0x600272E")]
		[Address(RVA = "0xA63498", Offset = "0xA63498", VA = "0xA63498")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x83A1DC", Offset = "0x83A1DC")]
		public IEnumerator ShowSalesAtSurfacePoint(int surfacePoint)
		{
			return null;
		}

		[Token(Token = "0x600272F")]
		[Address(RVA = "0xA6355C", Offset = "0xA6355C", VA = "0xA6355C")]
		private bool CanShowSale(DynamicSaleItem dynamicSaleItem)
		{
			return default(bool);
		}
	}
}
