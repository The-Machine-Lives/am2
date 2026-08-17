using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console.Scripts.UI.Utilities
{
	[Token(Token = "0x2000020")]
	internal static class ScreenshotCapture
	{
		[Token(Token = "0x2000033")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C95C", Offset = "0x81C95C")]
		private sealed class _003CWaitForCapture_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400015E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400015F")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000160")]
			[FieldOffset(Offset = "0x20")]
			public Action<byte[]> screenshotTakenAction;

			[Token(Token = "0x4000161")]
			[FieldOffset(Offset = "0x28")]
			public bool showConsoleAfter;

			[Token(Token = "0x4000162")]
			[FieldOffset(Offset = "0x30")]
			private Texture2D _003Ctexture_003E5__1;

			[Token(Token = "0x17000084")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60001E3")]
				[Address(RVA = "0xE90264", Offset = "0xE90264", VA = "0xE90264", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60001E5")]
				[Address(RVA = "0xE902D4", Offset = "0xE902D4", VA = "0xE902D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xE8FFF4", Offset = "0xE8FFF4", VA = "0xE8FFF4")]
			[DebuggerHidden]
			public _003CWaitForCapture_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xE9012C", Offset = "0xE9012C", VA = "0xE9012C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xE90130", Offset = "0xE90130", VA = "0xE90130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xE9026C", Offset = "0xE9026C", VA = "0xE9026C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE7FDD8", Offset = "0xE7FDD8", VA = "0xE7FDD8")]
		public static void CaptureScreenshot(Settings.SelectedScreenshotCaptureMode captureMode, Action<byte[]> screenshotTakenAction)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE8FB9C", Offset = "0xE8FB9C", VA = "0xE8FB9C")]
		private static void CaptureMainCamera(Action<byte[]> screenshotTakenAction)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE8FE74", Offset = "0xE8FE74", VA = "0xE8FE74")]
		private static void CaptureFullScreen(Action<byte[]> screenshotTakenAction)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xE8FF58", Offset = "0xE8FF58", VA = "0xE8FF58")]
		private static IEnumerator WaitForCapture(Action<byte[]> screenshotTakenAction, bool showConsoleAfter)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xE90020", Offset = "0xE90020", VA = "0xE90020")]
		private static Texture2D CaptureFullScreenTexture()
		{
			return null;
		}
	}
}
