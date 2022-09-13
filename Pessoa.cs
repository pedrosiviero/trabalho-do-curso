namespace POO{
    public class Pessoa{
        private string cpf = "";
        public string nome = "";

        private string rg = "";

        public string dataNascimento = "";

        public string endereço = "";

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
        public string GetEndereço(){
            return endereço; 
        }
        public void SetEndereço(string endereço){
            this.endereço = endereço; 
        }

        
    }
}