﻿using System;
using Xamarin.Forms;


namespace MotiveMe
{
    public partial class MSPage : MasterDetailPage
    {
        public MSPage()
        {
            InitializeComponent();
            //masterPage.listView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
               // masterPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}