﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Practical_UWP.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Practical_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShowContacts : Page
    {
        Database db;
        private ObservableCollection<Contacts> listContact;
        public ShowContacts()
        {
            this.InitializeComponent();
            db = new Database();
            listContact = new ObservableCollection<Contacts>();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //db.list(listContact);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = TxtName.Text;
            string phone = TxtPhone.Text;

            int code = db.Search(name, phone, listContact);
        }
    }
}
