using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Library.Web
{
	[Token(Token = "0x20003DD")]
	public class UkenImageCacher : IDisposable
	{
		[Token(Token = "0x20007B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820FC8", Offset = "0x820FC8")]
		private sealed class _003CStartImageDownload_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4002271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4002272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4002273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x4002274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UkenImageCacher _003C_003E4__this;

			[Token(Token = "0x4002275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pixelsPerUnit;

			[Token(Token = "0x4002276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private WWW _003Cwww_003E5__2;

			[Token(Token = "0x17000815")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60031D1")]
				[Address(RVA = "0xB4256C", Offset = "0xB4256C", VA = "0xB4256C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000816")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60031D3")]
				[Address(RVA = "0xB425DC", Offset = "0xB425DC", VA = "0xB425DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60031CE")]
			[Address(RVA = "0xB416CC", Offset = "0xB416CC", VA = "0xB416CC")]
			[DebuggerHidden]
			public _003CStartImageDownload_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60031CF")]
			[Address(RVA = "0xB41C18", Offset = "0xB41C18", VA = "0xB41C18", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60031D0")]
			[Address(RVA = "0xB41C1C", Offset = "0xB41C1C", VA = "0xB41C1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60031D2")]
			[Address(RVA = "0xB42574", Offset = "0xB42574", VA = "0xB42574", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4001213")]
		private const int KNOWN_INVALID_TEX_HEIGHT = 8;

		[Token(Token = "0x4001214")]
		private const int KNOWN_INVALID_TEX_WIDTH = 8;

		[Token(Token = "0x4001215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_bDisposed;

		[Token(Token = "0x4001216")]
		private const int MAX_CORRUPT_IMAGE_RETRY_ATTEMPTS = 2;

		[Token(Token = "0x4001217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, int> m_corruptImageDownloadRetries;

		[Token(Token = "0x4001218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<string, Sprite> m_cachedImages;

		[Token(Token = "0x4001219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<string, List<Action<bool, Sprite>>> m_waitingCallbacks;

		[Token(Token = "0x6001DD0")]
		[Address(RVA = "0xB40FD8", Offset = "0xB40FD8", VA = "0xB40FD8", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6001DD1")]
		[Address(RVA = "0xB410EC", Offset = "0xB410EC", VA = "0xB410EC", Slot = "1")]
		~UkenImageCacher()
		{
		}

		[Token(Token = "0x6001DD2")]
		[Address(RVA = "0xB4104C", Offset = "0xB4104C", VA = "0xB4104C")]
		private void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6001DD3")]
		[Address(RVA = "0xB413C0", Offset = "0xB413C0", VA = "0xB413C0")]
		public void DownloadImage(string url, [Optional] Action<bool, Sprite> OnDownloadComplete, float pixelsPerUnit = 100f)
		{
		}

		[Token(Token = "0x6001DD4")]
		[Address(RVA = "0xB41618", Offset = "0xB41618", VA = "0xB41618")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838BC8", Offset = "0x838BC8")]
		private IEnumerator StartImageDownload(string url, float pixelsPerUnit = 100f)
		{
			return null;
		}

		[Token(Token = "0x6001DD5")]
		[Address(RVA = "0xB416F8", Offset = "0xB416F8", VA = "0xB416F8")]
		public void DestroyImage(string sURL)
		{
		}

		[Token(Token = "0x6001DD6")]
		[Address(RVA = "0xB41164", Offset = "0xB41164", VA = "0xB41164")]
		public void Clear()
		{
		}

		[Token(Token = "0x6001DD7")]
		[Address(RVA = "0xB41934", Offset = "0xB41934", VA = "0xB41934")]
		private void OnFailedDownload(string url)
		{
		}

		[Token(Token = "0x6001DD8")]
		[Address(RVA = "0xB41B58", Offset = "0xB41B58", VA = "0xB41B58")]
		public UkenImageCacher()
		{
		}
	}
}
