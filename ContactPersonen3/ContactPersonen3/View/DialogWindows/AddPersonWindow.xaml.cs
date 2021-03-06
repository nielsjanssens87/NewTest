﻿using ContactPersonen3.Data;
using ContactPersonen3.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ContactPersonen3.View.DialogWindows
{
    /// <summary>
    /// Interaction logic for AddPersonWindow.xaml
    /// </summary>
    public partial class AddPersonWindow : Window
    {
        public ContactViewModel CVM { get; set; }
        public AddPersonWindow(ContactViewModel vm)
        {
            CVM = vm;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            Address address = new Address();
            person.Name = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.Phonenumber = txtPhonenumber.Text;
            address.Street = txtStreet.Text;
            if (int.TryParse(txtHouseNumber.Text, out int result))
            {
                address.HouseNumber = result;
            }
            address.PostalCode = txtPostalCode.Text;
            address.City = txtCity.Text;
            person.Address = address;
            person.Remark = txtRemarks.Text;
            CVM.Contacts.Add(person);
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
