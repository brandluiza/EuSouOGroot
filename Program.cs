﻿string Pergunta;

Console.Clear();


Console.WriteLine("--- Conversa com o Groot ---");

while (true)

{
    Console.Write("Pergunta: ");
    Pergunta = Console.ReadLine().ToLower();


    if (Pergunta == "tchau") 
    {
        Console.WriteLine("         Resposta: Eu sou Groot.");


        return;


    }
    else 
    {
        Console.WriteLine("         Resposta: Eu sou Groot.");
        
    }

};