using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using StudyTracker.DataAccess.Models;

namespace StudyTracker
{
    public partial class MainForm : Form
    {
        private readonly IActivityRepository _activityRepo;



        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _activityRepo = serviceProvider.GetRequiredService<IActivityRepository>();

            // Use a separate asynchronous method to initialize the form
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            try
            {
                var activities = await _activityRepo.GetAllActivitiesAsync();
                dataGridView1.DataSource = activities;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var date = dpDate.Value.ToString();
                var hours = txtHours.Text;
                var description = txtDescription.Text;
                var activity = new Activity
                {
                    ActivityDate = Convert.ToDateTime(date),
                    TotalHours = Convert.ToDouble(hours),
                    Description = description
                };
                await _activityRepo.AddActivityAsync(activity);
                RefreshGrid();
                ResetForm();
                MessageBox.Show("Addedd successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ResetForm()
        {
            dpDate.Value = DateTime.Now;
            txtHours.Text = "";
            txtDescription.Text = "";
        }

        private async void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = await _activityRepo.GetAllActivitiesAsync();
            //dataGridView1.Update();
            //dataGridView1.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
