/*
 * Josh Degazio
 * Feb 27, 2018
 * Career Informatory
 * User can learn about a selected course in a selected university chosen by the creator.
 */
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U1_04CareersJosh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        int PageNumber;

        public MainWindow()
        {
            InitializeComponent();
            PageNumber = 1;
            Page_Identifier.Text = "Page #" + PageNumber;
        }

        //Page Control
        //Next Page
        public void Next_Page_Activated(object sender, RoutedEventArgs e)
        {
            if (Page_2.Visibility == System.Windows.Visibility.Visible)
            {
                PageNumber = 3;
                Page_1.Visibility = System.Windows.Visibility.Hidden;
                Page_2.Visibility = System.Windows.Visibility.Hidden;
                Page_3.Visibility = System.Windows.Visibility.Visible;
                Page_Identifier.Text = "Page #" + PageNumber;
            }
            if (Page_1.Visibility == System.Windows.Visibility.Visible)
            {
                PageNumber = 2;
                Page_1.Visibility = System.Windows.Visibility.Hidden;
                Page_2.Visibility = System.Windows.Visibility.Visible;
                Page_3.Visibility = System.Windows.Visibility.Hidden;
                Page_Identifier.Text = "Page #" + PageNumber;
            }
        }
        //Last Page
        public void Last_Page_Activated(object sender, RoutedEventArgs e)
        {
            if (Page_2.Visibility == System.Windows.Visibility.Visible)
            {
                PageNumber = 1;
                Page_3.Visibility = System.Windows.Visibility.Hidden;
                Page_2.Visibility = System.Windows.Visibility.Hidden;
                Page_1.Visibility = System.Windows.Visibility.Visible;
                Page_Identifier.Text = "Page #" + PageNumber;
            }
            if (Page_3.Visibility == System.Windows.Visibility.Visible)
            {
                PageNumber = 2;
                Page_3.Visibility = System.Windows.Visibility.Hidden;
                Page_2.Visibility = System.Windows.Visibility.Visible;
                Page_1.Visibility = System.Windows.Visibility.Hidden;
                Page_Identifier.Text = "Page #" + PageNumber;
            }
        }



        //Page 2
        //Display Pre-Requisites
        public void PreReq_Active(object sender, RoutedEventArgs e)
        {
            PreReq.Visibility = System.Windows.Visibility.Visible;
            Basic_Info.Visibility = System.Windows.Visibility.Hidden;
        }
        
        //Display Basic Info
        public void Basic_Info_Active(object sender, RoutedEventArgs e)
        {
            Basic_Info.Visibility = System.Windows.Visibility.Visible;
            PreReq.Visibility = System.Windows.Visibility.Hidden;
        }

        //Reset Any Display Info
        public void Reset_Active(object sender, RoutedEventArgs e)
        {
            Basic_Info.Visibility = System.Windows.Visibility.Hidden;
            PreReq.Visibility = System.Windows.Visibility.Hidden;
        }



        //Page 3
        //Display First Year Courses
        public void First_Year_Active(object sender, RoutedEventArgs e)
        {
            FirstCourses.Visibility = System.Windows.Visibility.Visible;
            PotCareers.Visibility = System.Windows.Visibility.Hidden;
        }

        //Display Basic Info
        public void PotCareers_Active(object sender, RoutedEventArgs e)
        {
            PotCareers.Visibility = System.Windows.Visibility.Visible;
            FirstCourses.Visibility = System.Windows.Visibility.Hidden;
        }

        //Reset Any Display Info
        public void Reset2_Active(object sender, RoutedEventArgs e)
        {
            PotCareers.Visibility = System.Windows.Visibility.Hidden;
            FirstCourses.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
