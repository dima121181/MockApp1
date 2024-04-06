using MockApp1.ViewModels;
using MockApp1.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MockApp1 {
    public partial class AppShell : Xamarin.Forms.Shell {
        public AppShell() {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
