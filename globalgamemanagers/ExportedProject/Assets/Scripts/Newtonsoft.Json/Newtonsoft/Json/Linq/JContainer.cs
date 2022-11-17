using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000CC")]
	[Preserve]
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, IList, ICollection
	{
		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F040", Offset = "0x80F040")]
		private sealed class _003CGetDescendants_003Ed__29 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[Token(Token = "0x40002EB")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40002EC")]
			[FieldOffset(Offset = "0x18")]
			private JToken _003C_003E2__current;

			[Token(Token = "0x40002ED")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x40002EE")]
			[FieldOffset(Offset = "0x24")]
			private bool self;

			[Token(Token = "0x40002EF")]
			[FieldOffset(Offset = "0x25")]
			public bool _003C_003E3__self;

			[Token(Token = "0x40002F0")]
			[FieldOffset(Offset = "0x28")]
			public JContainer _003C_003E4__this;

			[Token(Token = "0x40002F1")]
			[FieldOffset(Offset = "0x30")]
			private JToken _003Co_003E5__1;

			[Token(Token = "0x40002F2")]
			[FieldOffset(Offset = "0x38")]
			private IEnumerator<JToken> _003C_003E7__wrap1;

			[Token(Token = "0x40002F3")]
			[FieldOffset(Offset = "0x40")]
			private IEnumerator<JToken> _003C_003E7__wrap2;

			[Token(Token = "0x1700011B")]
			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[Token(Token = "0x6000605")]
				[Address(RVA = "0xFEFCF0", Offset = "0xFEFCF0", VA = "0xFEFCF0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000607")]
				[Address(RVA = "0xFEFD60", Offset = "0xFEFD60", VA = "0xFEFD60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0xFECC68", Offset = "0xFECC68", VA = "0xFECC68")]
			[DebuggerHidden]
			public _003CGetDescendants_003Ed__29(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0xFEF634", Offset = "0xFEF634", VA = "0xFEF634", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0xFEF830", Offset = "0xFEF830", VA = "0xFEF830", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0xFEF770", Offset = "0xFEF770", VA = "0xFEF770")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0xFEF6B0", Offset = "0xFEF6B0", VA = "0xFEF6B0")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0xFEFCF8", Offset = "0xFEFCF8", VA = "0xFEFCF8", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0xFEFD68", Offset = "0xFEFD68", VA = "0xFEFD68", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0xFEFE30", Offset = "0xFEFE30", VA = "0xFEFE30", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x30")]
		internal ListChangedEventHandler _listChanged;

		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x38")]
		private object _syncRoot;

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x40")]
		private bool _busy;

		[Token(Token = "0x1700010F")]
		protected abstract IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x60005C3")]
			get;
		}

		[Token(Token = "0x17000110")]
		public override bool HasValues
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xFEC7D4", Offset = "0xFEC7D4", VA = "0xFEC7D4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000111")]
		public override JToken First
		{
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xFEC8A4", Offset = "0xFEC8A4", VA = "0xFEC8A4", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000112")]
		public override JToken Last
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xFEC9F8", Offset = "0xFEC9F8", VA = "0xFEC9F8", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000113")]
		private JToken System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EItem
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xFEF2C4", Offset = "0xFEF2C4", VA = "0xFEF2C4", Slot = "20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xFEF2D4", Offset = "0xFEF2D4", VA = "0xFEF2D4", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIsReadOnly
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xFEF324", Offset = "0xFEF324", VA = "0xFEF324", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000115")]
		private bool System_002ECollections_002EIList_002EIsFixedSize
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xFEF4FC", Offset = "0xFEF4FC", VA = "0xFEF4FC", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000116")]
		private bool System_002ECollections_002EIList_002EIsReadOnly
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xFEF504", Offset = "0xFEF504", VA = "0xFEF504", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		private object System_002ECollections_002EIList_002EItem
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0xFEF550", Offset = "0xFEF550", VA = "0xFEF550", Slot = "32")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xFEF560", Offset = "0xFEF560", VA = "0xFEF560", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public int Count
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xFEE5C4", Offset = "0xFEE5C4", VA = "0xFEE5C4", Slot = "44")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000119")]
		private bool System_002ECollections_002EICollection_002EIsSynchronized
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xFEF5B0", Offset = "0xFEF5B0", VA = "0xFEF5B0", Slot = "46")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011A")]
		private object System_002ECollections_002EICollection_002ESyncRoot
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xFEF5B8", Offset = "0xFEF5B8", VA = "0xFEF5B8", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xFEA3EC", Offset = "0xFEA3EC", VA = "0xFEA3EC")]
		internal JContainer()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xFEA4D0", Offset = "0xFEA4D0", VA = "0xFEA4D0")]
		internal JContainer(JContainer other)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xFEC674", Offset = "0xFEC674", VA = "0xFEC674")]
		internal void CheckReentrancy()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xFEC758", Offset = "0xFEC758", VA = "0xFEC758", Slot = "48")]
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xFEA8C4", Offset = "0xFEA8C4", VA = "0xFEA8C4")]
		internal bool ContentsEqual(JContainer container)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xFECB4C", Offset = "0xFECB4C", VA = "0xFECB4C", Slot = "17")]
		public override JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xFECBC8", Offset = "0xFECBC8", VA = "0xFECBC8")]
		public IEnumerable<JToken> Descendants()
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xFECBD0", Offset = "0xFECBD0", VA = "0xFECBD0")]
		internal IEnumerable<JToken> GetDescendants(bool self)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xFECCB8", Offset = "0xFECCB8", VA = "0xFECCB8")]
		internal bool IsMultiContent(object content)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xFECD80", Offset = "0xFECD80", VA = "0xFECD80")]
		internal JToken EnsureParentToken(JToken item, bool skipParentCheck)
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		internal abstract int IndexOfItem(JToken item);

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xFECE2C", Offset = "0xFECE2C", VA = "0xFECE2C", Slot = "50")]
		internal virtual void InsertItem(int index, JToken item, bool skipParentCheck)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xFED250", Offset = "0xFED250", VA = "0xFED250", Slot = "51")]
		internal virtual void RemoveItemAt(int index)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xFED6D0", Offset = "0xFED6D0", VA = "0xFED6D0", Slot = "52")]
		internal virtual bool RemoveItem(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xFED728", Offset = "0xFED728", VA = "0xFED728", Slot = "53")]
		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xFED7FC", Offset = "0xFED7FC", VA = "0xFED7FC", Slot = "54")]
		internal virtual void SetItem(int index, JToken item)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xFEDDC8", Offset = "0xFEDDC8", VA = "0xFEDDC8", Slot = "55")]
		internal virtual void ClearItems()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xFEE170", Offset = "0xFEE170", VA = "0xFEE170", Slot = "56")]
		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xFEE1D8", Offset = "0xFEE1D8", VA = "0xFEE1D8", Slot = "57")]
		internal virtual bool ContainsItem(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xFEE200", Offset = "0xFEE200", VA = "0xFEE200", Slot = "58")]
		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xFEDCEC", Offset = "0xFEDCEC", VA = "0xFEDCEC")]
		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xFEE688", Offset = "0xFEE688", VA = "0xFEE688", Slot = "59")]
		internal virtual void ValidateToken(JToken o, JToken existing)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xFEE7CC", Offset = "0xFEE7CC", VA = "0xFEE7CC", Slot = "60")]
		public virtual void Add(object content)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xFEE8B0", Offset = "0xFEE8B0", VA = "0xFEE8B0")]
		internal void AddAndSkipParentCheck(JToken token)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xFEC2B0", Offset = "0xFEC2B0", VA = "0xFEC2B0")]
		internal void AddInternal(int index, object content, bool skipParentCheck)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xFEE994", Offset = "0xFEE994", VA = "0xFEE994")]
		internal static JToken CreateFromContent(object content)
		{
			return null;
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xFEEA34", Offset = "0xFEEA34", VA = "0xFEEA34")]
		public void RemoveAll()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xFEB008", Offset = "0xFEB008", VA = "0xFEB008")]
		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xFEEA44", Offset = "0xFEEA44", VA = "0xFEEA44")]
		internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xFEB598", Offset = "0xFEB598", VA = "0xFEB598")]
		internal int ContentsHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xFEF290", Offset = "0xFEF290", VA = "0xFEF290", Slot = "22")]
		private int System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIndexOf(JToken item)
		{
			return default(int);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xFEF2A0", Offset = "0xFEF2A0", VA = "0xFEF2A0", Slot = "23")]
		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EInsert(int index, JToken item)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xFEF2B4", Offset = "0xFEF2B4", VA = "0xFEF2B4", Slot = "24")]
		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemoveAt(int index)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xFEF2E4", Offset = "0xFEF2E4", VA = "0xFEF2E4", Slot = "27")]
		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EAdd(JToken item)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xFEF2F4", Offset = "0xFEF2F4", VA = "0xFEF2F4", Slot = "28")]
		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EClear()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xFEF304", Offset = "0xFEF304", VA = "0xFEF304", Slot = "29")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EContains(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xFEF314", Offset = "0xFEF314", VA = "0xFEF314", Slot = "30")]
		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECopyTo(JToken[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xFEF32C", Offset = "0xFEF32C", VA = "0xFEF32C", Slot = "31")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemove(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xFEF33C", Offset = "0xFEF33C", VA = "0xFEF33C")]
		private JToken EnsureValue(object value)
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xFEF3FC", Offset = "0xFEF3FC", VA = "0xFEF3FC", Slot = "34")]
		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xFEF440", Offset = "0xFEF440", VA = "0xFEF440", Slot = "36")]
		private void System_002ECollections_002EIList_002EClear()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xFEF450", Offset = "0xFEF450", VA = "0xFEF450", Slot = "35")]
		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xFEF484", Offset = "0xFEF484", VA = "0xFEF484", Slot = "39")]
		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xFEF4B8", Offset = "0xFEF4B8", VA = "0xFEF4B8", Slot = "40")]
		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xFEF50C", Offset = "0xFEF50C", VA = "0xFEF50C", Slot = "41")]
		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xFEF540", Offset = "0xFEF540", VA = "0xFEF540", Slot = "42")]
		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xFEF5A0", Offset = "0xFEF5A0", VA = "0xFEF5A0", Slot = "43")]
		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}
	}
}
