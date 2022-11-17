using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Events
{
	[Token(Token = "0x2000307")]
	public interface IEventsClient
	{
		[Token(Token = "0x60017C5")]
		void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback);

		[Token(Token = "0x60017C6")]
		void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback);

		[Token(Token = "0x60017C7")]
		void IncrementEvent(string eventId, uint stepsToIncrement);
	}
}
