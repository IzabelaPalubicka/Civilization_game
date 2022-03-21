namespace IzabelaPałubickaLab1ZadDom
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.labelResource = new System.Windows.Forms.Label();
            this.labelWood = new System.Windows.Forms.Label();
            this.textBoxWoodAmount = new System.Windows.Forms.TextBox();
            this.labelStone = new System.Windows.Forms.Label();
            this.textBoxStoneAmount = new System.Windows.Forms.TextBox();
            this.labelCrops = new System.Windows.Forms.Label();
            this.textBoxCropsAmount = new System.Windows.Forms.TextBox();
            this.labelSteel = new System.Windows.Forms.Label();
            this.textBoxSteelAmount = new System.Windows.Forms.TextBox();
            this.labelArmy = new System.Windows.Forms.Label();
            this.labelInfantry = new System.Windows.Forms.Label();
            this.textBoxInfantryAmount = new System.Windows.Forms.TextBox();
            this.labelCavalry = new System.Windows.Forms.Label();
            this.textBoxCavalaryAmount = new System.Windows.Forms.TextBox();
            this.labelArcher = new System.Windows.Forms.Label();
            this.textBoxArcherAmount = new System.Windows.Forms.TextBox();
            this.domainUpDownExchengingFirstResource = new System.Windows.Forms.DomainUpDown();
            this.labelExchangingText = new System.Windows.Forms.Label();
            this.labelOnText = new System.Windows.Forms.Label();
            this.domainUpDownExchengingSecondResource = new System.Windows.Forms.DomainUpDown();
            this.labelExchengingAmount = new System.Windows.Forms.Label();
            this.buttonConfirmExchange = new System.Windows.Forms.Button();
            this.textBoxSecondResourceAmount = new System.Windows.Forms.TextBox();
            this.textBoxFirstResourceAmount = new System.Windows.Forms.TextBox();
            this.domainUpDownBuildingList = new System.Windows.Forms.DomainUpDown();
            this.labelBuildingSteel = new System.Windows.Forms.Label();
            this.labelBuildingCrops = new System.Windows.Forms.Label();
            this.labelBuildingStone = new System.Windows.Forms.Label();
            this.labelBuildingWood = new System.Windows.Forms.Label();
            this.labelBuildingArmySteel = new System.Windows.Forms.Label();
            this.labelBuildingArmyCrops = new System.Windows.Forms.Label();
            this.labelBuildingArmyStone = new System.Windows.Forms.Label();
            this.labelBuildingArmyWood = new System.Windows.Forms.Label();
            this.domainUpDownArmyBuildingList = new System.Windows.Forms.DomainUpDown();
            this.labelBuildingCost = new System.Windows.Forms.Label();
            this.buttonConfirmBuildingTown = new System.Windows.Forms.Button();
            this.labelArmyCost = new System.Windows.Forms.Label();
            this.textBoxAmountWoodForBuilding = new System.Windows.Forms.TextBox();
            this.textBoxAmountStoneForBuilding = new System.Windows.Forms.TextBox();
            this.textBoxAmountCropsForBuilding = new System.Windows.Forms.TextBox();
            this.textBoxAmountSteelForBuilding = new System.Windows.Forms.TextBox();
            this.textBoxAmountWoodForArmy = new System.Windows.Forms.TextBox();
            this.textBoxAmountStoneForArmy = new System.Windows.Forms.TextBox();
            this.textBoxAmountCropsForArmy = new System.Windows.Forms.TextBox();
            this.textBoxAmountSteelForArmy = new System.Windows.Forms.TextBox();
            this.labelArmyAmount = new System.Windows.Forms.Label();
            this.buttonBuildingArmy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxBuildingLvl = new System.Windows.Forms.TextBox();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.groupBoxBuildingArmy = new System.Windows.Forms.GroupBox();
            this.domainUpDownMilitaryAmount = new System.Windows.Forms.DomainUpDown();
            this.groupBoxExchange = new System.Windows.Forms.GroupBox();
            this.domainUpDownExchangingResourceAmount = new System.Windows.Forms.DomainUpDown();
            this.groupBoxMagasineAndBarrack = new System.Windows.Forms.GroupBox();
            this.groupBoxBuildingTown = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxBuildingArmy.SuspendLayout();
            this.groupBoxExchange.SuspendLayout();
            this.groupBoxMagasineAndBarrack.SuspendLayout();
            this.groupBoxBuildingTown.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelResource
            // 
            this.labelResource.AutoSize = true;
            this.labelResource.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResource.Location = new System.Drawing.Point(21, 24);
            this.labelResource.Name = "labelResource";
            this.labelResource.Size = new System.Drawing.Size(97, 24);
            this.labelResource.TabIndex = 0;
            this.labelResource.Text = "Zasoby";
            // 
            // labelWood
            // 
            this.labelWood.AutoSize = true;
            this.labelWood.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWood.Location = new System.Drawing.Point(6, 61);
            this.labelWood.Name = "labelWood";
            this.labelWood.Size = new System.Drawing.Size(77, 25);
            this.labelWood.TabIndex = 1;
            this.labelWood.Text = "Drewno";
            // 
            // textBoxWoodAmount
            // 
            this.textBoxWoodAmount.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxWoodAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWoodAmount.Enabled = false;
            this.textBoxWoodAmount.Location = new System.Drawing.Point(89, 61);
            this.textBoxWoodAmount.Name = "textBoxWoodAmount";
            this.textBoxWoodAmount.Size = new System.Drawing.Size(62, 22);
            this.textBoxWoodAmount.TabIndex = 2;
            this.textBoxWoodAmount.Text = "5";
            // 
            // labelStone
            // 
            this.labelStone.AutoSize = true;
            this.labelStone.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStone.Location = new System.Drawing.Point(169, 58);
            this.labelStone.Name = "labelStone";
            this.labelStone.Size = new System.Drawing.Size(77, 25);
            this.labelStone.TabIndex = 3;
            this.labelStone.Text = "Kamień";
            // 
            // textBoxStoneAmount
            // 
            this.textBoxStoneAmount.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxStoneAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStoneAmount.Enabled = false;
            this.textBoxStoneAmount.Location = new System.Drawing.Point(252, 59);
            this.textBoxStoneAmount.Name = "textBoxStoneAmount";
            this.textBoxStoneAmount.Size = new System.Drawing.Size(62, 22);
            this.textBoxStoneAmount.TabIndex = 4;
            this.textBoxStoneAmount.Text = "5";
            // 
            // labelCrops
            // 
            this.labelCrops.AutoSize = true;
            this.labelCrops.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCrops.Location = new System.Drawing.Point(334, 56);
            this.labelCrops.Name = "labelCrops";
            this.labelCrops.Size = new System.Drawing.Size(59, 25);
            this.labelCrops.TabIndex = 5;
            this.labelCrops.Text = "Plony";
            // 
            // textBoxCropsAmount
            // 
            this.textBoxCropsAmount.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxCropsAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCropsAmount.Enabled = false;
            this.textBoxCropsAmount.Location = new System.Drawing.Point(399, 61);
            this.textBoxCropsAmount.Name = "textBoxCropsAmount";
            this.textBoxCropsAmount.Size = new System.Drawing.Size(60, 22);
            this.textBoxCropsAmount.TabIndex = 6;
            this.textBoxCropsAmount.Text = "5";
            // 
            // labelSteel
            // 
            this.labelSteel.AutoSize = true;
            this.labelSteel.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSteel.Location = new System.Drawing.Point(480, 56);
            this.labelSteel.Name = "labelSteel";
            this.labelSteel.Size = new System.Drawing.Size(45, 25);
            this.labelSteel.TabIndex = 7;
            this.labelSteel.Text = "Stal";
            // 
            // textBoxSteelAmount
            // 
            this.textBoxSteelAmount.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxSteelAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSteelAmount.Enabled = false;
            this.textBoxSteelAmount.Location = new System.Drawing.Point(531, 61);
            this.textBoxSteelAmount.Name = "textBoxSteelAmount";
            this.textBoxSteelAmount.Size = new System.Drawing.Size(64, 22);
            this.textBoxSteelAmount.TabIndex = 8;
            this.textBoxSteelAmount.Text = "5";
            // 
            // labelArmy
            // 
            this.labelArmy.AutoSize = true;
            this.labelArmy.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArmy.Location = new System.Drawing.Point(21, 95);
            this.labelArmy.Name = "labelArmy";
            this.labelArmy.Size = new System.Drawing.Size(98, 24);
            this.labelArmy.TabIndex = 9;
            this.labelArmy.Text = "Wojsko";
            // 
            // labelInfantry
            // 
            this.labelInfantry.AutoSize = true;
            this.labelInfantry.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfantry.Location = new System.Drawing.Point(6, 131);
            this.labelInfantry.Name = "labelInfantry";
            this.labelInfantry.Size = new System.Drawing.Size(86, 25);
            this.labelInfantry.TabIndex = 10;
            this.labelInfantry.Text = "Piechota";
            // 
            // textBoxInfantryAmount
            // 
            this.textBoxInfantryAmount.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxInfantryAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInfantryAmount.Enabled = false;
            this.textBoxInfantryAmount.Location = new System.Drawing.Point(98, 136);
            this.textBoxInfantryAmount.Name = "textBoxInfantryAmount";
            this.textBoxInfantryAmount.Size = new System.Drawing.Size(69, 22);
            this.textBoxInfantryAmount.TabIndex = 11;
            this.textBoxInfantryAmount.Text = "0";
            // 
            // labelCavalry
            // 
            this.labelCavalry.AutoSize = true;
            this.labelCavalry.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCavalry.Location = new System.Drawing.Point(375, 128);
            this.labelCavalry.Name = "labelCavalry";
            this.labelCavalry.Size = new System.Drawing.Size(95, 25);
            this.labelCavalry.TabIndex = 12;
            this.labelCavalry.Text = "Kawaleria";
            // 
            // textBoxCavalaryAmount
            // 
            this.textBoxCavalaryAmount.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxCavalaryAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCavalaryAmount.Enabled = false;
            this.textBoxCavalaryAmount.Location = new System.Drawing.Point(476, 132);
            this.textBoxCavalaryAmount.Name = "textBoxCavalaryAmount";
            this.textBoxCavalaryAmount.Size = new System.Drawing.Size(64, 22);
            this.textBoxCavalaryAmount.TabIndex = 13;
            this.textBoxCavalaryAmount.Text = "0";
            // 
            // labelArcher
            // 
            this.labelArcher.AutoSize = true;
            this.labelArcher.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelArcher.Location = new System.Drawing.Point(188, 131);
            this.labelArcher.Name = "labelArcher";
            this.labelArcher.Size = new System.Drawing.Size(85, 25);
            this.labelArcher.TabIndex = 14;
            this.labelArcher.Text = "Łucznicy";
            // 
            // textBoxArcherAmount
            // 
            this.textBoxArcherAmount.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxArcherAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxArcherAmount.Enabled = false;
            this.textBoxArcherAmount.Location = new System.Drawing.Point(279, 132);
            this.textBoxArcherAmount.Name = "textBoxArcherAmount";
            this.textBoxArcherAmount.Size = new System.Drawing.Size(65, 22);
            this.textBoxArcherAmount.TabIndex = 15;
            this.textBoxArcherAmount.Text = "0";
            // 
            // domainUpDownExchengingFirstResource
            // 
            this.domainUpDownExchengingFirstResource.BackColor = System.Drawing.Color.BurlyWood;
            this.domainUpDownExchengingFirstResource.Font = new System.Drawing.Font("Source Sans Pro", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.domainUpDownExchengingFirstResource.Items.Add("wybierz");
            this.domainUpDownExchengingFirstResource.Items.Add("drewno");
            this.domainUpDownExchengingFirstResource.Items.Add("kamień");
            this.domainUpDownExchengingFirstResource.Items.Add("plony");
            this.domainUpDownExchengingFirstResource.Items.Add("stal");
            this.domainUpDownExchengingFirstResource.Location = new System.Drawing.Point(125, 39);
            this.domainUpDownExchengingFirstResource.Name = "domainUpDownExchengingFirstResource";
            this.domainUpDownExchengingFirstResource.Size = new System.Drawing.Size(151, 24);
            this.domainUpDownExchengingFirstResource.TabIndex = 22;
            this.domainUpDownExchengingFirstResource.Text = "wybierz";
            this.domainUpDownExchengingFirstResource.SelectedItemChanged += new System.EventHandler(this.domainUpDownExchengingFirstResource_SelectedItemChanged);
            // 
            // labelExchangingText
            // 
            this.labelExchangingText.AutoSize = true;
            this.labelExchangingText.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExchangingText.Location = new System.Drawing.Point(3, 34);
            this.labelExchangingText.Name = "labelExchangingText";
            this.labelExchangingText.Size = new System.Drawing.Size(112, 25);
            this.labelExchangingText.TabIndex = 23;
            this.labelExchangingText.Text = "Wymieniam";
            // 
            // labelOnText
            // 
            this.labelOnText.AutoSize = true;
            this.labelOnText.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOnText.Location = new System.Drawing.Point(82, 69);
            this.labelOnText.Name = "labelOnText";
            this.labelOnText.Size = new System.Drawing.Size(33, 25);
            this.labelOnText.TabIndex = 24;
            this.labelOnText.Text = "na";
            // 
            // domainUpDownExchengingSecondResource
            // 
            this.domainUpDownExchengingSecondResource.BackColor = System.Drawing.Color.BurlyWood;
            this.domainUpDownExchengingSecondResource.Font = new System.Drawing.Font("Source Sans Pro", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.domainUpDownExchengingSecondResource.Items.Add("wybierz");
            this.domainUpDownExchengingSecondResource.Items.Add("drewno");
            this.domainUpDownExchengingSecondResource.Items.Add("kamień");
            this.domainUpDownExchengingSecondResource.Items.Add("plony");
            this.domainUpDownExchengingSecondResource.Items.Add("stal");
            this.domainUpDownExchengingSecondResource.Location = new System.Drawing.Point(125, 69);
            this.domainUpDownExchengingSecondResource.Name = "domainUpDownExchengingSecondResource";
            this.domainUpDownExchengingSecondResource.Size = new System.Drawing.Size(151, 24);
            this.domainUpDownExchengingSecondResource.TabIndex = 25;
            this.domainUpDownExchengingSecondResource.Text = "wybierz";
            this.domainUpDownExchengingSecondResource.SelectedItemChanged += new System.EventHandler(this.domainUpDownExchengingFirstResource_SelectedItemChanged);
            // 
            // labelExchengingAmount
            // 
            this.labelExchengingAmount.AutoSize = true;
            this.labelExchengingAmount.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExchengingAmount.Location = new System.Drawing.Point(60, 106);
            this.labelExchengingAmount.Name = "labelExchengingAmount";
            this.labelExchengingAmount.Size = new System.Drawing.Size(55, 25);
            this.labelExchengingAmount.TabIndex = 26;
            this.labelExchengingAmount.Text = "Ilość:";
            // 
            // buttonConfirmExchange
            // 
            this.buttonConfirmExchange.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonConfirmExchange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmExchange.Location = new System.Drawing.Point(231, 110);
            this.buttonConfirmExchange.Name = "buttonConfirmExchange";
            this.buttonConfirmExchange.Size = new System.Drawing.Size(118, 29);
            this.buttonConfirmExchange.TabIndex = 27;
            this.buttonConfirmExchange.Text = "wymień";
            this.buttonConfirmExchange.UseVisualStyleBackColor = false;
            this.buttonConfirmExchange.Click += new System.EventHandler(this.buttonConfirmExchange_Click);
            // 
            // textBoxSecondResourceAmount
            // 
            this.textBoxSecondResourceAmount.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxSecondResourceAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSecondResourceAmount.Enabled = false;
            this.textBoxSecondResourceAmount.Location = new System.Drawing.Point(282, 69);
            this.textBoxSecondResourceAmount.Name = "textBoxSecondResourceAmount";
            this.textBoxSecondResourceAmount.Size = new System.Drawing.Size(70, 22);
            this.textBoxSecondResourceAmount.TabIndex = 28;
            this.textBoxSecondResourceAmount.Text = "0";
            // 
            // textBoxFirstResourceAmount
            // 
            this.textBoxFirstResourceAmount.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxFirstResourceAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstResourceAmount.Enabled = false;
            this.textBoxFirstResourceAmount.Location = new System.Drawing.Point(282, 38);
            this.textBoxFirstResourceAmount.Name = "textBoxFirstResourceAmount";
            this.textBoxFirstResourceAmount.Size = new System.Drawing.Size(70, 22);
            this.textBoxFirstResourceAmount.TabIndex = 29;
            this.textBoxFirstResourceAmount.Text = "0";
            // 
            // domainUpDownBuildingList
            // 
            this.domainUpDownBuildingList.BackColor = System.Drawing.Color.BurlyWood;
            this.domainUpDownBuildingList.Items.Add("wybierz budynek");
            this.domainUpDownBuildingList.Items.Add("tartak");
            this.domainUpDownBuildingList.Items.Add("kamieniołomy");
            this.domainUpDownBuildingList.Items.Add("spichlerz");
            this.domainUpDownBuildingList.Items.Add("huta stali");
            this.domainUpDownBuildingList.Items.Add("mury");
            this.domainUpDownBuildingList.Items.Add("koszary");
            this.domainUpDownBuildingList.Location = new System.Drawing.Point(9, 21);
            this.domainUpDownBuildingList.Name = "domainUpDownBuildingList";
            this.domainUpDownBuildingList.Size = new System.Drawing.Size(199, 22);
            this.domainUpDownBuildingList.TabIndex = 30;
            this.domainUpDownBuildingList.Text = "wybierz budynek";
            this.domainUpDownBuildingList.SelectedItemChanged += new System.EventHandler(this.domainUpDownBuildingList_SelectedItemChanged);
            // 
            // labelBuildingSteel
            // 
            this.labelBuildingSteel.AutoSize = true;
            this.labelBuildingSteel.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuildingSteel.Location = new System.Drawing.Point(25, 213);
            this.labelBuildingSteel.Name = "labelBuildingSteel";
            this.labelBuildingSteel.Size = new System.Drawing.Size(45, 25);
            this.labelBuildingSteel.TabIndex = 37;
            this.labelBuildingSteel.Text = "Stal";
            // 
            // labelBuildingCrops
            // 
            this.labelBuildingCrops.AutoSize = true;
            this.labelBuildingCrops.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuildingCrops.Location = new System.Drawing.Point(25, 177);
            this.labelBuildingCrops.Name = "labelBuildingCrops";
            this.labelBuildingCrops.Size = new System.Drawing.Size(59, 25);
            this.labelBuildingCrops.TabIndex = 35;
            this.labelBuildingCrops.Text = "Plony";
            // 
            // labelBuildingStone
            // 
            this.labelBuildingStone.AutoSize = true;
            this.labelBuildingStone.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuildingStone.Location = new System.Drawing.Point(25, 141);
            this.labelBuildingStone.Name = "labelBuildingStone";
            this.labelBuildingStone.Size = new System.Drawing.Size(77, 25);
            this.labelBuildingStone.TabIndex = 33;
            this.labelBuildingStone.Text = "Kamień";
            // 
            // labelBuildingWood
            // 
            this.labelBuildingWood.AutoSize = true;
            this.labelBuildingWood.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuildingWood.Location = new System.Drawing.Point(25, 105);
            this.labelBuildingWood.Name = "labelBuildingWood";
            this.labelBuildingWood.Size = new System.Drawing.Size(77, 25);
            this.labelBuildingWood.TabIndex = 31;
            this.labelBuildingWood.Text = "Drewno";
            // 
            // labelBuildingArmySteel
            // 
            this.labelBuildingArmySteel.AutoSize = true;
            this.labelBuildingArmySteel.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuildingArmySteel.Location = new System.Drawing.Point(41, 217);
            this.labelBuildingArmySteel.Name = "labelBuildingArmySteel";
            this.labelBuildingArmySteel.Size = new System.Drawing.Size(45, 25);
            this.labelBuildingArmySteel.TabIndex = 41;
            this.labelBuildingArmySteel.Text = "Stal";
            // 
            // labelBuildingArmyCrops
            // 
            this.labelBuildingArmyCrops.AutoSize = true;
            this.labelBuildingArmyCrops.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuildingArmyCrops.Location = new System.Drawing.Point(41, 181);
            this.labelBuildingArmyCrops.Name = "labelBuildingArmyCrops";
            this.labelBuildingArmyCrops.Size = new System.Drawing.Size(59, 25);
            this.labelBuildingArmyCrops.TabIndex = 40;
            this.labelBuildingArmyCrops.Text = "Plony";
            // 
            // labelBuildingArmyStone
            // 
            this.labelBuildingArmyStone.AutoSize = true;
            this.labelBuildingArmyStone.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuildingArmyStone.Location = new System.Drawing.Point(41, 145);
            this.labelBuildingArmyStone.Name = "labelBuildingArmyStone";
            this.labelBuildingArmyStone.Size = new System.Drawing.Size(77, 25);
            this.labelBuildingArmyStone.TabIndex = 39;
            this.labelBuildingArmyStone.Text = "Kamień";
            // 
            // labelBuildingArmyWood
            // 
            this.labelBuildingArmyWood.AutoSize = true;
            this.labelBuildingArmyWood.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuildingArmyWood.Location = new System.Drawing.Point(41, 107);
            this.labelBuildingArmyWood.Name = "labelBuildingArmyWood";
            this.labelBuildingArmyWood.Size = new System.Drawing.Size(77, 25);
            this.labelBuildingArmyWood.TabIndex = 38;
            this.labelBuildingArmyWood.Text = "Drewno";
            // 
            // domainUpDownArmyBuildingList
            // 
            this.domainUpDownArmyBuildingList.BackColor = System.Drawing.Color.BurlyWood;
            this.domainUpDownArmyBuildingList.Items.Add("wybierz");
            this.domainUpDownArmyBuildingList.Items.Add("piechota");
            this.domainUpDownArmyBuildingList.Items.Add("łucznicy");
            this.domainUpDownArmyBuildingList.Items.Add("kawaleria");
            this.domainUpDownArmyBuildingList.Location = new System.Drawing.Point(16, 38);
            this.domainUpDownArmyBuildingList.Name = "domainUpDownArmyBuildingList";
            this.domainUpDownArmyBuildingList.Size = new System.Drawing.Size(221, 22);
            this.domainUpDownArmyBuildingList.TabIndex = 42;
            this.domainUpDownArmyBuildingList.Text = "wybierz";
            this.domainUpDownArmyBuildingList.SelectedItemChanged += new System.EventHandler(this.domainUpDownArmyBuilding_SelectedItemChanged);
            // 
            // labelBuildingCost
            // 
            this.labelBuildingCost.AutoSize = true;
            this.labelBuildingCost.Font = new System.Drawing.Font("Source Sans Pro Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuildingCost.Location = new System.Drawing.Point(4, 68);
            this.labelBuildingCost.Name = "labelBuildingCost";
            this.labelBuildingCost.Size = new System.Drawing.Size(66, 25);
            this.labelBuildingCost.TabIndex = 43;
            this.labelBuildingCost.Text = "Koszt:";
            // 
            // buttonConfirmBuildingTown
            // 
            this.buttonConfirmBuildingTown.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonConfirmBuildingTown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmBuildingTown.Location = new System.Drawing.Point(179, 277);
            this.buttonConfirmBuildingTown.Name = "buttonConfirmBuildingTown";
            this.buttonConfirmBuildingTown.Size = new System.Drawing.Size(75, 30);
            this.buttonConfirmBuildingTown.TabIndex = 44;
            this.buttonConfirmBuildingTown.Text = "buduj";
            this.buttonConfirmBuildingTown.UseVisualStyleBackColor = false;
            this.buttonConfirmBuildingTown.Click += new System.EventHandler(this.buttonConfirmBuildingTown_Click);
            // 
            // labelArmyCost
            // 
            this.labelArmyCost.AutoSize = true;
            this.labelArmyCost.Font = new System.Drawing.Font("Source Sans Pro Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelArmyCost.Location = new System.Drawing.Point(6, 70);
            this.labelArmyCost.Name = "labelArmyCost";
            this.labelArmyCost.Size = new System.Drawing.Size(66, 25);
            this.labelArmyCost.TabIndex = 45;
            this.labelArmyCost.Text = "Koszt:";
            // 
            // textBoxAmountWoodForBuilding
            // 
            this.textBoxAmountWoodForBuilding.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxAmountWoodForBuilding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmountWoodForBuilding.Enabled = false;
            this.textBoxAmountWoodForBuilding.Location = new System.Drawing.Point(146, 105);
            this.textBoxAmountWoodForBuilding.Name = "textBoxAmountWoodForBuilding";
            this.textBoxAmountWoodForBuilding.Size = new System.Drawing.Size(62, 22);
            this.textBoxAmountWoodForBuilding.TabIndex = 46;
            this.textBoxAmountWoodForBuilding.Text = "0";
            // 
            // textBoxAmountStoneForBuilding
            // 
            this.textBoxAmountStoneForBuilding.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxAmountStoneForBuilding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmountStoneForBuilding.Enabled = false;
            this.textBoxAmountStoneForBuilding.Location = new System.Drawing.Point(146, 144);
            this.textBoxAmountStoneForBuilding.Name = "textBoxAmountStoneForBuilding";
            this.textBoxAmountStoneForBuilding.Size = new System.Drawing.Size(62, 22);
            this.textBoxAmountStoneForBuilding.TabIndex = 47;
            this.textBoxAmountStoneForBuilding.Text = "0";
            // 
            // textBoxAmountCropsForBuilding
            // 
            this.textBoxAmountCropsForBuilding.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxAmountCropsForBuilding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmountCropsForBuilding.Enabled = false;
            this.textBoxAmountCropsForBuilding.Location = new System.Drawing.Point(146, 180);
            this.textBoxAmountCropsForBuilding.Name = "textBoxAmountCropsForBuilding";
            this.textBoxAmountCropsForBuilding.Size = new System.Drawing.Size(62, 22);
            this.textBoxAmountCropsForBuilding.TabIndex = 48;
            this.textBoxAmountCropsForBuilding.Text = "0";
            // 
            // textBoxAmountSteelForBuilding
            // 
            this.textBoxAmountSteelForBuilding.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxAmountSteelForBuilding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmountSteelForBuilding.Enabled = false;
            this.textBoxAmountSteelForBuilding.Location = new System.Drawing.Point(145, 216);
            this.textBoxAmountSteelForBuilding.Name = "textBoxAmountSteelForBuilding";
            this.textBoxAmountSteelForBuilding.Size = new System.Drawing.Size(63, 22);
            this.textBoxAmountSteelForBuilding.TabIndex = 49;
            this.textBoxAmountSteelForBuilding.Text = "0";
            // 
            // textBoxAmountWoodForArmy
            // 
            this.textBoxAmountWoodForArmy.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxAmountWoodForArmy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmountWoodForArmy.Enabled = false;
            this.textBoxAmountWoodForArmy.Location = new System.Drawing.Point(161, 109);
            this.textBoxAmountWoodForArmy.Name = "textBoxAmountWoodForArmy";
            this.textBoxAmountWoodForArmy.Size = new System.Drawing.Size(63, 22);
            this.textBoxAmountWoodForArmy.TabIndex = 50;
            this.textBoxAmountWoodForArmy.Text = "0";
            // 
            // textBoxAmountStoneForArmy
            // 
            this.textBoxAmountStoneForArmy.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxAmountStoneForArmy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmountStoneForArmy.Enabled = false;
            this.textBoxAmountStoneForArmy.Location = new System.Drawing.Point(161, 148);
            this.textBoxAmountStoneForArmy.Name = "textBoxAmountStoneForArmy";
            this.textBoxAmountStoneForArmy.Size = new System.Drawing.Size(63, 22);
            this.textBoxAmountStoneForArmy.TabIndex = 51;
            this.textBoxAmountStoneForArmy.Text = "0";
            // 
            // textBoxAmountCropsForArmy
            // 
            this.textBoxAmountCropsForArmy.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxAmountCropsForArmy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmountCropsForArmy.Enabled = false;
            this.textBoxAmountCropsForArmy.Location = new System.Drawing.Point(161, 181);
            this.textBoxAmountCropsForArmy.Name = "textBoxAmountCropsForArmy";
            this.textBoxAmountCropsForArmy.Size = new System.Drawing.Size(63, 22);
            this.textBoxAmountCropsForArmy.TabIndex = 52;
            this.textBoxAmountCropsForArmy.Text = "0";
            // 
            // textBoxAmountSteelForArmy
            // 
            this.textBoxAmountSteelForArmy.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxAmountSteelForArmy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmountSteelForArmy.Enabled = false;
            this.textBoxAmountSteelForArmy.Location = new System.Drawing.Point(162, 214);
            this.textBoxAmountSteelForArmy.Name = "textBoxAmountSteelForArmy";
            this.textBoxAmountSteelForArmy.Size = new System.Drawing.Size(62, 22);
            this.textBoxAmountSteelForArmy.TabIndex = 53;
            this.textBoxAmountSteelForArmy.Text = "0";
            // 
            // labelArmyAmount
            // 
            this.labelArmyAmount.AutoSize = true;
            this.labelArmyAmount.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelArmyAmount.Location = new System.Drawing.Point(5, 251);
            this.labelArmyAmount.Name = "labelArmyAmount";
            this.labelArmyAmount.Size = new System.Drawing.Size(55, 25);
            this.labelArmyAmount.TabIndex = 54;
            this.labelArmyAmount.Text = "Ilość:";
            // 
            // buttonBuildingArmy
            // 
            this.buttonBuildingArmy.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonBuildingArmy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuildingArmy.Location = new System.Drawing.Point(181, 253);
            this.buttonBuildingArmy.Name = "buttonBuildingArmy";
            this.buttonBuildingArmy.Size = new System.Drawing.Size(75, 27);
            this.buttonBuildingArmy.TabIndex = 56;
            this.buttonBuildingArmy.Text = "dodaj";
            this.buttonBuildingArmy.UseVisualStyleBackColor = false;
            this.buttonBuildingArmy.Click += new System.EventHandler(this.buttonBuildingArmy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(280, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 387);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxBuildingLvl
            // 
            this.textBoxBuildingLvl.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxBuildingLvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuildingLvl.Enabled = false;
            this.textBoxBuildingLvl.Location = new System.Drawing.Point(226, 20);
            this.textBoxBuildingLvl.Name = "textBoxBuildingLvl";
            this.textBoxBuildingLvl.Size = new System.Drawing.Size(45, 22);
            this.textBoxBuildingLvl.TabIndex = 58;
            this.textBoxBuildingLvl.Text = "0";
            // 
            // timerCounter
            // 
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(24, 18);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(65, 24);
            this.labelTime.TabIndex = 59;
            this.labelTime.Text = "Czas";
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTime.Enabled = false;
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTime.Location = new System.Drawing.Point(104, 16);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(85, 30);
            this.textBoxTime.TabIndex = 60;
            this.textBoxTime.Text = "00:00:00";
            // 
            // groupBoxBuildingArmy
            // 
            this.groupBoxBuildingArmy.Controls.Add(this.domainUpDownMilitaryAmount);
            this.groupBoxBuildingArmy.Controls.Add(this.domainUpDownArmyBuildingList);
            this.groupBoxBuildingArmy.Controls.Add(this.labelArmyCost);
            this.groupBoxBuildingArmy.Controls.Add(this.labelBuildingArmyWood);
            this.groupBoxBuildingArmy.Controls.Add(this.labelBuildingArmyStone);
            this.groupBoxBuildingArmy.Controls.Add(this.buttonBuildingArmy);
            this.groupBoxBuildingArmy.Controls.Add(this.labelBuildingArmyCrops);
            this.groupBoxBuildingArmy.Controls.Add(this.labelBuildingArmySteel);
            this.groupBoxBuildingArmy.Controls.Add(this.labelArmyAmount);
            this.groupBoxBuildingArmy.Controls.Add(this.textBoxAmountWoodForArmy);
            this.groupBoxBuildingArmy.Controls.Add(this.textBoxAmountSteelForArmy);
            this.groupBoxBuildingArmy.Controls.Add(this.textBoxAmountStoneForArmy);
            this.groupBoxBuildingArmy.Controls.Add(this.textBoxAmountCropsForArmy);
            this.groupBoxBuildingArmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxBuildingArmy.Location = new System.Drawing.Point(12, 76);
            this.groupBoxBuildingArmy.Name = "groupBoxBuildingArmy";
            this.groupBoxBuildingArmy.Size = new System.Drawing.Size(262, 292);
            this.groupBoxBuildingArmy.TabIndex = 61;
            this.groupBoxBuildingArmy.TabStop = false;
            this.groupBoxBuildingArmy.Text = "ROZBUDOWA WOJSKA";
            // 
            // domainUpDownMilitaryAmount
            // 
            this.domainUpDownMilitaryAmount.BackColor = System.Drawing.Color.BurlyWood;
            this.domainUpDownMilitaryAmount.Items.Add("0");
            this.domainUpDownMilitaryAmount.Items.Add("1");
            this.domainUpDownMilitaryAmount.Items.Add("2");
            this.domainUpDownMilitaryAmount.Items.Add("3");
            this.domainUpDownMilitaryAmount.Items.Add("4");
            this.domainUpDownMilitaryAmount.Items.Add("5");
            this.domainUpDownMilitaryAmount.Items.Add("6");
            this.domainUpDownMilitaryAmount.Items.Add("7");
            this.domainUpDownMilitaryAmount.Items.Add("8");
            this.domainUpDownMilitaryAmount.Items.Add("9");
            this.domainUpDownMilitaryAmount.Items.Add("10");
            this.domainUpDownMilitaryAmount.Location = new System.Drawing.Point(84, 253);
            this.domainUpDownMilitaryAmount.Name = "domainUpDownMilitaryAmount";
            this.domainUpDownMilitaryAmount.Size = new System.Drawing.Size(58, 22);
            this.domainUpDownMilitaryAmount.TabIndex = 57;
            this.domainUpDownMilitaryAmount.Text = "0";
            this.domainUpDownMilitaryAmount.SelectedItemChanged += new System.EventHandler(this.domainUpDownArmyBuilding_SelectedItemChanged);
            // 
            // groupBoxExchange
            // 
            this.groupBoxExchange.Controls.Add(this.domainUpDownExchangingResourceAmount);
            this.groupBoxExchange.Controls.Add(this.domainUpDownExchengingFirstResource);
            this.groupBoxExchange.Controls.Add(this.labelExchangingText);
            this.groupBoxExchange.Controls.Add(this.labelOnText);
            this.groupBoxExchange.Controls.Add(this.domainUpDownExchengingSecondResource);
            this.groupBoxExchange.Controls.Add(this.labelExchengingAmount);
            this.groupBoxExchange.Controls.Add(this.buttonConfirmExchange);
            this.groupBoxExchange.Controls.Add(this.textBoxSecondResourceAmount);
            this.groupBoxExchange.Controls.Add(this.textBoxFirstResourceAmount);
            this.groupBoxExchange.Location = new System.Drawing.Point(704, 402);
            this.groupBoxExchange.Name = "groupBoxExchange";
            this.groupBoxExchange.Size = new System.Drawing.Size(384, 153);
            this.groupBoxExchange.TabIndex = 62;
            this.groupBoxExchange.TabStop = false;
            this.groupBoxExchange.Text = "WYMIANA ZASOBÓW";
            // 
            // domainUpDownExchangingResourceAmount
            // 
            this.domainUpDownExchangingResourceAmount.BackColor = System.Drawing.Color.BurlyWood;
            this.domainUpDownExchangingResourceAmount.Items.Add("0");
            this.domainUpDownExchangingResourceAmount.Items.Add("1");
            this.domainUpDownExchangingResourceAmount.Items.Add("2");
            this.domainUpDownExchangingResourceAmount.Items.Add("3");
            this.domainUpDownExchangingResourceAmount.Items.Add("4");
            this.domainUpDownExchangingResourceAmount.Items.Add("5");
            this.domainUpDownExchangingResourceAmount.Items.Add("6");
            this.domainUpDownExchangingResourceAmount.Items.Add("7");
            this.domainUpDownExchangingResourceAmount.Items.Add("8");
            this.domainUpDownExchangingResourceAmount.Items.Add("9");
            this.domainUpDownExchangingResourceAmount.Items.Add("10");
            this.domainUpDownExchangingResourceAmount.Location = new System.Drawing.Point(137, 109);
            this.domainUpDownExchangingResourceAmount.Name = "domainUpDownExchangingResourceAmount";
            this.domainUpDownExchangingResourceAmount.Size = new System.Drawing.Size(57, 22);
            this.domainUpDownExchangingResourceAmount.TabIndex = 30;
            this.domainUpDownExchangingResourceAmount.Text = "0";
            this.domainUpDownExchangingResourceAmount.SelectedItemChanged += new System.EventHandler(this.domainUpDownExchengingFirstResource_SelectedItemChanged);
            // 
            // groupBoxMagasineAndBarrack
            // 
            this.groupBoxMagasineAndBarrack.Controls.Add(this.labelResource);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.labelWood);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.textBoxWoodAmount);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.labelStone);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.textBoxStoneAmount);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.labelCrops);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.textBoxCropsAmount);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.labelSteel);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.textBoxSteelAmount);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.labelArmy);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.labelInfantry);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.textBoxInfantryAmount);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.labelCavalry);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.textBoxCavalaryAmount);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.labelArcher);
            this.groupBoxMagasineAndBarrack.Controls.Add(this.textBoxArcherAmount);
            this.groupBoxMagasineAndBarrack.Location = new System.Drawing.Point(37, 396);
            this.groupBoxMagasineAndBarrack.Name = "groupBoxMagasineAndBarrack";
            this.groupBoxMagasineAndBarrack.Size = new System.Drawing.Size(610, 168);
            this.groupBoxMagasineAndBarrack.TabIndex = 63;
            this.groupBoxMagasineAndBarrack.TabStop = false;
            this.groupBoxMagasineAndBarrack.Text = "MAGAZYN I BARAK";
            // 
            // groupBoxBuildingTown
            // 
            this.groupBoxBuildingTown.Controls.Add(this.domainUpDownBuildingList);
            this.groupBoxBuildingTown.Controls.Add(this.labelBuildingWood);
            this.groupBoxBuildingTown.Controls.Add(this.labelBuildingStone);
            this.groupBoxBuildingTown.Controls.Add(this.labelBuildingCrops);
            this.groupBoxBuildingTown.Controls.Add(this.labelBuildingSteel);
            this.groupBoxBuildingTown.Controls.Add(this.labelBuildingCost);
            this.groupBoxBuildingTown.Controls.Add(this.textBoxBuildingLvl);
            this.groupBoxBuildingTown.Controls.Add(this.buttonConfirmBuildingTown);
            this.groupBoxBuildingTown.Controls.Add(this.textBoxAmountWoodForBuilding);
            this.groupBoxBuildingTown.Controls.Add(this.textBoxAmountStoneForBuilding);
            this.groupBoxBuildingTown.Controls.Add(this.textBoxAmountSteelForBuilding);
            this.groupBoxBuildingTown.Controls.Add(this.textBoxAmountCropsForBuilding);
            this.groupBoxBuildingTown.Location = new System.Drawing.Point(880, 32);
            this.groupBoxBuildingTown.Name = "groupBoxBuildingTown";
            this.groupBoxBuildingTown.Size = new System.Drawing.Size(277, 320);
            this.groupBoxBuildingTown.TabIndex = 64;
            this.groupBoxBuildingTown.TabStop = false;
            this.groupBoxBuildingTown.Text = "ROZBUDOWA MIASTA";
            // 
            // FormGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1163, 567);
            this.Controls.Add(this.groupBoxBuildingTown);
            this.Controls.Add(this.groupBoxMagasineAndBarrack);
            this.Controls.Add(this.groupBoxExchange);
            this.Controls.Add(this.groupBoxBuildingArmy);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormGame";
            this.Text = "Cywilizacja";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxBuildingArmy.ResumeLayout(false);
            this.groupBoxBuildingArmy.PerformLayout();
            this.groupBoxExchange.ResumeLayout(false);
            this.groupBoxExchange.PerformLayout();
            this.groupBoxMagasineAndBarrack.ResumeLayout(false);
            this.groupBoxMagasineAndBarrack.PerformLayout();
            this.groupBoxBuildingTown.ResumeLayout(false);
            this.groupBoxBuildingTown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResource;
        private System.Windows.Forms.Label labelWood;
        private System.Windows.Forms.TextBox textBoxWoodAmount;
        private System.Windows.Forms.Label labelStone;
        private System.Windows.Forms.TextBox textBoxStoneAmount;
        private System.Windows.Forms.Label labelCrops;
        private System.Windows.Forms.TextBox textBoxCropsAmount;
        private System.Windows.Forms.Label labelSteel;
        private System.Windows.Forms.TextBox textBoxSteelAmount;
        private System.Windows.Forms.Label labelArmy;
        private System.Windows.Forms.Label labelInfantry;
        private System.Windows.Forms.TextBox textBoxInfantryAmount;
        private System.Windows.Forms.Label labelCavalry;
        private System.Windows.Forms.TextBox textBoxCavalaryAmount;
        private System.Windows.Forms.Label labelArcher;
        private System.Windows.Forms.TextBox textBoxArcherAmount;
        private System.Windows.Forms.DomainUpDown domainUpDownExchengingFirstResource;
        private System.Windows.Forms.Label labelExchangingText;
        private System.Windows.Forms.Label labelOnText;
        private System.Windows.Forms.DomainUpDown domainUpDownExchengingSecondResource;
        private System.Windows.Forms.Label labelExchengingAmount;
        private System.Windows.Forms.Button buttonConfirmExchange;
        private System.Windows.Forms.TextBox textBoxSecondResourceAmount;
        private System.Windows.Forms.TextBox textBoxFirstResourceAmount;
        private System.Windows.Forms.DomainUpDown domainUpDownBuildingList;
        private System.Windows.Forms.Label labelBuildingSteel;
        private System.Windows.Forms.Label labelBuildingCrops;
        private System.Windows.Forms.Label labelBuildingStone;
        private System.Windows.Forms.Label labelBuildingWood;
        private System.Windows.Forms.Label labelBuildingArmySteel;
        private System.Windows.Forms.Label labelBuildingArmyCrops;
        private System.Windows.Forms.Label labelBuildingArmyStone;
        private System.Windows.Forms.Label labelBuildingArmyWood;
        private System.Windows.Forms.DomainUpDown domainUpDownArmyBuildingList;
        private System.Windows.Forms.Label labelBuildingCost;
        private System.Windows.Forms.Button buttonConfirmBuildingTown;
        private System.Windows.Forms.Label labelArmyCost;
        private System.Windows.Forms.TextBox textBoxAmountWoodForBuilding;
        private System.Windows.Forms.TextBox textBoxAmountStoneForBuilding;
        private System.Windows.Forms.TextBox textBoxAmountCropsForBuilding;
        private System.Windows.Forms.TextBox textBoxAmountSteelForBuilding;
        private System.Windows.Forms.TextBox textBoxAmountWoodForArmy;
        private System.Windows.Forms.TextBox textBoxAmountStoneForArmy;
        private System.Windows.Forms.TextBox textBoxAmountCropsForArmy;
        private System.Windows.Forms.TextBox textBoxAmountSteelForArmy;
        private System.Windows.Forms.Label labelArmyAmount;
        private System.Windows.Forms.Button buttonBuildingArmy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxBuildingLvl;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.GroupBox groupBoxBuildingArmy;
        private System.Windows.Forms.DomainUpDown domainUpDownMilitaryAmount;
        private System.Windows.Forms.GroupBox groupBoxExchange;
        private System.Windows.Forms.DomainUpDown domainUpDownExchangingResourceAmount;
        private System.Windows.Forms.GroupBox groupBoxMagasineAndBarrack;
        private System.Windows.Forms.GroupBox groupBoxBuildingTown;
    }
}