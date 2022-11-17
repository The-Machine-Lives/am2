using System;
using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inventory;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004B4")]
	public class SpeedBoosterController : UkenController, IInventoryProgressTracker
	{
		[Token(Token = "0x2000825")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821348", Offset = "0x821348")]
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			[Token(Token = "0x4002362")]
			[FieldOffset(Offset = "0x10")]
			public SpeedBooster booster;

			[Token(Token = "0x6003314")]
			[Address(RVA = "0xA93918", Offset = "0xA93918", VA = "0xA93918")]
			public _003C_003Ec__DisplayClass13_0()
			{
			}
		}

		[Token(Token = "0x2000826")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821358", Offset = "0x821358")]
		private sealed class _003C_003Ec__DisplayClass13_1
		{
			[Token(Token = "0x4002363")]
			[FieldOffset(Offset = "0x10")]
			public bool checkAllBoosters;

			[Token(Token = "0x4002364")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003315")]
			[Address(RVA = "0xA939BC", Offset = "0xA939BC", VA = "0xA939BC")]
			public _003C_003Ec__DisplayClass13_1()
			{
			}

			[Token(Token = "0x6003316")]
			[Address(RVA = "0xA957E8", Offset = "0xA957E8", VA = "0xA957E8")]
			internal bool _003CGetMinTimeRemainingOnABoosterForRecipeAndBoosterType_003Eb__0(SpeedBoosterSlotItem slot)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000827")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821368", Offset = "0x821368")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002365")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4002366")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SpeedBoosterSlotItem, double?> _003C_003E9__13_1;

			[Token(Token = "0x4002367")]
			[FieldOffset(Offset = "0x10")]
			public static Func<SpeedBoosterSlotItem, long> _003C_003E9__14_1;

			[Token(Token = "0x4002368")]
			[FieldOffset(Offset = "0x18")]
			public static Func<GlobalSpeedBoosterItem, double> _003C_003E9__17_0;

			[Token(Token = "0x4002369")]
			[FieldOffset(Offset = "0x20")]
			public static Func<GlobalSpeedBoosterItem, double> _003C_003E9__19_0;

			[Token(Token = "0x400236A")]
			[FieldOffset(Offset = "0x28")]
			public static Func<List<SpeedBoosterSlotItem>, int> _003C_003E9__36_0;

			[Token(Token = "0x6003318")]
			[Address(RVA = "0xA95678", Offset = "0xA95678", VA = "0xA95678")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6003319")]
			[Address(RVA = "0xA95680", Offset = "0xA95680", VA = "0xA95680")]
			internal double? _003CGetMinTimeRemainingOnABoosterForRecipeAndBoosterType_003Eb__13_1(SpeedBoosterSlotItem slot)
			{
				return null;
			}

			[Token(Token = "0x600331A")]
			[Address(RVA = "0xA956FC", Offset = "0xA956FC", VA = "0xA956FC")]
			internal long _003CGetActiveCount_003Eb__14_1(SpeedBoosterSlotItem slot)
			{
				return default(long);
			}

			[Token(Token = "0x600331B")]
			[Address(RVA = "0xA9572C", Offset = "0xA9572C", VA = "0xA9572C")]
			internal double _003CGetGlobalSpeedBoosterPercent_003Eb__17_0(GlobalSpeedBoosterItem boostItem)
			{
				return default(double);
			}

			[Token(Token = "0x600331C")]
			[Address(RVA = "0xA9575C", Offset = "0xA9575C", VA = "0xA9575C")]
			internal double _003CGetRemainingGlobalSpeedBoosterDuration_003Eb__19_0(GlobalSpeedBoosterItem boostItem)
			{
				return default(double);
			}

			[Token(Token = "0x600331D")]
			[Address(RVA = "0xA9578C", Offset = "0xA9578C", VA = "0xA9578C")]
			internal int _003CGetActiveBoosterSlotCount_003Eb__36_0(List<SpeedBoosterSlotItem> slot)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000828")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821378", Offset = "0x821378")]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			[Token(Token = "0x400236B")]
			[FieldOffset(Offset = "0x10")]
			public SpeedBooster booster;

			[Token(Token = "0x600331E")]
			[Address(RVA = "0xA939C4", Offset = "0xA939C4", VA = "0xA939C4")]
			public _003C_003Ec__DisplayClass14_0()
			{
			}

			[Token(Token = "0x600331F")]
			[Address(RVA = "0xA95878", Offset = "0xA95878", VA = "0xA95878")]
			internal bool _003CGetActiveCount_003Eb__0(SpeedBoosterSlotItem slot)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40015F3")]
		[FieldOffset(Offset = "0x0")]
		public static int TEMP_MAX_SPEED_BOOSTERS;

		[Token(Token = "0x40015F4")]
		[FieldOffset(Offset = "0x4")]
		public static int TEMP_MAX_GLOBAL_SPEED_BOOSTERS;

		[Token(Token = "0x40015F5")]
		[FieldOffset(Offset = "0x18")]
		private List<GlobalSpeedBoosterItem> m_globalBoostItems;

		[Token(Token = "0x40015F6")]
		[FieldOffset(Offset = "0x20")]
		private List<GlobalSpeedBoosterItem> m_expiredGlobalBoostItem;

		[Token(Token = "0x40015F7")]
		[FieldOffset(Offset = "0x28")]
		private List<SpeedBoosterSlotItem> m_expiredBoosterSlots;

		[Token(Token = "0x40015F8")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, List<SpeedBoosterSlotItem>> m_activeBoosterSlotsByItemRef;

		[Token(Token = "0x40015F9")]
		[FieldOffset(Offset = "0x38")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x40015FA")]
		[FieldOffset(Offset = "0x40")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x40015FB")]
		[FieldOffset(Offset = "0x48")]
		private UkenTimeController m_timeController;

		[Token(Token = "0x40015FC")]
		[FieldOffset(Offset = "0x50")]
		private CasualAnalog m_analogController;

		[Token(Token = "0x6002351")]
		[Address(RVA = "0xA92BAC", Offset = "0xA92BAC", VA = "0xA92BAC")]
		public SpeedBoosterController(SharedDataCacheController dataCacheController, AM2InventoryController inventoryController, UkenTimeController timeController, CasualAnalog analogController)
		{
		}

		[Token(Token = "0x6002352")]
		[Address(RVA = "0xA92CB8", Offset = "0xA92CB8", VA = "0xA92CB8", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6002353")]
		[Address(RVA = "0xA932E8", Offset = "0xA932E8", VA = "0xA932E8")]
		public double GetMinTimeRemainingOnABoosterForRecipe(Recipe recipe)
		{
			return default(double);
		}

		[Token(Token = "0x6002354")]
		[Address(RVA = "0xA933E0", Offset = "0xA933E0", VA = "0xA933E0")]
		public double? GetMinTimeRemainingOnABoosterForRecipeAndBoosterType(Recipe recipe, SpeedBooster booster)
		{
			return null;
		}

		[Token(Token = "0x6002355")]
		[Address(RVA = "0xA93738", Offset = "0xA93738", VA = "0xA93738")]
		public long GetActiveCount(Recipe recipe, SpeedBooster booster)
		{
			return default(long);
		}

		[Token(Token = "0x6002356")]
		[Address(RVA = "0xA939CC", Offset = "0xA939CC", VA = "0xA939CC")]
		public double MultipliedDeltaTime(double deltaTime, double speedPercentAddition)
		{
			return default(double);
		}

		[Token(Token = "0x6002357")]
		[Address(RVA = "0xA939E4", Offset = "0xA939E4", VA = "0xA939E4")]
		public void AwardGlobalSpeedBoost(string adConfigRef, double durationInSeconds, double boostPercent, string eventName)
		{
		}

		[Token(Token = "0x6002358")]
		[Address(RVA = "0xA93CB4", Offset = "0xA93CB4", VA = "0xA93CB4")]
		public double GetGlobalSpeedBoosterPercent()
		{
			return default(double);
		}

		[Token(Token = "0x6002359")]
		[Address(RVA = "0xA93DC8", Offset = "0xA93DC8", VA = "0xA93DC8")]
		public double GetPrestigeGlobalSpeedBoostPercent()
		{
			return default(double);
		}

		[Token(Token = "0x600235A")]
		[Address(RVA = "0xA93608", Offset = "0xA93608", VA = "0xA93608")]
		public double GetRemainingGlobalSpeedBoosterDuration()
		{
			return default(double);
		}

		[Token(Token = "0x600235B")]
		[Address(RVA = "0xA93E10", Offset = "0xA93E10", VA = "0xA93E10")]
		public SpeedBooster GetSpeedBoosterFromSlot(SpeedBoosterSlotItem boosterSlot)
		{
			return null;
		}

		[Token(Token = "0x600235C")]
		[Address(RVA = "0xA93E64", Offset = "0xA93E64", VA = "0xA93E64")]
		public double GetSpeedUpPercentForRecipe(Recipe recipe)
		{
			return default(double);
		}

		[Token(Token = "0x600235D")]
		[Address(RVA = "0xA940A8", Offset = "0xA940A8", VA = "0xA940A8")]
		public double GetSpeedUpPercentForRecipeWithoutPrestigeBoost(Recipe recipe)
		{
			return default(double);
		}

		[Token(Token = "0x600235E")]
		[Address(RVA = "0xA93E70", Offset = "0xA93E70", VA = "0xA93E70")]
		public double GetSpeedUpPercentForRecipeAndBooster(Recipe recipe, SpeedBooster booster, bool includeGlobalSpeedBoost = true)
		{
			return default(double);
		}

		[Token(Token = "0x600235F")]
		[Address(RVA = "0xA93920", Offset = "0xA93920", VA = "0xA93920")]
		public List<SpeedBoosterSlotItem> TryGetActiveBoosterSlotsForRecipe(Recipe recipe)
		{
			return null;
		}

		[Token(Token = "0x6002360")]
		[Address(RVA = "0xA9414C", Offset = "0xA9414C", VA = "0xA9414C")]
		public IEnumerable<SpeedBooster> GetOwnedSpeedBoosts()
		{
			return null;
		}

		[Token(Token = "0x6002361")]
		[Address(RVA = "0xA94200", Offset = "0xA94200", VA = "0xA94200")]
		public bool CanAffordBooster(SpeedBooster booster, long boosterCount)
		{
			return default(bool);
		}

		[Token(Token = "0x6002362")]
		[Address(RVA = "0xA9428C", Offset = "0xA9428C", VA = "0xA9428C")]
		public void ApplyBoosterToRecipe(SpeedBooster booster, Recipe recipe, long boosterCount, out SpeedBoosterSlotItem boosterSlotItem, out Dictionary<string, long> visibleRewards)
		{
		}

		[Token(Token = "0x6002363")]
		[Address(RVA = "0xA946CC", Offset = "0xA946CC", VA = "0xA946CC")]
		private SpeedBoosterSlotItem RetrieveBoosterSlot(SpeedBooster booster, Recipe recipe)
		{
			return null;
		}

		[Token(Token = "0x6002364")]
		[Address(RVA = "0xA93110", Offset = "0xA93110", VA = "0xA93110")]
		public bool IsSlotMarkedAsExpired(SpeedBoosterSlotItem boosterSlotItem)
		{
			return default(bool);
		}

		[Token(Token = "0x6002365")]
		[Address(RVA = "0xA94DC8", Offset = "0xA94DC8", VA = "0xA94DC8", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6002366")]
		[Address(RVA = "0xA94EE8", Offset = "0xA94EE8", VA = "0xA94EE8")]
		public void UpdateBoosterSlots(float deltaTime)
		{
		}

		[Token(Token = "0x6002367")]
		[Address(RVA = "0xA94A20", Offset = "0xA94A20", VA = "0xA94A20")]
		private Dictionary<string, long> AwardBoosterUseRewards(SpeedBooster speedBooster, Recipe recipe)
		{
			return null;
		}

		[Token(Token = "0x6002368")]
		[Address(RVA = "0xA93058", Offset = "0xA93058", VA = "0xA93058")]
		private void RegisterSpeedBoosterSlotItem(int boosterSlotCount)
		{
		}

		[Token(Token = "0x6002369")]
		[Address(RVA = "0xA93178", Offset = "0xA93178", VA = "0xA93178")]
		private void AddSpeedBoosterSlotToActiveSlots(SpeedBoosterSlotItem boosterSlotItem)
		{
		}

		[Token(Token = "0x600236A")]
		[Address(RVA = "0xA94D54", Offset = "0xA94D54", VA = "0xA94D54")]
		private int GetSpeedBoostersSlotCount()
		{
			return default(int);
		}

		[Token(Token = "0x600236B")]
		[Address(RVA = "0xA95388", Offset = "0xA95388", VA = "0xA95388")]
		private int GetActiveBoosterSlotCount()
		{
			return default(int);
		}

		[Token(Token = "0x600236C")]
		[Address(RVA = "0xA95260", Offset = "0xA95260", VA = "0xA95260")]
		private bool UpdateBoosterSlotExpiration(SpeedBoosterSlotItem boosterSlotItem, float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x600236D")]
		[Address(RVA = "0xA954A4", Offset = "0xA954A4", VA = "0xA954A4")]
		private bool IsExpiredByTime(SpeedBoosterSlotItem boosterSlotItem)
		{
			return default(bool);
		}

		[Token(Token = "0x600236E")]
		[Address(RVA = "0xA954E0", Offset = "0xA954E0", VA = "0xA954E0", Slot = "10")]
		public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x6002370")]
		[Address(RVA = "0xA955B0", Offset = "0xA955B0", VA = "0xA955B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83965C", Offset = "0x83965C")]
		private bool _003CGetOwnedSpeedBoosts_003Eb__25_0(SpeedBooster booster)
		{
			return default(bool);
		}
	}
}
