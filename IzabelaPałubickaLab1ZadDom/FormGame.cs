using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzabelaPałubickaLab1ZadDom
{
    public partial class FormGame : Form
    {
        #region zmienne
        //zmienne zasobów w magazynie
        /// <summary>
        /// zmienna zawiera posiadaną ilość drewna
        /// </summary>
        int woodAmount;
        /// <summary>
        /// zmienna zawiera posiadaną ilość kamienia
        /// </summary>
        int stoneAmount;
        /// <summary>
        /// zmienna zawiera posiadaną ilość plonów
        /// </summary>
        int cropsAmount;
        /// <summary>
        /// zmienna zawiera posiadaną ilość stali
        /// </summary>
        int steelAmount;

        /// <summary>
        /// zmienna zawiera ilość wymian
        /// </summary>
        int changingAmount;

        //zmienne lvl budynków
        /// <summary>
        /// lvl wybranego budynku
        /// </summary>
        int buildingLvl;
        /// <summary>
        /// zmienna przechowująca poziom rozbudowy tartaku (drewno)
        /// </summary>
        int sawmillLvl = 1;
        /// <summary>
        /// zmienna przypisująca poziom rozbudowy kamieniołomów (kamień)
        /// </summary>
        int quarryLvl = 1;
        /// <summary>
        /// zmienna przypisująca poziom rozbudowy spichlerza (plony)
        /// </summary>
        int garnerLvl = 1;
        /// <summary>
        /// zmienna przypisująca poziom rozbudowy huty stali (stal)
        /// </summary>
        int steelMillLvl = 1;
        /// <summary>
        /// zmienna przypisująca poziom rozbudowy murów (obrona miasta)
        /// </summary>
        int wallLvl = 1;
        /// <summary>
        /// zmienna przypisująca poziom rozbudowy koszar (armia)
        /// </summary>
        int barrackLvl = 1;

        //zmienne potrzebnych zasobów
        /// <summary>
        /// zmienna określająca ilość drewna potrzebnego do rozbudowy miasta/wojska
        /// </summary>
        int woodResourceAmount = 0;
        /// <summary>
        /// zmienna określająca ilość kamieni potrzebnych do rozbudowy miasta/wojska
        /// </summary>
        int stoneResourceAmount = 0;
        /// <summary>
        /// zmienna określająca ilość plonów potrzebnych do rozbudowy miasta/wojska
        /// </summary>
        int cropsResourceAmount = 0;
        /// <summary>
        /// zmienna określająca ilość stali potrzebnej do rozbudowy miasta/wojska
        /// </summary>
        int steelResourceAmount = 0;

        //zmienne militarne
        /// <summary>
        /// zmienna określa ilość  konkretnego typu wojska do budowy
        /// </summary>
        int newMilitaryAmount = 0;
        /// <summary>
        /// zmienna przechowująca obecny stan konkretnego typu wojska
        /// </summary>
        int actualMilitaryAmount;

        //zmienne zegara
        /// <summary>
        /// zmienna określa ilość sekund
        /// </summary>
        int secondCounter = 0;
        /// <summary>
        /// zmienna określa ilość minut
        /// </summary>
        int minuteCounter = 0;
        /// <summary>
        /// zmienna określa ilość godzin
        /// </summary>
        int hourCounter = 0;

        /// <summary>
        /// zmienna podlicza całkowity czas
        /// </summary>
        int timeCounter;

        /// <summary>
        /// zmienna odliczająca czas informowania o ataku
        /// </summary>
        int attackTime;

        #endregion
        public FormGame()
        {
            InitializeComponent();
            //uruchomienie zegara
            timerCounter.Start();
        }
        /// <summary>
        /// Funkcja wymieniająca zasoby
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirmExchange_Click(object sender, EventArgs e)
        {
            //przydzielenie zmiennym zasobów ich wartości z textBoxów
            woodAmount = Int32.Parse(textBoxWoodAmount.Text);
            stoneAmount = Int32.Parse(textBoxStoneAmount.Text);
            cropsAmount = Int32.Parse(textBoxCropsAmount.Text);
            steelAmount = Int32.Parse(textBoxSteelAmount.Text);

            //przydzielenie zmiennym ilości wymian jej wartości z textBoxa
            changingAmount = Int32.Parse(domainUpDownExchangingResourceAmount.Text);

            //warunki wymiany drewna
            if (domainUpDownExchengingFirstResource.Text == "drewno")
            {
                //jesli drewno chcemy wymienić na stal (5xdrewno = 1xstal)
                if (domainUpDownExchengingSecondResource.Text == "stal")
                {
                    //jesli mamy wystarczajaca ilosc drewna
                    if (woodAmount > 5 * changingAmount)
                    {
                        //zmniejszamy ilosc drewna 
                        woodAmount -= 5 * changingAmount;
                        //zwiekszamy ilosc stali
                        steelAmount += changingAmount;
                        //wyzerowanie ilości wymian
                        changingAmount = 0;
                    }
                }
                //jesli drewno chcemy wymienić na kamień (3xdrewno = 1xkamień)
                else if (domainUpDownExchengingSecondResource.Text == "kamień")
                {
                    //jesli mamy wystarczajaca ilosc drewna
                    if (woodAmount > 3 * changingAmount)
                    {
                        //zmniejszamy ilosc drewna 
                        woodAmount -= 3 * changingAmount;
                        //zwiekszamy ilosc kamienia
                        stoneAmount += changingAmount;
                        //wyzerowanie ilości wymian
                        changingAmount = 0;
                    }
                }
                //jesli drewno chcemy wymienić na plony (1xdrewno = 3xplony)
                else if (domainUpDownExchengingSecondResource.Text == "plony")
                {
                    //jesli mamy wystarczajaca ilosc drewna
                    if (woodAmount > changingAmount)
                    {
                        //zmniejszamy ilosc drewna 
                        woodAmount -= changingAmount;
                        //zwiekszamy ilosc plonów
                        cropsAmount += 3 * changingAmount;
                        //wyzerowanie ilości wymian
                        changingAmount = 0;
                    }
                }
            }
            //warunki wymiany kamienia
            else if (domainUpDownExchengingFirstResource.Text == "kamień")
            {
                //jesli kamień chcemy wymienić na stal (3xkamień = 1xstal)
                if (domainUpDownExchengingSecondResource.Text == "stal")
                {
                    //jesli mamy wystarczajaca ilosc kamienia
                    if (stoneAmount > 3 * changingAmount)
                    {
                        //zmniejszamy ilosc kamienia 
                        stoneAmount -= 3 * changingAmount;
                        //zwiekszamy ilosc stali
                        steelAmount += changingAmount;
                        //wyzerowanie ilości wymian
                        changingAmount = 0;
                    }
                }
                //jesli kamień chcemy wymienić na drewano (1xkamień = 3xdrewna)
                else if (domainUpDownExchengingSecondResource.Text == "drewno")
                {
                    //jesli mamy wystarczajaca ilosc drewna
                    if (stoneAmount > changingAmount)
                    {
                        //zmniejszamy ilosc kamienia 
                        stoneAmount -= changingAmount;
                        //zwiekszamy ilosc drewna
                        woodAmount += 3 * changingAmount;
                        //wyzerowanie ilości wymian
                        changingAmount = 0;
                    }
                }
                //jesli kamień chcemy wymienić na plony (1xkamień = 5xplony)
                else if (domainUpDownExchengingSecondResource.Text == "plony")
                {
                    //jesli mamy wystarczajaca ilosc drewna
                    if (stoneAmount > changingAmount)
                    {
                        //zmniejszamy ilosc kamienia 
                        stoneAmount -= changingAmount;
                        //zwiekszamy ilosc plonów
                        cropsAmount += 5 * changingAmount;
                        //wyzerowanie ilości wymian
                        changingAmount = 0;
                    }
                }
            }
            //warunki wymiany plonów
            else if (domainUpDownExchengingFirstResource.Text == "plony")
            {
                //jesli plony chcemy wymienić na stal (8xplonów = 1xstal)
                if (domainUpDownExchengingSecondResource.Text == "stal")
                {
                    //jesli mamy wystarczajaca ilosc plonów
                    if (cropsAmount > 8 * changingAmount)
                    {
                        //zmniejszamy ilosc plonów 
                        cropsAmount -= 8 * changingAmount;
                        //zwiekszamy ilosc stali
                        steelAmount += changingAmount;
                        //wyzerowanie ilości wymian
                        changingAmount = 0;
                    }
                }
                //jesli plony chcemy wymienić na drewano (3xplony = 1xdrewno)
                else if (domainUpDownExchengingSecondResource.Text == "drewno")
                {
                    //jesli mamy wystarczajaca ilosc plonów
                    if (cropsAmount > 3 * changingAmount)
                    {
                        //zmniejszamy ilosc kamienia 
                        cropsAmount -= 3 * changingAmount;
                        //zwiekszamy ilosc drewna
                        woodAmount += changingAmount;
                        //wyzerowanie ilości wymian
                        changingAmount = 0;
                    }
                }
                //jesli kamień chcemy wymienić na plony (1xkamień = 5xplony)
                else if (domainUpDownExchengingSecondResource.Text == "kamień")
                {
                    //jesli mamy wystarczajaca ilosc drewna
                    if (cropsAmount > 5 * changingAmount)
                    {
                        //zmniejszamy ilosc plonów 
                        cropsAmount -= 5 * changingAmount;
                        //zwiekszamy ilosc kamienia
                        stoneAmount += changingAmount;
                        //wyzerowanie ilości wymian
                        changingAmount = 0;
                    }
                }
            }
            //warunki wymiany stali
            else if (domainUpDownExchengingFirstResource.Text == "stal")
            {
                //jesli plony chcemy wymienić na stal (1xstal = 8xplony)
                if (domainUpDownExchengingSecondResource.Text == "plony")
                {
                    //jesli mamy wystarczajaca ilosc stali
                    if (steelAmount > changingAmount)
                    {
                        //zmniejszamy ilosc stali 
                        steelAmount -= changingAmount;
                        //zwiekszamy ilosc plonów
                        cropsAmount += 8 * changingAmount;
                        //wyzerowanie ilości wymian
                        changingAmount = 0;
                    }
                }
                //jesli stal chcemy wymienić na drewano (1xstal = 5xdrewna)
                else if (domainUpDownExchengingSecondResource.Text == "drewno")
                {
                    //jesli mamy wystarczajaca ilosc stali
                    if (steelAmount > changingAmount)
                    {
                        //zmniejszamy ilosc stali 
                        steelAmount -= changingAmount;
                        //zwiekszamy ilosc drewna
                        woodAmount += 5 * changingAmount;
                        //wyzerowanie ilości wymian
                        changingAmount = 0;
                    }
                }
                //jesli stal chcemy wymienić na kamień (1xstal = 3xkamienia)
                else if (domainUpDownExchengingSecondResource.Text == "kamień")
                {
                    //jesli mamy wystarczajaca ilosc stali
                    if (steelAmount > changingAmount)
                    {
                        //zmniejszamy ilosc stali 
                        steelAmount -= changingAmount;
                        //zwiekszamy ilosc kamienia
                        stoneAmount += 3 * changingAmount;
                        //wyzerowanie ilości wymian
                        changingAmount = 0;
                    }
                }
            }
            //zmiana wartości liczbowej na zmienną typu string dla zasobów w magazynie czyli txtBoxów
            textBoxWoodAmount.Text = woodAmount.ToString();
            textBoxStoneAmount.Text = stoneAmount.ToString();
            textBoxCropsAmount.Text = cropsAmount.ToString();
            textBoxSteelAmount.Text = steelAmount.ToString();
            //zmiana wartości liczbowej na zmienną typu string dla ilości wymian czyli txtBoxa
            domainUpDownExchangingResourceAmount.Text = changingAmount.ToString();
        }

        /// <summary>
        /// Funkcja odpowiadająca za rozbudowe budynków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirmBuildingTown_Click(object sender, EventArgs e)
        {
            //zmienna pozwalająca na budowe
            bool buildingPermit = false;

            //przydzielenie zmiennym zasobów w magazynie ich wartości z textBoxów
            woodAmount = Int32.Parse(textBoxWoodAmount.Text);
            stoneAmount = Int32.Parse(textBoxStoneAmount.Text);
            cropsAmount = Int32.Parse(textBoxCropsAmount.Text);
            steelAmount = Int32.Parse(textBoxSteelAmount.Text);

            //przydzielenie zmiennym zasobów potrzebnych do budowy ich wartości z textBoxów
            woodResourceAmount = Int32.Parse(textBoxAmountWoodForBuilding.Text);
            stoneResourceAmount = Int32.Parse(textBoxAmountStoneForBuilding.Text);
            cropsResourceAmount = Int32.Parse(textBoxAmountCropsForBuilding.Text);
            steelResourceAmount = Int32.Parse(textBoxAmountSteelForBuilding.Text);

            //wybrano do rozbudowy tartak
            if (domainUpDownBuildingList.Text == "tartak" && sawmillLvl < 3)
            {
                //pozwolenie na budowe
                buildingPermit = true;
                //zwiększenie poziomu budowli
                sawmillLvl++;
                //przypisanie nowej wartości poziomu
                buildingLvl = sawmillLvl;
            }
            //wybrano do rozbudowy kamieniołomy
            else if (domainUpDownBuildingList.Text == "kamieniołomy" && quarryLvl < 3)
            {
                //pozwolenie na budowe
                buildingPermit = true;
                //zwiększenie poziomu budowli
                quarryLvl++;
                //przypisanie nowej wartości poziomu
                buildingLvl = quarryLvl;
            }
            //wybrano do rozbudowy spichlerz
            else if (domainUpDownBuildingList.Text == "spichlerz" && garnerLvl < 3)
            {
                //pozwolenie na budowe
                buildingPermit = true;
                //zwiększenie poziomu budowli
                garnerLvl++;
                //przypisanie nowej wartości poziomu
                buildingLvl = garnerLvl;
            }
            //wybrano do rozbudowy hutę stali
            else if (domainUpDownBuildingList.Text == "huta stali" && steelMillLvl < 3)
            {
                //pozwolenie na budowe
                buildingPermit = true;
                //zwiększenie poziomu budowli
                steelMillLvl++;
                //przypisanie nowej wartości poziomu
                buildingLvl = steelMillLvl;
            }
            //wybrano do rozbudowy mury obronne
            else if (domainUpDownBuildingList.Text == "mury" && wallLvl < 3)
            {
                //pozwolenie na budowe
                buildingPermit = true;
                //zwiększenie poziomu budowli
                wallLvl++;
                //przypisanie nowej wartości poziomu
                buildingLvl = wallLvl;
            }
            //wybrano do rozbudowy koszary
            else if (domainUpDownBuildingList.Text == "koszary" && barrackLvl < 3)
            {
                //pozwolenie na budowe
                buildingPermit = true;
                //zwiększenie poziomu budowli
                barrackLvl++;
                //przypisanie nowej wartości poziomu
                buildingLvl = barrackLvl;
            }

            //zgoda na budowe, poziom rozbudowy nie przekracza maksymalnego pozmiomu równemu 3
            //trzeba sprawdzić czy jest wystarczająco surowców
            if (buildingPermit == true && woodAmount >= woodResourceAmount && stoneAmount >= stoneResourceAmount &&
                cropsAmount >= cropsResourceAmount && steelAmount >= steelResourceAmount)
            {
                //odjęcie ilości drewna wymaganych do rozbudowy
                woodAmount -= woodResourceAmount;
                //odjęcie ilości kamienia wymaganych do rozbudowy
                stoneAmount -= stoneResourceAmount;
                //odjęcie ilości plonów wymaganych do rozbudowy
                cropsAmount -= cropsResourceAmount;
                //odjęcie ilości stali wymaganych do rozbudowy
                steelAmount -= steelResourceAmount;

                //przypisanie nowego poziomu budynku do textBoxa
                textBoxBuildingLvl.Text = buildingLvl.ToString();
            }
            //zmiana wartości liczbowej na zmienną typu string dla zasobów w magazynie w txtBoxaxh
            textBoxWoodAmount.Text = woodAmount.ToString();
            textBoxStoneAmount.Text = stoneAmount.ToString();
            textBoxCropsAmount.Text = cropsAmount.ToString();
            textBoxSteelAmount.Text = steelAmount.ToString();
        }
        /// <summary>
        /// Funkcja przypisuje warunki wymiany w txtBoxach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void domainUpDownExchengingFirstResource_SelectedItemChanged(object sender, EventArgs e)
        {
            //zmienna służąca do określania ilości zasobów potrzebych do wymiany 
            int firstResourceAmount = 0;
            //zmienna służąca do określania ilości zasobów, które można otrzymać podczas wymiany 
            int secondResourceAmount = 0;

            //przydzielenie zmiennej ilości wymian wartości z textBoxu
            changingAmount = Int32.Parse(domainUpDownExchangingResourceAmount.Text);

            //jeśli wybrano stal
            if (domainUpDownExchengingFirstResource.Text == "stal")
            {
                //jesli wybrano kamień
                if (domainUpDownExchengingSecondResource.Text == "kamień")
                {
                    //przypisanie potrzebnej ilości stali do wymiany
                    firstResourceAmount = changingAmount;
                    textBoxFirstResourceAmount.Text = firstResourceAmount.ToString();
                    //przypisanie ilości kamienia jaką się otrzyma w zamian
                    secondResourceAmount = 3 * changingAmount;
                    textBoxSecondResourceAmount.Text = secondResourceAmount.ToString();
                }
                //jeśli wybrano drewno
                if (domainUpDownExchengingSecondResource.Text == "drewno")
                {
                    //przypisanie potrzebnej ilości stali do wymiany
                    firstResourceAmount = changingAmount;
                    textBoxFirstResourceAmount.Text = firstResourceAmount.ToString();
                    //przypisanie ilości drewna jaką się otrzyma w zamian
                    secondResourceAmount = 5 * changingAmount;
                    textBoxSecondResourceAmount.Text = secondResourceAmount.ToString();
                }
                //jeśli wybrano plony
                if (domainUpDownExchengingSecondResource.Text == "plony")
                {
                    //przypisanie potrzebnej ilości stali do wymiany
                    firstResourceAmount = changingAmount;
                    textBoxFirstResourceAmount.Text = firstResourceAmount.ToString();
                    //przypisanie ilości plonów jaką się otrzyma w zamian
                    secondResourceAmount = 8 * changingAmount;
                    textBoxSecondResourceAmount.Text = secondResourceAmount.ToString();
                }
            }
            //jeśli wybrano kamień
            else if (domainUpDownExchengingFirstResource.Text == "kamień")
            {
                //jesli wybrano stal
                if (domainUpDownExchengingSecondResource.Text == "stal")
                {
                    //przypisanie potrzebnej ilości kamienia do wymiany
                    firstResourceAmount = 3 * changingAmount;
                    textBoxFirstResourceAmount.Text = firstResourceAmount.ToString();
                    //przypisanie ilości stali jaką się otrzyma w zamian
                    secondResourceAmount = changingAmount;
                    textBoxSecondResourceAmount.Text = secondResourceAmount.ToString();
                }
                //jeśli wybrano drewno
                if (domainUpDownExchengingSecondResource.Text == "drewno")
                {
                    //przypisanie potrzebnej ilości kamienia do wymiany
                    firstResourceAmount = changingAmount;
                    textBoxFirstResourceAmount.Text = firstResourceAmount.ToString();
                    //przypisanie ilości drewna jaką się otrzyma w zamian
                    secondResourceAmount = 3 * changingAmount;
                    textBoxSecondResourceAmount.Text = secondResourceAmount.ToString();
                }
                //jeśli wybrano plony
                if (domainUpDownExchengingSecondResource.Text == "plony")
                {
                    //przypisanie potrzebnej ilości kamienia do wymiany
                    firstResourceAmount = changingAmount;
                    textBoxFirstResourceAmount.Text = firstResourceAmount.ToString();
                    //przypisanie ilości plonów jaką się otrzyma w zamian
                    secondResourceAmount = 5 * changingAmount;
                    textBoxSecondResourceAmount.Text = secondResourceAmount.ToString();
                }
            }
            //jeśli wybrano drewno
            else if (domainUpDownExchengingFirstResource.Text == "drewno")
            {
                //jesli wybrano stal
                if (domainUpDownExchengingSecondResource.Text == "stal")
                {
                    //przypisanie potrzebnej ilości drewna do wymiany
                    firstResourceAmount = 5 * changingAmount;
                    textBoxFirstResourceAmount.Text = firstResourceAmount.ToString();
                    //przypisanie ilości stali jaką się otrzyma w zamian
                    secondResourceAmount = changingAmount;
                    textBoxSecondResourceAmount.Text = secondResourceAmount.ToString();
                }
                //jeśli wybrano kamienia
                if (domainUpDownExchengingSecondResource.Text == "kamień")
                {
                    //przypisanie potrzebnej ilości drewna do wymiany
                    firstResourceAmount = 3 * changingAmount;
                    textBoxFirstResourceAmount.Text = firstResourceAmount.ToString();
                    //przypisanie ilości kamienia jaką się otrzyma w zamian
                    secondResourceAmount = changingAmount;
                    textBoxSecondResourceAmount.Text = secondResourceAmount.ToString();
                }
                //jeśli wybrano plony
                if (domainUpDownExchengingSecondResource.Text == "plony")
                {
                    //przypisanie potrzebnej ilości drewna do wymiany
                    firstResourceAmount = changingAmount;
                    textBoxFirstResourceAmount.Text = firstResourceAmount.ToString();
                    //przypisanie ilości plonów jaką się otrzyma w zamian
                    secondResourceAmount = 3 * changingAmount;
                    textBoxSecondResourceAmount.Text = secondResourceAmount.ToString();
                }
            }
            //jeśli wybrano plony
            else if (domainUpDownExchengingFirstResource.Text == "plony")
            {
                //jesli wybrano stal
                if (domainUpDownExchengingSecondResource.Text == "stal")
                {
                    //przypisanie potrzebnej ilości plonów do wymiany
                    firstResourceAmount = 8 * changingAmount;
                    textBoxFirstResourceAmount.Text = firstResourceAmount.ToString();
                    //przypisanie ilości stali jaką się otrzyma w zamian
                    secondResourceAmount = changingAmount;
                    textBoxSecondResourceAmount.Text = secondResourceAmount.ToString();
                }
                //jeśli wybrano kamienia
                if (domainUpDownExchengingSecondResource.Text == "kamień")
                {
                    //przypisanie potrzebnej ilości plonów do wymiany
                    firstResourceAmount = 5 * changingAmount;
                    textBoxFirstResourceAmount.Text = firstResourceAmount.ToString();
                    //przypisanie ilości kamienia jaką się otrzyma w zamian
                    secondResourceAmount = changingAmount;
                    textBoxSecondResourceAmount.Text = secondResourceAmount.ToString();
                }
                //jeśli wybrano drewno
                if (domainUpDownExchengingSecondResource.Text == "drewno")
                {
                    //przypisanie potrzebnej ilości plonów do wymiany
                    firstResourceAmount = 3 * changingAmount;
                    textBoxFirstResourceAmount.Text = firstResourceAmount.ToString();
                    //przypisanie ilości drewna jaką się otrzyma w zamian
                    secondResourceAmount = changingAmount;
                    textBoxSecondResourceAmount.Text = secondResourceAmount.ToString();
                }
            }
            //jeśli nie wybrano wartości w co najmniej jednym domainUpDown
            else if (domainUpDownExchengingFirstResource.Text == "wybierz" && domainUpDownExchengingSecondResource.Text == "wybierz")
            {
                //przypisanie zera bo nie ma parametru wymiany
                textBoxFirstResourceAmount.Text = firstResourceAmount.ToString();
                //przypisanie zera bo nie ma parametru wymiany
                textBoxSecondResourceAmount.Text = secondResourceAmount.ToString();
            }
        }
 
        /// <summary>
        /// Funkcja ktora wyświetla w textBoksach co jest potrzebna do rozbudowy budynków i jaki jest
        /// poziom rozbudowy budynku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void domainUpDownBuildingList_SelectedItemChanged(object sender, EventArgs e)
        {
            //jeśli nie wybrano budynku
            if (domainUpDownBuildingList.Text == "wybierz budynek")
            {
                //przypisanie zer do textBoxów
                woodResourceAmount = 0;
                stoneResourceAmount = 0;
                cropsResourceAmount = 0;
                steelResourceAmount = 0;
                buildingLvl = 0;
            }
            //jeśli wybrano tartak
            else if (domainUpDownBuildingList.Text == "tartak")
            {
                //przypisanie ilości drewna wymaganych do rozbudowy
                woodResourceAmount = 6 * sawmillLvl;
                //przypisanie ilości kamienia wymaganych do rozbudowy
                stoneResourceAmount = 3 * sawmillLvl;
                //przypisanie ilości plonów wymaganych do rozbudowy
                cropsResourceAmount = 7 *sawmillLvl;
                //przypisanie ilości stali wymaganych do rozbudowy
                steelResourceAmount = 2*sawmillLvl;
                //przypisanie lvl budowli
                buildingLvl = sawmillLvl;
            }
            //jeśli wybrano kamieniołomy
            else if (domainUpDownBuildingList.Text == "kamieniołomy")
            {
                //przypisanie ilości drewna wymaganych do rozbudowy
                woodResourceAmount = 5 * quarryLvl;
                //przypisanie ilości kamienia wymaganych do rozbudowy
                stoneResourceAmount = 5 * quarryLvl;
                //przypisanie ilości plonów wymaganych do rozbudowy
                cropsResourceAmount = 7 * quarryLvl;
                //przypisanie ilości stali wymaganych do rozbudowy
                steelResourceAmount = 3 * quarryLvl;
                //przypisanie lvl budowli
                buildingLvl = quarryLvl;
            }
            //jeśli wybrano spichlerz
            else if (domainUpDownBuildingList.Text == "spichlerz")
            {
                //przypisanie ilości drewna wymaganych do rozbudowy
                woodResourceAmount = 5 * garnerLvl;
                //przypisanie ilości kamienia wymaganych do rozbudowy
                stoneResourceAmount = 3 * garnerLvl;
                //przypisanie ilości plonów wymaganych do rozbudowy
                cropsResourceAmount = 9 * garnerLvl;
                //przypisanie ilości stali wymaganych do rozbudowy
                steelResourceAmount = 3 * garnerLvl;
                //przypisanie lvl budowli
                buildingLvl = garnerLvl;
            }
            //jeśli wybrano hutę stali
            else if (domainUpDownBuildingList.Text == "huta stali")
            {
                //przypisanie ilości drewna wymaganych do rozbudowy
                woodResourceAmount = 5 * steelMillLvl;
                //przypisanie ilości kamienia wymaganych do rozbudowy
                stoneResourceAmount = 3 * steelMillLvl;
                //przypisanie ilości plonów wymaganych do rozbudowy
                cropsResourceAmount = 7 * steelMillLvl;
                //przypisanie ilości stali wymaganych do rozbudowy
                steelResourceAmount = 5 * steelMillLvl;
                //przypisanie lvl budowli
                buildingLvl = steelMillLvl;
            }
            //jeśli wybrano mury obronne
            else if (domainUpDownBuildingList.Text == "mury")
            {
                //przypisanie ilości drewna wymaganych do rozbudowy
                woodResourceAmount = 7 * wallLvl;
                //przypisanie ilości kamienia wymaganych do rozbudowy
                stoneResourceAmount = 6 * wallLvl;
                //przypisanie ilości plonów wymaganych do rozbudowy
                cropsResourceAmount = 10 * wallLvl;
                //przypisanie ilości stali wymaganych do rozbudowy
                steelResourceAmount = 4 * wallLvl;
                //przypisanie lvl budowli
                buildingLvl = wallLvl;
            }
            //jeśli wybrano koszary
            else if (domainUpDownBuildingList.Text == "koszary")
            {
                //przypisanie ilości drewna wymaganych do rozbudowy
                woodResourceAmount = 5 * barrackLvl;
                //przypisanie ilości kamienia wymaganych do rozbudowy
                stoneResourceAmount = 5 * barrackLvl;
                //przypisanie ilości plonów wymaganych do rozbudowy
                cropsResourceAmount = 8 * barrackLvl;
                //przypisanie ilości stali wymaganych do rozbudowy
                steelResourceAmount = 5 * barrackLvl;
                //przypisanie lvl budowli
                buildingLvl = barrackLvl;
            }
            //przypisanie ilości surowców do textBoxów
            textBoxAmountWoodForBuilding.Text = woodResourceAmount.ToString();
            textBoxAmountStoneForBuilding.Text = stoneResourceAmount.ToString();
            textBoxAmountCropsForBuilding.Text = cropsResourceAmount.ToString();
            textBoxAmountSteelForBuilding.Text = steelResourceAmount.ToString();
            //przypisanie poziomu budynku do textBoxa
            textBoxBuildingLvl.Text = buildingLvl.ToString();
        }

        /// <summary>       
        /// Funkcja która wyświetla w tekstBoxach co jest potrzebne do budowy wojska
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void domainUpDownArmyBuilding_SelectedItemChanged(object sender, EventArgs e)
        {
            //przypisanie do zmiennej ilości wojska do stworzenia
            newMilitaryAmount = Int32.Parse(domainUpDownMilitaryAmount.Text);

            //jeśli nie wybrano woja
            if (domainUpDownArmyBuildingList.Text == "wybierz")
            {
                //przypisanie zer do textBoxów
                woodResourceAmount = 0;
                stoneResourceAmount = 0;
                cropsResourceAmount = 0;
                steelResourceAmount = 0;
            }
            //jeśli wybrano piechotę
            else if (domainUpDownArmyBuildingList.Text == "piechota")
            {
                //przypisanie ilości drewna wymaganych do stworzenia wojska
                woodResourceAmount = 1 * newMilitaryAmount;
                //przypisanie ilości kamienia wymaganych do stworzenia wojska
                stoneResourceAmount = 1 * newMilitaryAmount;
                //przypisanie ilości plonów wymaganych do stworzenia wojska
                cropsResourceAmount = 2 * newMilitaryAmount;
                //przypisanie ilości stali wymaganych do stworzenia wojska
                steelResourceAmount = 1 * newMilitaryAmount;
            }
            //jeśli wybrano łuczników
            else if (domainUpDownArmyBuildingList.Text == "łucznicy")
            {
                //przypisanie ilości drewna wymaganych do stworzenia wojska
                woodResourceAmount = 3 * newMilitaryAmount;
                //przypisanie ilości kamienia wymaganych do stworzenia wojska
                stoneResourceAmount = 2 * newMilitaryAmount;
                //przypisanie ilości plonów wymaganych do stworzenia wojska
                cropsResourceAmount = 3 * newMilitaryAmount;
                //przypisanie ilości stali wymaganych do stworzenia wojska
                steelResourceAmount = 2 * newMilitaryAmount;
            }
            //jeśli wybrano kawalerie
            else if (domainUpDownArmyBuildingList.Text == "kawaleria")
            {
                //przypisanie ilości drewna wymaganych do stworzenia wojska
                woodResourceAmount = 3 * newMilitaryAmount;
                //przypisanie ilości kamienia wymaganych do stworzenia wojska
                stoneResourceAmount = 4 * newMilitaryAmount;
                //przypisanie ilości plonów wymaganych do stworzenia wojska
                cropsResourceAmount = 5 * newMilitaryAmount;
                //przypisanie ilości stali wymaganych do stworzenia wojska
                steelResourceAmount = 4 * newMilitaryAmount;
            }

            //przypisanie ilości surowców do textBoxów
            textBoxAmountWoodForArmy.Text = woodResourceAmount.ToString();
            textBoxAmountStoneForArmy.Text = stoneResourceAmount.ToString();
            textBoxAmountCropsForArmy.Text = cropsResourceAmount.ToString();
            textBoxAmountSteelForArmy.Text = steelResourceAmount.ToString();
        }

        /// <summary>
        /// Funkcja budująca wojsko
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildingArmy_Click(object sender, EventArgs e)
        {
            //przypisanie do zmiennej ilości wojska do stworzenia
            newMilitaryAmount = Int32.Parse(domainUpDownMilitaryAmount.Text);

            //przydzielenie zmiennym zasobów w magazynie ich wartości z textBoxów
            woodAmount = Int32.Parse(textBoxWoodAmount.Text);
            stoneAmount = Int32.Parse(textBoxStoneAmount.Text);
            cropsAmount = Int32.Parse(textBoxCropsAmount.Text);
            steelAmount = Int32.Parse(textBoxSteelAmount.Text);

            //przydzielenie zmiennym zasobów potrzebnych do budowy ich wartości z textBoxów
            woodResourceAmount = Int32.Parse(textBoxAmountWoodForArmy.Text);
            stoneResourceAmount = Int32.Parse(textBoxAmountStoneForArmy.Text);
            cropsResourceAmount = Int32.Parse(textBoxAmountCropsForArmy.Text);
            steelResourceAmount = Int32.Parse(textBoxAmountSteelForArmy.Text);

            //warunek jeśli jest wystarczajaco surowców
            if(newMilitaryAmount != 0 && woodAmount >= woodResourceAmount && stoneAmount >= stoneResourceAmount &&
               cropsAmount >= cropsResourceAmount && steelAmount >= steelResourceAmount)
            {
                //jeśli wybrano piechotę do budowy
                if (domainUpDownArmyBuildingList.Text == "piechota")
                {
                    //odjęcie ilości drewna wymaganych do rozbudowy
                    woodAmount -= woodResourceAmount;
                    //odjęcie ilości kamienia wymaganych do rozbudowy
                    stoneAmount -= stoneResourceAmount;
                    //odjęcie ilości plonów wymaganych do rozbudowy
                    cropsAmount -= cropsResourceAmount;
                    //odjęcie ilości stali wymaganych do rozbudowy
                    steelAmount -= steelResourceAmount;
                    //dodanie nowej piechoty do txtBoxa
                    actualMilitaryAmount = Int32.Parse(textBoxInfantryAmount.Text) + newMilitaryAmount;
                    textBoxInfantryAmount.Text = actualMilitaryAmount.ToString();
                }
                //jeśli wybrano łuczników do budowy
                else if (domainUpDownArmyBuildingList.Text == "łucznicy")
                {
                    //odjęcie ilości drewna wymaganych do rozbudowy
                    woodAmount -= woodResourceAmount;
                    //odjęcie ilości kamienia wymaganych do rozbudowy
                    stoneAmount -= stoneResourceAmount;
                    //odjęcie ilości plonów wymaganych do rozbudowy
                    cropsAmount -= cropsResourceAmount;
                    //odjęcie ilości stali wymaganych do rozbudowy
                    steelAmount -= steelResourceAmount;
                    //dodanie nowych łuczników do txtBoxa
                    actualMilitaryAmount = Int32.Parse(textBoxArcherAmount.Text) + newMilitaryAmount;
                    textBoxArcherAmount.Text = actualMilitaryAmount.ToString();
                }
                //jeśli wybrano kawalerie do budowy
                else if (domainUpDownArmyBuildingList.Text == "kawaleria")
                {
                    //odjęcie ilości drewna wymaganych do rozbudowy
                    woodAmount -= woodResourceAmount;
                    //odjęcie ilości kamienia wymaganych do rozbudowy
                    stoneAmount -= stoneResourceAmount;
                    //odjęcie ilości plonów wymaganych do rozbudowy
                    cropsAmount -= cropsResourceAmount;
                    //odjęcie ilości stali wymaganych do rozbudowy
                    steelAmount -= steelResourceAmount;
                    //dodanie nowej kawalerii do textBoxa
                    actualMilitaryAmount = Int32.Parse(textBoxCavalaryAmount.Text) + newMilitaryAmount;
                    textBoxCavalaryAmount.Text = actualMilitaryAmount.ToString();
                }

                //zmiana wartości liczbowej na zmienną typu string dla zasobów w magazynie
                textBoxWoodAmount.Text = woodAmount.ToString();
                textBoxStoneAmount.Text = stoneAmount.ToString();
                textBoxCropsAmount.Text = cropsAmount.ToString();
                textBoxSteelAmount.Text = steelAmount.ToString();
            }
        }

        /// <summary>
        /// Funkcja ustawia czas na wyświetlaczu zegara, zwiększa ilość surowców, dokonuje ataków (kradzieży surowców, straty w wojsku)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            //zmienna losowa do generowania czasu napadu i ilości start w kradzieży i zniszczeniach
            Random rand = new Random();

            //odliczanie czas ataku
            attackTime++;
            //podliczanie czasu
            timeCounter++;
            //zwiększenie zmiennej sekundowej
            secondCounter++;
            //odliczanie czasu
            if(secondCounter != 0) 
            {
                //odliczenie minuty
                if (secondCounter % 60 == 0)
                {   
                    //dodaj minute
                    minuteCounter++;
                    //wyzeruj sekundy
                    secondCounter = 0;
                }
                //odliczenie godziny
                if (minuteCounter != 0 && minuteCounter % 60 == 0)
                {
                    //dodaj godzine
                    hourCounter++;
                    //wyzeruj minuty
                    minuteCounter = 0;
                }
            }
            //odświeżenie zawartości textBoxa
            textBoxTime.Text = hourCounter.ToString() +":"+ minuteCounter.ToString() + ":" + secondCounter.ToString();

            //zwiększanie zasobu plonów
            if (timeCounter % (18/garnerLvl) == 0)
            {
                //przypisanie wartosci zasobu do zmiennej
                cropsAmount = Int32.Parse(textBoxCropsAmount.Text);
                //zwiekszenie ilosci zasobu
                cropsAmount++;
                //przypisanie zwiększonej wartosci do textBoxa
                textBoxCropsAmount.Text = cropsAmount.ToString();
            }
            //zwiększanie zasobu drewna
            if (timeCounter % (36 / sawmillLvl) == 0)
            {
                //przypisanie wartosci zasobu do zmiennej
                woodAmount = Int32.Parse(textBoxWoodAmount.Text);
                //zwiekszenie ilosci zasobu
                woodAmount++;
                //przypisanie zwiększonej wartosci do textBoxa
                textBoxWoodAmount.Text = woodAmount.ToString();
            }
            //zwiększanie zasobu kamienia
            if (timeCounter % (54 / quarryLvl) == 0)
            {
                //przypisanie wartosci zasobu do zmiennej
                stoneAmount = Int32.Parse(textBoxStoneAmount.Text);
                //zwiekszenie ilosci zasobu
                stoneAmount++;
                //przypisanie zwiększonej wartosci do textBoxa
                textBoxStoneAmount.Text = stoneAmount.ToString();
            }
            //zwiększanie zasobu stali
            if (timeCounter % (72 / steelMillLvl) == 0)
            {
                //przypisanie wartosci zasobu do zmiennej
                steelAmount = Int32.Parse(textBoxSteelAmount.Text);
                //zwiekszenie ilosci zasobu
                steelAmount++;
                //przypisanie zwiększonej wartosci do textBoxa
                textBoxSteelAmount.Text = steelAmount.ToString();
            }

            //atakowanie na miasto w losowym czasie
            if (timeCounter % rand.Next(550, 600) == 0)
            {
                //wyzerowanie licznika liczącego czas ataku
                attackTime = 0;

                //plądrowanie surowców miasta
                //kradzież drewna, przypisanie wartosci z magazynu (textBox) i usuniecie randomowj ilosci z uwzględnieniem poziomu rozbudowania muru
                woodAmount = Int32.Parse(textBoxWoodAmount.Text) - rand.Next(1,18) / wallLvl;
                if (woodAmount < 0) woodAmount = 0;
                //przypisanie zmniejszonej wartosci do textBoxa
                textBoxWoodAmount.Text = woodAmount.ToString();
                //sygnalizowanie ataku zmianą kolou textBoxa
                textBoxWoodAmount.BackColor = Color.Red;

                //kradzież stali, przypisanie wartosci z magazynu (textBox) i usuniecie randomowj ilosci z uwzględnieniem poziomu rozbudowania muru
                stoneAmount = Int32.Parse(textBoxStoneAmount.Text) - rand.Next(1, 15) / wallLvl;
                if (stoneAmount < 0) stoneAmount = 0;
                //przypisanie zmniejszonej wartosci do textBoxa
                textBoxStoneAmount.Text = stoneAmount.ToString();
                //sygnalizowanie ataku zmianą kolou textBoxa
                textBoxStoneAmount.BackColor = Color.Red;

                //kradzież plonów, przypisanie wartosci z magazynu (textBox) i usuniecie randomowj ilosci z uwzględnieniem poziomu rozbudowania muru
                cropsAmount = Int32.Parse(textBoxCropsAmount.Text) - rand.Next(1, 21) / wallLvl;
                if (cropsAmount < 0) cropsAmount = 0;
                //przypisanie zmniejszonej wartosci do textBoxa
                textBoxCropsAmount.Text = cropsAmount.ToString();
                //sygnalizowanie ataku zmianą kolou textBoxa
                textBoxCropsAmount.BackColor = Color.Red;

                //kradzież stali, przypisanie wartosci z magazynu (textBox) i usuniecie randomowj ilosci z uwzględnieniem poziomu rozbudowania muru
                steelAmount = Int32.Parse(textBoxSteelAmount.Text) - rand.Next(1, 12) / wallLvl;
                if (steelAmount < 0) steelAmount = 0;
                //przypisanie zmniejszonej wartosci do textBoxa
                textBoxSteelAmount.Text = steelAmount.ToString();
                //sygnalizowanie ataku zmianą kolou textBoxa
                textBoxSteelAmount.BackColor = Color.Red;

                //straty w wojsku
                //zniszenia w piechocie, przypisanie wartosci z koszar (textBox) i usuniecie randomowj ilosci z uwzględnieniem poziomu rozbudowania muru
                actualMilitaryAmount = Int32.Parse(textBoxInfantryAmount.Text) - rand.Next(1, 10) / wallLvl;
                if (actualMilitaryAmount < 0) actualMilitaryAmount = 0;
                //przypisanie zmniejszonej wartosci do textBoxa
                textBoxInfantryAmount.Text = actualMilitaryAmount.ToString();
                //sygnalizowanie ataku zmianą kolou textBoxa
                textBoxInfantryAmount.BackColor = Color.Red;

                //zniszczenia wśród łuczników, przypisanie wartosci z koszar (textBox) i usuniecie randomowj ilosci z uwzględnieniem poziomu rozbudowania muru
                actualMilitaryAmount = Int32.Parse(textBoxArcherAmount.Text) - rand.Next(1, 10) / wallLvl;
                if (actualMilitaryAmount < 0) actualMilitaryAmount = 0;
                //przypisanie zmniejszonej wartosci do textBoxa
                textBoxArcherAmount.Text = actualMilitaryAmount.ToString();
                //sygnalizowanie ataku zmianą kolou textBoxa
                textBoxArcherAmount.BackColor = Color.Red;

                //zniszczenia w kawalerii, przypisanie wartosci z koszar (textBox) i usuniecie randomowj ilosci z uwzględnieniem poziomu rozbudowania muru
                actualMilitaryAmount = Int32.Parse(textBoxCavalaryAmount.Text) - rand.Next(1, 5) / wallLvl;
                if (actualMilitaryAmount < 0) actualMilitaryAmount = 0;
                //przypisanie zmniejszonej wartosci do textBoxa
                textBoxCavalaryAmount.Text = actualMilitaryAmount.ToString();
                //sygnalizowanie ataku zmianą kolou textBoxa
                textBoxCavalaryAmount.BackColor = Color.Red;
            }

            //koniec sygnalizacji ataku, przywrócenie kolorów textBoxów
            if(attackTime == 15)
            {
                //zmiana kolou textBoxa drewna
                textBoxWoodAmount.BackColor = Color.BurlyWood;

                //zmiana kolou textBoxa plonów
                textBoxCropsAmount.BackColor = Color.BurlyWood;

                //zmiana kolou textBoxa kamienia
                textBoxStoneAmount.BackColor = Color.BurlyWood;

                //zmiana kolou textBoxa stali
                textBoxSteelAmount.BackColor = Color.BurlyWood;


                //zmiana kolou textBoxa piechoty
                textBoxInfantryAmount.BackColor = Color.BurlyWood;

                //zmiana kolou textBoxa łuczników
                textBoxArcherAmount.BackColor = Color.BurlyWood;

                //zmiana kolou textBoxa kawalerii
                textBoxCavalaryAmount.BackColor = Color.BurlyWood;
            }
        }

    }
}
