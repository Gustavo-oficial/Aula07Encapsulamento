namespace Aula7Encapsulamento
{
    public class Mastercard : Cartao
    {
    public int parcelas { get; set; }
	public void ComprarComDescontoMastercard(float desconto){
        System.Console.WriteLine($"Aplicado desconto de {desconto}%, diante de {parcelas} parcelas");
    }

    }
}