//_________________________________________________________________SEQUÊNCIAS BÁSICAS__________________________________________________________
using System.Globalization; //(utilizado para se usar ponto ao invés de vírgula)
Console.WriteLine("_________________________________________________________________SEQUÊNCIAS BÁSICAS__________________________________________________________");
//1) Escreva um programa que mostre na tela a mensagem "Olá, Mundo!"
string who = "Mundo!";
Console.WriteLine($"Olá, {who}");
Console.WriteLine();
//_____________________________________________________________________________________________________________________________________________


//2) Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boas vindas para ela:
Console.Write("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Seja muito bem vindo {name}!");
Console.WriteLine();
//_____________________________________________________________________________________________________________________________________________


//3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no final uma mensagem.
Console.WriteLine("Cadastre o nome e o salário do funcionário:");
Console.Write("Nome: ");
string name1 = Console.ReadLine();
Console.Write("Salário (Utilize a vírgula): R$");
decimal salary1 = decimal.Parse(Console.ReadLine());

Console.WriteLine($"O funcionário {name1} tem um salário de R${salary1} neste mês");
Console.WriteLine();
//_____________________________________________________________________________________________________________________________________________


//4) Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório entre eles.
Console.WriteLine("Você quer saber qual a soma de dois valores? Digite o primeiro numero (sem vírgula ou ponto):");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero (sem vírugula ou ponto):");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine($"A soma entre {number1} e {number2} é igual a {number1 + number2}.");
Console.WriteLine();
//_____________________________________________________________________________________________________________________________________________


//5) Faça um programa que leia as duas notas de um aluno em uma matéria e mostre na tela a sua média na disciplina.
Console.WriteLine("Para saber a média das notas de um aluno digite a primeira nota (Utilize ponto ao invés de vírgula):");
double note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Digite a segunda nota:");
double note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double avarage = (note1 + note2) / 2;
Console.WriteLine($"A média entre {note1} e {note2} é igual a {avarage.ToString("F1", CultureInfo.InvariantCulture)}");
Console.WriteLine();
//_____________________________________________________________________________________________________________________________________________


//6) Faça um programa que leia um número inteiro e mostre o seu antecessor e seu sucessor.
Console.WriteLine("Descubra o antecessor e sucessor de um numero. Digite um numero (sem vírgula):");
int number = int.Parse(Console.ReadLine());

int predecessor = number-1;
int successor = number+1;

Console.WriteLine($"O antecessor de {number} é {predecessor}");
Console.WriteLine($"O sucessor de {number} é {successor}");
Console.WriteLine();
//_____________________________________________________________________________________________________________________________________________


//7) Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a sua terça parte.
Console.WriteLine("Para saber o dobro e a terça parte de um numero. Digite um numero:");
double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double numbermult2 = number * 2;
double numberdiv3 = number / 3;

