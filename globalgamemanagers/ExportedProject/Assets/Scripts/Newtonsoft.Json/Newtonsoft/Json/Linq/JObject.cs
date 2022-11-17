using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x80F09C", Offset = "0x80F09C")]
	[Preserve]
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
	{
		[Serializable]
		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F0E8", Offset = "0x80F0E8")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002F9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x6000637")]
			[Address(RVA = "0xFF2244", Offset = "0xFF2244", VA = "0xFF2244")]
			public _003C_003Ec()
			{
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F0F8", Offset = "0x80F0F8")]
		private sealed class _003CGetEnumerator_003Ed__58 : IEnumerator<KeyValuePair<string, JToken>>, IDisposable, IEnumerator
		{
			[Token(Token = "0x40002FA")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40002FB")]
			[FieldOffset(Offset = "0x18")]
			private KeyValuePair<string, JToken> _003C_003E2__current;

			[Token(Token = "0x40002FC")]
			[FieldOffset(Offset = "0x28")]
			public JObject _003C_003E4__this;

			[Token(Token = "0x40002FD")]
			[FieldOffset(Offset = "0x30")]
			private IEnumerator<JToken> _003C_003E7__wrap1;

			[Token(Token = "0x17000123")]
			private KeyValuePair<string, JToken> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ECurrent
			{
				[Token(Token = "0x600063C")]
				[Address(RVA = "0xFF2644", Offset = "0xFF2644", VA = "0xFF2644", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, JToken>);
				}
			}

			[Token(Token = "0x17000124")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600063E")]
				[Address(RVA = "0xFF26B8", Offset = "0xFF26B8", VA = "0xFF26B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0xFF1C64", Offset = "0xFF1C64", VA = "0xFF1C64")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__58(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0xFF224C", Offset = "0xFF224C", VA = "0xFF224C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0xFF2328", Offset = "0xFF2328", VA = "0xFF2328", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0xFF2268", Offset = "0xFF2268", VA = "0xFF2268")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0xFF2650", Offset = "0xFF2650", VA = "0xFF2650", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x48")]
		private readonly JPropertyKeyedCollection _properties;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FBD8", Offset = "0x80FBD8")]
		private PropertyChangedEventHandler PropertyChanged;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FBE8", Offset = "0x80FBE8")]
		private PropertyChangingEventHandler PropertyChanging;

		[Token(Token = "0x1700011D")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0xFEFE34", Offset = "0xFEFE34", VA = "0xFEFE34", Slot = "47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011E")]
		public override JTokenType Type
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0xFF0A88", Offset = "0xFF0A88", VA = "0xFF0A88", Slot = "12")]
			get
			{
				return default(JTokenType);
			}
		}

		[Token(Token = "0x1700011F")]
		public override JToken this[object key]
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0xFF0A90", Offset = "0xFF0A90", VA = "0xFF0A90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000120")]
		public JToken this[string propertyName]
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0xFF0BB4", Offset = "0xFF0BB4", VA = "0xFF0BB4", Slot = "61")]
			get
			{
				return null;
			}
			[Token(Token = "0x600061F")]
			[Address(RVA = "0xFF0C3C", Offset = "0xFF0C3C", VA = "0xFF0C3C", Slot = "62")]
			set
			{
			}
		}

		[Token(Token = "0x17000121")]
		private ICollection<string> System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EKeys
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0xFF1318", Offset = "0xFF1318", VA = "0xFF1318", Slot = "63")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000122")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EIsReadOnly
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0xFF1A7C", Offset = "0xFF1A7C", VA = "0xFF1A7C", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xFEEFF4", Offset = "0xFEEFF4", VA = "0xFEEFF4")]
		public JObject()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xFEFEB4", Offset = "0xFEFEB4", VA = "0xFEFEB4")]
		public JObject(JObject other)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xFEFF24", Offset = "0xFEFF24", VA = "0xFEFF24", Slot = "11")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xFF03E4", Offset = "0xFF03E4", VA = "0xFF03E4", Slot = "49")]
		internal override int IndexOfItem(JToken item)
		{
			return default(int);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xFF050C", Offset = "0xFF050C", VA = "0xFF050C", Slot = "50")]
		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xFF0578", Offset = "0xFF0578", VA = "0xFF0578", Slot = "59")]
		internal override void ValidateToken(JToken o, JToken existing)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xFF0908", Offset = "0xFF0908", VA = "0xFF0908")]
		internal void InternalPropertyChanged(JProperty childProperty)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xFF09E8", Offset = "0xFF09E8", VA = "0xFF09E8")]
		internal void InternalPropertyChanging(JProperty childProperty)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xFF0A28", Offset = "0xFF0A28", VA = "0xFF0A28", Slot = "10")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xFEF0E4", Offset = "0xFEF0E4", VA = "0xFEF0E4")]
		public JProperty Property(string name)
		{
			return null;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xFF0E7C", Offset = "0xFF0E7C", VA = "0xFF0E7C")]
		public static JObject Load(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xFF0E84", Offset = "0xFF0E84", VA = "0xFF0E84")]
		public static JObject Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xFF1088", Offset = "0xFF1088", VA = "0xFF1088", Slot = "18")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xFF11A4", Offset = "0xFF11A4", VA = "0xFF11A4", Slot = "65")]
		public void Add(string propertyName, JToken value)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xFF1228", Offset = "0xFF1228", VA = "0xFF1228", Slot = "64")]
		private bool System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xFF13AC", Offset = "0xFF13AC", VA = "0xFF13AC", Slot = "66")]
		public bool Remove(string propertyName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xFF1468", Offset = "0xFF1468", VA = "0xFF1468", Slot = "67")]
		public bool TryGetValue(string propertyName, out JToken value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xFF14B0", Offset = "0xFF14B0", VA = "0xFF14B0", Slot = "70")]
		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EAdd(KeyValuePair<string, JToken> item)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xFF1570", Offset = "0xFF1570", VA = "0xFF1570", Slot = "71")]
		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EClear()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xFF1580", Offset = "0xFF1580", VA = "0xFF1580", Slot = "72")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EContains(KeyValuePair<string, JToken> item)
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xFF1620", Offset = "0xFF1620", VA = "0xFF1620", Slot = "73")]
		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ECopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xFF1A84", Offset = "0xFF1A84", VA = "0xFF1A84", Slot = "74")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ERemove(KeyValuePair<string, JToken> item)
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xFF1BEC", Offset = "0xFF1BEC", VA = "0xFF1BEC", Slot = "19")]
		internal override int GetDeepHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xFF1BF0", Offset = "0xFF1BF0", VA = "0xFF1BF0", Slot = "75")]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xFF1C90", Offset = "0xFF1C90", VA = "0xFF1C90", Slot = "80")]
		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xFF1D24", Offset = "0xFF1D24", VA = "0xFF1D24", Slot = "81")]
		protected virtual void OnPropertyChanging(string propertyName)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xFF1DB8", Offset = "0xFF1DB8", VA = "0xFF1DB8", Slot = "78")]
		private PropertyDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetProperties()
		{
			return null;
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xFF1E64", Offset = "0xFF1E64", VA = "0xFF1E64", Slot = "79")]
		private PropertyDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetProperties(Attribute[] attributes)
		{
			return null;
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xFF211C", Offset = "0xFF211C", VA = "0xFF211C", Slot = "76")]
		private AttributeCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetAttributes()
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xFF2184", Offset = "0xFF2184", VA = "0xFF2184", Slot = "77")]
		private TypeConverter System_002EComponentModel_002EICustomTypeDescriptor_002EGetConverter()
		{
			return null;
		}
	}
}
