using Il2CppDummyDll;
using Uken.Library.Observe;

namespace Uken.Library.UINotification
{
	[Token(Token = "0x20003E7")]
	public class UINotification<T> : UkenObservable<T> where T : class, new()
	{
		[Token(Token = "0x400125F")]
		[FieldOffset(Offset = "0x0")]
		protected T m_uiMessage;

		[Token(Token = "0x4001260")]
		[FieldOffset(Offset = "0x0")]
		protected string m_name;

		[Token(Token = "0x4001261")]
		[FieldOffset(Offset = "0x0")]
		protected bool m_uiMessageDirty;

		[Token(Token = "0x4001262")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E3B8", Offset = "0x82E3B8")]
		private bool _003CemitOnItemRemoval_003Ek__BackingField;

		[Token(Token = "0x1700059A")]
		public bool emitOnItemRemoval
		{
			[Token(Token = "0x6001E37")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838E50", Offset = "0x838E50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838E60", Offset = "0x838E60")]
			set
			{
			}
		}

		[Token(Token = "0x6001E39")]
		public UINotification(string name)
		{
		}

		[Token(Token = "0x6001E3A")]
		public T GetUIMessage()
		{
			return null;
		}

		[Token(Token = "0x6001E3B")]
		protected T GetUIMessageFromDisk()
		{
			return null;
		}

		[Token(Token = "0x6001E3C")]
		public void SetNotification(T updatedUIMessage, EEmitType emitType)
		{
		}
	}
}
