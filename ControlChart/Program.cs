using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;
using muWrapper;
using MathNet.Numerics.Distributions;

namespace ControlChart
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    static class Generator
    {
        static public double[,] GenerateData(int smpCount, int n, string exprM, string exprS)
        {
            double[,] data = new double[smpCount, n];
            Parser prsM = new Parser(), prsS = new Parser();
            prsM.SetExpr(exprM);
            prsS.SetExpr(exprS);
            ParserVariable varT = new ParserVariable();
            prsM.DefineVar("t", varT);
            prsS.DefineVar("t", varT);
            NormalDistribution dist = new NormalDistribution();
            for (int i = 0; i < smpCount; i++)
            {
                varT.Value = i + 1;
                dist.SetDistributionParameters(prsM.Eval(), prsS.Eval());
                for (int j = 0; j < n; j++)
                    data[i, j] = dist.NextDouble();
            }
            return data;
        }
        static public void SaveData(string file, double[,] data)
        {
            FileStream fs = new FileStream(file, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Unicode);
            sw.WriteLine(string.Format("{0} {1}", data.GetLength(0), data.GetLength(1)));
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                    sw.Write(String.Format("{0} ", data[i, j]));
                sw.WriteLine();
            }
            sw.Close();
        }
        static public double[,] ReadData(string file)
        {
            FileStream fs = new FileStream(file, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Unicode);
            string str = sr.ReadToEnd();
            sr.Close();
            string[] arrStr = str.Split(new char[] { ' ', '\r', '\n' });
            int smpCount = int.Parse(arrStr[0]);
            int n = int.Parse(arrStr[1]);
            double[,] data = new double[smpCount, n];
            int k = 2;
            for (int i = 0; i < smpCount; i++)
                for (int j = 0; j < n; j++)
                {
                    while (arrStr[k] == "")
                        k++;
                    data[i, j] = double.Parse(arrStr[k++]);
                }
            return data;
        }
    }
    class MSChart
    {
        public double[] arrM, arrS;
        public double mAv, sAv, mMin, mMax, sMin, sMax;
        protected double[,] data;
        protected static double[] A1 = new double[] {
            0.000, 0.000, 2.121, 1.732, 1.500, 1.342, 1.225, 1.134, 1.061, 1.000,
            0.949, 0.905, 0.866, 0.832, 0.802, 0.775, 0.750, 0.728, 0.707, 0.688,
            0.671, 0.655, 0.640, 0.626, 0.612, 0.600 };
        protected static double[] A3 = new double[] {
            0.000, 0.000, 2.659, 1.954, 1.628, 1.427, 1.287, 1.182, 1.099, 1.032,
            0.975, 0.927, 0.886, 0.850, 0.817, 0.789, 0.763, 0.739, 0.718, 0.698,
            0.680, 0.663, 0.647, 0.633, 0.619, 0.606 };
        protected static double[] B3 = new double[] {
            0.000, 0.000, 0.000, 0.000, 0.000, 0.000, 0.030, 0.118, 0.185, 0.239,
            0.284, 0.321, 0.354, 0.382, 0.406, 0.428, 0.448, 0.466, 0.482, 0.497,
            0.510, 0.523, 0.534, 0.545, 0.555, 0.565 };
        protected static double[] B4 = new double[] {
            0.000, 0.000, 3.267, 2.568, 2.266, 2.089, 1.970, 1.882, 1.815, 1.761,
            1.716, 1.679, 1.646, 1.618, 1.594, 1.572, 1.552, 1.534, 1.518, 1.503,
            1.490, 1.477, 1.466, 1.455, 1.445, 1.434 };
        protected static double[] B5 = new double[] {
            0.000, 0.000, 0.000, 0.000, 0.000, 0.000, 0.029, 0.113, 0.179, 0.232,
            0.276, 0.313, 0.346, 0.374, 0.399, 0.421, 0.440, 0.458, 0.475, 0.490,
            0.504, 0.516, 0.528, 0.539, 0.549, 0.559 };
        protected static double[] B6 = new double[] {
            0.000, 0.000, 2.606, 2.276, 2.088, 1.964, 1.874, 1.806, 1.751, 1.707,
            1.669, 1.637, 1.610, 1.585, 1.563, 1.544, 1.526, 1.511, 1.496, 1,483,
            1.470, 1.459, 1.448, 1.438, 1.429, 1.420 };
        protected static double[] C4 = new double[] {
            0.0000, 0.0000, 0.7979, 0.8886, 0.9213, 0.9400, 0.9515, 0.9594, 0.9650, 0.9693,
            0.9727, 0.9754, 0.9776, 0.9794, 0.9810, 0.9823, 0.9835, 0.9845, 0.9854, 0.9862,
            0.9869, 0.9876, 0.9882, 0.9887, 0.9892, 0.9896 };
    }
    class MSChartStd : MSChart
    {
        public MSChartStd(double mAv, double sigma, double[,] data)
        {
            this.mAv = mAv;
            this.data = (double[,])data.Clone();
            int smpCount = data.GetLength(0), n = data.GetLength(1);
            arrM = new double[smpCount];
            arrS = new double[smpCount];
            for (int i = 0; i < smpCount; i++)
            {
                double xSum = 0, x2Sum = 0;
                for (int j = 0; j < n; j++)
                {
                    xSum += data[i, j];
                    x2Sum += data[i, j] * data[i, j];
                }
                arrM[i] = xSum / n;
                arrS[i] = Math.Sqrt((x2Sum / n - arrM[i] * arrM[i]) * n / (n - 1));
            }
            if (n > 25)
                n = 25;
            mMin = mAv - A1[n] * sigma;
            mMax = mAv + A1[n] * sigma;
            sAv = C4[n] * sigma;
            sMin = B5[n] * sigma;
            sMax = B6[n] * sigma;
        }
    }
    class MSChartNS : MSChart
    {
        public MSChartNS(double[,] data)
        {
            this.data = (double[,])data.Clone();
            int smpCount = data.GetLength(0), n = data.GetLength(1);
            arrM = new double[smpCount];
            arrS = new double[smpCount];
            double mSum = 0, sSum = 0;
            for (int i = 0; i < smpCount; i++)
            {
                double xSum = 0, x2Sum = 0;
                for (int j = 0; j < n; j++)
                {
                    xSum += data[i, j];
                    x2Sum += data[i, j] * data[i, j];
                }
                mSum += arrM[i] = xSum / n;
                sSum += arrS[i] = Math.Sqrt((x2Sum / n - arrM[i] * arrM[i]) * n / (n - 1));
            }
            if (n > 25)
                n = 25;
            mAv = mSum / smpCount;
            sAv = sSum / smpCount;
            mMin = mAv - A3[n] * sAv;
            mMax = mAv + A3[n] * sAv;
            sMin = B3[n] * sAv;
            sMax = B4[n] * sAv;
        }
    }
}