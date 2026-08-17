using System;
using Com.Google.Android.Gms.Common.Api;
using Com.Google.Android.Gms.Games.Stats;
using GooglePlayGames.BasicApi;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.Native.Android
{
	[Token(Token = "0x2000262")]
	internal class AndroidClient : IClientImpl
	{
		[Token(Token = "0x20006F7")]
		private class StatsResultCallback : ResultCallbackProxy<Stats_LoadPlayerStatsResultObject>
		{
			[Token(Token = "0x40020E1")]
			[FieldOffset(Offset = "0x20")]
			private Action<int, Com.Google.Android.Gms.Games.Stats.PlayerStats> callback;

			[Token(Token = "0x6002F88")]
			[Address(RVA = "0x1467AB0", Offset = "0x1467AB0", VA = "0x1467AB0")]
			public StatsResultCallback(Action<int, Com.Google.Android.Gms.Games.Stats.PlayerStats> callback)
			{
			}

			[Token(Token = "0x6002F89")]
			[Address(RVA = "0x1468324", Offset = "0x1468324", VA = "0x1468324", Slot = "10")]
			public override void OnResult(Stats_LoadPlayerStatsResultObject arg_Result_1)
			{
			}
		}

		[Token(Token = "0x20006F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820D68", Offset = "0x820D68")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x40020E2")]
			[FieldOffset(Offset = "0x10")]
			public IntPtr intentRef;

			[Token(Token = "0x6002F8A")]
			[Address(RVA = "0x1467CD0", Offset = "0x1467CD0", VA = "0x1467CD0")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6002F8B")]
			[Address(RVA = "0x1467CD8", Offset = "0x1467CD8", VA = "0x1467CD8")]
			internal void _003CCreatePlatformConfiguration_003Eb__1()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20006F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820D78", Offset = "0x820D78")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40020E3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40020E4")]
			[FieldOffset(Offset = "0x8")]
			public static Action<IntPtr> _003C_003E9__5_0;

			[Token(Token = "0x6002F8D")]
			[Address(RVA = "0x1467BF8", Offset = "0x1467BF8", VA = "0x1467BF8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6002F8E")]
			[Address(RVA = "0x1467C00", Offset = "0x1467C00", VA = "0x1467C00")]
			internal void _003CCreatePlatformConfiguration_003Eb__5_0(IntPtr intent)
			{
			}
		}

		[Token(Token = "0x20006FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820D88", Offset = "0x820D88")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x40020E5")]
			[FieldOffset(Offset = "0x10")]
			public Action<CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback;

			[Token(Token = "0x6002F8F")]
			[Address(RVA = "0x1467AA8", Offset = "0x1467AA8", VA = "0x1467AA8")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6002F90")]
			[Address(RVA = "0x1467D50", Offset = "0x1467D50", VA = "0x1467D50")]
			internal void _003CGetPlayerStats_003Eb__0(int result, Com.Google.Android.Gms.Games.Stats.PlayerStats stats)
			{
			}
		}

		[Token(Token = "0x4000D13")]
		internal const string BridgeActivityClass = "com.google.games.bridge.NativeBridgeActivity";

		[Token(Token = "0x4000D14")]
		private const string LaunchBridgeMethod = "launchBridgeIntent";

		[Token(Token = "0x4000D15")]
		private const string LaunchBridgeSignature = "(Landroid/app/Activity;Landroid/content/Intent;)V";

		[Token(Token = "0x4000D16")]
		[FieldOffset(Offset = "0x10")]
		private TokenClient tokenClient;

		[Token(Token = "0x4000D17")]
		[FieldOffset(Offset = "0x0")]
		private static AndroidJavaObject invisible;

		[Token(Token = "0x60011F4")]
		[Address(RVA = "0x1466F04", Offset = "0x1466F04", VA = "0x1466F04", Slot = "4")]
		public PlatformConfiguration CreatePlatformConfiguration(PlayGamesClientConfiguration clientConfig)
		{
			return null;
		}

		[Token(Token = "0x60011F5")]
		[Address(RVA = "0x146717C", Offset = "0x146717C", VA = "0x146717C", Slot = "5")]
		public TokenClient CreateTokenClient(bool reset)
		{
			return null;
		}

		[Token(Token = "0x60011F6")]
		[Address(RVA = "0x146726C", Offset = "0x146726C", VA = "0x146726C")]
		private static void LaunchBridgeIntent(IntPtr bridgedIntent)
		{
		}

		[Token(Token = "0x60011F7")]
		[Address(RVA = "0x14677DC", Offset = "0x14677DC", VA = "0x14677DC")]
		public void Signout()
		{
		}

		[Token(Token = "0x60011F8")]
		[Address(RVA = "0x1467898", Offset = "0x1467898", VA = "0x1467898", Slot = "6")]
		public void GetPlayerStats(IntPtr apiClient, Action<CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback)
		{
		}

		[Token(Token = "0x60011F9")]
		[Address(RVA = "0x1467B14", Offset = "0x1467B14", VA = "0x1467B14", Slot = "7")]
		public void SetGravityForPopups(IntPtr apiClient, Gravity gravity)
		{
		}

		[Token(Token = "0x60011FA")]
		[Address(RVA = "0x1467B8C", Offset = "0x1467B8C", VA = "0x1467B8C")]
		public AndroidClient()
		{
		}
	}
}
