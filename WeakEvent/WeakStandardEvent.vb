'Copied from TMWSystems.Common project in the TmwUtility solution

''' <summary>
''' This class weakly links an event handler to a standard event.
''' </summary>
''' <typeparam name="T">The exact type of the 2nd EventArgs derived parameter.</typeparam>
''' <remarks>
''' Standard events always provide 2 parameters: the sender object, and an EventArgs derived object that provides additional
''' data.  This class allows a handler to be weakly linked to such an event.
''' 
''' This class exists to allow for event handlers to be linked up to events in such a way that they cannot cause
''' memory leaks.  Normally, linking up an event handler with AddHandler creates an implicit reference to the Event Handler's
''' class from the Event Source's class.  This hidden reference means that the event handler class cannot be released until
''' the event source is, or until the event is unbound.  Unfortunately, programmers frequently don't allow for this, and 
''' forget to make a mechanism to unbind event links from events in long-lived objects to handlers in what should have been 
''' short-lived objects.
''' 
''' Use this class instead of the AddHandler statement to cause the event handler to be weakly bound.  This means that
''' the object that handles the event will not be kept alive just because the source of an event is still alive.
''' The class is meant for use when an event is such that a specific target of an event should be weakly bound.
''' It is intended to be activated with code similar to the following:
'''     WeakStandardEvent(Of EventArgs).AddHandler(EventProvidingObject, "EventName", AddressOf MyEventHandler)
''' Then the handler is removed by the corresponding:
'''     WeakStandardEvent(Of EventArgs).RemoveHandler(EventProvidingObject, "EventName", AddressOf MyEventHandler)
''' Like the normal RemoveHandler, the weak removehandler will remove one reference to the specified handler for 
''' the specified event.  Accordingly, if a handler is multiply added, it must be multiply removed.
''' </remarks>
<System.Diagnostics.DebuggerStepThrough()> _
Public Class WeakStandardEvent(Of T As EventArgs)
	''' <summary>
	''' Weakly hooks a public non-shared event up to the specified handler
	''' </summary>
	''' <param name="SourceObject">Object that provides the Event.</param>
	''' <param name="EventName">Public Event's Name.</param>
	''' <param name="Handler">Delegate for event handler.</param>
	Public Shared Sub [AddHandler](ByVal SourceObject As Object, ByVal EventName As String, ByVal Handler As EventHandler(Of T))
		Dim Proxy As New WeakEventProxy(SourceObject, SourceObject.GetType.GetEvent(EventName), Handler)
	End Sub

	''' <summary>
	''' Weakly Hooks a public shared event up to the specified handler
	''' </summary>
	''' <param name="SourceType">Type that provides the Event.</param>
	''' <param name="EventName">Public Event's Name</param>
	''' <param name="Handler">Delegate for event handler.</param>
	Public Shared Sub [AddHandler](ByVal SourceType As Type, ByVal EventName As String, ByVal Handler As EventHandler(Of T))
		Dim Proxy As New WeakEventProxy(SourceType, SourceType.GetEvent(EventName), Handler)
	End Sub

	''' <summary>
	''' Weakly hooks a non-shared event up to the specified handler
	''' </summary>
	''' <param name="SourceObject">Object that provides the Event.</param>
	''' <param name="EventName">Event's Name</param>
	''' <param name="EventBindingInfo">Binding information to identify the access scope at which to resolve the event name.</param>
	''' <param name="Handler">Delegate for event handler.</param>
	Public Shared Sub [AddHandler](ByVal SourceObject As Object, ByVal EventName As String, ByVal EventBindingInfo As System.Reflection.BindingFlags, ByVal Handler As EventHandler(Of T))
		Dim Proxy As New WeakEventProxy(SourceObject, SourceObject.GetType.GetEvent(EventName, EventBindingInfo), Handler)
	End Sub

	''' <summary>
	''' Weakly hooks a shared event up to the specified handler
	''' </summary>
	''' <param name="SourceType">Type that provides the Event.</param>
	''' <param name="EventName">Event's Name</param>
	''' <param name="EventBindingInfo">Binding information to identify the access scope at which to resolve the event name.</param>
	''' <param name="Handler">Delegate for event handler.</param>
	Public Shared Sub [AddHandler](ByVal SourceType As Type, ByVal EventName As String, ByVal EventBindingInfo As System.Reflection.BindingFlags, ByVal Handler As EventHandler(Of T))
		Dim Proxy As New WeakEventProxy(SourceType, SourceType.GetEvent(EventName, EventBindingInfo), Handler)
	End Sub

	''' <summary>
	''' Weakly hooks an event up to a handler
	''' </summary>
	''' <param name="SourceObject">Object that provides the Event.  May be a Type or Nothing if Event is shared.</param>
	''' <param name="EventInfo">Reflection object identifying the event to hook.</param>
	''' <param name="Handler">Delegate of the event handler method.</param>
	Public Shared Sub [AddHandler](ByVal SourceObject As Object, ByVal EventInfo As Reflection.EventInfo, ByVal Handler As EventHandler(Of T))
		Dim Proxy As New WeakEventProxy(SourceObject, EventInfo, Handler)
	End Sub

	''' <summary>
	''' Weakly disconnects a public non-shared event from a handler
	''' </summary>
	''' <param name="SourceObject">Object that provides the Event.</param>
	''' <param name="EventName">Public Event's Name.</param>
	''' <param name="Handler">Delegate for event handler.</param>
	Public Shared Sub [RemoveHandler](ByVal SourceObject As Object, ByVal EventName As String, ByVal Handler As EventHandler(Of T))
		WeakEventProxy.RemoveHandler(SourceObject, SourceObject.GetType.GetEvent(EventName), Handler)
	End Sub

	''' <summary>
	''' Weakly disconnects a public shared event from a handler
	''' </summary>
	''' <param name="SourceType">Type that provides the Event.</param>
	''' <param name="EventName">Public Event's Name</param>
	''' <param name="Handler">Delegate for event handler.</param>
	Public Shared Sub [RemoveHandler](ByVal SourceType As Type, ByVal EventName As String, ByVal Handler As EventHandler(Of T))
		WeakEventProxy.RemoveHandler(SourceType, SourceType.GetEvent(EventName), Handler)
	End Sub

	''' <summary>
	''' Weakly disconnects a non-shared event from a handler
	''' </summary>
	''' <param name="SourceObject">Object that provides the Event.</param>
	''' <param name="EventName">Event's Name</param>
	''' <param name="EventBindingInfo">Binding information to identify the access scope at which to resolve the event name.</param>
	''' <param name="Handler">Delegate for event handler.</param>
	Public Shared Sub [RemoveHandler](ByVal SourceObject As Object, ByVal EventName As String, ByVal EventBindingInfo As System.Reflection.BindingFlags, ByVal Handler As EventHandler(Of T))
		WeakEventProxy.RemoveHandler(SourceObject, SourceObject.GetType.GetEvent(EventName, EventBindingInfo), Handler)
	End Sub

	''' <summary>
	''' Weakly disconnects a shared event from a handler
	''' </summary>
	''' <param name="SourceType">Type that provides the Event.</param>
	''' <param name="EventName">Event's Name</param>
	''' <param name="EventBindingInfo">Binding information to identify the access scope at which to resolve the event name.</param>
	''' <param name="Handler">Delegate for event handler.</param>
	Public Shared Sub [RemoveHandler](ByVal SourceType As Type, ByVal EventName As String, ByVal EventBindingInfo As System.Reflection.BindingFlags, ByVal Handler As EventHandler(Of T))
		WeakEventProxy.RemoveHandler(SourceType, SourceType.GetEvent(EventName, EventBindingInfo), Handler)
	End Sub

	''' <summary>
	''' Weakly disconnects an event from a handler
	''' </summary>
	''' <param name="SourceObject">Object that provides the Event.  May be a Type or Nothing if Event is shared.</param>
	''' <param name="EventInfo">Reflection object identifying the event to hook.</param>
	''' <param name="Handler">Delegate of the event handler method.</param>
	Public Shared Sub [RemoveHandler](ByVal SourceObject As Object, ByVal EventInfo As Reflection.EventInfo, ByVal Handler As EventHandler(Of T))
		WeakEventProxy.RemoveHandler(SourceObject, EventInfo, Handler)
	End Sub

	Private Shared ChangingActiveList As New System.Threading.Mutex
	Private Shared ActiveWeakEventProxies As New List(Of WeakReference)
	Private Shared _lastProxyCleanup As DateTime = Now

	<System.Diagnostics.DebuggerStepThrough()> _
	Private Class WeakEventProxy
		Private MyTarget As WeakReference
		Private SharedHandler As Boolean
		Private HandlerInfo As Reflection.MethodInfo
		Private SourceObject As Object
		Private EventInfo As Reflection.EventInfo
		Private MyDelegate As System.Delegate

		Public Sub New(ByVal SourceObject As Object, ByVal EventInfo As Reflection.EventInfo, ByVal Handler As EventHandler(Of T))
			ChangingActiveList.WaitOne()
			Try
				If TypeOf SourceObject Is Type Then SourceObject = Nothing
				Dim HandlerObject As Object = Handler.Target
				If TypeOf HandlerObject Is Type Then HandlerObject = Nothing
				SharedHandler = (HandlerObject Is Nothing)
				If Not SharedHandler Then MyTarget = New WeakReference(HandlerObject)
				Me.HandlerInfo = Handler.Method
				Me.SourceObject = SourceObject
				Me.EventInfo = EventInfo
				MyDelegate = System.Delegate.CreateDelegate(EventInfo.EventHandlerType, Me, "OnRaiseEvent")
				EventInfo.AddEventHandler(SourceObject, MyDelegate)
				ActiveWeakEventProxies.Add(New WeakReference(Me))
				If (Now - _lastProxyCleanup).TotalSeconds > 30 Then
					_lastProxyCleanup = Now
					Dim KillProxies As New List(Of WeakReference)
					For Each TestRef As WeakReference In ActiveWeakEventProxies
						Dim Proxy As WeakEventProxy = TryCast(TestRef.Target, WeakEventProxy)
						If Proxy Is Nothing OrElse Proxy.IsDead Then KillProxies.Add(TestRef)
					Next
					For Each KillRef As WeakReference In KillProxies
						Dim Proxy As WeakEventProxy = TryCast(KillRef.Target, WeakEventProxy)
						If Proxy IsNot Nothing Then Proxy.Unbind()
						ActiveWeakEventProxies.Remove(KillRef)
					Next
				End If
			Finally
				ChangingActiveList.ReleaseMutex()
			End Try
		End Sub

		Private Sub OnRaiseEvent(ByVal Parm1 As Object, ByVal Parm2 As T)
			Dim StrongTarget As Object = Nothing
			If Not SharedHandler Then StrongTarget = MyTarget.Target
			If StrongTarget Is Nothing AndAlso Not SharedHandler Then
				Me.Unbind()
				ReleasingProxy(Me)
				Exit Sub
			End If
			Dim a As System.Delegate = System.Delegate.CreateDelegate(GetType(EventHandler(Of T)), StrongTarget, HandlerInfo)
			Dim Parms(1) As Object
			Parms(0) = Parm1
			Parms(1) = Parm2
			HandlerInfo.Invoke(StrongTarget, Parms)
		End Sub

		Public Sub Unbind()
			EventInfo.RemoveEventHandler(SourceObject, MyDelegate)
		End Sub

		Public Function IsDead() As Boolean
			Return (Not SharedHandler) AndAlso (Not MyTarget.IsAlive)
		End Function

		''' <summary>
		''' Determines if this proxy is dead or is for the specified event link.
		''' </summary>
		''' <param name="SourceObject"></param>
		''' <param name="EventInfo"></param>
		''' <param name="Handler"></param>
		''' <returns></returns>
		''' <remarks></remarks>
		Public Function IsDeadOrMatch(ByVal SourceObject As Object, ByVal EventInfo As Reflection.EventInfo, ByVal Handler As EventHandler(Of T)) As Boolean
			Return IsDeadOrMatch(SourceObject, EventInfo, Handler, False)
		End Function

		Public Function IsDeadOrMatch(ByVal SourceObject As Object, ByVal EventInfo As Reflection.EventInfo, ByVal Handler As EventHandler(Of T), ByRef WasDead As Boolean) As Boolean
			WasDead = False
			If TypeOf SourceObject Is Type Then SourceObject = Nothing
			If SourceObject Is Me.SourceObject Then
				If EventInfo Is Me.EventInfo Then
					Dim StrongTarget As Object = Nothing
					If Not SharedHandler Then StrongTarget = MyTarget.Target
					If StrongTarget Is Nothing Then
						If Not SharedHandler Then WasDead = True : Return True 'Target is dead.
						If Handler.Method Is Me.HandlerInfo Then WasDead = False : Return True
					Else
						If Handler.Target Is StrongTarget AndAlso Handler.Method Is Me.HandlerInfo Then
							WasDead = False
							Return True
						Else
							Return False
						End If
					End If
				End If
			End If
			Return False
		End Function

		Public Shared Sub [RemoveHandler](ByVal SourceObject As Object, ByVal EventInfo As Reflection.EventInfo, ByVal Handler As EventHandler(Of T))
			ChangingActiveList.WaitOne()
			Try
				Dim KillList As New List(Of WeakReference)
				Dim WasDead As Boolean = False
				For Each TestReference As WeakReference In ActiveWeakEventProxies
					Dim TargetProxy As WeakEventProxy = DirectCast(TestReference.Target, WeakEventProxy)
					If TargetProxy Is Nothing Then
						KillList.Add(TestReference)
					ElseIf TargetProxy.IsDeadOrMatch(SourceObject, EventInfo, Handler, WasDead) Then
						TargetProxy.Unbind()
						KillList.Add(TestReference)
						If Not WasDead Then Exit For
					End If
				Next
				For Each KillReference As WeakReference In KillList
					ActiveWeakEventProxies.Remove(KillReference)
				Next
			Finally
				ChangingActiveList.ReleaseMutex()
			End Try
		End Sub

		Private Shared Sub ReleasingProxy(ByVal Proxy As WeakEventProxy)
			ChangingActiveList.WaitOne()
			Try
				Dim KillList As New List(Of WeakReference)
				For Each TestReference As WeakReference In ActiveWeakEventProxies
					Dim TargetProxy As WeakEventProxy = DirectCast(TestReference.Target, WeakEventProxy)
					If TargetProxy Is Nothing OrElse TargetProxy Is Proxy Then KillList.Add(TestReference)
				Next
				For Each KillReference As WeakReference In KillList
					ActiveWeakEventProxies.Remove(KillReference)
				Next
			Finally
				ChangingActiveList.ReleaseMutex()
			End Try
		End Sub
	End Class
End Class
