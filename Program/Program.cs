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
            const string MSGDoYouWantQuit = "0. Sortir";
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
            const string MSGRequieredValues = "Introdueix els valors requerits:";
            const string MSGSetError = "Error, no has introduit un valor dins del rang especificat. Torna a posarlo: ";

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



            /* MSG Accions Heroes i MSG Monstre */

            const string MSGDamage = " de dany. ";

            const string MSGAtkArcher = "L'Arquera ataca a Monstre amb ";
            const string MSGAtkBarbarian = "El Bàrbar ataca a Monstre amb ";
            const string MSGAtkMagician = "La Maga ataca a Monstre amb ";
            const string MSGAtkMagicianEspecialHability = "La Maga ataca a Monstre amb una bola de foc que fa ";
            const string MSGAtkDruid = "El Druida ataca a Monstre amb ";

            const string MSGAtkMonsterTooArcher = " El Monstre ataca a l’Arquera amb ";
            const string MSGAtkMonsterTooBarbarian = " El Monstre ataca al Bàrbar amb ";
            const string MSGAtkMonsterTooMagician = " El Monstre ataca a la Maga amb ";
            const string MSGAtkMonsterTooDruid = " El Monstre ataca al Druida amb ";

            const string MSGActionEspecialHabilityArcher = "L'Arquera activa la seva habilitat especial i noqueja el monstre durant 2 torns (no pot atacar).";
            const string MSGActionEspecialHabilityBarbarian = "Bàrbar activa la seva habilitat especial i durant 3 torns el valor de la seva reducció de dany serà del 100%.";
            const string MSGActionEspecialHabilityMagician = "La Maga activa la seva habilitat especial, dispara una bola de foc que fa 3 cops el seu atac.";
            const string MSGActionEspecialHabilityDruid = "El Druida activa la seva habilitat especial, cura la vida de tots els herois 500 punts de vida.";
            const string MSGActivatedEspecialHabilityBarbarian = "El Bàrbar te activa la seva habilitat especial i rep: ";


            const string MSGReduccionDamageWhenAtkMonsterTooArcher = "L’Arquera es defensa i rep només ";
            const string MSGReduccionDamageWhenAtkMonsterTooBarbarian = "El Bàrbar es defensa i rep només ";
            const string MSGReduccionDamageWhenAtkMonsterTooMagician = "La Maga es defensa i rep només ";
            const string MSGReduccionDamageWhenAtkMonsterTooDruid = "El Druida es defensa i rep només ";
            const string MSGReduccionDamageWhenAtkHerosTooMonster = "El Monstre es defensa i rep només ";

            const string MSGActionProtectArcher = "L'Arquera es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.";
            const string MSGActionProtectBarbarian = "El Bàrbar es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.";
            const string MSGActionProtectMagician = "La Maga es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.";
            const string MSGActionProtectDruid = "El Druida es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.";


            const string MSGHpArcher = "Vida restant de l’Arquera: ";
            const string MSGHpBarbarian = "Vida restant del Bàrbar: ";
            const string MSGHpMagician = "Vida restant de la Maga: ";
            const string MSGHpDruid = "Vida restant del Druida: ";
            const string MSGHpMonster = "Vida restant del Monstre: ";

            const string MSGDeathNotHealArcher = "L'arquera esta morta per tant no es pot cura.";
            const string MSGDeathNotHealBarbarian = "El Bàrbar esta mort per tant no es pot cura.";
            const string MSGDeathNotHealMagician = "La Maga esta morta per tant no es pot cura.";

            const string MSGDeathArcher = "L'arquera esta morta.";
            const string MSGDeathBarbarian = "El Bàrbar esta mort.";
            const string MSGDeathMagician = "La Maga esta morta.";
            const string MSGDeathDruid = "El Druida esta mort.";

            const string MSGMonsterAtkAll = "El Monstre ataca a tots els herois:";

            const string MSGActionArcher = "Arquera. Selecciona l’acció:";
            const string MSGActionBarbarian = "Bàrbar. Selecciona l’acció:";
            const string MSGActionMagician = "Maga. Selecciona l’acció:";
            const string MSGActionDruid = "Druida. Selecciona l’acció:";

            const string MSGActionAtk = "1. Atacar";
            const string MSGActionProtect = "2. Protegir-se";
            const string MSGActionEspecialHability = "3. Habilitat especial ";
            const string MSGErrorAction = "El valor introduit no es correcta. Torna a provar.";
            const string MSGActionCountDownEqual0 = "El valor introduit no es correcta. S’han acabat els intents. Adéu";
            const string MSGCooldown = "Cooldown: ";
            const string MSGErrorCooldown = "No pots utilitzar l'acció 3 ja que esta amb cooldown, fes una altre acció. ";
            const string MSGFailedCreateAllCharacters = "S’han acabat els intents per crear tots els personatges. Adéu";


            const string MSGWinHeros = "El monstre a mort, han guanyat el heroes!!!!";
            const string MSGWinMonster = "Tots els heroes han mort, ha guanyat el monstre.";



            /* Altres constants */
            const int actionatk = 1;
            const int actionprotection = 2;
            const int actionespecialhability = 3;
            const int play = 1;
            const int quit = 0;
            const int zero = 0;
            const int one = 1;
            const int three = 3;
            const int four = 4;
            const int onehundred = 100;
            const int healhabilitydruid = 500;
            const int maxcountdowntrys = 3;
            const int maxcooldown = 5;

            /* Declaracio variables heroes */
            double hparcher = 0, atkarcher = 0, damagereductionarcher = 0, tmpdamagereductionarcher, tmphpmaxarcher;
            int cooldownhabilityarcher = 0;
            bool specialhabilityarcher = false;

            double hpbarbarian = 0, atkbarbarian = 0, damagereductionbarbarian = 0, tmpdamagereductionbarbarian, tmphpmaxbarbarian;
            int cooldownhabilitybarbarian = 0;
            bool specialhabilitybarbarian = false;

            double hpmagician = 0, atkmagician = 0, damagereductionmagician = 0, tmpdamagereductionmagician, tmphpmaxmagician;
            int cooldownhabilitymagician = 0;

            double hpdruid = 0, atkdruid = 0, damagereductiondruid = 0, tmpdamagereductiondruid, tmphpmaxdruid;
            int cooldownhabilitydruid = 0;

            /* Declaracio variables monstruo*/
            double hpmonster = 0, atkmonster = 0, damagereductionmonster = 0;

            /* Error variables */
            bool errorstartgame = false, game = true, errorSetValueCharacter = false, errorActionGame = false, errorActionCooldown3 = false;

            /* Countsdown */

            int countdowntrystartgame = maxcountdowntrys;

            int countdowntryCreateCharacter = maxcountdowntrys;

            int countdowntrySetHpCharacter = maxcountdowntrys;

            int countdowntrySetAtkCharacter = maxcountdowntrys;

            int countdowntrySetDamageReductionCharacter = maxcountdowntrys;

            int countdowntryAction = maxcountdowntrys;

            /* Altres variables */
            int startgame, battleturns, useraction = 0;


            Console.WriteLine(MSGWelcome);
            while (game)
            {
                countdowntrystartgame = maxcountdowntrys;
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

                if (startgame == play && countdowntrystartgame != zero || startgame == play && countdowntrystartgame == zero)
                {
                    Console.WriteLine("");
                    Console.WriteLine(MSGStartCreateCharacters);
                    Console.WriteLine("");

                    /* Creacio personatges */

                    countdowntryCreateCharacter = maxcountdowntrys;

                    /* Demanar dades heroe Archer */
                    do
                    {
                        countdowntrySetHpCharacter = maxcountdowntrys;
                        errorSetValueCharacter = false;
                        Console.WriteLine("");
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

                        } while (!(hparcher >= HpMinArcher && hparcher <= HpMaxArcher) && countdowntrySetHpCharacter != zero);

                        /* Quando sigui diferent a 0 significa o igual a 0 i la resposta sigui correcta  pregutara el segon valor a introduir aixi amb tots*/

                        if (countdowntrySetHpCharacter != zero || (hparcher >= HpMinArcher && hparcher <= HpMaxArcher && countdowntrySetHpCharacter == zero))
                        {
                            countdowntrySetAtkCharacter = maxcountdowntrys;
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

                            } while (!(atkarcher >= AtkMinArcher && atkarcher <= AtkMaxArcher) && countdowntrySetAtkCharacter != zero);

                            if (countdowntrySetAtkCharacter != zero || (atkarcher >= AtkMinArcher && atkarcher <= AtkMaxArcher && countdowntrySetAtkCharacter == zero))
                            {
                                countdowntrySetDamageReductionCharacter = maxcountdowntrys;
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

                                } while (!(damagereductionarcher >= DamageReductionMinArcher && damagereductionarcher <= DamageReductionMaxArcher) && countdowntrySetDamageReductionCharacter != zero);
                                if (!(countdowntrySetDamageReductionCharacter != zero || (damagereductionarcher >= DamageReductionMinArcher && damagereductionarcher <= DamageReductionMaxArcher && countdowntrySetDamageReductionCharacter == zero)))
                                {
                                    countdowntryCreateCharacter--;
                                }
                            }
                            else
                            {
                                countdowntryCreateCharacter--;
                            }
                        }
                        else
                        {
                            countdowntryCreateCharacter--;
                        }
                    } while (!((hparcher >= HpMinArcher && hparcher <= HpMaxArcher) && (atkarcher >= AtkMinArcher && atkarcher <= AtkMaxArcher) && (damagereductionarcher >= DamageReductionMinArcher && damagereductionarcher <= DamageReductionMaxArcher)) && (countdowntryCreateCharacter != zero));

                    /* Creacio de heroe barbar */
                    if (countdowntryCreateCharacter != zero || (countdowntryCreateCharacter == zero && (hparcher >= HpMinArcher && hparcher <= HpMaxArcher) && (atkarcher >= AtkMinArcher && atkarcher <= AtkMaxArcher) && (damagereductionarcher >= DamageReductionMinArcher && damagereductionarcher <= DamageReductionMaxArcher)))
                    {
                        /* Demanar dades heroe Barbar */
                        do
                        {
                            countdowntrySetHpCharacter = maxcountdowntrys;
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

                            } while (!(hpbarbarian >= HpMinBarbarian && hpbarbarian <= HpMaxBarbarian) && countdowntrySetHpCharacter != zero);

                        /* Quando sigui diferent a 0 significa o igual a 0 i la resposta sigui correcta  pregutara el segon valor a introduir aixi amb tots*/

                            if (countdowntrySetHpCharacter != zero || (hpbarbarian >= HpMinBarbarian && hpbarbarian <= HpMaxBarbarian && countdowntrySetHpCharacter == zero))
                            {
                                countdowntrySetAtkCharacter = maxcountdowntrys;
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

                                } while (!(atkbarbarian >= AtkMinBarbarian && atkbarbarian <= AtkMaxBarbarian) && countdowntrySetAtkCharacter != zero);

                                if (countdowntrySetAtkCharacter != zero || (atkbarbarian >= AtkMinBarbarian && atkbarbarian <= AtkMaxBarbarian && countdowntrySetAtkCharacter == zero))
                                {
                                    countdowntrySetDamageReductionCharacter = maxcountdowntrys;
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

                                    } while (!(damagereductionbarbarian >= DamageReductionMinBarbarian && damagereductionbarbarian <= DamageReductionMaxBarbarian) && countdowntrySetDamageReductionCharacter != zero);
                                    if (!(countdowntrySetDamageReductionCharacter != zero || (damagereductionbarbarian >= DamageReductionMinBarbarian && damagereductionbarbarian <= DamageReductionMaxBarbarian && countdowntrySetDamageReductionCharacter == zero)))
                                    {
                                        countdowntryCreateCharacter--;
                                    }
                                }
                                else
                                {
                                    countdowntryCreateCharacter--;
                                }
                            }
                            else
                            {
                                countdowntryCreateCharacter--;
                            }
                        } while (!((hpbarbarian >= HpMinBarbarian && hpbarbarian <= HpMaxBarbarian) && (atkbarbarian >= AtkMinBarbarian && atkbarbarian <= AtkMaxBarbarian) && (damagereductionbarbarian >= DamageReductionMinBarbarian && damagereductionbarbarian <= DamageReductionMaxBarbarian)) && (countdowntryCreateCharacter != zero));
                        /* Creacio de heroe maga  */
                        if (countdowntryCreateCharacter != zero || (countdowntryCreateCharacter == zero && (hpbarbarian >= HpMinBarbarian && hpbarbarian <= HpMaxBarbarian) && (atkbarbarian >= AtkMinBarbarian && atkbarbarian <= AtkMaxBarbarian) && (damagereductionbarbarian >= DamageReductionMinBarbarian && damagereductionbarbarian <= DamageReductionMaxBarbarian)))
                        {
                            /* Demanar dades heroe maga */
                            do
                            {
                                countdowntrySetHpCharacter = maxcountdowntrys;
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

                                } while (!(hpmagician >= HpMinMagician && hpmagician <= HpMaxMagician) && countdowntrySetHpCharacter != zero);

                            /* Quando sigui diferent a 0 significa o igual a 0 i la resposta sigui correcta  pregutara el segon valor a introduir aixi amb tots*/

                                if (countdowntrySetHpCharacter != zero || (hpmagician >= HpMinMagician && hpmagician <= HpMaxMagician && countdowntrySetHpCharacter == zero))
                                {
                                    countdowntrySetAtkCharacter = maxcountdowntrys;
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

                                    } while (!(atkmagician >= AtkMinMagician && atkmagician <= AtkMaxMagician) && countdowntrySetAtkCharacter != zero);

                                    if (countdowntrySetAtkCharacter != zero || (atkmagician >= AtkMinMagician && atkmagician <= AtkMaxMagician && countdowntrySetAtkCharacter == zero))
                                    {
                                        countdowntrySetDamageReductionCharacter = maxcountdowntrys;
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

                                        } while (!(damagereductionmagician >= DamageReductionMinMagician && damagereductionmagician <= DamageReductionMaxMagician) && countdowntrySetDamageReductionCharacter != zero);
                                        if (!(countdowntrySetDamageReductionCharacter != zero || (damagereductionmagician >= DamageReductionMinMagician && damagereductionmagician <= DamageReductionMaxMagician && countdowntrySetDamageReductionCharacter == zero)))
                                        {
                                            countdowntryCreateCharacter--;
                                        }
                                    }
                                    else
                                    {
                                        countdowntryCreateCharacter--;
                                    }
                                }
                                else
                                {
                                    countdowntryCreateCharacter--;
                                }
                            } while (!((hpmagician >= HpMinMagician && hpmagician <= HpMaxMagician) && (atkmagician >= AtkMinMagician && atkmagician <= AtkMaxMagician) && (damagereductionmagician >= DamageReductionMinMagician && damagereductionmagician <= DamageReductionMaxMagician)) && (countdowntryCreateCharacter != zero));
                            /* Creacio heroe druida  */
                            if (countdowntryCreateCharacter != zero || (countdowntryCreateCharacter == zero && (hpmagician >= HpMinMagician && hpmagician <= HpMaxMagician) && (atkmagician >= AtkMinMagician && atkmagician <= AtkMaxMagician) && (damagereductionmagician >= DamageReductionMinMagician && damagereductionmagician <= DamageReductionMaxMagician)))
                            {
                                /* Demanar dades heroe druida */
                                do
                                {
                                    countdowntrySetHpCharacter = maxcountdowntrys;
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

                                    } while (!(hpdruid >= HpMinDruid && hpdruid <= HpMaxDruid) && countdowntrySetHpCharacter != zero);

                                /* Quando sigui diferent a 0 significa o igual a 0 i la resposta sigui correcta  pregutara el segon valor a introduir aixi amb tots*/

                                    if (countdowntrySetHpCharacter != zero || (hpdruid >= HpMinDruid && hpdruid <= HpMaxDruid && countdowntrySetHpCharacter == zero))
                                    {
                                        countdowntrySetAtkCharacter = maxcountdowntrys;
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

                                        } while (!(atkdruid >= AtkMinDruid && atkdruid <= AtkMaxDruid) && countdowntrySetAtkCharacter != zero);

                                        if (countdowntrySetAtkCharacter != zero || (atkdruid >= AtkMinDruid && atkdruid <= AtkMaxDruid && countdowntrySetAtkCharacter == zero))
                                        {
                                            countdowntrySetDamageReductionCharacter = maxcountdowntrys;
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

                                            } while (!(damagereductiondruid >= DamageReductionMinDruid && damagereductiondruid <= DamageReductionMaxDruid) && countdowntrySetDamageReductionCharacter != zero);
                                            if (!(countdowntrySetDamageReductionCharacter != zero || (damagereductiondruid >= DamageReductionMinDruid && damagereductiondruid <= DamageReductionMaxDruid && countdowntrySetDamageReductionCharacter == zero)))
                                            {
                                                countdowntryCreateCharacter--;
                                            }
                                        }
                                        else
                                        {
                                            countdowntryCreateCharacter--;
                                        }
                                    }
                                    else
                                    {
                                        countdowntryCreateCharacter--;
                                    }
                                } while (!((hpdruid >= HpMinDruid && hpdruid <= HpMaxDruid) && (atkdruid >= AtkMinDruid && atkdruid <= AtkMaxDruid) && (damagereductiondruid >= DamageReductionMinDruid && damagereductiondruid <= DamageReductionMaxDruid)) && (countdowntryCreateCharacter != zero));

                                /* Creacio Monstre */
                                if (countdowntryCreateCharacter != zero || (countdowntryCreateCharacter == zero && (hpdruid >= HpMinDruid && hpdruid <= HpMaxDruid) && (atkdruid >= AtkMinDruid && atkdruid <= AtkMaxDruid) && (damagereductiondruid >= DamageReductionMinDruid && damagereductiondruid <= DamageReductionMaxDruid)))
                                {
                                    /* Demanar dades del Monstre */
                                    do
                                    {
                                        countdowntrySetHpCharacter = maxcountdowntrys;
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

                                        } while (!(hpmonster >= HpMinMonster && hpmonster <= HpMaxMonster) && countdowntrySetHpCharacter != zero);

                                    /* Quando sigui diferent a 0 significa o igual a 0 i la resposta sigui correcta  pregutara el segon valor a introduir aixi amb tots*/

                                        if (countdowntrySetHpCharacter != zero || (hpmonster >= HpMinMonster && hpmonster <= HpMaxMonster && countdowntrySetHpCharacter == zero))
                                        {
                                            countdowntrySetAtkCharacter = maxcountdowntrys;
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

                                            } while (!(atkmonster >= AtkMinMonster && atkmonster <= AtkMaxMonster) && countdowntrySetAtkCharacter != zero);

                                            if (countdowntrySetAtkCharacter != zero || (atkmonster >= AtkMinMonster && atkmonster <= AtkMaxMonster && countdowntrySetAtkCharacter == zero))
                                            {
                                                countdowntrySetDamageReductionCharacter = maxcountdowntrys;
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

                                                } while (!(damagereductionmonster >= DamageReductionMinMonster && damagereductionmonster <= DamageReductionMaxMonster) && countdowntrySetDamageReductionCharacter != zero);
                                                if (!(countdowntrySetDamageReductionCharacter != zero || (damagereductionmonster >= DamageReductionMinMonster && damagereductionmonster <= DamageReductionMaxMonster && countdowntrySetDamageReductionCharacter == zero)))
                                                {
                                                    countdowntryCreateCharacter--;
                                                }
                                            }
                                            else
                                            {
                                                countdowntryCreateCharacter--;
                                            }
                                        }
                                        else
                                        {
                                            countdowntryCreateCharacter--;
                                        }
                                    } while (!((hpmonster >= HpMinMonster && hpmonster <= HpMaxMonster) && (atkmonster >= AtkMinMonster && atkmonster <= AtkMaxMonster) && (damagereductionmonster >= DamageReductionMinMonster && damagereductionmonster <= DamageReductionMaxMonster)) && (countdowntryCreateCharacter != zero));
                                    /* Personatges tots creats en cas de tots els personatges haguin creat en menys de 3 intents començara la partida */
                                    if (countdowntryCreateCharacter != zero || (countdowntryCreateCharacter == zero && (hpmonster >= HpMinMonster && hpmonster <= HpMaxMonster) && (atkmonster >= AtkMinMonster && atkmonster <= AtkMaxMonster) && (damagereductionmonster >= DamageReductionMinMonster && damagereductionmonster <= DamageReductionMaxMonster)))
                                    {
                                        battleturns = one;
                                        tmpdamagereductionarcher = damagereductionarcher;
                                        tmpdamagereductionbarbarian = damagereductionbarbarian;
                                        tmpdamagereductionmagician = damagereductionmagician;
                                        tmpdamagereductiondruid = damagereductiondruid;
                                        tmphpmaxarcher = hparcher;
                                        tmphpmaxbarbarian = hpbarbarian;
                                        tmphpmaxmagician = hpmagician;
                                        tmphpmaxdruid = hpdruid;

                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine(MSGStartBattle);
                                        Console.WriteLine("");

                                        while (!(hparcher <= zero && hpbarbarian <= zero && hpdruid <= zero && hpmagician <= zero || hpmonster <= zero) && countdowntryAction != zero)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGTurn + battleturns + MSGTwoPoints);
                                            Console.WriteLine("");

                                            if (hparcher > zero)
                                            {
                                                countdowntryAction = maxcountdowntrys;
                                                errorActionGame = false;
                                                errorActionCooldown3 = false;
                                                do
                                                {
                                                    if (useraction == three && cooldownhabilityarcher >= one && cooldownhabilityarcher <= maxcooldown && errorActionCooldown3)
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
                                                    if (cooldownhabilityarcher == zero)
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
                                                } while (!(useraction >= one && useraction <= three) || (useraction == actionespecialhability && cooldownhabilityarcher != zero) && countdowntryAction != zero);
                                                if (useraction == actionatk)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGAtkArcher + atkarcher + MSGDamage + MSGReduccionDamageWhenAtkHerosTooMonster + (atkarcher - ((damagereductionmonster / onehundred) * atkarcher)) + MSGDamage + MSGHpMonster + (hpmonster - (atkarcher - ((damagereductionmonster / onehundred) * atkarcher))));
                                                    Console.WriteLine("");
                                                    hpmonster -= (atkarcher - ((damagereductionmonster / onehundred) * atkarcher));

                                                    if (cooldownhabilityarcher > zero)
                                                    {
                                                        cooldownhabilityarcher--;
                                                    }
                                                }
                                                else if (useraction == actionprotection)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGActionProtectArcher);
                                                    Console.WriteLine("");
                                                    damagereductionarcher += tmpdamagereductionarcher;

                                                    if (cooldownhabilityarcher > zero)
                                                    {
                                                        cooldownhabilityarcher--;
                                                    }
                                                }
                                                else if (useraction == actionespecialhability && cooldownhabilityarcher == zero)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGActionEspecialHabilityArcher);
                                                    Console.WriteLine("");
                                                    specialhabilityarcher = true;
                                                    cooldownhabilityarcher = maxcooldown;
                                                }
                                            }
                                            else if (hparcher <= zero)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine(MSGDeathArcher);
                                                Console.WriteLine("");
                                            }

                                            if (hpbarbarian > zero && hpmonster > zero && countdowntryAction != zero || (countdowntryAction == zero && (useraction >= one && useraction <= three)))
                                            {
                                                countdowntryAction = maxcountdowntrys;
                                                errorActionGame = false;
                                                errorActionCooldown3 = false;
                                                do
                                                {
                                                    if (useraction == three && cooldownhabilitybarbarian >= one && cooldownhabilitybarbarian <= maxcooldown && errorActionCooldown3)
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
                                                    Console.WriteLine(MSGActionBarbarian);
                                                    Console.WriteLine(MSGActionAtk);
                                                    Console.WriteLine(MSGActionProtect);
                                                    if (cooldownhabilitybarbarian == zero)
                                                    {
                                                        Console.WriteLine(MSGActionEspecialHability);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(MSGActionEspecialHability + MSGCooldown + cooldownhabilitybarbarian);
                                                    }
                                                    useraction = Convert.ToInt32(Console.ReadLine());
                                                    errorActionGame = true;
                                                    errorActionCooldown3 = true;
                                                    countdowntryAction--;
                                                } while (!(useraction >= one && useraction <= three) || (useraction == three && cooldownhabilitybarbarian != zero) && countdowntryAction != zero);
                                                if (useraction == actionatk)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGAtkBarbarian + atkbarbarian + MSGDamage + MSGReduccionDamageWhenAtkHerosTooMonster + (atkbarbarian - ((damagereductionmonster / onehundred) * atkbarbarian)) + MSGDamage + MSGHpMonster + (hpmonster - (atkbarbarian - ((damagereductionmonster / onehundred) * atkbarbarian))));
                                                    Console.WriteLine("");
                                                    hpmonster -= (atkbarbarian - ((damagereductionmonster / onehundred) * atkbarbarian));

                                                    if (cooldownhabilitybarbarian > zero)
                                                    {
                                                        cooldownhabilitybarbarian--;
                                                    }
                                                }
                                                else if (useraction == actionprotection)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGActionProtectBarbarian);
                                                    Console.WriteLine("");
                                                    damagereductionbarbarian += tmpdamagereductionbarbarian;

                                                    if (cooldownhabilitybarbarian > zero)
                                                    {
                                                        cooldownhabilitybarbarian--;
                                                    }
                                                }
                                                else if (useraction == actionespecialhability && cooldownhabilitybarbarian == zero)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGActionEspecialHabilityBarbarian);
                                                    Console.WriteLine("");
                                                    specialhabilitybarbarian = true;
                                                    cooldownhabilitybarbarian = maxcooldown;
                                                }
                                            }
                                            else if (hpbarbarian <= zero)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine(MSGDeathBarbarian);
                                                Console.WriteLine("");
                                            }

                                            if (hpmagician > zero && hpmonster > zero && countdowntryAction != zero || (countdowntryAction == zero && (useraction >= one && useraction <= three)))
                                            {
                                                countdowntryAction = maxcountdowntrys;
                                                errorActionGame = false;
                                                errorActionCooldown3 = false;
                                                do
                                                {
                                                    if (useraction == three && cooldownhabilitymagician >= one && cooldownhabilitymagician <= maxcooldown && errorActionCooldown3)
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
                                                    Console.WriteLine(MSGActionMagician);
                                                    Console.WriteLine(MSGActionAtk);
                                                    Console.WriteLine(MSGActionProtect);
                                                    if (cooldownhabilitymagician == zero)
                                                    {
                                                        Console.WriteLine(MSGActionEspecialHability);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(MSGActionEspecialHability + MSGCooldown + cooldownhabilitymagician);
                                                    }
                                                    useraction = Convert.ToInt32(Console.ReadLine());
                                                    errorActionGame = true;
                                                    errorActionCooldown3 = true;
                                                    countdowntryAction--;
                                                } while (!(useraction >= one && useraction <= three) || (useraction == three && cooldownhabilitymagician != zero) && countdowntryAction != zero);
                                                if (useraction == actionatk)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGAtkMagician + atkmagician + MSGDamage + MSGReduccionDamageWhenAtkHerosTooMonster + (atkmagician - ((damagereductionmonster / onehundred) * atkmagician)) + MSGDamage + MSGHpMonster + (hpmonster - (atkmagician - ((damagereductionmonster / onehundred) * atkmagician))));
                                                    Console.WriteLine("");
                                                    hpmonster -= (atkmagician - ((damagereductionmonster / onehundred) * atkmagician));

                                                    if (cooldownhabilitymagician > zero)
                                                    {
                                                        cooldownhabilitymagician--;
                                                    }
                                                }
                                                else if (useraction == actionprotection)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGActionProtectMagician);
                                                    Console.WriteLine("");
                                                    damagereductionmagician += tmpdamagereductionmagician;

                                                    if (cooldownhabilitymagician > zero)
                                                    {
                                                        cooldownhabilitymagician--;
                                                    }
                                                }
                                                else if (useraction == actionespecialhability && cooldownhabilitymagician == 0)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGActionEspecialHabilityMagician);
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGAtkMagicianEspecialHability + atkmagician * three + MSGDamage + MSGReduccionDamageWhenAtkHerosTooMonster + ((atkmagician * three) - ((damagereductionmonster / onehundred) * (atkmagician * three))) + MSGDamage + MSGHpMonster + (hpmonster - ((atkmagician * three) - ((damagereductionmonster / onehundred) * (atkmagician * three)))));
                                                    Console.WriteLine("");
                                                    hpmonster -= ((atkmagician * three) - ((damagereductionmonster / onehundred) * (atkmagician * three)));
                                                    cooldownhabilitymagician = maxcooldown;
                                                }
                                            }
                                            else if (hpmagician <= zero)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine(MSGDeathMagician);
                                                Console.WriteLine("");
                                            }

                                            if (hpdruid > zero && hpmonster > zero && countdowntryAction != zero || (countdowntryAction == zero && (useraction >= one && useraction <= three)))
                                            {
                                                countdowntryAction = three;
                                                errorActionGame = false;
                                                errorActionCooldown3 = false;
                                                do
                                                {
                                                    if (useraction == three && cooldownhabilitydruid >= one && cooldownhabilitydruid <= maxcooldown && errorActionCooldown3)
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
                                                    Console.WriteLine(MSGActionDruid);
                                                    Console.WriteLine(MSGActionAtk);
                                                    Console.WriteLine(MSGActionProtect);
                                                    if (cooldownhabilitydruid == zero)
                                                    {
                                                        Console.WriteLine(MSGActionEspecialHability);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(MSGActionEspecialHability + MSGCooldown + cooldownhabilitydruid);
                                                    }
                                                    useraction = Convert.ToInt32(Console.ReadLine());
                                                    errorActionGame = true;
                                                    errorActionCooldown3 = true;
                                                    countdowntryAction--;
                                                } while (!(useraction >= one && useraction <= three) || (useraction == three && cooldownhabilitydruid != zero) && countdowntryAction != zero);
                                                if (useraction == actionatk)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGAtkDruid + atkdruid + MSGDamage + MSGReduccionDamageWhenAtkHerosTooMonster + (atkdruid - ((damagereductionmonster / onehundred) * atkdruid)) + MSGDamage + MSGHpMonster + (hpmonster - (atkdruid - ((damagereductionmonster / onehundred) * atkdruid))));
                                                    Console.WriteLine("");
                                                    hpmonster -= (atkdruid - ((damagereductionmonster / onehundred) * atkdruid));

                                                    if (cooldownhabilitydruid > zero)
                                                    {
                                                        cooldownhabilitydruid--;
                                                    }
                                                }
                                                else if (useraction == actionprotection)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGActionProtectDruid);
                                                    Console.WriteLine("");
                                                    damagereductiondruid += tmpdamagereductiondruid;

                                                    if (cooldownhabilitydruid > zero)
                                                    {
                                                        cooldownhabilitydruid--;
                                                    }
                                                }
                                                else if (useraction == actionespecialhability && cooldownhabilitydruid == zero)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGActionEspecialHabilityDruid);
                                                    Console.WriteLine("");
                                                    /* Abans de cura a qualsevol personatge comprova si esta veu aquell personatje y despres si
                                                     quant cura si la seva vida actual + la curacio supera la vida maxima especificada per el usuari al principi */
                                                    if (hparcher > zero)
                                                    {
                                                        if (hparcher+healhabilitydruid > tmphpmaxarcher)
                                                        {
                                                            Console.WriteLine(MSGHpArcher + (tmphpmaxarcher));
                                                            hparcher = tmphpmaxarcher;
                                                        } else
                                                        {
                                                            Console.WriteLine(MSGHpArcher + (hparcher + healhabilitydruid));
                                                            hparcher += healhabilitydruid;
                                                        }
                                                        
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(MSGDeathNotHealArcher);
                                                    }
                                                    if (hpbarbarian > zero)
                                                    {
                                                        if (hpbarbarian+healhabilitydruid > tmphpmaxbarbarian)
                                                        {
                                                            Console.WriteLine(MSGHpBarbarian + (tmphpmaxbarbarian));
                                                            hpbarbarian = tmphpmaxbarbarian;
                                                        } else
                                                        {
                                                            Console.WriteLine(MSGHpBarbarian + (hpbarbarian + healhabilitydruid));
                                                            hpbarbarian += healhabilitydruid;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(MSGDeathNotHealBarbarian);
                                                    }
                                                    if (hpmagician > zero)
                                                    {
                                                        if (hpmagician+healhabilitydruid > tmphpmaxmagician) 
                                                        {
                                                            Console.WriteLine(MSGHpMagician + (tmphpmaxmagician));
                                                            hpmagician = tmphpmaxmagician;
                                                        } else 
                                                        {
                                                            Console.WriteLine(MSGHpMagician + (hpmagician + healhabilitydruid));
                                                            hpmagician += healhabilitydruid;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(MSGDeathNotHealMagician);
                                                    }
                                                    if (hpdruid > zero)
                                                    {
                                                        if (hpdruid+healhabilitydruid > tmphpmaxdruid)
                                                        {
                                                            Console.WriteLine(MSGHpDruid + (tmphpmaxdruid));
                                                            hpdruid = tmphpmaxdruid;
                                                        } else
                                                        {
                                                            Console.WriteLine(MSGHpDruid + (hpdruid + healhabilitydruid));
                                                            hpdruid += healhabilitydruid;
                                                        }
                                                    }
                                                    Console.WriteLine("");
                                                    cooldownhabilitydruid = maxcooldown;
                                                }
                                            }
                                            else if (hpdruid <= zero)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine(MSGDeathDruid);
                                                Console.WriteLine("");
                                            }
                                            if (hpmonster > zero && !(specialhabilityarcher) && countdowntryAction != zero || (countdowntryAction == zero && (useraction >= one && useraction <= three)))
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine(MSGMonsterAtkAll);
                                                if (hparcher > zero)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGAtkMonsterTooArcher + atkmonster + MSGDamage + MSGReduccionDamageWhenAtkMonsterTooArcher + (atkmonster - ((damagereductionarcher / onehundred) * atkmonster)) + MSGDamage + MSGHpArcher + (hparcher - (atkmonster - ((damagereductionarcher / onehundred) * atkmonster))));
                                                    hparcher -= (atkmonster - ((damagereductionarcher / onehundred) * atkmonster));
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGDeathArcher);
                                                }
                                                if (hpbarbarian > zero)
                                                {
                                                    Console.WriteLine("");
                                                    if (specialhabilitybarbarian)
                                                    {
                                                        Console.WriteLine(MSGAtkMonsterTooBarbarian + atkmonster + MSGDamage + MSGActivatedEspecialHabilityBarbarian + zero + MSGDamage + MSGHpBarbarian + hpbarbarian);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(MSGAtkMonsterTooBarbarian + atkmonster + MSGDamage + MSGReduccionDamageWhenAtkMonsterTooBarbarian + (atkmonster - ((damagereductionbarbarian / onehundred) * atkmonster)) + MSGDamage + MSGHpBarbarian + (hpbarbarian - (atkmonster - ((damagereductionbarbarian / onehundred) * atkmonster))));
                                                        hpbarbarian -= (atkmonster - ((damagereductionbarbarian / onehundred) * atkmonster));
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGDeathBarbarian);
                                                }
                                                if (hpmagician > zero)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGAtkMonsterTooMagician + atkmonster + MSGDamage + MSGReduccionDamageWhenAtkMonsterTooMagician + (atkmonster - ((damagereductionmagician / onehundred) * atkmonster)) + MSGDamage + MSGHpMagician + (hpmagician - (atkmonster - ((damagereductionmagician / onehundred) * atkmonster))));
                                                    hpmagician -= (atkmonster - ((damagereductionmagician / onehundred) * atkmonster));
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGDeathMagician);
                                                }
                                                if (hpdruid > zero)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGAtkMonsterTooDruid + atkmonster + MSGDamage + MSGReduccionDamageWhenAtkMonsterTooDruid + (atkmonster - ((damagereductiondruid / onehundred) * atkmonster)) + MSGDamage + MSGHpDruid + (hpdruid - (atkmonster - ((damagereductiondruid / onehundred) * atkmonster))));
                                                    hpdruid -= (atkmonster - ((damagereductiondruid / onehundred) * atkmonster));
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine(MSGDeathDruid);
                                                }
                                            }

                                            /* Comprova quant cooldown tenen les habilitats especial per treuralis de activas en cas de estarlo */
                                            if (specialhabilitybarbarian && cooldownhabilitybarbarian == three)
                                            {
                                                specialhabilitybarbarian = false;
                                            }
                                            if (specialhabilityarcher && cooldownhabilityarcher == four)
                                            {
                                                specialhabilityarcher = false;
                                            }

                                            /* Comprova si hi ha algun heroe que a utilitzat la 2 accio de defensarse i la reinicia */

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
                                            Console.WriteLine(MSGWinHeros);
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGPressToContinue);
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGWinMonster);
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine(MSGPressToContinue);
                                            Console.ReadKey();
                                        }
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine(MSGFailedCreateAllCharacters);
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine(MSGPressToContinue);
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(MSGFailedCreateAllCharacters);
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine(MSGPressToContinue);
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine(MSGFailedCreateAllCharacters);
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine(MSGPressToContinue);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine(MSGFailedCreateAllCharacters);
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine(MSGPressToContinue);
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine(MSGFailedCreateAllCharacters);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine(MSGPressToContinue);
                        Console.ReadKey();
                        Console.Clear();
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