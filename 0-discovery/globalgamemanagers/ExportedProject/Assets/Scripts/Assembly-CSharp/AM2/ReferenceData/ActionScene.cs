using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000339")]
	public abstract class ActionScene<T> : RuntimeData<T>, IActionScene, IReferenceable, IWeighted, IItemModel, IInfoText where T : RDActionScene
	{
		[Token(Token = "0x4000FDD")]
		[FieldOffset(Offset = "0x0")]
		protected Localizations m_localizationController;

		[Token(Token = "0x4000FDE")]
		[FieldOffset(Offset = "0x0")]
		protected RewardGroupsController m_rewardGroupsCountroller;

		[Token(Token = "0x4000FDF")]
		[FieldOffset(Offset = "0x0")]
		protected InventoryController m_inventoryController;

		[Token(Token = "0x4000FE0")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8289A0", Offset = "0x8289A0")]
		private RewardGroup _003ConStartRewardGroup_003Ek__BackingField;

		[Token(Token = "0x4000FE1")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8289B0", Offset = "0x8289B0")]
		private readonly long _003Cquantity_003Ek__BackingField;

		[Token(Token = "0x4000FE2")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8289C0", Offset = "0x8289C0")]
		private List<IAbilityEffect> _003CfriendlyStartEffects_003Ek__BackingField;

		[Token(Token = "0x4000FE3")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8289D0", Offset = "0x8289D0")]
		private EActionSceneType _003CsceneType_003Ek__BackingField;

		[Token(Token = "0x17000410")]
		public int weight
		{
			[Token(Token = "0x60019DB")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000411")]
		public RewardGroup onStartRewardGroup
		{
			[Token(Token = "0x60019DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837CD0", Offset = "0x837CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019DD")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837CE0", Offset = "0x837CE0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000412")]
		public long quantity
		{
			[Token(Token = "0x60019DE")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837CF0", Offset = "0x837CF0")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000413")]
		public List<IAbilityEffect> friendlyStartEffects
		{
			[Token(Token = "0x60019DF")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837D00", Offset = "0x837D00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837D10", Offset = "0x837D10")]
			private set
			{
			}
		}

		[Token(Token = "0x17000414")]
		public EActionSceneType sceneType
		{
			[Token(Token = "0x60019E1")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837D20", Offset = "0x837D20")]
			get
			{
				return default(EActionSceneType);
			}
			[Token(Token = "0x60019E2")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837D30", Offset = "0x837D30")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000415")]
		public string readableItemName
		{
			[Token(Token = "0x60019E3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000416")]
		public string description
		{
			[Token(Token = "0x60019E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000417")]
		public string researchInfoText
		{
			[Token(Token = "0x60019E5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000418")]
		public string infoImageSource
		{
			[Token(Token = "0x60019E6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60019E7")]
		public virtual void Setup(Localizations localizationController, RewardGroupsController rewardGroupsCountroller, InventoryController inventoryController, Dictionary<string, IAbilityEffect> allAbilityEffects)
		{
		}

		[Token(Token = "0x60019E8")]
		public List<Reward> GetSceneRewards()
		{
			return null;
		}

		[Token(Token = "0x60019E9")]
		public long GetQuantity()
		{
			return default(long);
		}

		[Token(Token = "0x60019EA")]
		public bool IsSceneInfinite()
		{
			return default(bool);
		}

		[Token(Token = "0x60019EB")]
		public bool IsQuantityReached()
		{
			return default(bool);
		}

		[Token(Token = "0x60019EC")]
		public virtual void OnSceneStart(ZoneController zoneController)
		{
		}

		[Token(Token = "0x60019ED")]
		protected ActionScene()
		{
		}
	}
}
