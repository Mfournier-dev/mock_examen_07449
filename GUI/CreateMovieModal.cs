using mock_examen_07449.Business;
using mock_examen_07449.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mock_examen_07449.GUI
{
    public partial class CreateMovieModal : Form
    {

        private MovieDTO createdMovie;

        public CreateMovieModal()
        {
            InitializeComponent();
        }

        public void OpenModal() {
            this.txtMovieTitle.Text = "";
            this.txtMovieDescription.Text = "";
            this.dtpMovieReleasedDate.Value = DateTime.Now;
            this.DialogResult = DialogResult.None;
            this.ShowDialog();
        }

        public MovieDTO GetCreatedMovie() {
            return this.createdMovie;
        }

        private void btnCreateMovie_Click(object sender, EventArgs e)
        {
            this.createdMovie = MainService.GetInstance().GetMovieService().CreateNewMovie(
                this.txtMovieTitle.Text,
                this.dtpMovieReleasedDate.Value,
                this.txtMovieDescription.Text
                );
            this.DialogResult = DialogResult.OK;

        }
    }
}
