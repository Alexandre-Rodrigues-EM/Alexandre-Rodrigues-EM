namespace Banco
{
    public class Cliente
    {
        public int RG;
        public int CPF;
   //     public string nome;
        public string nome { get; set; }
        public Cliente(string _nome)
        {
            nome = _nome;
        }

    }
}