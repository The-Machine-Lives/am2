using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x2000013")]
	internal class Suggestions
	{
		[Token(Token = "0x200002D")]
		private class SuggestionButton
		{
			[Token(Token = "0x400013A")]
			[FieldOffset(Offset = "0x10")]
			private string _input;

			[Token(Token = "0x400013B")]
			[FieldOffset(Offset = "0x18")]
			private bool _automaticallyExecute;

			[Token(Token = "0x400013C")]
			[FieldOffset(Offset = "0x20")]
			private readonly InputField _inputField;

			[Token(Token = "0x400013D")]
			[FieldOffset(Offset = "0x28")]
			private GUIContent _guiContent;

			[Token(Token = "0x400013E")]
			[FieldOffset(Offset = "0x30")]
			private float _width;

			[Token(Token = "0x17000081")]
			public float Width
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0xE910B8", Offset = "0xE910B8", VA = "0xE910B8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000082")]
			public GUIContent Content
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0xE91184", Offset = "0xE91184", VA = "0xE91184")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000083")]
			public string Input
			{
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0xE91390", Offset = "0xE91390", VA = "0xE91390")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xE90FA4", Offset = "0xE90FA4", VA = "0xE90FA4")]
			public SuggestionButton(string label, string input, bool automaticallyExecute, InputField inputField)
			{
			}

			[Token(Token = "0x60001D8")]
			[Address(RVA = "0xE9118C", Offset = "0xE9118C", VA = "0xE9118C")]
			public void Pressed()
			{
			}
		}

		[Token(Token = "0x200002E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C93C", Offset = "0x81C93C")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x400013F")]
			[FieldOffset(Offset = "0x10")]
			public string commandUpToLastParameter;

			[Token(Token = "0x4000140")]
			[FieldOffset(Offset = "0x18")]
			public bool isLastParameter;

			[Token(Token = "0x4000141")]
			[FieldOffset(Offset = "0x19")]
			public bool lastParameterIsParamsArray;

			[Token(Token = "0x4000142")]
			[FieldOffset(Offset = "0x20")]
			public Suggestions _003C_003E4__this;

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xE910B0", Offset = "0xE910B0", VA = "0xE910B0")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xE9128C", Offset = "0xE9128C", VA = "0xE9128C")]
			internal SuggestionButton _003CGenerateParameterSuggestionButtons_003Eb__0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x10")]
		private List<SuggestionButton> _suggestionButtons;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x18")]
		private InputField _inputField;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x20")]
		private string _lastInput;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x28")]
		private bool _firstRun;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xE7AB0C", Offset = "0xE7AB0C", VA = "0xE7AB0C")]
		public Suggestions(InputField inputField)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xE7B50C", Offset = "0xE7B50C", VA = "0xE7B50C")]
		public void Update(bool forceReLayout = false)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xE7DA70", Offset = "0xE7DA70", VA = "0xE7DA70")]
		public void ForceRelayoutNextUpdate()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xE90544", Offset = "0xE90544", VA = "0xE90544")]
		private void GenerateSuggestionButtons()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xE90DD4", Offset = "0xE90DD4", VA = "0xE90DD4")]
		private void GeneratePossibleCommandButtons()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xE90680", Offset = "0xE90680", VA = "0xE90680")]
		private void GenerateParameterSuggestionButtons()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xE909B0", Offset = "0xE909B0", VA = "0xE909B0")]
		private void GenerateRecentCommandButtons()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xE7D2A0", Offset = "0xE7D2A0", VA = "0xE7D2A0")]
		public void Draw(Rect rect)
		{
		}
	}
}
