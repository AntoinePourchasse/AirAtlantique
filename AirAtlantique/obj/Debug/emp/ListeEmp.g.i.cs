﻿#pragma checksum "..\..\..\emp\ListeEmp.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8CD7BC5373612858E3CFCC1BC689654A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using AirAtlantique.emp;
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


namespace AirAtlantique.emp {
    
    
    /// <summary>
    /// ListeEmp
    /// </summary>
    public partial class ListeEmp : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\emp\ListeEmp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listEmp;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\emp\ListeEmp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock listemp;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\emp\ListeEmp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button creation;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\emp\ListeEmp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Supprimer;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\emp\ListeEmp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Retour;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\emp\ListeEmp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Nom;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\emp\ListeEmp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nom;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\emp\ListeEmp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Prenom;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\emp\ListeEmp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock prenom;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\emp\ListeEmp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Metier;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\emp\ListeEmp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock metier;
        
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
            System.Uri resourceLocater = new System.Uri("/AirAtlantique;component/emp/listeemp.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\emp\ListeEmp.xaml"
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
            this.listEmp = ((System.Windows.Controls.ListBox)(target));
            
            #line 13 "..\..\..\emp\ListeEmp.xaml"
            this.listEmp.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listEmp_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listemp = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.creation = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\emp\ListeEmp.xaml"
            this.creation.Click += new System.Windows.RoutedEventHandler(this.creation_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Supprimer = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\emp\ListeEmp.xaml"
            this.Supprimer.Click += new System.Windows.RoutedEventHandler(this.Supprimer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Retour = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\emp\ListeEmp.xaml"
            this.Retour.Click += new System.Windows.RoutedEventHandler(this.Retour_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Nom = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.nom = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Prenom = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.prenom = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.Metier = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.metier = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
