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
    public sealed partial class MerchantMenuSectionControl : UserControl
    {
        public string MerchantMenuSectionTitle
        {
            get
            {
                return this.GetValue(MerchantMenuSectionItemsProperty) as string;
            }
            set
            {
                this.SetValue(MerchantMenuSectionItemsProperty, value);
            }
        }

        public static readonly DependencyProperty MerchantMenuSectionTitleProperty = DependencyProperty.RegisterAttached("MerchantMenuSectionTitle", typeof(string),
            typeof(MerchantMenuSectionControl), new PropertyMetadata("", delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
            {
                (d as MerchantMenuSectionControl).MerchantMenuSectionTitle = e.NewValue as string;

                System.Diagnostics.Debug.WriteLine("Hit this too.");
            }));

        public Child2[] MerchantMenuSectionItems
        {
            get
            {
                return this.GetValue(MerchantMenuSectionItemsProperty) as Child2[];
            }
            set
            {
                this.SetValue(MerchantMenuSectionItemsProperty, value);
            }
        }

        public static readonly DependencyProperty MerchantMenuSectionItemsProperty = DependencyProperty.RegisterAttached("MerchantMenuSectionItems", typeof(Child2[]),
            typeof(MerchantMenuSectionControl), new PropertyMetadata(null, delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
                {
                    (d as MerchantMenuSectionControl).MerchantMenuSectionItems = e.NewValue as Child2[];
                    System.Diagnostics.Debug.WriteLine("Hit this.");
                }));

        public MerchantMenuSectionControl()
        {
            this.InitializeComponent();
        }
    }
}
