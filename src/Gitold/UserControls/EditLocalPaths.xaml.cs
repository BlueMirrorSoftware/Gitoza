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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gitold.UserControls
{
    /// <summary>
    /// Interaction logic for EditLocalPaths.xaml
    /// </summary>
    public partial class EditLocalPaths : UserControl
    {
        public EditLocalPaths() {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, RoutedEventArgs e) {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            //if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    string res = dialog.SelectedPath;
        }
    }
}