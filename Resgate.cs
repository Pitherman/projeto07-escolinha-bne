using System;

class Proporcional
{
    public double valorPresente;
    public double taxa;
    public int mes = 1;
    double valorSaque;
    double saldo;
    double rendimento;


    public double valorF()
    {
        return (valorPresente*Math.Pow((1+taxa/100), mes));
    }


    public void tabela()
    {
        int counter = 1;
        Console.WriteLine("\n_______________________________________________________________________________________________");
        while (counter <= 8)
        {

            rendimento = Math.Round(valorF(), 2);
            double liquido = rendimento - valorPresente;
            Console.WriteLine("["+counter+"º mês] Valor aplicado: R$"+valorPresente+" | Taxa: "+taxa+"% | Rendimento: R$"+rendimento.ToString("0.00")+" | Rendimento Líquido: "+liquido.ToString("0.00")+"");
            counter++;
            
            if(counter == 6)
            {
                Console.WriteLine("Qual o valor do saque?");
                valorSaque = Convert.ToDouble(Console.ReadLine());
                saldo = rendimento - valorSaque;
                //Console.WriteLine("["+mes+"º mês] Valor aplicado: R$"+valorPresente+" | Taxa: "+taxa+"% | Rendimento: R$"+rendimento.ToString("0.00")+" | Rendimento Líquido: R$"+liquido.ToString("0.00")+" |");
                valorPresente = rendimento - valorSaque;
                mes = 0;
            }

            if(counter > 8)
            {
                double parcial;
                parcial = (valorPresente*Math.Pow((1+taxa), 3.3));
                Console.WriteLine("_______________________________________________________________________________________________");
                Console.WriteLine("\n-[8º mês e 10 dias] Valor aplicado: R$"+valorPresente+" | Taxa: "+taxa+"% | Rendimento: R$"+ ((double)Math.Round(parcial, 2)).ToString("0.00")+" | Rendimento Líquido: "+ ((double)((double)Math.Round(parcial, 2) - valorPresente)).ToString("0.00")+"-\n\n");
            }
            mes++;
        }
        
    }
}