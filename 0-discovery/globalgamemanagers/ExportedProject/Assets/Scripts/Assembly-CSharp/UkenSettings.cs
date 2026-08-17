using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200020C")]
public class UkenSettings : ScriptableObject
{
	[Token(Token = "0x4000B8A")]
	private const string ukenSettingsAssetName = "UkenSettings";

	[Token(Token = "0x4000B8B")]
	private const string ukenSettingsPath = "Uken";

	[Token(Token = "0x4000B8C")]
	private const string ukenSettingsResourcesPath = "Resources";

	[Token(Token = "0x4000B8D")]
	private const string ukenSettingsAssetExtension = ".asset";

	[Token(Token = "0x4000B8E")]
	[FieldOffset(Offset = "0x0")]
	private static UkenSettings instance;

	[Token(Token = "0x4000B8F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string androidKeystoreName;

	[Token(Token = "0x4000B90")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string androidKeystorePassword;

	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string androidKeyaliasName;

	[Token(Token = "0x4000B92")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string[] scenesToBuild;

	[Token(Token = "0x4000B93")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string buildVersion;

	[Token(Token = "0x4000B94")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool buildPlatformAmazon;

	[Token(Token = "0x4000B95")]
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	private bool buildPlatformAmazonSandbox;

	[Token(Token = "0x4000B96")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string googlePlayPublicKey;

	[Token(Token = "0x4000B97")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string iOSSKU;

	[Token(Token = "0x4000B98")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool iOSPushNotifications;

	[Token(Token = "0x4000B99")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private string macSKU;

	[Token(Token = "0x4000B9A")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool webGLDebugAllowMemoryGrowth;

	[Token(Token = "0x4000B9B")]
	[FieldOffset(Offset = "0x69")]
	[SerializeField]
	private bool webGLDebugDevelopmentBuild;

	[Token(Token = "0x4000B9C")]
	[FieldOffset(Offset = "0x6A")]
	[SerializeField]
	private bool supportsPlatformiOS;

	[Token(Token = "0x4000B9D")]
	[FieldOffset(Offset = "0x6B")]
	[SerializeField]
	private bool supportsPlatformMac;

	[Token(Token = "0x4000B9E")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private bool supportsPlatformAndroid;

	[Token(Token = "0x4000B9F")]
	[FieldOffset(Offset = "0x6D")]
	[SerializeField]
	private bool supportsPlatformAmazon;

	[Token(Token = "0x4000BA0")]
	[FieldOffset(Offset = "0x6E")]
	[SerializeField]
	private bool supportsPlatformWebGL;

	[Token(Token = "0x4000BA1")]
	[FieldOffset(Offset = "0x6F")]
	[SerializeField]
	private bool supportsFacebook;

	[Token(Token = "0x4000BA2")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool supportsPurchases;

	[Token(Token = "0x4000BA3")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float timeScale;

	[Token(Token = "0x170001B1")]
	private static UkenSettings Instance
	{
		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0xB49FC4", Offset = "0xB49FC4", VA = "0xB49FC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B2")]
	public static string AndroidKeystoreName
	{
		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0xB4A39C", Offset = "0xB4A39C", VA = "0xB4A39C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0xB4A3C8", Offset = "0xB4A3C8", VA = "0xB4A3C8")]
		set
		{
		}
	}

	[Token(Token = "0x170001B3")]
	public static string AndroidKeystorePassword
	{
		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0xB4A420", Offset = "0xB4A420", VA = "0xB4A420")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0xB4A44C", Offset = "0xB4A44C", VA = "0xB4A44C")]
		set
		{
		}
	}

	[Token(Token = "0x170001B4")]
	public static string AndroidKeyaliasName
	{
		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0xB4A4A0", Offset = "0xB4A4A0", VA = "0xB4A4A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DC3")]
		[Address(RVA = "0xB4A4CC", Offset = "0xB4A4CC", VA = "0xB4A4CC")]
		set
		{
		}
	}

	[Token(Token = "0x170001B5")]
	public static string[] ScenesToBuild
	{
		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0xB4A60C", Offset = "0xB4A60C", VA = "0xB4A60C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0xB4A638", Offset = "0xB4A638", VA = "0xB4A638")]
		set
		{
		}
	}

	[Token(Token = "0x170001B6")]
	public static string BuildVersion
	{
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0xB4A684", Offset = "0xB4A684", VA = "0xB4A684")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0xB4A6B0", Offset = "0xB4A6B0", VA = "0xB4A6B0")]
		set
		{
		}
	}

	[Token(Token = "0x170001B7")]
	public static bool BuildPlatformAmazon
	{
		[Token(Token = "0x6000DC9")]
		[Address(RVA = "0xB47F9C", Offset = "0xB47F9C", VA = "0xB47F9C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0xB4A704", Offset = "0xB4A704", VA = "0xB4A704")]
		set
		{
		}
	}

	[Token(Token = "0x170001B8")]
	public static bool BuildPlatformAmazonSandbox
	{
		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0xB4A75C", Offset = "0xB4A75C", VA = "0xB4A75C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0xB4A788", Offset = "0xB4A788", VA = "0xB4A788")]
		set
		{
		}
	}

	[Token(Token = "0x170001B9")]
	public static string GooglePlayPublicKey
	{
		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0xB4A7E0", Offset = "0xB4A7E0", VA = "0xB4A7E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0xB4A80C", Offset = "0xB4A80C", VA = "0xB4A80C")]
		set
		{
		}
	}

	[Token(Token = "0x170001BA")]
	public static string IOSSKU
	{
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0xB4A860", Offset = "0xB4A860", VA = "0xB4A860")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0xB4A88C", Offset = "0xB4A88C", VA = "0xB4A88C")]
		set
		{
		}
	}

	[Token(Token = "0x170001BB")]
	public static bool IOSPushNotifications
	{
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0xB4A8E0", Offset = "0xB4A8E0", VA = "0xB4A8E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0xB4A90C", Offset = "0xB4A90C", VA = "0xB4A90C")]
		set
		{
		}
	}

	[Token(Token = "0x170001BC")]
	public static string MacSKU
	{
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0xB4A964", Offset = "0xB4A964", VA = "0xB4A964")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0xB4A990", Offset = "0xB4A990", VA = "0xB4A990")]
		set
		{
		}
	}

	[Token(Token = "0x170001BD")]
	public static bool WebGLDebugAllowMemoryGrowth
	{
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0xB4A9E4", Offset = "0xB4A9E4", VA = "0xB4A9E4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0xB4AA10", Offset = "0xB4AA10", VA = "0xB4AA10")]
		set
		{
		}
	}

	[Token(Token = "0x170001BE")]
	public static bool WebGLDebugDevelopmentBuild
	{
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0xB4AA68", Offset = "0xB4AA68", VA = "0xB4AA68")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0xB4AA94", Offset = "0xB4AA94", VA = "0xB4AA94")]
		set
		{
		}
	}

	[Token(Token = "0x170001BF")]
	public static bool SupportsPlatformiOS
	{
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0xB4AAEC", Offset = "0xB4AAEC", VA = "0xB4AAEC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0xB4AB18", Offset = "0xB4AB18", VA = "0xB4AB18")]
		set
		{
		}
	}

	[Token(Token = "0x170001C0")]
	public static bool SupportsPlatformMac
	{
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0xB4AB70", Offset = "0xB4AB70", VA = "0xB4AB70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0xB4AB9C", Offset = "0xB4AB9C", VA = "0xB4AB9C")]
		set
		{
		}
	}

	[Token(Token = "0x170001C1")]
	public static bool SupportsPlatformAndroid
	{
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0xB4ABF4", Offset = "0xB4ABF4", VA = "0xB4ABF4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0xB4AC20", Offset = "0xB4AC20", VA = "0xB4AC20")]
		set
		{
		}
	}

	[Token(Token = "0x170001C2")]
	public static bool SupportsPlatformAmazon
	{
		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0xB4AC78", Offset = "0xB4AC78", VA = "0xB4AC78")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0xB4ACA4", Offset = "0xB4ACA4", VA = "0xB4ACA4")]
		set
		{
		}
	}

	[Token(Token = "0x170001C3")]
	public static bool SupportsPlatformWebGL
	{
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0xB4ACFC", Offset = "0xB4ACFC", VA = "0xB4ACFC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0xB4AD28", Offset = "0xB4AD28", VA = "0xB4AD28")]
		set
		{
		}
	}

	[Token(Token = "0x170001C4")]
	public static bool SupportsFacebook
	{
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0xB4AD80", Offset = "0xB4AD80", VA = "0xB4AD80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0xB4ADAC", Offset = "0xB4ADAC", VA = "0xB4ADAC")]
		set
		{
		}
	}

	[Token(Token = "0x170001C5")]
	public static bool SupportsPurchases
	{
		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0xB4AE04", Offset = "0xB4AE04", VA = "0xB4AE04")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0xB4AE30", Offset = "0xB4AE30", VA = "0xB4AE30")]
		set
		{
		}
	}

	[Token(Token = "0x170001C6")]
	public static float TimeScale
	{
		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0xB4AE88", Offset = "0xB4AE88", VA = "0xB4AE88")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0xB4AEB4", Offset = "0xB4AEB4", VA = "0xB4AEB4")]
		set
		{
		}
	}

	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0xB4A058", Offset = "0xB4A058", VA = "0xB4A058")]
	public static void LoadFromDisk()
	{
	}

	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0xB4A18C", Offset = "0xB4A18C", VA = "0xB4A18C")]
	public static void TEMP_CLEAR_USER_DATA()
	{
	}

	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0xB4A31C", Offset = "0xB4A31C", VA = "0xB4A31C")]
	private static void TEMP_DELETEALLFILESINDIRECTORY(string path)
	{
	}

	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0xB4A520", Offset = "0xB4A520", VA = "0xB4A520")]
	public static void SetSceneToBuild(int index, string value)
	{
	}

	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0xB4A41C", Offset = "0xB4A41C", VA = "0xB4A41C")]
	private static void DirtyEditor()
	{
	}

	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0xB4AF08", Offset = "0xB4AF08", VA = "0xB4AF08")]
	public UkenSettings()
	{
	}
}
