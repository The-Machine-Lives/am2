using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Core
{
	[Token(Token = "0x20003CC")]
	public class UkenCore : MonoBehaviour
	{
		[Token(Token = "0x40011F2")]
		[FieldOffset(Offset = "0x0")]
		protected static bool m_errorShown;

		[Token(Token = "0x40011F3")]
		[FieldOffset(Offset = "0x8")]
		protected static UkenCore _self;

		[Token(Token = "0x40011F4")]
		[FieldOffset(Offset = "0x18")]
		protected bool m_bDebugStartup;

		[Token(Token = "0x40011F5")]
		[FieldOffset(Offset = "0x19")]
		protected bool m_bInitialized;

		[Token(Token = "0x40011F6")]
		[FieldOffset(Offset = "0x20")]
		protected List<UkenController> m_baseControllers;

		[Token(Token = "0x40011F7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E228", Offset = "0x82E228")]
		private UkenSubroutineController _003Cm_ukenSubroutineController_003Ek__BackingField;

		[Token(Token = "0x1700057F")]
		public static UkenCore Instance
		{
			[Token(Token = "0x6001D64")]
			[Address(RVA = "0xA1A338", Offset = "0xA1A338", VA = "0xA1A338")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000580")]
		public UkenSubroutineController m_ukenSubroutineController
		{
			[Token(Token = "0x6001D65")]
			[Address(RVA = "0xA1A480", Offset = "0xA1A480", VA = "0xA1A480")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838868", Offset = "0x838868")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D66")]
			[Address(RVA = "0xA1A488", Offset = "0xA1A488", VA = "0xA1A488")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838878", Offset = "0x838878")]
			private set
			{
			}
		}

		[Token(Token = "0x6001D67")]
		[Address(RVA = "0xA1A490", Offset = "0xA1A490", VA = "0xA1A490", Slot = "4")]
		public virtual void Create()
		{
		}

		[Token(Token = "0x6001D68")]
		[Address(RVA = "0xA1A584", Offset = "0xA1A584", VA = "0xA1A584", Slot = "5")]
		protected virtual bool IsOnline()
		{
			return default(bool);
		}

		[Token(Token = "0x6001D69")]
		[Address(RVA = "0xA1A5A4", Offset = "0xA1A5A4", VA = "0xA1A5A4", Slot = "6")]
		protected virtual void RegisterController(UkenController controller)
		{
		}

		[Token(Token = "0x6001D6A")]
		[Address(RVA = "0xA1A6B8", Offset = "0xA1A6B8", VA = "0xA1A6B8", Slot = "7")]
		public virtual bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x6001D6B")]
		[Address(RVA = "0xA1A8B4", Offset = "0xA1A8B4", VA = "0xA1A8B4", Slot = "8")]
		protected virtual void OnGamePaused(bool paused)
		{
		}

		[Token(Token = "0x6001D6C")]
		[Address(RVA = "0xA1A8B8", Offset = "0xA1A8B8", VA = "0xA1A8B8", Slot = "9")]
		protected virtual void OnGameQuit()
		{
		}

		[Token(Token = "0x6001D6D")]
		[Address(RVA = "0xA1A8BC", Offset = "0xA1A8BC", VA = "0xA1A8BC", Slot = "10")]
		protected virtual void OnGameFocus(bool focus)
		{
		}

		[Token(Token = "0x6001D6E")]
		[Address(RVA = "0xA1A8C0", Offset = "0xA1A8C0", VA = "0xA1A8C0", Slot = "11")]
		protected virtual bool UpdateGame(float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D6F")]
		[Address(RVA = "0xA1AAD4", Offset = "0xA1AAD4", VA = "0xA1AAD4", Slot = "12")]
		public virtual void Cleanup()
		{
		}

		[Token(Token = "0x6001D70")]
		[Address(RVA = "0xA1ACC4", Offset = "0xA1ACC4", VA = "0xA1ACC4")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6001D71")]
		[Address(RVA = "0xA1ACCC", Offset = "0xA1ACCC", VA = "0xA1ACCC")]
		protected void OnDataUpdated()
		{
		}

		[Token(Token = "0x6001D72")]
		[Address(RVA = "0xA1AEBC", Offset = "0xA1AEBC", VA = "0xA1AEBC")]
		protected void PostLoadContent()
		{
		}

		[Token(Token = "0x6001D73")]
		[Address(RVA = "0xA1B0AC", Offset = "0xA1B0AC", VA = "0xA1B0AC", Slot = "13")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6001D74")]
		[Address(RVA = "0xA1B144", Offset = "0xA1B144", VA = "0xA1B144", Slot = "14")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6001D75")]
		[Address(RVA = "0xA1B148", Offset = "0xA1B148", VA = "0xA1B148")]
		private void Update()
		{
		}

		[Token(Token = "0x6001D76")]
		[Address(RVA = "0xA1B18C", Offset = "0xA1B18C", VA = "0xA1B18C")]
		private void OnApplicationPause(bool paused)
		{
		}

		[Token(Token = "0x6001D77")]
		[Address(RVA = "0xA1B1A8", Offset = "0xA1B1A8", VA = "0xA1B1A8")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6001D78")]
		[Address(RVA = "0xA1B1C0", Offset = "0xA1B1C0", VA = "0xA1B1C0", Slot = "15")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6001D79")]
		[Address(RVA = "0xA1B1CC", Offset = "0xA1B1CC", VA = "0xA1B1CC")]
		public UkenCore()
		{
		}
	}
}
