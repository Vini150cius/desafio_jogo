using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_DS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string user01;
            string user02;
            int persoUm = 0;
            int persoDois = 0;
            int golpeUm = 0;
            int vidaUm = 0;
            int defUm = 0;
            int golpeDois = 0;
            int vidaDois = 0;
            int defDois = 0;
            int acaoUm = 0;
            int acaoDois = 0;
            int defChancesUm = 0;
            int defChancesDois = 0;
            int chanceUm = 1;
            int chanceDois = 1;
            int chanceCuraUm = 3;
            int chanceCuraDois = 3;
            bool ganhaUm = false;
            bool ganhaDois = false;

            //Regrinhas
            Console.WriteLine("Jogo de batalha em turnos para dois jogadores."); 
            Console.WriteLine(); 
            Console.WriteLine("Escolham seus personagens. Cada personagem tem atributos diferentes e secretos."); 
            Console.WriteLine("Vocês podem atacar o adversário, mas cada personagem tem um dano diferente."); 
            Console.WriteLine("É possível se curar, mas só poderá se curar 3 vezes e a cada cura o personagem recupera 5 pontos de vida.");
            Console.WriteLine("A defesa também dependerá do seu personagem e só pode ser usada uma só vez."); 
            Console.WriteLine("Caso deseje esperar os próximos passos do seu inimigo, poderá aguardar sem fazer nenhuma ação."); 
            Console.WriteLine();
            Console.WriteLine("Te desejamos um bom jogo!"); 
            Console.WriteLine("Criadores: Raphael Scapin Pereira e Vinícius de Lúcio Porto"); 
            Console.WriteLine(); 

            //Nome do usuário
            Console.WriteLine("Por favor, insira o nome do usuário do primeiro jogador.");
            user01 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Por favor, insira o nome do usuário do segundo jogador.");
            user02 = Console.ReadLine();
            Console.WriteLine();

            //escolha de personagem do usuário 01
            Console.WriteLine($"{user01}, escolha um dos personagens");
            Console.WriteLine();
            
            while (persoUm <= 0 || persoUm > 4)
            {
                Console.WriteLine("1. Tabata Nunes");
                Console.WriteLine("2. João Guilherme");
                Console.WriteLine("3. Cristina Ribeiro");
                Console.WriteLine("4. Sônia Guimarães");
                Console.WriteLine();
                Console.Write("Personagem: ");
                persoUm = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (persoUm <= 0 || persoUm > 4) {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Personagem inválido, escolha os personagens entre 1 a 4");
                    Console.ResetColor();
                }
            }
            

            switch (persoUm)
            {
                case 1:
                    golpeUm = 3;
                    vidaUm = 44;
                    defUm = 3;
                break;
               
                case 2:
                    golpeUm = 5;
                    vidaUm = 27;
                    defUm = 2;
                break;

                case 3:
                    golpeUm = 7;
                    vidaUm = 24;
                    defUm = 1;
                break;

                case 4:
                    golpeUm = 1;
                    vidaUm = 60;
                    defUm = 4;
                break;

                default:

                    break;

            }

            //escolha de personagem do usuário 02
            Console.WriteLine($"{user02}, escolha um dos personagens");
            Console.WriteLine();

            while (persoDois <= 0 || persoDois > 4)
            {
                Console.WriteLine("1. Tabata Nunes");
                Console.WriteLine("2. João Guilherme");
                Console.WriteLine("3. Cristina Ribeiro");
                Console.WriteLine("4. Sônia Guimarães");
                Console.WriteLine();
                Console.Write("Personagem: ");
                persoDois = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (persoDois <= 0 || persoDois > 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Personagem inválido, escolha os personagens entre 1 a 4");
                    Console.ResetColor();
                }
            }

            switch (persoDois)
            {
                case 1:
                    golpeDois = 3;
                    vidaDois = 44;
                    defDois = 3;
                    break;

                case 2:
                    golpeDois = 5;
                    vidaDois = 27;
                    defDois = 2;
                    break;

                case 3:
                    golpeDois = 7;
                    vidaDois = 24;
                    defDois = 1;
                    break;

                case 4:
                    golpeDois = 1;
                    vidaDois = 60;
                    defDois = 4;
                    break;

                default:

                    break;
            }

            
            //batalha entre os usuários
            while (vidaUm >= 0 || vidaDois >= 0)
            {
               
                while (acaoUm < 1 || acaoUm > 4)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Vez de {user01}");
                    Console.WriteLine("Escolha a ação: ");
                    Console.WriteLine();
                    Console.WriteLine("1. Atacar");
                    Console.WriteLine("2. Se curar");
                    Console.WriteLine("3. Defender");
                    Console.WriteLine("4. Esperar");
                    Console.WriteLine();
                    Console.Write($"Ação do {user01}: ");
                    acaoUm = int.Parse(Console.ReadLine());

                    if (acaoUm <= 0 || acaoUm > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Golpe invalido, escolha um golpe entre 1 a 4");
                        Console.ResetColor();
                    }
                }

                switch (acaoUm)
                {
                    case 1:
                        vidaDois = vidaDois - golpeUm;
                    break;

                    case 2:
                        if (chanceCuraUm > 0)
                        {
                            vidaUm = vidaUm + 5;
                            chanceCuraUm--;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A cura já foi usada");
                            Console.ResetColor();
                        }
                        
                    break;
                    
                    case 3:
                        if (chanceUm > 0)
                        {
                            defChancesUm++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A defesa já foi usada");
                            Console.ResetColor();

                        }
                    break;

                    case 4:

                    break;

                }

                if (vidaDois < 1)
                {
                    ganhaUm = true;
                }

                while (acaoDois < 1 || acaoDois > 4)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Vez de {user02}");
                    Console.WriteLine("Escolha a ação: ");
                    Console.WriteLine();
                    Console.WriteLine("1. Atacar");
                    Console.WriteLine("2. Se curar");
                    Console.WriteLine("3. Defender");
                    Console.WriteLine("4. Esperar");
                    Console.WriteLine();
                    Console.Write($"Ação do {user02}: ");
                    acaoDois = int.Parse(Console.ReadLine());

                    if (acaoDois <= 0 || acaoDois > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Golpe invalido, escolha um golpe entre 1 a 4");
                        Console.ResetColor();
                      
                    }
                }

                switch (acaoDois)
                {
                    case 1:
                        vidaUm = vidaUm - golpeDois;
                        break;

                    case 2:
                        if (chanceCuraDois > 0)
                        {
                            vidaDois = vidaDois + 5;
                            chanceCuraDois--;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A cura já foi usada");
                            Console.ResetColor();
                        }
                        break;

                    case 3:
                        if (chanceDois > 0)
                        {
                            defChancesDois++;
                        }
                        else
                        {
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("A defesa já foi usada");
                            Console.ResetColor();
                        }
                    break;

                    case 4:

                    break;

                }

                if (vidaUm < 1)
                {
                    ganhaDois = true;
                }

                if (ganhaDois == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Parabéns!! O jogador {user02} foi o ganhador dessa vez");
                    Console.ResetColor();
                    break;
                }
                else if (ganhaUm == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Parabéns!! O jogador {user01} foi o ganhador dessa vez");
                    Console.ResetColor();
                    break;
                }

                //verifica se o jogador usou a defesa e faz ela funcionar
                if (defChancesUm > 0)
                {
                    vidaUm = vidaUm + defUm;
                    defChancesUm= 0;
                    chanceUm= 0;
                }
                if (defChancesDois > 0)
                {
                    vidaDois = vidaDois + defDois;
                    defChancesDois = 0;
                    chanceDois= 0;

                }

                //Mostra a vida dos personagens 
                Console.WriteLine($"Vida do {user01} é de {vidaUm}");
                Console.WriteLine($"Vida do {user02} é de {vidaDois}");

                acaoUm = 0;
                acaoDois = 0;


            }
        }
    }
}
