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
using Core;

namespace ClubSchool.Pages
{
    /// <summary>
    /// Interaction logic for StatisticsPage.xaml
    /// </summary>
    public partial class StatisticsPage : Page
    {
        public List<StudentStatistic> StudentStatistics { get; set; }
        public List<ClubStatistic> ClubStatistics { get; set; }

        public StatisticsPage()
        {
            InitializeComponent();
            StudentStatistics = StatisticService.GetStudentStatistics();
            ClubStatistics = StatisticService.GetClubStatistics();

            DataContext = this;
        }
    }
}
