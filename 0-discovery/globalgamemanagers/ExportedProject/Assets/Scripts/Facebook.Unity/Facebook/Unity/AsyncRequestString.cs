using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity
{
	[Token(Token = "0x200004F")]
	internal class AsyncRequestString : MonoBehaviour
	{
		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8160D0", Offset = "0x8160D0")]
		private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncRequestString _003C_003E4__this;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private WWW _003Cwww_003E5__2;

			[Token(Token = "0x17000062")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600017D")]
				[Address(RVA = "0xCC98E4", Offset = "0xCC98E4", VA = "0xCC98E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000063")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600017F")]
				[Address(RVA = "0xCC9954", Offset = "0xCC9954", VA = "0xCC9954", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600017A")]
			[Address(RVA = "0xCC8B64", Offset = "0xCC8B64", VA = "0xCC8B64")]
			[DebuggerHidden]
			public _003CStart_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600017B")]
			[Address(RVA = "0xCC8B98", Offset = "0xCC8B98", VA = "0xCC8B98", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600017C")]
			[Address(RVA = "0xCC8B9C", Offset = "0xCC8B9C", VA = "0xCC8B9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0xCC98EC", Offset = "0xCC98EC", VA = "0xCC98EC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Uri url;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HttpMethod method;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IDictionary<string, string> formData;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWForm query;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FacebookDelegate<IGraphResult> callback;

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xCC8920", Offset = "0xCC8920", VA = "0xCC8920")]
		internal static void Post(Uri url, [Optional] Dictionary<string, string> formData, [Optional] FacebookDelegate<IGraphResult> callback)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xCC89F4", Offset = "0xCC89F4", VA = "0xCC89F4")]
		internal static void Get(Uri url, [Optional] Dictionary<string, string> formData, [Optional] FacebookDelegate<IGraphResult> callback)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xCC8A0C", Offset = "0xCC8A0C", VA = "0xCC8A0C")]
		internal static void Request(Uri url, HttpMethod method, [Optional] WWWForm query, [Optional] FacebookDelegate<IGraphResult> callback)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xCC8938", Offset = "0xCC8938", VA = "0xCC8938")]
		internal static void Request(Uri url, HttpMethod method, [Optional] IDictionary<string, string> formData, [Optional] FacebookDelegate<IGraphResult> callback)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xCC8AF0", Offset = "0xCC8AF0", VA = "0xCC8AF0")]
		internal IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xCC8AC8", Offset = "0xCC8AC8", VA = "0xCC8AC8")]
		internal AsyncRequestString SetUrl(Uri url)
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xCC8AD0", Offset = "0xCC8AD0", VA = "0xCC8AD0")]
		internal AsyncRequestString SetMethod(HttpMethod method)
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xCC8AE8", Offset = "0xCC8AE8", VA = "0xCC8AE8")]
		internal AsyncRequestString SetFormData(IDictionary<string, string> formData)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xCC8AD8", Offset = "0xCC8AD8", VA = "0xCC8AD8")]
		internal AsyncRequestString SetQuery(WWWForm query)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xCC8AE0", Offset = "0xCC8AE0", VA = "0xCC8AE0")]
		internal AsyncRequestString SetCallback(FacebookDelegate<IGraphResult> callback)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xCC8B90", Offset = "0xCC8B90", VA = "0xCC8B90")]
		public AsyncRequestString()
		{
		}
	}
}
