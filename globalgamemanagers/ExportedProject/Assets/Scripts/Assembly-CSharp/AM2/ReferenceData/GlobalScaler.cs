using System;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000380")]
	public class GlobalScaler : RuntimeData<RDGlobalScaler>
	{
		[Token(Token = "0x400110F")]
		[FieldOffset(Offset = "0x18")]
		private Formula m_scalingFormula;

		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x20")]
		private Upgradable m_upgradable;

		[Token(Token = "0x4001111")]
		[FieldOffset(Offset = "0x28")]
		private SharedDataCacheController m_sharedDataCacheController;

		[Token(Token = "0x6001BA1")]
		[Address(RVA = "0x9B4884", Offset = "0x9B4884", VA = "0x9B4884")]
		public GlobalScaler()
		{
		}

		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x9B48D4", Offset = "0x9B48D4", VA = "0x9B48D4", Slot = "4")]
		public override void Initialize(RDGlobalScaler referenceData)
		{
		}

		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x9B4A68", Offset = "0x9B4A68", VA = "0x9B4A68")]
		public long ApplyScalerValue(long value)
		{
			return default(long);
		}

		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0x9B4C38", Offset = "0x9B4C38", VA = "0x9B4C38")]
		public ValueTuple<RDGlobalScaler.ScalerOperation, double> ScalerOperation()
		{
			return default(ValueTuple<RDGlobalScaler.ScalerOperation, double>);
		}
	}
}
