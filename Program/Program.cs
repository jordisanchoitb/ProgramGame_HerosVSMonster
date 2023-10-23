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
            const string MSGDoYouWantError = "Introdueix un valor entre el 1 o el 0, Que vols fer?";
            const string MSGDoYouWantYes = "1. Jugar!";
            const string MSGDoYouWantQuit = "0. Sortir";
            
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
            bool errorstartgame = false, game = true, errorSetValueArcher = false;

            /* Countsdown */
            int countdowntrystartgame = 3;

            int countdowntryCreateCharacters = 3;

            int countdowntryCreateArcher = 3, countdowntryCreateBarbarian = 3, countdowntryCreateMagician = 3, countdowntryCreateDruid = 3, countdowntryCreateMonster = 3;

            int countdowntrySetValuesArcher = 3, countdowntrySetHpBarbarian = 3, countdowntrySetHpMagician = 3, countdowntrySetHpDruid = 3, countdowntrySetHpMonster = 3;

            int countdowntrySetAtkBarbarian = 3, countdowntrySetAtkMagician = 3, countdowntrySetAtkDruid = 3, countdowntrySetAtkMonster = 3;

            int countdowntrySetDamageReductionBarbarian = 3, countdowntrySetDamageReductionMagician = 3, countdowntrySetDamageReductionDruid = 3, countdowntrySetDamageReductionMonster = 3;

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
                } while (startgame != 0 && startgame != 1 && countdowntrystartgame != 0);

                if (startgame == 1 && countdowntrystartgame != 0)
                {
                    countdowntryCreateCharacters = 3;
                    Console.WriteLine("");
                    Console.WriteLine(MSGStartGame);
                    Console.WriteLine("");
                    
                    /* Creacio personatges */

                    countdowntryCreateArcher = 3; countdowntrySetValuesArcher = 3;  
                        
                    countdowntryCreateBarbarian = 3; countdowntrySetHpBarbarian = 3; countdowntrySetAtkBarbarian = 3; countdowntrySetDamageReductionBarbarian = 3;  
                        
                    countdowntryCreateMagician = 3; countdowntrySetHpMagician = 3; countdowntrySetAtkMagician = 3; countdowntrySetDamageReductionMagician = 3;  
                        
                    countdowntryCreateDruid = 3; countdowntrySetHpDruid = 3; countdowntrySetAtkDruid = 3; countdowntrySetDamageReductionDruid = 3;  
                        
                    countdowntryCreateMonster = 3; countdowntrySetHpMonster = 3; countdowntrySetAtkMonster = 3; countdowntrySetDamageReductionMonster = 3; 

                    /* Demanar dades usuari Archer */
                    do
                    {
                        errorSetValueArcher = false;
                        Console.WriteLine(MSGCreateArcher);
                        Console.WriteLine(MSGRequieredValues);
                        Console.WriteLine(MSGSetHpArcher);
                        Console.WriteLine(MSGSetAtkArcher);
                        Console.WriteLine(MSGSetDamageReductionArcher);
                        Console.WriteLine("");
                        do
                        {
                            if (errorSetValueArcher) 
                            {
                                Console.WriteLine("");
                                Console.WriteLine(MSGSetError);
                                Console.WriteLine(MSGRequieredValues);
                                Console.WriteLine(MSGSetHpArcher);
                                Console.WriteLine(MSGSetAtkArcher);
                                Console.WriteLine(MSGSetDamageReductionArcher);
                                Console.WriteLine("");
                            }
                            hparcher = Convert.ToInt32(Console.ReadLine());
                            atkarcher = Convert.ToInt32(Console.ReadLine());
                            damagereductionarcher = Convert.ToInt32(Console.ReadLine());
                            errorSetValueArcher = true;
                            countdowntrySetValuesArcher--;
                        } while (!((hparcher >= 1500 && hparcher <= 2000) && (atkarcher >= 180 && atkarcher <= 300) && (damagereductionarcher >= 25 && damagereductionarcher <= 40) && (countdowntrySetValuesArcher != 0)));




                    } while (false);
                } else
                {
                    game = false;
                }
            }
        }
    }
}
