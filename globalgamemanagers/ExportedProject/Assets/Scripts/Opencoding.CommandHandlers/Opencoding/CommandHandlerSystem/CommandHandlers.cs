using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Opencoding.CommandHandlerSystem
{
	[Token(Token = "0x2000003")]
	public static class CommandHandlers
	{
		[Token(Token = "0x2000004")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8184FC", Offset = "0x8184FC")]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x10")]
			public string partialCommand;

			[Token(Token = "0x600001A")]
			[Address(RVA = "0x17E4338", Offset = "0x17E4338", VA = "0x17E4338")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x600001B")]
			[Address(RVA = "0x17E46A4", Offset = "0x17E46A4", VA = "0x17E46A4")]
			internal bool _003CFindMatchingCommands_003Eb__0(CommandHandler x)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000005")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81850C", Offset = "0x81850C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x8")]
			public static Func<CommandHandler, int> _003C_003E9__22_1;

			[Token(Token = "0x600001D")]
			[Address(RVA = "0x17E4650", Offset = "0x17E4650", VA = "0x17E4650")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600001E")]
			[Address(RVA = "0x17E4658", Offset = "0x17E4658", VA = "0x17E4658")]
			internal int _003CFindMatchingCommands_003Eb__22_1(CommandHandler x)
			{
				return default(int);
			}

			[Token(Token = "0x600001F")]
			[Address(RVA = "0x17E4698", Offset = "0x17E4698", VA = "0x17E4698")]
			internal void _003C_002Ecctor_003Eb__60_0(CommandHandler _003Cp0_003E)
			{
			}

			[Token(Token = "0x6000020")]
			[Address(RVA = "0x17E469C", Offset = "0x17E469C", VA = "0x17E469C")]
			internal void _003C_002Ecctor_003Eb__60_1(CommandHandler _003Cp0_003E)
			{
			}

			[Token(Token = "0x6000021")]
			[Address(RVA = "0x17E46A0", Offset = "0x17E46A0", VA = "0x17E46A0")]
			internal void _003C_002Ecctor_003Eb__60_2(CommandHandler _003Cp0_003E)
			{
			}
		}

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, CommandHandler> _commandHandlers;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly HashSet<Type> _registeredCommandHandlers;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		private static Action<CommandHandler> _commandHandlerAdded;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		private static Action<CommandHandler> _commandHandlerRemoved;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x20")]
		private static Action<CommandHandler> _commandExecuted;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x28")]
		public static Func<string, bool> BeforeCommandParsedHook;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x30")]
		public static Func<CommandHandler, string[], bool> BeforeCommandExecutedHook;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x38")]
		public static Func<string, string[], bool> DefaultCommandHandler;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x40")]
		public static string CurrentExecutingCommand;

		[Token(Token = "0x17000005")]
		public static IEnumerable<CommandHandler> Handlers
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x17E3AB4", Offset = "0x17E3AB4", VA = "0x17E3AB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action<CommandHandler> CommandHandlerAdded
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x17E3514", Offset = "0x17E3514", VA = "0x17E3514")]
			add
			{
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x17E3604", Offset = "0x17E3604", VA = "0x17E3604")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event Action<CommandHandler> CommandHandlerRemoved
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x17E36F4", Offset = "0x17E36F4", VA = "0x17E36F4")]
			add
			{
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x17E37E4", Offset = "0x17E37E4", VA = "0x17E37E4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public static event Action<CommandHandler> CommandExecuted
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x17E38D4", Offset = "0x17E38D4", VA = "0x17E38D4")]
			add
			{
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x17E39C4", Offset = "0x17E39C4", VA = "0x17E39C4")]
			remove
			{
			}
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x17E3B38", Offset = "0x17E3B38", VA = "0x17E3B38")]
		public static void HandleCommand(string commandLine)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x17E4098", Offset = "0x17E4098", VA = "0x17E4098")]
		public static CommandHandler FindClosestMatchingCommand(string partialCommand, int index)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x17E4164", Offset = "0x17E4164", VA = "0x17E4164")]
		public static IEnumerable<CommandHandler> FindMatchingCommands(string partialCommand)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x17E4340", Offset = "0x17E4340", VA = "0x17E4340")]
		public static CommandHandler GetCommandHandler(string commandName)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x17E1C84", Offset = "0x17E1C84", VA = "0x17E1C84")]
		public static bool UnregisterCommandHandler(string commandName)
		{
			return default(bool);
		}
	}
}
