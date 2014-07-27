using Delivery.Core.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class ShoppingCartControl : UserControl
    {
        public ObservableCollection<CustomizationGroup> Groups
        {
            get
            {
                return (ObservableCollection<CustomizationGroup>)GetValue(GroupsDependencyProperty);
            }
            set
            {
                SetValue(GroupsDependencyProperty, value);
            }
        }
        public readonly DependencyProperty GroupsDependencyProperty =
            DependencyProperty.RegisterAttached("Groups", typeof(ObservableCollection<CustomizationGroup>), typeof(ShoppingCartControl), new PropertyMetadata(null, delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
            {
                (d as ShoppingCartControl).gvCart.ItemsSource = (ObservableCollection<CustomizationGroup>)e.NewValue;
            }));

        public ShoppingCartControl()
        {
            this.InitializeComponent();
        }
    }
}
