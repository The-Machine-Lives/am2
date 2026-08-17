using System.Collections.Generic;
using Il2CppDummyDll;

namespace Com.Uken.Adlib
{
	[Token(Token = "0x2000002")]
	public class AdPlacement
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		public readonly AdType AdType;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<AdProvider, AdUnitId> providerIds;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		private readonly string name;

		[Token(Token = "0x17000001")]
		public string Name
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x17D33AC", Offset = "0x17D33AC", VA = "0x17D33AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x17D32E8", Offset = "0x17D32E8", VA = "0x17D32E8")]
		public AdPlacement(string name, AdType adType, AdUnitId adUnitId, AdProvider provider = AdProvider.Mopub)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x17D33B4", Offset = "0x17D33B4", VA = "0x17D33B4")]
		public string GetAdUnitId(AdProvider adProviderType = AdProvider.Mopub)
		{
			return null;
		}
	}
}
