﻿#pragma checksum "..\..\AdministracionCliente.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "140D1E53C6F3389A1C2C7FE11E7506AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using BibliotecaVista;
using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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


namespace BibliotecaVista {
    
    
    /// <summary>
    /// AdministracionCliente
    /// </summary>
    public partial class AdministracionCliente : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\AdministracionCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AdministracionCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnActualizar;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AdministracionCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnListar;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AdministracionCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AdministracionCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBuscarCli;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AdministracionCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgAdmCli;
        
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
            System.Uri resourceLocater = new System.Uri("/BibliotecaVista;component/administracioncliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdministracionCliente.xaml"
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
            
            #line 11 "..\..\AdministracionCliente.xaml"
            ((MahApps.Metro.Controls.Tile)(target)).Click += new System.Windows.RoutedEventHandler(this.Tile_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.btnActualizar = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btnListar = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btnBuscar = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.txtBuscarCli = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.dtgAdmCli = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            
            #line 22 "..\..\AdministracionCliente.xaml"
            ((MahApps.Metro.Controls.Tile)(target)).Click += new System.Windows.RoutedEventHandler(this.Tile_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

