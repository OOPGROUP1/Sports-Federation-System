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

namespace SFS
{
    /// <summary>
    /// Interaction logic for Search_Sponser.xaml
    /// </summary>
    public partial class Search_Sponser : Window
    {
        public Search_Sponser()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Sponsers> find_Sponser = new List<Sponsers>();
            if (textBox.Text == "")
            {
                MessageBox.Show("Please fill the required information");
            }
            for (int i = 0; i < Containers.Sponsor_list.Count; i++)
            {
                if (Containers.Sponsor_list[i].GetName() == textBox.Text)
                {
                    find_Sponser.Add(Containers.Sponsor_list[i]);
                }

            }
        }
    }
}