using System;
using AM2;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000537")]
	public class LTOs : DepotController
	{
		[Token(Token = "0x40018B2")]
		public const string SOURCE_KEY = "lto";

		[Token(Token = "0x40018B3")]
		[FieldOffset(Offset = "0x20")]
		private CasualGame m_game;

		[Token(Token = "0x40018B4")]
		[FieldOffset(Offset = "0x28")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x40018B5")]
		[FieldOffset(Offset = "0x30")]
		private DynamicOfferSets m_offerSets;

		[Token(Token = "0x40018B6")]
		[FieldOffset(Offset = "0x38")]
		private UkenTimeController m_time;

		[Token(Token = "0x40018B7")]
		[FieldOffset(Offset = "0x40")]
		private Features m_features;

		[Token(Token = "0x170006F4")]
		private DepotEntity<RDLTO> m_ltos
		{
			[Token(Token = "0x60027F9")]
			[Address(RVA = "0xA6E7A8", Offset = "0xA6E7A8", VA = "0xA6E7A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60027FA")]
		[Address(RVA = "0xA6E910", Offset = "0xA6E910", VA = "0xA6E910")]
		public LTOs(CasualGame game, DataStoreController controller)
		{
		}

		[Token(Token = "0x60027FB")]
		[Address(RVA = "0xA6E940", Offset = "0xA6E940", VA = "0xA6E940", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60027FC")]
		[Address(RVA = "0xA6EA8C", Offset = "0xA6EA8C", VA = "0xA6EA8C")]
		public void TriggerSalesAtSurfacePoint(int surfacePoint, Action<bool> onPurchaseComplete)
		{
		}
	}
}
