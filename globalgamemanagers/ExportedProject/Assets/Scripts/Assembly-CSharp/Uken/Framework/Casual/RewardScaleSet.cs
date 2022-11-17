using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000547")]
	public class RewardScaleSet : RuntimeData<RDRewardScaleSet>
	{
		[Token(Token = "0x400191A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x831CBC", Offset = "0x831CBC")]
		private ScaleSet _003CscaleSet_003Ek__BackingField;

		[Token(Token = "0x400191B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x831CCC", Offset = "0x831CCC")]
		private RewardGroup _003CrewardGroup_003Ek__BackingField;

		[Token(Token = "0x400191C")]
		[FieldOffset(Offset = "0x28")]
		protected float m_globalScalar;

		[Token(Token = "0x400191D")]
		[FieldOffset(Offset = "0x30")]
		protected List<ScaleSetEntry> m_cachedSortedEntries;

		[Token(Token = "0x1700070B")]
		public ScaleSet scaleSet
		{
			[Token(Token = "0x6002849")]
			[Address(RVA = "0xA8BAD8", Offset = "0xA8BAD8", VA = "0xA8BAD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A240", Offset = "0x83A240")]
			get
			{
				return null;
			}
			[Token(Token = "0x600284A")]
			[Address(RVA = "0xA8BAE0", Offset = "0xA8BAE0", VA = "0xA8BAE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A250", Offset = "0x83A250")]
			private set
			{
			}
		}

		[Token(Token = "0x1700070C")]
		public RewardGroup rewardGroup
		{
			[Token(Token = "0x600284B")]
			[Address(RVA = "0xA8BAE8", Offset = "0xA8BAE8", VA = "0xA8BAE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A260", Offset = "0x83A260")]
			get
			{
				return null;
			}
			[Token(Token = "0x600284C")]
			[Address(RVA = "0xA8BAF0", Offset = "0xA8BAF0", VA = "0xA8BAF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A270", Offset = "0x83A270")]
			private set
			{
			}
		}

		[Token(Token = "0x600284D")]
		[Address(RVA = "0xA8BAF8", Offset = "0xA8BAF8", VA = "0xA8BAF8", Slot = "4")]
		public override void Initialize(RDRewardScaleSet referenceData)
		{
		}

		[Token(Token = "0x600284E")]
		[Address(RVA = "0xA8BFCC", Offset = "0xA8BFCC", VA = "0xA8BFCC")]
		public RewardScaleSet()
		{
		}

		[Token(Token = "0x600284F")]
		[Address(RVA = "0xA8C024", Offset = "0xA8C024", VA = "0xA8C024")]
		public RewardScaleSet(RewardGroup rewardGroup, ScaleSet scaleSet)
		{
		}

		[Token(Token = "0x6002850")]
		[Address(RVA = "0xA8C094", Offset = "0xA8C094", VA = "0xA8C094")]
		public RewardScaleSet(RewardGroup rewardGroup, ScaleSet scaleSet, float globalScalar)
		{
		}

		[Token(Token = "0x6002851")]
		[Address(RVA = "0xA8C0C4", Offset = "0xA8C0C4", VA = "0xA8C0C4")]
		public void ScaleAllEntries(float scalar)
		{
		}

		[Token(Token = "0x6002852")]
		[Address(RVA = "0xA8C0D4", Offset = "0xA8C0D4", VA = "0xA8C0D4")]
		public Dictionary<string, long> BuildTransactionForBoundsValue(int boundsValue)
		{
			return null;
		}

		[Token(Token = "0x6002853")]
		[Address(RVA = "0xA8C2B8", Offset = "0xA8C2B8", VA = "0xA8C2B8")]
		public List<ScaleSetEntry> GetEntriesSortedLowToHigh()
		{
			return null;
		}

		[Token(Token = "0x6002854")]
		[Address(RVA = "0xA8C3F8", Offset = "0xA8C3F8", VA = "0xA8C3F8")]
		public ScaleSetEntry GetEntryForBoundsValue(int boundsValue)
		{
			return null;
		}

		[Token(Token = "0x6002855")]
		[Address(RVA = "0xA8C54C", Offset = "0xA8C54C", VA = "0xA8C54C")]
		public ScaleSetEntry GetNextEntryForBoundsValue(int boundsValue)
		{
			return null;
		}
	}
}
