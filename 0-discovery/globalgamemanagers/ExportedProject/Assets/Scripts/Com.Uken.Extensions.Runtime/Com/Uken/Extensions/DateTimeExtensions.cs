using System;
using Il2CppDummyDll;

namespace Com.Uken.Extensions
{
	[Token(Token = "0x2000003")]
	public static class DateTimeExtensions
	{
		[Token(Token = "0x17000001")]
		public static DateTime Epoch
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x181BBBC", Offset = "0x181BBBC", VA = "0x181BBBC")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x181BC0C", Offset = "0x181BC0C", VA = "0x181BC0C")]
		public static long SecondsSinceEpoch(this DateTime dateTime)
		{
			return default(long);
		}
	}
}
