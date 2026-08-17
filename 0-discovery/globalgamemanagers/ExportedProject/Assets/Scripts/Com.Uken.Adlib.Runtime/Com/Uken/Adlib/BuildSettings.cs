using Il2CppDummyDll;
using UnityEngine;

namespace Com.Uken.Adlib
{
	[Token(Token = "0x200000E")]
	public class BuildSettings : ScriptableObject
	{
		[Token(Token = "0x4000024")]
		private const string BuildSettingsAssetName = "AdlibBuildSettings";

		[Token(Token = "0x4000025")]
		private const string BuildSettingsPath = "Assets/Resources";

		[Token(Token = "0x4000026")]
		private const string BuildSettingsAssetExtension = ".asset";

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x0")]
		private static BuildSettings instance;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string admobAppID;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string appLovinSDKKey;

		[Token(Token = "0x1700000B")]
		public static string AppLovinSDKKey
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x17D4B04", Offset = "0x17D4B04", VA = "0x17D4B04")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x17D4C44", Offset = "0x17D4C44", VA = "0x17D4C44")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public static string AdmobAppID
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x17D4C9C", Offset = "0x17D4C9C", VA = "0x17D4C9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x17D4CC8", Offset = "0x17D4CC8", VA = "0x17D4CC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		private static BuildSettings Instance
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x17D4B30", Offset = "0x17D4B30", VA = "0x17D4B30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x17D4C98", Offset = "0x17D4C98", VA = "0x17D4C98")]
		public static void MarkAsDirty()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x17D4D1C", Offset = "0x17D4D1C", VA = "0x17D4D1C")]
		private static void CreateAsset()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x17D4D20", Offset = "0x17D4D20", VA = "0x17D4D20")]
		public BuildSettings()
		{
		}
	}
}
