using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inventory;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004B1")]
	public class RecipeDifferentialController : UkenController
	{
		[Token(Token = "0x2000824")]
		private class Differential
		{
			[Token(Token = "0x400235E")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833010", Offset = "0x833010")]
			private Dictionary<string, double> _003Ctransactions_003Ek__BackingField;

			[Token(Token = "0x400235F")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833020", Offset = "0x833020")]
			private double _003CtotalDelta_003Ek__BackingField;

			[Token(Token = "0x4002360")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833030", Offset = "0x833030")]
			private double _003CresearchDelta_003Ek__BackingField;

			[Token(Token = "0x4002361")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833040", Offset = "0x833040")]
			private double _003CtotalProduction_003Ek__BackingField;

			[Token(Token = "0x17000826")]
			public Dictionary<string, double> transactions
			{
				[Token(Token = "0x6003308")]
				[Address(RVA = "0xA84758", Offset = "0xA84758", VA = "0xA84758")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BBDC", Offset = "0x83BBDC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003309")]
				[Address(RVA = "0xA85868", Offset = "0xA85868", VA = "0xA85868")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BBEC", Offset = "0x83BBEC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000827")]
			public double totalDelta
			{
				[Token(Token = "0x600330A")]
				[Address(RVA = "0xA84CA8", Offset = "0xA84CA8", VA = "0xA84CA8")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BBFC", Offset = "0x83BBFC")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x600330B")]
				[Address(RVA = "0xA85870", Offset = "0xA85870", VA = "0xA85870")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BC0C", Offset = "0x83BC0C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000828")]
			public double researchDelta
			{
				[Token(Token = "0x600330C")]
				[Address(RVA = "0xA84878", Offset = "0xA84878", VA = "0xA84878")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BC1C", Offset = "0x83BC1C")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x600330D")]
				[Address(RVA = "0xA85878", Offset = "0xA85878", VA = "0xA85878")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BC2C", Offset = "0x83BC2C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000829")]
			public double totalProduction
			{
				[Token(Token = "0x600330E")]
				[Address(RVA = "0xA84674", Offset = "0xA84674", VA = "0xA84674")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BC3C", Offset = "0x83BC3C")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x600330F")]
				[Address(RVA = "0xA85880", Offset = "0xA85880", VA = "0xA85880")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BC4C", Offset = "0x83BC4C")]
				private set
				{
				}
			}

			[Token(Token = "0x6003310")]
			[Address(RVA = "0xA857B0", Offset = "0xA857B0", VA = "0xA857B0")]
			public void RecordTransaction(string recipe, double delta, bool isResearch)
			{
			}

			[Token(Token = "0x6003311")]
			[Address(RVA = "0xA84ECC", Offset = "0xA84ECC", VA = "0xA84ECC")]
			public void Reset()
			{
			}

			[Token(Token = "0x6003312")]
			[Address(RVA = "0xA84AA4", Offset = "0xA84AA4", VA = "0xA84AA4")]
			public double? GetRecipeOverdraw(string sink)
			{
				return null;
			}

			[Token(Token = "0x6003313")]
			[Address(RVA = "0xA84CB0", Offset = "0xA84CB0", VA = "0xA84CB0")]
			public Differential()
			{
			}
		}

		[Token(Token = "0x40015DE")]
		[FieldOffset(Offset = "0x18")]
		private ConstructionController m_constructionController;

		[Token(Token = "0x40015DF")]
		[FieldOffset(Offset = "0x20")]
		private RecipeController m_recipeController;

		[Token(Token = "0x40015E0")]
		[FieldOffset(Offset = "0x28")]
		private ResearchController m_researchController;

		[Token(Token = "0x40015E1")]
		[FieldOffset(Offset = "0x30")]
		private SpeedBoosterController m_speedBoosterController;

		[Token(Token = "0x40015E2")]
		[FieldOffset(Offset = "0x38")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x40015E3")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, Differential> recipeDifferentials;

		[Token(Token = "0x6002325")]
		[Address(RVA = "0xA84514", Offset = "0xA84514", VA = "0xA84514")]
		public RecipeDifferentialController(ConstructionController constructionController, RecipeController recipeController, ResearchController researchController, SpeedBoosterController speedBoosterController, EquipmentController equipmentController, InventoryController inventoryController)
		{
		}

		[Token(Token = "0x6002326")]
		[Address(RVA = "0xA845C0", Offset = "0xA845C0", VA = "0xA845C0")]
		public double GetRecipeProduction(string recipeReference)
		{
			return default(double);
		}

		[Token(Token = "0x6002327")]
		[Address(RVA = "0xA8467C", Offset = "0xA8467C", VA = "0xA8467C")]
		public Dictionary<string, double> GetRecipeTransactions(string recipeReference)
		{
			return null;
		}

		[Token(Token = "0x6002328")]
		[Address(RVA = "0xA84760", Offset = "0xA84760", VA = "0xA84760")]
		public double? GetResearchOverdrawPercentage(string costItemRef)
		{
			return null;
		}

		[Token(Token = "0x6002329")]
		[Address(RVA = "0xA84880", Offset = "0xA84880", VA = "0xA84880")]
		public double? GetResearchOverdraw(IResearchable researchable)
		{
			return null;
		}

		[Token(Token = "0x600232A")]
		[Address(RVA = "0xA84B7C", Offset = "0xA84B7C", VA = "0xA84B7C")]
		public double? RecipeRelativeGrowthRate(string recipeReference)
		{
			return null;
		}

		[Token(Token = "0x600232B")]
		[Address(RVA = "0xA84D20", Offset = "0xA84D20", VA = "0xA84D20", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x600232C")]
		[Address(RVA = "0xA84D64", Offset = "0xA84D64", VA = "0xA84D64")]
		private void ClearDifferentials()
		{
		}

		[Token(Token = "0x600232D")]
		[Address(RVA = "0xA84EA8", Offset = "0xA84EA8", VA = "0xA84EA8")]
		private void UpdateDifferentials()
		{
		}

		[Token(Token = "0x600232E")]
		[Address(RVA = "0xA84F38", Offset = "0xA84F38", VA = "0xA84F38")]
		private void UpdateRecipeGenerationDifferentials()
		{
		}

		[Token(Token = "0x600232F")]
		[Address(RVA = "0xA850DC", Offset = "0xA850DC", VA = "0xA850DC")]
		private void UpdateRecipeDifferentials(Recipe recipe)
		{
		}

		[Token(Token = "0x6002330")]
		[Address(RVA = "0xA85308", Offset = "0xA85308", VA = "0xA85308")]
		private void UpdateRegentDifferentials(Recipe recipe, double productionRate)
		{
		}

		[Token(Token = "0x6002331")]
		[Address(RVA = "0xA851C0", Offset = "0xA851C0", VA = "0xA851C0")]
		private double? GetProductionRate(Recipe recipe)
		{
			return null;
		}

		[Token(Token = "0x6002332")]
		[Address(RVA = "0xA85300", Offset = "0xA85300", VA = "0xA85300")]
		private void RecordRecipeGeneration(string recipe, string otherResourceDisplayName, double delta)
		{
		}

		[Token(Token = "0x6002333")]
		[Address(RVA = "0xA8500C", Offset = "0xA8500C", VA = "0xA8500C")]
		private void UpdateResearchProgressDifferentials()
		{
		}

		[Token(Token = "0x6002334")]
		[Address(RVA = "0xA85584", Offset = "0xA85584", VA = "0xA85584")]
		private void UpdateResearchDifferential(ResearchSlotItem researchSlotItem)
		{
		}

		[Token(Token = "0x6002335")]
		[Address(RVA = "0xA85614", Offset = "0xA85614", VA = "0xA85614")]
		private double GlobalSpeedBoostMultiplier()
		{
			return default(double);
		}

		[Token(Token = "0x6002336")]
		[Address(RVA = "0xA8565C", Offset = "0xA8565C", VA = "0xA8565C")]
		private void RecordResearchProgress(IResearchable researchable, long deltaPerSecond)
		{
		}

		[Token(Token = "0x6002337")]
		[Address(RVA = "0xA85468", Offset = "0xA85468", VA = "0xA85468")]
		private void InsertOrUpdateDifferential(string recipe, string otherResourceDisplayName, double delta, bool isResearch)
		{
		}
	}
}
