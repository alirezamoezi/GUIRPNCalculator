using System;
using System.Collections.Generic;

namespace GUIRPNCalculator
{
    class Calculator
    {
        List<Entry> Entries;
        public Calculator(List<Entry> entries)
        {
            Entries = entries;
        }

        public double? GetEntries()
        {
            Stack<Entry> stackofEntries = new Stack<Entry>();
            //double? result = null;
            Entry entr1;
            Entry entr2;
            double ent1;
            double ent2 = 0;
            Entry res;
            foreach (Entry item in Entries)
            {
                switch (item.Type)
                {
                    case EntryType.Number:
                        stackofEntries.Push(item);
                        break;
                    case EntryType.Plus:
                        entr1 = stackofEntries.Pop();
                        entr2 = stackofEntries.Pop();
                        ent1 = (double)entr1.Value;
                        ent2 = (double)entr2.Value;
                        ent2 += ent1;
                        res = new Entry(EntryType.Number, (int?)ent2);
                        stackofEntries.Push(res);
                        break;
                    case EntryType.Multiply:
                        entr1 = stackofEntries.Pop();
                        entr2 = stackofEntries.Pop();
                        ent1 = (double)entr1.Value;
                        ent2 = (double)entr2.Value;
                        ent2 *= ent1;
                        res = new Entry(EntryType.Number, (int?)ent2);
                        stackofEntries.Push(res);
                        break;
                    case EntryType.Minus:
                        entr1 = stackofEntries.Pop();
                        entr2 = stackofEntries.Pop();
                        ent1 = (double)entr1.Value;
                        ent2 = (double)entr2.Value;
                        ent2 -= ent1;
                        res = new Entry(EntryType.Number, (int?)ent2);
                        stackofEntries.Push(res);
                        break;
                    case EntryType.Divide:
                        entr1 = stackofEntries.Pop();
                        entr2 = stackofEntries.Pop();
                        ent1 = (double)entr1.Value;
                        ent2 = (double)entr2.Value;
                        ent2 /= ent1;
                        res = new Entry(EntryType.Number, (int?)ent2);
                        stackofEntries.Push(res);
                        break;
                    case EntryType.Exponent:
                        entr1 = stackofEntries.Pop();
                        entr2 = stackofEntries.Pop();
                        ent1 = (double)entr1.Value;
                        ent2 = (double)entr2.Value;
                        ent2 = Math.Pow(ent1, ent2);
                        res = new Entry(EntryType.Number, (int?)ent2);
                        stackofEntries.Push(res);
                        break;
                }
            }
            return ent2;
        }
        public override string ToString()
        {
            string str = string.Join("  ", Entries);
            return str;
        }
    }
}
