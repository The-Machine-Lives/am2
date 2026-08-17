using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004AE")]
	public class OfflineGenerationController : UkenController
	{
		[Token(Token = "0x2000822")]
		private class ResearchResourceShare
		{
			[Token(Token = "0x400235C")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832FF0", Offset = "0x832FF0")]
			private long _003CtotalCurrentRate_003Ek__BackingField;

			[Token(Token = "0x400235D")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833000", Offset = "0x833000")]
			private List<ResearchSlotItem> _003CresearchSlotItems_003Ek__BackingField;

			[Token(Token = "0x17000824")]
			public long totalCurrentRate
			{
				[Token(Token = "0x6003302")]
				[Address(RVA = "0xA76A80", Offset = "0xA76A80", VA = "0xA76A80")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BB9C", Offset = "0x83BB9C")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003303")]
				[Address(RVA = "0xA76A88", Offset = "0xA76A88", VA = "0xA76A88")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BBAC", Offset = "0x83BBAC")]
				set
				{
				}
			}

			[Token(Token = "0x17000825")]
			public List<ResearchSlotItem> researchSlotItems
			{
				[Token(Token = "0x6003304")]
				[Address(RVA = "0xA76A78", Offset = "0xA76A78", VA = "0xA76A78")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BBBC", Offset = "0x83BBBC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003305")]
				[Address(RVA = "0xA7725C", Offset = "0xA7725C", VA = "0xA7725C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BBCC", Offset = "0x83BBCC")]
				set
				{
				}
			}

			[Token(Token = "0x6003306")]
			[Address(RVA = "0xA76A00", Offset = "0xA76A00", VA = "0xA76A00")]
			public ResearchResourceShare()
			{
			}
		}

		[Token(Token = "0x40015BD")]
		[FieldOffset(Offset = "0x18")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x40015BE")]
		[FieldOffset(Offset = "0x20")]
		private UkenTimeController m_time;

		[Token(Token = "0x40015BF")]
		[FieldOffset(Offset = "0x28")]
		private ConstructionController m_constructionController;

		[Token(Token = "0x40015C0")]
		[FieldOffset(Offset = "0x30")]
		private PowerController m_powerController;

		[Token(Token = "0x40015C1")]
		[FieldOffset(Offset = "0x38")]
		private SpeedBoosterController m_speedBoosterController;

		[Token(Token = "0x40015C2")]
		[FieldOffset(Offset = "0x40")]
		private RecipeController m_recipeController;

		[Token(Token = "0x40015C3")]
		[FieldOffset(Offset = "0x48")]
		private ResearchController m_researchController;

		[Token(Token = "0x40015C4")]
		[FieldOffset(Offset = "0x50")]
		private PlayerDataItem m_playerData;

		[Token(Token = "0x40015C5")]
		[FieldOffset(Offset = "0x58")]
		private MiniEventController m_miniEventController;

		[Token(Token = "0x40015C6")]
		[FieldOffset(Offset = "0x60")]
		private int m_maxOfflineIterations;

		[Token(Token = "0x40015C7")]
		[FieldOffset(Offset = "0x68")]
		private double m_minIterationTimeInSeconds;

		[Token(Token = "0x40015C8")]
		[FieldOffset(Offset = "0x70")]
		private float m_maxTimeInSeconds;

		[Token(Token = "0x60022EE")]
		[Address(RVA = "0xA757E0", Offset = "0xA757E0", VA = "0xA757E0")]
		public OfflineGenerationController(AM2InventoryController inventoryController, UkenTimeController time, ConstructionController constructionController, PowerController powerController, SpeedBoosterController speedBoosterController, RecipeController recipeController, ResearchController researchController, MiniEventController miniEventController)
		{
		}

		[Token(Token = "0x60022EF")]
		[Address(RVA = "0xA75874", Offset = "0xA75874", VA = "0xA75874", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x60022F0")]
		[Address(RVA = "0xA758B8", Offset = "0xA758B8", VA = "0xA758B8", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x60022F1")]
		[Address(RVA = "0xA75DDC", Offset = "0xA75DDC", VA = "0xA75DDC")]
		private int SortResearchSlotItemsByCurrentRate(ResearchSlotItem slot1, ResearchSlotItem slot2)
		{
			return default(int);
		}

		[Token(Token = "0x60022F2")]
		[Address(RVA = "0xA75ADC", Offset = "0xA75ADC", VA = "0xA75ADC")]
		private void OfflineGenerate(double offlineTimeInSeconds, int iterations, float iterationDuration)
		{
		}

		[Token(Token = "0x60022F3")]
		[Address(RVA = "0xA760F0", Offset = "0xA760F0", VA = "0xA760F0")]
		private Dictionary<string, ResearchResourceShare> GetSlotsByCostType(List<ResearchSlotItem> researchSlotItems)
		{
			return null;
		}

		[Token(Token = "0x60022F4")]
		[Address(RVA = "0xA763F8", Offset = "0xA763F8", VA = "0xA763F8")]
		private void OfflineGenerateResearch(float deltaTime, Dictionary<string, ResearchResourceShare> researchSlotsByCostType, double maxRate)
		{
		}
	}
}
