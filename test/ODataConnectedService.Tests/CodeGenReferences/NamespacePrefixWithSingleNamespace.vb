'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


'Generation date: 10.03.2021 20:08:25
Namespace NamespacePrefixWithSingleNamespace
    ''' <summary>
    ''' There are no comments for MyContainer in the schema.
    ''' </summary>
    Partial Public Class MyContainer
        Inherits Global.Microsoft.OData.Client.DataServiceContext
        ''' <summary>
        ''' Initialize a new MyContainer object.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        Public Sub New(ByVal serviceRoot As Global.System.Uri)
            Me.New(serviceRoot, Global.Microsoft.OData.Client.ODataProtocolVersion.V4)
        End Sub
        ''' <summary>
        ''' Initialize a new MyContainer object.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        Public Sub New(ByVal serviceRoot As Global.System.Uri, ByVal protocolVersion As Global.Microsoft.OData.Client.ODataProtocolVersion)
            MyBase.New(serviceRoot, protocolVersion)
            Me.ResolveName = AddressOf Me.ResolveNameFromType
            Me.ResolveType = AddressOf Me.ResolveTypeFromName
            Me.OnContextCreated
            Me.Format.LoadServiceModel = AddressOf GeneratedEdmModel.GetInstance
            Me.Format.UseJson()
        End Sub
        Partial Private Sub OnContextCreated()
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        Private Shared ROOTNAMESPACE As String = GetType(MyContainer).Namespace.Remove(GetType(MyContainer).Namespace.LastIndexOf("NamespacePrefixWithSingleNamespace"))
        ''' <summary>
        ''' Since the namespace configured for this service reference
        ''' in Visual Studio is different from the one indicated in the
        ''' server schema, use type-mappers to map between the two.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        Protected Function ResolveTypeFromName(ByVal typeName As String) As Global.System.Type
            Dim resolvedType As Global.System.Type = Me.DefaultResolveType(typeName, "NamespacePrefixWithSingleNamespace", String.Concat(ROOTNAMESPACE, "NamespacePrefixWithSingleNamespace"))
            If (Not (resolvedType) Is Nothing) Then
                Return resolvedType
            End If
            Return Nothing
        End Function
        ''' <summary>
        ''' Since the namespace configured for this service reference
        ''' in Visual Studio is different from the one indicated in the
        ''' server schema, use type-mappers to map between the two.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        Protected Function ResolveNameFromType(ByVal clientType As Global.System.Type) As String
            If clientType.Namespace.Equals(String.Concat(ROOTNAMESPACE, "NamespacePrefixWithSingleNamespace"), Global.System.StringComparison.OrdinalIgnoreCase) Then
                Return String.Concat("NamespacePrefixWithSingleNamespace.", clientType.Name)
            End If
            Return Nothing
        End Function
        ''' <summary>
        ''' There are no comments for Items in the schema.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        Public Overridable ReadOnly Property Items() As Global.Microsoft.OData.Client.DataServiceQuery(Of TestType)
            Get
                If (Me._Items Is Nothing) Then
                    Me._Items = MyBase.CreateQuery(Of TestType)("Items")
                End If
                Return Me._Items
            End Get
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        Private _Items As Global.Microsoft.OData.Client.DataServiceQuery(Of TestType)
        ''' <summary>
        ''' There are no comments for Items in the schema.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        Public Overridable Sub AddToItems(ByVal testType As TestType)
            MyBase.AddObject("Items", testType)
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        Private MustInherit Class GeneratedEdmModel
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
            Private Shared ParsedModel As Global.Microsoft.OData.Edm.IEdmModel = LoadModelFromString
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
            Private Const Edmx As String = "<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">" & _
 "  <edmx:DataServices>" & _
 "    <Schema Namespace=""NamespacePrefixWithSingleNamespace"" xmlns:d=""http://docs.oasis-open.org/odata/ns/data"" xmlns:m=""http://docs.oasis-open.org/odata/ns/metadata"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">" & _
 "      <EntityContainer Name=""MyContainer"">" & _
 "        <EntitySet Name=""Items"" EntityType=""NamespacePrefixWithSingleNamespace.TestType"" />" & _
 "      </EntityContainer>" & _
 "      <EntityType Name=""TestType"">" & _
 "        <Key>" & _
 "          <PropertyRef Name=""KeyProp"" />" & _
 "        </Key>" & _
 "        <Property Name=""KeyProp"" Type=""Edm.Int32"" Nullable=""false"" />" & _
 "        <Property Name=""ValueProp"" Type=""Edm.String"" Nullable=""false"" />" & _
 "      </EntityType>" & _
 "    </Schema>" & _
 "  </edmx:DataServices>" & _
 "</edmx:Edmx>"
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
            Public Shared Function GetInstance() As Global.Microsoft.OData.Edm.IEdmModel
                Return ParsedModel
            End Function
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
            Private Shared Function LoadModelFromString() As Global.Microsoft.OData.Edm.IEdmModel
                Dim reader As Global.System.Xml.XmlReader = CreateXmlReader(Edmx)
                Try
                    Dim errors As Global.System.Collections.Generic.IEnumerable(Of Global.Microsoft.OData.Edm.Validation.EdmError) = Nothing
                    Dim edmModel As Global.Microsoft.OData.Edm.IEdmModel = Nothing
                    If Not Global.Microsoft.OData.Edm.Csdl.CsdlReader.TryParse(reader, False, edmModel, errors) Then
                        Dim errorMessages As Global.System.Text.StringBuilder = New Global.System.Text.StringBuilder()
                        For Each err As Global.Microsoft.OData.Edm.Validation.EdmError In errors
                            errorMessages.Append(err.ErrorMessage)
                            errorMessages.Append("; ")
                        Next
                        Throw New Global.System.InvalidOperationException(errorMessages.ToString())
                    End If

                    Return edmModel
                Finally
                    CType(reader, Global.System.IDisposable).Dispose()
                End Try
            End Function
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
            Private Shared Function CreateXmlReader(ByVal edmxToParse As String) As Global.System.Xml.XmlReader
                Return Global.System.Xml.XmlReader.Create(New Global.System.IO.StringReader(edmxToParse))
            End Function
        End Class
    End Class
    ''' <summary>
    ''' There are no comments for TestTypeSingle in the schema.
    ''' </summary>
    Partial Public Class TestTypeSingle
        Inherits Global.Microsoft.OData.Client.DataServiceQuerySingle(Of TestType)
        ''' <summary>
        ''' Initialize a new TestTypeSingle object.
        ''' </summary>
        Public Sub New(ByVal context As Global.Microsoft.OData.Client.DataServiceContext, ByVal path As String)
            MyBase.New(context, path)
        End Sub

        ''' <summary>
        ''' Initialize a new TestTypeSingle object.
        ''' </summary>
        Public Sub New(ByVal context As Global.Microsoft.OData.Client.DataServiceContext, ByVal path As String, ByVal isComposable As Boolean)
            MyBase.New(context, path, isComposable)
        End Sub

        ''' <summary>
        ''' Initialize a new TestTypeSingle object.
        ''' </summary>
        Public Sub New(ByVal query As Global.Microsoft.OData.Client.DataServiceQuerySingle(Of TestType))
            MyBase.New(query)
        End Sub
    End Class
    ''' <summary>
    ''' There are no comments for TestType in the schema.
    ''' </summary>
    ''' <KeyProperties>
    ''' KeyProp
    ''' </KeyProperties>
    <Global.Microsoft.OData.Client.Key("KeyProp")>  _
    Partial Public Class TestType
        Inherits Global.Microsoft.OData.Client.BaseEntityType
        ''' <summary>
        ''' Create a new TestType object.
        ''' </summary>
        ''' <param name="keyProp">Initial value of KeyProp.</param>
        ''' <param name="valueProp">Initial value of ValueProp.</param>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        Public Shared Function CreateTestType(ByVal keyProp As Integer, ByVal valueProp As String) As TestType
            Dim testType As TestType = New TestType()
            testType.KeyProp = keyProp
            testType.ValueProp = valueProp
            Return testType
        End Function
        ''' <summary>
        ''' There are no comments for Property KeyProp in the schema.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        <Global.System.ComponentModel.DataAnnotations.RequiredAttribute()>  _
        Public Overridable Property KeyProp() As Integer
            Get
                Return Me._KeyProp
            End Get
            Set
                Me.OnKeyPropChanging(value)
                Me._KeyProp = value
                Me.OnKeyPropChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        Private _KeyProp As Integer
        Partial Private Sub OnKeyPropChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnKeyPropChanged()
        End Sub
        ''' <summary>
        ''' There are no comments for Property ValueProp in the schema.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        <Global.System.ComponentModel.DataAnnotations.RequiredAttribute()>  _
        Public Overridable Property ValueProp() As String
            Get
                Return Me._ValueProp
            End Get
            Set
                Me.OnValuePropChanging(value)
                Me._ValueProp = value
                Me.OnValuePropChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")>  _
        Private _ValueProp As String
        Partial Private Sub OnValuePropChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnValuePropChanged()
        End Sub
    End Class
    ''' <summary>
    ''' Class containing all extension methods
    ''' </summary>
    Public Module ExtensionMethods
        ''' <summary>
        ''' Get an entity of type NamespacePrefixWithSingleNamespace.TestType as NamespacePrefixWithSingleNamespace.TestTypeSingle specified by key from an entity set
        ''' </summary>
        ''' <param name="_source">source entity set</param>
        ''' <param name="_keys">dictionary with the names and values of keys</param>
        <Global.System.Runtime.CompilerServices.Extension()>
        Public Function ByKey(ByVal _source As Global.Microsoft.OData.Client.DataServiceQuery(Of NamespacePrefixWithSingleNamespace.TestType), ByVal _keys As Global.System.Collections.Generic.IDictionary(Of String, Object)) As NamespacePrefixWithSingleNamespace.TestTypeSingle
            Return New NamespacePrefixWithSingleNamespace.TestTypeSingle(_source.Context, _source.GetKeyPath(Global.Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)))
        End Function
        ''' <summary>
        ''' Get an entity of type NamespacePrefixWithSingleNamespace.TestType as NamespacePrefixWithSingleNamespace.TestTypeSingle specified by key from an entity set
        ''' </summary>
        ''' <param name="_source">source entity set</param>
        ''' <param name="keyProp">The value of keyProp</param>
        <Global.System.Runtime.CompilerServices.Extension()>
        Public Function ByKey(ByVal _source As Global.Microsoft.OData.Client.DataServiceQuery(Of NamespacePrefixWithSingleNamespace.TestType),
            keyProp As Integer) As NamespacePrefixWithSingleNamespace.TestTypeSingle
            Dim _keys As Global.System.Collections.Generic.IDictionary(Of String, Object) = New Global.System.Collections.Generic.Dictionary(Of String, Object)() From
            {
                { "KeyProp", keyProp }
            }
            Return New NamespacePrefixWithSingleNamespace.TestTypeSingle(_source.Context, _source.GetKeyPath(Global.Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)))
        End Function
    End Module
End Namespace
