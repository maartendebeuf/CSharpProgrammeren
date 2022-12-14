namespace TransactieLogic
{
    public class Rekening
    {
        private Single _HuidigSaldo = 0;
        public Rekening() {
            _HuidigSaldo = 100;
        }

        public Single HuidigSaldo { get { return _HuidigSaldo;} }


        public bool Transactie(string SoortTrans, Single Bedrag)
        {
            bool result = false;

            switch (SoortTrans)
            {
                case "+":

                    _HuidigSaldo += Bedrag;
                    result= true;
                    break;

                case "-":
                    if (_HuidigSaldo < Bedrag) throw new Exception("Onvoldoende saldo - rekening kan niet onder nul.");

                    _HuidigSaldo -= Bedrag;
                    result = true;
                    break;
            }

            return result;
        }
    }
}