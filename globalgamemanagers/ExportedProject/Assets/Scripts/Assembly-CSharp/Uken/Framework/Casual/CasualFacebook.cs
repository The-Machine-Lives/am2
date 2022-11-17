using System;
using System.Collections.Generic;
using Facebook.Unity;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.UkenTime;
using UnityEngine;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004D6")]
	public class CasualFacebook : UkenController
	{
		[Token(Token = "0x2000832")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8213A8", Offset = "0x8213A8")]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			[Token(Token = "0x400238D")]
			[FieldOffset(Offset = "0x10")]
			public CasualFacebook _003C_003E4__this;

			[Token(Token = "0x400238E")]
			[FieldOffset(Offset = "0x18")]
			public string facebookId;

			[Token(Token = "0x600332E")]
			[Address(RVA = "0xA2CA60", Offset = "0xA2CA60", VA = "0xA2CA60")]
			public _003C_003Ec__DisplayClass25_0()
			{
			}

			[Token(Token = "0x600332F")]
			[Address(RVA = "0xA2E5CC", Offset = "0xA2E5CC", VA = "0xA2E5CC")]
			internal void _003CQueryUser_003Eb__0(IGraphResult result)
			{
			}
		}

		[Token(Token = "0x2000833")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8213B8", Offset = "0x8213B8")]
		private sealed class _003C_003Ec__DisplayClass26_0
		{
			[Token(Token = "0x400238F")]
			[FieldOffset(Offset = "0x10")]
			public CasualFacebook _003C_003E4__this;

			[Token(Token = "0x4002390")]
			[FieldOffset(Offset = "0x18")]
			public string facebookId;

			[Token(Token = "0x6003330")]
			[Address(RVA = "0xA2CD64", Offset = "0xA2CD64", VA = "0xA2CD64")]
			public _003C_003Ec__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6003331")]
			[Address(RVA = "0xA2E60C", Offset = "0xA2E60C", VA = "0xA2E60C")]
			internal void _003CQueryFacebookImage_003Eb__0(IGraphResult result)
			{
			}
		}

		[Token(Token = "0x2000834")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8213C8", Offset = "0x8213C8")]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			[Token(Token = "0x4002391")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, FacebookSelfData> onComplete;

			[Token(Token = "0x6003332")]
			[Address(RVA = "0xA2D26C", Offset = "0xA2D26C", VA = "0xA2D26C")]
			public _003C_003Ec__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6003333")]
			[Address(RVA = "0xA2E64C", Offset = "0xA2E64C", VA = "0xA2E64C")]
			internal void _003CQuerySelf_003Eb__0(IGraphResult result)
			{
			}
		}

		[Token(Token = "0x2000835")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8213D8", Offset = "0x8213D8")]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			[Token(Token = "0x4002392")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, List<FacebookUserData>> onComplete;

			[Token(Token = "0x6003334")]
			[Address(RVA = "0xA2D3F8", Offset = "0xA2D3F8", VA = "0xA2D3F8")]
			public _003C_003Ec__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6003335")]
			[Address(RVA = "0xA2E82C", Offset = "0xA2E82C", VA = "0xA2E82C")]
			internal void _003CQueryFriendsList_003Eb__0(IGraphResult result)
			{
			}
		}

		[Token(Token = "0x2000836")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8213E8", Offset = "0x8213E8")]
		private sealed class _003C_003Ec__DisplayClass30_0
		{
			[Token(Token = "0x4002393")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, List<string>> onComplete;

			[Token(Token = "0x6003336")]
			[Address(RVA = "0xA2D5CC", Offset = "0xA2D5CC", VA = "0xA2D5CC")]
			public _003C_003Ec__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6003337")]
			[Address(RVA = "0xA2EA24", Offset = "0xA2EA24", VA = "0xA2EA24")]
			internal void _003CSendAppRequest_003Eb__0(IAppRequestResult result)
			{
			}
		}

		[Token(Token = "0x40016A5")]
		[FieldOffset(Offset = "0x18")]
		private NetworkStatusCentre m_networkStatus;

		[Token(Token = "0x40016A6")]
		[FieldOffset(Offset = "0x20")]
		private UkenTimeController m_time;

		[Token(Token = "0x40016A7")]
		private const string m_kLoginReadPermissions = "public_profile,email,user_friends";

		[Token(Token = "0x40016A8")]
		private const string m_kFacebookFriendFields = "first_name,last_name,installed";

		[Token(Token = "0x40016A9")]
		private const string m_kFacebookSelfFields = "email,gender,timezone,age_range,locale";

		[Token(Token = "0x40016AA")]
		[FieldOffset(Offset = "0x28")]
		private List<Action<bool>> m_initCallbacks;

		[Token(Token = "0x40016AB")]
		[FieldOffset(Offset = "0x30")]
		private List<Action<bool, FacebookAccessToken>> m_loginCallbacks;

		[Token(Token = "0x40016AC")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, List<Action<bool, FacebookUserData>>> m_friendDataCallbacks;

		[Token(Token = "0x40016AD")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, List<Action<bool, Sprite>>> m_facebookImageCallbacks;

		[Token(Token = "0x40016AE")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, FacebookUserData> m_userDataCache;

		[Token(Token = "0x40016AF")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, FacebookImageCacheEntry> m_userImageCache;

		[Token(Token = "0x40016B0")]
		[FieldOffset(Offset = "0x58")]
		private List<string> expiredImageCacheKeys;

		[Token(Token = "0x40016B1")]
		private const int m_kCacheTimeInSeconds = 300;

		[Token(Token = "0x40016B2")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82ED8C", Offset = "0x82ED8C")]
		private FacebookAccessToken _003Cm_accessToken_003Ek__BackingField;

		[Token(Token = "0x17000606")]
		public FacebookAccessToken m_accessToken
		{
			[Token(Token = "0x6002468")]
			[Address(RVA = "0xA2BFA4", Offset = "0xA2BFA4", VA = "0xA2BFA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839754", Offset = "0x839754")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002469")]
			[Address(RVA = "0xA2BFAC", Offset = "0xA2BFAC", VA = "0xA2BFAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839764", Offset = "0x839764")]
			private set
			{
			}
		}

		[Token(Token = "0x600246A")]
		[Address(RVA = "0xA2BFB4", Offset = "0xA2BFB4", VA = "0xA2BFB4")]
		public CasualFacebook(NetworkStatusCentre networkStatus, UkenTimeController time)
		{
		}

		[Token(Token = "0x600246B")]
		[Address(RVA = "0xA2C12C", Offset = "0xA2C12C", VA = "0xA2C12C", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600246C")]
		[Address(RVA = "0xA2C25C", Offset = "0xA2C25C", VA = "0xA2C25C")]
		public string GetFacebookId()
		{
			return null;
		}

		[Token(Token = "0x600246D")]
		[Address(RVA = "0xA2C2C8", Offset = "0xA2C2C8", VA = "0xA2C2C8")]
		public bool IsFacebookInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x600246E")]
		[Address(RVA = "0xA2C13C", Offset = "0xA2C13C", VA = "0xA2C13C")]
		public void InitializeFacebook(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x600246F")]
		[Address(RVA = "0xA2C3E8", Offset = "0xA2C3E8", VA = "0xA2C3E8")]
		public bool IsFacebookLoggedIn()
		{
			return default(bool);
		}

		[Token(Token = "0x6002470")]
		[Address(RVA = "0xA2C468", Offset = "0xA2C468", VA = "0xA2C468")]
		public void Login(Action<bool, FacebookAccessToken> onComplete, bool suppressLoginDialog = false)
		{
		}

		[Token(Token = "0x6002471")]
		[Address(RVA = "0xA2C6A4", Offset = "0xA2C6A4", VA = "0xA2C6A4")]
		public void LogOut()
		{
		}

		[Token(Token = "0x6002472")]
		[Address(RVA = "0xA2C734", Offset = "0xA2C734", VA = "0xA2C734")]
		public void QueryUser(string facebookId, Action<bool, FacebookUserData> onComplete)
		{
		}

		[Token(Token = "0x6002473")]
		[Address(RVA = "0xA2CA68", Offset = "0xA2CA68", VA = "0xA2CA68")]
		public void QueryFacebookImage(string facebookId, Action<bool, Sprite> onComplete)
		{
		}

		[Token(Token = "0x6002474")]
		[Address(RVA = "0xA2D094", Offset = "0xA2D094", VA = "0xA2D094")]
		public void QuerySelf(Action<bool, FacebookSelfData> onComplete)
		{
		}

		[Token(Token = "0x6002475")]
		[Address(RVA = "0xA2D274", Offset = "0xA2D274", VA = "0xA2D274")]
		public void QueryFriendsList(Action<bool, List<FacebookUserData>> onComplete)
		{
		}

		[Token(Token = "0x6002476")]
		[Address(RVA = "0xA2D400", Offset = "0xA2D400", VA = "0xA2D400")]
		public void PostShareLink(string url, string title, string description, string imageUrl)
		{
		}

		[Token(Token = "0x6002477")]
		[Address(RVA = "0xA2D4CC", Offset = "0xA2D4CC", VA = "0xA2D4CC")]
		public void SendAppRequest(string message, string[] facebookIds, Action<bool, List<string>> onComplete)
		{
		}

		[Token(Token = "0x6002478")]
		[Address(RVA = "0xA2D5D4", Offset = "0xA2D5D4", VA = "0xA2D5D4")]
		public void LogCompletedRegistration()
		{
		}

		[Token(Token = "0x6002479")]
		[Address(RVA = "0xA2D6A0", Offset = "0xA2D6A0", VA = "0xA2D6A0")]
		public void LogAppActivated()
		{
		}

		[Token(Token = "0x600247A")]
		[Address(RVA = "0xA2D6E8", Offset = "0xA2D6E8", VA = "0xA2D6E8")]
		public void LogCompletedTutorialEvent()
		{
		}

		[Token(Token = "0x600247B")]
		[Address(RVA = "0xA2D730", Offset = "0xA2D730", VA = "0xA2D730")]
		public void ClearCache()
		{
		}

		[Token(Token = "0x600247C")]
		[Address(RVA = "0xA2D7B4", Offset = "0xA2D7B4", VA = "0xA2D7B4")]
		protected void OnInitComplete(bool success)
		{
		}

		[Token(Token = "0x600247D")]
		[Address(RVA = "0xA2D91C", Offset = "0xA2D91C", VA = "0xA2D91C")]
		protected void OnLoginComplete(bool success, AccessToken accessToken)
		{
		}

		[Token(Token = "0x600247E")]
		[Address(RVA = "0xA2DABC", Offset = "0xA2DABC", VA = "0xA2DABC")]
		protected void OnQueryFacebookImageComplete(string facebookId, IGraphResult result)
		{
		}

		[Token(Token = "0x600247F")]
		[Address(RVA = "0xA2DF70", Offset = "0xA2DF70", VA = "0xA2DF70")]
		protected void OnQueryFriendComplete(string facebookId, IGraphResult result)
		{
		}

		[Token(Token = "0x6002480")]
		[Address(RVA = "0xA2CD6C", Offset = "0xA2CD6C", VA = "0xA2CD6C")]
		protected Sprite CheckCacheForProfileImage(string facebookId)
		{
			return null;
		}

		[Token(Token = "0x6002481")]
		[Address(RVA = "0xA2D61C", Offset = "0xA2D61C", VA = "0xA2D61C")]
		protected void LogFacebookEvent(string logName)
		{
		}

		[Token(Token = "0x6002482")]
		[Address(RVA = "0xA2C328", Offset = "0xA2C328", VA = "0xA2C328")]
		protected void QueryForPing(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6002483")]
		[Address(RVA = "0xA2E2B4", Offset = "0xA2E2B4", VA = "0xA2E2B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839774", Offset = "0x839774")]
		private void _003CInitializeFacebook_003Eb__21_0(bool success)
		{
		}

		[Token(Token = "0x6002484")]
		[Address(RVA = "0xA2E378", Offset = "0xA2E378", VA = "0xA2E378")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839784", Offset = "0x839784")]
		private void _003CInitializeFacebook_003Eb__21_1()
		{
		}

		[Token(Token = "0x6002485")]
		[Address(RVA = "0xA2E380", Offset = "0xA2E380", VA = "0xA2E380")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839794", Offset = "0x839794")]
		private void _003CLogin_003Eb__23_0(ILoginResult result)
		{
		}
	}
}
