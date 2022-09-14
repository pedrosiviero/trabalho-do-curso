namespace POO{
    public abstract class Pessoa{
        public string cpf = "";
        public string nome = "";

        public string rg = "";

        public string dataNascimento = "";

        public string endereco = "";

        public int profissao = 0;

        public string GetRg(){
            return rg; 
        }
        public void SetRg(string rg){
            this.rg = rg; 
        }
        public string GetDataNascimento(){
            return dataNascimento; 
        }
        public void SetDataNascimento(string dataNascimento){
            this.dataNascimento = dataNascimento; 
        }
        public string GetEndereco(){
            return endereco; 
        }
        public void SetEndereço(string endereco){
            this.endereco = endereco; 
        }
         public string GetNome(){
            return nome; 
        }
        public void SetNome(string nome){
            this.nome = nome; 
        }
         public string GetCpf(){
            return cpf; 
        }
        public void SetCpf(string cpf){
            this.cpf = cpf; 
        }
         public int GetProfissao(){
            return profissao; 
        }
        public void SetProfissao(int profissao){
            this.profissao = profissao; 
        }

        public void InformarDados(){

            Console.WriteLine("Digite o Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o cpf:");
            cpf = Console.ReadLine();

            Console.WriteLine("Digite o rg:");
            rg = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento:");
            dataNascimento = Console.ReadLine();

            Console.WriteLine("Digite o endereço:");
            endereco = Console.ReadLine();
        }

        /*if(profissao == 1){
                Console.WriteLine("Você foi cadastrado\n" + nome + "\n" + cpf + "\n" + rg + "\n" + dataNascimento + "\n " + endereco)
            }*/
        
    }
}