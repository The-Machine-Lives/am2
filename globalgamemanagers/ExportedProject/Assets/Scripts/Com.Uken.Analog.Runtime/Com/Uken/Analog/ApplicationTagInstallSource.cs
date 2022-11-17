using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000025")]
	public class ApplicationTagInstallSource : BaseEvent
	{
		[Token(Token = "0x4000085")]
		private const string TYPE = "application";

		[Token(Token = "0x4000086")]
		private const string NAME = "tag_install_source";

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x70")]
		private ApplicationTagInstallSourceEventData eventData;

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x16D5300", Offset = "0x16D5300", VA = "0x16D5300")]
		public ApplicationTagInstallSource(string sourceType, string trackerName, string network, string campaign, string adGroup, string creative, string clickLabel)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x16D547C", Offset = "0x16D547C", VA = "0x16D547C", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x16D55DC", Offset = "0x16D55DC", VA = "0x16D55DC")]
		public string GetSourceType()
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x16D5610", Offset = "0x16D5610", VA = "0x16D5610")]
		public string GetTrackerName()
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x16D5644", Offset = "0x16D5644", VA = "0x16D5644")]
		public string GetNetwork()
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x16D5678", Offset = "0x16D5678", VA = "0x16D5678")]
		public string GetCampaign()
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x16D56AC", Offset = "0x16D56AC", VA = "0x16D56AC")]
		public string GetAdGroup()
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x16D56E0", Offset = "0x16D56E0", VA = "0x16D56E0")]
		public string GetCreative()
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x16D5714", Offset = "0x16D5714", VA = "0x16D5714")]
		public string GetClickLabel()
		{
			return null;
		}
	}
}
