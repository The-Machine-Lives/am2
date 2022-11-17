using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000264")]
	internal sealed class AndroidPlatformConfiguration : PlatformConfiguration
	{
		[Token(Token = "0x20006FD")]
		private delegate void IntentHandlerInternal(IntPtr intent, IntPtr userData);

		[Token(Token = "0x6001205")]
		[Address(RVA = "0xC72008", Offset = "0xC72008", VA = "0xC72008")]
		private AndroidPlatformConfiguration(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001206")]
		[Address(RVA = "0xC72010", Offset = "0xC72010", VA = "0xC72010")]
		internal void SetActivity(IntPtr activity)
		{
		}

		[Token(Token = "0x6001207")]
		[Address(RVA = "0xC72038", Offset = "0xC72038", VA = "0xC72038")]
		internal void SetOptionalIntentHandlerForUI(Action<IntPtr> intentHandler)
		{
		}

		[Token(Token = "0x6001208")]
		[Address(RVA = "0xC72110", Offset = "0xC72110", VA = "0xC72110")]
		internal void SetOptionalViewForPopups(IntPtr view)
		{
		}

		[Token(Token = "0x6001209")]
		[Address(RVA = "0xC72138", Offset = "0xC72138", VA = "0xC72138", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x600120A")]
		[Address(RVA = "0xC71F84", Offset = "0xC71F84", VA = "0xC71F84")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x835D64", Offset = "0x835D64")]
		private static void InternalIntentHandler(IntPtr intent, IntPtr userData)
		{
		}

		[Token(Token = "0x600120B")]
		[Address(RVA = "0xC72148", Offset = "0xC72148", VA = "0xC72148")]
		internal static AndroidPlatformConfiguration Create()
		{
			return null;
		}
	}
}
