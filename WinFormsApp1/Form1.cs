using WinFormsApp1.Views;
using WinFormsApp1.Presenters;

namespace WinFormsApp1
{
    public partial class Form1 : Form, IRectangle
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string LengthText { get => txtLength.Text; set => txtLength.Text = value; }
        public string BreadthText { get => txtBreadth.Text; set => txtBreadth.Text = value; }
        public string AreaText { get => lblArea.Text; set => lblArea.Text = value; }

        private void CalculateArea_Click(object sender, EventArgs e)
        {
            RectanglePresenter presenter = new RectanglePresenter(this);
            presenter.CalculateArea();
        }
    }
}