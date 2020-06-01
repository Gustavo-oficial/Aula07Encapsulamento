namespace Aula7Encapsulamento
{
    public class Cartao
    {
    public string numero { get; set; }
	public string bandeira { get; set; }

    public string usuario;
	private string token { get; set; }
	protected int cvc { get; set; }

     public string AprovarCompra(){
        return "Compra aprovada!";
     }
	private bool ValidarToken(string validacaoToken){

        if(validacaoToken != null && validacaoToken == ""){
           return false;
        }
          return true;
    }
	protected bool ValidarCompra(){
        return true;
    }
    }
}