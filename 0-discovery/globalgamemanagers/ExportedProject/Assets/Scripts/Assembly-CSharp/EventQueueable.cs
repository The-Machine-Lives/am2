using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200008E")]
public class EventQueueable<T>
{
	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821DF8", Offset = "0x821DF8")]
	private int _003CmaxEvents_003Ek__BackingField;

	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x0")]
	protected Queue<T> m_events;

	[Token(Token = "0x1700004B")]
	public int maxEvents
	{
		[Token(Token = "0x60002AF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833B3C", Offset = "0x833B3C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833B4C", Offset = "0x833B4C")]
		set
		{
		}
	}

	[Token(Token = "0x60002B1")]
	public void AddEvent(T inEvent)
	{
	}

	[Token(Token = "0x60002B2")]
	public Queue<T> ConsumeEvents()
	{
		return null;
	}

	[Token(Token = "0x60002B3")]
	public EventQueueable()
	{
	}
}
