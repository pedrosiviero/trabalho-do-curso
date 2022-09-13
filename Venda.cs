namespace POO{

    public class Venda{

        public string cliente = "";
        public string vendedor = "";

        public string listaProdutos = "";

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
    }
}