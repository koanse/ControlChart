using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NPlot;

namespace ControlChart
{
    public partial class MainForm : Form
    {
        double[,] data;
        public MainForm()
        {
            InitializeComponent();
        }
        void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                    return;
                GenForm gf = new GenForm();
                if (gf.ShowDialog() != DialogResult.OK)
                    return;
                data = Generator.GenerateData(int.Parse(gf.tbSmp.Text),
                    int.Parse(gf.tbN.Text), gf.tbM.Text, gf.tbS.Text);
                Generator.SaveData(saveFileDialog1.FileName, data);
                DataForm df = new DataForm(saveFileDialog1.FileName);
                df.ShowDialog();
                ShowChart(data);
            }
            catch
            {
                MessageBox.Show("Ошибка генерации");
            }
        }
        void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                    return;
                data = Generator.ReadData(openFileDialog1.FileName);
                DataForm df = new DataForm(openFileDialog1.FileName);
                df.ShowDialog();
                ShowChart(data);
            }
            catch
            {
                MessageBox.Show("Ошибка чтения");
            }
        }
        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        void propToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ShowChart(data);
            }
            catch
            {
                MessageBox.Show("Задайте исходные данные");
            }
        }
        void ShowChart(double[,] data)
        {
            try
            {
                PropForm pf = new PropForm();
                pf.ShowDialog();
                MSChart chart;
                if (pf.rbNS.Checked)
                    chart = new MSChartNS(data);
                else chart = new MSChartStd(double.Parse(pf.tbM.Text),
                        double.Parse(pf.tbS.Text), data);
                psM.Clear();
                psS.Clear();
                double[] arrT = new double[chart.arrM.Length];
                for (int i = 0; i < arrT.Length; i++)
                    arrT[i] = i + 1;
                psM.Add(new LinePlot(chart.arrM, arrT));
                LinePlot lp = new LinePlot(new double[] { chart.mMin, chart.mMin },
                    new double[] { 1, arrT.Length });
                lp.Color = Color.Red;
                psM.Add(lp);
                lp = new LinePlot(new double[] { chart.mMax, chart.mMax },
                    new double[] { 1, arrT.Length });
                lp.Color = Color.Red;
                psM.Add(lp);
                lp = new LinePlot(new double[] { chart.mAv, chart.mAv },
                    new double[] { 1, arrT.Length });
                lp.Color = Color.Green;
                psM.Add(lp);
                psM.Title = "Контрольная карта Xср";
                psM.XAxis1.Label = "Номер выборки, t";
                psM.YAxis1.Label = "Среднее значение признака, Xср";
                psM.Refresh();

                psS.Add(new LinePlot(chart.arrS, arrT));
                lp = new LinePlot(new double[] { chart.sMin, chart.sMin },
                    new double[] { 1, arrT.Length });
                lp.Color = Color.Red;
                psS.Add(lp);
                lp = new LinePlot(new double[] { chart.sMax, chart.sMax },
                    new double[] { 1, arrT.Length });
                lp.Color = Color.Red;
                psS.Add(lp);
                lp = new LinePlot(new double[] { chart.sAv, chart.sAv },
                    new double[] { 1, arrT.Length });
                lp.Color = Color.Green;
                psS.Add(lp);
                psS.Title = "Контрольная карта s";
                psS.XAxis1.Label = "Номер выборки, t";
                psS.YAxis1.Label = "Стандартное отклонение, s";
                psS.Refresh();
            }
            catch
            {
                MessageBox.Show("Ошибка построения");
            }
        }        
    }
}