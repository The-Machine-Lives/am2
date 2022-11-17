using Il2CppDummyDll;

namespace Com.Uken.Adlib
{
	[Token(Token = "0x2000003")]
	public class BannerAdPlacement : AdPlacement
	{
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x28")]
		private BannerAdPosition adPosition;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x2C")]
		private MoPub.MaxAdSize maxBannerSize;

		[Token(Token = "0x17000002")]
		public BannerAdPosition AdPosition
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x17D4AE4", Offset = "0x17D4AE4", VA = "0x17D4AE4")]
			get
			{
				return default(BannerAdPosition);
			}
		}

		[Token(Token = "0x17000003")]
		public MoPub.MaxAdSize MaxBannerSize
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x17D4AEC", Offset = "0x17D4AEC", VA = "0x17D4AEC")]
			get
			{
				return default(MoPub.MaxAdSize);
			}
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x17D4AA0", Offset = "0x17D4AA0", VA = "0x17D4AA0")]
		public BannerAdPlacement(string name, BannerAdPosition adPosition, AdProvider provider, AdUnitId adUnitId, MoPub.MaxAdSize maxBannerSize = MoPub.MaxAdSize.Width320Height50)
		{
		}
	}
}
