// See https://aka.ms/new-console-template for more information

string[] investimentos = new string[5] {"CDB", "Acoes", "Fundos Imobiliarios", "Stocks", "Reits"};
int[] percentual = new int[5]; // Percentual indicado que eu quero aplicar %
int [] valoresAplicados = new int[5]; // Valor que eu ja tenho aplicado R$
int[] percentualAtual = new int[5]; // Percentual do meu valor ja aplicado em dinheiro %
int[] diferença = new int[5]; //guardando a diferença entre o percentual - percentualAtual %
int somaPercentual = 0;
int somaInvestimentos = 0;
int maiorNumero = 0;
string discrepancia = "";

Console.WriteLine("-----------Passo 1-----------");
Console.WriteLine("-----Valores Percentuais-----");

while(somaPercentual != 100) {

    for (int i = 0; i < investimentos.Length; i++)
    {
        Console.WriteLine("Qual a % você gostaria de investir em " + investimentos[i] + ": ");
        percentual[i] = Convert.ToInt32(Console.ReadLine());
        somaPercentual = somaPercentual + percentual[i];
    }
    
    if(somaPercentual != 100)
    {
        Console.WriteLine("A soma do percentual é diferente de 100%, insira novamente!!!");
       
    }

}

Console.WriteLine("-----------Passo 2-----------");
Console.WriteLine("-----Valores em Reais--------");

for (int i = 0; i < investimentos.Length; i++)
{
    Console.WriteLine("Qual o valor você ja tem investido em " + investimentos[i] + ": R$ ");
    valoresAplicados[i] = Convert.ToInt32(Console.ReadLine());
    somaInvestimentos = somaInvestimentos + valoresAplicados[i];
    
}

for (int i = 0; i < investimentos.Length; i++)
{
    percentualAtual[i] = (valoresAplicados[i] * 100) / somaInvestimentos;
}

Console.WriteLine("-----------Passo 3-----------");
Console.WriteLine("-----Imprimindo Valores--------");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Valor pretendido em " + investimentos[i] + ": " + percentual[i]);
    Console.WriteLine("Valor atual investido em " + investimentos[i] + " é de: " + percentualAtual[i]);

    if (percentual[i] > percentualAtual[i])
    {
        diferença[i] = percentual[i] - percentualAtual[i];
    }
    else
    {
        diferença[i] = percentualAtual[i] - percentual[i];
    }
    if (diferença[i] > maiorNumero)
    {
        maiorNumero = diferença[i];
        discrepancia = investimentos[i];
    };

}

Console.WriteLine("-----------Passo 4-----------");

Console.WriteLine("A maior diferença esta no ativo: " + discrepancia + " com " + maiorNumero + " % de diferença.");

Console.ReadLine();