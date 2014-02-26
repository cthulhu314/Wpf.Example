using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Example
{
    public class RectanglesWindowViewModel
    {
        public class RectangleViewModel 
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        public ObservableCollection<RectangleViewModel> Rectangles { get; set; }
        public RectanglesWindowViewModel()
        {
            var random = new Random();
            Rectangles = new ObservableCollection<RectangleViewModel>(
                Enumerable.Range(0, 10).Select(_ =>
                    new RectangleViewModel { X = 50 + 200 * random.NextDouble(), Y = 50 + 200 * random.NextDouble() }));
        }
    }
}
