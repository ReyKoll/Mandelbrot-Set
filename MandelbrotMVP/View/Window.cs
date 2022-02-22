using System;
using System.Windows.Forms;
using MandelbrotMVP.Presenter;
using MandelbrotMVP.View;

namespace MandelbrotMVP
{
    public partial class MainWindow : Form, IMandelbrot
    {
        private Fractal _fractal;

        public MainWindow()
        {
            InitializeComponent();
            ShowDefaultTxt();
        }

        public string TxtX0 { get => txtX0.Text; set => txtX0.Text = value; }
        public string TxtXN { get => txtXN.Text; set => txtXN.Text = value; }
        public string TxtY0 { get => txtY0.Text; set => txtY0.Text = value; }
        public string TxtYN { get => txtYN.Text; set => txtYN.Text = value; }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            _fractal = new Fractal(this);
            _fractal.Draw(this);
            gbSettings.Hide();
            btnUndo.Visible = true;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            gbSettings.Visible = true;
            btnUndo.Visible = false;
        }

        private void ShowDefaultTxt()
        {
            txtX0.Text = (string)txtX0.Tag;
            txtXN.Text = (string)txtXN.Tag;
            txtY0.Text = (string)txtY0.Tag;
            txtYN.Text = (string)txtYN.Tag;
        }
    }
}