using System;
using Com.Uken.Adlib;
using Il2CppDummyDll;
using Uken.Library.Advertising;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004C0")]
	public class AdLibController : ExternalAdProvider
	{
		[Token(Token = "0x200082B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821388", Offset = "0x821388")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x400236F")]
			[FieldOffset(Offset = "0x10")]
			public Action<AdsController.AdShowState> onComplete;

			[Token(Token = "0x4002370")]
			[FieldOffset(Offset = "0x18")]
			public AdLibController _003C_003E4__this;

			[Token(Token = "0x6003328")]
			[Address(RVA = "0xA22384", Offset = "0xA22384", VA = "0xA22384")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6003329")]
			[Address(RVA = "0xA22590", Offset = "0xA22590", VA = "0xA22590")]
			internal void _003CDisplayVideoAd_003Eb__0(AdPlacementShowResult result)
			{
			}
		}

		[Token(Token = "0x4001643")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_initializeCalled;

		[Token(Token = "0x4001644")]
		[FieldOffset(Offset = "0x1")]
		private static bool s_initializeComplete;

		[Token(Token = "0x4001645")]
		[FieldOffset(Offset = "0x8")]
		private static AdPlacement rewardedAdPlacement;

		[Token(Token = "0x17000601")]
		public bool RewardedAdIsReady
		{
			[Token(Token = "0x60023E4")]
			[Address(RVA = "0xA22188", Offset = "0xA22188", VA = "0xA22188")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60023E1")]
		[Address(RVA = "0xA21E6C", Offset = "0xA21E6C", VA = "0xA21E6C")]
		public AdLibController(AdUnitId gameAdID)
		{
		}

		[Token(Token = "0x60023E2")]
		[Address(RVA = "0xA22070", Offset = "0xA22070", VA = "0xA22070", Slot = "12")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x60023E3")]
		[Address(RVA = "0xA2211C", Offset = "0xA2211C", VA = "0xA2211C")]
		protected void OnAdUnitMopubInitialized(string mopubEvent)
		{
		}

		[Token(Token = "0x60023E5")]
		[Address(RVA = "0xA22220", Offset = "0xA22220", VA = "0xA22220", Slot = "8")]
		public override bool CanDisplayAds(AdsController.WatchType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60023E6")]
		[Address(RVA = "0xA2225C", Offset = "0xA2225C", VA = "0xA2225C", Slot = "7")]
		public override bool DisplayVideoAd(Action<AdsController.AdShowState> onComplete)
		{
			return default(bool);
		}

		[Token(Token = "0x60023E7")]
		[Address(RVA = "0xA2238C", Offset = "0xA2238C", VA = "0xA2238C", Slot = "5")]
		public override string GetProviderName()
		{
			return null;
		}

		[Token(Token = "0x60023E8")]
		[Address(RVA = "0xA223D4", Offset = "0xA223D4", VA = "0xA223D4", Slot = "6")]
		public override AdController.AdStockState GetPlacementState()
		{
			return default(AdController.AdStockState);
		}

		[Token(Token = "0x60023E9")]
		[Address(RVA = "0xA223F4", Offset = "0xA223F4", VA = "0xA223F4", Slot = "11")]
		public override void PrepareRewardedAdIfNecessary()
		{
		}

		[Token(Token = "0x60023EB")]
		[Address(RVA = "0xA22584", Offset = "0xA22584", VA = "0xA22584")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8396AC", Offset = "0x8396AC")]
		private void _003CPrepareRewardedAdIfNecessary_003Eb__12_0(string _, bool __)
		{
		}
	}
}
