namespace mock_examen_07449.GUI
{
    partial class MainWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveActor = new System.Windows.Forms.Button();
            this.btnAddActor = new System.Windows.Forms.Button();
            this.lstMovieActorList = new System.Windows.Forms.ListView();
            this.dtpMovieReleasedDate = new System.Windows.Forms.DateTimePicker();
            this.txtMovieDescription = new System.Windows.Forms.TextBox();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.lblMovieIDField = new System.Windows.Forms.Label();
            this.lblReleasedDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnCreateMovie = new System.Windows.Forms.Button();
            this.cbMovieSelector = new System.Windows.Forms.ComboBox();
            this.lblSelectItem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveActor);
            this.groupBox1.Controls.Add(this.btnAddActor);
            this.groupBox1.Controls.Add(this.lstMovieActorList);
            this.groupBox1.Controls.Add(this.dtpMovieReleasedDate);
            this.groupBox1.Controls.Add(this.txtMovieDescription);
            this.groupBox1.Controls.Add(this.txtMovieTitle);
            this.groupBox1.Controls.Add(this.lblMovieIDField);
            this.groupBox1.Controls.Add(this.lblReleasedDate);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(19, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 365);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails du film";
            // 
            // btnRemoveActor
            // 
            this.btnRemoveActor.Location = new System.Drawing.Point(323, 265);
            this.btnRemoveActor.Name = "btnRemoveActor";
            this.btnRemoveActor.Size = new System.Drawing.Size(110, 23);
            this.btnRemoveActor.TabIndex = 10;
            this.btnRemoveActor.Text = "Retirer Acteur";
            this.btnRemoveActor.UseVisualStyleBackColor = true;
            this.btnRemoveActor.Click += new System.EventHandler(this.btnRemoveActor_Click);
            // 
            // btnAddActor
            // 
            this.btnAddActor.Location = new System.Drawing.Point(138, 265);
            this.btnAddActor.Name = "btnAddActor";
            this.btnAddActor.Size = new System.Drawing.Size(103, 23);
            this.btnAddActor.TabIndex = 9;
            this.btnAddActor.Text = "Ajouter Acteur";
            this.btnAddActor.UseVisualStyleBackColor = true;
            this.btnAddActor.Click += new System.EventHandler(this.btnAddActor_Click);
            // 
            // lstMovieActorList
            // 
            this.lstMovieActorList.Location = new System.Drawing.Point(458, 35);
            this.lstMovieActorList.Name = "lstMovieActorList";
            this.lstMovieActorList.Size = new System.Drawing.Size(206, 253);
            this.lstMovieActorList.TabIndex = 8;
            this.lstMovieActorList.UseCompatibleStateImageBehavior = false;
            this.lstMovieActorList.View = System.Windows.Forms.View.List;
            // 
            // dtpMovieReleasedDate
            // 
            this.dtpMovieReleasedDate.Location = new System.Drawing.Point(157, 186);
            this.dtpMovieReleasedDate.Name = "dtpMovieReleasedDate";
            this.dtpMovieReleasedDate.Size = new System.Drawing.Size(295, 23);
            this.dtpMovieReleasedDate.TabIndex = 7;
            // 
            // txtMovieDescription
            // 
            this.txtMovieDescription.Location = new System.Drawing.Point(157, 109);
            this.txtMovieDescription.Multiline = true;
            this.txtMovieDescription.Name = "txtMovieDescription";
            this.txtMovieDescription.PlaceholderText = "Description";
            this.txtMovieDescription.Size = new System.Drawing.Size(295, 70);
            this.txtMovieDescription.TabIndex = 6;
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(157, 72);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.PlaceholderText = "Titre";
            this.txtMovieTitle.Size = new System.Drawing.Size(295, 23);
            this.txtMovieTitle.TabIndex = 5;
            // 
            // lblMovieIDField
            // 
            this.lblMovieIDField.AutoSize = true;
            this.lblMovieIDField.Location = new System.Drawing.Point(157, 43);
            this.lblMovieIDField.Name = "lblMovieIDField";
            this.lblMovieIDField.Size = new System.Drawing.Size(69, 15);
            this.lblMovieIDField.TabIndex = 4;
            this.lblMovieIDField.Text = "placeholder";
            this.lblMovieIDField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReleasedDate
            // 
            this.lblReleasedDate.Location = new System.Drawing.Point(5, 186);
            this.lblReleasedDate.Name = "lblReleasedDate";
            this.lblReleasedDate.Size = new System.Drawing.Size(136, 23);
            this.lblReleasedDate.TabIndex = 3;
            this.lblReleasedDate.Text = "Date de sortie";
            this.lblReleasedDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(5, 109);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(136, 23);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(5, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Titre:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(5, 39);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(136, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(596, 23);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(87, 23);
            this.btnDeleteMovie.TabIndex = 8;
            this.btnDeleteMovie.Text = "Effacer Film";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnCreateMovie
            // 
            this.btnCreateMovie.Location = new System.Drawing.Point(477, 23);
            this.btnCreateMovie.Name = "btnCreateMovie";
            this.btnCreateMovie.Size = new System.Drawing.Size(87, 23);
            this.btnCreateMovie.TabIndex = 7;
            this.btnCreateMovie.Text = "Créer Film";
            this.btnCreateMovie.UseVisualStyleBackColor = true;
            this.btnCreateMovie.Click += new System.EventHandler(this.btnCreateMovie_Click);
            // 
            // cbMovieSelector
            // 
            this.cbMovieSelector.FormattingEnabled = true;
            this.cbMovieSelector.Location = new System.Drawing.Point(176, 21);
            this.cbMovieSelector.Name = "cbMovieSelector";
            this.cbMovieSelector.Size = new System.Drawing.Size(295, 23);
            this.cbMovieSelector.TabIndex = 6;
            this.cbMovieSelector.SelectedIndexChanged += new System.EventHandler(this.cbMovieSelector_SelectedIndexChanged);
            // 
            // lblSelectItem
            // 
            this.lblSelectItem.AutoSize = true;
            this.lblSelectItem.Location = new System.Drawing.Point(34, 23);
            this.lblSelectItem.Name = "lblSelectItem";
            this.lblSelectItem.Size = new System.Drawing.Size(117, 15);
            this.lblSelectItem.TabIndex = 5;
            this.lblSelectItem.Text = "Sélectionnez un item";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnCreateMovie);
            this.Controls.Add(this.cbMovieSelector);
            this.Controls.Add(this.lblSelectItem);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRemoveActor;
        private Button btnAddActor;
        private ListView lstMovieActorList;
        private DateTimePicker dtpMovieReleasedDate;
        private TextBox txtMovieDescription;
        private TextBox txtMovieTitle;
        private Label lblMovieIDField;
        private Label lblReleasedDate;
        private Label lblDescription;
        private Label lblTitle;
        private Label lblID;
        private Button btnDeleteMovie;
        private Button btnCreateMovie;
        private ComboBox cbMovieSelector;
        private Label lblSelectItem;
    }
}