namespace mock_examen_07449.GUI
{
    partial class ActorSelectedModal
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
            this.BtnSelectActor = new System.Windows.Forms.Button();
            this.cbActorSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnSelectActor
            // 
            this.BtnSelectActor.Location = new System.Drawing.Point(25, 68);
            this.BtnSelectActor.Name = "BtnSelectActor";
            this.BtnSelectActor.Size = new System.Drawing.Size(339, 23);
            this.BtnSelectActor.TabIndex = 1;
            this.BtnSelectActor.Text = "Sélectionner Acteur";
            this.BtnSelectActor.UseVisualStyleBackColor = true;
            this.BtnSelectActor.Click += new System.EventHandler(this.BtnSelectActor_Click);
            // 
            // cbActorSelector
            // 
            this.cbActorSelector.FormattingEnabled = true;
            this.cbActorSelector.Location = new System.Drawing.Point(25, 27);
            this.cbActorSelector.Name = "cbActorSelector";
            this.cbActorSelector.Size = new System.Drawing.Size(339, 23);
            this.cbActorSelector.TabIndex = 2;
            this.cbActorSelector.SelectedIndexChanged += new System.EventHandler(this.cbActorSelector_SelectedIndexChanged);
            // 
            // ActorSelectedModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 106);
            this.Controls.Add(this.cbActorSelector);
            this.Controls.Add(this.BtnSelectActor);
            this.Name = "ActorSelectedModal";
            this.Text = "ActorSelectedModal";
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnSelectActor;
        private ComboBox cbActorSelector;
    }
}