﻿#pragma checksum "..\..\DetallexFacturaWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DE5A6B93FBFC371EF13F2C9C6F725B725FE5F7ECF19718D9D9705DA1846CA93F"
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
    /// DetallexFacturaWindow
    /// </summary>
    public partial class DetallexFacturaWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\DetallexFacturaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCantidad;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\DetallexFacturaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAsignar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\DetallexFacturaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\DetallexFacturaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgDetallexFacturas;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\DetallexFacturaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFactura;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\DetallexFacturaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbProducto;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\DetallexFacturaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPrecio;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\DetallexFacturaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbImporte;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\DetallexFacturaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMontoTotal;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentacion;component/detallexfacturawindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DetallexFacturaWindow.xaml"
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
            this.tbCantidad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnAsignar = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\DetallexFacturaWindow.xaml"
            this.btnAsignar.Click += new System.Windows.RoutedEventHandler(this.btnAsignar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\DetallexFacturaWindow.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgDetallexFacturas = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.cbFactura = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cbProducto = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.tbPrecio = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbImporte = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbMontoTotal = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
