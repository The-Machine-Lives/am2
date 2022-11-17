using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000548")]
	public class ScaleSet
	{
		[Token(Token = "0x200084F")]
		protected class SortByLowerBoundComparer : IComparer<ScaleSetEntry>
		{
			[Token(Token = "0x6003371")]
			[Address(RVA = "0xA90F20", Offset = "0xA90F20", VA = "0xA90F20", Slot = "4")]
			public int Compare(ScaleSetEntry x, ScaleSetEntry y)
			{
				return default(int);
			}

			[Token(Token = "0x6003372")]
			[Address(RVA = "0xA90F18", Offset = "0xA90F18", VA = "0xA90F18")]
			public SortByLowerBoundComparer()
			{
			}
		}

		[Token(Token = "0x400191E")]
		[FieldOffset(Offset = "0x10")]
		protected List<ScaleSetEntry> m_entries;

		[Token(Token = "0x6002856")]
		[Address(RVA = "0xA90B44", Offset = "0xA90B44", VA = "0xA90B44")]
		public ScaleSet()
		{
		}

		[Token(Token = "0x6002857")]
		[Address(RVA = "0xA8BD14", Offset = "0xA8BD14", VA = "0xA8BD14")]
		public ScaleSet(List<ScaleSetEntry> entries)
		{
		}

		[Token(Token = "0x6002858")]
		[Address(RVA = "0xA90BB4", Offset = "0xA90BB4", VA = "0xA90BB4")]
		public void AddScaleSetEntry(ScaleSetEntry entry)
		{
		}

		[Token(Token = "0x6002859")]
		[Address(RVA = "0xA90CE4", Offset = "0xA90CE4", VA = "0xA90CE4")]
		public float GetScalarForBoundsValue(int boundsValue, float fallbackScalar)
		{
			return default(float);
		}

		[Token(Token = "0x600285A")]
		[Address(RVA = "0xA8C198", Offset = "0xA8C198", VA = "0xA8C198")]
		public ScaleSetEntry GetEntryForBoundsValue(int boundsValue)
		{
			return null;
		}

		[Token(Token = "0x600285B")]
		[Address(RVA = "0xA90D18", Offset = "0xA90D18", VA = "0xA90D18")]
		public int GetHighestBounds()
		{
			return default(int);
		}

		[Token(Token = "0x600285C")]
		[Address(RVA = "0xA90E0C", Offset = "0xA90E0C", VA = "0xA90E0C")]
		public ScaleSetEntry GetEntryForScalarValue(float entryValue)
		{
			return null;
		}

		[Token(Token = "0x600285D")]
		[Address(RVA = "0xA8C348", Offset = "0xA8C348", VA = "0xA8C348")]
		public List<ScaleSetEntry> GetOrderedEntries()
		{
			return null;
		}

		[Token(Token = "0x600285E")]
		[Address(RVA = "0xA8BD98", Offset = "0xA8BD98", VA = "0xA8BD98")]
		public ScaleSet CreateOrderedSafeSet()
		{
			return null;
		}

		[Token(Token = "0x600285F")]
		[Address(RVA = "0xA90BC0", Offset = "0xA90BC0", VA = "0xA90BC0")]
		protected void AddEntry(ScaleSetEntry entry)
		{
		}
	}
}
