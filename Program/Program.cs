/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * PR1. Joc de Batalla d'Herois vs Monstre
 *
 */

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
            const double HpMinArcher = 1500, HpMaxArcher = 2000;
            const double AtkMinArcher = 180, AtkMaxArcher = 300;
            const double DamageReductionMinArcher = 25, DamageReductionMaxArcher = 40;

            const double HpMinBarbarian = 3000, HpMaxBarbarian = 3750;
            const double AtkMinBarbarian = 150, AtkMaxBarbarian = 250;
            const double DamageReductionMinBarbarian = 35, DamageReductionMaxBarbarian = 45;

            const double HpMinMagician = 1000, HpMaxMagician = 1500;
            const double AtkMinMagician = 300, AtkMaxMagician = 350;
            const double DamageReductionMinMagician = 20, DamageReductionMaxMagician = 35;

            const double HpMinDruid = 2000, HpMaxDruid = 2500;
            const double AtkMinDruid = 70, AtkMaxDruid = 120;
            const double DamageReductionMinDruid = 25, DamageReductionMaxDruid = 40;

            const double HpMinMonster = 9000, HpMaxMonster = 12000;
            const double AtkMinMonster = 250, AtkMaxMonster = 400;
            const double DamageReductionMinMonster = 20, DamageReductionMaxMonster = 30;


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
            const string MSGActionArcherAtk = "Arquera ataca a Monstre amb 180 de dany. El Monstre es defensa i rep només 135 de dany. Vida restant del Monstre: 8865";
            const string MSGActionArcherProtect = "L'Arquera es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.";
            const string MSGActionArcherEspecialHability = "Arquera. Selecciona l’acció:";

            const string MSGDamage = " de dany.";

            const string MSGAtkArcher = "L'Arquera ataca a Monstre amb ";
            const string MSGAtkBarbarian = "El Bàrbar ataca a Monstre amb ";
            const string MSGAtkMagician = "La Maga ataca a Monstre amb ";
            const string MSGAtkDruid = "El Druida ataca a Monstre amb ";

            const string MSGAtkMonsterTooArcher = " El Monstre ataca a l’Arquera ";
            const string MSGAtkMonsterTooBarbarian = " El Monstre ataca al Bàrbar ";
            const string MSGAtkMonsterTooMagician = " El Monstre ataca a la Maga ";
            const string MSGAtkMonsterTooDruid = " El Monstre ataca al Druida ";
            
            const string MSGEspecialHabilityArcher = "L'Arquera activa la seva habilitat especial i noqueja el monstre durant 2 torns (no pot atacar).";
            const string MSGEspecialHabilityBarbarian = "Bàrbar activa la seva habilitat especial i durant 3 torns el valor de la seva reducció de dany serà del 100%.";
            const string MSGEspecialHabilityMagician = "La Maga activa la seva habilitat especial, dispara una bola de foc que fa 3 cops el seu atac.";
            const string MSGEspecialHabilityDruid = "El Druida activa la seva habilitat especial, cura la vida de tots els herois 500 punts de vida.";

            const string MSGProtectArcher = " L’Arquera es defensa i rep només ";
            const string MSGProtectBarbarian = " El Bàrbar es defensa i rep només ";
            const string MSGProtectMagician = " La Maga es defensa i rep només ";
            const string MSGProtectDruid = " El Druida es defensa i rep només ";
            const string MSGProtectMonster = " El Monstre es defensa i rep només ";


            const string MSGHpArcher = " Vida restant de l’Arquera: ";
            const string MSGHpBarbarian = " Vida restant del Bàrbar: ";
            const string MSGHpMagician = " Vida restant de la Maga: ";
            const string MSGHpDruid = " Vida restant del Druida: ";
            const string MSGHpMonster = " Vida restant del Monstre: ";

            const string MSGMonsterAtkAll = "El Monstre ataca a tots els herois:";

            const string MSGActionBarbarian = "Bàrbar. Selecciona l’acció:";
            const string MSGActionMagician = "Maga. Selecciona l’acció:";
            const string MSGActionDruid = "Druida. Selecciona l’acció:";
            const string MSGActionMonster = "El Monstre ataca a tots els herois:";
            const string MSGActionAtk = "1. Atacar";
            const string MSGActionProtect = "2. Protegir-se";
            const string MSGActionEspecialHability = "3. Habilitat especial ";
            const string MSGErrorAction = "El valor introduit no es correcta. Torna a provar.";
            const string MSGActionCountDownEqual0 = "El valor introduit no es correcta. S’han acabat els intents. Adéu";
            const string MSGCooldown = "Cooldown: ";
            const string MSGErrorCooldown = "No pots utilitzar l'acció 3 ja que esta amb cooldown, fes una altre acció. ";


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
            const int onehundred = 100;


            /* Declaracio variables heroes */
            double hparcher = 0, atkarcher = 0, damagereductionarcher = 0, tmpdamagereductionarcher;
            int cooldownhabilityarcher = 0, countdownhabilityarcher=2;
            bool specialhabilityarcher = true;

            double hpbarbarian = 0, atkbarbarian = 0, damagereductionbarbarian = 0, tmpdamagereductionbarbarian;
            int cooldownhabilitybarbarian = 0, countdownhabilitybarbarian = 3;
            bool specialhabilitybarbarian = true;

            double hpmagician = 0, atkmagician = 0, damagereductionmagician = 0, tmpdamagereductionmagician;
            int cooldownhabilitymagician = 0;

            double hpdruid = 0, atkdruid = 0, damagereductiondruid = 0, tmpdamagereductiondruid; 
            int cooldownhabilitydruid = 0;

            /* Declaracio variables monstruo*/
            double hpmonster = 0, atkmonster = 0, damagereductionmonster = 0;

            /* Error variables */
            bool errorstartgame = false, game = true, errorSetValueCharacter = false, errorActionGame = false, errorActionCooldown3 = false;

            /* Countsdown */
            int countdowntrystartgame = 3;

            int countdowntryCreateCharacter = 3;

            int countdowntrySetHpCharacter = 3;

            int countdowntrySetAtkCharacter = 3;

            int countdowntrySetDamageReductionCharacter = 3;

            int countdowntryAction = 3;

            /* Altres variables */
            int startgame, battleturns, useraction = 0;


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
                            hparcher = Convert.ToDouble(Console.ReadLine());
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
                                atkarcher = Convert.ToDouble(Console.ReadLine());
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
                                    damagereductionarcher = Convert.ToDouble(Console.ReadLine());
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
                                hpbarbarian = Convert.ToDouble(Console.ReadLine());
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
                                    atkbarbarian = Convert.ToDouble(Console.ReadLine());
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
                                        damagereductionbarbarian = Convert.ToDouble(Console.ReadLine());
                                        errorSetValueCharacter = true;
                                        countdowntrySetDamageReductionCharacter--;

                                    } while (!(damagereductionbarbarian >= DamageReductionMinBarbarian && damagereductionbarbarian <= DamageReductionMaxBarbarian && countdowntrySetDamageReductionCharacter != zero));
                                }
                            }
                            countdowntryCreateCharacter--;
                        } while (!((hpbarbarian >= HpMinBarbarian && hpbarbarian <= HpMaxBarbarian) && (atkbarbarian >= AtkMinBarbarian && atkbarbarian <= AtkMaxBarbarian) && (damagereductionbarbarian >= DamageReductionMinBarbarian && damagereductionbarbarian <= DamageReductionMaxBarbarian) && (countdowntryCreateCharacter != zero)));
                        /* Creacio de heroe maga si el barbar ha sigut fet en menos de 3 intents */
                        if (countdowntrySetHpCharacter != zero)
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
                                    hpmagician = Convert.ToDouble(Console.ReadLine());
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
                                        atkmagician = Convert.ToDouble(Console.ReadLine());
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
                                            damagereductionmagician = Convert.ToDouble(Console.ReadLine());
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
                                        hpdruid = Convert.ToDouble(Console.ReadLine());
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
                                            atkdruid = Convert.ToDouble(Console.ReadLine());
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
                                                damagereductiondruid = Convert.ToDouble(Console.ReadLine());
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
                                            hpmonster = Convert.ToDouble(Console.ReadLine());
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
                                                atkmonster = Convert.ToDouble(Console.ReadLine());
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
                                                    damagereductionmonster = Convert.ToDouble(Console.ReadLine());
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
                                        tmpdamagereductionarcher = damagereductionarcher;
                                        tmpdamagereductionbarbarian = damagereductionbarbarian;
                                        tmpdamagereductionmagician = damagereductionmagician;
                                        tmpdamagereductiondruid = damagereductiondruid;

                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine(MSGStartBattle);
                                        Console.WriteLine("");

                                        while (!(hparcher <= zero && hpbarbarian <= zero && hpdruid <= zero && hpmagician <= zero || hpmonster <= zero) && countdowntryAction != zero)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGTurn + battleturns + MSGTwoPoints);
                                            Console.WriteLine("");

                                            if (hparcher > 0)
                                            {
                                                countdowntryAction = three;
                                                errorActionGame = false;
                                                errorActionCooldown3 = false;
                                                do
                                                {
                                                    if (useraction == 3 && cooldownhabilityarcher >= 1 && cooldownhabilityarcher <= 5 && errorActionCooldown3)
                                                    {
                                                        Console.WriteLine("");
                                                        Console.WriteLine(MSGErrorCooldown);
                                                        Console.WriteLine("");

                                                    }
                                                    else if (errorActionGame)
                                                    {
                                                        Console.WriteLine("");
                                                        Console.WriteLine(MSGErrorAction);
                                                    }
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGActionArcher);
                                                    Console.WriteLine(MSGActionAtk);
                                                    Console.WriteLine(MSGActionProtect);
                                                    if (cooldownhabilityarcher == 0)
                                                    {
                                                        Console.WriteLine(MSGActionEspecialHability);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(MSGActionEspecialHability + MSGCooldown + cooldownhabilityarcher);
                                                    }
                                                    useraction = Convert.ToInt32(Console.ReadLine());
                                                    errorActionGame = true;
                                                    errorActionCooldown3 = true;
                                                    countdowntryAction--;
                                                } while (!(useraction >= 1 && useraction <= 3) || (useraction == 3 && cooldownhabilityarcher != 0) && countdowntryAction != zero);
                                                if (useraction == actionatk)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGAtkArcher+atkarcher+MSGDamage+MSGProtectMonster+(atkarcher-((damagereductionmonster / onehundred) * atkarcher))+MSGDamage+MSGHpMonster+(hpmonster - (atkarcher - ((damagereductionmonster / onehundred) * atkarcher))));
                                                    Console.WriteLine("");
                                                    hpmonster -= (atkarcher - ((damagereductionmonster / onehundred) * atkarcher));

                                                    if (cooldownhabilityarcher > 0)
                                                    {
                                                        cooldownhabilityarcher--;
                                                    }
                                                }
                                                else if (useraction == actionprotection)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGActionProtect);
                                                    Console.WriteLine("");

                                                    if (cooldownhabilityarcher > 0)
                                                    {
                                                        cooldownhabilityarcher--;
                                                    }
                                                }
                                                else if (useraction == actionespecialhability && cooldownhabilityarcher == 0)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGActionEspecialHability);
                                                    Console.WriteLine("");
                                                    cooldownhabilityarcher = 5;
                                                }
                                            }

                                            /* Comprova si hi ha algun heroe que a utilitzat la 2 accio de defensarse */

                                            if (damagereductionarcher != tmpdamagereductionarcher)
                                            {
                                                damagereductionarcher -= tmpdamagereductionarcher;
                                            }

                                            if (damagereductionbarbarian != tmpdamagereductionbarbarian)
                                            {
                                                damagereductionbarbarian -= tmpdamagereductionbarbarian;
                                            }

                                            if (damagereductionmagician != tmpdamagereductionmagician)
                                            {
                                                damagereductionmagician -= tmpdamagereductionmagician;
                                            }

                                            if (damagereductiondruid != tmpdamagereductiondruid)
                                            {
                                                damagereductiondruid -= tmpdamagereductiondruid;
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
                                        }
                                        else if (hpmonster <= zero)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGWinMonster);
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGPressToContinue);
                                            Console.ReadKey();
                                        }
                                        else
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
