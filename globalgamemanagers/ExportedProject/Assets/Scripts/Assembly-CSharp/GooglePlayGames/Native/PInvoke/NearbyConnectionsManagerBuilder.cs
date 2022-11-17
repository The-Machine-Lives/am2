using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000289")]
	internal class NearbyConnectionsManagerBuilder : BaseReferenceHolder
	{
		[Token(Token = "0x6001375")]
		[Address(RVA = "0xE6056C", Offset = "0xE6056C", VA = "0xE6056C")]
		internal NearbyConnectionsManagerBuilder()
		{
		}

		[Token(Token = "0x6001376")]
		[Address(RVA = "0xE605E8", Offset = "0xE605E8", VA = "0xE605E8")]
		internal NearbyConnectionsManagerBuilder SetOnInitializationFinished(Action<NearbyConnectionsStatus.InitializationStatus> callback)
		{
			return null;
		}

		[Token(Token = "0x6001377")]
		[Address(RVA = "0xE603AC", Offset = "0xE603AC", VA = "0xE603AC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836750", Offset = "0x836750")]
		private static void InternalOnInitializationFinishedCallback(NearbyConnectionsStatus.InitializationStatus status, IntPtr userData)
		{
		}

		[Token(Token = "0x6001378")]
		[Address(RVA = "0xE607BC", Offset = "0xE607BC", VA = "0xE607BC")]
		internal NearbyConnectionsManagerBuilder SetLocalClientId(long localClientId)
		{
			return null;
		}

		[Token(Token = "0x6001379")]
		[Address(RVA = "0xE607F4", Offset = "0xE607F4", VA = "0xE607F4")]
		internal NearbyConnectionsManagerBuilder SetDefaultLogLevel(Types.LogLevel minLevel)
		{
			return null;
		}

		[Token(Token = "0x600137A")]
		[Address(RVA = "0xE6082C", Offset = "0xE6082C", VA = "0xE6082C")]
		internal NearbyConnectionsManager Build(PlatformConfiguration configuration)
		{
			return null;
		}

		[Token(Token = "0x600137B")]
		[Address(RVA = "0xE608E0", Offset = "0xE608E0", VA = "0xE608E0", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}
	}
}
