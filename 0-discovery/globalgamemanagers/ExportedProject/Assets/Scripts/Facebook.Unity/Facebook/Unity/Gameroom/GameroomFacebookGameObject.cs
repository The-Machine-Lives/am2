using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Facebook.Unity.Gameroom
{
	[Token(Token = "0x200006B")]
	internal class GameroomFacebookGameObject : FacebookGameObject, IFacebookCallbackHandler
	{
		[Token(Token = "0x200006C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816120", Offset = "0x816120")]
		private sealed class _003CWaitForPipeResponse_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A1")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000A2")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000A3")]
			[FieldOffset(Offset = "0x20")]
			public GameroomFacebookGameObject _003C_003E4__this;

			[Token(Token = "0x40000A4")]
			[FieldOffset(Offset = "0x28")]
			public GameroomFacebook.OnComplete onCompleteDelegate;

			[Token(Token = "0x40000A5")]
			[FieldOffset(Offset = "0x30")]
			public string callbackId;

			[Token(Token = "0x1700007E")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600021F")]
				[Address(RVA = "0xCE06F0", Offset = "0xCE06F0", VA = "0xCE06F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000221")]
				[Address(RVA = "0xCE0760", Offset = "0xCE0760", VA = "0xCE0760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0xCE04E8", Offset = "0xCE04E8", VA = "0xCE04E8")]
			[DebuggerHidden]
			public _003CWaitForPipeResponse_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0xCE051C", Offset = "0xCE051C", VA = "0xCE051C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0xCE0520", Offset = "0xCE0520", VA = "0xCE0520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0xCE06F8", Offset = "0xCE06F8", VA = "0xCE06F8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x1700007D")]
		protected IGameroomFacebookImplementation GameroomFacebookImpl
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0xCE0350", Offset = "0xCE0350", VA = "0xCE0350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xCE040C", Offset = "0xCE040C", VA = "0xCE040C")]
		public void WaitForResponse(GameroomFacebook.OnComplete onCompleteDelegate, string callbackId)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xCE04E4", Offset = "0xCE04E4", VA = "0xCE04E4", Slot = "10")]
		protected override void OnAwake()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xCE0438", Offset = "0xCE0438", VA = "0xCE0438")]
		private IEnumerator WaitForPipeResponse(GameroomFacebook.OnComplete onCompleteDelegate, string callbackId)
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xCE0514", Offset = "0xCE0514", VA = "0xCE0514")]
		public GameroomFacebookGameObject()
		{
		}
	}
}
