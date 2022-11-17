using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Firebase
{
	[Token(Token = "0x2000009")]
	internal class AppUtil
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1796088", Offset = "0x1796088", VA = "0x1796088")]
		internal static void PollCallbacks()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1796410", Offset = "0x1796410", VA = "0x1796410")]
		internal static void AppEnableLogCallback(bool arg0)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1796570", Offset = "0x1796570", VA = "0x1796570")]
		internal static void SetEnabledAllAppCallbacks(bool arg0)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x17966D0", Offset = "0x17966D0", VA = "0x17966D0")]
		internal static void SetEnabledAppCallbackByName(string arg0, bool arg1)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1796860", Offset = "0x1796860", VA = "0x1796860")]
		internal static bool GetEnabledAppCallbackByName(string arg0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x17969E8", Offset = "0x17969E8", VA = "0x17969E8")]
		internal static void SetLogFunction(LogUtil.LogMessageDelegate arg0)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1796B4C", Offset = "0x1796B4C", VA = "0x1796B4C")]
		public static GooglePlayServicesAvailability CheckAndroidDependencies()
		{
			return default(GooglePlayServicesAvailability);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1796CA0", Offset = "0x1796CA0", VA = "0x1796CA0")]
		public static Task FixAndroidDependenciesAsync()
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1797024", Offset = "0x1797024", VA = "0x1797024")]
		internal static void InitializePlayServicesInternal()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x179716C", Offset = "0x179716C", VA = "0x179716C")]
		internal static void TerminatePlayServicesInternal()
		{
		}
	}
}
