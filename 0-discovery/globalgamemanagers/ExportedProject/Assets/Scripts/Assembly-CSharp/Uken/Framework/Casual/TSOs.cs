using System;
using System.Collections.Generic;
using AM2;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000545")]
	public class TSOs : DepotController
	{
		[Token(Token = "0x400190C")]
		public const int MAX_BUFFER_SIZE = 20;

		[Token(Token = "0x400190D")]
		public const string SOURCE_KEY = "tso";

		[Token(Token = "0x400190E")]
		[FieldOffset(Offset = "0x20")]
		private CasualGame m_game;

		[Token(Token = "0x400190F")]
		[FieldOffset(Offset = "0x28")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x4001910")]
		[FieldOffset(Offset = "0x30")]
		private DynamicOfferSets m_offerSets;

		[Token(Token = "0x4001911")]
		[FieldOffset(Offset = "0x38")]
		private UkenTimeController m_time;

		[Token(Token = "0x4001912")]
		[FieldOffset(Offset = "0x40")]
		private GameTriggers m_gameTriggers;

		[Token(Token = "0x4001913")]
		[FieldOffset(Offset = "0x48")]
		private Features m_features;

		[Token(Token = "0x4001914")]
		[FieldOffset(Offset = "0x50")]
		private GameSettings m_gameSettings;

		[Token(Token = "0x4001915")]
		[FieldOffset(Offset = "0x58")]
		private int m_cooldownSeconds;

		[Token(Token = "0x4001916")]
		[FieldOffset(Offset = "0x5C")]
		private float m_cooldownRemaining;

		[Token(Token = "0x4001917")]
		[FieldOffset(Offset = "0x60")]
		private Queue<string> m_triggerBuffer;

		[Token(Token = "0x1700070A")]
		private DepotEntity<RDTSO> m_TSOs
		{
			[Token(Token = "0x6002840")]
			[Address(RVA = "0xA99134", Offset = "0xA99134", VA = "0xA99134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002841")]
		[Address(RVA = "0xA9929C", Offset = "0xA9929C", VA = "0xA9929C")]
		public TSOs(CasualGame game, DataStoreController controller)
		{
		}

		[Token(Token = "0x6002842")]
		[Address(RVA = "0xA99330", Offset = "0xA99330", VA = "0xA99330", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6002843")]
		[Address(RVA = "0xA994B8", Offset = "0xA994B8", VA = "0xA994B8", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x6002844")]
		[Address(RVA = "0xA995BC", Offset = "0xA995BC", VA = "0xA995BC", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6002845")]
		[Address(RVA = "0xA99658", Offset = "0xA99658", VA = "0xA99658", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6002846")]
		[Address(RVA = "0xA9966C", Offset = "0xA9966C", VA = "0xA9966C")]
		public void OnTriggerActivated(List<string> triggers)
		{
		}

		[Token(Token = "0x6002847")]
		[Address(RVA = "0xA9980C", Offset = "0xA9980C", VA = "0xA9980C")]
		public void TriggerSalesAtSurfacePoint(int surfacePoint, Action<bool> onPurchaseComplete)
		{
		}
	}
}
