﻿#pragma checksum "D:\OneDrive2\OneDrive\Dokumentumok\egyetem\vi_felev\klitech\last\XAML MVVM start\XAML 2 start\Cookbook\Cookbook\Views\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9269414F592CA22CC83786F5D55BA7CA53E44038E94F1BD56F539027B169DE0B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookbook.Views
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MainPage.xaml line 14
                {
                    this.ViewModel = (global::Cookbook.ViewModels.MainPageViewModel)(target);
                }
                break;
            case 3: // Views\MainPage.xaml line 26
                {
                    this.txtSearch = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtSearch).KeyDown += this.txtSearch_KeyDown;
                }
                break;
            case 4: // Views\MainPage.xaml line 27
                {
                    this.btnSearch = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSearch).Click += this.btnSearch_Click;
                }
                break;
            case 5: // Views\MainPage.xaml line 22
                {
                    this.txtHelloText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Views\MainPage.xaml line 23
                {
                    this.txtBeOurGuestText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

