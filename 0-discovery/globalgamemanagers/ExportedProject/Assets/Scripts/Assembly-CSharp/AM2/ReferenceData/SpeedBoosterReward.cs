using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200034B")]
	public class SpeedBoosterReward : RuntimeData<RDSpeedBoosterReward>
	{
		[Token(Token = "0x4001006")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82911C", Offset = "0x82911C")]
		private RewardGroup _003CrewardGroup_003Ek__BackingField;

		[Token(Token = "0x1700042D")]
		public bool visible
		{
			[Token(Token = "0x6001A22")]
			[Address(RVA = "0x9702DC", Offset = "0x9702DC", VA = "0x9702DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700042E")]
		public RewardGroup rewardGroup
		{
			[Token(Token = "0x6001A23")]
			[Address(RVA = "0x970308", Offset = "0x970308", VA = "0x970308")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837DC0", Offset = "0x837DC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A24")]
			[Address(RVA = "0x970310", Offset = "0x970310", VA = "0x970310")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837DD0", Offset = "0x837DD0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700042F")]
		public string recipeRef
		{
			[Token(Token = "0x6001A25")]
			[Address(RVA = "0x970318", Offset = "0x970318", VA = "0x970318")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001A26")]
		[Address(RVA = "0x970344", Offset = "0x970344", VA = "0x970344")]
		public SpeedBoosterReward()
		{
		}

		[Token(Token = "0x6001A27")]
		[Address(RVA = "0x970394", Offset = "0x970394", VA = "0x970394", Slot = "4")]
		public override void Initialize(RDSpeedBoosterReward referenceData)
		{
		}
	}
}
