using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace Com.Uken.ApiClient
{
	[Token(Token = "0x2000006")]
	public static class ApiClientHelper
	{
		[Token(Token = "0x2000007")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815E80", Offset = "0x815E80")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x10")]
			public Action<Dictionary<string, string>, string> success;

			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x18")]
			public Action<string> parseErrorHandler;

			[Token(Token = "0x600001A")]
			[Address(RVA = "0x17FBF70", Offset = "0x17FBF70", VA = "0x17FBF70")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600001B")]
			[Address(RVA = "0x17FBF80", Offset = "0x17FBF80", VA = "0x17FBF80")]
			internal void _003CCreateSuccessByteArrayWrapper_003Eb__0(Dictionary<string, string> responseHeaders, byte[] byteArray)
			{
			}
		}

		[Token(Token = "0x2000008")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815E90", Offset = "0x815E90")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x10")]
			public Action<Dictionary<string, string>, long, string> error;

			[Token(Token = "0x600001C")]
			[Address(RVA = "0x17FBF78", Offset = "0x17FBF78", VA = "0x17FBF78")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600001D")]
			[Address(RVA = "0x17FC0EC", Offset = "0x17FC0EC", VA = "0x17FC0EC")]
			internal void _003CCreateErrorByteArrayWrapper_003Eb__0(Dictionary<string, string> responseHeaders, long statusCode, byte[] byteArray)
			{
			}
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x17FB03C", Offset = "0x17FB03C", VA = "0x17FB03C")]
		public static void AddHttpHeadersToRequest(Dictionary<string, object> httpHeaders, UnityWebRequest www)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x17FAE80", Offset = "0x17FAE80", VA = "0x17FAE80")]
		public static UnityWebRequest CreateUnityWebRequestWithData(string url, object data, bool serializeDataToJson = true, bool binary = false)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x17FAE6C", Offset = "0x17FAE6C", VA = "0x17FAE6C")]
		public static string CreateGetArguments(object data)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x17FA4F8", Offset = "0x17FA4F8", VA = "0x17FA4F8")]
		public static Action<Dictionary<string, string>, byte[]> CreateSuccessByteArrayWrapper(Action<Dictionary<string, string>, string> success, Action<string> parseErrorHandler)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x17FA5C0", Offset = "0x17FA5C0", VA = "0x17FA5C0")]
		public static Action<Dictionary<string, string>, long, byte[]> CreateErrorByteArrayWrapper(Action<Dictionary<string, string>, long, string> error)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x17FB99C", Offset = "0x17FB99C", VA = "0x17FB99C")]
		private static Dictionary<string, object> GetKeyValues(object data)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x17FBB24", Offset = "0x17FBB24", VA = "0x17FBB24")]
		private static string CreateGetArguments(Dictionary<string, object> keyValues)
		{
			return null;
		}
	}
}
