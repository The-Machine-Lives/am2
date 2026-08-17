using System;
using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x200018F")]
public class VIPStatusItem : Item
{
	[Token(Token = "0x4000967")]
	public new const string mc_sItemType = "VIPStatusItem";

	[Token(Token = "0x4000968")]
	private const string c_vipStatusTimeRemaining = "vip_status_time_remaining";

	[Token(Token = "0x1700015B")]
	public DateTime dateVipStatusExpires
	{
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0xAB7740", Offset = "0xAB7740", VA = "0xAB7740")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0xAB77EC", Offset = "0xAB77EC", VA = "0xAB77EC")]
		set
		{
		}
	}

	[Token(Token = "0x6000ADC")]
	[Address(RVA = "0xAB785C", Offset = "0xAB785C", VA = "0xAB785C")]
	public void AddDaysToVIPStatus(long days)
	{
	}

	[Token(Token = "0x6000ADD")]
	[Address(RVA = "0xAB794C", Offset = "0xAB794C", VA = "0xAB794C")]
	public VIPStatusItem()
	{
	}
}
