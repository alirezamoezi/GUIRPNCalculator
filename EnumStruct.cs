namespace GUIRPNCalculator
{
    enum EntryType
    {
        Number,
        Plus,
        Minus,
        Multiply,
        Divide,
        Exponent
    }
    struct Entry
    {
        public EntryType Type { get; }
        public int? Value { get; }
        public Entry(EntryType type, int? value = null)
        {
            Type = type; Value = value;
        }
        public override string ToString()
        {
            string Operator = "";
            if (Type == EntryType.Divide) Operator = "/";
            if (Type == EntryType.Minus) Operator = "-";
            if (Type == EntryType.Multiply) Operator = "*";
            if (Type == EntryType.Exponent) Operator = "^";
            if (Type == EntryType.Plus) Operator = "+";
            if (Type == EntryType.Number) Operator = "";
            return $"{Value} {Operator}";
        }
    }
}
