using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UnoPrism410.Commons
{
    public partial class ViewModelResource : FrameworkElement
    {
        public object ViewModel
        {
            get => GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        // Using a DependencyProperty as the backing store for ViewModel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(object), typeof(ViewModelResource), new PropertyMetadata(null, ViewModelChanged));

        private static void ViewModelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //var resource = (ViewModelResource)d;
            //resource.ViewModel = e.NewValue;
        }
    }
}
