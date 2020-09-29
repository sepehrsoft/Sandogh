﻿using Sandogh.DataLayer.Context;

using System;
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

namespace Sandogh.App
{
    /// <summary>
    /// Interaction logic for AddOrEditUserWindow.xaml
    /// </summary>
    public partial class AddOrEditUserWindow : Window
    {
        public AddOrEditUserWindow(int id)
        {
            InitializeComponent();
            TxtID.Text = id.ToString();
            UnitOfWork unitOfWork = new UnitOfWork();
            UserFullView fullView = unitOfWork.UserGenericRepository.GetUserFullDetailsByID(id);
        }
    }
}
