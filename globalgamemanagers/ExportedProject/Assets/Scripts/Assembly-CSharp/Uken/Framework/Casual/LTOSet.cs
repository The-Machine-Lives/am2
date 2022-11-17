using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000524")]
	public class LTOSet
	{
		[Token(Token = "0x400182B")]
		[FieldOffset(Offset = "0x0")]
		private static string LTO_SET_ITEM_NAME;

		[Token(Token = "0x400182C")]
		[FieldOffset(Offset = "0x8")]
		private static string LTO_SET_INDEX_TAG;

		[Token(Token = "0x400182D")]
		[FieldOffset(Offset = "0x10")]
		private static string LTO_SET_ITERATION_TAG;

		[Token(Token = "0x400182E")]
		[FieldOffset(Offset = "0x10")]
		private RDLTOSet m_ltoSetData;

		[Token(Token = "0x400182F")]
		[FieldOffset(Offset = "0x18")]
		private List<UserSegment> m_userSegments;

		[Token(Token = "0x4001830")]
		[FieldOffset(Offset = "0x20")]
		private LTOSets m_ltoSetsCntrl;

		[Token(Token = "0x4001831")]
		[FieldOffset(Offset = "0x28")]
		private DynamicSaleItemController m_ltoCntrl;

		[Token(Token = "0x4001832")]
		[FieldOffset(Offset = "0x30")]
		private UserProfiler m_userProfiler;

		[Token(Token = "0x4001833")]
		[FieldOffset(Offset = "0x38")]
		private UkenTimeController m_timeCntrl;

		[Token(Token = "0x4001834")]
		[FieldOffset(Offset = "0x40")]
		private PurchaseProfiler m_purchaseProfiler;

		[Token(Token = "0x4001835")]
		[FieldOffset(Offset = "0x48")]
		private DynamicSaleItem m_currentLTO;

		[Token(Token = "0x170006CA")]
		public string reference
		{
			[Token(Token = "0x6002756")]
			[Address(RVA = "0xA6BF38", Offset = "0xA6BF38", VA = "0xA6BF38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006CB")]
		public List<int> surfacePoints
		{
			[Token(Token = "0x6002757")]
			[Address(RVA = "0xA6BF64", Offset = "0xA6BF64", VA = "0xA6BF64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006CC")]
		public string prefabPath
		{
			[Token(Token = "0x6002758")]
			[Address(RVA = "0xA6BF90", Offset = "0xA6BF90", VA = "0xA6BF90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006CD")]
		public string title
		{
			[Token(Token = "0x6002759")]
			[Address(RVA = "0xA6BFBC", Offset = "0xA6BFBC", VA = "0xA6BFBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006CE")]
		public string description
		{
			[Token(Token = "0x600275A")]
			[Address(RVA = "0xA6BFE8", Offset = "0xA6BFE8", VA = "0xA6BFE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006CF")]
		public string backgroundPath
		{
			[Token(Token = "0x600275B")]
			[Address(RVA = "0xA6C014", Offset = "0xA6C014", VA = "0xA6C014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D0")]
		public string assetBundle
		{
			[Token(Token = "0x600275C")]
			[Address(RVA = "0xA6C040", Offset = "0xA6C040", VA = "0xA6C040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D1")]
		public List<string> customImages
		{
			[Token(Token = "0x600275D")]
			[Address(RVA = "0xA6C06C", Offset = "0xA6C06C", VA = "0xA6C06C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D2")]
		public List<string> customTexts
		{
			[Token(Token = "0x600275E")]
			[Address(RVA = "0xA6C098", Offset = "0xA6C098", VA = "0xA6C098")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002755")]
		[Address(RVA = "0xA6BED0", Offset = "0xA6BED0", VA = "0xA6BED0")]
		public LTOSet(RDLTOSet ltoSetData, List<UserSegment> userSegments, LTOSets ltoSetsCntrl, DynamicSaleItemController dynamicSaleItemsCntrl, UserProfiler userProfiler, UkenTimeController timeCntrl, PurchaseProfiler purchaseProfiler)
		{
		}

		[Token(Token = "0x600275F")]
		[Address(RVA = "0xA6C0C4", Offset = "0xA6C0C4", VA = "0xA6C0C4")]
		public List<DynamicSaleItem> GetAllLTOsInSet()
		{
			return null;
		}

		[Token(Token = "0x6002760")]
		[Address(RVA = "0xA62FE0", Offset = "0xA62FE0", VA = "0xA62FE0")]
		public DynamicSaleItem GetCurrentLTO()
		{
			return null;
		}

		[Token(Token = "0x6002761")]
		[Address(RVA = "0xA61A18", Offset = "0xA61A18", VA = "0xA61A18")]
		public void OnLTOPurchased()
		{
		}

		[Token(Token = "0x6002762")]
		[Address(RVA = "0xA6C23C", Offset = "0xA6C23C", VA = "0xA6C23C")]
		public bool UserHasAssets()
		{
			return default(bool);
		}

		[Token(Token = "0x6002763")]
		[Address(RVA = "0xA617F0", Offset = "0xA617F0", VA = "0xA617F0")]
		public bool QualifiesForUser()
		{
			return default(bool);
		}

		[Token(Token = "0x6002764")]
		[Address(RVA = "0xA6C6DC", Offset = "0xA6C6DC", VA = "0xA6C6DC")]
		public bool IsLTODone(string ltoReference)
		{
			return default(bool);
		}

		[Token(Token = "0x6002765")]
		[Address(RVA = "0xA6CC28", Offset = "0xA6CC28", VA = "0xA6CC28")]
		public int GetCurrentIteration()
		{
			return default(int);
		}

		[Token(Token = "0x6002766")]
		[Address(RVA = "0xA6CD78", Offset = "0xA6CD78", VA = "0xA6CD78")]
		public bool IsSaleExpired()
		{
			return default(bool);
		}

		[Token(Token = "0x6002767")]
		[Address(RVA = "0xA6C988", Offset = "0xA6C988", VA = "0xA6C988")]
		private int GetRecordIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6002768")]
		[Address(RVA = "0xA6CB94", Offset = "0xA6CB94", VA = "0xA6CB94")]
		private string GetRecordKey(int recordIndex)
		{
			return null;
		}

		[Token(Token = "0x6002769")]
		[Address(RVA = "0xA6CF30", Offset = "0xA6CF30", VA = "0xA6CF30")]
		private string GetIterationKey(int recordIndex)
		{
			return null;
		}

		[Token(Token = "0x600276A")]
		[Address(RVA = "0xA6C244", Offset = "0xA6C244", VA = "0xA6C244")]
		private DynamicSaleItem RefreshCurrentLTO()
		{
			return null;
		}
	}
}
