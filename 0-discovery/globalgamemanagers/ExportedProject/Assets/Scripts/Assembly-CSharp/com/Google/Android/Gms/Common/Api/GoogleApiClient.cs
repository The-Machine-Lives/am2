using System;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Common.Api
{
	[Token(Token = "0x2000240")]
	public class GoogleApiClient : JavaObjWrapper
	{
		[Token(Token = "0x4000CA7")]
		private const string CLASS_NAME = "com/google/android/gms/common/api/GoogleApiClient";

		[Token(Token = "0x600103C")]
		[Address(RVA = "0xA4CA84", Offset = "0xA4CA84", VA = "0xA4CA84")]
		public GoogleApiClient(IntPtr ptr)
		{
		}

		[Token(Token = "0x600103D")]
		[Address(RVA = "0xA4CA8C", Offset = "0xA4CA8C", VA = "0xA4CA8C")]
		public GoogleApiClient()
		{
		}

		[Token(Token = "0x600103E")]
		[Address(RVA = "0xA4CAE0", Offset = "0xA4CAE0", VA = "0xA4CAE0")]
		public object getContext()
		{
			return null;
		}

		[Token(Token = "0x600103F")]
		[Address(RVA = "0xA4CB5C", Offset = "0xA4CB5C", VA = "0xA4CB5C")]
		public void connect()
		{
		}

		[Token(Token = "0x6001040")]
		[Address(RVA = "0xA4CBD0", Offset = "0xA4CBD0", VA = "0xA4CBD0")]
		public void disconnect()
		{
		}

		[Token(Token = "0x6001041")]
		[Address(RVA = "0xA4CC44", Offset = "0xA4CC44", VA = "0xA4CC44")]
		public void dump(string arg_string_1, object arg_object_2, object arg_object_3, string[] arg_string_4)
		{
		}

		[Token(Token = "0x6001042")]
		[Address(RVA = "0xA4CE0C", Offset = "0xA4CE0C", VA = "0xA4CE0C")]
		public ConnectionResult blockingConnect(long arg_long_1, object arg_object_2)
		{
			return null;
		}

		[Token(Token = "0x6001043")]
		[Address(RVA = "0xA4CF68", Offset = "0xA4CF68", VA = "0xA4CF68")]
		public ConnectionResult blockingConnect()
		{
			return null;
		}

		[Token(Token = "0x6001044")]
		[Address(RVA = "0xA4CFE4", Offset = "0xA4CFE4", VA = "0xA4CFE4")]
		public PendingResult<Status> clearDefaultAccountAndReconnect()
		{
			return null;
		}

		[Token(Token = "0x6001045")]
		[Address(RVA = "0xA4D060", Offset = "0xA4D060", VA = "0xA4D060")]
		public ConnectionResult getConnectionResult(object arg_object_1)
		{
			return null;
		}

		[Token(Token = "0x6001046")]
		[Address(RVA = "0xA4D144", Offset = "0xA4D144", VA = "0xA4D144")]
		public int getSessionId()
		{
			return default(int);
		}

		[Token(Token = "0x6001047")]
		[Address(RVA = "0xA4D1C0", Offset = "0xA4D1C0", VA = "0xA4D1C0")]
		public bool isConnecting()
		{
			return default(bool);
		}

		[Token(Token = "0x6001048")]
		[Address(RVA = "0xA4D23C", Offset = "0xA4D23C", VA = "0xA4D23C")]
		public bool isConnectionCallbacksRegistered(object arg_object_1)
		{
			return default(bool);
		}

		[Token(Token = "0x6001049")]
		[Address(RVA = "0xA4D320", Offset = "0xA4D320", VA = "0xA4D320")]
		public bool isConnectionFailedListenerRegistered(object arg_object_1)
		{
			return default(bool);
		}

		[Token(Token = "0x600104A")]
		[Address(RVA = "0xA4D404", Offset = "0xA4D404", VA = "0xA4D404")]
		public void reconnect()
		{
		}

		[Token(Token = "0x600104B")]
		[Address(RVA = "0xA4D478", Offset = "0xA4D478", VA = "0xA4D478")]
		public void registerConnectionCallbacks(object arg_object_1)
		{
		}

		[Token(Token = "0x600104C")]
		[Address(RVA = "0xA4D554", Offset = "0xA4D554", VA = "0xA4D554")]
		public void registerConnectionFailedListener(object arg_object_1)
		{
		}

		[Token(Token = "0x600104D")]
		[Address(RVA = "0xA4D630", Offset = "0xA4D630", VA = "0xA4D630")]
		public void stopAutoManage(object arg_object_1)
		{
		}

		[Token(Token = "0x600104E")]
		[Address(RVA = "0xA4D70C", Offset = "0xA4D70C", VA = "0xA4D70C")]
		public void unregisterConnectionCallbacks(object arg_object_1)
		{
		}

		[Token(Token = "0x600104F")]
		[Address(RVA = "0xA4D7E8", Offset = "0xA4D7E8", VA = "0xA4D7E8")]
		public void unregisterConnectionFailedListener(object arg_object_1)
		{
		}

		[Token(Token = "0x6001050")]
		[Address(RVA = "0xA4D8C4", Offset = "0xA4D8C4", VA = "0xA4D8C4")]
		public bool hasConnectedApi(object arg_object_1)
		{
			return default(bool);
		}

		[Token(Token = "0x6001051")]
		[Address(RVA = "0xA4D9A8", Offset = "0xA4D9A8", VA = "0xA4D9A8")]
		public object getLooper()
		{
			return null;
		}

		[Token(Token = "0x6001052")]
		[Address(RVA = "0xA4DA24", Offset = "0xA4DA24", VA = "0xA4DA24")]
		public bool isConnected()
		{
			return default(bool);
		}
	}
}
