namespace mock_examen_07449.GUI
{
    partial class CreateMovieModal
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
            this.dtpMovieReleasedDate = new System.Windows.Forms.DateTimePicker();
            this.txtMovieDescription = new System.Windows.Forms.TextBox();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.lblMovieIDField = new System.Windows.Forms.Label();
            this.lblReleasedDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCreateMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpMovieReleasedDate
            // 
            this.dtpMovieReleasedDate.Location = new System.Drawing.Point(171, 171);
            this.dtpMovieReleasedDate.Name = "dtpMovieReleasedDate";
            this.dtpMovieReleasedDate.Size = new System.Drawing.Size(295, 23);
            this.dtpMovieReleasedDate.TabIndex = 15;
            // 
            // txtMovieDescription
            // 
            this.txtMovieDescription.Location = new System.Drawing.Point(171, 94);
            this.txtMovieDescription.Multiline = true;
            this.txtMovieDescription.Name = "txtMovieDescription";
            this.txtMovieDescription.PlaceholderText = "Description";
            this.txtMovieDescription.Size = new System.Drawing.Size(295, 70);
            this.txtMovieDescription.TabIndex = 14;
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(171, 57);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.PlaceholderText = "Titre";
            this.txtMovieTitle.Size = new System.Drawing.Size(295, 23);
            this.txtMovieTitle.TabIndex = 13;
            // 
            // lblMovieIDField
            // 
            this.lblMovieIDField.AutoSize = true;
            this.lblMovieIDField.Location = new System.Drawing.Point(171, 28);
            this.lblMovieIDField.Name = "lblMovieIDField";
            this.lblMovieIDField.Size = new System.Drawing.Size(69, 15);
            this.lblMovieIDField.TabIndex = 12;
            this.lblMovieIDField.Text = "placeholder";
            this.lblMovieIDField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReleasedDate
            // 
            this.lblReleasedDate.Location = new System.Drawing.Point(19, 171);
            this.lblReleasedDate.Name = "lblReleasedDate";
            this.lblReleasedDate.Size = new System.Drawing.Size(136, 23);
            this.lblReleasedDate.TabIndex = 11;
            this.lblReleasedDate.Text = "Date de sortie";
            this.lblReleasedDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(19, 94);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(136, 23);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(19, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 23);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Titre:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(19, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(136, 23);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCreateMovie
            // 
            this.btnCreateMovie.Location = new System.Drawing.Point(183, 229);
            this.btnCreateMovie.Name = "btnCreateMovie";
            this.btnCreateMovie.Size = new System.Drawing.Size(144, 23);
            this.btnCreateMovie.TabIndex = 16;
            this.btnCreateMovie.Text = "Create";
            this.btnCreateMovie.UseVisualStyleBackColor = true;
            this.btnCreateMovie.Click += new System.EventHandler(this.btnCreateMovie_Click);
            // 
            // CreateMovieModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 291);
            this.Controls.Add(this.btnCreateMovie);
            this.Controls.Add(this.dtpMovieReleasedDate);
            this.Controls.Add(this.txtMovieDescription);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.lblMovieIDField);
            this.Controls.Add(this.lblReleasedDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblID);
            this.Name = "CreateMovieModal";
            this.Text = "CreateMovieModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpMovieReleasedDate;
        private TextBox txtMovieDescription;
        private TextBox txtMovieTitle;
        private Label lblMovieIDField;
        private Label lblReleasedDate;
        private Label lblDescription;
        private Label lblTitle;
        private Label lblID;
        private Button btnCreateMovie;
    }
}