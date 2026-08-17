using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003FC")]
	public class ScoreboardController : UkenController
	{
		[Token(Token = "0x20007C0")]
		public delegate void WebHandler(WebRequest request);

		[Token(Token = "0x20007C1")]
		public delegate void SaveDataFunc(ScoreboardSaveData dataToSave);

		[Token(Token = "0x20007C2")]
		public delegate ScoreboardSaveData LoadDataFunc();

		[Token(Token = "0x20007C3")]
		public delegate double GetCurrentUnixTime();

		[Token(Token = "0x20007C4")]
		public class QueryCache
		{
			[Token(Token = "0x200089A")]
			public class CacheEntry
			{
				[Token(Token = "0x200089D")]
				protected class EntryMetaData
				{
					[Token(Token = "0x4002492")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833244", Offset = "0x833244")]
					private int _003Cm_topUsersParam_003Ek__BackingField;

					[Token(Token = "0x4002493")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
					[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833254", Offset = "0x833254")]
					private int _003Cm_belowUsersParam_003Ek__BackingField;

					[Token(Token = "0x4002494")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833264", Offset = "0x833264")]
					private int _003Cm_aboveUsersParam_003Ek__BackingField;

					[Token(Token = "0x4002495")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833274", Offset = "0x833274")]
					private double _003Cm_expiryTime_003Ek__BackingField;

					[Token(Token = "0x1700083A")]
					public int m_topUsersParam
					{
						[Token(Token = "0x60033FA")]
						[Address(RVA = "0xB3D2E0", Offset = "0xB3D2E0", VA = "0xB3D2E0")]
						[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BE3C", Offset = "0x83BE3C")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x60033FB")]
						[Address(RVA = "0xB3D2F8", Offset = "0xB3D2F8", VA = "0xB3D2F8")]
						[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BE4C", Offset = "0x83BE4C")]
						private set
						{
						}
					}

					[Token(Token = "0x1700083B")]
					public int m_belowUsersParam
					{
						[Token(Token = "0x60033FC")]
						[Address(RVA = "0xB3D2F0", Offset = "0xB3D2F0", VA = "0xB3D2F0")]
						[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BE5C", Offset = "0x83BE5C")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x60033FD")]
						[Address(RVA = "0xB3D300", Offset = "0xB3D300", VA = "0xB3D300")]
						[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BE6C", Offset = "0x83BE6C")]
						private set
						{
						}
					}

					[Token(Token = "0x1700083C")]
					public int m_aboveUsersParam
					{
						[Token(Token = "0x60033FE")]
						[Address(RVA = "0xB3D2E8", Offset = "0xB3D2E8", VA = "0xB3D2E8")]
						[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BE7C", Offset = "0x83BE7C")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x60033FF")]
						[Address(RVA = "0xB3D308", Offset = "0xB3D308", VA = "0xB3D308")]
						[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BE8C", Offset = "0x83BE8C")]
						private set
						{
						}
					}

					[Token(Token = "0x1700083D")]
					public double m_expiryTime
					{
						[Token(Token = "0x6003400")]
						[Address(RVA = "0xB3D2D8", Offset = "0xB3D2D8", VA = "0xB3D2D8")]
						[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BE9C", Offset = "0x83BE9C")]
						get
						{
							return default(double);
						}
						[Token(Token = "0x6003401")]
						[Address(RVA = "0xB3D310", Offset = "0xB3D310", VA = "0xB3D310")]
						[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BEAC", Offset = "0x83BEAC")]
						private set
						{
						}
					}

					[Token(Token = "0x6003402")]
					[Address(RVA = "0xB3D288", Offset = "0xB3D288", VA = "0xB3D288")]
					public EntryMetaData(double expiryTime, int topUsers, int aboveUsers, int belowUsers)
					{
					}
				}

				[Token(Token = "0x4002487")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833234", Offset = "0x833234")]
				private ScoreboardScoreData _003Cm_scoreData_003Ek__BackingField;

				[Token(Token = "0x4002488")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				protected EntryMetaData m_metaData;

				[Token(Token = "0x17000839")]
				public ScoreboardScoreData m_scoreData
				{
					[Token(Token = "0x60033F4")]
					[Address(RVA = "0xB3D278", Offset = "0xB3D278", VA = "0xB3D278")]
					[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BE1C", Offset = "0x83BE1C")]
					get
					{
						return null;
					}
					[Token(Token = "0x60033F5")]
					[Address(RVA = "0xB3D280", Offset = "0xB3D280", VA = "0xB3D280")]
					[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BE2C", Offset = "0x83BE2C")]
					protected set
					{
					}
				}

				[Token(Token = "0x60033F6")]
				[Address(RVA = "0xB3D114", Offset = "0xB3D114", VA = "0xB3D114")]
				public CacheEntry(ScoreboardScoreData scoreData, double expiryTime, int topUsers, int aboveUsers, int belowUsers)
				{
				}

				[Token(Token = "0x60033F7")]
				[Address(RVA = "0xB3D1BC", Offset = "0xB3D1BC", VA = "0xB3D1BC")]
				public bool IsValid(double currentTime, int topUsersParam, int aboveUsersParam, int belowUsersParam)
				{
					return default(bool);
				}
			}

			[Token(Token = "0x40022A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			protected Dictionary<string, CacheEntry> m_cache;

			[Token(Token = "0x600320C")]
			[Address(RVA = "0xB3C1E4", Offset = "0xB3C1E4", VA = "0xB3C1E4")]
			public void Cache(string cacheKey, ScoreboardScoreData scoreData, double cacheExpiry, int topUsersParam, int aboveUsersParam, int belowUsersParam)
			{
			}

			[Token(Token = "0x600320D")]
			[Address(RVA = "0xB3BDE4", Offset = "0xB3BDE4", VA = "0xB3BDE4")]
			public ScoreboardScoreData Get(string cacheKey, double currentTime, int topUsersParam, int aboveUsersParam, int belowUsersParam)
			{
				return null;
			}

			[Token(Token = "0x600320E")]
			[Address(RVA = "0xB3C110", Offset = "0xB3C110", VA = "0xB3C110")]
			public void Expire(string cacheKey)
			{
			}

			[Token(Token = "0x600320F")]
			[Address(RVA = "0xB3C0A0", Offset = "0xB3C0A0", VA = "0xB3C0A0")]
			public QueryCache()
			{
			}
		}

		[Token(Token = "0x20007C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821018", Offset = "0x821018")]
		private sealed class _003C_003Ec__DisplayClass29_0
		{
			[Token(Token = "0x40022A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScoreboardController _003C_003E4__this;

			[Token(Token = "0x40022A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<bool, ScoreboardResultResponse> onComplete;

			[Token(Token = "0x6003210")]
			[Address(RVA = "0xB3972C", Offset = "0xB3972C", VA = "0xB3972C")]
			public _003C_003Ec__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6003211")]
			[Address(RVA = "0xB3C4F8", Offset = "0xB3C4F8", VA = "0xB3C4F8")]
			internal void _003CQueryResults_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x20007C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821028", Offset = "0x821028")]
		private sealed class _003C_003Ec__DisplayClass30_0
		{
			[Token(Token = "0x40022A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScoreboardController _003C_003E4__this;

			[Token(Token = "0x40022A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<string> entityIDs;

			[Token(Token = "0x40022A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<bool, ScoreboardScoreQueryResponse> onComplete;

			[Token(Token = "0x40022A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<ScoreboardDefinition> requestedScoreboards;

			[Token(Token = "0x40022A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ScoreboardScoreData[][] scoreData;

			[Token(Token = "0x40022AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<int> requestedScoreboardIndices;

			[Token(Token = "0x40022AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int top;

			[Token(Token = "0x40022AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public int above;

			[Token(Token = "0x40022AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int below;

			[Token(Token = "0x40022AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public double cacheDuration;

			[Token(Token = "0x40022AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public ScoreboardScoreQueryResponse query;

			[Token(Token = "0x6003212")]
			[Address(RVA = "0xB3A70C", Offset = "0xB3A70C", VA = "0xB3A70C")]
			public _003C_003Ec__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6003213")]
			[Address(RVA = "0xB3C6B0", Offset = "0xB3C6B0", VA = "0xB3C6B0")]
			internal void _003CQueryScoreboards_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x20007C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821038", Offset = "0x821038")]
		private sealed class _003C_003Ec__DisplayClass31_0
		{
			[Token(Token = "0x40022B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool, ScoreboardPostScoreResponse> onComplete;

			[Token(Token = "0x40022B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ScoreboardController _003C_003E4__this;

			[Token(Token = "0x40022B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string entityID;

			[Token(Token = "0x6003214")]
			[Address(RVA = "0xB3AD34", Offset = "0xB3AD34", VA = "0xB3AD34")]
			public _003C_003Ec__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6003215")]
			[Address(RVA = "0xB3CB78", Offset = "0xB3CB78", VA = "0xB3CB78")]
			internal void _003CPostEvent_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x20007C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821048", Offset = "0x821048")]
		private sealed class _003C_003Ec__DisplayClass32_0
		{
			[Token(Token = "0x40022B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> scoreboardEntityTotals;

			[Token(Token = "0x40022B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<bool, ScoreboardTotalEntitiesQueryResponse> onComplete;

			[Token(Token = "0x6003216")]
			[Address(RVA = "0xB3B254", Offset = "0xB3B254", VA = "0xB3B254")]
			public _003C_003Ec__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6003217")]
			[Address(RVA = "0xB3CDB0", Offset = "0xB3CDB0", VA = "0xB3CDB0")]
			internal void _003CQueryTotalEntities_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x400129C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string InventoryStorageItem;

		[Token(Token = "0x400129D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string InventoryStorageItemTrait;

		[Token(Token = "0x400129E")]
		private const int DefaultCacheDuration = 120;

		[Token(Token = "0x400129F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, QueryCache> m_queryCache;

		[Token(Token = "0x40012A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Queue<ScoreboardPostScoreRequest> postQueue;

		[Token(Token = "0x40012A1")]
		private const int MaxActivePosts = 3;

		[Token(Token = "0x40012A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int activePosts;

		[Token(Token = "0x40012A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E3C8", Offset = "0x82E3C8")]
		private int _003Cm_lastResultTime_003Ek__BackingField;

		[Token(Token = "0x40012A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ScoreboardResultRequest resultRequest;

		[Token(Token = "0x40012A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected WebHandler m_webHandler;

		[Token(Token = "0x40012A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected string m_resultRoute;

		[Token(Token = "0x40012A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected string m_queryRoute;

		[Token(Token = "0x40012A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected string m_postRoute;

		[Token(Token = "0x40012A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected string m_totalEntitiesRoute;

		[Token(Token = "0x40012AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SaveDataFunc m_saveData;

		[Token(Token = "0x40012AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private LoadDataFunc m_loadData;

		[Token(Token = "0x40012AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GetCurrentUnixTime m_getCurrentUnixTime;

		[Token(Token = "0x40012AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool bReadyForUse;

		[Token(Token = "0x1700059B")]
		public int m_lastResultTime
		{
			[Token(Token = "0x6001E5A")]
			[Address(RVA = "0xB38638", Offset = "0xB38638", VA = "0xB38638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838E70", Offset = "0x838E70")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001E5B")]
			[Address(RVA = "0xB38640", Offset = "0xB38640", VA = "0xB38640")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838E80", Offset = "0x838E80")]
			protected set
			{
			}
		}

		[Token(Token = "0x6001E5C")]
		[Address(RVA = "0xB38648", Offset = "0xB38648", VA = "0xB38648")]
		public ScoreboardController(WebHandler webHandler, string baseURL, SaveDataFunc saveDataFunc, LoadDataFunc loadDataFunc, GetCurrentUnixTime getUnixTimeFunc)
		{
		}

		[Token(Token = "0x6001E5D")]
		[Address(RVA = "0xB38790", Offset = "0xB38790", VA = "0xB38790", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6001E5E")]
		[Address(RVA = "0xB3887C", Offset = "0xB3887C", VA = "0xB3887C")]
		public void LoadSaveData()
		{
		}

		[Token(Token = "0x6001E5F")]
		[Address(RVA = "0xB38CE8", Offset = "0xB38CE8", VA = "0xB38CE8")]
		public void SaveData()
		{
		}

		[Token(Token = "0x6001E60")]
		[Address(RVA = "0xB39550", Offset = "0xB39550", VA = "0xB39550")]
		public void QueryResults(List<string> entityIDs, Action<bool, ScoreboardResultResponse> onComplete)
		{
		}

		[Token(Token = "0x6001E61")]
		[Address(RVA = "0xB39F70", Offset = "0xB39F70", VA = "0xB39F70")]
		public void QueryScoreboards(List<ScoreboardDefinition> scoreboards, List<string> entityIDs, int top, int above, int below, Action<bool, ScoreboardScoreQueryResponse> onComplete, double cacheDuration = 120.0)
		{
		}

		[Token(Token = "0x6001E62")]
		[Address(RVA = "0xB3AAE0", Offset = "0xB3AAE0", VA = "0xB3AAE0")]
		public void PostEvent(List<ScoreboardDefinition> scoreboards, string entityID, string entityData, long value, Action<bool, ScoreboardPostScoreResponse> onComplete, bool absolute = false, [Optional] List<string> segments)
		{
		}

		[Token(Token = "0x6001E63")]
		[Address(RVA = "0xB3AFAC", Offset = "0xB3AFAC", VA = "0xB3AFAC")]
		public void QueryTotalEntities(List<ScoreboardDefinition> scoreboards, Action<bool, ScoreboardTotalEntitiesQueryResponse> onComplete)
		{
		}

		[Token(Token = "0x6001E64")]
		[Address(RVA = "0xB38D94", Offset = "0xB38D94", VA = "0xB38D94")]
		private bool IsScoreboardReadyForUse()
		{
			return default(bool);
		}

		[Token(Token = "0x6001E65")]
		[Address(RVA = "0xB3B308", Offset = "0xB3B308", VA = "0xB3B308")]
		private bool AreEntityResultsValid(List<ScoreboardScoreData> entityResults, int scoreboardsRequested, Action<bool, ScoreboardScoreQueryResponse> onFailure)
		{
			return default(bool);
		}

		[Token(Token = "0x6001E66")]
		[Address(RVA = "0xB3B3EC", Offset = "0xB3B3EC", VA = "0xB3B3EC")]
		private bool IsScoreQueryResponseValid(ScoreboardScoreQueryResponse response, int entitiesRequested, Action<bool, ScoreboardScoreQueryResponse> onFailure)
		{
			return default(bool);
		}

		[Token(Token = "0x6001E67")]
		[Address(RVA = "0xB38794", Offset = "0xB38794", VA = "0xB38794")]
		private void UpdatePostQueue()
		{
		}

		[Token(Token = "0x6001E68")]
		[Address(RVA = "0xB3AF3C", Offset = "0xB3AF3C", VA = "0xB3AF3C")]
		private void QueuePost(ScoreboardPostScoreRequest postRequest)
		{
		}

		[Token(Token = "0x6001E69")]
		[Address(RVA = "0xB3B4EC", Offset = "0xB3B4EC", VA = "0xB3B4EC")]
		private ScoreboardPostScoreRequest DequeuePost()
		{
			return null;
		}

		[Token(Token = "0x6001E6A")]
		[Address(RVA = "0xB3B59C", Offset = "0xB3B59C", VA = "0xB3B59C")]
		public void QueryScoreboard(ScoreboardDefinition scoreboard, string entityID, int top, int above, int below, Action<bool, ScoreboardScoreQueryResponse> onComplete, double cacheDuration = 120.0)
		{
		}

		[Token(Token = "0x6001E6B")]
		[Address(RVA = "0xB3B680", Offset = "0xB3B680", VA = "0xB3B680")]
		public void QueryScoreboard(ScoreboardDefinition scoreboard, List<string> entityIDs, int top, int above, int below, Action<bool, ScoreboardScoreQueryResponse> onComplete, double cacheDuration = 120.0)
		{
		}

		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0xB3B764", Offset = "0xB3B764", VA = "0xB3B764")]
		public void PostEvent(ScoreboardDefinition scoreboard, string entityID, string entityData, long value, Action<bool, ScoreboardPostScoreResponse> onComplete, bool absolute = false)
		{
		}

		[Token(Token = "0x6001E6D")]
		[Address(RVA = "0xB3B848", Offset = "0xB3B848", VA = "0xB3B848")]
		protected double GetCacheExpiryTime(double cacheDuration)
		{
			return default(double);
		}

		[Token(Token = "0x6001E6E")]
		[Address(RVA = "0xB3A788", Offset = "0xB3A788", VA = "0xB3A788")]
		protected bool GetCachedScoreDataForEntities(List<string> entityIDs, string scoreboardName, int scoreboardIndex, int top, int above, int below, ref ScoreboardScoreData[][] scoreData)
		{
			return default(bool);
		}

		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0xB3BCB8", Offset = "0xB3BCB8", VA = "0xB3BCB8")]
		protected ScoreboardScoreData GetCachedScoreDataForEntity(string entityID, string scoreboardName, int top, int above, int below)
		{
			return null;
		}

		[Token(Token = "0x6001E70")]
		[Address(RVA = "0xB3BEF0", Offset = "0xB3BEF0", VA = "0xB3BEF0")]
		protected void CacheScoreQueryForEntity(string entityID, ScoreboardScoreData scoreData, int top, int above, int below, double cacheDuration)
		{
		}

		[Token(Token = "0x6001E71")]
		[Address(RVA = "0xB3C31C", Offset = "0xB3C31C", VA = "0xB3C31C")]
		protected void UpdateQueryCacheForPostResponse(string entityID, ScoreboardPostScoreResponse postResponse)
		{
		}
	}
}
