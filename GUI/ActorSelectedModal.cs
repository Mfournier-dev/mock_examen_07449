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
    public partial class ActorSelectedModal : Form
    {
        private ActorDTO selectedActor;
        public ActorSelectedModal()
        {
            InitializeComponent();
            this.cbActorSelector.DisplayMember = "ProfessionalName";
            this.cbActorSelector.ValueMember = "Id";
        }

        public void OpenModal(List<ActorDTO> actors) {
            this.DialogResult = DialogResult.None;
            this.cbActorSelector.Items.Clear();

            foreach (ActorDTO actor in actors) {
                this.cbActorSelector.Items.Add(actor);
                }
            this.ShowDialog();
        }

        private void cbActorSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedActor = (ActorDTO) this.cbActorSelector.Items[this.cbActorSelector.SelectedIndex];
        }

        private void BtnSelectActor_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public ActorDTO GetSelectedActor() {
            return this.selectedActor;
        }
    }
}
