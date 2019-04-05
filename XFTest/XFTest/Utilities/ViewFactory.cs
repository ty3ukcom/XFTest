﻿using CommonServiceLocator;
using Xamarin.Forms;

namespace XFTest.Utilities
{
    internal static class ViewFactory
    {
        internal static Page GetView(string viewName)
        {
            return ServiceLocator.Current.GetInstance<Page>(viewName);
        }

        internal static TView GetView<TView>() where TView : ContentPage
        {
            return ServiceLocator.Current.GetInstance<TView>();
        }
    }
}
