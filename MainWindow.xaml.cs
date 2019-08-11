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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public abstract class MyNode
    {

        public MyNode(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public MyNode Parent { get; set; }
    }


    public class RdsItem : MyNode
    {
        public RdsItem(string name) : base(name)
        {
        }

        public IEnumerable<MyNode> Child { get; set; }
    }


    public class Underlying : MyNode
    {
        public Underlying(string name) : base(name)
        {
        }

        public string Id { get; set; }
    }


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            var source = new List<MyNode>()
            {
                new RdsItem("Hello")
                {
                    Child = new List<MyNode>()
                    {
                        new RdsItem("oyo")

                    }
                },
                new RdsItem("World")
            };





        }
    }
}
