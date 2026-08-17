using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000348")]
	public class SpeedBooster : RuntimeData<RDSpeedBooster>, IItemModel, IInfoText
	{
		[Token(Token = "0x4001000")]
		public const string c_itemType = "booster_item";

		[Token(Token = "0x4001001")]
		public const string c_expiredTag = "expired";

		[Token(Token = "0x4001002")]
		[FieldOffset(Offset = "0x18")]
		public List<SpeedBoosterReward> onUseRewards;

		[Token(Token = "0x17000424")]
		public string costItemRef
		{
			[Token(Token = "0x6001A12")]
			[Address(RVA = "0x96FE5C", Offset = "0x96FE5C", VA = "0x96FE5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000425")]
		public long costItemAmount
		{
			[Token(Token = "0x6001A13")]
			[Address(RVA = "0x96FE88", Offset = "0x96FE88", VA = "0x96FE88")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000426")]
		public int durationInSeconds
		{
			[Token(Token = "0x6001A14")]
			[Address(RVA = "0x96FEB4", Offset = "0x96FEB4", VA = "0x96FEB4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000427")]
		public double speedUpPercent
		{
			[Token(Token = "0x6001A15")]
			[Address(RVA = "0x96FEE0", Offset = "0x96FEE0", VA = "0x96FEE0")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000428")]
		public string speedUpPercentDisplayText
		{
			[Token(Token = "0x6001A16")]
			[Address(RVA = "0x96FF10", Offset = "0x96FF10", VA = "0x96FF10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000429")]
		public string readableItemName
		{
			[Token(Token = "0x6001A17")]
			[Address(RVA = "0x96FFC8", Offset = "0x96FFC8", VA = "0x96FFC8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700042A")]
		public string description
		{
			[Token(Token = "0x6001A18")]
			[Address(RVA = "0x96FFF4", Offset = "0x96FFF4", VA = "0x96FFF4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700042B")]
		public string researchInfoText
		{
			[Token(Token = "0x6001A19")]
			[Address(RVA = "0x970020", Offset = "0x970020", VA = "0x970020", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700042C")]
		public string infoImageSource
		{
			[Token(Token = "0x6001A1A")]
			[Address(RVA = "0x970068", Offset = "0x970068", VA = "0x970068", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001A1B")]
		[Address(RVA = "0x9700B0", Offset = "0x9700B0", VA = "0x9700B0")]
		public SpeedBooster()
		{
		}

		[Token(Token = "0x6001A1C")]
		[Address(RVA = "0x970100", Offset = "0x970100", VA = "0x970100", Slot = "4")]
		public override void Initialize(RDSpeedBooster referenceData)
		{
		}

		[Token(Token = "0x6001A1D")]
		[Address(RVA = "0x9702A0", Offset = "0x9702A0", VA = "0x9702A0")]
		public double GetMaxTimeInSecondsForPiggyBack()
		{
			return default(double);
		}

		[Token(Token = "0x6001A1E")]
		[Address(RVA = "0x96FD98", Offset = "0x96FD98", VA = "0x96FD98")]
		public int CompareTo(SpeedBooster value)
		{
			return default(int);
		}
	}
}
