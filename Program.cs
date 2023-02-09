// 3 lados de um triângulo
//validar os lados e depois dizer o tipo do triângulo
float lado1;
float lado2;
float lado3;

Console.WriteLine("Olá, vamos validar um triângulo. Para isso, a seguir, digite o valor dos três lados.");
Console.WriteLine("Digite o valor do lado 1:");
lado1 = float.Parse(Console.ReadLine());
Console.WriteLine("Agora digite o valor do lado 2:");
lado2 = float.Parse(Console.ReadLine());
Console.WriteLine("Por fim, digite o valor do lado 3:");
lado3 = float.Parse(Console.ReadLine());
if((lado1 + lado2) > lado3 && (lado3 + lado2) > lado1 && (lado3 + lado1) > lado2){
    Console.WriteLine("Não formam um triângulo");
    return;
}
Console.WriteLine("Os lados formam um triângulo!");
if(lado1 == lado2 && lado2 == lado3 && lado1 == lado3){
    Console.WriteLine("As medidas formam um triângulo equilátero (três lados iguais).");
}
else if(lado1 == lado2 || lado2 == lado3 || lado1 == lado3){
    Console.WriteLine("As medidas formam um triângulo isósceles (quaisquer dois lados iguais).");
}
else if(lado1 != lado2 && lado2 != lado3 && lado1 != lado3){
    Console.WriteLine("As medidas formam um triângulo escaleno (três lados diferentes).");
}

