namespace POO{


    public class Produto{

        public string codigo = "";
        public string marca = ""; 
        public string descricao = "";
        public int valorUnidade = 0;

        public string GetCodigo(){
            return codigo; 
        }
        public void SetCodigo(string codigo){
            this.codigo = codigo; 
        }
        public string GetMarca(){
            return marca; 
        }
        public void SetMarca(string marca){
            this.marca = marca; 
        }
        public string GetDescricao(){
            return descricao; 
        }
        public void SetDescricao(string descricao){
            this.descricao = descricao; 
        }
        public int GetValorUnidade(){
            return valorUnidade; 
        }
        public void SetValorUnidade(int valorUnidade){
            this.valorUnidade = valorUnidade; 
        }

        public void InformarDados(){

            Console.WriteLine("Digite o código: ");
            codigo = Console.ReadLine();

            Console.WriteLine("Digite a marca: ");
            marca = Console.ReadLine();

            Console.WriteLine("Digite a descrição: ");
            descricao = Console.ReadLine();

            Console.WriteLine("Digite o valor da unidade: ");
            valorUnidade = int.Parse(Console.ReadLine());

        }

    }
}