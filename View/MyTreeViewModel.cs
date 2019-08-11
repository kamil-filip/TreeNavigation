using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.View
{


    public abstract class BaseNodeViewModel
    {
        public string Name { get; set; }
        public BaseNodeViewModel Parent { get; set; }
    }

    public class RdsNodeViewModel : BaseNodeViewModel
    {
        public RdsNodeViewModel(string name)
        {
            Name = name;
        }
        public IEnumerable<BaseNodeViewModel> Children { get; set; }
    }

    public class UnderlyingViewModel: BaseNodeViewModel
    {
        public UnderlyingViewModel(string name)
        {
            Name = name;
        }
    }






    public class MyTreeViewModel
    {

        public ICollection<BaseNodeViewModel> FirstLayer  { get; set; }

        public MyTreeViewModel()
        {

            FirstLayer = new List<BaseNodeViewModel>()
            {
                new RdsNodeViewModel("Hello")
                {
                    Children = new List<BaseNodeViewModel>()
                    {
                        new RdsNodeViewModel("Jan"),
                        new RdsNodeViewModel("Malgorzata"),
                                        new RdsNodeViewModel("Hello")
                {
                    Children = new List<BaseNodeViewModel>()
                    {
                        new RdsNodeViewModel("Jan"),
                        new RdsNodeViewModel("Malgorzata"),
                        new UnderlyingViewModel("MyUnderling")
                    }
                },
                        new UnderlyingViewModel("MyUnderling")
                    }
                },
                new RdsNodeViewModel("Kamil"),
                new RdsNodeViewModel("Hello")
                {
                    Children = new List<BaseNodeViewModel>()
                    {
                        new RdsNodeViewModel("Jan"),
                        new RdsNodeViewModel("Malgorzata"),
                        new UnderlyingViewModel("MyUnderling")
                    }
                },
            };

        }

    }
}
