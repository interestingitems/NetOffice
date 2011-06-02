//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Workbook_OpenEventHandler();
	public delegate void Workbook_ActivateEventHandler();
	public delegate void Workbook_DeactivateEventHandler();
	public delegate void Workbook_BeforeCloseEventHandler(ref bool Cancel);
	public delegate void Workbook_BeforeSaveEventHandler(bool SaveAsUI, ref bool Cancel);
	public delegate void Workbook_BeforePrintEventHandler(ref bool Cancel);
	public delegate void Workbook_NewSheetEventHandler(COMObject Sh);
	public delegate void Workbook_AddinInstallEventHandler();
	public delegate void Workbook_AddinUninstallEventHandler();
	public delegate void Workbook_WindowResizeEventHandler(NetOffice.ExcelApi.Window Wn);
	public delegate void Workbook_WindowActivateEventHandler(NetOffice.ExcelApi.Window Wn);
	public delegate void Workbook_WindowDeactivateEventHandler(NetOffice.ExcelApi.Window Wn);
	public delegate void Workbook_SheetSelectionChangeEventHandler(COMObject Sh, NetOffice.ExcelApi.Range Target);
	public delegate void Workbook_SheetBeforeDoubleClickEventHandler(COMObject Sh, NetOffice.ExcelApi.Range Target, ref bool Cancel);
	public delegate void Workbook_SheetBeforeRightClickEventHandler(COMObject Sh, NetOffice.ExcelApi.Range Target, ref bool Cancel);
	public delegate void Workbook_SheetActivateEventHandler(COMObject Sh);
	public delegate void Workbook_SheetDeactivateEventHandler(COMObject Sh);
	public delegate void Workbook_SheetCalculateEventHandler(COMObject Sh);
	public delegate void Workbook_SheetChangeEventHandler(COMObject Sh, NetOffice.ExcelApi.Range Target);
	public delegate void Workbook_SheetFollowHyperlinkEventHandler(COMObject Sh, NetOffice.ExcelApi.Hyperlink Target);
	public delegate void Workbook_SheetPivotTableUpdateEventHandler(COMObject Sh, NetOffice.ExcelApi.PivotTable Target);
	public delegate void Workbook_PivotTableCloseConnectionEventHandler(NetOffice.ExcelApi.PivotTable Target);
	public delegate void Workbook_PivotTableOpenConnectionEventHandler(NetOffice.ExcelApi.PivotTable Target);
	public delegate void Workbook_SyncEventHandler(NetOffice.OfficeApi.Enums.MsoSyncEventType SyncEventType);
	public delegate void Workbook_BeforeXmlImportEventHandler(NetOffice.ExcelApi.XmlMap Map, string Url, bool IsRefresh, ref bool Cancel);
	public delegate void Workbook_AfterXmlImportEventHandler(NetOffice.ExcelApi.XmlMap Map, bool IsRefresh, NetOffice.ExcelApi.Enums.XlXmlImportResult Result);
	public delegate void Workbook_BeforeXmlExportEventHandler(NetOffice.ExcelApi.XmlMap Map, string Url, ref bool Cancel);
	public delegate void Workbook_AfterXmlExportEventHandler(NetOffice.ExcelApi.XmlMap Map, string Url, NetOffice.ExcelApi.Enums.XlXmlExportResult Result);
	public delegate void Workbook_RowsetCompleteEventHandler(string Description, string Sheet, bool Success);
	public delegate void Workbook_SheetPivotTableAfterValueChangeEventHandler(COMObject Sh, NetOffice.ExcelApi.PivotTable TargetPivotTable, NetOffice.ExcelApi.Range TargetRange);
	public delegate void Workbook_SheetPivotTableBeforeAllocateChangesEventHandler(COMObject Sh, NetOffice.ExcelApi.PivotTable TargetPivotTable, Int32 ValueChangeStart, Int32 ValueChangeEnd, ref bool Cancel);
	public delegate void Workbook_SheetPivotTableBeforeCommitChangesEventHandler(COMObject Sh, NetOffice.ExcelApi.PivotTable TargetPivotTable, Int32 ValueChangeStart, Int32 ValueChangeEnd, ref bool Cancel);
	public delegate void Workbook_SheetPivotTableBeforeDiscardChangesEventHandler(COMObject Sh, NetOffice.ExcelApi.PivotTable TargetPivotTable, Int32 ValueChangeStart, Int32 ValueChangeEnd);
	public delegate void Workbook_SheetPivotTableChangeSyncEventHandler(COMObject Sh, NetOffice.ExcelApi.PivotTable Target);
	public delegate void Workbook_AfterSaveEventHandler(bool Success);
	public delegate void Workbook_NewChartEventHandler(NetOffice.ExcelApi.Chart Ch);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Workbook SupportByLibrary Excel, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Workbook : _Workbook, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		WorkbookEvents_SinkHelper _workbookEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public Workbook(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Workbook(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Workbook(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public Workbook()
		{
			CreateFromProgId("Excel.Workbook");
		}
		
		/// <param name="progId">progId</param>
		public Workbook(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, WorkbookEvents_SinkHelper.Id);


			if(WorkbookEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_workbookEvents_SinkHelper = new WorkbookEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_OpenEventHandler _OpenEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_OpenEventHandler OpenEvent
		{
			add
			{
				CreateEventBridge();
				_OpenEvent += value;
			}
			remove
			{
				_OpenEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_ActivateEventHandler _ActivateEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_ActivateEventHandler ActivateEvent
		{
			add
			{
				CreateEventBridge();
				_ActivateEvent += value;
			}
			remove
			{
				_ActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_DeactivateEventHandler _DeactivateEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_DeactivateEventHandler DeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_DeactivateEvent += value;
			}
			remove
			{
				_DeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_BeforeCloseEventHandler _BeforeCloseEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_BeforeCloseEventHandler BeforeCloseEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeCloseEvent += value;
			}
			remove
			{
				_BeforeCloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_BeforeSaveEventHandler _BeforeSaveEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_BeforeSaveEventHandler BeforeSaveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeSaveEvent += value;
			}
			remove
			{
				_BeforeSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_BeforePrintEventHandler _BeforePrintEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_BeforePrintEventHandler BeforePrintEvent
		{
			add
			{
				CreateEventBridge();
				_BeforePrintEvent += value;
			}
			remove
			{
				_BeforePrintEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_NewSheetEventHandler _NewSheetEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_NewSheetEventHandler NewSheetEvent
		{
			add
			{
				CreateEventBridge();
				_NewSheetEvent += value;
			}
			remove
			{
				_NewSheetEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_AddinInstallEventHandler _AddinInstallEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_AddinInstallEventHandler AddinInstallEvent
		{
			add
			{
				CreateEventBridge();
				_AddinInstallEvent += value;
			}
			remove
			{
				_AddinInstallEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_AddinUninstallEventHandler _AddinUninstallEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_AddinUninstallEventHandler AddinUninstallEvent
		{
			add
			{
				CreateEventBridge();
				_AddinUninstallEvent += value;
			}
			remove
			{
				_AddinUninstallEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_WindowResizeEventHandler _WindowResizeEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_WindowResizeEventHandler WindowResizeEvent
		{
			add
			{
				CreateEventBridge();
				_WindowResizeEvent += value;
			}
			remove
			{
				_WindowResizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_WindowActivateEventHandler _WindowActivateEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_WindowActivateEventHandler WindowActivateEvent
		{
			add
			{
				CreateEventBridge();
				_WindowActivateEvent += value;
			}
			remove
			{
				_WindowActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_WindowDeactivateEventHandler _WindowDeactivateEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_WindowDeactivateEventHandler WindowDeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_WindowDeactivateEvent += value;
			}
			remove
			{
				_WindowDeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_SheetSelectionChangeEventHandler _SheetSelectionChangeEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_SheetSelectionChangeEventHandler SheetSelectionChangeEvent
		{
			add
			{
				CreateEventBridge();
				_SheetSelectionChangeEvent += value;
			}
			remove
			{
				_SheetSelectionChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_SheetBeforeDoubleClickEventHandler _SheetBeforeDoubleClickEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_SheetBeforeDoubleClickEventHandler SheetBeforeDoubleClickEvent
		{
			add
			{
				CreateEventBridge();
				_SheetBeforeDoubleClickEvent += value;
			}
			remove
			{
				_SheetBeforeDoubleClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_SheetBeforeRightClickEventHandler _SheetBeforeRightClickEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_SheetBeforeRightClickEventHandler SheetBeforeRightClickEvent
		{
			add
			{
				CreateEventBridge();
				_SheetBeforeRightClickEvent += value;
			}
			remove
			{
				_SheetBeforeRightClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_SheetActivateEventHandler _SheetActivateEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_SheetActivateEventHandler SheetActivateEvent
		{
			add
			{
				CreateEventBridge();
				_SheetActivateEvent += value;
			}
			remove
			{
				_SheetActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_SheetDeactivateEventHandler _SheetDeactivateEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_SheetDeactivateEventHandler SheetDeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_SheetDeactivateEvent += value;
			}
			remove
			{
				_SheetDeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_SheetCalculateEventHandler _SheetCalculateEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_SheetCalculateEventHandler SheetCalculateEvent
		{
			add
			{
				CreateEventBridge();
				_SheetCalculateEvent += value;
			}
			remove
			{
				_SheetCalculateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_SheetChangeEventHandler _SheetChangeEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_SheetChangeEventHandler SheetChangeEvent
		{
			add
			{
				CreateEventBridge();
				_SheetChangeEvent += value;
			}
			remove
			{
				_SheetChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 9,10,11,12,14
		/// </summary>
		private event Workbook_SheetFollowHyperlinkEventHandler _SheetFollowHyperlinkEvent;

		/// <summary>
		/// SupportByLibrary Excel 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public event Workbook_SheetFollowHyperlinkEventHandler SheetFollowHyperlinkEvent
		{
			add
			{
				CreateEventBridge();
				_SheetFollowHyperlinkEvent += value;
			}
			remove
			{
				_SheetFollowHyperlinkEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 10,11,12,14
		/// </summary>
		private event Workbook_SheetPivotTableUpdateEventHandler _SheetPivotTableUpdateEvent;

		/// <summary>
		/// SupportByLibrary Excel 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public event Workbook_SheetPivotTableUpdateEventHandler SheetPivotTableUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_SheetPivotTableUpdateEvent += value;
			}
			remove
			{
				_SheetPivotTableUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 10,11,12,14
		/// </summary>
		private event Workbook_PivotTableCloseConnectionEventHandler _PivotTableCloseConnectionEvent;

		/// <summary>
		/// SupportByLibrary Excel 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public event Workbook_PivotTableCloseConnectionEventHandler PivotTableCloseConnectionEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableCloseConnectionEvent += value;
			}
			remove
			{
				_PivotTableCloseConnectionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 10,11,12,14
		/// </summary>
		private event Workbook_PivotTableOpenConnectionEventHandler _PivotTableOpenConnectionEvent;

		/// <summary>
		/// SupportByLibrary Excel 10 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public event Workbook_PivotTableOpenConnectionEventHandler PivotTableOpenConnectionEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableOpenConnectionEvent += value;
			}
			remove
			{
				_PivotTableOpenConnectionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 11,12,14
		/// </summary>
		private event Workbook_SyncEventHandler _SyncEvent;

		/// <summary>
		/// SupportByLibrary Excel 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public event Workbook_SyncEventHandler SyncEvent
		{
			add
			{
				CreateEventBridge();
				_SyncEvent += value;
			}
			remove
			{
				_SyncEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 11,12,14
		/// </summary>
		private event Workbook_BeforeXmlImportEventHandler _BeforeXmlImportEvent;

		/// <summary>
		/// SupportByLibrary Excel 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public event Workbook_BeforeXmlImportEventHandler BeforeXmlImportEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeXmlImportEvent += value;
			}
			remove
			{
				_BeforeXmlImportEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 11,12,14
		/// </summary>
		private event Workbook_AfterXmlImportEventHandler _AfterXmlImportEvent;

		/// <summary>
		/// SupportByLibrary Excel 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public event Workbook_AfterXmlImportEventHandler AfterXmlImportEvent
		{
			add
			{
				CreateEventBridge();
				_AfterXmlImportEvent += value;
			}
			remove
			{
				_AfterXmlImportEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 11,12,14
		/// </summary>
		private event Workbook_BeforeXmlExportEventHandler _BeforeXmlExportEvent;

		/// <summary>
		/// SupportByLibrary Excel 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public event Workbook_BeforeXmlExportEventHandler BeforeXmlExportEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeXmlExportEvent += value;
			}
			remove
			{
				_BeforeXmlExportEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 11,12,14
		/// </summary>
		private event Workbook_AfterXmlExportEventHandler _AfterXmlExportEvent;

		/// <summary>
		/// SupportByLibrary Excel 11 12 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public event Workbook_AfterXmlExportEventHandler AfterXmlExportEvent
		{
			add
			{
				CreateEventBridge();
				_AfterXmlExportEvent += value;
			}
			remove
			{
				_AfterXmlExportEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 12,14
		/// </summary>
		private event Workbook_RowsetCompleteEventHandler _RowsetCompleteEvent;

		/// <summary>
		/// SupportByLibrary Excel 12 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public event Workbook_RowsetCompleteEventHandler RowsetCompleteEvent
		{
			add
			{
				CreateEventBridge();
				_RowsetCompleteEvent += value;
			}
			remove
			{
				_RowsetCompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 14
		/// </summary>
		private event Workbook_SheetPivotTableAfterValueChangeEventHandler _SheetPivotTableAfterValueChangeEvent;

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public event Workbook_SheetPivotTableAfterValueChangeEventHandler SheetPivotTableAfterValueChangeEvent
		{
			add
			{
				CreateEventBridge();
				_SheetPivotTableAfterValueChangeEvent += value;
			}
			remove
			{
				_SheetPivotTableAfterValueChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 14
		/// </summary>
		private event Workbook_SheetPivotTableBeforeAllocateChangesEventHandler _SheetPivotTableBeforeAllocateChangesEvent;

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public event Workbook_SheetPivotTableBeforeAllocateChangesEventHandler SheetPivotTableBeforeAllocateChangesEvent
		{
			add
			{
				CreateEventBridge();
				_SheetPivotTableBeforeAllocateChangesEvent += value;
			}
			remove
			{
				_SheetPivotTableBeforeAllocateChangesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 14
		/// </summary>
		private event Workbook_SheetPivotTableBeforeCommitChangesEventHandler _SheetPivotTableBeforeCommitChangesEvent;

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public event Workbook_SheetPivotTableBeforeCommitChangesEventHandler SheetPivotTableBeforeCommitChangesEvent
		{
			add
			{
				CreateEventBridge();
				_SheetPivotTableBeforeCommitChangesEvent += value;
			}
			remove
			{
				_SheetPivotTableBeforeCommitChangesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 14
		/// </summary>
		private event Workbook_SheetPivotTableBeforeDiscardChangesEventHandler _SheetPivotTableBeforeDiscardChangesEvent;

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public event Workbook_SheetPivotTableBeforeDiscardChangesEventHandler SheetPivotTableBeforeDiscardChangesEvent
		{
			add
			{
				CreateEventBridge();
				_SheetPivotTableBeforeDiscardChangesEvent += value;
			}
			remove
			{
				_SheetPivotTableBeforeDiscardChangesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 14
		/// </summary>
		private event Workbook_SheetPivotTableChangeSyncEventHandler _SheetPivotTableChangeSyncEvent;

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public event Workbook_SheetPivotTableChangeSyncEventHandler SheetPivotTableChangeSyncEvent
		{
			add
			{
				CreateEventBridge();
				_SheetPivotTableChangeSyncEvent += value;
			}
			remove
			{
				_SheetPivotTableChangeSyncEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 14
		/// </summary>
		private event Workbook_AfterSaveEventHandler _AfterSaveEvent;

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public event Workbook_AfterSaveEventHandler AfterSaveEvent
		{
			add
			{
				CreateEventBridge();
				_AfterSaveEvent += value;
			}
			remove
			{
				_AfterSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel, 14
		/// </summary>
		private event Workbook_NewChartEventHandler _NewChartEvent;

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public event Workbook_NewChartEventHandler NewChartEvent
		{
			add
			{
				CreateEventBridge();
				_NewChartEvent += value;
			}
			remove
			{
				_NewChartEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _workbookEvents_SinkHelper)
			{
				_workbookEvents_SinkHelper.Dispose();
				_workbookEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}