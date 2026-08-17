using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000DC")]
	[Preserve]
	public class JProperty : JContainer
	{
		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x80F220", Offset = "0x80F220")]
		private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
		{
			[Token(Token = "0x20000DE")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F258", Offset = "0x80F258")]
			private sealed class _003CGetEnumerator_003Ed__1 : IEnumerator<JToken>, IDisposable, IEnumerator
			{
				[Token(Token = "0x4000338")]
				[FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x4000339")]
				[FieldOffset(Offset = "0x18")]
				private JToken _003C_003E2__current;

				[Token(Token = "0x400033A")]
				[FieldOffset(Offset = "0x20")]
				public JPropertyList _003C_003E4__this;

				[Token(Token = "0x1700014C")]
				private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
				{
					[Token(Token = "0x600072C")]
					[Address(RVA = "0xFF373C", Offset = "0xFF373C", VA = "0xFF373C", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x1700014D")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x600072E")]
					[Address(RVA = "0xFF37AC", Offset = "0xFF37AC", VA = "0xFF37AC", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x6000729")]
				[Address(RVA = "0xFF3560", Offset = "0xFF3560", VA = "0xFF3560")]
				[DebuggerHidden]
				public _003CGetEnumerator_003Ed__1(int _003C_003E1__state)
				{
				}

				[Token(Token = "0x600072A")]
				[Address(RVA = "0xFF36B4", Offset = "0xFF36B4", VA = "0xFF36B4", Slot = "5")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x600072B")]
				[Address(RVA = "0xFF36B8", Offset = "0xFF36B8", VA = "0xFF36B8", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x600072D")]
				[Address(RVA = "0xFF3744", Offset = "0xFF3744", VA = "0xFF3744", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			[Token(Token = "0x4000337")]
			[FieldOffset(Offset = "0x10")]
			internal JToken _token;

			[Token(Token = "0x17000149")]
			public int Count
			{
				[Token(Token = "0x6000721")]
				[Address(RVA = "0xFF3658", Offset = "0xFF3658", VA = "0xFF3658", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700014A")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6000722")]
				[Address(RVA = "0xFF3668", Offset = "0xFF3668", VA = "0xFF3668", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700014B")]
			public JToken this[int index]
			{
				[Token(Token = "0x6000726")]
				[Address(RVA = "0xFF3690", Offset = "0xFF3690", VA = "0xFF3690", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000727")]
				[Address(RVA = "0xFF36A4", Offset = "0xFF36A4", VA = "0xFF36A4", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0xFF34EC", Offset = "0xFF34EC", VA = "0xFF34EC", Slot = "16")]
			public IEnumerator<JToken> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0xFF358C", Offset = "0xFF358C", VA = "0xFF358C", Slot = "17")]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0xFF3590", Offset = "0xFF3590", VA = "0xFF3590", Slot = "11")]
			public void Add(JToken item)
			{
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0xFF3598", Offset = "0xFF3598", VA = "0xFF3598", Slot = "12")]
			public void Clear()
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0xFF35A0", Offset = "0xFF35A0", VA = "0xFF35A0", Slot = "13")]
			public bool Contains(JToken item)
			{
				return default(bool);
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0xFF35B0", Offset = "0xFF35B0", VA = "0xFF35B0", Slot = "14")]
			public void CopyTo(JToken[] array, int arrayIndex)
			{
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0xFF3638", Offset = "0xFF3638", VA = "0xFF3638", Slot = "15")]
			public bool Remove(JToken item)
			{
				return default(bool);
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0xFF2D58", Offset = "0xFF2D58", VA = "0xFF2D58", Slot = "6")]
			public int IndexOf(JToken item)
			{
				return default(int);
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0xFF3670", Offset = "0xFF3670", VA = "0xFF3670", Slot = "7")]
			public void Insert(int index, JToken item)
			{
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0xFF3680", Offset = "0xFF3680", VA = "0xFF3680", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0xFF27B0", Offset = "0xFF27B0", VA = "0xFF27B0")]
			public JPropertyList()
			{
			}
		}

		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x48")]
		private readonly JPropertyList _content;

		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _name;

		[Token(Token = "0x17000145")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0xFF271C", Offset = "0xFF271C", VA = "0xFF271C", Slot = "47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000146")]
		public string Name
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0xFF0880", Offset = "0xFF0880", VA = "0xFF0880")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000147")]
		public JToken Value
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0xFEEFC8", Offset = "0xFEEFC8", VA = "0xFEEFC8")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			[Token(Token = "0x6000708")]
			[Address(RVA = "0xFF0D14", Offset = "0xFF0D14", VA = "0xFF0D14")]
			set
			{
			}
		}

		[Token(Token = "0x17000148")]
		public override JTokenType Type
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0xFF3130", Offset = "0xFF3130", VA = "0xFF3130", Slot = "12")]
			[DebuggerStepThrough]
			get
			{
				return default(JTokenType);
			}
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xFF2724", Offset = "0xFF2724", VA = "0xFF2724")]
		public JProperty(JProperty other)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xFF27B8", Offset = "0xFF27B8", VA = "0xFF27B8", Slot = "53")]
		internal override JToken GetItem(int index)
		{
			return null;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xFF2854", Offset = "0xFF2854", VA = "0xFF2854", Slot = "54")]
		internal override void SetItem(int index, JToken item)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xFF2B28", Offset = "0xFF2B28", VA = "0xFF2B28", Slot = "52")]
		internal override bool RemoveItem(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xFF2C24", Offset = "0xFF2C24", VA = "0xFF2C24", Slot = "51")]
		internal override void RemoveItemAt(int index)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xFF2D20", Offset = "0xFF2D20", VA = "0xFF2D20", Slot = "49")]
		internal override int IndexOfItem(JToken item)
		{
			return default(int);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xFF2D68", Offset = "0xFF2D68", VA = "0xFF2D68", Slot = "50")]
		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xFF2ED4", Offset = "0xFF2ED4", VA = "0xFF2ED4", Slot = "57")]
		internal override bool ContainsItem(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xFF2F0C", Offset = "0xFF2F0C", VA = "0xFF2F0C", Slot = "55")]
		internal override void ClearItems()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xFF3008", Offset = "0xFF3008", VA = "0xFF3008", Slot = "11")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xFF30D0", Offset = "0xFF30D0", VA = "0xFF30D0", Slot = "10")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xFEF054", Offset = "0xFEF054", VA = "0xFEF054")]
		internal JProperty(string name)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xFF0DA8", Offset = "0xFF0DA8", VA = "0xFF0DA8")]
		public JProperty(string name, object content)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xFF3138", Offset = "0xFF3138", VA = "0xFF3138", Slot = "18")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xFF31D4", Offset = "0xFF31D4", VA = "0xFF31D4", Slot = "19")]
		internal override int GetDeepHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xFF3274", Offset = "0xFF3274", VA = "0xFF3274")]
		public static JProperty Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}
	}
}
