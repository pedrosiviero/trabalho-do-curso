namespace POO{

    public class Venda{

        public string cliente = "";
        public string vendedor = "";

        public string listaProdutos = "";
        public int valorTotal = 0;

        public string GetCliente(){
            return cliente; 
        }
        public void SetCliente(string cliente){
            this.cliente = cliente; 
        }
        public string GetVendedor(){
            return vendedor; 
        }
        public void SetVendedor(string vendedor){
            this.vendedor = vendedor; 
        }
        public string GetListaProdutos(){
            return listaProdutos;
        }
        public void SetListaProduto(string listaProdutos){
            this.listaProdutos = listaProdutos;
        } 
        public int GetValorTotal(){
            return valorTotal; 
        }
        public void SetValorTotal(int valorTotal){
            this.valorTotal = valorTotal; 
        }

        public void InformarDados(){

        Console.WriteLine("Digite o produto: ");
        listaProdutos = Console.ReadLine();

        Console.WriteLine("Digite o valor total: ");
        valorTotal = int.Parse(Console.ReadLine());

        }
    }
}