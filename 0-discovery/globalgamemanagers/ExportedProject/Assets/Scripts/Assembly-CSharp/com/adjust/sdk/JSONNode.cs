using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace com.adjust.sdk
{
	[Token(Token = "0x200021E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x81E9F0", Offset = "0x81E9F0")]
	public class JSONNode
	{
		[Token(Token = "0x2000670")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820698", Offset = "0x820698")]
		private sealed class _003Cget_Childs_003Ed__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001FB6")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001FB7")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode _003C_003E2__current;

			[Token(Token = "0x4001FB8")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x170007EF")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x6002DCF")]
				[Address(RVA = "0x1781CA8", Offset = "0x1781CA8", VA = "0x1781CA8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170007F0")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6002DD1")]
				[Address(RVA = "0x1781D18", Offset = "0x1781D18", VA = "0x1781D18", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6002DCC")]
			[Address(RVA = "0x1780D50", Offset = "0x1780D50", VA = "0x1780D50")]
			[DebuggerHidden]
			public _003Cget_Childs_003Ed__17(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6002DCD")]
			[Address(RVA = "0x1781C8C", Offset = "0x1781C8C", VA = "0x1781C8C", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6002DCE")]
			[Address(RVA = "0x1781C90", Offset = "0x1781C90", VA = "0x1781C90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6002DD0")]
			[Address(RVA = "0x1781CB0", Offset = "0x1781CB0", VA = "0x1781CB0", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6002DD2")]
			[Address(RVA = "0x1781D20", Offset = "0x1781D20", VA = "0x1781D20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6002DD3")]
			[Address(RVA = "0x1781DB8", Offset = "0x1781DB8", VA = "0x1781DB8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000671")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8206A8", Offset = "0x8206A8")]
		private sealed class _003Cget_DeepChilds_003Ed__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001FB9")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001FBA")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode _003C_003E2__current;

			[Token(Token = "0x4001FBB")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4001FBC")]
			[FieldOffset(Offset = "0x28")]
			public JSONNode _003C_003E4__this;

			[Token(Token = "0x4001FBD")]
			[FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> _003C_003E7__wrap1;

			[Token(Token = "0x4001FBE")]
			[FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> _003C_003E7__wrap2;

			[Token(Token = "0x170007F1")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x6002DD9")]
				[Address(RVA = "0x17823F0", Offset = "0x17823F0", VA = "0x17823F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170007F2")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6002DDB")]
				[Address(RVA = "0x1782460", Offset = "0x1782460", VA = "0x1782460", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6002DD4")]
			[Address(RVA = "0x1780E0C", Offset = "0x1780E0C", VA = "0x1780E0C")]
			[DebuggerHidden]
			public _003Cget_DeepChilds_003Ed__19(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6002DD5")]
			[Address(RVA = "0x1781DBC", Offset = "0x1781DBC", VA = "0x1781DBC", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6002DD6")]
			[Address(RVA = "0x1781FB4", Offset = "0x1781FB4", VA = "0x1781FB4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6002DD7")]
			[Address(RVA = "0x1781EF4", Offset = "0x1781EF4", VA = "0x1781EF4")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6002DD8")]
			[Address(RVA = "0x1781E34", Offset = "0x1781E34", VA = "0x1781E34")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x6002DDA")]
			[Address(RVA = "0x17823F8", Offset = "0x17823F8", VA = "0x17823F8", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6002DDC")]
			[Address(RVA = "0x1782468", Offset = "0x1782468", VA = "0x1782468", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6002DDD")]
			[Address(RVA = "0x1782518", Offset = "0x1782518", VA = "0x1782518", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x170001DB")]
		public virtual JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000E7A")]
			[Address(RVA = "0x1780BF4", Offset = "0x1780BF4", VA = "0x1780BF4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E7B")]
			[Address(RVA = "0x1780BFC", Offset = "0x1780BFC", VA = "0x1780BFC", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170001DC")]
		public virtual JSONNode this[string aKey]
		{
			[Token(Token = "0x6000E7C")]
			[Address(RVA = "0x1780C00", Offset = "0x1780C00", VA = "0x1780C00", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E7D")]
			[Address(RVA = "0x1780C08", Offset = "0x1780C08", VA = "0x1780C08", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170001DD")]
		public virtual string Value
		{
			[Token(Token = "0x6000E7E")]
			[Address(RVA = "0x1780C0C", Offset = "0x1780C0C", VA = "0x1780C0C", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E7F")]
			[Address(RVA = "0x1780C54", Offset = "0x1780C54", VA = "0x1780C54", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170001DE")]
		public virtual int Count
		{
			[Token(Token = "0x6000E80")]
			[Address(RVA = "0x1780C58", Offset = "0x1780C58", VA = "0x1780C58", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001DF")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000E85")]
			[Address(RVA = "0x1780CE0", Offset = "0x1780CE0", VA = "0x1780CE0", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x835304", Offset = "0x835304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E0")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x6000E86")]
			[Address(RVA = "0x1780D88", Offset = "0x1780D88", VA = "0x1780D88")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x835368", Offset = "0x835368")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E1")]
		public virtual int AsInt
		{
			[Token(Token = "0x6000E89")]
			[Address(RVA = "0x1780ED4", Offset = "0x1780ED4", VA = "0x1780ED4", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000E8A")]
			[Address(RVA = "0x1780F14", Offset = "0x1780F14", VA = "0x1780F14", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170001E2")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6000E8B")]
			[Address(RVA = "0x1780F54", Offset = "0x1780F54", VA = "0x1780F54", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000E8C")]
			[Address(RVA = "0x1780F98", Offset = "0x1780F98", VA = "0x1780F98", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6000E8D")]
			[Address(RVA = "0x1780FD8", Offset = "0x1780FD8", VA = "0x1780FD8", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000E8E")]
			[Address(RVA = "0x178107C", Offset = "0x178107C", VA = "0x178107C", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x170001E4")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000E8F")]
			[Address(RVA = "0x17810BC", Offset = "0x17810BC", VA = "0x17810BC", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E90")]
			[Address(RVA = "0x1781184", Offset = "0x1781184", VA = "0x1781184", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x170001E5")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000E91")]
			[Address(RVA = "0x1781208", Offset = "0x1781208", VA = "0x1781208", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E6")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x6000E92")]
			[Address(RVA = "0x1781288", Offset = "0x1781288", VA = "0x1781288", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x1780BF0", Offset = "0x1780BF0", VA = "0x1780BF0", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000E81")]
		[Address(RVA = "0x1780C60", Offset = "0x1780C60", VA = "0x1780C60", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x1780CC8", Offset = "0x1780CC8", VA = "0x1780CC8", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x1780CD0", Offset = "0x1780CD0", VA = "0x1780CD0", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x1780CD8", Offset = "0x1780CD8", VA = "0x1780CD8", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000E87")]
		[Address(RVA = "0x1780E44", Offset = "0x1780E44", VA = "0x1780E44", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x1780E8C", Offset = "0x1780E8C", VA = "0x1780E8C", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000E93")]
		[Address(RVA = "0x1781308", Offset = "0x1781308", VA = "0x1781308")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x178136C", Offset = "0x178136C", VA = "0x178136C")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x17789FC", Offset = "0x17789FC", VA = "0x17789FC")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x17797D0", Offset = "0x17797D0", VA = "0x17797D0")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x17813BC", Offset = "0x17813BC", VA = "0x17813BC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x1780658", Offset = "0x1780658", VA = "0x1780658", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x177EEA0", Offset = "0x177EEA0", VA = "0x177EEA0")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x177C8C4", Offset = "0x177C8C4", VA = "0x177C8C4")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0x17813C8", Offset = "0x17813C8", VA = "0x17813C8", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0x17813CC", Offset = "0x17813CC", VA = "0x17813CC")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0x178144C", Offset = "0x178144C", VA = "0x178144C")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x17814C0", Offset = "0x17814C0", VA = "0x17814C0")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0x1781534", Offset = "0x1781534", VA = "0x1781534")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0x17815A8", Offset = "0x17815A8", VA = "0x17815A8")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x1781948", Offset = "0x1781948", VA = "0x1781948")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x17819BC", Offset = "0x17819BC", VA = "0x17819BC")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x1781A30", Offset = "0x1781A30", VA = "0x1781A30")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x1781AA4", Offset = "0x1781AA4", VA = "0x1781AA4")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x1781BD4", Offset = "0x1781BD4", VA = "0x1781BD4")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x177DB90", Offset = "0x177DB90", VA = "0x177DB90")]
		public JSONNode()
		{
		}
	}
}
