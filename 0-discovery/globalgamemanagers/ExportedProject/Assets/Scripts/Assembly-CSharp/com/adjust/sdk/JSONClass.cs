using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace com.adjust.sdk
{
	[Token(Token = "0x2000220")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x81EA60", Offset = "0x81EA60")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000674")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8206D8", Offset = "0x8206D8")]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			[Token(Token = "0x4001FC8")]
			[FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x6002DEE")]
			[Address(RVA = "0x177E9C0", Offset = "0x177E9C0", VA = "0x177E9C0")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6002DEF")]
			[Address(RVA = "0x177F720", Offset = "0x177F720", VA = "0x177F720")]
			internal bool _003CRemove_003Eb__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000675")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8206E8", Offset = "0x8206E8")]
		private sealed class _003Cget_Childs_003Ed__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001FC9")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001FCA")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode _003C_003E2__current;

			[Token(Token = "0x4001FCB")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4001FCC")]
			[FieldOffset(Offset = "0x28")]
			public JSONClass _003C_003E4__this;

			[Token(Token = "0x4001FCD")]
			[FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x170007F7")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x6002DF4")]
				[Address(RVA = "0x177FC30", Offset = "0x177FC30", VA = "0x177FC30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170007F8")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6002DF6")]
				[Address(RVA = "0x177FCA0", Offset = "0x177FCA0", VA = "0x177FCA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6002DF0")]
			[Address(RVA = "0x177EA4C", Offset = "0x177EA4C", VA = "0x177EA4C")]
			[DebuggerHidden]
			public _003Cget_Childs_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6002DF1")]
			[Address(RVA = "0x177FA18", Offset = "0x177FA18", VA = "0x177FA18", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6002DF2")]
			[Address(RVA = "0x177FA8C", Offset = "0x177FA8C", VA = "0x177FA8C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6002DF3")]
			[Address(RVA = "0x177FA34", Offset = "0x177FA34", VA = "0x177FA34")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6002DF5")]
			[Address(RVA = "0x177FC38", Offset = "0x177FC38", VA = "0x177FC38", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6002DF7")]
			[Address(RVA = "0x177FCA8", Offset = "0x177FCA8", VA = "0x177FCA8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6002DF8")]
			[Address(RVA = "0x177FD58", Offset = "0x177FD58", VA = "0x177FD58", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000676")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8206F8", Offset = "0x8206F8")]
		private sealed class _003CGetEnumerator_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001FCE")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001FCF")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001FD0")]
			[FieldOffset(Offset = "0x20")]
			public JSONClass _003C_003E4__this;

			[Token(Token = "0x4001FD1")]
			[FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x170007F9")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6002DFD")]
				[Address(RVA = "0x177F9A0", Offset = "0x177F9A0", VA = "0x177F9A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170007FA")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6002DFF")]
				[Address(RVA = "0x177FA10", Offset = "0x177FA10", VA = "0x177FA10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6002DF9")]
			[Address(RVA = "0x177EA84", Offset = "0x177EA84", VA = "0x177EA84")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__15(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6002DFA")]
			[Address(RVA = "0x177F78C", Offset = "0x177F78C", VA = "0x177F78C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6002DFB")]
			[Address(RVA = "0x177F800", Offset = "0x177F800", VA = "0x177F800", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6002DFC")]
			[Address(RVA = "0x177F7A8", Offset = "0x177F7A8", VA = "0x177F7A8")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6002DFE")]
			[Address(RVA = "0x177F9A8", Offset = "0x177F9A8", VA = "0x177F9A8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x170001EB")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6000EB5")]
			[Address(RVA = "0x177E10C", Offset = "0x177E10C", VA = "0x177E10C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EB6")]
			[Address(RVA = "0x177E214", Offset = "0x177E214", VA = "0x177E214", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170001EC")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000EB7")]
			[Address(RVA = "0x177E2E8", Offset = "0x177E2E8", VA = "0x177E2E8", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EB8")]
			[Address(RVA = "0x177E3AC", Offset = "0x177E3AC", VA = "0x177E3AC", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170001ED")]
		public override int Count
		{
			[Token(Token = "0x6000EB9")]
			[Address(RVA = "0x177E49C", Offset = "0x177E49C", VA = "0x177E49C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001EE")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000EBE")]
			[Address(RVA = "0x177E9C8", Offset = "0x177E9C8", VA = "0x177E9C8", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x835494", Offset = "0x835494")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000EBA")]
		[Address(RVA = "0x177E4FC", Offset = "0x177E4FC", VA = "0x177E4FC", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000EBB")]
		[Address(RVA = "0x177E634", Offset = "0x177E634", VA = "0x177E634", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000EBC")]
		[Address(RVA = "0x177E70C", Offset = "0x177E70C", VA = "0x177E70C", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000EBD")]
		[Address(RVA = "0x177E80C", Offset = "0x177E80C", VA = "0x177E80C", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000EBF")]
		[Address(RVA = "0x177B798", Offset = "0x177B798", VA = "0x177B798", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8354F8", Offset = "0x8354F8")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0x177EAB0", Offset = "0x177EAB0", VA = "0x177EAB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0x177F02C", Offset = "0x177F02C", VA = "0x177F02C", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x177F4A0", Offset = "0x177F4A0", VA = "0x177F4A0", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x177F6B0", Offset = "0x177F6B0", VA = "0x177F6B0")]
		public JSONClass()
		{
		}
	}
}
