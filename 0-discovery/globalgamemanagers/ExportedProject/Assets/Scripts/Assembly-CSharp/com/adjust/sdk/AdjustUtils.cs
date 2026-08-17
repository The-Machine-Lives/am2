using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace com.adjust.sdk
{
	[Token(Token = "0x2000231")]
	public class AdjustUtils
	{
		[Token(Token = "0x4000C6C")]
		[FieldOffset(Offset = "0x0")]
		public static string KeyAdid;

		[Token(Token = "0x4000C6D")]
		[FieldOffset(Offset = "0x8")]
		public static string KeyMessage;

		[Token(Token = "0x4000C6E")]
		[FieldOffset(Offset = "0x10")]
		public static string KeyNetwork;

		[Token(Token = "0x4000C6F")]
		[FieldOffset(Offset = "0x18")]
		public static string KeyAdgroup;

		[Token(Token = "0x4000C70")]
		[FieldOffset(Offset = "0x20")]
		public static string KeyCampaign;

		[Token(Token = "0x4000C71")]
		[FieldOffset(Offset = "0x28")]
		public static string KeyCreative;

		[Token(Token = "0x4000C72")]
		[FieldOffset(Offset = "0x30")]
		public static string KeyWillRetry;

		[Token(Token = "0x4000C73")]
		[FieldOffset(Offset = "0x38")]
		public static string KeyTimestamp;

		[Token(Token = "0x4000C74")]
		[FieldOffset(Offset = "0x40")]
		public static string KeyCallbackId;

		[Token(Token = "0x4000C75")]
		[FieldOffset(Offset = "0x48")]
		public static string KeyEventToken;

		[Token(Token = "0x4000C76")]
		[FieldOffset(Offset = "0x50")]
		public static string KeyClickLabel;

		[Token(Token = "0x4000C77")]
		[FieldOffset(Offset = "0x58")]
		public static string KeyTrackerName;

		[Token(Token = "0x4000C78")]
		[FieldOffset(Offset = "0x60")]
		public static string KeyTrackerToken;

		[Token(Token = "0x4000C79")]
		[FieldOffset(Offset = "0x68")]
		public static string KeyJsonResponse;

		[Token(Token = "0x4000C7A")]
		[FieldOffset(Offset = "0x70")]
		public static string KeyTestOptionsBaseUrl;

		[Token(Token = "0x4000C7B")]
		[FieldOffset(Offset = "0x78")]
		public static string KeyTestOptionsGdprUrl;

		[Token(Token = "0x4000C7C")]
		[FieldOffset(Offset = "0x80")]
		public static string KeyTestOptionsBasePath;

		[Token(Token = "0x4000C7D")]
		[FieldOffset(Offset = "0x88")]
		public static string KeyTestOptionsGdprPath;

		[Token(Token = "0x4000C7E")]
		[FieldOffset(Offset = "0x90")]
		public static string KeyTestOptionsDeleteState;

		[Token(Token = "0x4000C7F")]
		[FieldOffset(Offset = "0x98")]
		public static string KeyTestOptionsUseTestConnectionOptions;

		[Token(Token = "0x4000C80")]
		[FieldOffset(Offset = "0xA0")]
		public static string KeyTestOptionsTimerIntervalInMilliseconds;

		[Token(Token = "0x4000C81")]
		[FieldOffset(Offset = "0xA8")]
		public static string KeyTestOptionsTimerStartInMilliseconds;

		[Token(Token = "0x4000C82")]
		[FieldOffset(Offset = "0xB0")]
		public static string KeyTestOptionsSessionIntervalInMilliseconds;

		[Token(Token = "0x4000C83")]
		[FieldOffset(Offset = "0xB8")]
		public static string KeyTestOptionsSubsessionIntervalInMilliseconds;

		[Token(Token = "0x4000C84")]
		[FieldOffset(Offset = "0xC0")]
		public static string KeyTestOptionsTeardown;

		[Token(Token = "0x4000C85")]
		[FieldOffset(Offset = "0xC8")]
		public static string KeyTestOptionsNoBackoffWait;

		[Token(Token = "0x4000C86")]
		[FieldOffset(Offset = "0xD0")]
		public static string KeyTestOptionsiAdFrameworkEnabled;

		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x177B384", Offset = "0x177B384", VA = "0x177B384")]
		public static int ConvertLogLevel(AdjustLogLevel? logLevel)
		{
			return default(int);
		}

		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x177B3F8", Offset = "0x177B3F8", VA = "0x177B3F8")]
		public static int ConvertBool(bool? value)
		{
			return default(int);
		}

		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x177B470", Offset = "0x177B470", VA = "0x177B470")]
		public static double ConvertDouble(double? value)
		{
			return default(double);
		}

		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x177B4EC", Offset = "0x177B4EC", VA = "0x177B4EC")]
		public static long ConvertLong(long? value)
		{
			return default(long);
		}

		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x177B568", Offset = "0x177B568", VA = "0x177B568")]
		public static string ConvertListToJson(List<string> list)
		{
			return null;
		}

		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x1779EB8", Offset = "0x1779EB8", VA = "0x1779EB8")]
		public static string GetJsonResponseCompact(Dictionary<string, object> dictionary)
		{
			return null;
		}

		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0x1778A94", Offset = "0x1778A94", VA = "0x1778A94")]
		public static string GetJsonString(JSONNode node, string key)
		{
			return null;
		}

		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0x17797EC", Offset = "0x17797EC", VA = "0x17797EC")]
		public static void WriteJsonResponseDictionary(JSONClass jsonObject, Dictionary<string, object> output)
		{
		}

		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0x1778CE0", Offset = "0x1778CE0", VA = "0x1778CE0")]
		public static string TryGetValue(Dictionary<string, string> dictionary, string key)
		{
			return null;
		}

		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0x177B80C", Offset = "0x177B80C", VA = "0x177B80C")]
		public static AndroidJavaObject TestOptionsMap2AndroidJavaObject(Dictionary<string, string> testOptionsMap, AndroidJavaObject ajoCurrentActivity)
		{
			return null;
		}

		[Token(Token = "0x6000FA0")]
		[Address(RVA = "0x177C650", Offset = "0x177C650", VA = "0x177C650")]
		public AdjustUtils()
		{
		}
	}
}
