﻿#pragma checksum "..\..\..\..\..\..\..\MVVM\View\DialogWindows\AddWindows\AddFlashcardWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0274070F549CF83794159F25CB870A840984AEC2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Flashcards.MVVM.View.DialogWindows.AddWindows {
    
    
    /// <summary>
    /// AddFlashcardWindow
    /// </summary>
    public partial class AddFlashcardWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\..\..\..\MVVM\View\DialogWindows\AddWindows\AddFlashcardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label title;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\..\..\MVVM\View\DialogWindows\AddWindows\AddFlashcardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FiszkaPL;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\..\..\..\MVVM\View\DialogWindows\AddWindows\AddFlashcardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label error1;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\..\..\MVVM\View\DialogWindows\AddWindows\AddFlashcardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FiszkaENG;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\..\..\..\MVVM\View\DialogWindows\AddWindows\AddFlashcardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label error2;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\..\..\..\MVVM\View\DialogWindows\AddWindows\AddFlashcardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Flashcards;V1.0.0.0;component/mvvm/view/dialogwindows/addwindows/addflashcardwin" +
                    "dow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\MVVM\View\DialogWindows\AddWindows\AddFlashcardWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.title = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.FiszkaPL = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.error1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.FiszkaENG = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.error2 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.saveButton = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\..\..\..\..\MVVM\View\DialogWindows\AddWindows\AddFlashcardWindow.xaml"
            this.saveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 120 "..\..\..\..\..\..\..\MVVM\View\DialogWindows\AddWindows\AddFlashcardWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

