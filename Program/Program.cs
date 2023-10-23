/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * PR1. Joc de Batalla d'Herois vs Monstre
 *
 */

using System;

namespace GameProject
{
    public class SanchoJordiCode
    {
        public static void Main()
        {
            const string MSGWelcome = "Benvingut a Herois vs Monstre!";
            const string MSGDoYouWant = "Que vols fer?";
            const string MSGDoYouWantError = "Introdueix un valor entre el 1 o el 2, Que vols fer?";
            const string MSGDoYouWantYes = "1. Jugar!";
            const string MSGDoYouWantQuit = "2. Sortir";

            /* Constantes valores Max i Min de los atributos */
            const int HpMinArcher = 1500, HpMaxArcher = 2000;
            const int AtkMinArcher = 180, AtkMaxArcher = 300;
            const int DamageReductionMinArcher = 25, DamageReductionMaxArcher = 40;

            const int HpMinBarbarian = 3000, HpMaxBarbarian = 3750;
            const int AtkMinBarbarian = 150, AtkMaxBarbarian = 250;
            const int DamageReductionMinBarbarian = 35, DamageReductionMaxBarbarian = 45;

            const int HpMinMagician = 1000, HpMaxMagician = 1500;
            const int AtkMinMagician = 300, AtkMaxMagician = 350;
            const int DamageReductionMinMagician = 20, DamageReductionMaxMagician = 35;

            const int HpMinDruid = 2000, HpMaxDruid = 2500;
            const int AtkMinDruid = 70, AtkMaxDruid = 120;
            const int DamageReductionMinDruid = 25, DamageReductionMaxDruid = 40;

            const int HpMinMonster = 9000, HpMaxMonster = 12000;
            const int AtkMinMonster = 250, AtkMaxMonster = 400;
            const int DamageReductionMinMonster = 20, DamageReductionMaxMonster = 30;


            /* MSG Creacion heroes i monstruo + MSG Introducir valores heroes i mosntruo */
            const string MSGStartGame = "Perfecte! Comencem a crear presonatges:";

            const string MSGCreateArcher = "Primer personatge: Arquera. ";
            const string MSGSetHpArcher = "Vida [1500-2000]: ";
            const string MSGSetAtkArcher = "Atac [180-300]: ";
            const string MSGSetDamageReductionArcher = "Reducció de dany (valor percentual) [25-40] %: ";
            
            const string MSGCreateBarbarian = "Primer personatge: Bàrbar. ";
            const string MSGSetHpBarbarian = "Vida [3000-3750]: ";
            const string MSGSetAtkBarbarian = "Atac [150-250]: ";
            const string MSGSetDamageReductionBarbarian = "Reducció de dany (valor percentual) [35-45] %: ";
            
            const string MSGCreateMagician = "Primer personatge: Maga. ";
            const string MSGSetHpMagician = "Vida [1000-1500]: ";
            const string MSGSetAtkMagician = "Atac [300-350]: ";
            const string MSGSetDamageReductionMagician = "Reducció de dany (valor percentual) [20-35] %: ";
            
            const string MSGCreateDruid = "Primer personatge: Druida. ";
            const string MSGSetHpDruid = "Vida [2000-2500]: ";
            const string MSGSetAtkDruid = "Atac [70-120]: ";
            const string MSGSetDamageReductionDruid = "Reducció de dany (valor percentual) [25-40] %: ";
            
            const string MSGCreateMonster = "Ara toca el Monstre. ";
            const string MSGSetHpMonster = "Vida [9000-12000]: ";
            const string MSGSetAtkMonster = "Atac [250-400]: ";
            const string MSGSetDamageReductionMonster = "Reducció de dany (valor percentual) [20-30] %: ";

            const string MSGRequieredValues = "Introdueix els valors requerits:";
            
            const string MSGSetError = "Error, no has introduit un valor dins del rang especificat. Torna a posarlo: ";
            /* Altres constants */
            const int play = 1;
            const int quit = 2;
            const int zero = 0;

            /* Declaracio variables heroes */
            int hparcher = 0, atkarcher = 0, damagereductionarcher = 0, cooldownhabilityarcher = 5;
            bool specialhabilityarcher = true;

            int hpbarbarian = 0, atkbarbarian = 0, damagereductionbarbarian = 0, cooldownhabilitybarbarian = 5;
            bool specialhabilitybarbarian = true;

            int hpmagician = 0, atkmagician = 0, damagereductionmagician = 0,  cooldownhabilitymagician = 5;
            bool specialhabilitymagician = true;

            int hpdruid = 0, atkdruid = 0, damagereductiondruid = 0,  cooldownhabilitydruid = 5;
            bool specialhabilitydruid = true;

            /* Declaracio variables monstruo*/
            int hpmonster = 0, atkmonster = 0, damagereductionmonster = 0;

            /* Error variables */
            bool errorstartgame = false, game = true, errorSetValueCharacter = false;

            /* Countsdown */
            int countdowntrystartgame = 3;

            int countdowntryCreateCharacter = 3;

            int countdowntrySetHpCharacter = 3;

            int countdowntrySetAtkCharacter = 3;

            int countdowntrySetDamageReductionCharacter = 3;

            /* Altres variables */
            int startgame;


            Console.WriteLine(MSGWelcome);
            while (game)
            {
                errorstartgame = false;
                Console.WriteLine(MSGDoYouWant);
                Console.WriteLine(MSGDoYouWantYes);
                Console.WriteLine(MSGDoYouWantQuit);
                Console.WriteLine("");

                do
                {
                    if (errorstartgame)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(MSGDoYouWantError);
                        Console.WriteLine(MSGDoYouWantYes);
                        Console.WriteLine(MSGDoYouWantQuit);
                        Console.WriteLine("");
                    }
                    startgame = Convert.ToInt32(Console.ReadLine());
                    errorstartgame = true;
                    countdowntrystartgame--;
                } while (startgame != quit && startgame != play && countdowntrystartgame != zero);

                if (startgame == play && countdowntrystartgame != zero)
                {
                    Console.WriteLine("");
                    Console.WriteLine(MSGStartGame);
                    Console.WriteLine("");
                    
                    /* Creacio personatges */

                    countdowntryCreateCharacter = 3;
                        
                    /* Demanar dades usuari Archer */
                    do
                    {
                        countdowntrySetHpCharacter = 3;
                        errorSetValueCharacter = false;
                        Console.WriteLine(MSGCreateArcher);
                        Console.WriteLine(MSGRequieredValues);
                        Console.WriteLine(MSGSetHpArcher);
                        Console.WriteLine("");
                        do
                        {
                            if (errorSetValueCharacter) 
                            {
                                Console.WriteLine("");
                                Console.WriteLine(MSGSetError);
                                Console.WriteLine(MSGRequieredValues);
                                Console.WriteLine(MSGSetHpArcher);
                                Console.WriteLine("");
                            }
                            hparcher = Convert.ToInt32(Console.ReadLine());
                            errorSetValueCharacter = true;
                            countdowntrySetHpCharacter--;

                        } while (!(hparcher >= HpMinArcher && hparcher <= HpMaxArcher && countdowntrySetHpCharacter != zero));

                        /* Cuando sea distinta a 0 significa que no a utilizado los 3 intentos asi que pone el otro valor*/
                        
                        if (countdowntrySetHpCharacter != zero)
                        {
                            countdowntrySetAtkCharacter = 3;
                            errorSetValueCharacter = false;
                            Console.WriteLine(MSGSetAtkArcher);
                            do
                            {
                                if (errorSetValueCharacter)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(MSGSetError);
                                    Console.WriteLine(MSGSetAtkArcher);
                                    Console.WriteLine("");
                                }
                                atkarcher = Convert.ToInt32(Console.ReadLine());
                                errorSetValueCharacter = true;
                                countdowntrySetAtkCharacter--;

                            } while (!(atkarcher >= AtkMinArcher && atkarcher <= AtkMaxArcher && countdowntrySetAtkCharacter != zero));

                            if (countdowntrySetAtkCharacter != zero)
                            {
                                countdowntrySetDamageReductionCharacter = 3;
                                errorSetValueCharacter = false;
                                Console.WriteLine(MSGSetDamageReductionArcher);
                                do
                                {
                                    if (errorSetValueCharacter)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine(MSGSetError);
                                        Console.WriteLine(MSGSetDamageReductionArcher);
                                        Console.WriteLine("");
                                    }
                                    damagereductionarcher = Convert.ToInt32(Console.ReadLine());
                                    errorSetValueCharacter = true;
                                    countdowntrySetDamageReductionCharacter--;

                                } while (!(damagereductionarcher >= DamageReductionMinArcher && damagereductionarcher <= DamageReductionMaxArcher && countdowntrySetDamageReductionCharacter != zero));
                            }
                        }
                        countdowntryCreateCharacter--;
                    } while (false);
                } else
                {
                    game = false;
                }
            }
        }
    }
}
