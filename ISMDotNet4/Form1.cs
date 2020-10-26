using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace ISMDotNet4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int width = 35;
            int count = int.Parse(textBoxCount.Text);
            dataGridArray.ColumnCount = count;
            dataGridArray.RowCount = 1;
            dataGridSorted.ColumnCount = count;
            dataGridSorted.RowCount = 1;
            dataGridDeleteNegative.ColumnCount = count;
            dataGridDeleteNegative.RowCount = 1;
            double[] arr = new double[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                dataGridArray.Columns[i].Width = width;
                dataGridArray.Columns[i].HeaderCell.Value = i.ToString();
                if (rnd.Next(-50, 100) <= 0) 
                    arr[i] = rnd.Next(-1000,1000) * 1.0 / 10;
                else
                    arr[i] = rnd.Next(-100, 100);
                dataGridArray[i, 0].Value = arr[i];

            }

            labelSumNegative.Text = "Сумма негативных элементов: " 
                + ArrayMethods.SumNegative(arr).ToString();
            labelMax.Text = "Максимальный элемент массива: " + ArrayMethods.MaxElement(arr).ToString() + ", его индекс: "
                + ArrayMethods.MaxElementIndex(arr).ToString();
            labelMaxByModule.Text = "Максимальный элемент массива по модулю: " + ArrayMethods.MaxElementByModule(arr).ToString() + ", его индекс: "
                + ArrayMethods.MaxElementByModuleIndex(arr).ToString();
            labelSumPositiveIndexes.Text = "Сумма индексов положительных элементов: " 
                + ArrayMethods.SumOfPositiveNumberIndexes(arr).ToString() + ", количестов целых чисел: "
                + ArrayMethods.AmountOfIntegerNumbers(arr).ToString(); 

            for (int i = 0; i < count; i++)
            {
                dataGridSorted.Columns[i].Width = width;
                dataGridSorted.Columns[i].HeaderCell.Value = i.ToString();
                ArrayMethods.ArraySort(arr);
                dataGridSorted[i, 0].Value = arr[i];
                
            }

            double[] arrNegative = new double[ArrayMethods.DeleteNagativeNumbers(arr).Length];
            arrNegative = ArrayMethods.DeleteNagativeNumbers(arr);

            for (int i = 0; i < arrNegative.Length; i++)
            {
                dataGridDeleteNegative.Columns[i].Width = width;
                dataGridDeleteNegative.Columns[i].HeaderCell.Value = i.ToString();
                dataGridDeleteNegative.ColumnCount = arrNegative.Length;
                dataGridDeleteNegative[i, 0].Value = arrNegative[i];
            }
        }
    }
}
