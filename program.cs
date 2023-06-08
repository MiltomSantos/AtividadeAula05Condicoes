using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string name;
        string lastname;
        string endereco;
        string bairro;
        string cidade;
        string estado;
        int viagempassada;
        int viagempresente;
        int soma;
        int media;
        int intervalo;
        string desconto;
        string email;
        
        Console.WriteLine("Olá seja bem-vindo ao sistema de viagens!");
        Console.WriteLine("\nDigite o seu nome");
        name=Console.ReadLine();
        Console.WriteLine("\nDigite o seu sobrenome");
        lastname=Console.ReadLine();
        
        Console.WriteLine($"\nOlá Sr(a) {name} {lastname} vamos continuar o seu cadastro...");
        
        Console.WriteLine("\nDigite o seu endereço:");
        endereco=Console.ReadLine();
        Console.WriteLine("\nDigite o seu bairro:");
        bairro=Console.ReadLine();
        Console.WriteLine("\nDigite a sua cidade:");
        cidade=Console.ReadLine();
        Console.WriteLine("\nDigite a sigla do seu estado em maiusculo:");
        estado=Console.ReadLine();
        
        Console.WriteLine($"\nO Sr(a) {lastname} mora na cidade de {cidade}-{estado}, no endereço {endereco}, localizado no bairro {bairro}");
        
        Console.WriteLine("\nQuantas viagens você fez no ano passado: ");
        viagempassada=Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("\nQuantas viagens você planejou fazer nesse ano: ");
        viagempresente=Int32.Parse(Console.ReadLine());
        
        soma = viagempassada + viagempresente;
        
        Console.WriteLine($"\nVocê já fez {soma} viagens");
        
        if(soma<10){
            Console.WriteLine($"\nFaltam {10 - soma} viagens para voce completar 10 viagens");
        }
        else{
            Console.WriteLine($"\nVocê já completou 10 viagens");
        }
        
        media= soma/2;
        intervalo= 12/viagempresente;
        
        Console.WriteLine($"\nA sua média de viagens é: {media}");
        Console.WriteLine($"\nO seu intervalo de viagens em meses nesse ano é: {intervalo}");
        Console.WriteLine($"\nObrigado {name}, o seu cadstro foi realizado com sucesso!");
        
        Console.WriteLine("\nDigite o seu Cupom de desconto:");
        desconto=Console.ReadLine();
        
        if(desconto == "Conradito10"){
            Console.WriteLine("\nParabéns, você ganhou 10% de desconto na sua próxima viagem");
        }
        else{
            Console.WriteLine("\nEste Cupom não existe");
        }
        
       Console.WriteLine("\nVocê gostaria de receber promoções no e-mail? digite 'S' para sim e 'N' para não");
       email=Console.ReadLine();
       
       if(email=="S"){
           Console.WriteLine($"\nObrigado {name} por se registrar, você recebera novos emails em breve");
       }
       else{
           Console.WriteLine("\nOk, você não recebera emails de promoções");
       }
       
       Console.WriteLine("\nObrigado e volte sempre");
        
        Console.ReadKey();
        
    }
}
