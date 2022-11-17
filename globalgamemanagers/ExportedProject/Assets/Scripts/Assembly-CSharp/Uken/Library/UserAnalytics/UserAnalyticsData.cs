using Il2CppDummyDll;

namespace Uken.Library.UserAnalytics
{
	[Token(Token = "0x20003E4")]
	public class UserAnalyticsData
	{
		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0x10")]
		public int rfm;

		[Token(Token = "0x4001247")]
		[FieldOffset(Offset = "0x14")]
		public int rfm_r;

		[Token(Token = "0x4001248")]
		[FieldOffset(Offset = "0x18")]
		public int rfm_f;

		[Token(Token = "0x4001249")]
		[FieldOffset(Offset = "0x1C")]
		public int rfm_m;

		[Token(Token = "0x400124A")]
		[FieldOffset(Offset = "0x20")]
		public double total_spend_7d;

		[Token(Token = "0x400124B")]
		[FieldOffset(Offset = "0x28")]
		public double total_spend_30d;

		[Token(Token = "0x400124C")]
		[FieldOffset(Offset = "0x30")]
		public int num_days_active_7d;

		[Token(Token = "0x400124D")]
		[FieldOffset(Offset = "0x34")]
		public int num_purchases_7d;

		[Token(Token = "0x400124E")]
		[FieldOffset(Offset = "0x38")]
		public int num_days_with_match_7d;

		[Token(Token = "0x400124F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x82E348", Offset = "0x82E348")]
		public long last_login;

		[Token(Token = "0x4001250")]
		[FieldOffset(Offset = "0x48")]
		public double average_spend_7d;

		[Token(Token = "0x4001251")]
		[FieldOffset(Offset = "0x50")]
		public double average_spend_14d;

		[Token(Token = "0x4001252")]
		[FieldOffset(Offset = "0x58")]
		public double average_spend_30d;

		[Token(Token = "0x4001253")]
		[FieldOffset(Offset = "0x60")]
		public double average_spend_60d;

		[Token(Token = "0x4001254")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x82E380", Offset = "0x82E380")]
		public long install_date;

		[Token(Token = "0x4001255")]
		[FieldOffset(Offset = "0x70")]
		public int balance_score_adjustment;

		[Token(Token = "0x6001E2B")]
		[Address(RVA = "0xB3F504", Offset = "0xB3F504", VA = "0xB3F504")]
		public UserAnalyticsData()
		{
		}
	}
}
