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

namespace Constructors_Toshmatovv
{

    public partial class MainWindow : Window
    {
        public List<Classes.Student> AllStudents = Classes.RepoStudents.AllStudents();
        public int Count = 10;
        public int Step = 0;

        public MainWindow()
        {
            InitializeComponent();
            CreateStudent(Step, Count);
        }
        public void CreateStudent(int step, int count)
        {
            for (int iStudent = step; iStudent < step + count; iStudent++)
            {
                if (AllStudents.Count > iStudent)
                {
                    parent.Children.Add(new Elements.Student(AllStudents[iStudent]));
                }
            }
            this.Step += count;
        }
        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scroll = sender as ScrollViewer;
            double parentHeight = parent.ActualHeight;
            double windowHeight = scroll.ActualHeight - 20;
            double deltaHeight = parentHeight - windowHeight;
            if (deltaHeight - scroll.VerticalOffset < 140)
            {
                CreateStudent(Step, Count);
            }
        }
    }
}
