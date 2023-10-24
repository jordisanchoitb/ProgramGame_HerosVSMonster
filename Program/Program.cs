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
            const string MSGPressToContinue = "Toca una tecla para continuar.";

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
            const string MSGStartCreateCharacters = "Perfecte! Comencem a crear presonatges:";
            const string MSGStartBattle = "Comença la batalla!";
            const string MSGTurn = "Torn ";
            const string MSGTwoPoints = ":";

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
            
            /* MSG Accions Heroes i MSG Monstre */
            const string MSGActionArcher = "Arquera. Selecciona l’acció:";
            const string MSGActionBarbarian = "Bàrbar. Selecciona l’acció:";
            const string MSGActionMagician = "Maga. Selecciona l’acció:";
            const string MSGActionDruid = "Druida. Selecciona l’acció:";
            const string MSGActionMonster = "El Monstre ataca a tots els herois:";
            const string MSGActionAtk = "1. Atacar";
            const string MSGActionProtect = "2. Protegir-se";
            const string MSGActionEspecialHability = "3. Habilitat especial";
            const string MSGErrorAction = "El valor introduit no es correcta. Torna a provar.";
            const string MSGActionCountDownEqual0 = "El valor introduit no es correcta. S’han acabat els intents. Adéu";

            const string MSGWinHeros = "El monstre a mort, han guanyat el heroes!!!!";
            const string MSGWinMonster = "Tots els heroes han mort, ha guanyat el monstre.";



            /* Altres constants */
            const int actionatk = 1;
            const int actionprotection = 2;
            const int actionespecialhability = 3;
            const int play = 1;
            const int quit = 2;
            const int zero = 0;
            const int one = 1;
            const int three = 3;



            /* Declaracio variables heroes */
            int hparcher = 0, atkarcher = 0, damagereductionarcher = 0, cooldownhabilityarcher = 5;
            bool specialhabilityarcher = true;

            int hpbarbarian = 0, atkbarbarian = 0, damagereductionbarbarian = 0, cooldownhabilitybarbarian = 5;
            bool specialhabilitybarbarian = true;

            int hpmagician = 0, atkmagician = 0, damagereductionmagician = 0, cooldownhabilitymagician = 5;
            bool specialhabilitymagician = true;

            int hpdruid = 0, atkdruid = 0, damagereductiondruid = 0, cooldownhabilitydruid = 5;
            bool specialhabilitydruid = true;

            /* Declaracio variables monstruo*/
            int hpmonster = 0, atkmonster = 0, damagereductionmonster = 0;

            /* Error variables */
            bool errorstartgame = false, game = true, errorSetValueCharacter = false, errorActionGame = false;

            /* Countsdown */
            int countdowntrystartgame = 3;

            int countdowntryCreateCharacter = 3;

            int countdowntrySetHpCharacter = 3;

            int countdowntrySetAtkCharacter = 3;

            int countdowntrySetDamageReductionCharacter = 3;

            int countdowntryAction = 3;

            /* Altres variables */
            int startgame, battleturns, useraction;


            Console.WriteLine(MSGWelcome);
            while (game)
            {
                countdowntrystartgame = three;
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
                    Console.WriteLine(MSGStartCreateCharacters);
                    Console.WriteLine("");

                    /* Creacio personatges */

                    countdowntryCreateCharacter = three;

                    /* Demanar dades heroe Archer */
                    do
                    {
                        countdowntrySetHpCharacter = three;
                        errorSetValueCharacter = false;
                        Console.WriteLine(MSGCreateArcher);
                        Console.WriteLine(MSGRequieredValues);
                        Console.Write(MSGSetHpArcher);
                        do
                        {
                            if (errorSetValueCharacter)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(MSGSetError);
                                Console.Write(MSGSetHpArcher);
                            }
                            hparcher = Convert.ToInt32(Console.ReadLine());
                            errorSetValueCharacter = true;
                            countdowntrySetHpCharacter--;

                        } while (!(hparcher >= HpMinArcher && hparcher <= HpMaxArcher && countdowntrySetHpCharacter != zero));

                        /* Cuando sea distinta a 0 significa que no a utilizado los 3 intentos asi que pone el otro valor*/

                        if (countdowntrySetHpCharacter != zero)
                        {
                            countdowntrySetAtkCharacter = three;
                            errorSetValueCharacter = false;
                            Console.Write(MSGSetAtkArcher);
                            do
                            {
                                if (errorSetValueCharacter)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(MSGSetError);
                                    Console.Write(MSGSetAtkArcher);
                                }
                                atkarcher = Convert.ToInt32(Console.ReadLine());
                                errorSetValueCharacter = true;
                                countdowntrySetAtkCharacter--;

                            } while (!(atkarcher >= AtkMinArcher && atkarcher <= AtkMaxArcher && countdowntrySetAtkCharacter != zero));

                            if (countdowntrySetAtkCharacter != zero)
                            {
                                countdowntrySetDamageReductionCharacter = three;
                                errorSetValueCharacter = false;
                                Console.Write(MSGSetDamageReductionArcher);
                                do
                                {
                                    if (errorSetValueCharacter)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine(MSGSetError);
                                        Console.Write(MSGSetDamageReductionArcher);
                                    }
                                    damagereductionarcher = Convert.ToInt32(Console.ReadLine());
                                    errorSetValueCharacter = true;
                                    countdowntrySetDamageReductionCharacter--;

                                } while (!(damagereductionarcher >= DamageReductionMinArcher && damagereductionarcher <= DamageReductionMaxArcher && countdowntrySetDamageReductionCharacter != zero));
                            }
                        }
                        countdowntryCreateCharacter--;
                    } while (!((hparcher >= HpMinArcher && hparcher <= HpMaxArcher) && (atkarcher >= AtkMinArcher && atkarcher <= AtkMaxArcher) && (damagereductionarcher >= DamageReductionMinArcher && damagereductionarcher <= DamageReductionMaxArcher) && (countdowntryCreateCharacter != zero)));

                    /* Demanar dades heroe barbar en cas de que el contador de trys crear personatje sigui diferent a 0 que significara que a creat el personatje en menos de 3 intents */
                    if (countdowntryCreateCharacter != zero)
                    {
                        countdowntryCreateCharacter = three;
                        /* Demanar dades heroe Barbar */
                        do
                        {
                            countdowntrySetHpCharacter = three;
                            errorSetValueCharacter = false;
                            Console.WriteLine("");
                            Console.WriteLine(MSGCreateBarbarian);
                            Console.WriteLine(MSGRequieredValues);
                            Console.Write(MSGSetHpBarbarian);
                            do
                            {
                                if (errorSetValueCharacter)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(MSGSetError);
                                    Console.Write(MSGSetHpBarbarian);
                                }
                                hpbarbarian = Convert.ToInt32(Console.ReadLine());
                                errorSetValueCharacter = true;
                                countdowntrySetHpCharacter--;

                            } while (!(hpbarbarian >= HpMinBarbarian && hpbarbarian <= HpMaxBarbarian && countdowntrySetHpCharacter != zero));

                            /* Cuando sea distinta a 0 significa que no a utilizado los 3 intentos asi que pone el otro valor*/

                            if (countdowntrySetHpCharacter != zero)
                            {
                                countdowntrySetAtkCharacter = three;
                                errorSetValueCharacter = false;
                                Console.Write(MSGSetAtkBarbarian);
                                do
                                {
                                    if (errorSetValueCharacter)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine(MSGSetError);
                                        Console.Write(MSGSetAtkBarbarian);
                                    }
                                    atkbarbarian = Convert.ToInt32(Console.ReadLine());
                                    errorSetValueCharacter = true;
                                    countdowntrySetAtkCharacter--;

                                } while (!(atkbarbarian >= AtkMinBarbarian && atkbarbarian <= AtkMaxBarbarian && countdowntrySetAtkCharacter != zero));

                                if (countdowntrySetAtkCharacter != zero)
                                {
                                    countdowntrySetDamageReductionCharacter = three;
                                    errorSetValueCharacter = false;
                                    Console.Write(MSGSetDamageReductionBarbarian);
                                    do
                                    {
                                        if (errorSetValueCharacter)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGSetError);
                                            Console.Write(MSGSetDamageReductionBarbarian);
                                        }
                                        damagereductionbarbarian = Convert.ToInt32(Console.ReadLine());
                                        errorSetValueCharacter = true;
                                        countdowntrySetDamageReductionCharacter--;

                                    } while (!(damagereductionbarbarian >= DamageReductionMinBarbarian && damagereductionbarbarian <= DamageReductionMaxBarbarian && countdowntrySetDamageReductionCharacter != zero));
                                }
                            }
                            countdowntryCreateCharacter--;
                        } while (!((hpbarbarian >= HpMinBarbarian && hpbarbarian <= HpMaxBarbarian) && (atkbarbarian >= AtkMinBarbarian && atkbarbarian <= AtkMaxBarbarian) && (damagereductionbarbarian >= DamageReductionMinBarbarian && damagereductionbarbarian <= DamageReductionMaxBarbarian) && (countdowntryCreateCharacter != zero)));
                        /* Creacio de heroe maga si el barbar ha sigut fet en menos de 3 intents */
                        if  (countdowntrySetHpCharacter != zero) 
                        {
                            countdowntryCreateCharacter = three;
                            /* Demanar dades heroe maga */
                            do
                            {
                                countdowntrySetHpCharacter = three;
                                errorSetValueCharacter = false;
                                Console.WriteLine("");
                                Console.WriteLine(MSGCreateMagician);
                                Console.WriteLine(MSGRequieredValues);
                                Console.Write(MSGSetHpMagician);
                                do
                                {
                                    if (errorSetValueCharacter)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine(MSGSetError);
                                        Console.Write(MSGSetHpMagician);
                                    }
                                    hpmagician = Convert.ToInt32(Console.ReadLine());
                                    errorSetValueCharacter = true;
                                    countdowntrySetHpCharacter--;

                                } while (!(hpmagician >= HpMinMagician && hpmagician <= HpMaxMagician && countdowntrySetHpCharacter != zero));

                                /* Quant es diferent a 0 significa que no ha utilitzat tots els 3 intents aixi que pregunta l'altre valor */

                                if (countdowntrySetHpCharacter != zero)
                                {
                                    countdowntrySetAtkCharacter = three;
                                    errorSetValueCharacter = false;
                                    Console.Write(MSGSetAtkMagician);
                                    do
                                    {
                                        if (errorSetValueCharacter)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGSetError);
                                            Console.Write(MSGSetAtkMagician);
                                        }
                                        atkmagician = Convert.ToInt32(Console.ReadLine());
                                        errorSetValueCharacter = true;
                                        countdowntrySetAtkCharacter--;

                                    } while (!(atkmagician >= AtkMinMagician && atkmagician <= AtkMaxMagician && countdowntrySetAtkCharacter != zero));

                                    if (countdowntrySetAtkCharacter != zero)
                                    {
                                        countdowntrySetDamageReductionCharacter = three;
                                        errorSetValueCharacter = false;
                                        Console.Write(MSGSetDamageReductionMagician);
                                        do
                                        {
                                            if (errorSetValueCharacter)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine(MSGSetError);
                                                Console.Write(MSGSetDamageReductionMagician);
                                            }
                                            damagereductionmagician = Convert.ToInt32(Console.ReadLine());
                                            errorSetValueCharacter = true;
                                            countdowntrySetDamageReductionCharacter--;

                                        } while (!(damagereductionmagician >= DamageReductionMinMagician && damagereductionmagician <= DamageReductionMaxMagician && countdowntrySetDamageReductionCharacter != zero));
                                    }
                                }
                                countdowntryCreateCharacter--;
                            } while (!((hpmagician >= HpMinMagician && hpmagician <= HpMaxMagician) && (atkmagician >= AtkMinMagician && atkmagician <= AtkMaxMagician) && (damagereductionmagician >= DamageReductionMinMagician && damagereductionmagician <= DamageReductionMaxMagician) && (countdowntryCreateCharacter != zero)));
                            /* Creacio Druida mateixa condicio d'adalt */
                            if (countdowntryCreateCharacter != zero) 
                            {
                                countdowntryCreateCharacter = three;
                                /* Demanar dades heroe druida */
                                do
                                {
                                    countdowntrySetHpCharacter = three;
                                    errorSetValueCharacter = false;
                                    Console.WriteLine("");
                                    Console.WriteLine(MSGCreateDruid);
                                    Console.WriteLine(MSGRequieredValues);
                                    Console.Write(MSGSetHpDruid);
                                    do
                                    {
                                        if (errorSetValueCharacter)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGSetError);
                                            Console.Write(MSGSetHpDruid);
                                        }
                                        hpdruid = Convert.ToInt32(Console.ReadLine());
                                        errorSetValueCharacter = true;
                                        countdowntrySetHpCharacter--;

                                    } while (!(hpdruid >= HpMinDruid && hpdruid <= HpMaxDruid && countdowntrySetHpCharacter != zero));

                                    /* Quant es diferent a 0 significa que no ha utilitzat tots els 3 intents aixi que pregunta l'altre valor */

                                    if (countdowntrySetHpCharacter != zero)
                                    {
                                        countdowntrySetAtkCharacter = three;
                                        errorSetValueCharacter = false;
                                        Console.Write(MSGSetAtkDruid);
                                        do
                                        {
                                            if (errorSetValueCharacter)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine(MSGSetError);
                                                Console.Write(MSGSetAtkDruid);
                                            }
                                            atkdruid = Convert.ToInt32(Console.ReadLine());
                                            errorSetValueCharacter = true;
                                            countdowntrySetAtkCharacter--;

                                        } while (!(atkdruid >= AtkMinDruid && atkdruid <= AtkMaxDruid && countdowntrySetAtkCharacter != zero));

                                        if (countdowntrySetAtkCharacter != zero)
                                        {
                                            countdowntrySetDamageReductionCharacter = three;
                                            errorSetValueCharacter = false;
                                            Console.Write(MSGSetDamageReductionDruid);
                                            do
                                            {
                                                if (errorSetValueCharacter)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGSetError);
                                                    Console.Write(MSGSetDamageReductionDruid);
                                                }
                                                damagereductiondruid = Convert.ToInt32(Console.ReadLine());
                                                errorSetValueCharacter = true;
                                                countdowntrySetDamageReductionCharacter--;

                                            } while (!(damagereductiondruid >= DamageReductionMinDruid && damagereductiondruid <= DamageReductionMaxDruid && countdowntrySetDamageReductionCharacter != zero));
                                        }
                                    }
                                    countdowntryCreateCharacter--;
                                } while (!((hpdruid >= HpMinDruid && hpdruid <= HpMaxDruid) && (atkdruid >= AtkMinDruid && atkdruid <= AtkMaxDruid) && (damagereductiondruid >= DamageReductionMinDruid && damagereductiondruid <= DamageReductionMaxDruid) && (countdowntryCreateCharacter != zero)));
                                /* Creacio Monstre mateixa condicio d'adalt */
                                if (countdowntryCreateCharacter != zero)
                                {
                                    countdowntryCreateCharacter = three;
                                    /* Demanar dades del Monstre */
                                    do
                                    {
                                        countdowntrySetHpCharacter = three;
                                        errorSetValueCharacter = false;
                                        Console.WriteLine("");
                                        Console.WriteLine(MSGCreateMonster);
                                        Console.WriteLine(MSGRequieredValues);
                                        Console.Write(MSGSetHpMonster);
                                        do
                                        {
                                            if (errorSetValueCharacter)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine(MSGSetError);
                                                Console.Write(MSGSetHpMonster);
                                            }
                                            hpmonster = Convert.ToInt32(Console.ReadLine());
                                            errorSetValueCharacter = true;
                                            countdowntrySetHpCharacter--;

                                        } while (!(hpmonster >= HpMinMonster && hpmonster <= HpMaxMonster && countdowntrySetHpCharacter != zero));

                                        /* Quant es diferent a 0 significa que no ha utilitzat tots els 3 intents aixi que pregunta l'altre valor */

                                        if (countdowntrySetHpCharacter != zero)
                                        {
                                            countdowntrySetAtkCharacter = three;
                                            errorSetValueCharacter = false;
                                            Console.Write(MSGSetAtkMonster);
                                            do
                                            {
                                                if (errorSetValueCharacter)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGSetError);
                                                    Console.Write(MSGSetAtkMonster);
                                                }
                                                atkmonster = Convert.ToInt32(Console.ReadLine());
                                                errorSetValueCharacter = true;
                                                countdowntrySetAtkCharacter--;

                                            } while (!(atkmonster >= AtkMinMonster && atkmonster <= AtkMaxMonster && countdowntrySetAtkCharacter != zero));

                                            if (countdowntrySetAtkCharacter != zero)
                                            {
                                                countdowntrySetDamageReductionCharacter = three;
                                                errorSetValueCharacter = false;
                                                Console.Write(MSGSetDamageReductionMonster);
                                                do
                                                {
                                                    if (errorSetValueCharacter)
                                                    {
                                                        Console.WriteLine("");
                                                        Console.WriteLine(MSGSetError);
                                                        Console.Write(MSGSetDamageReductionMonster);
                                                    }
                                                    damagereductionmonster = Convert.ToInt32(Console.ReadLine());
                                                    errorSetValueCharacter = true;
                                                    countdowntrySetDamageReductionCharacter--;

                                                } while (!(damagereductionmonster >= DamageReductionMinMonster && damagereductionmonster <= DamageReductionMaxMonster && countdowntrySetDamageReductionCharacter != zero));
                                            }
                                        }
                                        countdowntryCreateCharacter--;
                                    } while (!((hpmonster >= HpMinMonster && hpmonster <= HpMaxMonster) && (atkmonster >= AtkMinMonster && atkmonster <= AtkMaxMonster) && (damagereductionmonster >= DamageReductionMinMonster && damagereductionmonster <= DamageReductionMaxMonster) && (countdowntryCreateCharacter != zero)));
                                    /* Personatges tots creats en cas de que el monstre tambe estigui ven creat sense falla 3 cop la creacio del monstre començara la partida */
                                    if (countdowntryCreateCharacter != zero)
                                    {
                                        battleturns = one;
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine(MSGStartBattle);
                                        Console.WriteLine("");

                                        while (!(hparcher <= zero && hpbarbarian <= zero && hpdruid <= zero && hpmagician <= zero || hpmonster <= zero) && countdowntryAction != zero)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGTurn+battleturns+MSGTwoPoints);
                                            Console.WriteLine("");

                                            if (hparcher > 0)
                                            {
                                                countdowntryAction = three;
                                                errorActionGame = false;
                                                do
                                                {
                                                    if (errorActionGame)
                                                    {
                                                        Console.WriteLine("");
                                                        Console.WriteLine(MSGErrorAction);
                                                    }
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGActionArcher);
                                                    Console.WriteLine(MSGActionAtk);
                                                    Console.WriteLine(MSGActionProtect);
                                                    Console.WriteLine(MSGActionEspecialHability);
                                                    useraction = Convert.ToInt32(Console.ReadLine());
                                                    errorActionGame = true;
                                                    countdowntryAction--;
                                                } while (useraction != actionatk && useraction != actionprotection && useraction != actionespecialhability && countdowntryAction != zero);
                                            }


                                            battleturns++;
                                        }
                                        if (countdowntryAction == zero)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGActionCountDownEqual0);
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGPressToContinue);
                                            Console.ReadKey();
                                        } else if (hpmonster <= zero)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGWinMonster);
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGPressToContinue);
                                            Console.ReadKey();
                                        } else
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGWinHeros);
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGPressToContinue);
                                            Console.ReadKey();
                                        }
                                        Console.Clear();
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    game = false;
                }
            }
        }
    }
}
