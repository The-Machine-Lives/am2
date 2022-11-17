using Il2CppDummyDll;

namespace Com.Uken.Adlib
{
	[Token(Token = "0x2000004")]
	public class AdPlacementShowResult
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		private readonly AdResult result;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		private readonly AdPlacement placement;

		[Token(Token = "0x17000004")]
		public AdResult Result
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x17D3580", Offset = "0x17D3580", VA = "0x17D3580")]
			get
			{
				return default(AdResult);
			}
		}

		[Token(Token = "0x17000005")]
		public AdPlacement Placement
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x17D3588", Offset = "0x17D3588", VA = "0x17D3588")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x17D3544", Offset = "0x17D3544", VA = "0x17D3544")]
		public AdPlacementShowResult(AdResult result, AdPlacement adPlacement)
		{
		}
	}
}
