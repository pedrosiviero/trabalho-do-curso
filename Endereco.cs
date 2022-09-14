namespace POO{

    public class Endereco{

        private string rua = "";
        private int numeroCasa = 0;
        private string bairro = "";
        private string cep = "";
        private string cidade = "";
        private string estado = "";
 // arrumar endereço(new) produto e venda 
       public string GetRua(){
            return rua; 
        }
        public void SetRua(string rua){
            this.rua = rua; 
        }
        public int GetNumeroCasa(){
            return numeroCasa; 
        }
        public void SetNumeroCasa(int numeroCasa){
            this.numeroCasa = numeroCasa; 
        }
        public string GetBairro(){
            return bairro; 
        }
        public void SetBairro(string bairro){
            this.bairro = bairro; 
        }
        public string GetCep(){
            return cep; 
        }
        public void SetCep(string cep){
            this.cep = cep; 
        }
        public string GetCidade(){
            return cidade; 
        }
        public void SetCidade(string cidade){
            this.cidade = cidade; 
        }public string GetEstado(){
            return estado; 
        }
        public void SetEstado(string estado){
            this.estado = estado; 
        }

        public void InformarDados(){

            Console.WriteLine("Digite a rua:");
            rua = Console.ReadLine();

            Console.WriteLine("Digite o número da casa:");
            numeroCasa = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o CEP:");
            cep = Console.ReadLine();

            Console.WriteLine("Digite a cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine("Digite o estado:");
            estado = Console.ReadLine();
        }
    }
}