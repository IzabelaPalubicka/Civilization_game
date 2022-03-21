namespace IzabelaPałubickaLab1ZadDom
{
    partial class FormMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.BackColor = System.Drawing.Color.Transparent;
            this.labelMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMenu.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(320, 120);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(284, 79);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "MENU";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(319, 202);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(162, 54);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(319, 275);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(160, 51);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(796, 452);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelMenu);
            this.Name = "FormMenu";
            this.Text = "Cywilizacja - MENU";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
    }
}