Console.WriteLine($"O dobro de {number.ToString(CultureInfo.InvariantCulture)} é {numbermult2.ToString(CultureInfo.InvariantCulture)}");
Console.WriteLine($"A terça parte de {number.ToString(CultureInfo.InvariantCulture)} é {numberdiv3.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine();
//_____________________________________________________________________________________________________________________________________________


//8) Desenvolva um programa que leia uma distância em metros e mostre os valores relativos em outras medidas.
Console.WriteLine("Para converter Metros para outras unidades de medida, digite a distância (em metros):");
double distance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double km = distance / 1000;
double hm = distance / 100;
double dam = distance / 10;
double dm = distance * 10;
double cm = distance * 100;
double mm = distance * 1000;

Console.WriteLine($"A distância de {distance.ToString("F2", CultureInfo.InvariantCulture)} corresponde a: ");
Console.WriteLine($"{km.ToString("F5", CultureInfo.InvariantCulture)} Km                {dm.ToString("F3", CultureInfo.InvariantCulture)} dm");
Console.WriteLine($"{hm.ToString("F4", CultureInfo.InvariantCulture)} Hm                {cm.ToString("F2", CultureInfo.InvariantCulture)} cm");
Console.WriteLine($"{dam.ToString("F3", CultureInfo.InvariantCulture)} Dam               {mm.ToString("F1", CultureInfo.InvariantCulture)} mm");
Console.WriteLine();
//_____________________________________________________________________________________________________________________________________________


//9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45.
decimal usd_brl = 3.45m;

Console.WriteLine("Para saber quantos dólares você pode comprar, digite a quantidade em reais:");
decimal reais = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
decimal dol = reais / usd_brl;

Console.WriteLine($"Com R${reais.ToString("F2", CultureInfo.InvariantCulture)} reais. Você pode comprar U${dol.ToString("F2", CultureInfo.InvariantCulture)} dólares.");
Console.WriteLine();
//_____________________________________________________________________________________________________________________________________________


//10) Faça um algoritmo que leia a largura e altura de uma parede, calcule e mostre a área a ser pintada e a quantidade de tinta necessária para o serviço, sabendo que cada litro de tinta pinta uma área de 2metros quadrados.
Console.Write("Para saber a area e quanto em tinta será necessário digite a largura da parede: ");
double width = double.Parse(Console.ReadLine());
Console.Write("Agora digite a altura da parede: ");
double height = double.Parse(Console.ReadLine());

double literpersquarmeter = 2.00;
double area = width * height;
double need = area / literpersquarmeter;

Console.WriteLine($"A area a ser pintada é de {area}m² , e será necessário {need}litros de tinta.");
Console.WriteLine();
//_____________________________________________________________________________________________________________________________________________


//11) Desenvolva uma lógica que leia os valores de A, B e C de uma equação do segundo grau e mostre o valor de Delta.
//Encontrando o delta
Console.WriteLine("Digite o valor de A, B e C:");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

double delta = ((double)Math.Pow(b, 2)) - (4 * a) * (c);

Console.WriteLine($"A = {a}, B={b}, C{c};");
Console.WriteLine($"o Delta é {delta}");
Console.WriteLine();
//_____________________________________________________________________________________________________________________________________________


//12) Crie um programa que leia o preço de um produto, calcule e mostre o seu PREÇO PROMOCIONAL, com 5% de desconto.
Console.WriteLine("Digite o preço do produto para ver o preço com o desconto de 5%:");
decimal price = decimal.Parse(Console.ReadLine());

decimal discount = 5 / 100M;
decimal pricewithdiscount = (price * discount);
Console.WriteLine($"O Preço PROMOCIONAL é R${price - pricewithdiscount}");
Console.WriteLine();
//_____________________________________________________________________________________________________________________________________________


//13) Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o seu novo salário, com 15% de aumento.
Console.WriteLine("Digite seu salário para ve seu aumento de 15%:");
decimal salary = decimal.Parse(Console.ReadLine());

decimal increase = 15 / 100M;
decimal salaryIncrease = (salary * increase);
Console.WriteLine($"Seu salário com aumento é R${salary + salaryIncrease}");
Console.WriteLine();
//_____________________________________________________________________________________________________________________________________________


//14) A locadora de carros precisa da sua ajuda para cobrar seus serviços. Escreva um programa que pergunte a quantidade de Km percorridos por um carro alugado e a quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar, sabendo que o carro custa R$90 por dia e R$0,20 por Km rodado.
double costForDay = 90.0;
double costForKm = 0.20;

Console.WriteLine("Para saber o valor do aluguel do seu veículo");
Console.WriteLine("Digite quantos Km's foram percorridos com seu carro alugado:");
double carkm = double.Parse(Console.ReadLine());
Console.WriteLine("Por quantos dias você ficou com o carro?");
double rentalDays = double.Parse(Console.ReadLine());

double totalRent = (costForDay * rentalDays) + (costForKm * km);
Console.WriteLine($"O total a pagar pelo aluguel do carro é R${totalRent.ToString("F2")}");
Console.WriteLine();
//______________________________________________________________________________________________________________________________________________


// 15) Crie um programa que leia o número de dias trabalhados em um mês e mostre o salário de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25 por hora trabalhada.
double dailySalary = 8.00 * 25;

Console.WriteLine("Para saber o salário do funcionário desse mês digite o numero de dias trabalhados");
int workDays = int.Parse(Console.ReadLine());

Console.WriteLine($"O salário do funcionário esse mês é R${dailySalary * workDays}");
Console.WriteLine();
//______________________________________________________________________________________________________________________________________________


//16) [DESAFIO] Escreva um programa para calcular a redução do tempo de vida de um fumante.Pergunte a quantidade de cigarros fumados por dias e quantos anos ele já fumou. Considere que um fumante perde 10 min de vida a cada cigarro. Calcule quantos dias de vida um fumante perderá e exiba o total em dias.
Console.WriteLine("Quer saber quanto tempo de vida esta perdendo ao fumar um cigarro ?");
Console.WriteLine("Digite quantos cigarros você fuma por dia");
int cigarettesPerDay = int.Parse(Console.ReadLine());
Console.WriteLine("Faz quantos anos que você fuma ?");
int yearSmoking = int.Parse(Console.ReadLine());

double lossTimePerDay = (0.1 * 24) * cigarettesPerDay;
double daysLife = (365 * yearSmoking);

Console.WriteLine($"Você reduziu {(lossTimePerDay - daysLife).ToString("F2")} dias de vida");
Console.WriteLine($"{((lossTimePerDay - daysLife) / 365).ToString("F2")} Anos");
//04/2022


