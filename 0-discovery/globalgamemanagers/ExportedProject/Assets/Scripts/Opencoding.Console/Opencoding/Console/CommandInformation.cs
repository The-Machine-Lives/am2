using System.Collections.Generic;
using Il2CppDummyDll;
using Opencoding.CommandHandlerSystem;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x2000009")]
	internal class CommandInformation
	{
		[Token(Token = "0x200002B")]
		private class ParameterEntry
		{
			[Token(Token = "0x4000136")]
			[FieldOffset(Offset = "0x10")]
			public List<KeyValuePair<GUIContent, GUIStyle>> _Items;

			[Token(Token = "0x4000137")]
			[FieldOffset(Offset = "0x18")]
			public float _Width;

			[Token(Token = "0x60001CF")]
			[Address(RVA = "0xE786C0", Offset = "0xE786C0", VA = "0xE786C0")]
			public void Add(string text, GUIStyle style)
			{
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xE78650", Offset = "0xE78650", VA = "0xE78650")]
			public ParameterEntry()
			{
			}
		}

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x10")]
		private readonly InputField _inputField;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<ParameterEntry> _parameterEntries;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x20")]
		private CommandHandler _lastCommand;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x28")]
		private int _lastCurrentParameterIndex;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x30")]
		private DebugConsole _debugConsole;

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xE76FFC", Offset = "0xE76FFC", VA = "0xE76FFC")]
		public CommandInformation(DebugConsole debugConsole, InputField inputField)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xE77088", Offset = "0xE77088", VA = "0xE77088")]
		public Vector2 OnGUI()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xE771CC", Offset = "0xE771CC", VA = "0xE771CC")]
		private Vector2 DrawDescription(Vector2 topLeft)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xE77480", Offset = "0xE77480", VA = "0xE77480")]
		private Vector2 DrawParameterList(Vector2 topLeft)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xE77E90", Offset = "0xE77E90", VA = "0xE77E90")]
		private float DrawPropertyCommandParameterList(Vector2 topLeft, CommandHandler exactlyMatchingCommand)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE77734", Offset = "0xE77734", VA = "0xE77734")]
		private float DrawMethodCommandParameterList(Vector2 topLeft, CommandHandler exactlyMatchingCommand)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xE78170", Offset = "0xE78170", VA = "0xE78170")]
		private void RegenerateMethodCommandParameterList(CommandHandler commandHandler)
		{
		}
	}
}
