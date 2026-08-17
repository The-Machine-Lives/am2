using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity.Settings
{
	[Token(Token = "0x2000002")]
	public class FacebookSettings : ScriptableObject
	{
		[Token(Token = "0x2000003")]
		public delegate void OnChangeCallback();

		[Serializable]
		[Token(Token = "0x2000004")]
		public class UrlSchemes
		{
			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private List<string> list;

			[Token(Token = "0x17000016")]
			public List<string> Schemes
			{
				[Token(Token = "0x600002F")]
				[Address(RVA = "0x18169C0", Offset = "0x18169C0", VA = "0x18169C0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000030")]
				[Address(RVA = "0x18169C8", Offset = "0x18169C8", VA = "0x18169C8")]
				set
				{
				}
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x18163CC", Offset = "0x18163CC", VA = "0x18163CC")]
			public UrlSchemes([Optional] List<string> schemes)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000005")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CF4C", Offset = "0x80CF4C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<OnChangeCallback> _003C_003E9__80_0;

			[Token(Token = "0x6000032")]
			[Address(RVA = "0x181653C", Offset = "0x181653C", VA = "0x181653C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1816544", Offset = "0x1816544", VA = "0x1816544")]
			internal void _003CSettingsChanged_003Eb__80_0(OnChangeCallback callback)
			{
			}
		}

		[Token(Token = "0x4000001")]
		public const string FacebookSettingsAssetName = "FacebookSettings";

		[Token(Token = "0x4000002")]
		public const string FacebookSettingsPath = "FacebookSDK/SDK/Resources";

		[Token(Token = "0x4000003")]
		public const string FacebookSettingsAssetExtension = ".asset";

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<OnChangeCallback> onChangeCallbacks;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static FacebookSettings instance;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int selectedAppIndex;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> clientTokens;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<string> appIds;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<string> appLabels;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool cookie;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool logging;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool status;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		[SerializeField]
		private bool xfbml;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool frictionlessRequests;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string androidKeystorePath;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string iosURLSuffix;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<UrlSchemes> appLinkSchemes;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string uploadAccessToken;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool autoLogAppEventsEnabled;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool advertiserIDCollectionEnabled;

		[Token(Token = "0x17000001")]
		public static int SelectedAppIndex
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x1814898", Offset = "0x1814898", VA = "0x1814898")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x1814A18", Offset = "0x1814A18", VA = "0x1814A18")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public static List<string> AppIds
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x1814C04", Offset = "0x1814C04", VA = "0x1814C04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x1814C74", Offset = "0x1814C74", VA = "0x1814C74")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public static List<string> AppLabels
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x1814D34", Offset = "0x1814D34", VA = "0x1814D34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x1814DA4", Offset = "0x1814DA4", VA = "0x1814DA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public static List<string> ClientTokens
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x1814E64", Offset = "0x1814E64", VA = "0x1814E64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1814ED4", Offset = "0x1814ED4", VA = "0x1814ED4")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public static string AppId
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x1814F94", Offset = "0x1814F94", VA = "0x1814F94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static string ClientToken
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x1815038", Offset = "0x1815038", VA = "0x1815038")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		public static bool IsValidAppId
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x18150DC", Offset = "0x18150DC", VA = "0x18150DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public static bool Cookie
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x18151CC", Offset = "0x18151CC", VA = "0x18151CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x181523C", Offset = "0x181523C", VA = "0x181523C")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public static bool Logging
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1815308", Offset = "0x1815308", VA = "0x1815308")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1815378", Offset = "0x1815378", VA = "0x1815378")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public static bool Status
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x1815444", Offset = "0x1815444", VA = "0x1815444")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x18154B4", Offset = "0x18154B4", VA = "0x18154B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public static bool Xfbml
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x1815580", Offset = "0x1815580", VA = "0x1815580")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x18155F0", Offset = "0x18155F0", VA = "0x18155F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public static string AndroidKeystorePath
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x18156BC", Offset = "0x18156BC", VA = "0x18156BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x181572C", Offset = "0x181572C", VA = "0x181572C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public static string IosURLSuffix
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x18157F4", Offset = "0x18157F4", VA = "0x18157F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x1815864", Offset = "0x1815864", VA = "0x1815864")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public static string ChannelUrl
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x181592C", Offset = "0x181592C", VA = "0x181592C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public static bool FrictionlessRequests
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x1815974", Offset = "0x1815974", VA = "0x1815974")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x18159E4", Offset = "0x18159E4", VA = "0x18159E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public static List<UrlSchemes> AppLinkSchemes
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x1815AB0", Offset = "0x1815AB0", VA = "0x1815AB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1815B20", Offset = "0x1815B20", VA = "0x1815B20")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public static string UploadAccessToken
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x1815BE0", Offset = "0x1815BE0", VA = "0x1815BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x1815C50", Offset = "0x1815C50", VA = "0x1815C50")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public static bool AutoLogAppEventsEnabled
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x1815D18", Offset = "0x1815D18", VA = "0x1815D18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x1815D88", Offset = "0x1815D88", VA = "0x1815D88")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public static bool AdvertiserIDCollectionEnabled
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x1815E54", Offset = "0x1815E54", VA = "0x1815E54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x1815EC4", Offset = "0x1815EC4", VA = "0x1815EC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public static FacebookSettings Instance
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x1814908", Offset = "0x1814908", VA = "0x1814908")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public static FacebookSettings NullableInstance
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x1815F90", Offset = "0x1815F90", VA = "0x1815F90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x18160D0", Offset = "0x18160D0", VA = "0x18160D0")]
		public static void RegisterChangeEventCallback(OnChangeCallback callback)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x181615C", Offset = "0x181615C", VA = "0x181615C")]
		public static void UnregisterChangeEventCallback(OnChangeCallback callback)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1814AD8", Offset = "0x1814AD8", VA = "0x1814AD8")]
		private static void SettingsChanged()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x18161E8", Offset = "0x18161E8", VA = "0x18161E8")]
		public FacebookSettings()
		{
		}
	}
}
