// API v1.9.3 

// RELEASE STATIC

// OLD API VERSION: 8.4.2
// NEW GITHUB

// TOKENS LISTED FOR DRILL SHORTCUTS!

[assembly: TypeForwardedTo(typeof(Registry))]
[assembly: TypeForwardedTo(typeof(RegistryAccessRule))]
[assembly: TypeForwardedTo(typeof(RegistryAuditRule))]
[assembly: TypeForwardedTo(typeof(RegistryHive))]
[assembly: TypeForwardedTo(typeof(RegistryKey))]
[assembly: TypeForwardedTo(typeof(RegistryKeyPermissionCheck))]
[assembly: TypeForwardedTo(typeof(RegistryOptions))]
[assembly: TypeForwardedTo(typeof(RegistryRights))]
[assembly: TypeForwardedTo(typeof(RegistrySecurity))]
[assembly: TypeForwardedTo(typeof(RegistryValueKind))]
[assembly: TypeForwardedTo(typeof(RegistryValueOptions))]
[assembly: TypeForwardedTo(typeof(RegistryView))]
[assembly: TypeForwardedTo(typeof(SafeRegistryHandle))]
// Token: 0x02000013 RID: 19
	internal static class SafeHandleCache<T> where T : SafeHandle
	{
		// Token: 0x06000072 RID: 114 RVA: 0x000045C8 File Offset: 0x000031C8
		internal static T GetInvalidHandle(Func<T> invalidHandleFactory)
		{
			T t = Volatile.Read<T>(ref SafeHandleCache<T>.s_invalidHandle);
			if (t == null)
			{
				T t2 = invalidHandleFactory();
				t = Interlocked.CompareExchange<T>(ref SafeHandleCache<T>.s_invalidHandle, t2, default(T));
				if (t == null)
				{
					GC.SuppressFinalize(t2);
					t = t2;
				}
				else
				{
					t2.Dispose();
				}
			}
			return t;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004628 File Offset: 0x00003228
		internal static bool IsCachedInvalidHandle(SafeHandle handle)
		{
			return handle == Volatile.Read<T>(ref SafeHandleCache<T>.s_invalidHandle);
		}

		// Token: 0x04000027 RID: 39
		private static T s_invalidHandle;
	}
// System.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(BitArray))]
[assembly: TypeForwardedTo(typeof(StructuralComparisons))]
// System.Collections.Concurrent, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(ConcurrentDictionary<, >))]
[assembly: TypeForwardedTo(typeof(ConcurrentStack<>))]
[assembly: TypeForwardedTo(typeof(EnumerablePartitionerOptions))]
[assembly: TypeForwardedTo(typeof(OrderablePartitioner<>))]
[assembly: TypeForwardedTo(typeof(Partitioner))]
[assembly: TypeForwardedTo(typeof(Partitioner<>))]
// System.Collections.NonGeneric, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(CaseInsensitiveComparer))]
[assembly: TypeForwardedTo(typeof(CaseInsensitiveHashCodeProvider))]
[assembly: TypeForwardedTo(typeof(CollectionBase))]
[assembly: TypeForwardedTo(typeof(DictionaryBase))]
[assembly: TypeForwardedTo(typeof(Queue))]
[assembly: TypeForwardedTo(typeof(Queue.QueueDebugView))]
[assembly: TypeForwardedTo(typeof(ReadOnlyCollectionBase))]
[assembly: TypeForwardedTo(typeof(SortedList))]
[assembly: TypeForwardedTo(typeof(SortedList.SortedListDebugView))]
[assembly: TypeForwardedTo(typeof(Stack))]
[assembly: TypeForwardedTo(typeof(Stack.StackDebugView))]
// System.ComponentModel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(IServiceProvider))]
// System.Console, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(Console))]
[assembly: TypeForwardedTo(typeof(ConsoleCancelEventArgs))]
[assembly: TypeForwardedTo(typeof(ConsoleCancelEventHandler))]
[assembly: TypeForwardedTo(typeof(ConsoleColor))]
[assembly: TypeForwardedTo(typeof(ConsoleKey))]
[assembly: TypeForwardedTo(typeof(ConsoleKeyInfo))]
[assembly: TypeForwardedTo(typeof(ConsoleModifiers))]
[assembly: TypeForwardedTo(typeof(ConsoleSpecialKey))]
// System.Diagnostics.StackTrace, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(ISymbolBinder))]
[assembly: TypeForwardedTo(typeof(ISymbolBinder1))]
[assembly: TypeForwardedTo(typeof(ISymbolDocument))]
[assembly: TypeForwardedTo(typeof(ISymbolMethod))]
[assembly: TypeForwardedTo(typeof(ISymbolNamespace))]
[assembly: TypeForwardedTo(typeof(ISymbolReader))]
[assembly: TypeForwardedTo(typeof(ISymbolScope))]
[assembly: TypeForwardedTo(typeof(ISymbolVariable))]
[assembly: TypeForwardedTo(typeof(ISymbolWriter))]
[assembly: TypeForwardedTo(typeof(SymAddressKind))]
[assembly: TypeForwardedTo(typeof(SymbolToken))]
[assembly: TypeForwardedTo(typeof(SymDocumentType))]
[assembly: TypeForwardedTo(typeof(SymLanguageType))]
[assembly: TypeForwardedTo(typeof(SymLanguageVendor))]
// System.IO.FileSystem, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(Directory))]
[assembly: TypeForwardedTo(typeof(DirectoryInfo))]
[assembly: TypeForwardedTo(typeof(File))]
[assembly: TypeForwardedTo(typeof(FileInfo))]
[assembly: TypeForwardedTo(typeof(FileSystemInfo))]
[assembly: TypeForwardedTo(typeof(SearchOption))]
// System.IO.FileSystem.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(DirectoryObjectSecurity))]
[assembly: TypeForwardedTo(typeof(DirectorySecurity))]
[assembly: TypeForwardedTo(typeof(FileSecurity))]
[assembly: TypeForwardedTo(typeof(FileSystemAccessRule))]
[assembly: TypeForwardedTo(typeof(FileSystemAuditRule))]
[assembly: TypeForwardedTo(typeof(FileSystemRights))]
[assembly: TypeForwardedTo(typeof(FileSystemSecurity))]
// System.IO.FileSystem.DriveInfo, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(DriveInfo))]
[assembly: TypeForwardedTo(typeof(DriveNotFoundException))]
[assembly: TypeForwardedTo(typeof(DriveType))]
// System.IO.IsolatedStorage, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(INormalizeForIsolatedStorage))]
[assembly: TypeForwardedTo(typeof(IsolatedStorage))]
[assembly: TypeForwardedTo(typeof(IsolatedStorageException))]
using System;
using System.Resources;
using FxResources.System.ComponentModel.Primitives;

namespace System
{
	// Token: 0x02000007 RID: 7
	internal static class SR
	{
		// Token: 0x06000005 RID: 5 RVA: 0x0000324E File Offset: 0x00001C4E
		private static bool UsingResourceKeys()
		{
			return System.SR.s_usingResourceKeys;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00003258 File Offset: 0x00001C58
		internal static string GetResourceString(string resourceKey, string defaultString = null)
		{
			if (System.SR.UsingResourceKeys())
			{
				return defaultString ?? resourceKey;
			}
			string text = null;
			try
			{
				text = System.SR.ResourceManager.GetString(resourceKey);
			}
			catch (MissingManifestResourceException)
			{
			}
			if (defaultString != null && resourceKey.Equals(text))
			{
				return defaultString;
			}
			return text;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000032A8 File Offset: 0x00001CA8
		internal static string Format(string resourceFormat, object p1, object p2, object p3)
		{
			if (System.SR.UsingResourceKeys())
			{
				return string.Join(", ", new object[]
				{
					resourceFormat,
					p1,
					p2,
					p3
				});
			}
			return string.Format(resourceFormat, p1, p2, p3);
		}

		// Token: 0x17000001 RID: 1
		
		internal static ResourceManager ResourceManager
		{
			get
			{
				ResourceManager result;
				if ((result = System.SR.s_resourceManager) == null)
				{
					result = (System.SR.s_resourceManager = new ResourceManager(typeof(FxResources.System.ComponentModel.Primitives.SR)));
				}
				return result;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000032FB File Offset: 0x00001CFB
		internal static string InvalidEnumArgument
		{
			get
			{
				return System.SR.GetResourceString("InvalidEnumArgument", null);
			}
		}


		static SR()
		{
			bool flag;
			System.SR.s_usingResourceKeys = (AppContext.TryGetSwitch("System.Resources.UseSystemResourceKeys", out flag) && flag);
		}


		private static readonly bool s_usingResourceKeys;

		// Token: 0x04000005 RID: 5
		private static ResourceManager s_resourceManager;
	}
}

[assembly: TypeForwardedTo(typeof(IsolatedStorageFile))]
[assembly: TypeForwardedTo(typeof(IsolatedStorageFile.IsolatedStorageFileEnumerator))]
[assembly: TypeForwardedTo(typeof(IsolatedStorageFileStream))]
[assembly: TypeForwardedTo(typeof(IsolatedStorageScope))]
// System.ObjectModel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(ReadOnlyDictionary<, >.KeyCollection))]
[assembly: TypeForwardedTo(typeof(KeyedCollection<, >))]
[assembly: TypeForwardedTo(typeof(ReadOnlyDictionary<, >))]
[assembly: TypeForwardedTo(typeof(ReadOnlyDictionary<, >.ValueCollection))]
// System.Private.CoreLib, Version=0.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
[assembly: TypeForwardedTo(typeof(AbandonedMutexException))]
[assembly: TypeForwardedTo(typeof(AccessedThroughPropertyAttribute))]
[assembly: TypeForwardedTo(typeof(AccessViolationException))]
[assembly: TypeForwardedTo(typeof(Action))]
[assembly: TypeForwardedTo(typeof(Action<>))]
[assembly: TypeForwardedTo(typeof(Action<, >))]
[assembly: TypeForwardedTo(typeof(Action<, , >))]
[assembly: TypeForwardedTo(typeof(Action<, , , >))]
[assembly: TypeForwardedTo(typeof(Action<, , , , >))]
[assembly: TypeForwardedTo(typeof(Action<, , , , , >))]
[assembly: TypeForwardedTo(typeof(Action<, , , , , , >))]
[assembly: TypeForwardedTo(typeof(Action<, , , , , , , >))]
[assembly: TypeForwardedTo(typeof(Activator))]
[assembly: TypeForwardedTo(typeof(TimeZoneInfo.AdjustmentRule))]
[assembly: TypeForwardedTo(typeof(AggregateException))]
[assembly: TypeForwardedTo(typeof(AllowPartiallyTrustedCallersAttribute))]
[assembly: TypeForwardedTo(typeof(AllowReversePInvokeCallsAttribute))]
[assembly: TypeForwardedTo(typeof(AmbiguousMatchException))]
[assembly: TypeForwardedTo(typeof(ApartmentState))]
[assembly: TypeForwardedTo(typeof(AppContext))]
[assembly: TypeForwardedTo(typeof(AppDomain))]
[assembly: TypeForwardedTo(typeof(AppDomainSetup))]
[assembly: TypeForwardedTo(typeof(AppDomainUnloadedException))]
[assembly: TypeForwardedTo(typeof(ApplicationException))]
[assembly: TypeForwardedTo(typeof(ApplicationId))]
[assembly: TypeForwardedTo(typeof(ArgIterator))]
[assembly: TypeForwardedTo(typeof(ArgumentException))]
[assembly: TypeForwardedTo(typeof(ArgumentNullException))]
[assembly: TypeForwardedTo(typeof(ArgumentOutOfRangeException))]
[assembly: TypeForwardedTo(typeof(ArithmeticException))]
[assembly: TypeForwardedTo(typeof(Array))]
[assembly: TypeForwardedTo(typeof(ArrayList))]
[assembly: TypeForwardedTo(typeof(ArrayList.ArrayListDebugView))]
[assembly: TypeForwardedTo(typeof(ArraySegment<>))]
[assembly: TypeForwardedTo(typeof(ArrayTypeMismatchException))]
[assembly: TypeForwardedTo(typeof(ArrayWithOffset))]
[assembly: TypeForwardedTo(typeof(ASCIIEncoding))]
[assembly: TypeForwardedTo(typeof(ASCIIEncoding.ASCIIEncodingSealed))]
[assembly: TypeForwardedTo(typeof(Assembly))]
[assembly: TypeForwardedTo(typeof(AssemblyAlgorithmIdAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyBuilder))]
[assembly: TypeForwardedTo(typeof(AssemblyBuilderAccess))]
[assembly: TypeForwardedTo(typeof(AssemblyCompanyAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyConfigurationAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyContentType))]
[assembly: TypeForwardedTo(typeof(AssemblyCopyrightAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyCultureAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyDefaultAliasAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyDelaySignAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyDescriptionAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyFileVersionAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyFlagsAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyHashAlgorithm))]
[assembly: TypeForwardedTo(typeof(AssemblyInformationalVersionAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyKeyFileAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyKeyNameAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyLoadEventArgs))]
[assembly: TypeForwardedTo(typeof(AssemblyLoadEventHandler))]
[assembly: TypeForwardedTo(typeof(AssemblyMetadataAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyName))]
[assembly: TypeForwardedTo(typeof(AssemblyNameFlags))]
[assembly: TypeForwardedTo(typeof(AssemblyNameProxy))]
[assembly: TypeForwardedTo(typeof(AssemblyProductAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblySignatureKeyAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyTargetedPatchBandAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyTitleAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyTrademarkAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyVersionAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyVersionCompatibility))]
[assembly: TypeForwardedTo(typeof(AsyncCallback))]
[assembly: TypeForwardedTo(typeof(AsyncFlowControl))]
[assembly: TypeForwardedTo(typeof(AsyncLocalValueChangedArgs<>))]
[assembly: TypeForwardedTo(typeof(AsyncLocal<>))]
[assembly: TypeForwardedTo(typeof(AsyncStateMachineAttribute))]
[assembly: TypeForwardedTo(typeof(AsyncTaskMethodBuilder))]
[assembly: TypeForwardedTo(typeof(AsyncTaskMethodBuilder<>))]
[assembly: TypeForwardedTo(typeof(AsyncVoidMethodBuilder))]
[assembly: TypeForwardedTo(typeof(Attribute))]
[assembly: TypeForwardedTo(typeof(AttributeTargets))]
[assembly: TypeForwardedTo(typeof(AttributeUsageAttribute))]
[assembly: TypeForwardedTo(typeof(AutoResetEvent))]
[assembly: TypeForwardedTo(typeof(BadImageFormatException))]
[assembly: TypeForwardedTo(typeof(Base64FormattingOptions))]
[assembly: TypeForwardedTo(typeof(BestFitMappingAttribute))]
[assembly: TypeForwardedTo(typeof(BinaryReader))]
[assembly: TypeForwardedTo(typeof(BinaryWriter))]
[assembly: TypeForwardedTo(typeof(Binder))]
[assembly: TypeForwardedTo(typeof(BindingFlags))]
[assembly: TypeForwardedTo(typeof(BINDPTR))]
[assembly: TypeForwardedTo(typeof(BIND_OPTS))]
[assembly: TypeForwardedTo(typeof(BitConverter))]
[assembly: TypeForwardedTo(typeof(bool))]
[assembly: TypeForwardedTo(typeof(BStrWrapper))]
[assembly: TypeForwardedTo(typeof(Buffer))]
[assembly: TypeForwardedTo(typeof(BufferedStream))]
[assembly: TypeForwardedTo(typeof(byte))]
[assembly: TypeForwardedTo(typeof(ByteEqualityComparer))]
[assembly: TypeForwardedTo(typeof(Calendar))]
[assembly: TypeForwardedTo(typeof(CalendarAlgorithmType))]
[assembly: TypeForwardedTo(typeof(CalendarWeekRule))]
[assembly: TypeForwardedTo(typeof(CancellationTokenSource.CallbackNode))]
[assembly: TypeForwardedTo(typeof(CancellationTokenSource.CallbackPartition))]
[assembly: TypeForwardedTo(typeof(CALLCONV))]
[assembly: TypeForwardedTo(typeof(CallConvCdecl))]
[assembly: TypeForwardedTo(typeof(CallConvFastcall))]
[assembly: TypeForwardedTo(typeof(CallConvStdcall))]
[assembly: TypeForwardedTo(typeof(CallConvThiscall))]
[assembly: TypeForwardedTo(typeof(CallerFilePathAttribute))]
[assembly: TypeForwardedTo(typeof(CallerLineNumberAttribute))]
[assembly: TypeForwardedTo(typeof(CallerMemberNameAttribute))]
[assembly: TypeForwardedTo(typeof(CallingConvention))]
[assembly: TypeForwardedTo(typeof(CallingConventions))]
[assembly: TypeForwardedTo(typeof(CancellationToken))]
[assembly: TypeForwardedTo(typeof(CancellationTokenRegistration))]
[assembly: TypeForwardedTo(typeof(CancellationTokenSource))]
[assembly: TypeForwardedTo(typeof(CannotUnloadAppDomainException))]
[assembly: TypeForwardedTo(typeof(Cer))]
[assembly: TypeForwardedTo(typeof(char))]
[assembly: TypeForwardedTo(typeof(CharEnumerator))]
[assembly: TypeForwardedTo(typeof(CharSet))]
[assembly: TypeForwardedTo(typeof(CharUnicodeInfo))]
[assembly: TypeForwardedTo(typeof(ChineseLunisolarCalendar))]
[assembly: TypeForwardedTo(typeof(StringBuilder.ChunkEnumerator))]
[assembly: TypeForwardedTo(typeof(ClassInterfaceAttribute))]
[assembly: TypeForwardedTo(typeof(ClassInterfaceType))]
[assembly: TypeForwardedTo(typeof(RuntimeHelpers.CleanupCode))]
[assembly: TypeForwardedTo(typeof(CLSCompliantAttribute))]
[assembly: TypeForwardedTo(typeof(CoClassAttribute))]
[assembly: TypeForwardedTo(typeof(CodeAccessSecurityAttribute))]
// Token: 0x0200004A RID: 74
	internal sealed class DeviceContext : MarshalByRefObject, IDeviceContext, IDisposable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060005A3 RID: 1443 RVA: 0x00022588 File Offset: 0x00020B88
		// (remove) Token: 0x060005A4 RID: 1444 RVA: 0x000225C0 File Offset: 0x00020BC0
		public event EventHandler Disposing;

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x000225F5 File Offset: 0x00020BF5
		public IntPtr Hdc
		{
			get
			{
				if (this._hDC == IntPtr.Zero && this._dcType == DeviceContextType.Display)
				{
					this._hDC = ((IDeviceContext)this).GetHdc();
					this.CacheInitialState();
				}
				return this._hDC;
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0002262C File Offset: 0x00020C2C
		private void CacheInitialState()
		{
			this._hCurrentPen = (this._hInitialPen = Interop.Gdi32.GetCurrentObject(new HandleRef(this, this._hDC), Interop.Gdi32.ObjectType.OBJ_PEN));
			this._hCurrentBrush = (this._hInitialBrush = Interop.Gdi32.GetCurrentObject(new HandleRef(this, this._hDC), Interop.Gdi32.ObjectType.OBJ_BRUSH));
			this._hCurrentBmp = (this._hInitialBmp = Interop.Gdi32.GetCurrentObject(new HandleRef(this, this._hDC), Interop.Gdi32.ObjectType.OBJ_BITMAP));
			this._hCurrentFont = (this._hInitialFont = Interop.Gdi32.GetCurrentObject(new HandleRef(this, this._hDC), Interop.Gdi32.ObjectType.OBJ_FONT));
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000226BD File Offset: 0x00020CBD
		private DeviceContext(IntPtr hWnd)
		{
			this._hWnd = hWnd;
			this._dcType = DeviceContextType.Display;
			DeviceContexts.AddDeviceContext(this);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000226E8 File Offset: 0x00020CE8
		private DeviceContext(IntPtr hDC, DeviceContextType dcType)
		{
			this._hDC = hDC;
			this._dcType = dcType;
			this.CacheInitialState();
			DeviceContexts.AddDeviceContext(this);
			if (dcType == DeviceContextType.Display)
			{
				this._hWnd = Interop.User32.WindowFromDC(new HandleRef(this, this._hDC));
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0002273C File Offset: 0x00020D3C
		public static DeviceContext CreateDC(string driverName, string deviceName, string fileName, IntPtr devMode)
		{
			IntPtr hDC = Interop.Gdi32.CreateDCW(driverName, deviceName, fileName, devMode);
			return new DeviceContext(hDC, DeviceContextType.NamedDevice);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0002275C File Offset: 0x00020D5C
		public static DeviceContext CreateIC(string driverName, string deviceName, string fileName, IntPtr devMode)
		{
			IntPtr hDC = Interop.Gdi32.CreateICW(driverName, deviceName, fileName, devMode);
			return new DeviceContext(hDC, DeviceContextType.Information);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0002277C File Offset: 0x00020D7C
		public static DeviceContext FromCompatibleDC(IntPtr hdc)
		{
			IntPtr hDC = Interop.Gdi32.CreateCompatibleDC(hdc);
			return new DeviceContext(hDC, DeviceContextType.Memory);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00022797 File Offset: 0x00020D97
		public static DeviceContext FromHdc(IntPtr hdc)
		{
			return new DeviceContext(hdc, DeviceContextType.Unknown);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000227A0 File Offset: 0x00020DA0
		public static DeviceContext FromHwnd(IntPtr hwnd)
		{
			return new DeviceContext(hwnd);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x000227A8 File Offset: 0x00020DA8
		~DeviceContext()
		{
			this.Dispose(false);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x000227D8 File Offset: 0x00020DD8
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000227E8 File Offset: 0x00020DE8
		internal void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			EventHandler disposing2 = this.Disposing;
			if (disposing2 != null)
			{
				disposing2(this, EventArgs.Empty);
			}
			this._disposed = true;
			switch (this._dcType)
			{
			case DeviceContextType.Unknown:
			case DeviceContextType.NCWindow:
				return;
			case DeviceContextType.Display:
				((IDeviceContext)this).ReleaseHdc();
				return;
			case DeviceContextType.NamedDevice:
			case DeviceContextType.Information:
				Interop.Gdi32.DeleteDC(new HandleRef(this, this._hDC));
				this._hDC = IntPtr.Zero;
				return;
			case DeviceContextType.Memory:
				Interop.Gdi32.DeleteDC(new HandleRef(this, this._hDC));
				this._hDC = IntPtr.Zero;
				return;
			default:
				return;
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00022885 File Offset: 0x00020E85
		IntPtr IDeviceContext.GetHdc()
		{
			if (this._hDC == IntPtr.Zero)
			{
				this._hDC = Interop.User32.GetDC(new HandleRef(this, this._hWnd));
			}
			return this._hDC;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000228B8 File Offset: 0x00020EB8
		void IDeviceContext.ReleaseHdc()
		{
			if (this._hDC != IntPtr.Zero && this._dcType == DeviceContextType.Display)
			{
				Interop.User32.ReleaseDC(new HandleRef(this, this._hWnd), new HandleRef(this, this._hDC));
				this._hDC = IntPtr.Zero;
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0002290C File Offset: 0x00020F0C
		public void RestoreHdc()
		{
			Interop.Gdi32.RestoreDC(new HandleRef(this, this._hDC), -1);
			if (this._contextStack != null)
			{
				DeviceContext.GraphicsState graphicsState = (DeviceContext.GraphicsState)this._contextStack.Pop();
				this._hCurrentBmp = graphicsState.hBitmap;
				this._hCurrentBrush = graphicsState.hBrush;
				this._hCurrentPen = graphicsState.hPen;
				this._hCurrentFont = graphicsState.hFont;
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00022978 File Offset: 0x00020F78
		public int SaveHdc()
		{
			HandleRef hdc = new HandleRef(this, this._hDC);
			int result = Interop.Gdi32.SaveDC(hdc);
			if (this._contextStack == null)
			{
				this._contextStack = new Stack();
			}
			DeviceContext.GraphicsState graphicsState = new DeviceContext.GraphicsState();
			graphicsState.hBitmap = this._hCurrentBmp;
			graphicsState.hBrush = this._hCurrentBrush;
			graphicsState.hPen = this._hCurrentPen;
			graphicsState.hFont = this._hCurrentFont;
			this._contextStack.Push(graphicsState);
			return result;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000229F0 File Offset: 0x00020FF0
		public void SetClip(WindowsRegion region)
		{
			HandleRef hdc = new HandleRef(this, this._hDC);
			HandleRef hrgn = new HandleRef(region, region.HRegion);
			Interop.Gdi32.SelectClipRgn(hdc, hrgn);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00022A24 File Offset: 0x00021024
		public void IntersectClip(WindowsRegion wr)
		{
			if (wr.HRegion == IntPtr.Zero)
			{
				return;
			}
			WindowsRegion windowsRegion = new WindowsRegion(0, 0, 0, 0);
			try
			{
				int clipRgn = Interop.Gdi32.GetClipRgn(new HandleRef(this, this._hDC), new HandleRef(windowsRegion, windowsRegion.HRegion));
				if (clipRgn == 1)
				{
					wr.CombineRegion(windowsRegion, wr, Interop.Gdi32.CombineMode.RGN_AND);
				}
				this.SetClip(wr);
			}
			finally
			{
				windowsRegion.Dispose();
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00022A9C File Offset: 0x0002109C
		public void TranslateTransform(int dx, int dy)
		{
			Point point = default(Point);
			Interop.Gdi32.OffsetViewportOrgEx(new HandleRef(this, this._hDC), dx, dy, ref point);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00022AC8 File Offset: 0x000210C8
		public override bool Equals(object obj)
		{
			DeviceContext deviceContext = obj as DeviceContext;
			return deviceContext == this || (deviceContext != null && deviceContext.Hdc == this._hDC);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00022AF8 File Offset: 0x000210F8
		public override int GetHashCode()
		{
			return this._hDC.GetHashCode();
		}

		// Token: 0x040002E7 RID: 743
		private IntPtr _hDC;

		// Token: 0x040002E8 RID: 744
		private readonly DeviceContextType _dcType;

		// Token: 0x040002EA RID: 746
		private bool _disposed;

		// Token: 0x040002EB RID: 747
		private readonly IntPtr _hWnd = (IntPtr)(-1);

		// Token: 0x040002EC RID: 748
		private IntPtr _hInitialPen;

		// Token: 0x040002ED RID: 749
		private IntPtr _hInitialBrush;

		// Token: 0x040002EE RID: 750
		private IntPtr _hInitialBmp;

		// Token: 0x040002EF RID: 751
		private IntPtr _hInitialFont;

		// Token: 0x040002F0 RID: 752
		private IntPtr _hCurrentPen;

		// Token: 0x040002F1 RID: 753
		private IntPtr _hCurrentBrush;

		// Token: 0x040002F2 RID: 754
		private IntPtr _hCurrentBmp;

		// Token: 0x040002F3 RID: 755
		private IntPtr _hCurrentFont;

		// Token: 0x040002F4 RID: 756
		private Stack _contextStack;

		// Token: 0x020000E3 RID: 227
		internal class GraphicsState
		{
			// Token: 0x0400081A RID: 2074
			internal IntPtr hBrush;

			// Token: 0x0400081B RID: 2075
			internal IntPtr hFont;

			// Token: 0x0400081C RID: 2076
			internal IntPtr hPen;

			// Token: 0x0400081D RID: 2077
			internal IntPtr hBitmap;
		}
	}
[assembly: TypeForwardedTo(typeof(Collection<>))]
[assembly: TypeForwardedTo(typeof(ComDefaultInterfaceAttribute))]
[assembly: TypeForwardedTo(typeof(ComEventInterfaceAttribute))]
[assembly: TypeForwardedTo(typeof(ComEventsHelper))]
[assembly: TypeForwardedTo(typeof(COMException))]
[assembly: TypeForwardedTo(typeof(ComImportAttribute))]
[assembly: TypeForwardedTo(typeof(ComInterfaceType))]
[assembly: TypeForwardedTo(typeof(ComMemberType))]
[assembly: TypeForwardedTo(typeof(CompareInfo))]
[assembly: TypeForwardedTo(typeof(CompareOptions))]
[assembly: TypeForwardedTo(typeof(Comparer))]
[assembly: TypeForwardedTo(typeof(Comparer<>))]
[assembly: TypeForwardedTo(typeof(Comparison<>))]
[assembly: TypeForwardedTo(typeof(CompilationRelaxations))]
[assembly: TypeForwardedTo(typeof(CompilationRelaxationsAttribute))]
[assembly: TypeForwardedTo(typeof(CompilerGeneratedAttribute))]
[assembly: TypeForwardedTo(typeof(CompilerGlobalScopeAttribute))]
[assembly: TypeForwardedTo(typeof(TaskFactory.CompleteOnInvokePromise))]
[assembly: TypeForwardedTo(typeof(ComponentGuaranteesAttribute))]
[assembly: TypeForwardedTo(typeof(ComponentGuaranteesOptions))]
[assembly: TypeForwardedTo(typeof(CompressedStack))]
[assembly: TypeForwardedTo(typeof(ComSourceInterfacesAttribute))]
[assembly: TypeForwardedTo(typeof(ComVisibleAttribute))]
[assembly: TypeForwardedTo(typeof(ConcurrentExclusiveSchedulerPair))]
[assembly: TypeForwardedTo(typeof(ConcurrentQueue<>))]
[assembly: TypeForwardedTo(typeof(ConditionalAttribute))]
[assembly: TypeForwardedTo(typeof(ConditionalWeakTable<, >))]
[assembly: TypeForwardedTo(typeof(ConfiguredTaskAwaitable))]
[assembly: TypeForwardedTo(typeof(ConfiguredTaskAwaitable<>))]
[assembly: TypeForwardedTo(typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter))]
[assembly: TypeForwardedTo(typeof(ConfiguredTaskAwaitable<>.ConfiguredTaskAwaiter))]
[assembly: TypeForwardedTo(typeof(CONNECTDATA))]
[assembly: TypeForwardedTo(typeof(Consistency))]
[assembly: TypeForwardedTo(typeof(ConstructorBuilder))]
[assembly: TypeForwardedTo(typeof(ConstructorInfo))]
[assembly: TypeForwardedTo(typeof(ContextBoundObject))]
[assembly: TypeForwardedTo(typeof(ContextCallback))]
[assembly: TypeForwardedTo(typeof(ContextMarshalException))]
[assembly: TypeForwardedTo(typeof(ContextStaticAttribute))]
[assembly: TypeForwardedTo(typeof(Task.ContingentProperties))]
[assembly: TypeForwardedTo(typeof(Contract))]
[assembly: TypeForwardedTo(typeof(ContractAbbreviatorAttribute))]
[assembly: TypeForwardedTo(typeof(ContractArgumentValidatorAttribute))]
[assembly: TypeForwardedTo(typeof(ContractClassAttribute))]
[assembly: TypeForwardedTo(typeof(ContractClassForAttribute))]
[assembly: TypeForwardedTo(typeof(ContractException))]
[assembly: TypeForwardedTo(typeof(ContractFailedEventArgs))]
[assembly: TypeForwardedTo(typeof(ContractFailureKind))]
[assembly: TypeForwardedTo(typeof(ContractHelper))]
[assembly: TypeForwardedTo(typeof(ContractInvariantMethodAttribute))]
[assembly: TypeForwardedTo(typeof(ContractOptionAttribute))]
[assembly: TypeForwardedTo(typeof(ContractPublicPropertyNameAttribute))]
[assembly: TypeForwardedTo(typeof(ContractReferenceAssemblyAttribute))]
[assembly: TypeForwardedTo(typeof(ContractRuntimeIgnoredAttribute))]
[assembly: TypeForwardedTo(typeof(ContractVerificationAttribute))]
[assembly: TypeForwardedTo(typeof(Convert))]
[assembly: TypeForwardedTo(typeof(Converter<, >))]
[assembly: TypeForwardedTo(typeof(ConditionalWeakTable<, >.CreateValueCallback))]
[assembly: TypeForwardedTo(typeof(CriticalFinalizerObject))]
[assembly: TypeForwardedTo(typeof(CriticalHandle))]
[assembly: TypeForwardedTo(typeof(CriticalHandleMinusOneIsInvalid))]
[assembly: TypeForwardedTo(typeof(CriticalHandleZeroOrMinusOneIsInvalid))]
[assembly: TypeForwardedTo(typeof(CryptographicException))]
[assembly: TypeForwardedTo(typeof(CultureAwareComparer))]
[assembly: TypeForwardedTo(typeof(CultureInfo))]
[assembly: TypeForwardedTo(typeof(ResourceManager.CultureNameResourceSetPair))]
[assembly: TypeForwardedTo(typeof(CultureNotFoundException))]
[assembly: TypeForwardedTo(typeof(CultureTypes))]
[assembly: TypeForwardedTo(typeof(CurrencyWrapper))]
[assembly: TypeForwardedTo(typeof(CustomAttributeBuilder))]
[assembly: TypeForwardedTo(typeof(CustomAttributeData))]
[assembly: TypeForwardedTo(typeof(CustomAttributeExtensions))]
[assembly: TypeForwardedTo(typeof(CustomAttributeFormatException))]
[assembly: TypeForwardedTo(typeof(CustomAttributeNamedArgument))]
[assembly: TypeForwardedTo(typeof(CustomAttributeTypedArgument))]
[assembly: TypeForwardedTo(typeof(CustomConstantAttribute))]
[assembly: TypeForwardedTo(typeof(CustomQueryInterfaceMode))]
[assembly: TypeForwardedTo(typeof(CustomQueryInterfaceResult))]
[assembly: TypeForwardedTo(typeof(DataMisalignedException))]
[assembly: TypeForwardedTo(typeof(HebrewCalendar.DateBuffer))]
[assembly: TypeForwardedTo(typeof(DateTime))]
[assembly: TypeForwardedTo(typeof(DateTimeConstantAttribute))]
[assembly: TypeForwardedTo(typeof(DateTimeFormatInfo))]
[assembly: TypeForwardedTo(typeof(DateTimeKind))]
[assembly: TypeForwardedTo(typeof(DateTimeOffset))]
[assembly: TypeForwardedTo(typeof(DateTimeStyles))]
[assembly: TypeForwardedTo(typeof(DaylightTime))]
[assembly: TypeForwardedTo(typeof(DayOfWeek))]
[assembly: TypeForwardedTo(typeof(DBNull))]
[assembly: TypeForwardedTo(typeof(DebuggableAttribute))]
[assembly: TypeForwardedTo(typeof(Debugger))]
[assembly: TypeForwardedTo(typeof(DebuggerBrowsableAttribute))]
[assembly: TypeForwardedTo(typeof(DebuggerBrowsableState))]
[assembly: TypeForwardedTo(typeof(DebuggerDisplayAttribute))]
[assembly: TypeForwardedTo(typeof(DebuggerHiddenAttribute))]
[assembly: TypeForwardedTo(typeof(DebuggerNonUserCodeAttribute))]
[assembly: TypeForwardedTo(typeof(DebuggerStepperBoundaryAttribute))]
[assembly: TypeForwardedTo(typeof(DebuggerStepThroughAttribute))]
[assembly: TypeForwardedTo(typeof(DebuggerTypeProxyAttribute))]
[assembly: TypeForwardedTo(typeof(DebuggerVisualizerAttribute))]
[assembly: TypeForwardedTo(typeof(DebuggableAttribute.DebuggingModes))]
[assembly: TypeForwardedTo(typeof(decimal))]
[assembly: TypeForwardedTo(typeof(DecimalConstantAttribute))]
[assembly: TypeForwardedTo(typeof(Decoder))]
[assembly: TypeForwardedTo(typeof(DecoderExceptionFallback))]
[assembly: TypeForwardedTo(typeof(DecoderExceptionFallbackBuffer))]
[assembly: TypeForwardedTo(typeof(DecoderFallback))]
[assembly: TypeForwardedTo(typeof(DecoderFallbackBuffer))]
[assembly: TypeForwardedTo(typeof(DecoderFallbackException))]
[assembly: TypeForwardedTo(typeof(DecoderReplacementFallback))]
[assembly: TypeForwardedTo(typeof(DecoderReplacementFallbackBuffer))]
[assembly: TypeForwardedTo(typeof(DefaultCharSetAttribute))]
[assembly: TypeForwardedTo(typeof(Encoding.DefaultDecoder))]
[assembly: TypeForwardedTo(typeof(DefaultDependencyAttribute))]
[assembly: TypeForwardedTo(typeof(DefaultDllImportSearchPathsAttribute))]
[assembly: TypeForwardedTo(typeof(Encoding.DefaultEncoder))]
[assembly: TypeForwardedTo(typeof(DefaultMemberAttribute))]
[assembly: TypeForwardedTo(typeof(Delegate))]
[assembly: TypeForwardedTo(typeof(DependencyAttribute))]
[assembly: TypeForwardedTo(typeof(DESCKIND))]
[assembly: TypeForwardedTo(typeof(ELEMDESC.DESCUNION))]
[assembly: TypeForwardedTo(typeof(VARDESC.DESCUNION))]
[assembly: TypeForwardedTo(typeof(DictionaryEntry))]
[assembly: TypeForwardedTo(typeof(Dictionary<, >))]
[assembly: TypeForwardedTo(typeof(DigitShapes))]
[assembly: TypeForwardedTo(typeof(DirectoryNotFoundException))]
[assembly: TypeForwardedTo(typeof(DisablePrivateReflectionAttribute))]
[assembly: TypeForwardedTo(typeof(DiscardableAttribute))]
[assembly: TypeForwardedTo(typeof(Exception.DispatchState))]
[assembly: TypeForwardedTo(typeof(DispatchWrapper))]
[assembly: TypeForwardedTo(typeof(DispIdAttribute))]
[assembly: TypeForwardedTo(typeof(DISPPARAMS))]
[assembly: TypeForwardedTo(typeof(DivideByZeroException))]
[assembly: TypeForwardedTo(typeof(DllImportAttribute))]
[assembly: TypeForwardedTo(typeof(DllImportSearchPath))]
[assembly: TypeForwardedTo(typeof(DllNotFoundException))]
[assembly: TypeForwardedTo(typeof(double))]
[assembly: TypeForwardedTo(typeof(DuplicateWaitObjectException))]
[assembly: TypeForwardedTo(typeof(DynamicILInfo))]
[assembly: TypeForwardedTo(typeof(DynamicMethod))]
[assembly: TypeForwardedTo(typeof(EastAsianLunisolarCalendar))]
[assembly: TypeForwardedTo(typeof(ELEMDESC))]
[assembly: TypeForwardedTo(typeof(Encoder))]
[assembly: TypeForwardedTo(typeof(EncoderExceptionFallback))]
[assembly: TypeForwardedTo(typeof(EncoderExceptionFallbackBuffer))]
[assembly: TypeForwardedTo(typeof(EncoderFallback))]
// Token: 0x0200004B RID: 75
	internal static class DeviceContexts
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x00022B08 File Offset: 0x00021108
		internal static void AddDeviceContext(DeviceContext dc)
		{
			if (DeviceContexts.t_activeDeviceContexts == null)
			{
				DeviceContexts.t_activeDeviceContexts = new ClientUtils.WeakRefCollection
				{
					RefCheckThreshold = 20
				};
			}
			if (!DeviceContexts.t_activeDeviceContexts.Contains(dc))
			{
				dc.Disposing += DeviceContexts.OnDcDisposing;
				DeviceContexts.t_activeDeviceContexts.Add(dc);
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00022B5C File Offset: 0x0002115C
		private static void OnDcDisposing(object sender, EventArgs e)
		{
			DeviceContext deviceContext = sender as DeviceContext;
			if (deviceContext != null)
			{
				deviceContext.Disposing -= DeviceContexts.OnDcDisposing;
				DeviceContexts.RemoveDeviceContext(deviceContext);
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00022B8B File Offset: 0x0002118B
		internal static void RemoveDeviceContext(DeviceContext dc)
		{
			ClientUtils.WeakRefCollection weakRefCollection = DeviceContexts.t_activeDeviceContexts;
			if (weakRefCollection == null)
			{
				return;
			}
			weakRefCollection.RemoveByHashCode(dc);
		}

		// Token: 0x040002F5 RID: 757
		[ThreadStatic]
		private static ClientUtils.WeakRefCollection t_activeDeviceContexts;
	}
[assembly: TypeForwardedTo(typeof(EncoderFallbackBuffer))]
[assembly: TypeForwardedTo(typeof(EncoderFallbackException))]
[assembly: TypeForwardedTo(typeof(EncoderReplacementFallback))]
[assembly: TypeForwardedTo(typeof(EncoderReplacementFallbackBuffer))]
[assembly: TypeForwardedTo(typeof(Encoding))]
[assembly: TypeForwardedTo(typeof(Encoding.EncodingByteBuffer))]
[assembly: TypeForwardedTo(typeof(Encoding.EncodingCharBuffer))]
[assembly: TypeForwardedTo(typeof(EncodingInfo))]
[assembly: TypeForwardedTo(typeof(EncodingProvider))]
[assembly: TypeForwardedTo(typeof(EndOfStreamException))]
[assembly: TypeForwardedTo(typeof(EntryPointNotFoundException))]
[assembly: TypeForwardedTo(typeof(Enum))]
[assembly: TypeForwardedTo(typeof(EnumBuilder))]
[assembly: TypeForwardedTo(typeof(EnumEqualityComparer<>))]
[assembly: TypeForwardedTo(typeof(ArraySegment<>.Enumerator))]
[assembly: TypeForwardedTo(typeof(Dictionary<, >.Enumerator))]
[assembly: TypeForwardedTo(typeof(Dictionary<, >.KeyCollection.Enumerator))]
[assembly: TypeForwardedTo(typeof(Dictionary<, >.ValueCollection.Enumerator))]
[assembly: TypeForwardedTo(typeof(List<>.Enumerator))]
[assembly: TypeForwardedTo(typeof(Enum.EnumInfo))]
[assembly: TypeForwardedTo(typeof(Environment))]
[assembly: TypeForwardedTo(typeof(EnvironmentVariableTarget))]
[assembly: TypeForwardedTo(typeof(EqualityComparer<>))]
[assembly: TypeForwardedTo(typeof(ErrorWrapper))]
[assembly: TypeForwardedTo(typeof(EventActivityOptions))]
[assembly: TypeForwardedTo(typeof(EventArgs))]
[assembly: TypeForwardedTo(typeof(EventAttribute))]
[assembly: TypeForwardedTo(typeof(EventAttributes))]
[assembly: TypeForwardedTo(typeof(EventBuilder))]
[assembly: TypeForwardedTo(typeof(EventChannel))]
[assembly: TypeForwardedTo(typeof(EventCommand))]
[assembly: TypeForwardedTo(typeof(EventCommandEventArgs))]
[assembly: TypeForwardedTo(typeof(EventSource.EventData))]
[assembly: TypeForwardedTo(typeof(EventDataAttribute))]
[assembly: TypeForwardedTo(typeof(EventFieldAttribute))]
[assembly: TypeForwardedTo(typeof(EventFieldFormat))]
[assembly: TypeForwardedTo(typeof(EventFieldTags))]
[assembly: TypeForwardedTo(typeof(EventHandler))]
[assembly: TypeForwardedTo(typeof(EventHandler<>))]
[assembly: TypeForwardedTo(typeof(EventIgnoreAttribute))]
[assembly: TypeForwardedTo(typeof(EventInfo))]
[assembly: TypeForwardedTo(typeof(EventKeywords))]
[assembly: TypeForwardedTo(typeof(EventLevel))]
[assembly: TypeForwardedTo(typeof(EventListener))]
[assembly: TypeForwardedTo(typeof(EventManifestOptions))]
[assembly: TypeForwardedTo(typeof(EventSource.EventMetadata))]
[assembly: TypeForwardedTo(typeof(EventOpcode))]
[assembly: TypeForwardedTo(typeof(EventResetMode))]
[assembly: TypeForwardedTo(typeof(EventSource))]
[assembly: TypeForwardedTo(typeof(EventSourceAttribute))]
[assembly: TypeForwardedTo(typeof(EventSourceCreatedEventArgs))]
[assembly: TypeForwardedTo(typeof(EventSourceException))]
[assembly: TypeForwardedTo(typeof(EventSourceOptions))]
[assembly: TypeForwardedTo(typeof(EventSourceSettings))]
[assembly: TypeForwardedTo(typeof(EventTags))]
[assembly: TypeForwardedTo(typeof(EventTask))]
[assembly: TypeForwardedTo(typeof(EventToken))]
[assembly: TypeForwardedTo(typeof(EventWaitHandle))]
[assembly: TypeForwardedTo(typeof(EventWrittenEventArgs))]
[assembly: TypeForwardedTo(typeof(EXCEPINFO))]
[assembly: TypeForwardedTo(typeof(Exception))]
[assembly: TypeForwardedTo(typeof(ExceptionDispatchInfo))]
[assembly: TypeForwardedTo(typeof(ExceptionHandlingClause))]
[assembly: TypeForwardedTo(typeof(ExceptionHandlingClauseOptions))]
[assembly: TypeForwardedTo(typeof(Exception.ExceptionMessageKind))]
[assembly: TypeForwardedTo(typeof(ExecutionContext))]
[assembly: TypeForwardedTo(typeof(ExecutionEngineException))]
[assembly: TypeForwardedTo(typeof(ExtensionAttribute))]
[assembly: TypeForwardedTo(typeof(ExternalException))]
[assembly: TypeForwardedTo(typeof(FieldAccessException))]
[assembly: TypeForwardedTo(typeof(FieldAttributes))]
[assembly: TypeForwardedTo(typeof(FieldBuilder))]
[assembly: TypeForwardedTo(typeof(FieldInfo))]
[assembly: TypeForwardedTo(typeof(FieldOffsetAttribute))]
[assembly: TypeForwardedTo(typeof(FieldToken))]
[assembly: TypeForwardedTo(typeof(FileAccess))]
[assembly: TypeForwardedTo(typeof(FileAttributes))]
[assembly: TypeForwardedTo(typeof(FileLoadException))]
[assembly: TypeForwardedTo(typeof(FileMode))]
[assembly: TypeForwardedTo(typeof(FileNotFoundException))]
[assembly: TypeForwardedTo(typeof(FileOptions))]
[assembly: TypeForwardedTo(typeof(FileShare))]
[assembly: TypeForwardedTo(typeof(FileStream))]
[assembly: TypeForwardedTo(typeof(FILETIME))]
[assembly: TypeForwardedTo(typeof(FirstChanceExceptionEventArgs))]
[assembly: TypeForwardedTo(typeof(FixedAddressValueTypeAttribute))]
[assembly: TypeForwardedTo(typeof(FixedBufferAttribute))]
[assembly: TypeForwardedTo(typeof(FlagsAttribute))]
[assembly: TypeForwardedTo(typeof(FlowControl))]
[assembly: TypeForwardedTo(typeof(FormatException))]
[assembly: TypeForwardedTo(typeof(FormattableString))]
[assembly: TypeForwardedTo(typeof(FormattableStringFactory))]
[assembly: TypeForwardedTo(typeof(FUNCDESC))]
[assembly: TypeForwardedTo(typeof(FUNCFLAGS))]
[assembly: TypeForwardedTo(typeof(FUNCKIND))]
[assembly: TypeForwardedTo(typeof(Func<>))]
[assembly: TypeForwardedTo(typeof(Func<, >))]
[assembly: TypeForwardedTo(typeof(Func<, , >))]
[assembly: TypeForwardedTo(typeof(Func<, , , >))]
[assembly: TypeForwardedTo(typeof(Func<, , , , >))]
[assembly: TypeForwardedTo(typeof(Func<, , , , , >))]
[assembly: TypeForwardedTo(typeof(Func<, , , , , , >))]
[assembly: TypeForwardedTo(typeof(Func<, , , , , , , >))]
[assembly: TypeForwardedTo(typeof(Func<, , , , , , , , >))]
[assembly: TypeForwardedTo(typeof(GC))]
[assembly: TypeForwardedTo(typeof(GCCollectionMode))]
[assembly: TypeForwardedTo(typeof(GCHandle))]
[assembly: TypeForwardedTo(typeof(GCHandleType))]
[assembly: TypeForwardedTo(typeof(GCLargeObjectHeapCompactionMode))]
[assembly: TypeForwardedTo(typeof(GCLatencyMode))]
[assembly: TypeForwardedTo(typeof(GCNotificationStatus))]
[assembly: TypeForwardedTo(typeof(GCSettings))]
[assembly: TypeForwardedTo(typeof(GC.GC_ALLOC_FLAGS))]
[assembly: TypeForwardedTo(typeof(GenericComparer<>))]
[assembly: TypeForwardedTo(typeof(GenericEqualityComparer<>))]
[assembly: TypeForwardedTo(typeof(GenericParameterAttributes))]
[assembly: TypeForwardedTo(typeof(GenericTypeParameterBuilder))]
[assembly: TypeForwardedTo(typeof(GlobalizationExtensions))]
[assembly: TypeForwardedTo(typeof(GregorianCalendar))]
[assembly: TypeForwardedTo(typeof(GregorianCalendarTypes))]
[assembly: TypeForwardedTo(typeof(Guid))]
[assembly: TypeForwardedTo(typeof(GuidAttribute))]
[assembly: TypeForwardedTo(typeof(HandleProcessCorruptedStateExceptionsAttribute))]
[assembly: TypeForwardedTo(typeof(HandleRef))]
[assembly: TypeForwardedTo(typeof(Hashtable))]
[assembly: TypeForwardedTo(typeof(Hashtable.HashtableDebugView))]
[assembly: TypeForwardedTo(typeof(HebrewCalendar))]
[assembly: TypeForwardedTo(typeof(HijriCalendar))]
[assembly: TypeForwardedTo(typeof(IAsyncResult))]
[assembly: TypeForwardedTo(typeof(IAsyncStateMachine))]
[assembly: TypeForwardedTo(typeof(IBindCtx))]
[assembly: TypeForwardedTo(typeof(ICloneable))]
[assembly: TypeForwardedTo(typeof(ICollection))]
[assembly: TypeForwardedTo(typeof(ICollection<>))]
[assembly: TypeForwardedTo(typeof(IComparable))]
[assembly: TypeForwardedTo(typeof(IComparable<>))]
[assembly: TypeForwardedTo(typeof(IComparer))]
[assembly: TypeForwardedTo(typeof(IComparer<>))]
[assembly: TypeForwardedTo(typeof(IConnectionPoint))]
[assembly: TypeForwardedTo(typeof(IConnectionPointContainer))]
[assembly: TypeForwardedTo(typeof(IConvertible))]
[assembly: TypeForwardedTo(typeof(ICriticalNotifyCompletion))]
[assembly: TypeForwardedTo(typeof(ICustomAdapter))]
[assembly: TypeForwardedTo(typeof(ICustomAttributeProvider))]
[assembly: TypeForwardedTo(typeof(ICustomFactory))]
[assembly: TypeForwardedTo(typeof(ICustomFormatter))]
[assembly: TypeForwardedTo(typeof(ICustomMarshaler))]
[assembly: TypeForwardedTo(typeof(ICustomQueryInterface))]
[assembly: TypeForwardedTo(typeof(IDeserializationCallback))]
[assembly: TypeForwardedTo(typeof(IDictionary))]
[assembly: TypeForwardedTo(typeof(IDictionaryEnumerator))]
[assembly: TypeForwardedTo(typeof(IDictionary<, >))]
[assembly: TypeForwardedTo(typeof(IDisposable))]
[assembly: TypeForwardedTo(typeof(IDLDESC))]
[assembly: TypeForwardedTo(typeof(IDLFLAG))]
[assembly: TypeForwardedTo(typeof(IdnMapping))]
[assembly: TypeForwardedTo(typeof(IEnumConnectionPoints))]
[assembly: TypeForwardedTo(typeof(IEnumConnections))]
[assembly: TypeForwardedTo(typeof(IEnumerable))]
[assembly: TypeForwardedTo(typeof(IEnumerable<>))]
[assembly: TypeForwardedTo(typeof(IEnumerator))]
[assembly: TypeForwardedTo(typeof(IEnumerator<>))]
[assembly: TypeForwardedTo(typeof(IEnumMoniker))]
[assembly: TypeForwardedTo(typeof(IEnumString))]
[assembly: TypeForwardedTo(typeof(IEnumVARIANT))]
[assembly: TypeForwardedTo(typeof(IEqualityComparer))]
[assembly: TypeForwardedTo(typeof(IEqualityComparer<>))]
[assembly: TypeForwardedTo(typeof(IEquatable<>))]
[assembly: TypeForwardedTo(typeof(IFormatProvider))]
[assembly: TypeForwardedTo(typeof(IFormattable))]
[assembly: TypeForwardedTo(typeof(IFormatterConverter))]
[assembly: TypeForwardedTo(typeof(IHashCodeProvider))]
[assembly: TypeForwardedTo(typeof(IIdentity))]
[assembly: TypeForwardedTo(typeof(ILGenerator))]
[assembly: TypeForwardedTo(typeof(IList))]
[assembly: TypeForwardedTo(typeof(IList<>))]
[assembly: TypeForwardedTo(typeof(ImageFileMachine))]
[assembly: TypeForwardedTo(typeof(IMoniker))]
[assembly: TypeForwardedTo(typeof(IMPLTYPEFLAGS))]
[assembly: TypeForwardedTo(typeof(InAttribute))]
[assembly: TypeForwardedTo(typeof(IndexerNameAttribute))]
[assembly: TypeForwardedTo(typeof(IndexOutOfRangeException))]
[assembly: TypeForwardedTo(typeof(INotifyCompletion))]
[assembly: TypeForwardedTo(typeof(InsufficientExecutionStackException))]
[assembly: TypeForwardedTo(typeof(InsufficientMemoryException))]
[assembly: TypeForwardedTo(typeof(short))]
[assembly: TypeForwardedTo(typeof(int))]
[assembly: TypeForwardedTo(typeof(long))]
[assembly: TypeForwardedTo(typeof(InterfaceMapping))]
[assembly: TypeForwardedTo(typeof(InterfaceTypeAttribute))]
[assembly: TypeForwardedTo(typeof(Interlocked))]
[assembly: TypeForwardedTo(typeof(InternalsVisibleToAttribute))]
[assembly: TypeForwardedTo(typeof(IntPtr))]
[assembly: TypeForwardedTo(typeof(RuntimeTypeHandle.IntroducedMethodEnumerator))]
[assembly: TypeForwardedTo(typeof(IntrospectionExtensions))]
[assembly: TypeForwardedTo(typeof(InvalidCastException))]
[assembly: TypeForwardedTo(typeof(InvalidComObjectException))]
[assembly: TypeForwardedTo(typeof(InvalidFilterCriteriaException))]
[assembly: TypeForwardedTo(typeof(InvalidOleVariantTypeException))]
[assembly: TypeForwardedTo(typeof(InvalidOperationException))]
[assembly: TypeForwardedTo(typeof(InvalidProgramException))]
[assembly: TypeForwardedTo(typeof(InvalidTimeZoneException))]
[assembly: TypeForwardedTo(typeof(INVOKEKIND))]
[assembly: TypeForwardedTo(typeof(IObjectReference))]
[assembly: TypeForwardedTo(typeof(IObservable<>))]
[assembly: TypeForwardedTo(typeof(IObserver<>))]
[assembly: TypeForwardedTo(typeof(IOCompletionCallback))]
[assembly: TypeForwardedTo(typeof(IOException))]
[assembly: TypeForwardedTo(typeof(IPermission))]
[assembly: TypeForwardedTo(typeof(IPersistFile))]
[assembly: TypeForwardedTo(typeof(IPrincipal))]
[assembly: TypeForwardedTo(typeof(IProducerConsumerCollection<>))]
[assembly: TypeForwardedTo(typeof(IProgress<>))]
[assembly: TypeForwardedTo(typeof(IReadOnlyCollection<>))]
[assembly: TypeForwardedTo(typeof(IReadOnlyDictionary<, >))]
[assembly: TypeForwardedTo(typeof(IReadOnlyList<>))]
[assembly: TypeForwardedTo(typeof(IReflect))]
[assembly: TypeForwardedTo(typeof(IReflectableType))]
[assembly: TypeForwardedTo(typeof(IResourceReader))]
[assembly: TypeForwardedTo(typeof(IRunningObjectTable))]
[assembly: TypeForwardedTo(typeof(ISafeSerializationData))]
[assembly: TypeForwardedTo(typeof(IsByRefLikeAttribute))]
[assembly: TypeForwardedTo(typeof(IsConst))]
[assembly: TypeForwardedTo(typeof(ISecurityEncodable))]
[assembly: TypeForwardedTo(typeof(ISerializable))]
[assembly: TypeForwardedTo(typeof(IsReadOnlyAttribute))]
[assembly: TypeForwardedTo(typeof(IStackWalk))]
[assembly: TypeForwardedTo(typeof(IStream))]
[assembly: TypeForwardedTo(typeof(IStructuralComparable))]
[assembly: TypeForwardedTo(typeof(IStructuralEquatable))]
[assembly: TypeForwardedTo(typeof(IsVolatile))]
[assembly: TypeForwardedTo(typeof(ISymbolDocumentWriter))]
[assembly: TypeForwardedTo(typeof(IteratorStateMachineAttribute))]
[assembly: TypeForwardedTo(typeof(ITuple))]
[assembly: TypeForwardedTo(typeof(ITypeComp))]
[assembly: TypeForwardedTo(typeof(ITypeInfo))]
[assembly: TypeForwardedTo(typeof(ITypeInfo2))]
[assembly: TypeForwardedTo(typeof(ITypeLib))]
[assembly: TypeForwardedTo(typeof(ITypeLib2))]
[assembly: TypeForwardedTo(typeof(JapaneseCalendar))]
[assembly: TypeForwardedTo(typeof(JapaneseLunisolarCalendar))]
[assembly: TypeForwardedTo(typeof(JulianCalendar))]
[assembly: TypeForwardedTo(typeof(Dictionary<, >.KeyCollection))]
[assembly: TypeForwardedTo(typeof(KeyNotFoundException))]
[assembly: TypeForwardedTo(typeof(KeyValuePair<, >))]
[assembly: TypeForwardedTo(typeof(KoreanCalendar))]
[assembly: TypeForwardedTo(typeof(KoreanLunisolarCalendar))]
[assembly: TypeForwardedTo(typeof(Label))]
[assembly: TypeForwardedTo(typeof(LayoutKind))]
[assembly: TypeForwardedTo(typeof(LazyInitializer))]
[assembly: TypeForwardedTo(typeof(LazyThreadSafetyMode))]
[assembly: TypeForwardedTo(typeof(Lazy<>))]
[assembly: TypeForwardedTo(typeof(LCIDConversionAttribute))]
[assembly: TypeForwardedTo(typeof(LIBFLAGS))]
[assembly: TypeForwardedTo(typeof(ListDictionaryInternal))]
[assembly: TypeForwardedTo(typeof(List<>))]
[assembly: TypeForwardedTo(typeof(LoaderOptimization))]
[assembly: TypeForwardedTo(typeof(LoaderOptimizationAttribute))]
[assembly: TypeForwardedTo(typeof(LoadHint))]
[assembly: TypeForwardedTo(typeof(LocalBuilder))]
[assembly: TypeForwardedTo(typeof(LocalDataStoreSlot))]
[assembly: TypeForwardedTo(typeof(LocalVariableInfo))]
[assembly: TypeForwardedTo(typeof(LockRecursionException))]
[assembly: TypeForwardedTo(typeof(ManifestResourceInfo))]
[assembly: TypeForwardedTo(typeof(ManualResetEvent))]
[assembly: TypeForwardedTo(typeof(ManualResetEventSlim))]
[assembly: TypeForwardedTo(typeof(Marshal))]
[assembly: TypeForwardedTo(typeof(MarshalAsAttribute))]
[assembly: TypeForwardedTo(typeof(MarshalByRefObject))]
[assembly: TypeForwardedTo(typeof(MarshalDirectiveException))]
[assembly: TypeForwardedTo(typeof(Math))]
[assembly: TypeForwardedTo(typeof(MemberAccessException))]
[assembly: TypeForwardedTo(typeof(MemberFilter))]
[assembly: TypeForwardedTo(typeof(MemberInfo))]
[assembly: TypeForwardedTo(typeof(MemberTypes))]
[assembly: TypeForwardedTo(typeof(MemoryFailPoint))]
[assembly: TypeForwardedTo(typeof(MemoryStream))]
[assembly: TypeForwardedTo(typeof(MethodAccessException))]
[assembly: TypeForwardedTo(typeof(MethodAttributes))]
[assembly: TypeForwardedTo(typeof(MethodBase))]
[assembly: TypeForwardedTo(typeof(MethodBody))]
[assembly: TypeForwardedTo(typeof(MethodBuilder))]
[assembly: TypeForwardedTo(typeof(MethodCodeType))]
[assembly: TypeForwardedTo(typeof(MethodImplAttribute))]
[assembly: TypeForwardedTo(typeof(MethodImplAttributes))]
[assembly: TypeForwardedTo(typeof(MethodImplOptions))]
[assembly: TypeForwardedTo(typeof(MethodInfo))]
[assembly: TypeForwardedTo(typeof(MethodToken))]
[assembly: TypeForwardedTo(typeof(MidpointRounding))]
[assembly: TypeForwardedTo(typeof(Missing))]
[assembly: TypeForwardedTo(typeof(MissingFieldException))]
[assembly: TypeForwardedTo(typeof(MissingManifestResourceException))]
[assembly: TypeForwardedTo(typeof(MissingMemberException))]
[assembly: TypeForwardedTo(typeof(MissingMethodException))]
[assembly: TypeForwardedTo(typeof(MissingSatelliteAssemblyException))]
[assembly: TypeForwardedTo(typeof(Module))]
[assembly: TypeForwardedTo(typeof(ModuleBuilder))]
[assembly: TypeForwardedTo(typeof(ModuleHandle))]
[assembly: TypeForwardedTo(typeof(ModuleResolveEventHandler))]
[assembly: TypeForwardedTo(typeof(Monitor))]
[assembly: TypeForwardedTo(typeof(MTAThreadAttribute))]
[assembly: TypeForwardedTo(typeof(MulticastDelegate))]
[assembly: TypeForwardedTo(typeof(MulticastNotSupportedException))]
[assembly: TypeForwardedTo(typeof(Mutex))]
[assembly: TypeForwardedTo(typeof(NativeOverlapped))]
[assembly: TypeForwardedTo(typeof(NeutralResourcesLanguageAttribute))]
[assembly: TypeForwardedTo(typeof(NonEventAttribute))]
[assembly: TypeForwardedTo(typeof(NonRandomizedStringEqualityComparer))]
[assembly: TypeForwardedTo(typeof(NonSerializedAttribute))]
[assembly: TypeForwardedTo(typeof(NormalizationForm))]
[assembly: TypeForwardedTo(typeof(NotFiniteNumberException))]
[assembly: TypeForwardedTo(typeof(NotImplementedException))]
[assembly: TypeForwardedTo(typeof(NotSupportedException))]
[assembly: TypeForwardedTo(typeof(Nullable))]
[assembly: TypeForwardedTo(typeof(NullableComparer<>))]
[assembly: TypeForwardedTo(typeof(NullableEqualityComparer<>))]
[assembly: TypeForwardedTo(typeof(Nullable<>))]
[assembly: TypeForwardedTo(typeof(NullReferenceException))]
[assembly: TypeForwardedTo(typeof(NumberFormatInfo))]
[assembly: TypeForwardedTo(typeof(NumberStyles))]
[assembly: TypeForwardedTo(typeof(ObfuscateAssemblyAttribute))]
[assembly: TypeForwardedTo(typeof(ObfuscationAttribute))]
[assembly: TypeForwardedTo(typeof(object))]
[assembly: TypeForwardedTo(typeof(ObjectComparer<>))]
[assembly: TypeForwardedTo(typeof(ObjectDisposedException))]
[assembly: TypeForwardedTo(typeof(ObjectEqualityComparer<>))]
[assembly: TypeForwardedTo(typeof(ObjectHandle))]
[assembly: TypeForwardedTo(typeof(ObsoleteAttribute))]
[assembly: TypeForwardedTo(typeof(OnDeserializedAttribute))]
[assembly: TypeForwardedTo(typeof(OnDeserializingAttribute))]
[assembly: TypeForwardedTo(typeof(OnSerializedAttribute))]
[assembly: TypeForwardedTo(typeof(OnSerializingAttribute))]
[assembly: TypeForwardedTo(typeof(OpCode))]
[assembly: TypeForwardedTo(typeof(OpCodes))]
[assembly: TypeForwardedTo(typeof(OpCodeType))]
[assembly: TypeForwardedTo(typeof(WaitHandle.OpenExistingResult))]
[assembly: TypeForwardedTo(typeof(OperandType))]
[assembly: TypeForwardedTo(typeof(OperatingSystem))]
[assembly: TypeForwardedTo(typeof(OperationCanceledException))]
[assembly: TypeForwardedTo(typeof(OptionalAttribute))]
[assembly: TypeForwardedTo(typeof(OptionalFieldAttribute))]
[assembly: TypeForwardedTo(typeof(OrdinalComparer))]
[assembly: TypeForwardedTo(typeof(OutAttribute))]
[assembly: TypeForwardedTo(typeof(OutOfMemoryException))]
[assembly: TypeForwardedTo(typeof(OverflowException))]
[assembly: TypeForwardedTo(typeof(Overlapped))]
[assembly: TypeForwardedTo(typeof(PackingSize))]
[assembly: TypeForwardedTo(typeof(ParamArrayAttribute))]
[assembly: TypeForwardedTo(typeof(PARAMDESC))]
[assembly: TypeForwardedTo(typeof(ParameterAttributes))]
[assembly: TypeForwardedTo(typeof(ParameterBuilder))]
[assembly: TypeForwardedTo(typeof(ParameterInfo))]
[assembly: TypeForwardedTo(typeof(ParameterizedThreadStart))]
[assembly: TypeForwardedTo(typeof(ParameterModifier))]
[assembly: TypeForwardedTo(typeof(ParameterToken))]
[assembly: TypeForwardedTo(typeof(PARAMFLAG))]
[assembly: TypeForwardedTo(typeof(PartialTrustVisibilityLevel))]
[assembly: TypeForwardedTo(typeof(Path))]
[assembly: TypeForwardedTo(typeof(PathTooLongException))]
[assembly: TypeForwardedTo(typeof(PEFileKinds))]
[assembly: TypeForwardedTo(typeof(PermissionSet))]
[assembly: TypeForwardedTo(typeof(PermissionState))]
[assembly: TypeForwardedTo(typeof(PersianCalendar))]
[assembly: TypeForwardedTo(typeof(PlatformID))]
[assembly: TypeForwardedTo(typeof(PlatformNotSupportedException))]
[assembly: TypeForwardedTo(typeof(Pointer))]
[assembly: TypeForwardedTo(typeof(PortableExecutableKinds))]
[assembly: TypeForwardedTo(typeof(PreAllocatedOverlapped))]
[assembly: TypeForwardedTo(typeof(Predicate<>))]
[assembly: TypeForwardedTo(typeof(PrePrepareMethodAttribute))]
[assembly: TypeForwardedTo(typeof(PreserveSigAttribute))]
[assembly: TypeForwardedTo(typeof(PrincipalPolicy))]
[assembly: TypeForwardedTo(typeof(ProcessorArchitecture))]
[assembly: TypeForwardedTo(typeof(ProfileOptimization))]
[assembly: TypeForwardedTo(typeof(ProgIdAttribute))]
[assembly: TypeForwardedTo(typeof(Progress<>))]
[assembly: TypeForwardedTo(typeof(PropertyAttributes))]
[assembly: TypeForwardedTo(typeof(PropertyBuilder))]
[assembly: TypeForwardedTo(typeof(PropertyInfo))]
[assembly: TypeForwardedTo(typeof(PropertyToken))]
[assembly: TypeForwardedTo(typeof(PureAttribute))]
[assembly: TypeForwardedTo(typeof(Random))]
[assembly: TypeForwardedTo(typeof(RankException))]
[assembly: TypeForwardedTo(typeof(ReadOnlyCollection<>))]
[assembly: TypeForwardedTo(typeof(ReferenceAssemblyAttribute))]
[assembly: TypeForwardedTo(typeof(ReflectionContext))]
[assembly: TypeForwardedTo(typeof(ReflectionTypeLoadException))]
[assembly: TypeForwardedTo(typeof(RegionInfo))]
[assembly: TypeForwardedTo(typeof(RegisteredWaitHandle))]
[assembly: TypeForwardedTo(typeof(ReliabilityContractAttribute))]
[assembly: TypeForwardedTo(typeof(ResolveEventArgs))]
[assembly: TypeForwardedTo(typeof(ResolveEventHandler))]
[assembly: TypeForwardedTo(typeof(ResourceAttributes))]
[assembly: TypeForwardedTo(typeof(ResourceConsumptionAttribute))]
[assembly: TypeForwardedTo(typeof(ResourceReader.ResourceEnumerator))]
[assembly: TypeForwardedTo(typeof(ResourceExposureAttribute))]
[assembly: TypeForwardedTo(typeof(ResourceLocation))]
[assembly: TypeForwardedTo(typeof(ResourceManager))]
[assembly: TypeForwardedTo(typeof(ResourceManager.ResourceManagerMediator))]
[assembly: TypeForwardedTo(typeof(ResourceReader))]
[assembly: TypeForwardedTo(typeof(ResourceScope))]
[assembly: TypeForwardedTo(typeof(ResourceSet))]
[assembly: TypeForwardedTo(typeof(DynamicMethod.RTDynamicMethod))]
[assembly: TypeForwardedTo(typeof(RuntimeArgumentHandle))]
[assembly: TypeForwardedTo(typeof(RuntimeCompatibilityAttribute))]
[assembly: TypeForwardedTo(typeof(RuntimeFeature))]
[assembly: TypeForwardedTo(typeof(RuntimeFieldHandle))]
[assembly: TypeForwardedTo(typeof(RuntimeHelpers))]
[assembly: TypeForwardedTo(typeof(RuntimeMethodHandle))]
[assembly: TypeForwardedTo(typeof(RuntimeReflectionExtensions))]
[assembly: TypeForwardedTo(typeof(RuntimeTypeHandle))]
[assembly: TypeForwardedTo(typeof(RuntimeWrappedException))]
[assembly: TypeForwardedTo(typeof(SafeArrayRankMismatchException))]
[assembly: TypeForwardedTo(typeof(SafeArrayTypeMismatchException))]
[assembly: TypeForwardedTo(typeof(SafeBuffer))]
[assembly: TypeForwardedTo(typeof(SafeFileHandle))]
[assembly: TypeForwardedTo(typeof(SafeHandle))]
[assembly: TypeForwardedTo(typeof(SafeHandleMinusOneIsInvalid))]
[assembly: TypeForwardedTo(typeof(SafeHandleZeroOrMinusOneIsInvalid))]
[assembly: TypeForwardedTo(typeof(SafeSerializationEventArgs))]
[assembly: TypeForwardedTo(typeof(SafeWaitHandle))]
[assembly: TypeForwardedTo(typeof(SatelliteContractVersionAttribute))]
[assembly: TypeForwardedTo(typeof(sbyte))]
[assembly: TypeForwardedTo(typeof(SecureString))]
[assembly: TypeForwardedTo(typeof(SecurityAction))]
[assembly: TypeForwardedTo(typeof(SecurityAttribute))]
[assembly: TypeForwardedTo(typeof(SecurityCriticalAttribute))]
[assembly: TypeForwardedTo(typeof(SecurityCriticalScope))]
[assembly: TypeForwardedTo(typeof(SecurityElement))]
[assembly: TypeForwardedTo(typeof(SecurityException))]
[assembly: TypeForwardedTo(typeof(SecurityPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(SecurityPermissionFlag))]
[assembly: TypeForwardedTo(typeof(SecurityRulesAttribute))]
[assembly: TypeForwardedTo(typeof(SecurityRuleSet))]
[assembly: TypeForwardedTo(typeof(SecuritySafeCriticalAttribute))]
[assembly: TypeForwardedTo(typeof(SecurityTransparentAttribute))]
[assembly: TypeForwardedTo(typeof(SecurityTreatAsSafeAttribute))]
[assembly: TypeForwardedTo(typeof(SeekOrigin))]
[assembly: TypeForwardedTo(typeof(SEHException))]
[assembly: TypeForwardedTo(typeof(SemaphoreFullException))]
[assembly: TypeForwardedTo(typeof(SemaphoreSlim))]
[assembly: TypeForwardedTo(typeof(SendOrPostCallback))]
[assembly: TypeForwardedTo(typeof(SerializableAttribute))]
[assembly: TypeForwardedTo(typeof(SerializationEntry))]
[assembly: TypeForwardedTo(typeof(SerializationException))]
[assembly: TypeForwardedTo(typeof(SerializationInfo))]
[assembly: TypeForwardedTo(typeof(SerializationInfoEnumerator))]
[assembly: TypeForwardedTo(typeof(SignatureHelper))]
[assembly: TypeForwardedTo(typeof(SignatureToken))]
[assembly: TypeForwardedTo(typeof(float))]
[assembly: TypeForwardedTo(typeof(SortKey))]
[assembly: TypeForwardedTo(typeof(SortVersion))]
[assembly: TypeForwardedTo(typeof(Environment.SpecialFolder))]
[assembly: TypeForwardedTo(typeof(Environment.SpecialFolderOption))]
[assembly: TypeForwardedTo(typeof(SpecialNameAttribute))]
[assembly: TypeForwardedTo(typeof(SpinLock))]
[assembly: TypeForwardedTo(typeof(SpinWait))]
[assembly: TypeForwardedTo(typeof(StackBehaviour))]
[assembly: TypeForwardedTo(typeof(StackFrame))]
[assembly: TypeForwardedTo(typeof(StackOverflowException))]
[assembly: TypeForwardedTo(typeof(StackTrace))]
[assembly: TypeForwardedTo(typeof(StateMachineAttribute))]
[assembly: TypeForwardedTo(typeof(STAThreadAttribute))]
[assembly: TypeForwardedTo(typeof(STATSTG))]
[assembly: TypeForwardedTo(typeof(Stream))]
[assembly: TypeForwardedTo(typeof(StreamingContext))]
[assembly: TypeForwardedTo(typeof(StreamingContextStates))]
[assembly: TypeForwardedTo(typeof(StreamReader))]
[assembly: TypeForwardedTo(typeof(StreamWriter))]
[assembly: TypeForwardedTo(typeof(string))]
[assembly: TypeForwardedTo(typeof(StringBuilder))]
[assembly: TypeForwardedTo(typeof(StringComparer))]
[assembly: TypeForwardedTo(typeof(StringComparison))]
[assembly: TypeForwardedTo(typeof(StringFreezingAttribute))]
[assembly: TypeForwardedTo(typeof(StringInfo))]
[assembly: TypeForwardedTo(typeof(StringReader))]
[assembly: TypeForwardedTo(typeof(StringSplitOptions))]
[assembly: TypeForwardedTo(typeof(StringToken))]
[assembly: TypeForwardedTo(typeof(StringWriter))]
[assembly: TypeForwardedTo(typeof(StrongNameKeyPair))]
[assembly: TypeForwardedTo(typeof(StructLayoutAttribute))]
[assembly: TypeForwardedTo(typeof(SuppressIldasmAttribute))]
[assembly: TypeForwardedTo(typeof(SuppressMessageAttribute))]
[assembly: TypeForwardedTo(typeof(SuppressUnmanagedCodeSecurityAttribute))]
[assembly: TypeForwardedTo(typeof(SynchronizationContext))]
[assembly: TypeForwardedTo(typeof(SynchronizationLockException))]
[assembly: TypeForwardedTo(typeof(TextReader.SyncTextReader))]
[assembly: TypeForwardedTo(typeof(TextWriter.SyncTextWriter))]
[assembly: TypeForwardedTo(typeof(SYSKIND))]
[assembly: TypeForwardedTo(typeof(SystemException))]
[assembly: TypeForwardedTo(typeof(TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView))]
[assembly: TypeForwardedTo(typeof(SpinLock.SystemThreading_SpinLockDebugView))]
[assembly: TypeForwardedTo(typeof(TaiwanCalendar))]
[assembly: TypeForwardedTo(typeof(TaiwanLunisolarCalendar))]
[assembly: TypeForwardedTo(typeof(TargetedPatchingOptOutAttribute))]
[assembly: TypeForwardedTo(typeof(TargetException))]
[assembly: TypeForwardedTo(typeof(TargetFrameworkAttribute))]
[assembly: TypeForwardedTo(typeof(TargetInvocationException))]
[assembly: TypeForwardedTo(typeof(TargetParameterCountException))]
[assembly: TypeForwardedTo(typeof(Task))]
[assembly: TypeForwardedTo(typeof(TaskAwaiter))]
[assembly: TypeForwardedTo(typeof(TaskAwaiter<>))]
[assembly: TypeForwardedTo(typeof(TaskCanceledException))]
[assembly: TypeForwardedTo(typeof(TaskCompletionSource<>))]
[assembly: TypeForwardedTo(typeof(TaskContinuationOptions))]
[assembly: TypeForwardedTo(typeof(TaskCreationOptions))]
[assembly: TypeForwardedTo(typeof(TaskFactory))]
[assembly: TypeForwardedTo(typeof(TaskFactory<>))]
[assembly: TypeForwardedTo(typeof(TaskScheduler))]
[assembly: TypeForwardedTo(typeof(TaskSchedulerException))]
[assembly: TypeForwardedTo(typeof(TaskStatus))]
[assembly: TypeForwardedTo(typeof(Task<>.TaskWhenAnyCast))]
[assembly: TypeForwardedTo(typeof(Task<>))]
[assembly: TypeForwardedTo(typeof(TextElementEnumerator))]
[assembly: TypeForwardedTo(typeof(TextInfo))]
[assembly: TypeForwardedTo(typeof(TextReader))]
[assembly: TypeForwardedTo(typeof(TextWriter))]
[assembly: TypeForwardedTo(typeof(ThaiBuddhistCalendar))]
[assembly: TypeForwardedTo(typeof(Thread))]
[assembly: TypeForwardedTo(typeof(ThreadAbortException))]
[assembly: TypeForwardedTo(typeof(ThreadInterruptedException))]
[assembly: TypeForwardedTo(typeof(ThreadLocal<>))]
[assembly: TypeForwardedTo(typeof(ThreadPool))]
[assembly: TypeForwardedTo(typeof(ThreadPoolBoundHandle))]
[assembly: TypeForwardedTo(typeof(ThreadPriority))]
[assembly: TypeForwardedTo(typeof(ThreadStart))]
[assembly: TypeForwardedTo(typeof(ThreadStartException))]
[assembly: TypeForwardedTo(typeof(ThreadState))]
[assembly: TypeForwardedTo(typeof(ThreadStateException))]
[assembly: TypeForwardedTo(typeof(ThreadStaticAttribute))]
[assembly: TypeForwardedTo(typeof(Timeout))]
[assembly: TypeForwardedTo(typeof(TimeoutException))]
[assembly: TypeForwardedTo(typeof(Timer))]
[assembly: TypeForwardedTo(typeof(TimerCallback))]
[assembly: TypeForwardedTo(typeof(TimeSpan))]
[assembly: TypeForwardedTo(typeof(TimeSpanStyles))]
[assembly: TypeForwardedTo(typeof(TimeZone))]
[assembly: TypeForwardedTo(typeof(TimeZoneInfo))]
[assembly: TypeForwardedTo(typeof(TimeZoneNotFoundException))]
[assembly: TypeForwardedTo(typeof(DateTimeFormatInfo.TokenHashValue))]
[assembly: TypeForwardedTo(typeof(TokenImpersonationLevel))]
[assembly: TypeForwardedTo(typeof(StackTrace.TraceFormat))]
[assembly: TypeForwardedTo(typeof(TimeZoneInfo.TransitionTime))]
[assembly: TypeForwardedTo(typeof(RuntimeHelpers.TryCode))]
[assembly: TypeForwardedTo(typeof(Tuple))]
[assembly: TypeForwardedTo(typeof(TupleElementNamesAttribute))]
[assembly: TypeForwardedTo(typeof(TupleExtensions))]
[assembly: TypeForwardedTo(typeof(Tuple<>))]
[assembly: TypeForwardedTo(typeof(Tuple<, >))]
[assembly: TypeForwardedTo(typeof(Tuple<, , >))]
[assembly: TypeForwardedTo(typeof(Tuple<, , , >))]
[assembly: TypeForwardedTo(typeof(Tuple<, , , , >))]
[assembly: TypeForwardedTo(typeof(Tuple<, , , , , >))]
[assembly: TypeForwardedTo(typeof(Tuple<, , , , , , >))]
[assembly: TypeForwardedTo(typeof(Tuple<, , , , , , , >))]
[assembly: TypeForwardedTo(typeof(Type))]
[assembly: TypeForwardedTo(typeof(TypeAccessException))]
[assembly: TypeForwardedTo(typeof(TYPEATTR))]
[assembly: TypeForwardedTo(typeof(TypeAttributes))]
[assembly: TypeForwardedTo(typeof(TypeBuilder))]
[assembly: TypeForwardedTo(typeof(TypeCode))]
[assembly: TypeForwardedTo(typeof(TypeDelegator))]
[assembly: TypeForwardedTo(typeof(TYPEDESC))]
[assembly: TypeForwardedTo(typeof(TypedReference))]
[assembly: TypeForwardedTo(typeof(TypeFilter))]
[assembly: TypeForwardedTo(typeof(TYPEFLAGS))]
[assembly: TypeForwardedTo(typeof(TypeForwardedFromAttribute))]
[assembly: TypeForwardedTo(typeof(TypeForwardedToAttribute))]
[assembly: TypeForwardedTo(typeof(TypeIdentifierAttribute))]
[assembly: TypeForwardedTo(typeof(TypeInfo))]
[assembly: TypeForwardedTo(typeof(TypeInitializationException))]
[assembly: TypeForwardedTo(typeof(TYPEKIND))]
[assembly: TypeForwardedTo(typeof(TYPELIBATTR))]
[assembly: TypeForwardedTo(typeof(TypeLoadException))]
[assembly: TypeForwardedTo(typeof(TypeToken))]
[assembly: TypeForwardedTo(typeof(TypeUnloadedException))]
[assembly: TypeForwardedTo(typeof(ushort))]
[assembly: TypeForwardedTo(typeof(uint))]
[assembly: TypeForwardedTo(typeof(ulong))]
[assembly: TypeForwardedTo(typeof(UIntPtr))]
[assembly: TypeForwardedTo(typeof(UltimateResourceFallbackLocation))]
[assembly: TypeForwardedTo(typeof(UmAlQuraCalendar))]
[assembly: TypeForwardedTo(typeof(UnauthorizedAccessException))]
[assembly: TypeForwardedTo(typeof(UnhandledExceptionEventArgs))]
[assembly: TypeForwardedTo(typeof(UnhandledExceptionEventHandler))]
[assembly: TypeForwardedTo(typeof(UnicodeCategory))]
[assembly: TypeForwardedTo(typeof(UnicodeEncoding))]
[assembly: TypeForwardedTo(typeof(UnitySerializationHolder))]
[assembly: TypeForwardedTo(typeof(UnknownWrapper))]
[assembly: TypeForwardedTo(typeof(UnmanagedFunctionPointerAttribute))]
[assembly: TypeForwardedTo(typeof(UnmanagedMemoryAccessor))]
[assembly: TypeForwardedTo(typeof(UnmanagedMemoryStream))]
[assembly: TypeForwardedTo(typeof(UnmanagedType))]
[assembly: TypeForwardedTo(typeof(UnobservedTaskExceptionEventArgs))]
[assembly: TypeForwardedTo(typeof(UnsafeValueTypeAttribute))]
[assembly: TypeForwardedTo(typeof(UnverifiableCodeAttribute))]
[assembly: TypeForwardedTo(typeof(UTF32Encoding))]
[assembly: TypeForwardedTo(typeof(UTF7Encoding))]
[assembly: TypeForwardedTo(typeof(UTF8Encoding))]
[assembly: TypeForwardedTo(typeof(UTF8Encoding.UTF8EncodingSealed))]
[assembly: TypeForwardedTo(typeof(Dictionary<, >.ValueCollection))]
[assembly: TypeForwardedTo(typeof(ValueTuple))]
[assembly: TypeForwardedTo(typeof(ValueTuple<>))]
[assembly: TypeForwardedTo(typeof(ValueTuple<, >))]
[assembly: TypeForwardedTo(typeof(ValueTuple<, , >))]
[assembly: TypeForwardedTo(typeof(ValueTuple<, , , >))]
[assembly: TypeForwardedTo(typeof(ValueTuple<, , , , >))]
[assembly: TypeForwardedTo(typeof(ValueTuple<, , , , , >))]
[assembly: TypeForwardedTo(typeof(ValueTuple<, , , , , , >))]
[assembly: TypeForwardedTo(typeof(ValueTuple<, , , , , , , >))]
[assembly: TypeForwardedTo(typeof(ValueType))]
[assembly: TypeForwardedTo(typeof(VARDESC))]
[assembly: TypeForwardedTo(typeof(VarEnum))]
[assembly: TypeForwardedTo(typeof(VARFLAGS))]
[assembly: TypeForwardedTo(typeof(VariantWrapper))]
[assembly: TypeForwardedTo(typeof(VARKIND))]
[assembly: TypeForwardedTo(typeof(VerificationException))]
[assembly: TypeForwardedTo(typeof(Version))]
[assembly: TypeForwardedTo(typeof(VersioningHelper))]
[assembly: TypeForwardedTo(typeof(void))]
[assembly: TypeForwardedTo(typeof(Volatile))]
[assembly: TypeForwardedTo(typeof(WaitCallback))]
[assembly: TypeForwardedTo(typeof(WaitHandle))]
[assembly: TypeForwardedTo(typeof(WaitHandleCannotBeOpenedException))]
[assembly: TypeForwardedTo(typeof(WaitHandleExtensions))]
[assembly: TypeForwardedTo(typeof(WaitOrTimerCallback))]
[assembly: TypeForwardedTo(typeof(WeakReference))]
[assembly: TypeForwardedTo(typeof(WeakReference<>))]
[assembly: TypeForwardedTo(typeof(YieldAwaitable))]
[assembly: TypeForwardedTo(typeof(YieldAwaitable.YieldAwaiter))]
// System.Resources.Writer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(IResourceWriter))]
[assembly: TypeForwardedTo(typeof(ResourceWriter))]
// System.Runtime.CompilerServices.VisualC, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(AssemblyAttributesGoHere))]
[assembly: TypeForwardedTo(typeof(AssemblyAttributesGoHereM))]
[assembly: TypeForwardedTo(typeof(AssemblyAttributesGoHereS))]
[assembly: TypeForwardedTo(typeof(AssemblyAttributesGoHereSM))]
[assembly: TypeForwardedTo(typeof(CompilerMarshalOverride))]
[assembly: TypeForwardedTo(typeof(HasCopySemanticsAttribute))]
[assembly: TypeForwardedTo(typeof(IsBoxed))]
[assembly: TypeForwardedTo(typeof(IsByValue))]
[assembly: TypeForwardedTo(typeof(IsCopyConstructed))]
[assembly: TypeForwardedTo(typeof(IsExplicitlyDereferenced))]
[assembly: TypeForwardedTo(typeof(IsImplicitlyDereferenced))]
[assembly: TypeForwardedTo(typeof(IsJitIntrinsic))]
[assembly: TypeForwardedTo(typeof(IsLong))]
[assembly: TypeForwardedTo(typeof(IsPinned))]
[assembly: TypeForwardedTo(typeof(IsSignUnspecifiedByte))]
[assembly: TypeForwardedTo(typeof(IsUdtReturn))]
[assembly: TypeForwardedTo(typeof(NativeCppClassAttribute))]
[assembly: TypeForwardedTo(typeof(RequiredAttributeAttribute))]
[assembly: TypeForwardedTo(typeof(ScopelessEnumAttribute))]
[assembly: TypeForwardedTo(typeof(SuppressMergeCheckAttribute))]
// System.Runtime.InteropServices, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(AssemblyRegistrationFlags))]
[assembly: TypeForwardedTo(typeof(AutomationProxyAttribute))]
[assembly: TypeForwardedTo(typeof(ComAliasNameAttribute))]
[assembly: TypeForwardedTo(typeof(ComCompatibleVersionAttribute))]
[assembly: TypeForwardedTo(typeof(ComConversionLossAttribute))]
[assembly: TypeForwardedTo(typeof(ComRegisterFunctionAttribute))]
[assembly: TypeForwardedTo(typeof(ComUnregisterFunctionAttribute))]
[assembly: TypeForwardedTo(typeof(ExporterEventKind))]
[assembly: TypeForwardedTo(typeof(IDispatchConstantAttribute))]
[assembly: TypeForwardedTo(typeof(IDispatchImplAttribute))]
[assembly: TypeForwardedTo(typeof(IDispatchImplType))]
[assembly: TypeForwardedTo(typeof(ImportedFromTypeLibAttribute))]
[assembly: TypeForwardedTo(typeof(IUnknownConstantAttribute))]
[assembly: TypeForwardedTo(typeof(ManagedToNativeComInteropStubAttribute))]
[assembly: TypeForwardedTo(typeof(PrimaryInteropAssemblyAttribute))]
[assembly: TypeForwardedTo(typeof(RegistrationClassContext))]
[assembly: TypeForwardedTo(typeof(RegistrationConnectionType))]
[assembly: TypeForwardedTo(typeof(RuntimeEnvironment))]
[assembly: TypeForwardedTo(typeof(SetWin32ContextInIDispatchAttribute))]
[assembly: TypeForwardedTo(typeof(TypeLibFuncAttribute))]
[assembly: TypeForwardedTo(typeof(TypeLibFuncFlags))]
[assembly: TypeForwardedTo(typeof(TypeLibImportClassAttribute))]
[assembly: TypeForwardedTo(typeof(TypeLibTypeAttribute))]
[assembly: TypeForwardedTo(typeof(TypeLibTypeFlags))]
[assembly: TypeForwardedTo(typeof(TypeLibVarAttribute))]
[assembly: TypeForwardedTo(typeof(TypeLibVarFlags))]
[assembly: TypeForwardedTo(typeof(TypeLibVersionAttribute))]
// System.Runtime.InteropServices.RuntimeInformation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(Architecture))]
[assembly: TypeForwardedTo(typeof(OSPlatform))]
[assembly: TypeForwardedTo(typeof(RuntimeInformation))]
// System.Runtime.Serialization.Formatters, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(BinaryFormatter))]
[assembly: TypeForwardedTo(typeof(Formatter))]
[assembly: TypeForwardedTo(typeof(FormatterAssemblyStyle))]
[assembly: TypeForwardedTo(typeof(FormatterConverter))]
[assembly: TypeForwardedTo(typeof(FormatterServices))]
[assembly: TypeForwardedTo(typeof(FormatterTypeStyle))]
[assembly: TypeForwardedTo(typeof(IFieldInfo))]
[assembly: TypeForwardedTo(typeof(IFormatter))]
[assembly: TypeForwardedTo(typeof(ISerializationSurrogate))]
[assembly: TypeForwardedTo(typeof(ISurrogateSelector))]
[assembly: TypeForwardedTo(typeof(ObjectIDGenerator))]
[assembly: TypeForwardedTo(typeof(ObjectManager))]
[assembly: TypeForwardedTo(typeof(SerializationBinder))]
[assembly: TypeForwardedTo(typeof(SerializationObjectManager))]
[assembly: TypeForwardedTo(typeof(SurrogateSelector))]
[assembly: TypeForwardedTo(typeof(TypeFilterLevel))]
// System.Security.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(AccessControlActions))]
[assembly: TypeForwardedTo(typeof(AccessControlModification))]
[assembly: TypeForwardedTo(typeof(AccessControlSections))]
[assembly: TypeForwardedTo(typeof(AccessControlType))]
[assembly: TypeForwardedTo(typeof(AccessRule))]
[assembly: TypeForwardedTo(typeof(AccessRule<>))]
[assembly: TypeForwardedTo(typeof(AceEnumerator))]
[assembly: TypeForwardedTo(typeof(AceFlags))]
[assembly: TypeForwardedTo(typeof(AceQualifier))]
[assembly: TypeForwardedTo(typeof(AceType))]
[assembly: TypeForwardedTo(typeof(AuditFlags))]
[assembly: TypeForwardedTo(typeof(AuditRule))]
[assembly: TypeForwardedTo(typeof(AuditRule<>))]
[assembly: TypeForwardedTo(typeof(AuthorizationRule))]
[assembly: TypeForwardedTo(typeof(AuthorizationRuleCollection))]
[assembly: TypeForwardedTo(typeof(CommonAce))]
[assembly: TypeForwardedTo(typeof(CommonAcl))]
[assembly: TypeForwardedTo(typeof(CommonObjectSecurity))]
[assembly: TypeForwardedTo(typeof(CommonSecurityDescriptor))]
[assembly: TypeForwardedTo(typeof(CompoundAce))]
[assembly: TypeForwardedTo(typeof(CompoundAceType))]
[assembly: TypeForwardedTo(typeof(ControlFlags))]
[assembly: TypeForwardedTo(typeof(CustomAce))]
[assembly: TypeForwardedTo(typeof(DiscretionaryAcl))]
[assembly: TypeForwardedTo(typeof(NativeObjectSecurity.ExceptionFromErrorCode))]
[assembly: TypeForwardedTo(typeof(GenericAce))]
[assembly: TypeForwardedTo(typeof(GenericAcl))]
[assembly: TypeForwardedTo(typeof(GenericSecurityDescriptor))]
[assembly: TypeForwardedTo(typeof(InheritanceFlags))]
[assembly: TypeForwardedTo(typeof(KnownAce))]
[assembly: TypeForwardedTo(typeof(NativeObjectSecurity))]
[assembly: TypeForwardedTo(typeof(ObjectAccessRule))]
[assembly: TypeForwardedTo(typeof(ObjectAce))]
[assembly: TypeForwardedTo(typeof(ObjectAceFlags))]
[assembly: TypeForwardedTo(typeof(ObjectAuditRule))]
[assembly: TypeForwardedTo(typeof(ObjectSecurity))]
[assembly: TypeForwardedTo(typeof(ObjectSecurity<>))]
[assembly: TypeForwardedTo(typeof(PrivilegeNotHeldException))]
[assembly: TypeForwardedTo(typeof(PropagationFlags))]
[assembly: TypeForwardedTo(typeof(QualifiedAce))]
[assembly: TypeForwardedTo(typeof(RawAcl))]
[assembly: TypeForwardedTo(typeof(RawSecurityDescriptor))]
[assembly: TypeForwardedTo(typeof(ResourceType))]
[assembly: TypeForwardedTo(typeof(SecurityInfos))]
[assembly: TypeForwardedTo(typeof(SystemAcl))]
// System.Security.Claims, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(Claim))]
[assembly: TypeForwardedTo(typeof(ClaimsIdentity))]
[assembly: TypeForwardedTo(typeof(ClaimsPrincipal))]
[assembly: TypeForwardedTo(typeof(ClaimTypes))]
[assembly: TypeForwardedTo(typeof(ClaimValueTypes))]
[assembly: TypeForwardedTo(typeof(GenericIdentity))]
[assembly: TypeForwardedTo(typeof(GenericPrincipal))]
// System.Security.Cryptography.Algorithms, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(Aes))]
[assembly: TypeForwardedTo(typeof(AsymmetricKeyExchangeDeformatter))]
[assembly: TypeForwardedTo(typeof(AsymmetricKeyExchangeFormatter))]
[assembly: TypeForwardedTo(typeof(AsymmetricSignatureDeformatter))]
[assembly: TypeForwardedTo(typeof(AsymmetricSignatureFormatter))]
[assembly: TypeForwardedTo(typeof(CryptoConfig))]
[assembly: TypeForwardedTo(typeof(DeriveBytes))]
[assembly: TypeForwardedTo(typeof(DES))]
[assembly: TypeForwardedTo(typeof(DSA))]
[assembly: TypeForwardedTo(typeof(DSAParameters))]
[assembly: TypeForwardedTo(typeof(DSASignatureDeformatter))]
[assembly: TypeForwardedTo(typeof(DSASignatureFormatter))]
[assembly: TypeForwardedTo(typeof(HMACMD5))]
[assembly: TypeForwardedTo(typeof(HMACSHA1))]
[assembly: TypeForwardedTo(typeof(HMACSHA256))]
[assembly: TypeForwardedTo(typeof(HMACSHA384))]
[assembly: TypeForwardedTo(typeof(HMACSHA512))]
[assembly: TypeForwardedTo(typeof(MaskGenerationMethod))]
[assembly: TypeForwardedTo(typeof(MD5))]
[assembly: TypeForwardedTo(typeof(PKCS1MaskGenerationMethod))]
[assembly: TypeForwardedTo(typeof(RandomNumberGenerator))]
[assembly: TypeForwardedTo(typeof(RC2))]
[assembly: TypeForwardedTo(typeof(Rfc2898DeriveBytes))]
[assembly: TypeForwardedTo(typeof(Rijndael))]
[assembly: TypeForwardedTo(typeof(RijndaelManaged))]
[assembly: TypeForwardedTo(typeof(RSA))]
[assembly: TypeForwardedTo(typeof(RSAEncryptionPadding))]
[assembly: TypeForwardedTo(typeof(RSAEncryptionPaddingMode))]
[assembly: TypeForwardedTo(typeof(RSAOAEPKeyExchangeDeformatter))]
[assembly: TypeForwardedTo(typeof(RSAOAEPKeyExchangeFormatter))]
[assembly: TypeForwardedTo(typeof(RSAParameters))]
[assembly: TypeForwardedTo(typeof(RSAPKCS1KeyExchangeDeformatter))]
[assembly: TypeForwardedTo(typeof(RSAPKCS1KeyExchangeFormatter))]
[assembly: TypeForwardedTo(typeof(RSAPKCS1SignatureDeformatter))]
[assembly: TypeForwardedTo(typeof(RSAPKCS1SignatureFormatter))]
[assembly: TypeForwardedTo(typeof(RSASignaturePadding))]
[assembly: TypeForwardedTo(typeof(RSASignaturePaddingMode))]
[assembly: TypeForwardedTo(typeof(SHA1))]
[assembly: TypeForwardedTo(typeof(SHA1Managed))]
[assembly: TypeForwardedTo(typeof(SHA256))]
[assembly: TypeForwardedTo(typeof(SHA256Managed))]
[assembly: TypeForwardedTo(typeof(SHA384))]
[assembly: TypeForwardedTo(typeof(SHA384Managed))]
[assembly: TypeForwardedTo(typeof(SHA512))]
[assembly: TypeForwardedTo(typeof(SHA512Managed))]
[assembly: TypeForwardedTo(typeof(SignatureDescription))]
[assembly: TypeForwardedTo(typeof(TripleDES))]
// System.Security.Cryptography.Csp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(CspKeyContainerInfo))]
[assembly: TypeForwardedTo(typeof(CspParameters))]
[assembly: TypeForwardedTo(typeof(CspProviderFlags))]
[assembly: TypeForwardedTo(typeof(DESCryptoServiceProvider))]
[assembly: TypeForwardedTo(typeof(DSACryptoServiceProvider))]
[assembly: TypeForwardedTo(typeof(ICspAsymmetricAlgorithm))]
[assembly: TypeForwardedTo(typeof(KeyNumber))]
[assembly: TypeForwardedTo(typeof(MD5CryptoServiceProvider))]
[assembly: TypeForwardedTo(typeof(PasswordDeriveBytes))]
[assembly: TypeForwardedTo(typeof(RC2CryptoServiceProvider))]
[assembly: TypeForwardedTo(typeof(RNGCryptoServiceProvider))]
[assembly: TypeForwardedTo(typeof(RSACryptoServiceProvider))]
[assembly: TypeForwardedTo(typeof(SHA1CryptoServiceProvider))]
[assembly: TypeForwardedTo(typeof(TripleDESCryptoServiceProvider))]
// System.Security.Cryptography.Encoding, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(FromBase64Transform))]
[assembly: TypeForwardedTo(typeof(FromBase64TransformMode))]
[assembly: TypeForwardedTo(typeof(ToBase64Transform))]
// System.Security.Cryptography.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(AsymmetricAlgorithm))]
[assembly: TypeForwardedTo(typeof(CipherMode))]
[assembly: TypeForwardedTo(typeof(CryptographicUnexpectedOperationException))]
[assembly: TypeForwardedTo(typeof(CryptoStream))]
[assembly: TypeForwardedTo(typeof(CryptoStreamMode))]
[assembly: TypeForwardedTo(typeof(HashAlgorithm))]
[assembly: TypeForwardedTo(typeof(HashAlgorithmName))]
[assembly: TypeForwardedTo(typeof(HMAC))]
[assembly: TypeForwardedTo(typeof(ICryptoTransform))]
[assembly: TypeForwardedTo(typeof(KeyedHashAlgorithm))]
[assembly: TypeForwardedTo(typeof(KeySizes))]
[assembly: TypeForwardedTo(typeof(PaddingMode))]
[assembly: TypeForwardedTo(typeof(SymmetricAlgorithm))]
// System.Security.Cryptography.X509Certificates, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(X509Certificate))]
[assembly: TypeForwardedTo(typeof(X509ContentType))]
[assembly: TypeForwardedTo(typeof(X509KeyStorageFlags))]
// System.Security.Permissions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
[assembly: TypeForwardedTo(typeof(AllMembershipCondition))]
[assembly: TypeForwardedTo(typeof(ApplicationDirectory))]
[assembly: TypeForwardedTo(typeof(ApplicationDirectoryMembershipCondition))]
[assembly: TypeForwardedTo(typeof(ApplicationIdentity))]
[assembly: TypeForwardedTo(typeof(ApplicationTrust))]
[assembly: TypeForwardedTo(typeof(ApplicationTrustCollection))]
[assembly: TypeForwardedTo(typeof(ApplicationTrustEnumerator))]
[assembly: TypeForwardedTo(typeof(ApplicationVersionMatch))]
[assembly: TypeForwardedTo(typeof(CodeAccessPermission))]
[assembly: TypeForwardedTo(typeof(CodeConnectAccess))]
[assembly: TypeForwardedTo(typeof(CodeGroup))]
[assembly: TypeForwardedTo(typeof(EnvironmentPermission))]
[assembly: TypeForwardedTo(typeof(EnvironmentPermissionAccess))]
[assembly: TypeForwardedTo(typeof(EnvironmentPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(Evidence))]
[assembly: TypeForwardedTo(typeof(EvidenceBase))]
[assembly: TypeForwardedTo(typeof(FileCodeGroup))]
[assembly: TypeForwardedTo(typeof(FileDialogPermission))]
[assembly: TypeForwardedTo(typeof(FileDialogPermissionAccess))]
[assembly: TypeForwardedTo(typeof(FileDialogPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(FileIOPermission))]
[assembly: TypeForwardedTo(typeof(FileIOPermissionAccess))]
[assembly: TypeForwardedTo(typeof(FileIOPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(FirstMatchCodeGroup))]
[assembly: TypeForwardedTo(typeof(GacIdentityPermission))]
[assembly: TypeForwardedTo(typeof(GacIdentityPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(GacInstalled))]
[assembly: TypeForwardedTo(typeof(GacMembershipCondition))]
[assembly: TypeForwardedTo(typeof(Hash))]
[assembly: TypeForwardedTo(typeof(HashMembershipCondition))]
[assembly: TypeForwardedTo(typeof(HostProtectionAttribute))]
[assembly: TypeForwardedTo(typeof(HostProtectionException))]
[assembly: TypeForwardedTo(typeof(HostProtectionResource))]
[assembly: TypeForwardedTo(typeof(HostSecurityManager))]
[assembly: TypeForwardedTo(typeof(HostSecurityManagerOptions))]
[assembly: TypeForwardedTo(typeof(IEvidenceFactory))]
[assembly: TypeForwardedTo(typeof(IIdentityPermissionFactory))]
[assembly: TypeForwardedTo(typeof(IMembershipCondition))]
[assembly: TypeForwardedTo(typeof(ISecurityPolicyEncodable))]
[assembly: TypeForwardedTo(typeof(IsolatedStorageContainment))]
[assembly: TypeForwardedTo(typeof(IsolatedStorageFilePermission))]
[assembly: TypeForwardedTo(typeof(IsolatedStorageFilePermissionAttribute))]
[assembly: TypeForwardedTo(typeof(IsolatedStoragePermission))]
[assembly: TypeForwardedTo(typeof(IsolatedStoragePermissionAttribute))]
[assembly: TypeForwardedTo(typeof(IUnrestrictedPermission))]
[assembly: TypeForwardedTo(typeof(KeyContainerPermission))]
[assembly: TypeForwardedTo(typeof(KeyContainerPermissionAccessEntry))]
[assembly: TypeForwardedTo(typeof(KeyContainerPermissionAccessEntryCollection))]
[assembly: TypeForwardedTo(typeof(KeyContainerPermissionAccessEntryEnumerator))]
[assembly: TypeForwardedTo(typeof(KeyContainerPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(KeyContainerPermissionFlags))]
[assembly: TypeForwardedTo(typeof(NamedPermissionSet))]
[assembly: TypeForwardedTo(typeof(NetCodeGroup))]
[assembly: TypeForwardedTo(typeof(PermissionRequestEvidence))]
[assembly: TypeForwardedTo(typeof(PermissionSetAttribute))]
[assembly: TypeForwardedTo(typeof(PolicyException))]
[assembly: TypeForwardedTo(typeof(PolicyLevel))]
[assembly: TypeForwardedTo(typeof(PolicyLevelType))]
[assembly: TypeForwardedTo(typeof(PolicyStatement))]
[assembly: TypeForwardedTo(typeof(PolicyStatementAttribute))]
[assembly: TypeForwardedTo(typeof(PrincipalPermission))]
[assembly: TypeForwardedTo(typeof(PrincipalPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(Publisher))]
[assembly: TypeForwardedTo(typeof(PublisherIdentityPermission))]
[assembly: TypeForwardedTo(typeof(PublisherIdentityPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(PublisherMembershipCondition))]
[assembly: TypeForwardedTo(typeof(ReflectionPermission))]
[assembly: TypeForwardedTo(typeof(ReflectionPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(ReflectionPermissionFlag))]
[assembly: TypeForwardedTo(typeof(RegistryPermission))]
[assembly: TypeForwardedTo(typeof(RegistryPermissionAccess))]
[assembly: TypeForwardedTo(typeof(RegistryPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(SecurityContext))]
[assembly: TypeForwardedTo(typeof(SecurityContextSource))]
[assembly: TypeForwardedTo(typeof(SecurityManager))]
[assembly: TypeForwardedTo(typeof(SecurityPermission))]
[assembly: TypeForwardedTo(typeof(SecurityState))]
[assembly: TypeForwardedTo(typeof(SecurityZone))]
[assembly: TypeForwardedTo(typeof(Site))]
[assembly: TypeForwardedTo(typeof(SiteIdentityPermission))]
[assembly: TypeForwardedTo(typeof(SiteIdentityPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(SiteMembershipCondition))]
[assembly: TypeForwardedTo(typeof(StrongName))]
[assembly: TypeForwardedTo(typeof(StrongNameIdentityPermission))]
[assembly: TypeForwardedTo(typeof(StrongNameIdentityPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(StrongNameMembershipCondition))]
[assembly: TypeForwardedTo(typeof(StrongNamePublicKeyBlob))]
[assembly: TypeForwardedTo(typeof(TrustManagerContext))]
[assembly: TypeForwardedTo(typeof(TrustManagerUIContext))]
[assembly: TypeForwardedTo(typeof(UIPermission))]
[assembly: TypeForwardedTo(typeof(UIPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(UIPermissionClipboard))]
[assembly: TypeForwardedTo(typeof(UIPermissionWindow))]
[assembly: TypeForwardedTo(typeof(UnionCodeGroup))]
[assembly: TypeForwardedTo(typeof(Url))]
[assembly: TypeForwardedTo(typeof(UrlIdentityPermission))]
[assembly: TypeForwardedTo(typeof(UrlIdentityPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(UrlMembershipCondition))]
[assembly: TypeForwardedTo(typeof(XmlSyntaxException))]
[assembly: TypeForwardedTo(typeof(Zone))]
[assembly: TypeForwardedTo(typeof(ZoneIdentityPermission))]
[assembly: TypeForwardedTo(typeof(ZoneIdentityPermissionAttribute))]
[assembly: TypeForwardedTo(typeof(ZoneMembershipCondition))]
// System.Security.Principal.Windows, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(IdentityNotMappedException))]
[assembly: TypeForwardedTo(typeof(IdentityReference))]
[assembly: TypeForwardedTo(typeof(IdentityReferenceCollection))]
[assembly: TypeForwardedTo(typeof(NTAccount))]
[assembly: TypeForwardedTo(typeof(SafeAccessTokenHandle))]
[assembly: TypeForwardedTo(typeof(SecurityIdentifier))]
[assembly: TypeForwardedTo(typeof(TokenAccessLevels))]
[assembly: TypeForwardedTo(typeof(WellKnownSidType))]
[assembly: TypeForwardedTo(typeof(WindowsAccountType))]
[assembly: TypeForwardedTo(typeof(WindowsBuiltInRole))]
[assembly: TypeForwardedTo(typeof(WindowsIdentity))]
[assembly: TypeForwardedTo(typeof(WindowsPrincipal))]
// System.Threading, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(CountdownEvent))]
[assembly: TypeForwardedTo(typeof(HostExecutionContext))]
[assembly: TypeForwardedTo(typeof(HostExecutionContextManager))]
[assembly: TypeForwardedTo(typeof(LockCookie))]
[assembly: TypeForwardedTo(typeof(ReaderWriterLock))]
// System.Threading.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(EventWaitHandleAccessRule))]
[assembly: TypeForwardedTo(typeof(EventWaitHandleAuditRule))]
[assembly: TypeForwardedTo(typeof(EventWaitHandleRights))]
[assembly: TypeForwardedTo(typeof(EventWaitHandleSecurity))]
[assembly: TypeForwardedTo(typeof(MutexAccessRule))]
[assembly: TypeForwardedTo(typeof(MutexAuditRule))]
[assembly: TypeForwardedTo(typeof(MutexRights))]
[assembly: TypeForwardedTo(typeof(MutexSecurity))]
// System.Threading.Tasks.Parallel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: TypeForwardedTo(typeof(Parallel))]
[assembly: TypeForwardedTo(typeof(ParallelLoopResult))]
[assembly: TypeForwardedTo(typeof(ParallelLoopState))]
[assembly: TypeForwardedTo(typeof(ParallelOptions))]
