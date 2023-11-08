namespace calculator.Services
{
    public class Calculator
    {
        private List<string> listHistory;
        private string date;
        public Calculator(string date)
        {
            listHistory = new List<string>();
            this.date = date;
        }
        public int sum(int numb1, int numb2)
        {
            int res = numb1 + numb2;
            listHistory.Insert(0, "Resultado: " + res + " - data: " + date);
            return res;
        }
        public int substract(int numb1, int numb2)
        {
            int res = numb1 - numb2;
            listHistory.Insert(0, "Resultado: " + res + " - data: " + date);
            return res;
        }
        public int divider(int numb1, int numb2)
        {
            int res = numb1 / numb2;
            listHistory.Insert(0, "Resultado: " + res + " - data: " + date);
            return res;
        }
        public int multiply(int numb1, int numb2)
        {
            int res = numb1 * numb2;
            listHistory.Insert(0, "Resultado: " + res + " - data: " + date);
            return res;
        }

        public List<string> history()
        {
            listHistory.RemoveRange(3, listHistory.Count - 3);
            return listHistory;
        }
    }
}
