﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18326
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace TestResources.SymbolsTests
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Public Class V2
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("V2", GetType(V2).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Public Shared ReadOnly Property MTTestLib1() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("MTTestLib1", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;vbc /t:library /out:MTTestLib1.Dll MTTestLib1_V2.vb 
        '''&apos;vbc /t:module /out:MTTestModule1.netmodule MTTestLib1_V2.vb
        '''
        '''&lt;Assembly: System.Reflection.AssemblyVersion(&quot;2.0.0.0&quot;)&gt; 
        '''&lt;Assembly: System.Reflection.AssemblyFileVersion(&quot;2.0.0.0&quot;)&gt; 
        '''
        '''Public Class Class1
        '''
        '''End Class
        '''
        '''Public Class Class2
        '''
        '''End Class
        '''
        '''Public Delegate Sub Delegate1()
        '''
        '''Public Interface Interface1
        '''    Sub Method1() &apos; same as V1
        '''    &apos; Sub Method2() &apos; removed since V1
        '''    Sub Method3(x As Integer) &apos; different param type in V2
        '''  [rest of string was truncated]&quot;;.
        '''</summary>
        Public Shared ReadOnly Property MTTestLib1_V2() As String
            Get
                Return ResourceManager.GetString("MTTestLib1_V2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Public Shared ReadOnly Property MTTestLib3() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("MTTestLib3", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos; vbc /t:Library /out:MTTestLib3.Dll MTTestLib3_V2.vb /r:MTTestLib1.Dll /r:..\V1\MTTestLib2.Dll
        '''&apos; vbc /t:module /out:MTTestModule3.netmodule MTTestLib3_V2.vb /r:MTTestLib1.Dll /r:..\V1\MTTestLib2.Dll
        '''
        '''Public Class Class5
        '''    Function Foo1() As Class1
        '''        Return Nothing
        '''    End Function
        '''
        '''    Function Foo2() As Class2
        '''        Return Nothing
        '''    End Function
        '''
        '''    Function Foo3() As Class4
        '''        Return Nothing
        '''    End Function
        '''
        '''    Public Bar1 As Class1
        '''    Public Bar2 As Class2
        '''    Publ [rest of string was truncated]&quot;;.
        '''</summary>
        Public Shared ReadOnly Property MTTestLib3_V2() As String
            Get
                Return ResourceManager.GetString("MTTestLib3_V2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Public Shared ReadOnly Property MTTestModule1() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("MTTestModule1", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Public Shared ReadOnly Property MTTestModule3() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("MTTestModule3", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
    End Class
End Namespace
