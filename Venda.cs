namespace POO{

    public class Venda{

        public Cliente cliente;
        public Vendedor vendedor;

        public string listaProdutos = "";
        public int valorTotal = 0;

        public Cliente GetCliente(){
            return cliente; 
        }
        public void SetCliente(Cliente cliente){
            this.cliente = cliente; 
        }
        public Vendedor GetVendedor(){
            return vendedor; 
        }
        public void SetVendedor(Vendedor vendedor){
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

        Console.WriteLine("Agora vamos cadastrar seu produto.\nDigite o produto: ");
        listaProdutos = Console.ReadLine();
        
        }
    }
}