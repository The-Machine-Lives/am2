using System;
using Il2CppDummyDll;
using Uken.Library.Advertising;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004C1")]
	public class ExternalAdProvider
	{
		[Token(Token = "0x4001646")]
		[FieldOffset(Offset = "0x10")]
		protected bool bDebugAds;

		[Token(Token = "0x4001647")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EB6C", Offset = "0x82EB6C")]
		private string _003CGameAD_Id_003Ek__BackingField;

		[Token(Token = "0x4001648")]
		[FieldOffset(Offset = "0x20")]
		private Action<AdsController.AdShowState> m_onDisplayComplete;

		[Token(Token = "0x4001649")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EB7C", Offset = "0x82EB7C")]
		private bool _003CIsFetchingRewardedAd_003Ek__BackingField;

		[Token(Token = "0x17000602")]
		public string GameAD_Id
		{
			[Token(Token = "0x60023EC")]
			[Address(RVA = "0xA66B5C", Offset = "0xA66B5C", VA = "0xA66B5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8396BC", Offset = "0x8396BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60023ED")]
			[Address(RVA = "0xA66B64", Offset = "0xA66B64", VA = "0xA66B64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8396CC", Offset = "0x8396CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000603")]
		public bool IsFetchingRewardedAd
		{
			[Token(Token = "0x60023EE")]
			[Address(RVA = "0xA66B6C", Offset = "0xA66B6C", VA = "0xA66B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8396DC", Offset = "0x8396DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60023EF")]
			[Address(RVA = "0xA66B74", Offset = "0xA66B74", VA = "0xA66B74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8396EC", Offset = "0x8396EC")]
			protected set
			{
			}
		}

		[Token(Token = "0x60023F0")]
		[Address(RVA = "0xA66B80", Offset = "0xA66B80", VA = "0xA66B80")]
		public ExternalAdProvider(string gameAdID)
		{
		}

		[Token(Token = "0x60023F1")]
		[Address(RVA = "0xA66BB4", Offset = "0xA66BB4", VA = "0xA66BB4", Slot = "4")]
		public virtual bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x60023F2")]
		[Address(RVA = "0xA66BBC", Offset = "0xA66BBC", VA = "0xA66BBC", Slot = "5")]
		public virtual string GetProviderName()
		{
			return null;
		}

		[Token(Token = "0x60023F3")]
		[Address(RVA = "0xA66C04", Offset = "0xA66C04", VA = "0xA66C04", Slot = "6")]
		public virtual AdController.AdStockState GetPlacementState()
		{
			return default(AdController.AdStockState);
		}

		[Token(Token = "0x60023F4")]
		[Address(RVA = "0xA66C0C", Offset = "0xA66C0C", VA = "0xA66C0C", Slot = "7")]
		public virtual bool DisplayVideoAd(Action<AdsController.AdShowState> onComplete)
		{
			return default(bool);
		}

		[Token(Token = "0x60023F5")]
		[Address(RVA = "0xA66C1C", Offset = "0xA66C1C", VA = "0xA66C1C", Slot = "8")]
		public virtual bool CanDisplayAds(AdsController.WatchType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60023F6")]
		[Address(RVA = "0xA66C24", Offset = "0xA66C24", VA = "0xA66C24", Slot = "9")]
		public virtual bool DisplayInterstitialAd(Action<AdsController.AdShowState> onComplete)
		{
			return default(bool);
		}

		[Token(Token = "0x60023F7")]
		[Address(RVA = "0xA66C34", Offset = "0xA66C34", VA = "0xA66C34", Slot = "10")]
		public virtual void OnDisplayComplete(AdsController.AdShowState state)
		{
		}

		[Token(Token = "0x60023F8")]
		[Address(RVA = "0xA66CA8", Offset = "0xA66CA8", VA = "0xA66CA8", Slot = "11")]
		public virtual void PrepareRewardedAdIfNecessary()
		{
		}

		[Token(Token = "0x60023F9")]
		[Address(RVA = "0xA66CAC", Offset = "0xA66CAC", VA = "0xA66CAC", Slot = "12")]
		public virtual void Cleanup()
		{
		}
	}
}
