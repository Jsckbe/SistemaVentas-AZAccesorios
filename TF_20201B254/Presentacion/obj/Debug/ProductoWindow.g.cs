﻿#pragma checksum "..\..\ProductoWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "27453D64C715080E968B45E1C3C56C880599E20D933841DED5C7AF0A1DDB866E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Presentacion;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Presentacion {
    
    
    /// <summary>
    /// ProductoWindow
    /// </summary>
    public partial class ProductoWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\ProductoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCodigo;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ProductoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegistrar;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ProductoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ProductoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ProductoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ProductoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgProductos;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ProductoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNombre;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ProductoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPrecio;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ProductoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbProveedor;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ProductoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbEmpleado;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ProductoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProdxCod;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ProductoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMostrarProductos;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Presentacion;component/productowindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProductoWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbCodigo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnRegistrar = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\ProductoWindow.xaml"
            this.btnRegistrar.Click += new System.Windows.RoutedEventHandler(this.btnRegistrar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnModificar = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\ProductoWindow.xaml"
            this.btnModificar.Click += new System.Windows.RoutedEventHandler(this.btnModificar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\ProductoWindow.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\ProductoWindow.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgProductos = ((System.Windows.Controls.DataGrid)(target));
            
            #line 22 "..\..\ProductoWindow.xaml"
            this.dgProductos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgProductos_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tbNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbPrecio = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.cbProveedor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.cbEmpleado = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.btnProdxCod = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\ProductoWindow.xaml"
            this.btnProdxCod.Click += new System.Windows.RoutedEventHandler(this.btnProdxCod_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnMostrarProductos = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\ProductoWindow.xaml"
            this.btnMostrarProductos.Click += new System.Windows.RoutedEventHandler(this.btnMostrarProductos_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

