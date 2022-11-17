using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace com.adjust.sdk
{
	[Token(Token = "0x200021F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x81EA28", Offset = "0x81EA28")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000672")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8206B8", Offset = "0x8206B8")]
		private sealed class _003Cget_Childs_003Ed__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001FBF")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001FC0")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode _003C_003E2__current;

			[Token(Token = "0x4001FC1")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4001FC2")]
			[FieldOffset(Offset = "0x28")]
			public JSONArray _003C_003E4__this;

			[Token(Token = "0x4001FC3")]
			[FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x170007F3")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x6002DE2")]
				[Address(RVA = "0x177DFE0", Offset = "0x177DFE0", VA = "0x177DFE0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170007F4")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6002DE4")]
				[Address(RVA = "0x177E050", Offset = "0x177E050", VA = "0x177E050", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6002DDE")]
			[Address(RVA = "0x177D594", Offset = "0x177D594", VA = "0x177D594")]
			[DebuggerHidden]
			public _003Cget_Childs_003Ed__13(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6002DDF")]
			[Address(RVA = "0x177DDF8", Offset = "0x177DDF8", VA = "0x177DDF8", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6002DE0")]
			[Address(RVA = "0x177DE6C", Offset = "0x177DE6C", VA = "0x177DE6C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6002DE1")]
			[Address(RVA = "0x177DE14", Offset = "0x177DE14", VA = "0x177DE14")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6002DE3")]
			[Address(RVA = "0x177DFE8", Offset = "0x177DFE8", VA = "0x177DFE8", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6002DE5")]
			[Address(RVA = "0x177E058", Offset = "0x177E058", VA = "0x177E058", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6002DE6")]
			[Address(RVA = "0x177E108", Offset = "0x177E108", VA = "0x177E108", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000673")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8206C8", Offset = "0x8206C8")]
		private sealed class _003CGetEnumerator_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001FC4")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001FC5")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001FC6")]
			[FieldOffset(Offset = "0x20")]
			public JSONArray _003C_003E4__this;

			[Token(Token = "0x4001FC7")]
			[FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x170007F5")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6002DEB")]
				[Address(RVA = "0x177DD80", Offset = "0x177DD80", VA = "0x177DD80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170007F6")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6002DED")]
				[Address(RVA = "0x177DDF0", Offset = "0x177DDF0", VA = "0x177DDF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6002DE7")]
			[Address(RVA = "0x177D640", Offset = "0x177D640", VA = "0x177D640")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6002DE8")]
			[Address(RVA = "0x177DB98", Offset = "0x177DB98", VA = "0x177DB98", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6002DE9")]
			[Address(RVA = "0x177DC0C", Offset = "0x177DC0C", VA = "0x177DC0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6002DEA")]
			[Address(RVA = "0x177DBB4", Offset = "0x177DBB4", VA = "0x177DBB4")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6002DEC")]
			[Address(RVA = "0x177DD88", Offset = "0x177DD88", VA = "0x177DD88", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x170001E7")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000EA7")]
			[Address(RVA = "0x177D040", Offset = "0x177D040", VA = "0x177D040", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EA8")]
			[Address(RVA = "0x177D13C", Offset = "0x177D13C", VA = "0x177D13C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170001E8")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6000EA9")]
			[Address(RVA = "0x177D218", Offset = "0x177D218", VA = "0x177D218", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EAA")]
			[Address(RVA = "0x177D27C", Offset = "0x177D27C", VA = "0x177D27C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		public override int Count
		{
			[Token(Token = "0x6000EAB")]
			[Address(RVA = "0x177D2EC", Offset = "0x177D2EC", VA = "0x177D2EC", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001EA")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000EAF")]
			[Address(RVA = "0x177D510", Offset = "0x177D510", VA = "0x177D510", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8353CC", Offset = "0x8353CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x177D34C", Offset = "0x177D34C", VA = "0x177D34C", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x177D3BC", Offset = "0x177D3BC", VA = "0x177D3BC", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x177D498", Offset = "0x177D498", VA = "0x177D498", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x177D5CC", Offset = "0x177D5CC", VA = "0x177D5CC", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x835430", Offset = "0x835430")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x177D66C", Offset = "0x177D66C", VA = "0x177D66C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x177D838", Offset = "0x177D838", VA = "0x177D838", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000EB3")]
		[Address(RVA = "0x177DA64", Offset = "0x177DA64", VA = "0x177DA64", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x177B6FC", Offset = "0x177B6FC", VA = "0x177B6FC")]
		public JSONArray()
		{
		}
	}
}
