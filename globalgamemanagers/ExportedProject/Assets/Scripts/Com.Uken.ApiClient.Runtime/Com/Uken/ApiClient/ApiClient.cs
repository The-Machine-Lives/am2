using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace Com.Uken.ApiClient
{
	[Token(Token = "0x2000002")]
	public abstract class ApiClient
	{
		[Token(Token = "0x2000003")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815E50", Offset = "0x815E50")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x4000002")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<Dictionary<string, string>, long, string> error;

			[Token(Token = "0x6000008")]
			[Address(RVA = "0x17FA4F0", Offset = "0x17FA4F0", VA = "0x17FA4F0")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000009")]
			[Address(RVA = "0x17FB20C", Offset = "0x17FB20C", VA = "0x17FB20C")]
			internal void _003CRequest_003Eb__0(string errorMessage)
			{
			}
		}

		[Token(Token = "0x2000004")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815E60", Offset = "0x815E60")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x4000003")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<string> success;

			[Token(Token = "0x4000004")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<long, string> error;

			[Token(Token = "0x600000A")]
			[Address(RVA = "0x17FA930", Offset = "0x17FA930", VA = "0x17FA930")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600000B")]
			[Address(RVA = "0x17FB2A8", Offset = "0x17FB2A8", VA = "0x17FB2A8")]
			internal void _003CRequest_003Eb__0(Dictionary<string, string> headers, string responseText)
			{
			}

			[Token(Token = "0x600000C")]
			[Address(RVA = "0x17FB318", Offset = "0x17FB318", VA = "0x17FB318")]
			internal void _003CRequest_003Eb__1(Dictionary<string, string> headers, long statusCode, string responseText)
			{
			}
		}

		[Token(Token = "0x2000005")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815E70", Offset = "0x815E70")]
		private sealed class _003CCoroutineRequest_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000005")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000007")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RetrySettings retrySettings;

			[Token(Token = "0x4000008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ApiClient _003C_003E4__this;

			[Token(Token = "0x4000009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RequestMethod method;

			[Token(Token = "0x400000A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string path;

			[Token(Token = "0x400000B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Dictionary<string, object> requestHttpHeaders;

			[Token(Token = "0x400000C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public object data;

			[Token(Token = "0x400000D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool serializeDataToJson;

			[Token(Token = "0x400000E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
			public bool binary;

			[Token(Token = "0x400000F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Action<Dictionary<string, string>, byte[]> success;

			[Token(Token = "0x4000010")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action<Dictionary<string, string>, long, byte[]> error;

			[Token(Token = "0x4000011")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int _003CretryCount_003E5__2;

			[Token(Token = "0x4000012")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private UnityWebRequest _003Crequest_003E5__3;

			[Token(Token = "0x17000002")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000010")]
				[Address(RVA = "0x17FB924", Offset = "0x17FB924", VA = "0x17FB924", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000003")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000012")]
				[Address(RVA = "0x17FB994", Offset = "0x17FB994", VA = "0x17FB994", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600000D")]
			[Address(RVA = "0x17FB1E0", Offset = "0x17FB1E0", VA = "0x17FB1E0")]
			[DebuggerHidden]
			public _003CCoroutineRequest_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600000E")]
			[Address(RVA = "0x17FB390", Offset = "0x17FB390", VA = "0x17FB390", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600000F")]
			[Address(RVA = "0x17FB394", Offset = "0x17FB394", VA = "0x17FB394", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0x17FB92C", Offset = "0x17FB92C", VA = "0x17FB92C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IApiConfig config;

		[Token(Token = "0x17000001")]
		protected IApiConfig Config
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x17FA334", Offset = "0x17FA334", VA = "0x17FA334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x17FA308", Offset = "0x17FA308", VA = "0x17FA308")]
		protected ApiClient(IApiConfig config)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x17FA33C", Offset = "0x17FA33C", VA = "0x17FA33C")]
		protected void Request(RequestMethod method, string path, object data, Action<Dictionary<string, string>, string> success, Action<Dictionary<string, string>, long, string> error, [Optional] Dictionary<string, object> httpHeaders, [Optional] RetrySettings retrySettings)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x17FA7E8", Offset = "0x17FA7E8", VA = "0x17FA7E8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x815EE0", Offset = "0x815EE0")]
		protected void Request(RequestMethod method, string path, object data, Action<string> success, Action<long, string> error, [Optional] Dictionary<string, object> httpHeaders, [Optional] RetrySettings retrySettings)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x17FA938", Offset = "0x17FA938", VA = "0x17FA938")]
		private UnityWebRequest FormRequest(RequestMethod method, string path, Dictionary<string, object> requestHttpHeaders, object data, bool serializeDataToJson = true, bool binary = false)
		{
			return null;
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x17FA664", Offset = "0x17FA664", VA = "0x17FA664")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x815F18", Offset = "0x815F18")]
		private IEnumerator CoroutineRequest(RequestMethod method, string path, Dictionary<string, object> requestHttpHeaders, object data, Action<Dictionary<string, string>, byte[]> success, Action<Dictionary<string, string>, long, byte[]> error, bool serializeDataToJson = true, bool binary = false, [Optional] RetrySettings retrySettings)
		{
			return null;
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x17FACCC", Offset = "0x17FACCC", VA = "0x17FACCC")]
		private string ConstructRequestUrl(string requestPath)
		{
			return null;
		}
	}
}
