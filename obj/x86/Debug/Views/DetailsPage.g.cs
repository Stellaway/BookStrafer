﻿#pragma checksum "D:\OneDrive2\OneDrive\Dokumentumok\egyetem\vi_felev\klitech\last\XAML MVVM start\XAML 2 start\Cookbook\Cookbook\Views\DetailsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3619D0CB912EBE70359C3EA9F467C00CE1B15440417E3D72646DB6BFEBE1BDEF"
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
    partial class DetailsPage : 
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
            case 2: // Views\DetailsPage.xaml line 17
                {
                    this.ViewModel = (global::Cookbook.ViewModels.DetailsPageViewModel)(target);
                }
                break;
            case 3: // Views\DetailsPage.xaml line 33
                {
                    this.clickableCover = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.clickableCover).Tapped += this.clickableCover_Tapped;
                }
                break;
            case 4: // Views\DetailsPage.xaml line 36
                {
                    global::Windows.UI.Xaml.Controls.GridView element4 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)element4).ItemClick += this.Author_ItemClick;
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
