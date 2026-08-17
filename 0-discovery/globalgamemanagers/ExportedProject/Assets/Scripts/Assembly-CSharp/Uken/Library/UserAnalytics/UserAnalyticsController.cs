using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.UserAnalytics
{
	[Token(Token = "0x20003E2")]
	public class UserAnalyticsController : UkenController
	{
		[Token(Token = "0x20007B4")]
		public class UserProfile
		{
			[Token(Token = "0x4002280")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832FA0", Offset = "0x832FA0")]
			private UserProfileData _003CuserData_003Ek__BackingField;

			[Token(Token = "0x4002281")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832FB0", Offset = "0x832FB0")]
			private double _003CexpiresAt_003Ek__BackingField;

			[Token(Token = "0x17000819")]
			public UserProfileData userData
			{
				[Token(Token = "0x60031E2")]
				[Address(RVA = "0xB40F14", Offset = "0xB40F14", VA = "0xB40F14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BA0C", Offset = "0x83BA0C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60031E3")]
				[Address(RVA = "0xB40F1C", Offset = "0xB40F1C", VA = "0xB40F1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BA1C", Offset = "0x83BA1C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700081A")]
			public double expiresAt
			{
				[Token(Token = "0x60031E4")]
				[Address(RVA = "0xB4001C", Offset = "0xB4001C", VA = "0xB4001C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BA2C", Offset = "0x83BA2C")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x60031E5")]
				[Address(RVA = "0xB40F24", Offset = "0xB40F24", VA = "0xB40F24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BA3C", Offset = "0x83BA3C")]
				private set
				{
				}
			}

			[Token(Token = "0x60031E6")]
			[Address(RVA = "0xB40C20", Offset = "0xB40C20", VA = "0xB40C20")]
			public UserProfile(UserProfileData data, double createdAt)
			{
			}
		}

		[Token(Token = "0x20007B5")]
		protected class UserProfileQuery : WebRequest
		{
			[Token(Token = "0x60031E7")]
			[Address(RVA = "0xB40024", Offset = "0xB40024", VA = "0xB40024")]
			public UserProfileQuery(string endpoint, List<string> fields, List<string> userIds, Action<WebResponse, WebRequest> onComplete)
			{
			}
		}

		[Token(Token = "0x20007B6")]
		protected class UserAnalyticsQuery : WebRequest
		{
			[Token(Token = "0x60031E8")]
			[Address(RVA = "0xB40720", Offset = "0xB40720", VA = "0xB40720")]
			public UserAnalyticsQuery(string endpoint, string userId, Action<WebResponse, WebRequest> onComplete)
			{
			}
		}

		[Token(Token = "0x20007B7")]
		public enum UserAnalytic
		{
			[Token(Token = "0x4002283")]
			RFM = 0,
			[Token(Token = "0x4002284")]
			RFM_R = 1,
			[Token(Token = "0x4002285")]
			RFM_F = 2,
			[Token(Token = "0x4002286")]
			RFM_M = 3,
			[Token(Token = "0x4002287")]
			TotalSpend7Day = 4,
			[Token(Token = "0x4002288")]
			TotalSpend30Day = 5,
			[Token(Token = "0x4002289")]
			NumberOfDaysActive7Day = 6,
			[Token(Token = "0x400228A")]
			NumberOfPurchases = 7,
			[Token(Token = "0x400228B")]
			NumberOfDaysWithMatch = 8,
			[Token(Token = "0x400228C")]
			AverageSpend7Day = 9,
			[Token(Token = "0x400228D")]
			AverageSpend14Day = 10,
			[Token(Token = "0x400228E")]
			AverageSpend30Day = 11,
			[Token(Token = "0x400228F")]
			AverageSpend60Day = 12,
			[Token(Token = "0x4002290")]
			LastLogin = 13,
			[Token(Token = "0x4002291")]
			InstallDate = 14,
			[Token(Token = "0x4002292")]
			BalanceScoreAdjustment = 15
		}

		[Token(Token = "0x20007B8")]
		public delegate string GetUserIDFunc();

		[Token(Token = "0x20007B9")]
		public delegate double GetCurrentTime();

		[Token(Token = "0x20007BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820FE8", Offset = "0x820FE8")]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			[Token(Token = "0x4002293")]
			[FieldOffset(Offset = "0x10")]
			public List<string> queryUserIDs;

			[Token(Token = "0x4002294")]
			[FieldOffset(Offset = "0x18")]
			public UserAnalyticsController _003C_003E4__this;

			[Token(Token = "0x4002295")]
			[FieldOffset(Offset = "0x20")]
			public Action<bool, Dictionary<string, UserProfile>> onComplete;

			[Token(Token = "0x60031F1")]
			[Address(RVA = "0xB3FBE4", Offset = "0xB3FBE4", VA = "0xB3FBE4")]
			public _003C_003Ec__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60031F2")]
			[Address(RVA = "0xB40910", Offset = "0xB40910", VA = "0xB40910")]
			internal void _003CQueryUserProfile_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x20007BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820FF8", Offset = "0x820FF8")]
		private sealed class _003C_003Ec__DisplayClass19_0
		{
			[Token(Token = "0x4002296")]
			[FieldOffset(Offset = "0x10")]
			public UserAnalyticsController _003C_003E4__this;

			[Token(Token = "0x4002297")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> onComplete;

			[Token(Token = "0x60031F3")]
			[Address(RVA = "0xB402FC", Offset = "0xB402FC", VA = "0xB402FC")]
			public _003C_003Ec__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60031F4")]
			[Address(RVA = "0xB40C68", Offset = "0xB40C68", VA = "0xB40C68")]
			internal void _003CQueryUserData_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x400123E")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, UserProfile> m_cachedProfileData;

		[Token(Token = "0x400123F")]
		[FieldOffset(Offset = "0x20")]
		private UserAnalyticsData m_cachedData;

		[Token(Token = "0x4001240")]
		[FieldOffset(Offset = "0x28")]
		private string m_endpoint;

		[Token(Token = "0x4001241")]
		[FieldOffset(Offset = "0x30")]
		private Action<WebRequest> m_WebSend;

		[Token(Token = "0x4001242")]
		[FieldOffset(Offset = "0x38")]
		private GetUserIDFunc m_getUserID;

		[Token(Token = "0x4001243")]
		[FieldOffset(Offset = "0x40")]
		private GetCurrentTime m_GetTime;

		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0x48")]
		protected List<string> m_profileFields;

		[Token(Token = "0x17000599")]
		public UserAnalyticsData Data
		{
			[Token(Token = "0x6001E20")]
			[Address(RVA = "0xB3F46C", Offset = "0xB3F46C", VA = "0xB3F46C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0xB3F190", Offset = "0xB3F190", VA = "0xB3F190")]
		public UserAnalyticsController(string endpoint, GetUserIDFunc getUserID, GetCurrentTime getTime, Action<WebRequest> webSend)
		{
		}

		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0xB3F254", Offset = "0xB3F254", VA = "0xB3F254", Slot = "10")]
		protected virtual void SetupProfileFields()
		{
		}

		[Token(Token = "0x6001E21")]
		[Address(RVA = "0xB3F3C0", Offset = "0xB3F3C0", VA = "0xB3F3C0")]
		protected void AddProfileField(string fieldName)
		{
		}

		[Token(Token = "0x6001E22")]
		[Address(RVA = "0xB3F538", Offset = "0xB3F538", VA = "0xB3F538")]
		public void QueryUserProfile(List<string> userIds, Action<bool, Dictionary<string, UserProfile>> onComplete)
		{
		}

		[Token(Token = "0x6001E23")]
		[Address(RVA = "0xB400FC", Offset = "0xB400FC", VA = "0xB400FC")]
		public void QueryUserData(string userId, Action<bool> onComplete, bool forceRefresh = false)
		{
		}

		[Token(Token = "0x6001E24")]
		[Address(RVA = "0xB407C4", Offset = "0xB407C4", VA = "0xB407C4")]
		public bool GetString(UserAnalytic key, out string value)
		{
			return default(bool);
		}

		[Token(Token = "0x6001E25")]
		[Address(RVA = "0xB407D0", Offset = "0xB407D0", VA = "0xB407D0")]
		public bool GetInt(UserAnalytic key, out int value)
		{
			return default(bool);
		}

		[Token(Token = "0x6001E26")]
		[Address(RVA = "0xB4084C", Offset = "0xB4084C", VA = "0xB4084C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x838DE0", Offset = "0x838DE0")]
		public bool GetLong(UserAnalytic key, out long value)
		{
			return default(bool);
		}

		[Token(Token = "0x6001E27")]
		[Address(RVA = "0xB4088C", Offset = "0xB4088C", VA = "0xB4088C")]
		public bool GetFloat(UserAnalytic key, out float value)
		{
			return default(bool);
		}

		[Token(Token = "0x6001E28")]
		[Address(RVA = "0xB40904", Offset = "0xB40904", VA = "0xB40904")]
		public bool GetBool(UserAnalytic key, out bool value)
		{
			return default(bool);
		}
	}
}
