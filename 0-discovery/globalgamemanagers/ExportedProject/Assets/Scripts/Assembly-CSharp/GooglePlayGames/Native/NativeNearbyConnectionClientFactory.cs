using System;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	[Token(Token = "0x200025A")]
	public class NativeNearbyConnectionClientFactory
	{
		[Token(Token = "0x4000D05")]
		[FieldOffset(Offset = "0x0")]
		private static NearbyConnectionsManager sManager;

		[Token(Token = "0x4000D06")]
		[FieldOffset(Offset = "0x8")]
		private static Action<INearbyConnectionClient> sCreationCallback;

		[Token(Token = "0x600117D")]
		[Address(RVA = "0x1338A00", Offset = "0x1338A00", VA = "0x1338A00")]
		internal static NearbyConnectionsManager GetManager()
		{
			return null;
		}

		[Token(Token = "0x600117E")]
		[Address(RVA = "0x1338A58", Offset = "0x1338A58", VA = "0x1338A58")]
		public static void Create(Action<INearbyConnectionClient> callback)
		{
		}

		[Token(Token = "0x600117F")]
		[Address(RVA = "0x1338B20", Offset = "0x1338B20", VA = "0x1338B20")]
		internal static void InitializeFactory()
		{
		}

		[Token(Token = "0x6001180")]
		[Address(RVA = "0x1338D94", Offset = "0x1338D94", VA = "0x1338D94")]
		internal static void OnManagerInitialized(NearbyConnectionsStatus.InitializationStatus status)
		{
		}

		[Token(Token = "0x6001181")]
		[Address(RVA = "0x133906C", Offset = "0x133906C", VA = "0x133906C")]
		public NativeNearbyConnectionClientFactory()
		{
		}
	}
}
