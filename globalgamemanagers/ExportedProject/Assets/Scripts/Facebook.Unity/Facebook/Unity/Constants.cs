using System;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x200000A")]
	internal static class Constants
	{
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x0")]
		private static FacebookUnityPlatform? currentPlatform;

		[Token(Token = "0x1700000D")]
		public static Uri GraphUrl
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0xCD2728", Offset = "0xCD2728", VA = "0xCD2728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		public static string GraphApiUserAgent
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0xCC95E4", Offset = "0xCC95E4", VA = "0xCC95E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public static bool IsEditor
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0xCD2B2C", Offset = "0xCD2B2C", VA = "0xCD2B2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public static bool IsWeb
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0xCD2B34", Offset = "0xCD2B34", VA = "0xCD2B34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		public static bool IsGameroom
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0xCD2B50", Offset = "0xCD2B50", VA = "0xCD2B50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		public static string UnitySDKUserAgentSuffixLegacy
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0xCD2B6C", Offset = "0xCD2B6C", VA = "0xCD2B6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public static string UnitySDKUserAgent
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xCD2AB0", Offset = "0xCD2AB0", VA = "0xCD2AB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public static bool DebugMode
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xCD2C98", Offset = "0xCD2C98", VA = "0xCD2C98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public static FacebookUnityPlatform CurrentPlatform
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0xCC9504", Offset = "0xCC9504", VA = "0xCC9504")]
			get
			{
				return default(FacebookUnityPlatform);
			}
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xCD2CF8", Offset = "0xCD2CF8", VA = "0xCD2CF8")]
		private static FacebookUnityPlatform GetCurrentPlatform()
		{
			return default(FacebookUnityPlatform);
		}
	}
}
