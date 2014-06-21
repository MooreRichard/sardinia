using Delivery.Core.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Delivery.WindowsStore.Common
{
    public sealed partial class MerchantMenuControl : UserControl
    {
        public string MerchantMenuTitle
        {
            get
            {
                return this.GetValue(MerchantMenuTitleProperty) as string;
            }
            set
            {
                this.SetValue(MerchantMenuTitleProperty, value);
            }
        }

        public static readonly DependencyProperty MerchantMenuTitleProperty = DependencyProperty.RegisterAttached("MerchantMenuTitle", typeof(string),
            typeof(MerchantMenuControl), new PropertyMetadata("", delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
            {
                (d as MerchantMenuControl).MerchantMenuTitle = e.NewValue as string;

                System.Diagnostics.Debug.WriteLine("Hit this too.");
            }));

        public Child[] MerchantMenuItems
        {
            get
            {
                return this.GetValue(MerchantMenuItemsProperty) as Child[];
            }
            set
            {
                this.SetValue(MerchantMenuItemsProperty, value);
            }
        }

        public static readonly DependencyProperty MerchantMenuItemsProperty = DependencyProperty.RegisterAttached("MerchantMenuItems", typeof(Child[]),
            typeof(MerchantMenuControl), new PropertyMetadata(null, delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
            {
                (d as MerchantMenuControl).MerchantMenuItems = e.NewValue as Child[];
                System.Diagnostics.Debug.WriteLine("Hit this.");
            }));

        public MerchantMenuControl()
        {
            this.InitializeComponent();
        }
    }
}
