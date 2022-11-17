using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	[Token(Token = "0x2000259")]
	internal class NativeEventClient : IEventsClient
	{
		[Token(Token = "0x20006AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820998", Offset = "0x820998")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x400202F")]
			[FieldOffset(Offset = "0x10")]
			public Action<ResponseStatus, List<IEvent>> callback;

			[Token(Token = "0x6002E85")]
			[Address(RVA = "0x1338634", Offset = "0x1338634", VA = "0x1338634")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6002E86")]
			[Address(RVA = "0x13387F0", Offset = "0x13387F0", VA = "0x13387F0")]
			internal void _003CFetchAllEvents_003Eb__0(EventManager.FetchAllResponse response)
			{
			}
		}

		[Token(Token = "0x20006AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8209A8", Offset = "0x8209A8")]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			[Token(Token = "0x4002030")]
			[FieldOffset(Offset = "0x10")]
			public Action<ResponseStatus, IEvent> callback;

			[Token(Token = "0x6002E87")]
			[Address(RVA = "0x1338764", Offset = "0x1338764", VA = "0x1338764")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6002E88")]
			[Address(RVA = "0x133890C", Offset = "0x133890C", VA = "0x133890C")]
			internal void _003CFetchEvent_003Eb__0(EventManager.FetchResponse response)
			{
			}
		}

		[Token(Token = "0x4000D04")]
		[FieldOffset(Offset = "0x10")]
		private readonly EventManager mEventManager;

		[Token(Token = "0x6001179")]
		[Address(RVA = "0x1334138", Offset = "0x1334138", VA = "0x1334138")]
		internal NativeEventClient(EventManager manager)
		{
		}

		[Token(Token = "0x600117A")]
		[Address(RVA = "0x13384C4", Offset = "0x13384C4", VA = "0x13384C4", Slot = "4")]
		public void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback)
		{
		}

		[Token(Token = "0x600117B")]
		[Address(RVA = "0x133863C", Offset = "0x133863C", VA = "0x133863C", Slot = "5")]
		public void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback)
		{
		}

		[Token(Token = "0x600117C")]
		[Address(RVA = "0x133876C", Offset = "0x133876C", VA = "0x133876C", Slot = "6")]
		public void IncrementEvent(string eventId, uint stepsToIncrement)
		{
		}
	}
}
