﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MmmData;

namespace MmmDemo.Employees
{
    /// <summary>
    /// Interaction logic for AddNewEmployee.xaml
    /// </summary>
    public partial class AddNewEmployee : Window
    {
        public AddNewEmployee()
        {
            InitializeComponent();
        }

        private void registerNewClientBtn_Click(object sender, RoutedEventArgs e)
        {
            MmmData.EmployeeDetails employeeDetails = employeeInfoControl.getDetails();

            employeeDetails.employeeId = MmmData.IdGenerator.GetEmployeeUniqueId();

            if (MmmDb.DbInteraction.DoRegisterNewEmployee(employeeDetails) == 1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("do it");
            }
        }
    }
}
