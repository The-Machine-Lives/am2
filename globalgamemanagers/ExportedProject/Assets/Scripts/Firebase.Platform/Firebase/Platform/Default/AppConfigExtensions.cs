using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Firebase.Platform.Default
{
	[Token(Token = "0x2000014")]
	internal class AppConfigExtensions : IAppConfigExtensions
	{
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Uri DefaultUpdateUrl;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string Default;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly object Sync;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x18")]
		private static AppConfigExtensions _instance;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Dictionary<int, Dictionary<string, string>> SStringState;

		[Token(Token = "0x17000019")]
		public static IAppConfigExtensions Instance
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x17CFA18", Offset = "0x17CFA18", VA = "0x17CFA18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x17CFA10", Offset = "0x17CFA10", VA = "0x17CFA10")]
		protected AppConfigExtensions()
		{
		}
	}
}
