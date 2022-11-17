using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004B0")]
	public class RecipeController : UkenController, IInventoryProgressTracker, IUkenObserver<List<Unlocker>>
	{
		[Token(Token = "0x2000823")]
		public class OnPauseRecipeLogData : CasualAnalogData
		{
			[Token(Token = "0x6003307")]
			[Address(RVA = "0xA82734", Offset = "0xA82734", VA = "0xA82734")]
			public OnPauseRecipeLogData(Dictionary<string, long> recipeQuantities)
			{
			}
		}

		[Token(Token = "0x40015D2")]
		public const string c_recipeUINotificationKey = "recipe";

		[Token(Token = "0x40015D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<string> m_sessionRelevantRecipes;

		[Token(Token = "0x40015D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x40015D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UkenTimeController m_time;

		[Token(Token = "0x40015D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ConstructionController m_constructionController;

		[Token(Token = "0x40015D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FTUEController m_ftueController;

		[Token(Token = "0x40015D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UIAlertController m_uiAlertController;

		[Token(Token = "0x40015D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SpeedBoosterController m_speedBoosterController;

		[Token(Token = "0x40015DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ResearchController m_researchController;

		[Token(Token = "0x40015DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private EquipmentController m_equipmentController;

		[Token(Token = "0x40015DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CasualAnalog m_analogController;

		[Token(Token = "0x40015DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UkenUnsubscriber<List<Unlocker>> m_ftueSignalHandle;

		[Token(Token = "0x6002306")]
		[Address(RVA = "0xA81EDC", Offset = "0xA81EDC", VA = "0xA81EDC")]
		public RecipeController(AM2InventoryController inventoryController, UkenTimeController time, QuestController questController, ConstructionController constructionController, FTUEController ftueController, UIAlertController uiAlertController, SpeedBoosterController speedBoosterController, ResearchController researchController, EquipmentController equipmentController, CasualAnalog analogController)
		{
		}

		[Token(Token = "0x6002307")]
		[Address(RVA = "0xA8210C", Offset = "0xA8210C", VA = "0xA8210C", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6002308")]
		[Address(RVA = "0xA824CC", Offset = "0xA824CC", VA = "0xA824CC", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6002309")]
		[Address(RVA = "0xA82538", Offset = "0xA82538", VA = "0xA82538")]
		public void OnApplicationPause(bool bPause)
		{
		}

		[Token(Token = "0x600230A")]
		[Address(RVA = "0xA828F8", Offset = "0xA828F8", VA = "0xA828F8", Slot = "10")]
		public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x600230B")]
		[Address(RVA = "0xA82CA4", Offset = "0xA82CA4", VA = "0xA82CA4", Slot = "11")]
		private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CSystem_002ECollections_002EGeneric_002EList_003CAM2_002EReferenceData_002EUnlocker_003E_003E_002EOnEmit(List<Unlocker> unlockers)
		{
		}

		[Token(Token = "0x600230C")]
		[Address(RVA = "0xA8324C", Offset = "0xA8324C", VA = "0xA8324C")]
		public long GetBoostedMaxCap(Recipe recipe)
		{
			return default(long);
		}

		[Token(Token = "0x600230D")]
		[Address(RVA = "0xA83314", Offset = "0xA83314", VA = "0xA83314")]
		public long GetBoostedVolume(Recipe recipe)
		{
			return default(long);
		}

		[Token(Token = "0x600230E")]
		[Address(RVA = "0xA829F8", Offset = "0xA829F8", VA = "0xA829F8")]
		private void TryAddRecipesUpgradablesAsUntouchedResearch(Recipe recipe, [Optional] Unlocker unlocker)
		{
		}

		[Token(Token = "0x600230F")]
		[Address(RVA = "0xA83170", Offset = "0xA83170", VA = "0xA83170")]
		private void TryAddUpgradableAsUntouchedResearch(Upgradable upgradable, Unlocker unlocker, EUnlockType unlockType, string category)
		{
		}

		[Token(Token = "0x6002310")]
		[Address(RVA = "0xA8337C", Offset = "0xA8337C", VA = "0xA8337C", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6002311")]
		[Address(RVA = "0xA833CC", Offset = "0xA833CC", VA = "0xA833CC")]
		public void UpdateRecipes(float deltaTime)
		{
		}

		[Token(Token = "0x6002312")]
		[Address(RVA = "0xA76730", Offset = "0xA76730", VA = "0xA76730")]
		public bool UpdateRecipe(double deltaTime, Recipe recipe)
		{
			return default(bool);
		}

		[Token(Token = "0x6002313")]
		[Address(RVA = "0xA83510", Offset = "0xA83510", VA = "0xA83510")]
		private void StartNewJobIfInactive(RecipeItem recipeItem, Recipe recipe, ConstructionItem constructionItem)
		{
		}

		[Token(Token = "0x6002314")]
		[Address(RVA = "0xA835AC", Offset = "0xA835AC", VA = "0xA835AC")]
		private static void DecrementSustainTime(RecipeItem recipeItem, Recipe recipe, double deltaTime)
		{
		}

		[Token(Token = "0x6002315")]
		[Address(RVA = "0xA83890", Offset = "0xA83890", VA = "0xA83890")]
		private void GrantAwardedRecipe(long quantityToAward, ConstructionItem constructionItem)
		{
		}

		[Token(Token = "0x6002316")]
		[Address(RVA = "0xA839A4", Offset = "0xA839A4", VA = "0xA839A4")]
		private static void UpdateJobProgress(RecipeItem recipeItem, double newJobProgress)
		{
		}

		[Token(Token = "0x6002317")]
		[Address(RVA = "0xA83630", Offset = "0xA83630", VA = "0xA83630")]
		private ValueTuple<long, double> ApplyJobProgress(RecipeItem recipeItem, Recipe recipe, ConstructionItem constructionItem, double deltaTime)
		{
			return default(ValueTuple<long, double>);
		}

		[Token(Token = "0x6002318")]
		[Address(RVA = "0xA83AA0", Offset = "0xA83AA0", VA = "0xA83AA0")]
		public double GetProgressPerSecond(RecipeItem recipeItem, Recipe recipe)
		{
			return default(double);
		}

		[Token(Token = "0x6002319")]
		[Address(RVA = "0xA83E30", Offset = "0xA83E30", VA = "0xA83E30")]
		private static double GetSliderRateMultiplier(RecipeItem recipeItem, bool isAutomated)
		{
			return default(double);
		}

		[Token(Token = "0x600231A")]
		[Address(RVA = "0xA83E74", Offset = "0xA83E74", VA = "0xA83E74")]
		private double GetSpeedMultiplier(Recipe recipe)
		{
			return default(double);
		}

		[Token(Token = "0x600231B")]
		[Address(RVA = "0xA83F00", Offset = "0xA83F00", VA = "0xA83F00")]
		public static bool IsRecipeSustainUnlocked(Recipe recipe)
		{
			return default(bool);
		}

		[Token(Token = "0x600231C")]
		[Address(RVA = "0xA834B4", Offset = "0xA834B4", VA = "0xA834B4")]
		public static bool IsRecipeAutomated(RecipeItem recipeItem, Recipe recipe)
		{
			return default(bool);
		}

		[Token(Token = "0x600231D")]
		[Address(RVA = "0xA83F5C", Offset = "0xA83F5C", VA = "0xA83F5C")]
		public void SetSliderRate(RecipeItem recipeItem, double sliderRate)
		{
		}

		[Token(Token = "0x600231E")]
		[Address(RVA = "0xA83F9C", Offset = "0xA83F9C", VA = "0xA83F9C")]
		public void OnPressedGenerateButton(ConstructionItem constructionItem, RecipeItem recipeItem, Recipe recipe)
		{
		}

		[Token(Token = "0x600231F")]
		[Address(RVA = "0xA839E0", Offset = "0xA839E0", VA = "0xA839E0")]
		public bool TryToStartJob(ConstructionItem constructionItem, RecipeItem recipeItem, Recipe recipe)
		{
			return default(bool);
		}

		[Token(Token = "0x6002320")]
		[Address(RVA = "0xA83B38", Offset = "0xA83B38", VA = "0xA83B38")]
		public long SpendRegents(ConstructionItem constructionItem, RecipeItem recipeItem, Recipe recipe, long maxCycles)
		{
			return default(long);
		}

		[Token(Token = "0x6002321")]
		[Address(RVA = "0xA8401C", Offset = "0xA8401C", VA = "0xA8401C")]
		public long CyclesToPurchase(Recipe recipe, long cycleCap, long volume)
		{
			return default(long);
		}

		[Token(Token = "0x6002322")]
		[Address(RVA = "0xA84214", Offset = "0xA84214", VA = "0xA84214")]
		private bool RegentsHaveEnoughMaxCap(Recipe recipe)
		{
			return default(bool);
		}

		[Token(Token = "0x6002323")]
		[Address(RVA = "0xA842D4", Offset = "0xA842D4", VA = "0xA842D4")]
		private bool RegentHasEnoughMaxCap(Regent regent)
		{
			return default(bool);
		}

		[Token(Token = "0x6002324")]
		[Address(RVA = "0xA84380", Offset = "0xA84380", VA = "0xA84380")]
		public bool CanAffordToProduce(Recipe recipe)
		{
			return default(bool);
		}
	}
}
