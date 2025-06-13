using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using ACO.Properties;

namespace ACO
{
    public partial class FormACO : Form
    {
        public FormACO()
        {
            InitializeComponent();

            MyInit();
        }

        #region Event Handlers

        private void PanelMapPaint(object sender, PaintEventArgs e)
        {
            if (_points.Count > 0)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                for (int it = 1; it < _optimalPath.Count; ++it)
                {
                    e.Graphics.DrawLine(_penOptimal, _points[_optimalPath[it]], _points[_optimalPath[it - 1]]);
                }
                for (int it = 1; it < _currentPath.Count; ++it)
                {
                    e.Graphics.DrawLine(_penPath, _points[_currentPath[it]], _points[_currentPath[it - 1]]);
                }
                e.Graphics.FillEllipse(_brushHome, _points[0].X - 4, _points[0].Y - 4, 8, 8);
                for (int it = 1; it < _points.Count; ++it)
                {
                    e.Graphics.FillEllipse(_brushCity, _points[it].X - 3, _points[it].Y - 3, 6, 6);
                }
            }
        }

        private void ButtonGenerateClick(object sender, EventArgs e)
        {
            Generate();
            Buttons(true);
        }

        private void ButtonOptimalClick(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                Buttons(false);
                _currentPath.Clear();
                _solver = new OptimalSolver([_points, _currentPath, _optimalPath]);
                backgroundWorker.RunWorkerAsync(_solver);
            }
        }

        private void ButtonAntClick(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                Buttons(false);
                _currentPath.Clear();
                double alfa, beta, ro;
                if (double.TryParse(textBoxAlfa.Text, out alfa) &&
                    double.TryParse(textBoxBeta.Text, out beta) &&
                    double.TryParse(textBoxRo.Text, out  ro))
                {
                    _solver = new AntSystemSolver([_points, _currentPath, Ants.Value, Iterations.Value, alfa, beta, ro, 1d]);
                    backgroundWorker.RunWorkerAsync(_solver);
                }
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
                backgroundWorker.CancelAsync();
        }

        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            while (((Solver)e.Argument).Solve(Delay.Value, out  _cost))
            {
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                if (panelMap.InvokeRequired)
                {
                    panelMap.Invoke((MethodInvoker)(() => panelMap.Refresh()));
                }
                else
                {
                    panelMap.Refresh();
                }
            }
        }

        private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_solver.GetType() == typeof(OptimalSolver))
                toolStripStatusLabelOptimalVal.Text = _cost.ToString(CultureInfo.InvariantCulture);
            else
                toolStripStatusLabelCurrentVal.Text = _cost.ToString(CultureInfo.InvariantCulture);

            Buttons(true);
        }

        private void PointsToolStripMenuItem1Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = Resources.openFile;
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                using (FileStream stream = File.OpenRead(openFileDialog.FileName))
                {
                    _points.Clear();
                    _points.AddRange((List<Point>)_serializer.Deserialize(stream));
                    Cities.Value = _points.Count;
                    Buttons(true);
                }
                panelMap.Refresh();
            }
        }

        private void PointsToolStripMenuItemClick(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.Filter = Resources.openFile;
            DialogResult result = saveFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                using FileStream stream = File.OpenWrite(saveFileDialog.FileName);
                _serializer.Serialize(stream, _points);
            }
        }


        private void ImageToolStripMenuItemClick(object sender, EventArgs e)
        {

            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.Filter = Resources.image;
            DialogResult result = saveFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                using var bitmap = new Bitmap(panelMap.Width, panelMap.Height);
                panelMap.DrawToBitmap(bitmap, panelMap.ClientRectangle);
                bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        #endregion

        #region My functions

        private void MyInit()
        {
            _penPath.StartCap = LineCap.ArrowAnchor;
            _penPath.EndCap = LineCap.RoundAnchor;
            _penOptimal.StartCap = LineCap.ArrowAnchor;
            _penOptimal.EndCap = LineCap.RoundAnchor;

            Cities.Set(1, 1, 11);
            Delay.Set(0, 0, 500);
            Ants.Set(10, 1, 100);
            Iterations.Set(1000, 100, 10000);
        }

        private void Generate()
        {
            toolStripStatusLabelCurrentVal.Text = "";
            toolStripStatusLabelOptimalVal.Text = "";

            _points.Clear();
            _currentPath.Clear();
            _optimalPath.Clear();
            for (int i = 0; i < Cities.Value; ++i)
                _points.Add(new Point(_rand.Next(panelMap.Width - 10) + 5, _rand.Next(panelMap.Height - 10) + 5));
            panelMap.Refresh();
        }

        private void Buttons(bool enabled)
        {
            buttonOptimal.Enabled = buttonAnt.Enabled = buttonGenerate.Enabled = enabled;
        }

        #endregion

        #region Data

        private readonly Brush _brushCity = Brushes.Crimson;
        private readonly Brush _brushHome = Brushes.Green;
        private readonly List<int> _currentPath = [];
        private readonly List<int> _optimalPath = [];
        private readonly Pen _penPath = new(Color.FromArgb(64, 0, 255, 0), 4);
        private readonly Pen _penOptimal = new(Color.FromArgb(64, 0, 0, 255), 4);
        private readonly List<Point> _points = [];
        private readonly Random _rand = new();
        private Solver _solver;
        private double _cost;
        private readonly XmlSerializer _serializer = new(typeof(List<Point>));

        #endregion

       }
}