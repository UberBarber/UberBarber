﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UberBarber
{
    /// <summary>
    /// Interaction logic for Appointments.xaml
    /// </summary>
    public partial class Appointments : Window
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void refresh_datagrid_button_Click(object sender, RoutedEventArgs e)
        {
            appointments_datagrid.Items.Refresh();
        }
    }
}
