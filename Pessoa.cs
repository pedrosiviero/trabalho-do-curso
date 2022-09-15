namespace POO{
    public abstract class Pessoa{
        private string cpf = "";
        private string nome = "";

        private string rg = "";

        private string dataNascimento = "";

        public int profissa = 0; 

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
         public int GetProfissa(){
            return profissa; 
        }
        public void SetProfissa(int profissa){
            this.profissa = profissa; 
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

        }
        
    }
}