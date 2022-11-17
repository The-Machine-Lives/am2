using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Web
{
	[Token(Token = "0x20003E0")]
	public class UkenWebController : UkenController
	{
		[Token(Token = "0x20007B2")]
		public class WwwWrapper
		{
			[Token(Token = "0x2000899")]
			public enum MockResult
			{
				[Token(Token = "0x4002485")]
				SUCCESS = 0,
				[Token(Token = "0x4002486")]
				FAILURE = 1
			}

			[Token(Token = "0x4002277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Queue<MockResult> NextResults;

			[Token(Token = "0x4002278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MockResult mockResult;

			[Token(Token = "0x4002279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UkenWWW Www;

			[Token(Token = "0x60031D8")]
			[Address(RVA = "0xB4573C", Offset = "0xB4573C", VA = "0xB4573C")]
			public WwwWrapper(UkenRequest request)
			{
			}

			[Token(Token = "0x60031D9")]
			[Address(RVA = "0xB45898", Offset = "0xB45898", VA = "0xB45898")]
			public bool isSuccess()
			{
				return default(bool);
			}

			[Token(Token = "0x60031DA")]
			[Address(RVA = "0xB45970", Offset = "0xB45970", VA = "0xB45970")]
			public int status()
			{
				return default(int);
			}
		}

		[Token(Token = "0x20007B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820FD8", Offset = "0x820FD8")]
		private sealed class _003CRequest_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400227A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400227B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400227C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UkenRequest request;

			[Token(Token = "0x400227D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UkenWebController _003C_003E4__this;

			[Token(Token = "0x400227E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private WwwWrapper _003Cwrapper_003E5__2;

			[Token(Token = "0x400227F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private DateTime _003CwwwEnd_003E5__3;

			[Token(Token = "0x17000817")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60031DF")]
				[Address(RVA = "0xB458F8", Offset = "0xB458F8", VA = "0xB458F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000818")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60031E1")]
				[Address(RVA = "0xB45968", Offset = "0xB45968", VA = "0xB45968", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60031DC")]
			[Address(RVA = "0xB450DC", Offset = "0xB450DC", VA = "0xB450DC")]
			[DebuggerHidden]
			public _003CRequest_003Ed__23(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60031DD")]
			[Address(RVA = "0xB45170", Offset = "0xB45170", VA = "0xB45170", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60031DE")]
			[Address(RVA = "0xB45174", Offset = "0xB45174", VA = "0xB45174", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60031E0")]
			[Address(RVA = "0xB45900", Offset = "0xB45900", VA = "0xB45900", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4001231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static double c_timeout;

		[Token(Token = "0x4001232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static UkenWebController _self;

		[Token(Token = "0x4001233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UkenWebConfig Config;

		[Token(Token = "0x4001237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string cookie;

		[Token(Token = "0x4001238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Func<bool> m_isOnline;

		[Token(Token = "0x4001239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Action m_networkStatusPing;

		[Token(Token = "0x1400000B")]
		public event Action<UkenRequest> beforeResponse
		{
			[Token(Token = "0x6001E03")]
			[Address(RVA = "0xB44778", Offset = "0xB44778", VA = "0xB44778")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838CFC", Offset = "0x838CFC")]
			add
			{
			}
			[Token(Token = "0x6001E04")]
			[Address(RVA = "0xB44864", Offset = "0xB44864", VA = "0xB44864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838D0C", Offset = "0x838D0C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event Action<UkenRequest> afterResponse
		{
			[Token(Token = "0x6001E05")]
			[Address(RVA = "0xB44950", Offset = "0xB44950", VA = "0xB44950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838D1C", Offset = "0x838D1C")]
			add
			{
			}
			[Token(Token = "0x6001E06")]
			[Address(RVA = "0xB44A3C", Offset = "0xB44A3C", VA = "0xB44A3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838D2C", Offset = "0x838D2C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event Action<UkenRequest> beforeRequest
		{
			[Token(Token = "0x6001E07")]
			[Address(RVA = "0xB44B28", Offset = "0xB44B28", VA = "0xB44B28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838D3C", Offset = "0x838D3C")]
			add
			{
			}
			[Token(Token = "0x6001E08")]
			[Address(RVA = "0xB44C14", Offset = "0xB44C14", VA = "0xB44C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838D4C", Offset = "0x838D4C")]
			remove
			{
			}
		}

		[Token(Token = "0x6001E02")]
		[Address(RVA = "0xB3E7D4", Offset = "0xB3E7D4", VA = "0xB3E7D4")]
		public static UkenWebController Get()
		{
			return null;
		}

		[Token(Token = "0x6001E09")]
		[Address(RVA = "0xB44D00", Offset = "0xB44D00", VA = "0xB44D00")]
		public UkenWebController(UkenWebConfig config, Func<bool> isOnlineCB, Action networkStatusPing)
		{
		}

		[Token(Token = "0x6001E0A")]
		[Address(RVA = "0xB44D9C", Offset = "0xB44D9C", VA = "0xB44D9C")]
		public void AddBeforeResponseHandler(Action<UkenRequest> handler)
		{
		}

		[Token(Token = "0x6001E0B")]
		[Address(RVA = "0xB44DA0", Offset = "0xB44DA0", VA = "0xB44DA0")]
		public void AddAfterResponseHandler(Action<UkenRequest> handler)
		{
		}

		[Token(Token = "0x6001E0C")]
		[Address(RVA = "0xB44DA4", Offset = "0xB44DA4", VA = "0xB44DA4")]
		public void AddBeforeRequestHandler(Action<UkenRequest> handler)
		{
		}

		[Token(Token = "0x6001E0D")]
		[Address(RVA = "0xB44DA8", Offset = "0xB44DA8", VA = "0xB44DA8")]
		public void AttachCookieToHeader(ref Dictionary<string, string> headers)
		{
		}

		[Token(Token = "0x6001E0E")]
		[Address(RVA = "0xB3E8A0", Offset = "0xB3E8A0", VA = "0xB3E8A0")]
		public void Send(string path, UkenRequestType requestType, [Optional] Dictionary<string, object> parameters, [Optional] Action<bool, UkenRequest> onComplete, [Optional] Dictionary<string, string> headers, bool parseJSONResponse = false)
		{
		}

		[Token(Token = "0x6001E0F")]
		[Address(RVA = "0xB44E6C", Offset = "0xB44E6C", VA = "0xB44E6C")]
		public void MakeAsyncRequest(UkenRequest request)
		{
		}

		[Token(Token = "0x6001E10")]
		[Address(RVA = "0xB45044", Offset = "0xB45044", VA = "0xB45044")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838D5C", Offset = "0x838D5C")]
		public IEnumerator Request(UkenRequest request)
		{
			return null;
		}

		[Token(Token = "0x6001E11")]
		[Address(RVA = "0xB44FE0", Offset = "0xB44FE0", VA = "0xB44FE0")]
		private bool IsOnline()
		{
			return default(bool);
		}

		[Token(Token = "0x6001E12")]
		[Address(RVA = "0xB45108", Offset = "0xB45108", VA = "0xB45108")]
		private void IssueNetworkStatusPing()
		{
		}
	}
}
