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
    public partial class MainWindow : Form
    {
        private MovieDTO? currentSelectedMovie;
        private CreateMovieModal createdMovieModal;
        private ActorSelectedModal actorSelectModal;
        public MainWindow()
        {
            InitializeComponent();
            this.createdMovieModal = new CreateMovieModal();
            this.actorSelectModal = new ActorSelectedModal();
            this.Init();
        }

        private void Init()
        {
            this.cbMovieSelector.DisplayMember = "Title";
            this.cbMovieSelector.ValueMember = "Id";
            this.LoadMovieSelector(MainService.GetInstance().GetMovieService().GetAllMovies());
        }

        private void btnCreateMovie_Click(object sender, EventArgs e)
        {
            this.createdMovieModal.OpenModal();
            if (this.createdMovieModal.DialogResult == DialogResult.OK) { 
                MovieDTO createdMovie = this.createdMovieModal.GetCreatedMovie();
                this.cbMovieSelector.Items.Add(createdMovie);
                this.cbMovieSelector.SelectedItem = createdMovie;
            }

        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (this.currentSelectedMovie is not null) {
                MainService.GetInstance().GetMovieService().DeleteMovie(this.currentSelectedMovie);
            }
            this.ClearDetailsFields();
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            if (this.currentSelectedMovie is not null) {
                List<ActorDTO> allActors = MainService.GetInstance().GetActorService().GetAllActors();
                List<ActorDTO> actorsInMovie = MainService.GetInstance().GetMovieActorService().GetAllActorsForMovie(this.currentSelectedMovie.Id);
                List<ActorDTO> actorsNotInMovie =  new List<ActorDTO>();

                foreach (ActorDTO actor in allActors) {
                    if (!actorsInMovie.Contains(actor))
                    {
                        actorsNotInMovie.Add(actor);
                    }
                
                }
                this.actorSelectModal.OpenModal(actorsNotInMovie);

                if (this.actorSelectModal.DialogResult == DialogResult.OK) { 
                    ActorDTO selectedActor = this.actorSelectModal.GetSelectedActor();
                    MainService.GetInstance().GetMovieActorService().CreateNewMovieActorsLink(this.currentSelectedMovie.Id, selectedActor.Id);
                    this.AddActorToListView(selectedActor);
                }
            }

        }

        private void btnRemoveActor_Click(object sender, EventArgs e)
        {
            if (this.currentSelectedMovie is not null) {
                List<ActorDTO> actorsInMovie = MainService.GetInstance().GetMovieActorService().GetAllActorsForMovie(this.currentSelectedMovie.Id);
                this.actorSelectModal.OpenModal(actorsInMovie);
                if (this.actorSelectModal.DialogResult == DialogResult.OK)
                {
                    ActorDTO selectedActor = this.actorSelectModal.GetSelectedActor();
                    MainService.GetInstance().GetMovieActorService().DeleteMovieActorLink(this.currentSelectedMovie.Id, selectedActor.Id);
                    this.RemoveActorFromListView(selectedActor);
                }
            }
        }

        private void LoadMovieSelector(List<MovieDTO> movies) {
            this.cbMovieSelector.Items.Clear();
            foreach (MovieDTO movie in movies)
            {
                this.cbMovieSelector.Items.Add(movie);
            }

        }

        private void LoadDetailsFields(MovieDTO movie) { 
            this.lblMovieIDField.Text = movie.Id.ToString();
            this.txtMovieTitle.Text = movie.Title;
            this.txtMovieDescription.Text = movie.Description;
            this.dtpMovieReleasedDate.Value = movie.ReleasedDate;
            List<ActorDTO> actors = MainService.GetInstance().GetMovieActorService().GetAllActorsForMovie(movie.Id);
            foreach (ActorDTO actor in actors) {
                this.AddActorToListView(actor);
            
            }
        }

        private void ClearDetailsFields() {
            this.lblMovieIDField.Text = "";
            this.txtMovieTitle.Text = "";
            this.txtMovieDescription.Text = "";
            this.dtpMovieReleasedDate.Value = DateTime.Now;
            this.lstMovieActorList.Items.Clear();

            //List<ActorDTO> actors = MainService.GetInstance().GetMovieActorService().GetAllActorsForMovie(actors.Id);

        }

        private void AddActorToListView(ActorDTO actor) {
             
            ListViewItem lstItem = new ListViewItem(actor.ProfessionalName);
            lstItem.Tag = actor.Id;
            this.lstMovieActorList.Items.Add(lstItem);
        
        }

        private void RemoveActorFromListView(ActorDTO actor)
        {
            foreach (ListViewItem lstItem in this.lstMovieActorList.Items)
            { 
                if(((int) lstItem.Tag) == actor.Id) {  
                lstItem.Tag = actor.Id;
                this.lstMovieActorList.Items.Add(lstItem);
                }
            }
        }

        private void cbMovieSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentSelectedMovie = (MovieDTO)this.cbMovieSelector.Items[this.cbMovieSelector.SelectedIndex];
            this.LoadDetailsFields(this.currentSelectedMovie);
        }
    }
}
