using WinFormsApp1.Views;
using WinFormsApp1.Models;

namespace WinFormsApp1.Presenters
{
    public class RectanglePresenter
    {
        IRectangle rectangleView;

        public RectanglePresenter(IRectangle view)
        {
            rectangleView = view; 
        }

        public void CalculateArea()
        {
            Models.Rectangle rectangle = new Models.Rectangle();
            rectangle.Length = double.Parse(rectangleView.LengthText);
            rectangle.Breadth = double.Parse(rectangleView.BreadthText);

            rectangleView.AreaText = rectangle.CalculateArea().ToString();
        }
    }
}
