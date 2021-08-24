using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUIRPNCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbExp.DataSource = CreateComputations();
        }

        private List<Calculator> CreateComputations()
        {
            List<Calculator> computations = new List<Calculator>();
            //first entry Ans=7
            List<Entry> entry = new List<Entry>()
            {
                new Entry(EntryType.Number, 3),
                new Entry(EntryType.Number, 4),
                new Entry(EntryType.Plus)
            };
            Calculator computation = new Calculator(entry);
            computations.Add(computation);

            //second entry Ans = 17
            entry = new List<Entry>()
            {
                new Entry(EntryType.Number, 1),
                new Entry(EntryType.Number, 2),
                new Entry(EntryType.Number, 4),
                new Entry(EntryType.Exponent),
                new Entry(EntryType.Plus)
            };
            computation = new Calculator(entry);
            computations.Add(computation);

            //third entry Ans=14
            entry = new List<Entry>()
            {
                new Entry(EntryType.Number, 2),
                new Entry(EntryType.Number, 3),
                new Entry(EntryType.Number, 4),
                new Entry(EntryType.Plus),
                new Entry(EntryType.Multiply)
            };
            computation = new Calculator(entry);
            computations.Add(computation);

            //4 2 5 * + 1 3 2 * + /
            //fourth entry Ans=2
            entry = new List<Entry>()
            {
                new Entry(EntryType.Number, 4),
                new Entry(EntryType.Number, 2),
                new Entry(EntryType.Number, 5),
                new Entry(EntryType.Multiply),
                new Entry(EntryType.Plus),
                new Entry(EntryType.Number, 1),
                new Entry(EntryType.Number, 3),
                new Entry(EntryType.Number, 2),
                new Entry(EntryType.Multiply),
                new Entry(EntryType.Plus),
                new Entry(EntryType.Divide)
            };
            computation = new Calculator(entry);
            computations.Add(computation);

            //15 7 1 1 + − ÷ 3 × 2 1 1 + + −
            //last entry Ans=5
            entry = new List<Entry>()
            {
                new Entry(EntryType.Number, 15),
                new Entry(EntryType.Number, 7),
                new Entry(EntryType.Number, 1),
                new Entry(EntryType.Number, 1),
                new Entry(EntryType.Plus),
                new Entry(EntryType.Minus),
                new Entry(EntryType.Divide),
                new Entry(EntryType.Number, 3),
                new Entry(EntryType.Multiply),
                new Entry(EntryType.Number, 2),
                new Entry(EntryType.Number, 1),
                new Entry(EntryType.Number, 1),
                new Entry(EntryType.Plus),
                new Entry(EntryType.Plus),
                new Entry(EntryType.Minus)
            };
            computation = new Calculator(entry);
            computations.Add(computation);

            return computations;
        }

        private void cmbExp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculator calculator = cmbExp.SelectedItem as Calculator;
            txtAns.Text = Convert.ToString(calculator.GetEntries());
        }
    }
}
