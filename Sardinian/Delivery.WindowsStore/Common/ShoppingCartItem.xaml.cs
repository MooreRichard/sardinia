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
    public sealed partial class ShoppingCartItem : UserControl
    {

        public string SectionName
        {
            get
            {
                return (string)GetValue(SectionNameDependencyProperty);
            }
            set
            {
                SetValue(SectionNameDependencyProperty, value);
            }
        }
        public readonly DependencyProperty SectionNameDependencyProperty =
            DependencyProperty.RegisterAttached("SectionName", typeof(string), typeof(ShoppingCartItem), new PropertyMetadata(null, delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
            {
                (d as ShoppingCartItem).tbSectionName.Text = (string)e.NewValue;
            }));

        public ObservableCollection<Options> Options
        {
            get
            {
                return (ObservableCollection<Options>)GetValue(OptionsDependencyProperty);
            }
            set
            {
                SetValue(OptionsDependencyProperty, value);
            }
        }

        public readonly DependencyProperty OptionsDependencyProperty =
            DependencyProperty.RegisterAttached("Options", typeof(ObservableCollection<Options>), typeof(ShoppingCartItem), new PropertyMetadata(null, delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
            {
                (d as ShoppingCartItem).lvOptions.ItemsSource = (ObservableCollection<Options>)e.NewValue;
            }));

        public ShoppingCartItem()
        {
            this.InitializeComponent();
        }
    }
}
