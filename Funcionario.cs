namespace POO{

    public class Funcionario{

        public string vendedores = ""; 

        public string gerente = ""; 


        public string GetVendedores(){
            return vendedores; 
        }
        public void SetVendedores(string vendedores){
            this.vendedores = vendedores; 
        }
        public string GetGerente(){
            return gerente; 
        }
        public void SetGerente(string gerente){
            this.gerente = gerente; 
        }
    }
}