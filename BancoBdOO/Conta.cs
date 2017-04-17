namespace BancoBdOO
{
    public class Conta
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Agencia { get; set; } 
        public decimal Saldo { get; set; }
        public string Tipo { get; set; }

        public virtual void Desconta()
        {
               
        }
        public virtual bool Sacar(decimal s)
        {
            if(Saldo >= s)
            {
                Saldo = Saldo - s;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}