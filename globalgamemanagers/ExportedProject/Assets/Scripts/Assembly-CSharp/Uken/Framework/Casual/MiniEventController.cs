using System.Collections.Generic;
using AM2;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inventory;
using Uken.Library.Observe;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004AD")]
	public class MiniEventController : UkenController, IInventoryProgressTracker
	{
		[Token(Token = "0x40015B7")]
		private const string c_miniEventActivationEvent = "mini_event_activation";

		[Token(Token = "0x40015B8")]
		[FieldOffset(Offset = "0x18")]
		private MiniEventItemPool miniEventItemPool;

		[Token(Token = "0x40015B9")]
		[FieldOffset(Offset = "0x20")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x40015BA")]
		[FieldOffset(Offset = "0x28")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x40015BB")]
		[FieldOffset(Offset = "0x30")]
		private CasualAnalog m_analogController;

		[Token(Token = "0x40015BC")]
		[FieldOffset(Offset = "0x38")]
		public UkenObservable<MiniEventItem> m_miniEventUpdateObservable;

		[Token(Token = "0x170005F6")]
		public List<MiniEventItem> ActiveMiniEvents
		{
			[Token(Token = "0x60022DB")]
			[Address(RVA = "0xA740B4", Offset = "0xA740B4", VA = "0xA740B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60022DC")]
		[Address(RVA = "0xA740E4", Offset = "0xA740E4", VA = "0xA740E4")]
		public MiniEventController(SharedDataCacheController dataCacheController, AM2InventoryController inventoryController, CasualAnalog analogController)
		{
		}

		[Token(Token = "0x60022DD")]
		[Address(RVA = "0xA74180", Offset = "0xA74180", VA = "0xA74180", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x60022DE")]
		[Address(RVA = "0xA74274", Offset = "0xA74274", VA = "0xA74274", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x60022DF")]
		[Address(RVA = "0xA7439C", Offset = "0xA7439C", VA = "0xA7439C")]
		public void UpdateMiniEventItems(float deltaTime)
		{
		}

		[Token(Token = "0x60022E0")]
		[Address(RVA = "0xA74510", Offset = "0xA74510", VA = "0xA74510")]
		private bool IsExpiredByTime(MiniEventItem item)
		{
			return default(bool);
		}

		[Token(Token = "0x60022E1")]
		[Address(RVA = "0xA7454C", Offset = "0xA7454C", VA = "0xA7454C")]
		private void ExpireMiniEvent(MiniEventItem item, int index)
		{
		}

		[Token(Token = "0x60022E2")]
		[Address(RVA = "0xA74204", Offset = "0xA74204", VA = "0xA74204")]
		private void MiniEventItemUpdated(MiniEventItem miniEventItem)
		{
		}

		[Token(Token = "0x60022E3")]
		[Address(RVA = "0xA744A0", Offset = "0xA744A0", VA = "0xA744A0")]
		private void IncrementExpirationTimer(MiniEventItem item, float deltaTime)
		{
		}

		[Token(Token = "0x60022E4")]
		[Address(RVA = "0xA74668", Offset = "0xA74668", VA = "0xA74668")]
		private void DecrementMiniEventItemCount(string reference)
		{
		}

		[Token(Token = "0x60022E5")]
		[Address(RVA = "0xA746F4", Offset = "0xA746F4", VA = "0xA746F4", Slot = "10")]
		public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x60022E6")]
		[Address(RVA = "0xA7476C", Offset = "0xA7476C", VA = "0xA7476C")]
		private void ActivateMiniEvent(string reference)
		{
		}

		[Token(Token = "0x60022E7")]
		[Address(RVA = "0xA74854", Offset = "0xA74854", VA = "0xA74854")]
		private void InitializeMiniEventItemFields(string reference, MiniEventItem miniEventItem)
		{
		}

		[Token(Token = "0x60022E8")]
		[Address(RVA = "0xA7492C", Offset = "0xA7492C", VA = "0xA7492C")]
		private void ActivateMiniEventEffects(string miniEventReference)
		{
		}

		[Token(Token = "0x60022E9")]
		[Address(RVA = "0xA74660", Offset = "0xA74660", VA = "0xA74660")]
		private void DeactivateMiniEventEffects(string miniEventReference)
		{
		}

		[Token(Token = "0x60022EA")]
		[Address(RVA = "0xA7493C", Offset = "0xA7493C", VA = "0xA7493C")]
		private void AdjustMiniEventUpgradables(string miniEventReference, long delta)
		{
		}

		[Token(Token = "0x60022EB")]
		[Address(RVA = "0xA74934", Offset = "0xA74934", VA = "0xA74934")]
		private void LogMiniEventActivation(MiniEventItem miniEventItem)
		{
		}

		[Token(Token = "0x60022EC")]
		[Address(RVA = "0xA746EC", Offset = "0xA746EC", VA = "0xA746EC")]
		private void LogMiniEventExpriation(MiniEventItem miniEventItem)
		{
		}

		[Token(Token = "0x60022ED")]
		[Address(RVA = "0xA74B24", Offset = "0xA74B24", VA = "0xA74B24")]
		private void LogMiniEvent(MiniEventItem miniEventItem, bool isActivation)
		{
		}
	}
}
