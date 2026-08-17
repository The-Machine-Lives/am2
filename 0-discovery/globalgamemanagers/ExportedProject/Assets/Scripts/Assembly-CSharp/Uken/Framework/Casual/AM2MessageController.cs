using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Observe;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004B6")]
	public class AM2MessageController : DepotController
	{
		[Token(Token = "0x40015FE")]
		[FieldOffset(Offset = "0x20")]
		private RuntimeDataCache<AM2Message, RDAM2Message> m_am2MessageCache;

		[Token(Token = "0x40015FF")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EAEC", Offset = "0x82EAEC")]
		private static string _003CAM2_MESSAGE_SAVE_KEY_003Ek__BackingField;

		[Token(Token = "0x4001600")]
		[FieldOffset(Offset = "0x28")]
		protected UkenObservable<string> m_am2MessageObservable;

		[Token(Token = "0x170005FB")]
		public static string AM2_MESSAGE_SAVE_KEY
		{
			[Token(Token = "0x6002372")]
			[Address(RVA = "0xA1EB48", Offset = "0xA1EB48", VA = "0xA1EB48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83966C", Offset = "0x83966C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002373")]
			[Address(RVA = "0xA1EBB0", Offset = "0xA1EBB0", VA = "0xA1EBB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83967C", Offset = "0x83967C")]
			private set
			{
			}
		}

		[Token(Token = "0x6002374")]
		[Address(RVA = "0xA1EC1C", Offset = "0xA1EC1C", VA = "0xA1EC1C")]
		public AM2MessageController(CasualDataStoreController dataController)
		{
		}

		[Token(Token = "0x6002375")]
		[Address(RVA = "0xA1ECA0", Offset = "0xA1ECA0", VA = "0xA1ECA0")]
		public UkenUnsubscriber<string> SubscribeToAM2Message(IUkenObserver<string> observer)
		{
			return null;
		}

		[Token(Token = "0x6002376")]
		[Address(RVA = "0xA1ED14", Offset = "0xA1ED14", VA = "0xA1ED14")]
		public void ShowMessage(string message)
		{
		}

		[Token(Token = "0x6002377")]
		[Address(RVA = "0xA1ED84", Offset = "0xA1ED84", VA = "0xA1ED84")]
		public void SetAM2MessagesAsOld()
		{
		}

		[Token(Token = "0x6002378")]
		[Address(RVA = "0xA1EE54", Offset = "0xA1EE54", VA = "0xA1EE54")]
		public List<AM2Message> GetAllNewAM2Messages()
		{
			return null;
		}

		[Token(Token = "0x6002379")]
		[Address(RVA = "0xA1EFE8", Offset = "0xA1EFE8", VA = "0xA1EFE8", Slot = "9")]
		public override void OnDataUpdated()
		{
		}
	}
}
