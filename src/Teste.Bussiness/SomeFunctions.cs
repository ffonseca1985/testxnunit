namespace Teste.Bussiness
{
    public class SomeFunctions
    {
        public int Sum(int a, int b) => a + b;
        public int Minus(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public int Divide(int a, int b)
        {
            CheckDivideByZero(b);
            return a / b;
        }

        private void CheckDivideByZero(int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Divisão por zero!");
        }
    }
}