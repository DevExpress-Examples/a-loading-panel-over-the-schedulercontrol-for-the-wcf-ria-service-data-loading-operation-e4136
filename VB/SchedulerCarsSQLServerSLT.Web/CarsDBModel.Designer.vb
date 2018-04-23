﻿'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Xml.Serialization

<Assembly: EdmSchemaAttribute()>
Namespace SchedulerCarsSQLServerSLT.Web
	#Region "Contexts"

	''' <summary>
	''' No Metadata Documentation available.
	''' </summary>
	Partial Public Class CarsXtraSchedulingEntities
		Inherits ObjectContext
		#Region "Constructors"

		''' <summary>
		''' Initializes a new CarsXtraSchedulingEntities object using the connection string found in the 'CarsXtraSchedulingEntities' section of the application configuration file.
		''' </summary>
		Public Sub New()
			MyBase.New("name=CarsXtraSchedulingEntities", "CarsXtraSchedulingEntities")
			Me.ContextOptions.LazyLoadingEnabled = True
			OnContextCreated()
		End Sub

		''' <summary>
		''' Initialize a new CarsXtraSchedulingEntities object.
		''' </summary>
		Public Sub New(ByVal connectionString As String)
			MyBase.New(connectionString, "CarsXtraSchedulingEntities")
			Me.ContextOptions.LazyLoadingEnabled = True
			OnContextCreated()
		End Sub

		''' <summary>
		''' Initialize a new CarsXtraSchedulingEntities object.
		''' </summary>
		Public Sub New(ByVal connection As EntityConnection)
			MyBase.New(connection, "CarsXtraSchedulingEntities")
			Me.ContextOptions.LazyLoadingEnabled = True
			OnContextCreated()
		End Sub

		#End Region

		#Region "Partial Methods"

		Partial Private Sub OnContextCreated()
		End Sub

		#End Region

		#Region "ObjectSet Properties"

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		Public ReadOnly Property Cars() As ObjectSet(Of Cars)
			Get
				If (_Cars Is Nothing) Then
					_Cars = MyBase.CreateObjectSet(Of Cars)("Cars")
				End If
				Return _Cars
			End Get
		End Property
		Private _Cars As ObjectSet(Of Cars)

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		Public ReadOnly Property CarScheduling() As ObjectSet(Of CarScheduling)
			Get
				If (_CarScheduling Is Nothing) Then
					_CarScheduling = MyBase.CreateObjectSet(Of CarScheduling)("CarScheduling")
				End If
				Return _CarScheduling
			End Get
		End Property
		Private _CarScheduling As ObjectSet(Of CarScheduling)

		#End Region

		#Region "AddTo Methods"

		''' <summary>
		''' Deprecated Method for adding a new object to the Cars EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
		''' </summary>
		Public Sub AddToCars(ByVal cars As Cars)
			MyBase.AddObject("Cars", cars)
		End Sub

		''' <summary>
		''' Deprecated Method for adding a new object to the CarScheduling EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
		''' </summary>
		Public Sub AddToCarScheduling(ByVal carScheduling As CarScheduling)
			MyBase.AddObject("CarScheduling", carScheduling)
		End Sub

		#End Region

	End Class

	#End Region

	#Region "Entities"

	''' <summary>
	''' No Metadata Documentation available.
	''' </summary>
	<EdmEntityTypeAttribute(NamespaceName:="CarsXtraSchedulingModel", Name:="Cars"), Serializable(), DataContractAttribute(IsReference:=True)> _
	Partial Public Class Cars
		Inherits EntityObject
		#Region "Factory Method"

		''' <summary>
		''' Create a new Cars object.
		''' </summary>
		''' <param name="id">Initial value of the ID property.</param>
		Public Shared Function CreateCars(ByVal id As Global.System.Int32) As Cars
			Dim cars As New Cars()
			cars.ID = id
			Return cars
		End Function

		#End Region

		#Region "Primitive Properties"

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property ID() As Global.System.Int32
			Get
				Return _ID
			End Get
			Set(ByVal value As System.Int32)
				If _ID <> value Then
					OnIDChanging(value)
					ReportPropertyChanging("ID")
					_ID = StructuralObject.SetValidValue(value)
					ReportPropertyChanged("ID")
					OnIDChanged()
				End If
			End Set
		End Property
		Private _ID As Global.System.Int32
		Partial Private Sub OnIDChanging(ByVal value As Global.System.Int32)
		End Sub
		Partial Private Sub OnIDChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Trademark() As Global.System.String
			Get
				Return _Trademark
			End Get
			Set(ByVal value As System.String)
				OnTrademarkChanging(value)
				ReportPropertyChanging("Trademark")
				_Trademark = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Trademark")
				OnTrademarkChanged()
			End Set
		End Property
		Private _Trademark As Global.System.String
		Partial Private Sub OnTrademarkChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnTrademarkChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Model() As Global.System.String
			Get
				Return _Model
			End Get
			Set(ByVal value As System.String)
				OnModelChanging(value)
				ReportPropertyChanging("Model")
				_Model = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Model")
				OnModelChanged()
			End Set
		End Property
		Private _Model As Global.System.String
		Partial Private Sub OnModelChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnModelChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property HP() As Global.System.Int16?
			Get
				Return _HP
			End Get
			Set(ByVal value? As System.Int16)
				OnHPChanging(value)
				ReportPropertyChanging("HP")
				_HP = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("HP")
				OnHPChanged()
			End Set
		End Property
		Private _HP? As Global.System.Int16
		Partial Private Sub OnHPChanging(ByVal value? As Global.System.Int16)
		End Sub
		Partial Private Sub OnHPChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Liter() As Global.System.Double?
			Get
				Return _Liter
			End Get
			Set(ByVal value? As System.Double)
				OnLiterChanging(value)
				ReportPropertyChanging("Liter")
				_Liter = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("Liter")
				OnLiterChanged()
			End Set
		End Property
		Private _Liter? As Global.System.Double
		Partial Private Sub OnLiterChanging(ByVal value? As Global.System.Double)
		End Sub
		Partial Private Sub OnLiterChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Cyl() As Global.System.Int16?
			Get
				Return _Cyl
			End Get
			Set(ByVal value? As System.Int16)
				OnCylChanging(value)
				ReportPropertyChanging("Cyl")
				_Cyl = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("Cyl")
				OnCylChanged()
			End Set
		End Property
		Private _Cyl? As Global.System.Int16
		Partial Private Sub OnCylChanging(ByVal value? As Global.System.Int16)
		End Sub
		Partial Private Sub OnCylChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property TransmissSpeedCount() As Global.System.Int16?
			Get
				Return _TransmissSpeedCount
			End Get
			Set(ByVal value? As System.Int16)
				OnTransmissSpeedCountChanging(value)
				ReportPropertyChanging("TransmissSpeedCount")
				_TransmissSpeedCount = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("TransmissSpeedCount")
				OnTransmissSpeedCountChanged()
			End Set
		End Property
		Private _TransmissSpeedCount? As Global.System.Int16
		Partial Private Sub OnTransmissSpeedCountChanging(ByVal value? As Global.System.Int16)
		End Sub
		Partial Private Sub OnTransmissSpeedCountChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property TransmissAutomatic() As Global.System.String
			Get
				Return _TransmissAutomatic
			End Get
			Set(ByVal value As System.String)
				OnTransmissAutomaticChanging(value)
				ReportPropertyChanging("TransmissAutomatic")
				_TransmissAutomatic = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("TransmissAutomatic")
				OnTransmissAutomaticChanged()
			End Set
		End Property
		Private _TransmissAutomatic As Global.System.String
		Partial Private Sub OnTransmissAutomaticChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnTransmissAutomaticChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property MPG_City() As Global.System.Int16?
			Get
				Return _MPG_City
			End Get
			Set(ByVal value? As System.Int16)
				OnMPG_CityChanging(value)
				ReportPropertyChanging("MPG_City")
				_MPG_City = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("MPG_City")
				OnMPG_CityChanged()
			End Set
		End Property
		Private _MPG_City? As Global.System.Int16
		Partial Private Sub OnMPG_CityChanging(ByVal value? As Global.System.Int16)
		End Sub
		Partial Private Sub OnMPG_CityChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property MPG_Highway() As Global.System.Int16?
			Get
				Return _MPG_Highway
			End Get
			Set(ByVal value? As System.Int16)
				OnMPG_HighwayChanging(value)
				ReportPropertyChanging("MPG_Highway")
				_MPG_Highway = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("MPG_Highway")
				OnMPG_HighwayChanged()
			End Set
		End Property
		Private _MPG_Highway? As Global.System.Int16
		Partial Private Sub OnMPG_HighwayChanging(ByVal value? As Global.System.Int16)
		End Sub
		Partial Private Sub OnMPG_HighwayChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Category() As Global.System.String
			Get
				Return _Category
			End Get
			Set(ByVal value As System.String)
				OnCategoryChanging(value)
				ReportPropertyChanging("Category")
				_Category = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Category")
				OnCategoryChanged()
			End Set
		End Property
		Private _Category As Global.System.String
		Partial Private Sub OnCategoryChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnCategoryChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Description() As Global.System.String
			Get
				Return _Description
			End Get
			Set(ByVal value As System.String)
				OnDescriptionChanging(value)
				ReportPropertyChanging("Description")
				_Description = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Description")
				OnDescriptionChanged()
			End Set
		End Property
		Private _Description As Global.System.String
		Partial Private Sub OnDescriptionChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnDescriptionChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Hyperlink() As Global.System.String
			Get
				Return _Hyperlink
			End Get
			Set(ByVal value As System.String)
				OnHyperlinkChanging(value)
				ReportPropertyChanging("Hyperlink")
				_Hyperlink = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Hyperlink")
				OnHyperlinkChanged()
			End Set
		End Property
		Private _Hyperlink As Global.System.String
		Partial Private Sub OnHyperlinkChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnHyperlinkChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Picture() As Global.System.Byte()
			Get
				Return StructuralObject.GetValidValue(_Picture)
			End Get
			Set(ByVal value As System.Byte())
				OnPictureChanging(value)
				ReportPropertyChanging("Picture")
				_Picture = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Picture")
				OnPictureChanged()
			End Set
		End Property
		Private _Picture() As Global.System.Byte
		Partial Private Sub OnPictureChanging(ByVal value() As Global.System.Byte)
		End Sub
		Partial Private Sub OnPictureChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Price() As Global.System.Decimal?
			Get
				Return _Price
			End Get
			Set(ByVal value? As System.Decimal)
				OnPriceChanging(value)
				ReportPropertyChanging("Price")
				_Price = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("Price")
				OnPriceChanged()
			End Set
		End Property
		Private _Price? As Global.System.Decimal
		Partial Private Sub OnPriceChanging(ByVal value? As Global.System.Decimal)
		End Sub
		Partial Private Sub OnPriceChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property RtfContent() As Global.System.String
			Get
				Return _RtfContent
			End Get
			Set(ByVal value As System.String)
				OnRtfContentChanging(value)
				ReportPropertyChanging("RtfContent")
				_RtfContent = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("RtfContent")
				OnRtfContentChanged()
			End Set
		End Property
		Private _RtfContent As Global.System.String
		Partial Private Sub OnRtfContentChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnRtfContentChanged()
		End Sub

		#End Region


	End Class

	''' <summary>
	''' No Metadata Documentation available.
	''' </summary>
	<EdmEntityTypeAttribute(NamespaceName:="CarsXtraSchedulingModel", Name:="CarScheduling"), Serializable(), DataContractAttribute(IsReference:=True)> _
	Partial Public Class CarScheduling
		Inherits EntityObject
		#Region "Factory Method"

		''' <summary>
		''' Create a new CarScheduling object.
		''' </summary>
		''' <param name="id">Initial value of the ID property.</param>
		''' <param name="label">Initial value of the Label property.</param>
		''' <param name="allDay">Initial value of the AllDay property.</param>
		Public Shared Function CreateCarScheduling(ByVal id As Global.System.Int32, ByVal label As Global.System.Int32, ByVal allDay As Global.System.Boolean) As CarScheduling
			Dim carScheduling As New CarScheduling()
			carScheduling.ID = id
			carScheduling.Label = label
			carScheduling.AllDay = allDay
			Return carScheduling
		End Function

		#End Region

		#Region "Primitive Properties"

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property ID() As Global.System.Int32
			Get
				Return _ID
			End Get
			Set(ByVal value As System.Int32)
				If _ID <> value Then
					OnIDChanging(value)
					ReportPropertyChanging("ID")
					_ID = StructuralObject.SetValidValue(value)
					ReportPropertyChanged("ID")
					OnIDChanged()
				End If
			End Set
		End Property
		Private _ID As Global.System.Int32
		Partial Private Sub OnIDChanging(ByVal value As Global.System.Int32)
		End Sub
		Partial Private Sub OnIDChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property CarId() As Global.System.String
			Get
				Return _CarId
			End Get
			Set(ByVal value As System.String)
				OnCarIdChanging(value)
				ReportPropertyChanging("CarId")
				_CarId = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("CarId")
				OnCarIdChanged()
			End Set
		End Property
		Private _CarId As Global.System.String
		Partial Private Sub OnCarIdChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnCarIdChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property UserId() As Global.System.Int32?
			Get
				Return _UserId
			End Get
			Set(ByVal value? As System.Int32)
				OnUserIdChanging(value)
				ReportPropertyChanging("UserId")
				_UserId = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("UserId")
				OnUserIdChanged()
			End Set
		End Property
		Private _UserId? As Global.System.Int32
		Partial Private Sub OnUserIdChanging(ByVal value? As Global.System.Int32)
		End Sub
		Partial Private Sub OnUserIdChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Status() As Global.System.Int32?
			Get
				Return _Status
			End Get
			Set(ByVal value? As System.Int32)
				OnStatusChanging(value)
				ReportPropertyChanging("Status")
				_Status = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("Status")
				OnStatusChanged()
			End Set
		End Property
		Private _Status? As Global.System.Int32
		Partial Private Sub OnStatusChanging(ByVal value? As Global.System.Int32)
		End Sub
		Partial Private Sub OnStatusChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Subject() As Global.System.String
			Get
				Return _Subject
			End Get
			Set(ByVal value As System.String)
				OnSubjectChanging(value)
				ReportPropertyChanging("Subject")
				_Subject = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Subject")
				OnSubjectChanged()
			End Set
		End Property
		Private _Subject As Global.System.String
		Partial Private Sub OnSubjectChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnSubjectChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Description() As Global.System.String
			Get
				Return _Description
			End Get
			Set(ByVal value As System.String)
				OnDescriptionChanging(value)
				ReportPropertyChanging("Description")
				_Description = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Description")
				OnDescriptionChanged()
			End Set
		End Property
		Private _Description As Global.System.String
		Partial Private Sub OnDescriptionChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnDescriptionChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=False), DataMemberAttribute()> _
		Public Property Label() As Global.System.Int32
			Get
				Return _Label
			End Get
			Set(ByVal value As System.Int32)
				OnLabelChanging(value)
				ReportPropertyChanging("Label")
				_Label = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("Label")
				OnLabelChanged()
			End Set
		End Property
		Private _Label As Global.System.Int32
		Partial Private Sub OnLabelChanging(ByVal value As Global.System.Int32)
		End Sub
		Partial Private Sub OnLabelChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property StartTime() As Global.System.DateTime?
			Get
				Return _StartTime
			End Get
			Set(ByVal value? As System.DateTime)
				OnStartTimeChanging(value)
				ReportPropertyChanging("StartTime")
				_StartTime = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("StartTime")
				OnStartTimeChanged()
			End Set
		End Property
		Private _StartTime? As Global.System.DateTime
		Partial Private Sub OnStartTimeChanging(ByVal value? As Global.System.DateTime)
		End Sub
		Partial Private Sub OnStartTimeChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property EndTime() As Global.System.DateTime?
			Get
				Return _EndTime
			End Get
			Set(ByVal value? As System.DateTime)
				OnEndTimeChanging(value)
				ReportPropertyChanging("EndTime")
				_EndTime = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("EndTime")
				OnEndTimeChanged()
			End Set
		End Property
		Private _EndTime? As Global.System.DateTime
		Partial Private Sub OnEndTimeChanging(ByVal value? As Global.System.DateTime)
		End Sub
		Partial Private Sub OnEndTimeChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Location() As Global.System.String
			Get
				Return _Location
			End Get
			Set(ByVal value As System.String)
				OnLocationChanging(value)
				ReportPropertyChanging("Location")
				_Location = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Location")
				OnLocationChanged()
			End Set
		End Property
		Private _Location As Global.System.String
		Partial Private Sub OnLocationChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnLocationChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=False), DataMemberAttribute()> _
		Public Property AllDay() As Global.System.Boolean
			Get
				Return _AllDay
			End Get
			Set(ByVal value As System.Boolean)
				OnAllDayChanging(value)
				ReportPropertyChanging("AllDay")
				_AllDay = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("AllDay")
				OnAllDayChanged()
			End Set
		End Property
		Private _AllDay As Global.System.Boolean
		Partial Private Sub OnAllDayChanging(ByVal value As Global.System.Boolean)
		End Sub
		Partial Private Sub OnAllDayChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property EventType() As Global.System.Int32?
			Get
				Return _EventType
			End Get
			Set(ByVal value? As System.Int32)
				OnEventTypeChanging(value)
				ReportPropertyChanging("EventType")
				_EventType = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("EventType")
				OnEventTypeChanged()
			End Set
		End Property
		Private _EventType? As Global.System.Int32
		Partial Private Sub OnEventTypeChanging(ByVal value? As Global.System.Int32)
		End Sub
		Partial Private Sub OnEventTypeChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property RecurrenceInfo() As Global.System.String
			Get
				Return _RecurrenceInfo
			End Get
			Set(ByVal value As System.String)
				OnRecurrenceInfoChanging(value)
				ReportPropertyChanging("RecurrenceInfo")
				_RecurrenceInfo = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("RecurrenceInfo")
				OnRecurrenceInfoChanged()
			End Set
		End Property
		Private _RecurrenceInfo As Global.System.String
		Partial Private Sub OnRecurrenceInfoChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnRecurrenceInfoChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ReminderInfo() As Global.System.String
			Get
				Return _ReminderInfo
			End Get
			Set(ByVal value As System.String)
				OnReminderInfoChanging(value)
				ReportPropertyChanging("ReminderInfo")
				_ReminderInfo = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ReminderInfo")
				OnReminderInfoChanged()
			End Set
		End Property
		Private _ReminderInfo As Global.System.String
		Partial Private Sub OnReminderInfoChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnReminderInfoChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Price() As Global.System.Decimal?
			Get
				Return _Price
			End Get
			Set(ByVal value? As System.Decimal)
				OnPriceChanging(value)
				ReportPropertyChanging("Price")
				_Price = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("Price")
				OnPriceChanged()
			End Set
		End Property
		Private _Price? As Global.System.Decimal
		Partial Private Sub OnPriceChanging(ByVal value? As Global.System.Decimal)
		End Sub
		Partial Private Sub OnPriceChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ContactInfo() As Global.System.String
			Get
				Return _ContactInfo
			End Get
			Set(ByVal value As System.String)
				OnContactInfoChanging(value)
				ReportPropertyChanging("ContactInfo")
				_ContactInfo = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ContactInfo")
				OnContactInfoChanged()
			End Set
		End Property
		Private _ContactInfo As Global.System.String
		Partial Private Sub OnContactInfoChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnContactInfoChanged()
		End Sub

		#End Region


	End Class

	#End Region


End Namespace
